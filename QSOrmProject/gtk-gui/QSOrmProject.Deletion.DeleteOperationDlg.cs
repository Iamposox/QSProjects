
// This file has been generated by the GUI designer. Do not modify.
namespace QSOrmProject.Deletion
{
	public partial class DeleteOperationDlg
	{
		private global::Gtk.VBox vbox2;

		private global::Gtk.Label labelOperation;

		private global::Gtk.ProgressBar progressbarOperation;

		private global::Gtk.Button buttonCancel;

		protected virtual void Build()
		{
			global::Stetic.Gui.Initialize(this);
			// Widget QSOrmProject.Deletion.DeleteOperationDlg
			this.Name = "QSOrmProject.Deletion.DeleteOperationDlg";
			this.Title = global::Mono.Unix.Catalog.GetString("Выполняем удаление");
			this.WindowPosition = ((global::Gtk.WindowPosition)(3));
			this.Modal = true;
			this.Gravity = ((global::Gdk.Gravity)(5));
			// Container child QSOrmProject.Deletion.DeleteOperationDlg.Gtk.Container+ContainerChild
			this.vbox2 = new global::Gtk.VBox();
			this.vbox2.Name = "vbox2";
			this.vbox2.Spacing = 6;
			// Container child vbox2.Gtk.Box+BoxChild
			this.labelOperation = new global::Gtk.Label();
			this.labelOperation.Name = "labelOperation";
			this.labelOperation.Xalign = 0F;
			this.labelOperation.LabelProp = global::Mono.Unix.Catalog.GetString("label1");
			this.labelOperation.Ellipsize = ((global::Pango.EllipsizeMode)(3));
			this.vbox2.Add(this.labelOperation);
			global::Gtk.Box.BoxChild w1 = ((global::Gtk.Box.BoxChild)(this.vbox2[this.labelOperation]));
			w1.Position = 0;
			w1.Expand = false;
			w1.Fill = false;
			// Container child vbox2.Gtk.Box+BoxChild
			this.progressbarOperation = new global::Gtk.ProgressBar();
			this.progressbarOperation.Name = "progressbarOperation";
			this.vbox2.Add(this.progressbarOperation);
			global::Gtk.Box.BoxChild w2 = ((global::Gtk.Box.BoxChild)(this.vbox2[this.progressbarOperation]));
			w2.Position = 1;
			w2.Expand = false;
			w2.Fill = false;
			// Container child vbox2.Gtk.Box+BoxChild
			this.buttonCancel = new global::Gtk.Button();
			this.buttonCancel.CanFocus = true;
			this.buttonCancel.Name = "buttonCancel";
			this.buttonCancel.UseStock = true;
			this.buttonCancel.UseUnderline = true;
			this.buttonCancel.Label = "gtk-cancel";
			this.vbox2.Add(this.buttonCancel);
			global::Gtk.Box.BoxChild w3 = ((global::Gtk.Box.BoxChild)(this.vbox2[this.buttonCancel]));
			w3.Position = 2;
			w3.Expand = false;
			w3.Fill = false;
			this.Add(this.vbox2);
			if ((this.Child != null))
			{
				this.Child.ShowAll();
			}
			this.DefaultWidth = 458;
			this.DefaultHeight = 80;
			this.Show();
		}
	}
}
