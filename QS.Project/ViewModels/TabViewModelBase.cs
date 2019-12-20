﻿using System;
using System.ComponentModel;
using System.Reflection;
using QS.Services;
using QS.Tdi;
using QS.Project.Journal;
using QS.Navigation;

namespace QS.ViewModels
{
	public abstract class TabViewModelBase : ViewModelBase, ITdiTab, IDisposable, IJournalSlidedTab
	{
		protected TabViewModelBase(IInteractiveService interactiveService) : base(interactiveService)
		{
		}

		#region IJournalSlidedTab implementation

		public virtual SliderOption SliderOption { get; set; }

		#endregion IJournalSlidedTab implementation

		#region ITdiTab implementation


		public HandleSwitchIn HandleSwitchIn { get; private set; }
		public HandleSwitchOut HandleSwitchOut { get; private set; }


		private string tabName = string.Empty;

		/// <summary>
		/// Имя вкладки может быть автоматически получено из атрибута DisplayNameAttribute у класса диалога.
		/// </summary>
		public virtual string TabName {
			get {
				if(string.IsNullOrWhiteSpace(tabName)) {
					return GetType().GetCustomAttribute<DisplayNameAttribute>(true)?.DisplayName;
				}
				return tabName;
			}
			set {
				if(tabName == value)
					return;
				tabName = value;
				OnTabNameChanged();
			}
		}


		public ITdiTabParent TabParent {
			get => (ITdiTabParent)NavigationManager;
			set { }
		}

		public bool FailInitialize { get; protected set; }


		public event EventHandler<TdiTabNameChangedEventArgs> TabNameChanged;

		public event EventHandler TabClosed;

		protected void RaiseTabClosed()
		{
			TabClosed?.Invoke(this, EventArgs.Empty);
		}


		public event EventHandler<TdiTabCloseEventArgs> CloseTab;

		public virtual bool CompareHashName(string hashName)
		{
			return GenerateHashName(this.GetType()) == hashName;
		}


		#endregion

		/// <summary>
		/// Отменяет открытие вкладки
		/// </summary>
		/// <param name="message">Сообщение пользователю при отмене открытия</param>
		protected void AbortOpening(string message, string title = "Невозможно открыть вкладку")
		{
			//throw new AbortCreatingPageException(message, title);

			ShowErrorMessage(message, title);
			AbortOpening();
		}


		/// <summary>
		/// Отменяет открытие вкладки
		/// </summary>
		protected void AbortOpening()
		{
			FailInitialize = true;
		}



		public static string GenerateHashName<TTab>() where TTab : TabViewModelBase
		{
			return GenerateHashName(typeof(TTab));
		}

		public static string GenerateHashName(Type tabType)
		{
			if(!typeof(TabViewModelBase).IsAssignableFrom(tabType))
				throw new ArgumentException($"Тип должен наследоваться от {nameof(TabViewModelBase)}", nameof(tabType));

			return string.Format("Tab_{0}", tabType.Name);
		}


		protected virtual void OnTabNameChanged()
		{
			TabNameChanged?.Invoke(this, new TdiTabNameChangedEventArgs(TabName));
		}


		public virtual void Close(bool askSave)
		{
			if(askSave)
				NavigationManager.AskClosePage(NavigationManager.FindPage(this));
			else
				NavigationManager.ForceClosePage(NavigationManager.FindPage(this));
		}


		public void OnTabClosed()
		{
			TabClosed?.Invoke(this, EventArgs.Empty);
		}


		public virtual void Dispose() { }
	}
}
