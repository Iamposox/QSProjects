﻿using System;
using System.Collections.Generic;
using NHibernate;
using NHibernate.Cfg;
using QSTDI;
using Gtk;
using NLog;

namespace QSOrmProject
{
	public static class OrmMain
	{
		private static Logger logger = LogManager.GetCurrentClassLogger();
		public static ISessionFactory Sessions;
		public static List<OrmObjectMaping> ClassMapingList;

		public static void ConfigureOrm(string connectionString ,string[] assemblies)
		{
			var c = new Configuration(); 

			c.Configure();
			c.SetProperty("connection.connection_string", connectionString);

			foreach(string ass in assemblies)
			{
				c.AddAssembly(ass);
			}

			Sessions = c.BuildSessionFactory ();
		}

		public static Type GetDialogType(System.Type objectClass)
		{
			if (ClassMapingList == null)
				throw new NullReferenceException("ORM Модуль не настроен. Нужно создать ClassMapingList.");
			return ClassMapingList.Find(c => c.ObjectClass == objectClass).DialogClass;
		}

		public static OrmObjectMaping GetObjectDiscription(System.Type type)
		{
			return OrmMain.ClassMapingList.Find(m => m.ObjectClass == type);
		}

		public static void NotifyObjectUpdated(object subject)
		{
			System.Type subjectType = NHibernateUtil.GetClass(subject);
			OrmObjectMaping map = ClassMapingList.Find(m => m.ObjectClass == subjectType);
			if (map != null)
				map.RaiseObjectUpdated(subject);
			else
				logger.Warn("В ClassMapingList тип объекта не найден. Поэтому событие обновления не вызвано.");
		}

		public static IOrmDialog FindMyDialog(Widget child)
		{
			if (child.Parent is IOrmDialog)
				return child.Parent as IOrmDialog;
			else if (child.Parent.IsTopLevel)
				return null;
			else
				return FindMyDialog(child.Parent);
		}
	}

	public class OrmObjectMaping
	{
		public System.Type ObjectClass;
		public System.Type DialogClass;
		public string RefColumnMappings;
		public event EventHandler<OrmObjectUpdatedEventArgs> ObjectUpdated;

		public OrmObjectMaping(System.Type objectClass, System.Type dialogClass)
		{
			ObjectClass = objectClass;
			DialogClass = dialogClass;
			RefColumnMappings = String.Empty;
		}

		public OrmObjectMaping(System.Type objectClass, System.Type dialogClass, string columnMaping)
		{
			ObjectClass = objectClass;
			DialogClass = dialogClass;
			RefColumnMappings = columnMaping;
		}

		public void RaiseObjectUpdated(int id)
		{
			if (ObjectUpdated != null)
				ObjectUpdated(this, new OrmObjectUpdatedEventArgs(id));
		}

		public void RaiseObjectUpdated(object subject)
		{
			if (ObjectUpdated != null)
				ObjectUpdated(this, new OrmObjectUpdatedEventArgs(subject));
		}
	}

	public class OrmObjectUpdatedEventArgs : EventArgs
	{
		public int Id { get; private set; }
		public object Subject { get; private set; }

		public OrmObjectUpdatedEventArgs(int id)
		{
			Id = id;
		}

		public OrmObjectUpdatedEventArgs(object subject)
		{
			Subject= subject;
		}
	}

}

