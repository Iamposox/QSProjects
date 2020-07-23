﻿using System;
using System.ServiceModel.Syndication;
using Gtk;
using QS.NewsFeed.ViewModels;
using QS.Utilities;
using QSWidgetLib;

namespace QS.NewsFeed.Views
{
	public class NewsMenuView : MenuItem
	{
		private static NLog.Logger logger = NLog.LogManager.GetCurrentClassLogger();

		private readonly NewsMenuViewModel viewModel;
		Label menuLabel;
		Image newsicon;

		public NewsMenuView (NewsMenuViewModel viewModel)
		{
			this.viewModel = viewModel ?? throw new ArgumentNullException(nameof(viewModel));

			HBox box = new HBox (false, 0);

			menuLabel = new Label ();
			box.Add (menuLabel);

			newsicon = new Image ( new Gdk.Pixbuf(viewModel.MenuIcon));
			newsicon.TooltipText = "Нет непрочитанных новостей.";
			newsicon.Show ();
			box.Add (newsicon);

			this.Add (box);
			this.RightJustified = true;
			this.ShowAll ();
			menuLabel.Visible = false;

			viewModel.PropertyChanged += ViewModel_PropertyChanged;
		}

		void ViewModel_PropertyChanged(object sender1, System.ComponentModel.PropertyChangedEventArgs args)
		{
			if (args.PropertyName == nameof(viewModel.Feed))
				Application.Invoke((sender, e) => UpdateMenu());
			if (args.PropertyName == nameof(viewModel.UnreadNewsCount))
				Application.Invoke((sender, e) => UpdateIcon());
		}

		void OnNewsActivated (object sender, EventArgs e)
		{
			if (sender is MenuItemId<SyndicationItem> menuItem) {
				viewModel.OpenNews(menuItem.ID);
			}
			else
				throw new InvalidCastException("Некорректная привязка события.");

		}

		void UpdateIcon()
		{
			if (viewModel.UnreadNewsCount > 0)
			{
				menuLabel.Markup = String.Format ("<span foreground=\"red\" weight=\"bold\">+{0}</span>", viewModel.UnreadNewsCount);
				menuLabel.TooltipText = NumberToTextRus.FormatCase (viewModel.UnreadNewsCount, "{0} непрочитанная новость", "{0} непрочитанных новости", "{0} непрочитанных новостей");
			}

			menuLabel.Visible = (viewModel.UnreadNewsCount > 0);
			newsicon.Visible = (viewModel.UnreadNewsCount == 0);
		}

		public void UpdateMenu()
		{
			logger.Info("Создаем меню новостей..");
			var newsMenu = new Menu();
			MenuItemId<SyndicationItem> newsItem;
			foreach (var news in viewModel.News) {
				Label itemLabel = new Label();
				if (news.Read)
					itemLabel.Text = news.Item.Title.Text;
				else {
					itemLabel.Markup = String.Format("<b>{0}</b>", news.Item.Title.Text);
				}
				newsItem = new MenuItemId<SyndicationItem>();
				newsItem.Add(itemLabel);
				newsItem.ID = news.Item;
				newsItem.TooltipMarkup = String.Format("<b>{0:D}</b> {1}", news.Item.PublishDate, news.Item.Summary.Text);
				newsItem.Activated += OnNewsActivated;
				newsMenu.Append(newsItem);
			}
			this.Submenu = newsMenu;
			UpdateIcon();
			newsMenu.ShowAll();
			logger.Info("Ок");
		}
	}
}

