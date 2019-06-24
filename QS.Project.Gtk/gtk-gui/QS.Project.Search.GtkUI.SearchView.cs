
// This file has been generated by the GUI designer. Do not modify.
namespace QS.Project.Search.GtkUI
{
	public partial class SearchView
	{
		private global::Gtk.HBox hbox2;

		private global::Gtk.Label label2;

		private global::Gamma.GtkWidgets.yEntry entSearchText;

		private global::Gtk.Button btnClear;

		protected virtual void Build()
		{
			global::Stetic.Gui.Initialize(this);
			// Widget QS.Project.Search.GtkUI.SearchView
			global::Stetic.BinContainer.Attach(this);
			this.Name = "QS.Project.Search.GtkUI.SearchView";
			// Container child QS.Project.Search.GtkUI.SearchView.Gtk.Container+ContainerChild
			this.hbox2 = new global::Gtk.HBox();
			this.hbox2.Name = "hbox2";
			this.hbox2.Spacing = 6;
			// Container child hbox2.Gtk.Box+BoxChild
			this.label2 = new global::Gtk.Label();
			this.label2.Name = "label2";
			this.label2.Xalign = 1F;
			this.label2.LabelProp = global::Mono.Unix.Catalog.GetString("Поиск:");
			this.hbox2.Add(this.label2);
			global::Gtk.Box.BoxChild w1 = ((global::Gtk.Box.BoxChild)(this.hbox2[this.label2]));
			w1.Position = 0;
			w1.Expand = false;
			// Container child hbox2.Gtk.Box+BoxChild
			this.entSearchText = new global::Gamma.GtkWidgets.yEntry();
			this.entSearchText.TooltipMarkup = "Введите фразу для поиска";
			this.entSearchText.CanFocus = true;
			this.entSearchText.Name = "entSearchText";
			this.entSearchText.IsEditable = true;
			this.entSearchText.InvisibleChar = '●';
			this.hbox2.Add(this.entSearchText);
			global::Gtk.Box.BoxChild w2 = ((global::Gtk.Box.BoxChild)(this.hbox2[this.entSearchText]));
			w2.Position = 1;
			// Container child hbox2.Gtk.Box+BoxChild
			this.btnClear = new global::Gtk.Button();
			this.btnClear.TooltipMarkup = "Очистить поисковую фаразу";
			this.btnClear.CanFocus = true;
			this.btnClear.Name = "btnClear";
			this.btnClear.UseUnderline = true;
			global::Gtk.Image w3 = new global::Gtk.Image();
			w3.Pixbuf = global::Stetic.IconLoader.LoadIcon(this, "gtk-clear", global::Gtk.IconSize.Menu);
			this.btnClear.Image = w3;
			this.hbox2.Add(this.btnClear);
			global::Gtk.Box.BoxChild w4 = ((global::Gtk.Box.BoxChild)(this.hbox2[this.btnClear]));
			w4.Position = 2;
			w4.Expand = false;
			w4.Fill = false;
			this.Add(this.hbox2);
			if ((this.Child != null))
			{
				this.Child.ShowAll();
			}
			this.Hide();
			this.entSearchText.WidgetEvent += new global::Gtk.WidgetEventHandler(this.OnEntSearchTextWidgetEvent);
			this.btnClear.Clicked += new global::System.EventHandler(this.OnBtnClearClicked);
		}
	}
}
