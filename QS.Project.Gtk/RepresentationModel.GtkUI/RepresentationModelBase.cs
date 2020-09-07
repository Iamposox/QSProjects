﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading;
using Gamma.Binding;
using Gamma.ColumnConfig;
using QS.DomainModel.Entity;
using QS.DomainModel.UoW;

namespace QS.RepresentationModel.GtkUI
{
	/// <summary>
	/// Базовый класс презентационной модели, не используйте его без необходимости. Используйте наследников.
	/// </summary>
	public abstract class RepresentationModelBase<TNode> : PropertyChangedBase
	{
		private static NLog.Logger logger = NLog.LogManager.GetCurrentClassLogger ();

		#region IRepresentationModel implementation

		IUnitOfWork uow;

		public IUnitOfWork UoW {
			get { return uow; }
			set { uow = value; }
		}

		public event EventHandler ItemsListUpdated;

		protected void OnItemsListUpdated()
		{
			if (ItemsListUpdated != null)
				ItemsListUpdated (this, EventArgs.Empty);
		}

		List<TNode> filtredItemsList;

		IList<TNode> itemsList;

		public IList ItemsList {
			get {
				return filtredItemsList ?? itemsList as IList;
			}
		}

		protected void SetItemsSource (IList<TNode> list)
		{
			itemsList = list;

			if (SearchStrings == null || SearchStrings.Length == 0)
				OnItemsListUpdated ();
			else
				OnSearchRefilter ();
		}

		public abstract IColumnsConfig ColumnsConfig { get; }
		public virtual IyTreeModel YTreeModel { get; }

		private IRepresentationFilter representationFilter;

		public IRepresentationFilter RepresentationFilter {
			get { if (representationFilter != null)
					return representationFilter;
				if (CreateRepresentationFilter != null)
					RepresentationFilter = CreateRepresentationFilter();
				return representationFilter;
			}
			protected set { 
				if (representationFilter != null)
					representationFilter.Refiltered -= RepresentationFilter_Refiltered;
				representationFilter = value;
				if (representationFilter != null)
					representationFilter.Refiltered += RepresentationFilter_Refiltered;
			}
		}

		/// <summary>
		/// Функция создания нового фильтра необходима для отложенной загрузки.
		/// </summary>
		/// <value>The create representation filter.</value>
		public Func<IRepresentationFilter> CreateRepresentationFilter { get; set;}

		public virtual IEnumerable<string> SearchFields {
			get {
				foreach (var prop in typeof(TNode).GetProperties ()) {
					var att = prop.GetCustomAttributes (typeof(UseForSearchAttribute), true).FirstOrDefault ();
					if (att != null)
						yield return prop.Name;
				}
			}
		}

		void RepresentationFilter_Refiltered (object sender, EventArgs e)
		{
			UpdateNodes ();
		}

		public abstract void UpdateNodes ();

		public Type NodeType {
			get { return typeof(TNode); }
		}

		#endregion

		#region Косаемо поиска

		public bool SearchFieldsExist{
			get { return SearchFields.Any ();
			}
		}

		public bool CanEntryFastSelect {
			get {
				return typeof(TNode).GetInterface(nameof(INodeWithEntryFastSelect)) != null && SearchFieldsExist;
			}
		}

		string[] searchStrings;

		public string[] SearchStrings {
			get{
				return searchStrings;
			}
			set{
				if (searchStrings != null && value != null && searchStrings.SequenceEqual(value))
					return;

				if (value != null && value.Any(x => String.IsNullOrEmpty(x)))
					searchStrings = value.Where(x => !String.IsNullOrEmpty(x)).ToArray();
				else
					searchStrings = value;

				OnSearchRefilter ();
			}
		}

		public string SearchString{
			get{
				return SearchStrings != null && SearchStrings.Length > 0
					? SearchStrings[0] : String.Empty;
			}
			set{
				SearchStrings = new string[]{ value };
			}
		}

		private PropertyInfo[] searchPropCache;

		protected virtual PropertyInfo[] SearchPropCache {
			get {
				if (searchPropCache != null)
					return searchPropCache;

				searchPropCache = typeof(TNode).GetProperties ()
					.Where (prop => prop.GetCustomAttributes (typeof(UseForSearchAttribute), true).Length > 0)
					.ToArray ();

				return searchPropCache;
			}
		}

		protected void OnSearchRefilter()
		{
			if(searchThread != null && searchThread.IsAlive)
			{
				searchThread.Abort();
				searchThread = null;
			}
				
			if (SearchStrings == null || SearchStrings.Length == 0)
			{
				filtredItemsList = null;
				OnItemsListUpdated ();
			}
			else
			{
				if (itemsList.Count > 100)
				{
					searchThread = new Thread(RefilterList);
					searchThread.Start();
				}
				else
					RefilterList();
			}
		}

		Thread searchThread; 

		void RefilterList()
		{
			var filtredParam = String.Join(", ", SearchStrings.Select(x => String.Format("<{0}>", x)));
			logger.Info("Фильтрация таблицы по {0}...", filtredParam);
			DateTime searchStarted = DateTime.Now;
			var newList = itemsList.AsParallel().Where (SearchFilterFunc).ToList ();
			filtredItemsList = newList;

			var delay = DateTime.Now.Subtract (searchStarted);
			logger.Debug ("Поиск нашел {0} элементов за {1} секунд.", newList.Count, delay.TotalSeconds);
			logger.Info("Ок");
			Gtk.Application.Invoke(delegate {
				OnItemsListUpdated ();
			});
		}

		public bool SearchFilterNodeFunc(object item, string key)
		{
			foreach(var prop in SearchPropCache) {
				string Str = (prop.GetValue(item, null) ?? String.Empty).ToString();
				if(Str.IndexOf(key, StringComparison.CurrentCultureIgnoreCase) > -1) {
					return true;
				}
			}
			return false;
		}

		private bool SearchFilterFunc(TNode item)
		{
			foreach (var searchString in SearchStrings)
			{
				bool found = false;
				foreach (var prop in SearchPropCache)
				{
					string Str = (prop.GetValue(item, null) ?? String.Empty).ToString();
					if (Str.IndexOf(searchString, StringComparison.CurrentCultureIgnoreCase) > -1)
					{
						found = true;
						break;
					}
				}
				if (!found)
					return false;
			}
			return true;
		}

		#endregion
	}
}

