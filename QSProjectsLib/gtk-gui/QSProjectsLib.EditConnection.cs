
// This file has been generated by the GUI designer. Do not modify.
namespace QSProjectsLib
{
	public partial class EditConnection
	{
		private global::Gtk.HBox hbox1;

		private global::Gtk.VBox vbox2;

		private global::Gtk.ScrolledWindow GtkScrolledWindow;

		private global::Gtk.TreeView treeConnections;

		private global::Gtk.HBox hbox3;

		private global::Gtk.Button buttonAdd;

		private global::Gtk.Button buttonDelete;

		private global::Gtk.VBox vbox3;

		private global::Gtk.Table table1;

		private global::Gtk.ComboBox comboConnectionType;

		private global::Gtk.Entry entryBase;

		private global::Gtk.Entry entryName;

		private global::Gtk.Entry entryServer;

		private global::Gtk.Label label1;

		private global::Gtk.Label label2;

		private global::Gtk.Label label4;

		private global::Gtk.Label labelServer;

		private global::Gtk.HSeparator hseparator1;

		private global::Gtk.Label labelTitle;

		private global::Gtk.Table tableAccount;

		private global::Gtk.Entry entryLogin;

		private global::Gtk.Label labelLogin;

		private global::Gtk.Label labelInfo;

		private global::Gtk.HBox hboxCreateBase;

		private global::Gtk.Button buttonCreateBase;

		private global::Gtk.Button buttonHelp;

		private global::Gtk.Button buttonCancel;

		private global::Gtk.Button buttonOk;

