﻿using System;
using QS.DomainModel.Config;
using QS.Services;
using QS.DomainModel.Entity;
using NHibernate;
using System.ComponentModel;
using QS.Tdi;
using QS.Project.Journal.EntitySelector;

namespace QS.Project.Journal
{
	public abstract class SingleEntityJournalViewModelBase<TEntity, TEntityTab , TNode, TFilter> : EntityJournalViewModelBase<TNode, TFilter> , IEntitySelector
		where TEntity : class, IDomainObject, INotifyPropertyChanged, new()
		where TNode : JournalEntityNodeBase<TEntity>
		where TFilter : class, IJournalFilter
		where TEntityTab : class, ITdiTab
	{
		private readonly ICommonServices commonServices;
		public Type EntityType { get; }

		public SingleEntityJournalViewModelBase(TFilter filter, IEntityConfigurationProvider entityConfigurationProvider, ICommonServices commonServices) : base(entityConfigurationProvider, commonServices)
		{
			FilterViewModel = filter ?? throw new ArgumentNullException(nameof(filter));
			this.commonServices = commonServices ?? throw new ArgumentNullException(nameof(commonServices));

			EntityType = typeof(TEntity);
			var config = RegisterEntity(ItemsSourceQueryFunction);
			config.AddDocumentConfiguration("Добавить", CreateDialogFunction, OpenDialogFunction, (node) => node.EntityType == typeof(TEntity)).FinishConfiguration();
			FinishJournalConfiguration();

			if(!EntityConfigs[EntityType].PermissionResult.CanRead) {
				AbortOpening($"Нет прав для просмотра документов типа: {EntityType.GetSubjectName()}", "Невозможно открыть журнал");
			}
		}

		/// <summary>
		/// Функция формирования запроса.
		/// ВАЖНО: Необходимо следить чтобы в запросе не было INNER JOIN с ORDER BY и LIMIT.
		/// Иначе запрос с LIMIT будет выполнятся также медленно как и без него.
		/// В таких случаях необходимо заменять на другой JOIN и условие в WHERE
		/// </summary>
		/// <value>The items source query function.</value>
		protected abstract Func<IQueryOver<TEntity>> ItemsSourceQueryFunction { get; }

		protected abstract Func<TEntityTab> CreateDialogFunction { get; }

		protected abstract Func<TNode, TEntityTab> OpenDialogFunction { get; }

		public bool IsActive => UoW.IsAlive;
	}
}
