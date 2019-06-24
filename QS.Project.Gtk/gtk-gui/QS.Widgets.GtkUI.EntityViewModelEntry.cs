
// This file has been generated by the GUI designer. Do not modify.
namespace QS.Widgets.GtkUI
{
	public partial class EntityViewModelEntry
	{
		private global::Gtk.HBox hbox1;

		private global::Gtk.Entry entryObject;

		private global::Gtk.Button buttonClear;

		private global::Gtk.Button buttonSelectEntity;

		private global::Gtk.Button buttonViewEntity;

		protected virtual void Build()
		{
			global::Stetic.Gui.Initialize(this);
			// Widget QS.Widgets.GtkUI.EntityViewModelEntry
			global::Stetic.BinContainer.Attach(this);
			this.Name = "QS.Widgets.GtkUI.EntityViewModelEntry";
			// Container child QS.Widgets.GtkUI.EntityViewModelEntry.Gtk.Container+ContainerChild
			this.hbox1 = new global::Gtk.HBox();
			this.hbox1.Name = "hbox1";
			this.hbox1.Spacing = 6;
			// Container child hbox1.Gtk.Box+BoxChild
			this.entryObject = new global::Gtk.Entry();
			this.entryObject.CanFocus = true;
			this.entryObject.Name = "entryObject";
			this.entryObject.IsEditable = false;
			this.entryObject.InvisibleChar = '●';
			this.hbox1.Add(this.entryObject);
			global::Gtk.Box.BoxChild w1 = ((global::Gtk.Box.BoxChild)(this.hbox1[this.entryObject]));
			w1.Position = 0;
			// Container child hbox1.Gtk.Box+BoxChild
			this.buttonClear = new global::Gtk.Button();
			this.buttonClear.CanFocus = true;
			this.buttonClear.Name = "buttonClear";
			this.buttonClear.UseUnderline = true;
			global::Gtk.Image w2 = new global::Gtk.Image();
			w2.Pixbuf = global::Stetic.IconLoader.LoadIcon(this, "gtk-clear", global::Gtk.IconSize.Menu);
			this.buttonClear.Image = w2;
			this.hbox1.Add(this.buttonClear);
			global::Gtk.Box.BoxChild w3 = ((global::Gtk.Box.BoxChild)(this.hbox1[this.buttonClear]));
			w3.Position = 1;
			w3.Expand = false;
			w3.Fill = false;
			// Container child hbox1.Gtk.Box+BoxChild
			this.buttonSelectEntity = new global::Gtk.Button();
			this.buttonSelectEntity.TooltipMarkup = "Выбрать из справочника";
			this.buttonSelectEntity.CanFocus = true;
			this.buttonSelectEntity.Name = "buttonSelectEntity";
			this.buttonSelectEntity.UseUnderline = true;
			global::Gtk.Image w4 = new global::Gtk.Image();
			w4.Pixbuf = global::Stetic.IconLoader.LoadIcon(this, "gtk-index", global::Gtk.IconSize.Menu);
			this.buttonSelectEntity.Image = w4;
			this.hbox1.Add(this.buttonSelectEntity);
			global::Gtk.Box.BoxChild w5 = ((global::Gtk.Box.BoxChild)(this.hbox1[this.buttonSelectEntity]));
			w5.Position = 2;
			w5.Expand = false;
			w5.Fill = false;
			// Container child hbox1.Gtk.Box+BoxChild
			this.buttonViewEntity = new global::Gtk.Button();
			this.buttonViewEntity.TooltipMarkup = "Открыть";
			this.buttonViewEntity.Sensitive = false;
			this.buttonViewEntity.CanFocus = true;
			this.buttonViewEntity.Name = "buttonViewEntity";
			this.buttonViewEntity.UseUnderline = true;
			global::Gtk.Image w6 = new global::Gtk.Image();
			w6.Pixbuf = global::Stetic.IconLoader.LoadIcon(this, "gtk-edit", global::Gtk.IconSize.Menu);
			this.buttonViewEntity.Image = w6;
			this.hbox1.Add(this.buttonViewEntity);
			global::Gtk.Box.BoxChild w7 = ((global::Gtk.Box.BoxChild)(this.hbox1[this.buttonViewEntity]));
			w7.Position = 3;
			w7.Expand = false;
			w7.Fill = false;
			this.Add(this.hbox1);
			if ((this.Child != null))
			{
				this.Child.ShowAll();
			}
			this.Hide();
			this.entryObject.KeyPressEvent += new global::Gtk.KeyPressEventHandler(this.OnEntryObjectKeyPressEvent);
			this.entryObject.Changed += new global::System.EventHandler(this.OnEntryObjectChanged);
			this.entryObject.FocusOutEvent += new global::Gtk.FocusOutEventHandler(this.OnEntryObjectFocusOutEvent);
			this.buttonClear.Clicked += new global::System.EventHandler(this.OnButtonClearClicked);
			this.buttonSelectEntity.Clicked += new global::System.EventHandler(this.OnButtonSelectEntityClicked);
			this.buttonViewEntity.Clicked += new global::System.EventHandler(this.OnButtonViewEntityClicked);
		}
	}
}