		protected virtual void Build()
		{
			global::Stetic.Gui.Initialize(this);
			// Widget QSProjectsLib.EditConnection
			this.Name = "QSProjectsLib.EditConnection";
			this.Title = global::Mono.Unix.Catalog.GetString("Редактор подключений");
			this.WindowPosition = ((global::Gtk.WindowPosition)(4));
			// Internal child QSProjectsLib.EditConnection.VBox
			global::Gtk.VBox w1 = this.VBox;
			w1.Name = "dialog1_VBox";
			w1.BorderWidth = ((uint)(2));
			// Container child dialog1_VBox.Gtk.Box+BoxChild
			this.hbox1 = new global::Gtk.HBox();
			this.hbox1.Name = "hbox1";
			this.hbox1.Spacing = 6;
			// Container child hbox1.Gtk.Box+BoxChild
			this.vbox2 = new global::Gtk.VBox();
			this.vbox2.Name = "vbox2";
			this.vbox2.Spacing = 6;
			// Container child vbox2.Gtk.Box+BoxChild
			this.GtkScrolledWindow = new global::Gtk.ScrolledWindow();
			this.GtkScrolledWindow.Name = "GtkScrolledWindow";
			this.GtkScrolledWindow.ShadowType = ((global::Gtk.ShadowType)(1));
			// Container child GtkScrolledWindow.Gtk.Container+ContainerChild
			this.treeConnections = new global::Gtk.TreeView();
			this.treeConnections.WidthRequest = 150;
			this.treeConnections.HeightRequest = 300;
			this.treeConnections.CanFocus = true;
			this.treeConnections.Name = "treeConnections";
			this.GtkScrolledWindow.Add(this.treeConnections);
			this.vbox2.Add(this.GtkScrolledWindow);
			global::Gtk.Box.BoxChild w3 = ((global::Gtk.Box.BoxChild)(this.vbox2[this.GtkScrolledWindow]));
			w3.Position = 0;
			// Container child vbox2.Gtk.Box+BoxChild
			this.hbox3 = new global::Gtk.HBox();
			this.hbox3.Name = "hbox3";
			this.hbox3.Spacing = 6;
			// Container child hbox3.Gtk.Box+BoxChild
			this.buttonAdd = new global::Gtk.Button();
			this.buttonAdd.CanFocus = true;
			this.buttonAdd.Name = "buttonAdd";
			this.buttonAdd.UseUnderline = true;
			global::Gtk.Image w4 = new global::Gtk.Image();
			w4.Pixbuf = global::Stetic.IconLoader.LoadIcon(this, "gtk-add", global::Gtk.IconSize.Menu);
			this.buttonAdd.Image = w4;
			this.hbox3.Add(this.buttonAdd);
			global::Gtk.Box.BoxChild w5 = ((global::Gtk.Box.BoxChild)(this.hbox3[this.buttonAdd]));
			w5.Position = 0;
			// Container child hbox3.Gtk.Box+BoxChild
			this.buttonDelete = new global::Gtk.Button();
			this.buttonDelete.CanFocus = true;
			this.buttonDelete.Name = "buttonDelete";
			this.buttonDelete.UseUnderline = true;
			global::Gtk.Image w6 = new global::Gtk.Image();
			w6.Pixbuf = global::Stetic.IconLoader.LoadIcon(this, "gtk-delete", global::Gtk.IconSize.Menu);
			this.buttonDelete.Image = w6;
			this.hbox3.Add(this.buttonDelete);
			global::Gtk.Box.BoxChild w7 = ((global::Gtk.Box.BoxChild)(this.hbox3[this.buttonDelete]));
			w7.Position = 1;
			this.vbox2.Add(this.hbox3);
			global::Gtk.Box.BoxChild w8 = ((global::Gtk.Box.BoxChild)(this.vbox2[this.hbox3]));
			w8.Position = 1;
			w8.Expand = false;
			this.hbox1.Add(this.vbox2);
			global::Gtk.Box.BoxChild w9 = ((global::Gtk.Box.BoxChild)(this.hbox1[this.vbox2]));
			w9.Position = 0;
			// Container child hbox1.Gtk.Box+BoxChild
			this.vbox3 = new global::Gtk.VBox();
			this.vbox3.Name = "vbox3";
			this.vbox3.Spacing = 6;
			// Container child vbox3.Gtk.Box+BoxChild
			this.table1 = new global::Gtk.Table(((uint)(4)), ((uint)(2)), false);
			this.table1.Name = "table1";
			this.table1.RowSpacing = ((uint)(6));
			this.table1.ColumnSpacing = ((uint)(6));
			// Container child table1.Gtk.Table+TableChild
			this.comboConnectionType = global::Gtk.ComboBox.NewText();
			this.comboConnectionType.AppendText(global::Mono.Unix.Catalog.GetString("Сервер MySQL"));
			this.comboConnectionType.AppendText(global::Mono.Unix.Catalog.GetString("Облако Quality Solution"));
			this.comboConnectionType.Name = "comboConnectionType";
			this.comboConnectionType.Active = 0;
			this.table1.Add(this.comboConnectionType);
			global::Gtk.Table.TableChild w10 = ((global::Gtk.Table.TableChild)(this.table1[this.comboConnectionType]));
			w10.LeftAttach = ((uint)(1));
			w10.RightAttach = ((uint)(2));
			w10.XOptions = ((global::Gtk.AttachOptions)(4));
			w10.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.entryBase = new global::Gtk.Entry();
			this.entryBase.CanFocus = true;
			this.entryBase.Name = "entryBase";
			this.entryBase.IsEditable = true;
			this.entryBase.InvisibleChar = '●';
			this.table1.Add(this.entryBase);
			global::Gtk.Table.TableChild w11 = ((global::Gtk.Table.TableChild)(this.table1[this.entryBase]));
			w11.TopAttach = ((uint)(3));
			w11.BottomAttach = ((uint)(4));
			w11.LeftAttach = ((uint)(1));
			w11.RightAttach = ((uint)(2));
			w11.XOptions = ((global::Gtk.AttachOptions)(4));
			w11.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.entryName = new global::Gtk.Entry();
			this.entryName.CanFocus = true;
			this.entryName.Name = "entryName";
			this.entryName.IsEditable = true;
			this.entryName.InvisibleChar = '●';
			this.table1.Add(this.entryName);
			global::Gtk.Table.TableChild w12 = ((global::Gtk.Table.TableChild)(this.table1[this.entryName]));
			w12.TopAttach = ((uint)(1));
			w12.BottomAttach = ((uint)(2));
			w12.LeftAttach = ((uint)(1));
			w12.RightAttach = ((uint)(2));
			w12.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.entryServer = new global::Gtk.Entry();
			this.entryServer.CanFocus = true;
			this.entryServer.Name = "entryServer";
			this.entryServer.IsEditable = true;
			this.entryServer.InvisibleChar = '●';
			this.table1.Add(this.entryServer);
			global::Gtk.Table.TableChild w13 = ((global::Gtk.Table.TableChild)(this.table1[this.entryServer]));
			w13.TopAttach = ((uint)(2));
			w13.BottomAttach = ((uint)(3));
			w13.LeftAttach = ((uint)(1));
			w13.RightAttach = ((uint)(2));
			w13.XOptions = ((global::Gtk.AttachOptions)(4));
			w13.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.label1 = new global::Gtk.Label();
			this.label1.Name = "label1";
			this.label1.Xalign = 1F;
			this.label1.LabelProp = global::Mono.Unix.Catalog.GetString("Тип подключения:");
			this.table1.Add(this.label1);
			global::Gtk.Table.TableChild w14 = ((global::Gtk.Table.TableChild)(this.table1[this.label1]));
			w14.XOptions = ((global::Gtk.AttachOptions)(4));
			w14.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.label2 = new global::Gtk.Label();
			this.label2.Name = "label2";
			this.label2.Xalign = 1F;
			this.label2.LabelProp = global::Mono.Unix.Catalog.GetString("Название подключения:");
			this.table1.Add(this.label2);
			global::Gtk.Table.TableChild w15 = ((global::Gtk.Table.TableChild)(this.table1[this.label2]));
			w15.TopAttach = ((uint)(1));
			w15.BottomAttach = ((uint)(2));
			w15.XOptions = ((global::Gtk.AttachOptions)(4));
			w15.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.label4 = new global::Gtk.Label();
			this.label4.Name = "label4";
			this.label4.Xalign = 1F;
			this.label4.LabelProp = global::Mono.Unix.Catalog.GetString("Название базы:");
			this.table1.Add(this.label4);
			global::Gtk.Table.TableChild w16 = ((global::Gtk.Table.TableChild)(this.table1[this.label4]));
			w16.TopAttach = ((uint)(3));
			w16.BottomAttach = ((uint)(4));
			w16.XOptions = ((global::Gtk.AttachOptions)(4));
			w16.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.labelServer = new global::Gtk.Label();
			this.labelServer.Name = "labelServer";
			this.labelServer.Xalign = 1F;
			this.labelServer.LabelProp = global::Mono.Unix.Catalog.GetString("Сервер:");
			this.table1.Add(this.labelServer);
			global::Gtk.Table.TableChild w17 = ((global::Gtk.Table.TableChild)(this.table1[this.labelServer]));
			w17.TopAttach = ((uint)(2));
			w17.BottomAttach = ((uint)(3));
			w17.XOptions = ((global::Gtk.AttachOptions)(4));
			w17.YOptions = ((global::Gtk.AttachOptions)(4));
			this.vbox3.Add(this.table1);
			global::Gtk.Box.BoxChild w18 = ((global::Gtk.Box.BoxChild)(this.vbox3[this.table1]));
			w18.Position = 0;
			w18.Expand = false;
			w18.Fill = false;
			// Container child vbox3.Gtk.Box+BoxChild
			this.hseparator1 = new global::Gtk.HSeparator();
			this.hseparator1.Name = "hseparator1";
			this.vbox3.Add(this.hseparator1);
			global::Gtk.Box.BoxChild w19 = ((global::Gtk.Box.BoxChild)(this.vbox3[this.hseparator1]));
			w19.Position = 1;
			w19.Expand = false;
			w19.Fill = false;
			// Container child vbox3.Gtk.Box+BoxChild
			this.labelTitle = new global::Gtk.Label();
			this.labelTitle.Name = "labelTitle";
			this.labelTitle.LabelProp = global::Mono.Unix.Catalog.GetString("Учетная запись Quality Solution");
			this.vbox3.Add(this.labelTitle);
			global::Gtk.Box.BoxChild w20 = ((global::Gtk.Box.BoxChild)(this.vbox3[this.labelTitle]));
			w20.Position = 2;
			w20.Expand = false;
			w20.Fill = false;
			// Container child vbox3.Gtk.Box+BoxChild
			this.tableAccount = new global::Gtk.Table(((uint)(1)), ((uint)(2)), false);
			this.tableAccount.Name = "tableAccount";
			this.tableAccount.RowSpacing = ((uint)(6));
			this.tableAccount.ColumnSpacing = ((uint)(6));
			// Container child tableAccount.Gtk.Table+TableChild
			this.entryLogin = new global::Gtk.Entry();
			this.entryLogin.CanFocus = true;
			this.entryLogin.Name = "entryLogin";
			this.entryLogin.IsEditable = true;
			this.entryLogin.InvisibleChar = '●';
			this.tableAccount.Add(this.entryLogin);
			global::Gtk.Table.TableChild w21 = ((global::Gtk.Table.TableChild)(this.tableAccount[this.entryLogin]));
			w21.LeftAttach = ((uint)(1));
			w21.RightAttach = ((uint)(2));
			w21.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child tableAccount.Gtk.Table+TableChild
			this.labelLogin = new global::Gtk.Label();
			this.labelLogin.Name = "labelLogin";
			this.labelLogin.LabelProp = global::Mono.Unix.Catalog.GetString("Логин:");
			this.tableAccount.Add(this.labelLogin);
			global::Gtk.Table.TableChild w22 = ((global::Gtk.Table.TableChild)(this.tableAccount[this.labelLogin]));
			w22.XOptions = ((global::Gtk.AttachOptions)(4));
			w22.YOptions = ((global::Gtk.AttachOptions)(4));
			this.vbox3.Add(this.tableAccount);
			global::Gtk.Box.BoxChild w23 = ((global::Gtk.Box.BoxChild)(this.vbox3[this.tableAccount]));
			w23.Position = 3;
			w23.Expand = false;
			w23.Fill = false;
			// Container child vbox3.Gtk.Box+BoxChild
			this.labelInfo = new global::Gtk.Label();
			this.labelInfo.Name = "labelInfo";
			this.vbox3.Add(this.labelInfo);
			global::Gtk.Box.BoxChild w24 = ((global::Gtk.Box.BoxChild)(this.vbox3[this.labelInfo]));
			w24.Position = 4;
			w24.Expand = false;
			w24.Fill = false;
			// Container child vbox3.Gtk.Box+BoxChild
			this.hboxCreateBase = new global::Gtk.HBox();
			this.hboxCreateBase.Name = "hboxCreateBase";
			this.hboxCreateBase.Spacing = 6;
			// Container child hboxCreateBase.Gtk.Box+BoxChild
			this.buttonCreateBase = new global::Gtk.Button();
			this.buttonCreateBase.Sensitive = false;
			this.buttonCreateBase.CanFocus = true;
			this.buttonCreateBase.Name = "buttonCreateBase";
			this.buttonCreateBase.UseUnderline = true;
			this.buttonCreateBase.Label = global::Mono.Unix.Catalog.GetString("Создать базу на сервере...");
			this.hboxCreateBase.Add(this.buttonCreateBase);
			global::Gtk.Box.BoxChild w25 = ((global::Gtk.Box.BoxChild)(this.hboxCreateBase[this.buttonCreateBase]));
			w25.Position = 0;
			// Container child hboxCreateBase.Gtk.Box+BoxChild
			this.buttonHelp = new global::Gtk.Button();
			this.buttonHelp.CanFocus = true;
			this.buttonHelp.Name = "buttonHelp";
			this.buttonHelp.UseUnderline = true;
			this.buttonHelp.Relief = ((global::Gtk.ReliefStyle)(2));
			global::Gtk.Image w26 = new global::Gtk.Image();
			w26.Pixbuf = global::Stetic.IconLoader.LoadIcon(this, "stock_help", global::Gtk.IconSize.Button);
			this.buttonHelp.Image = w26;
			this.hboxCreateBase.Add(this.buttonHelp);
			global::Gtk.Box.BoxChild w27 = ((global::Gtk.Box.BoxChild)(this.hboxCreateBase[this.buttonHelp]));
			w27.Position = 1;
			w27.Expand = false;
			w27.Fill = false;
			this.vbox3.Add(this.hboxCreateBase);
			global::Gtk.Box.BoxChild w28 = ((global::Gtk.Box.BoxChild)(this.vbox3[this.hboxCreateBase]));
			w28.Position = 5;
			w28.Expand = false;
			w28.Fill = false;
			this.hbox1.Add(this.vbox3);
			global::Gtk.Box.BoxChild w29 = ((global::Gtk.Box.BoxChild)(this.hbox1[this.vbox3]));
			w29.Position = 1;
			w29.Padding = ((uint)(20));
			w1.Add(this.hbox1);
			global::Gtk.Box.BoxChild w30 = ((global::Gtk.Box.BoxChild)(w1[this.hbox1]));
			w30.Position = 0;
			// Internal child QSProjectsLib.EditConnection.ActionArea
			global::Gtk.HButtonBox w31 = this.ActionArea;
			w31.Name = "dialog1_ActionArea";
			w31.Spacing = 10;
			w31.BorderWidth = ((uint)(5));
			w31.LayoutStyle = ((global::Gtk.ButtonBoxStyle)(4));
			// Container child dialog1_ActionArea.Gtk.ButtonBox+ButtonBoxChild
			this.buttonCancel = new global::Gtk.Button();
			this.buttonCancel.CanDefault = true;
			this.buttonCancel.CanFocus = true;
			this.buttonCancel.Name = "buttonCancel";
			this.buttonCancel.UseUnderline = true;
			this.buttonCancel.Label = global::Mono.Unix.Catalog.GetString("Отменить");
			global::Gtk.Image w32 = new global::Gtk.Image();
			w32.Pixbuf = global::Stetic.IconLoader.LoadIcon(this, "gtk-cancel", global::Gtk.IconSize.Menu);
			this.buttonCancel.Image = w32;
			this.AddActionWidget(this.buttonCancel, -6);
			global::Gtk.ButtonBox.ButtonBoxChild w33 = ((global::Gtk.ButtonBox.ButtonBoxChild)(w31[this.buttonCancel]));
			w33.Expand = false;
			w33.Fill = false;
			// Container child dialog1_ActionArea.Gtk.ButtonBox+ButtonBoxChild
			this.buttonOk = new global::Gtk.Button();
			this.buttonOk.CanDefault = true;
			this.buttonOk.CanFocus = true;
			this.buttonOk.Name = "buttonOk";
			this.buttonOk.UseUnderline = true;
			this.buttonOk.Label = global::Mono.Unix.Catalog.GetString("ОК");
			global::Gtk.Image w34 = new global::Gtk.Image();
			w34.Pixbuf = global::Stetic.IconLoader.LoadIcon(this, "gtk-apply", global::Gtk.IconSize.Menu);
			this.buttonOk.Image = w34;
			w31.Add(this.buttonOk);
			global::Gtk.ButtonBox.ButtonBoxChild w35 = ((global::Gtk.ButtonBox.ButtonBoxChild)(w31[this.buttonOk]));
			w35.Position = 1;
			w35.Expand = false;
			w35.Fill = false;
			if ((this.Child != null))
			{
				this.Child.ShowAll();
			}
			this.DefaultWidth = 562;
			this.DefaultHeight = 407;
			this.Show();
			this.treeConnections.RowActivated += new global::Gtk.RowActivatedHandler(this.OnTreeviewConnectionsRowActivated);
			this.buttonAdd.Clicked += new global::System.EventHandler(this.OnButtonAddClicked);
			this.buttonDelete.Clicked += new global::System.EventHandler(this.OnButtonDeleteClicked);
			this.entryServer.TextInserted += new global::Gtk.TextInsertedHandler(this.OnEntryServerTextInserted);
			this.entryServer.TextDeleted += new global::Gtk.TextDeletedHandler(this.OnEntryServerTextDeleted);
			this.entryServer.FocusInEvent += new global::Gtk.FocusInEventHandler(this.OnEntryServerFocusInEvent);
			this.entryServer.FocusOutEvent += new global::Gtk.FocusOutEventHandler(this.OnEntryServerFocusOutEvent);
			this.entryName.Changed += new global::System.EventHandler(this.OnEntryNameChanged);
			this.comboConnectionType.Changed += new global::System.EventHandler(this.OnComboConnectionTypeChanged);
			this.buttonCreateBase.Clicked += new global::System.EventHandler(this.OnButtonCreateBaseClicked);
			this.buttonHelp.Clicked += new global::System.EventHandler(this.OnButtonHelpClicked);
			this.buttonOk.Clicked += new global::System.EventHandler(this.OnButtonOkClicked);
		}
	}
}
