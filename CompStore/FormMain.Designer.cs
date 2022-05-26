
namespace CompStore
{
    partial class FormMain
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.TreeNode treeNode17 = new System.Windows.Forms.TreeNode("Филиалы", 5, 5);
            System.Windows.Forms.TreeNode treeNode18 = new System.Windows.Forms.TreeNode("Здания", 3, 3);
            System.Windows.Forms.TreeNode treeNode19 = new System.Windows.Forms.TreeNode("Помещения", 6, 6);
            System.Windows.Forms.TreeNode treeNode20 = new System.Windows.Forms.TreeNode("Подразделения", 7, 7);
            System.Windows.Forms.TreeNode treeNode21 = new System.Windows.Forms.TreeNode("Должности", 8, 8);
            System.Windows.Forms.TreeNode treeNode22 = new System.Windows.Forms.TreeNode("Сотрудники", 2, 2);
            System.Windows.Forms.TreeNode treeNode23 = new System.Windows.Forms.TreeNode("Предприятие", 4, 4, new System.Windows.Forms.TreeNode[] {
            treeNode17,
            treeNode18,
            treeNode19,
            treeNode20,
            treeNode21,
            treeNode22});
            System.Windows.Forms.TreeNode treeNode24 = new System.Windows.Forms.TreeNode("Перемещения", 1, 1);
            System.Windows.Forms.TreeNode treeNode25 = new System.Windows.Forms.TreeNode("Обслуживания", 11, 11);
            System.Windows.Forms.TreeNode treeNode26 = new System.Windows.Forms.TreeNode("Оборудование", 0, 0, new System.Windows.Forms.TreeNode[] {
            treeNode24,
            treeNode25});
            System.Windows.Forms.TreeNode treeNode27 = new System.Windows.Forms.TreeNode("Типы оборудования", 10, 10);
            System.Windows.Forms.TreeNode treeNode28 = new System.Windows.Forms.TreeNode("Производители", 11, 11);
            System.Windows.Forms.TreeNode treeNode29 = new System.Windows.Forms.TreeNode("Модели", 12, 12);
            System.Windows.Forms.TreeNode treeNode30 = new System.Windows.Forms.TreeNode("Расходники", 13, 13);
            System.Windows.Forms.TreeNode treeNode31 = new System.Windows.Forms.TreeNode("Поставщики", 4, 4);
            System.Windows.Forms.TreeNode treeNode32 = new System.Windows.Forms.TreeNode("Общие разделы", 9, 9, new System.Windows.Forms.TreeNode[] {
            treeNode27,
            treeNode28,
            treeNode29,
            treeNode30,
            treeNode31});
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.treeMenu = new System.Windows.Forms.TreeView();
            this.imageListThree = new System.Windows.Forms.ImageList(this.components);
            this.mainMenu = new System.Windows.Forms.MenuStrip();
            this.menuFile = new System.Windows.Forms.ToolStripMenuItem();
            this.menuInitDB = new System.Windows.Forms.ToolStripMenuItem();
            this.menuExit = new System.Windows.Forms.ToolStripMenuItem();
            this.menuReports = new System.Windows.Forms.ToolStripMenuItem();
            this.menuUserCard = new System.Windows.Forms.ToolStripMenuItem();
            this.menuSep1 = new System.Windows.Forms.ToolStripSeparator();
            this.menuPrintPreview = new System.Windows.Forms.ToolStripMenuItem();
            this.menuService = new System.Windows.Forms.ToolStripMenuItem();
            this.menuProperties = new System.Windows.Forms.ToolStripMenuItem();
            this.menuHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.menuAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.statusCount = new System.Windows.Forms.ToolStripStatusLabel();
            this.panelList = new System.Windows.Forms.Panel();
            this.panelDown = new System.Windows.Forms.Panel();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.listViewAdd3 = new System.Windows.Forms.ListView();
            this.listViewAdd2 = new System.Windows.Forms.ListView();
            this.listViewAdd1 = new System.Windows.Forms.ListView();
            this.splitterH = new System.Windows.Forms.Splitter();
            this.panelUp = new System.Windows.Forms.Panel();
            this.toolStrip = new System.Windows.Forms.ToolStrip();
            this.toolStripLabelName = new System.Windows.Forms.ToolStripLabel();
            this.tAdd = new System.Windows.Forms.ToolStripButton();
            this.tCopy = new System.Windows.Forms.ToolStripButton();
            this.tEdit = new System.Windows.Forms.ToolStripButton();
            this.tDelete = new System.Windows.Forms.ToolStripButton();
            this.tFilterReset = new System.Windows.Forms.ToolStripButton();
            this.tFilter = new System.Windows.Forms.ToolStripTextBox();
            this.tLabelFilter = new System.Windows.Forms.ToolStripLabel();
            this.tMove = new System.Windows.Forms.ToolStripButton();
            this.tFix = new System.Windows.Forms.ToolStripButton();
            this.tRefill = new System.Windows.Forms.ToolStripButton();
            this.listViewMain = new System.Windows.Forms.ListView();
            this.contextMenuMain = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.cmAdd = new System.Windows.Forms.ToolStripMenuItem();
            this.cmCopy = new System.Windows.Forms.ToolStripMenuItem();
            this.cmEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.cmDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.cmMove = new System.Windows.Forms.ToolStripMenuItem();
            this.tShowAll = new System.Windows.Forms.ToolStripButton();
            this.menuView = new System.Windows.Forms.ToolStripMenuItem();
            this.menuShowAll = new System.Windows.Forms.ToolStripMenuItem();
            this.mainMenu.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.panelList.SuspendLayout();
            this.panelDown.SuspendLayout();
            this.tabControl.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.panelUp.SuspendLayout();
            this.toolStrip.SuspendLayout();
            this.contextMenuMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // treeMenu
            // 
            this.treeMenu.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.treeMenu.ImageIndex = 0;
            this.treeMenu.ImageList = this.imageListThree;
            this.treeMenu.ItemHeight = 24;
            this.treeMenu.Location = new System.Drawing.Point(0, 27);
            this.treeMenu.Name = "treeMenu";
            treeNode17.ImageIndex = 5;
            treeNode17.Name = "nodeFilials";
            treeNode17.SelectedImageIndex = 5;
            treeNode17.Text = "Филиалы";
            treeNode18.ImageIndex = 3;
            treeNode18.Name = "nodeBuildings";
            treeNode18.SelectedImageIndex = 3;
            treeNode18.Text = "Здания";
            treeNode19.ImageIndex = 6;
            treeNode19.Name = "nodeRooms";
            treeNode19.SelectedImageIndex = 6;
            treeNode19.Text = "Помещения";
            treeNode20.ImageIndex = 7;
            treeNode20.Name = "nodeDeps";
            treeNode20.SelectedImageIndex = 7;
            treeNode20.Text = "Подразделения";
            treeNode21.ImageIndex = 8;
            treeNode21.Name = "nodePosts";
            treeNode21.SelectedImageIndex = 8;
            treeNode21.Text = "Должности";
            treeNode22.ImageIndex = 2;
            treeNode22.Name = "nodeUsers";
            treeNode22.SelectedImageIndex = 2;
            treeNode22.Text = "Сотрудники";
            treeNode23.ImageIndex = 4;
            treeNode23.Name = "nodeCompany";
            treeNode23.SelectedImageIndex = 4;
            treeNode23.Text = "Предприятие";
            treeNode24.ImageIndex = 1;
            treeNode24.Name = "nodeMoves";
            treeNode24.SelectedImageIndex = 1;
            treeNode24.Text = "Перемещения";
            treeNode25.ImageIndex = 11;
            treeNode25.Name = "nodeServices";
            treeNode25.SelectedImageIndex = 11;
            treeNode25.Text = "Обслуживания";
            treeNode26.ImageIndex = 0;
            treeNode26.Name = "nodeEquipment";
            treeNode26.SelectedImageIndex = 0;
            treeNode26.Text = "Оборудование";
            treeNode27.ImageIndex = 10;
            treeNode27.Name = "nodeEqType";
            treeNode27.SelectedImageIndex = 10;
            treeNode27.Text = "Типы оборудования";
            treeNode28.ImageIndex = 11;
            treeNode28.Name = "nodeVendors";
            treeNode28.SelectedImageIndex = 11;
            treeNode28.Text = "Производители";
            treeNode29.ImageIndex = 12;
            treeNode29.Name = "nodeModels";
            treeNode29.SelectedImageIndex = 12;
            treeNode29.Text = "Модели";
            treeNode30.ImageIndex = 13;
            treeNode30.Name = "nodeConsumables";
            treeNode30.SelectedImageIndex = 13;
            treeNode30.Text = "Расходники";
            treeNode31.ImageIndex = 4;
            treeNode31.Name = "nodeProviders";
            treeNode31.SelectedImageIndex = 4;
            treeNode31.Text = "Поставщики";
            treeNode32.ImageIndex = 9;
            treeNode32.Name = "nodeCommon";
            treeNode32.SelectedImageIndex = 9;
            treeNode32.Text = "Общие разделы";
            this.treeMenu.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode23,
            treeNode26,
            treeNode32});
            this.treeMenu.SelectedImageIndex = 0;
            this.treeMenu.Size = new System.Drawing.Size(157, 709);
            this.treeMenu.TabIndex = 0;
            this.treeMenu.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.TabChange);
            // 
            // imageListThree
            // 
            this.imageListThree.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageListThree.ImageStream")));
            this.imageListThree.TransparentColor = System.Drawing.Color.Transparent;
            this.imageListThree.Images.SetKeyName(0, "pc.png");
            this.imageListThree.Images.SetKeyName(1, "move.png");
            this.imageListThree.Images.SetKeyName(2, "user.png");
            this.imageListThree.Images.SetKeyName(3, "building.png");
            this.imageListThree.Images.SetKeyName(4, "company.png");
            this.imageListThree.Images.SetKeyName(5, "filial.png");
            this.imageListThree.Images.SetKeyName(6, "room.png");
            this.imageListThree.Images.SetKeyName(7, "dep.png");
            this.imageListThree.Images.SetKeyName(8, "post.png");
            this.imageListThree.Images.SetKeyName(9, "dictionarys.png");
            this.imageListThree.Images.SetKeyName(10, "eqtypes.png");
            this.imageListThree.Images.SetKeyName(11, "vendors.png");
            this.imageListThree.Images.SetKeyName(12, "models.png");
            this.imageListThree.Images.SetKeyName(13, "mouse.png");
            // 
            // mainMenu
            // 
            this.mainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuFile,
            this.menuView,
            this.menuReports,
            this.menuService,
            this.menuHelp});
            this.mainMenu.Location = new System.Drawing.Point(0, 0);
            this.mainMenu.Name = "mainMenu";
            this.mainMenu.Size = new System.Drawing.Size(1184, 24);
            this.mainMenu.TabIndex = 1;
            this.mainMenu.Text = "menuStrip1";
            // 
            // menuFile
            // 
            this.menuFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuInitDB,
            this.menuExit});
            this.menuFile.Name = "menuFile";
            this.menuFile.Size = new System.Drawing.Size(48, 20);
            this.menuFile.Text = "Файл";
            // 
            // menuInitDB
            // 
            this.menuInitDB.Name = "menuInitDB";
            this.menuInitDB.Size = new System.Drawing.Size(162, 22);
            this.menuInitDB.Text = "Инициализация";
            this.menuInitDB.Click += new System.EventHandler(this.инициализацияToolStripMenuItem_Click);
            // 
            // menuExit
            // 
            this.menuExit.Name = "menuExit";
            this.menuExit.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.menuExit.Size = new System.Drawing.Size(162, 22);
            this.menuExit.Text = "Выход";
            this.menuExit.Click += new System.EventHandler(this.Exit);
            // 
            // menuReports
            // 
            this.menuReports.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuUserCard,
            this.menuSep1,
            this.menuPrintPreview});
            this.menuReports.Name = "menuReports";
            this.menuReports.Size = new System.Drawing.Size(60, 20);
            this.menuReports.Text = "Отчёты";
            // 
            // menuUserCard
            // 
            this.menuUserCard.Name = "menuUserCard";
            this.menuUserCard.Size = new System.Drawing.Size(233, 22);
            this.menuUserCard.Text = "Карточка учёта";
            this.menuUserCard.Click += new System.EventHandler(this.UserCard);
            // 
            // menuSep1
            // 
            this.menuSep1.Name = "menuSep1";
            this.menuSep1.Size = new System.Drawing.Size(230, 6);
            // 
            // menuPrintPreview
            // 
            this.menuPrintPreview.Name = "menuPrintPreview";
            this.menuPrintPreview.Size = new System.Drawing.Size(233, 22);
            this.menuPrintPreview.Text = "Предварительный просмотр";
            this.menuPrintPreview.Click += new System.EventHandler(this.CheckPrintPreview);
            // 
            // menuService
            // 
            this.menuService.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuProperties});
            this.menuService.Name = "menuService";
            this.menuService.Size = new System.Drawing.Size(59, 20);
            this.menuService.Text = "Сервис";
            // 
            // menuProperties
            // 
            this.menuProperties.Name = "menuProperties";
            this.menuProperties.Size = new System.Drawing.Size(180, 22);
            this.menuProperties.Text = "Параметры";
            this.menuProperties.Click += new System.EventHandler(this.PropertiesMenu);
            // 
            // menuHelp
            // 
            this.menuHelp.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuAbout});
            this.menuHelp.Name = "menuHelp";
            this.menuHelp.Size = new System.Drawing.Size(65, 20);
            this.menuHelp.Text = "Справка";
            // 
            // menuAbout
            // 
            this.menuAbout.Name = "menuAbout";
            this.menuAbout.Size = new System.Drawing.Size(149, 22);
            this.menuAbout.Text = "О программе";
            this.menuAbout.Click += new System.EventHandler(this.About);
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusCount});
            this.statusStrip.Location = new System.Drawing.Point(0, 739);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(1184, 22);
            this.statusStrip.TabIndex = 2;
            this.statusStrip.Text = "statusStrip1";
            // 
            // statusCount
            // 
            this.statusCount.AutoSize = false;
            this.statusCount.Name = "statusCount";
            this.statusCount.Size = new System.Drawing.Size(300, 17);
            this.statusCount.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panelList
            // 
            this.panelList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelList.Controls.Add(this.panelDown);
            this.panelList.Controls.Add(this.splitterH);
            this.panelList.Controls.Add(this.panelUp);
            this.panelList.Location = new System.Drawing.Point(163, 27);
            this.panelList.Name = "panelList";
            this.panelList.Size = new System.Drawing.Size(1021, 709);
            this.panelList.TabIndex = 19;
            this.panelList.Visible = false;
            // 
            // panelDown
            // 
            this.panelDown.Controls.Add(this.tabControl);
            this.panelDown.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDown.Location = new System.Drawing.Point(0, 408);
            this.panelDown.Name = "panelDown";
            this.panelDown.Size = new System.Drawing.Size(1021, 301);
            this.panelDown.TabIndex = 21;
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabPage1);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Location = new System.Drawing.Point(0, 0);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(1021, 301);
            this.tabControl.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.listViewAdd3);
            this.tabPage1.Controls.Add(this.listViewAdd2);
            this.tabPage1.Controls.Add(this.listViewAdd1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1013, 275);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Дополнительная информация";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // listViewAdd3
            // 
            this.listViewAdd3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listViewAdd3.FullRowSelect = true;
            this.listViewAdd3.HideSelection = false;
            this.listViewAdd3.Location = new System.Drawing.Point(3, 3);
            this.listViewAdd3.MultiSelect = false;
            this.listViewAdd3.Name = "listViewAdd3";
            this.listViewAdd3.Size = new System.Drawing.Size(1007, 269);
            this.listViewAdd3.TabIndex = 5;
            this.listViewAdd3.UseCompatibleStateImageBehavior = false;
            this.listViewAdd3.View = System.Windows.Forms.View.Details;
            this.listViewAdd3.DoubleClick += new System.EventHandler(this.MoveEditFromAdd);
            // 
            // listViewAdd2
            // 
            this.listViewAdd2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listViewAdd2.FullRowSelect = true;
            this.listViewAdd2.HideSelection = false;
            this.listViewAdd2.Location = new System.Drawing.Point(3, 3);
            this.listViewAdd2.MultiSelect = false;
            this.listViewAdd2.Name = "listViewAdd2";
            this.listViewAdd2.Size = new System.Drawing.Size(1007, 269);
            this.listViewAdd2.TabIndex = 4;
            this.listViewAdd2.UseCompatibleStateImageBehavior = false;
            this.listViewAdd2.View = System.Windows.Forms.View.Details;
            this.listViewAdd2.DoubleClick += new System.EventHandler(this.MoveEditFromAdd);
            // 
            // listViewAdd1
            // 
            this.listViewAdd1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listViewAdd1.FullRowSelect = true;
            this.listViewAdd1.HideSelection = false;
            this.listViewAdd1.Location = new System.Drawing.Point(3, 3);
            this.listViewAdd1.MultiSelect = false;
            this.listViewAdd1.Name = "listViewAdd1";
            this.listViewAdd1.Size = new System.Drawing.Size(1007, 269);
            this.listViewAdd1.TabIndex = 3;
            this.listViewAdd1.UseCompatibleStateImageBehavior = false;
            this.listViewAdd1.View = System.Windows.Forms.View.Details;
            this.listViewAdd1.DoubleClick += new System.EventHandler(this.MoveEditFromAdd);
            // 
            // splitterH
            // 
            this.splitterH.Dock = System.Windows.Forms.DockStyle.Top;
            this.splitterH.Location = new System.Drawing.Point(0, 400);
            this.splitterH.Name = "splitterH";
            this.splitterH.Size = new System.Drawing.Size(1021, 8);
            this.splitterH.TabIndex = 20;
            this.splitterH.TabStop = false;
            // 
            // panelUp
            // 
            this.panelUp.Controls.Add(this.toolStrip);
            this.panelUp.Controls.Add(this.listViewMain);
            this.panelUp.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelUp.Location = new System.Drawing.Point(0, 0);
            this.panelUp.Name = "panelUp";
            this.panelUp.Size = new System.Drawing.Size(1021, 400);
            this.panelUp.TabIndex = 17;
            // 
            // toolStrip
            // 
            this.toolStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabelName,
            this.tAdd,
            this.tCopy,
            this.tEdit,
            this.tDelete,
            this.tFilterReset,
            this.tFilter,
            this.tLabelFilter,
            this.tMove,
            this.tFix,
            this.tRefill,
            this.tShowAll});
            this.toolStrip.Location = new System.Drawing.Point(0, 0);
            this.toolStrip.Name = "toolStrip";
            this.toolStrip.Size = new System.Drawing.Size(1021, 25);
            this.toolStrip.TabIndex = 22;
            // 
            // toolStripLabelName
            // 
            this.toolStripLabelName.AutoSize = false;
            this.toolStripLabelName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.toolStripLabelName.Name = "toolStripLabelName";
            this.toolStripLabelName.Size = new System.Drawing.Size(170, 22);
            this.toolStripLabelName.Text = "Справочник";
            this.toolStripLabelName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tAdd
            // 
            this.tAdd.Image = global::CompStore.Properties.Resources.add;
            this.tAdd.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tAdd.Name = "tAdd";
            this.tAdd.Size = new System.Drawing.Size(79, 22);
            this.tAdd.Text = "Добавить";
            this.tAdd.Click += new System.EventHandler(this.ItemAdd);
            // 
            // tCopy
            // 
            this.tCopy.Image = global::CompStore.Properties.Resources.copy;
            this.tCopy.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tCopy.Name = "tCopy";
            this.tCopy.Size = new System.Drawing.Size(92, 22);
            this.tCopy.Text = "Копировать";
            this.tCopy.Click += new System.EventHandler(this.ItemCopy);
            // 
            // tEdit
            // 
            this.tEdit.Image = global::CompStore.Properties.Resources.edit;
            this.tEdit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tEdit.Name = "tEdit";
            this.tEdit.Size = new System.Drawing.Size(81, 22);
            this.tEdit.Text = "Изменить";
            this.tEdit.Click += new System.EventHandler(this.ItemEdit);
            // 
            // tDelete
            // 
            this.tDelete.Image = ((System.Drawing.Image)(resources.GetObject("tDelete.Image")));
            this.tDelete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tDelete.Name = "tDelete";
            this.tDelete.Size = new System.Drawing.Size(71, 22);
            this.tDelete.Text = "Удалить";
            this.tDelete.Click += new System.EventHandler(this.ItemDelete);
            // 
            // tFilterReset
            // 
            this.tFilterReset.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tFilterReset.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tFilterReset.Image = global::CompStore.Properties.Resources.cancel;
            this.tFilterReset.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tFilterReset.Name = "tFilterReset";
            this.tFilterReset.Size = new System.Drawing.Size(23, 22);
            this.tFilterReset.Click += new System.EventHandler(this.FilterReset);
            // 
            // tFilter
            // 
            this.tFilter.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tFilter.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tFilter.Name = "tFilter";
            this.tFilter.Size = new System.Drawing.Size(160, 25);
            this.tFilter.TextChanged += new System.EventHandler(this.ListViewDraw);
            // 
            // tLabelFilter
            // 
            this.tLabelFilter.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tLabelFilter.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tLabelFilter.Image = global::CompStore.Properties.Resources.search;
            this.tLabelFilter.Name = "tLabelFilter";
            this.tLabelFilter.Size = new System.Drawing.Size(16, 22);
            // 
            // tMove
            // 
            this.tMove.Image = global::CompStore.Properties.Resources.move;
            this.tMove.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tMove.Name = "tMove";
            this.tMove.Size = new System.Drawing.Size(99, 22);
            this.tMove.Text = "Переместить";
            this.tMove.Click += new System.EventHandler(this.Move);
            // 
            // tFix
            // 
            this.tFix.Image = global::CompStore.Properties.Resources.fix;
            this.tFix.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tFix.Name = "tFix";
            this.tFix.Size = new System.Drawing.Size(68, 22);
            this.tFix.Text = "Ремонт";
            // 
            // tRefill
            // 
            this.tRefill.Image = global::CompStore.Properties.Resources.refill;
            this.tRefill.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tRefill.Name = "tRefill";
            this.tRefill.Size = new System.Drawing.Size(78, 22);
            this.tRefill.Text = "Заправка";
            // 
            // listViewMain
            // 
            this.listViewMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listViewMain.ContextMenuStrip = this.contextMenuMain;
            this.listViewMain.FullRowSelect = true;
            this.listViewMain.HideSelection = false;
            this.listViewMain.Location = new System.Drawing.Point(0, 25);
            this.listViewMain.Name = "listViewMain";
            this.listViewMain.Size = new System.Drawing.Size(1021, 375);
            this.listViewMain.TabIndex = 10;
            this.listViewMain.UseCompatibleStateImageBehavior = false;
            this.listViewMain.View = System.Windows.Forms.View.Details;
            this.listViewMain.SelectedIndexChanged += new System.EventHandler(this.ItemSelChange);
            this.listViewMain.DoubleClick += new System.EventHandler(this.ItemEdit);
            this.listViewMain.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Keyboard);
            // 
            // contextMenuMain
            // 
            this.contextMenuMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cmAdd,
            this.cmCopy,
            this.cmEdit,
            this.cmDelete,
            this.cmMove});
            this.contextMenuMain.Name = "contextMenuEquipment";
            this.contextMenuMain.Size = new System.Drawing.Size(209, 114);
            // 
            // cmAdd
            // 
            this.cmAdd.Image = global::CompStore.Properties.Resources.add;
            this.cmAdd.Name = "cmAdd";
            this.cmAdd.ShortcutKeys = System.Windows.Forms.Keys.Insert;
            this.cmAdd.Size = new System.Drawing.Size(208, 22);
            this.cmAdd.Text = "Добавить";
            this.cmAdd.Click += new System.EventHandler(this.ItemAdd);
            // 
            // cmCopy
            // 
            this.cmCopy.Image = global::CompStore.Properties.Resources.copy;
            this.cmCopy.Name = "cmCopy";
            this.cmCopy.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Shift | System.Windows.Forms.Keys.Insert)));
            this.cmCopy.Size = new System.Drawing.Size(208, 22);
            this.cmCopy.Text = "Копировать";
            this.cmCopy.Click += new System.EventHandler(this.ItemCopy);
            // 
            // cmEdit
            // 
            this.cmEdit.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.cmEdit.Image = global::CompStore.Properties.Resources.edit;
            this.cmEdit.Name = "cmEdit";
            this.cmEdit.Size = new System.Drawing.Size(208, 22);
            this.cmEdit.Text = "Изменить";
            this.cmEdit.Click += new System.EventHandler(this.ItemEdit);
            // 
            // cmDelete
            // 
            this.cmDelete.Image = ((System.Drawing.Image)(resources.GetObject("cmDelete.Image")));
            this.cmDelete.Name = "cmDelete";
            this.cmDelete.ShortcutKeys = System.Windows.Forms.Keys.Delete;
            this.cmDelete.Size = new System.Drawing.Size(208, 22);
            this.cmDelete.Text = "Удалить";
            this.cmDelete.Click += new System.EventHandler(this.ItemDelete);
            // 
            // cmMove
            // 
            this.cmMove.Image = global::CompStore.Properties.Resources.move;
            this.cmMove.Name = "cmMove";
            this.cmMove.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Right)));
            this.cmMove.Size = new System.Drawing.Size(208, 22);
            this.cmMove.Text = "Переместить";
            this.cmMove.Click += new System.EventHandler(this.Move);
            // 
            // tShowAll
            // 
            this.tShowAll.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tShowAll.Image = ((System.Drawing.Image)(resources.GetObject("tShowAll.Image")));
            this.tShowAll.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tShowAll.Name = "tShowAll";
            this.tShowAll.Size = new System.Drawing.Size(30, 22);
            this.tShowAll.Text = "Все";
            this.tShowAll.Click += new System.EventHandler(this.ShowAll);
            // 
            // menuView
            // 
            this.menuView.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuShowAll});
            this.menuView.Name = "menuView";
            this.menuView.Size = new System.Drawing.Size(39, 20);
            this.menuView.Text = "Вид";
            // 
            // menuShowAll
            // 
            this.menuShowAll.Name = "menuShowAll";
            this.menuShowAll.Size = new System.Drawing.Size(180, 22);
            this.menuShowAll.Text = "Показывать все";
            this.menuShowAll.Click += new System.EventHandler(this.ShowAll);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 761);
            this.Controls.Add(this.panelList);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.treeMenu);
            this.Controls.Add(this.mainMenu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.mainMenu;
            this.MinimumSize = new System.Drawing.Size(400, 300);
            this.Name = "FormMain";
            this.Text = "CompStore";
            this.mainMenu.ResumeLayout(false);
            this.mainMenu.PerformLayout();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.panelList.ResumeLayout(false);
            this.panelDown.ResumeLayout(false);
            this.tabControl.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.panelUp.ResumeLayout(false);
            this.panelUp.PerformLayout();
            this.toolStrip.ResumeLayout(false);
            this.toolStrip.PerformLayout();
            this.contextMenuMain.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TreeView treeMenu;
        private System.Windows.Forms.MenuStrip mainMenu;
        private System.Windows.Forms.ToolStripMenuItem menuFile;
        private System.Windows.Forms.ToolStripMenuItem menuExit;
        private System.Windows.Forms.ToolStripMenuItem menuHelp;
        private System.Windows.Forms.ToolStripMenuItem menuAbout;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripMenuItem menuInitDB;
        private System.Windows.Forms.ToolStripStatusLabel statusCount;
        private System.Windows.Forms.ToolStripMenuItem menuReports;
        private System.Windows.Forms.ToolStripMenuItem menuUserCard;
        private System.Windows.Forms.ToolStripSeparator menuSep1;
        private System.Windows.Forms.ToolStripMenuItem menuPrintPreview;
        private System.Windows.Forms.Panel panelList;
        private System.Windows.Forms.Panel panelDown;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.ListView listViewAdd1;
        private System.Windows.Forms.Splitter splitterH;
        private System.Windows.Forms.Panel panelUp;
        private System.Windows.Forms.ToolStrip toolStrip;
        private System.Windows.Forms.ToolStripLabel toolStripLabelName;
        private System.Windows.Forms.ToolStripButton tEdit;
        private System.Windows.Forms.ToolStripButton tDelete;
        private System.Windows.Forms.ToolStripButton tFilterReset;
        private System.Windows.Forms.ToolStripTextBox tFilter;
        private System.Windows.Forms.ToolStripLabel tLabelFilter;
        private System.Windows.Forms.ToolStripButton tMove;
        private System.Windows.Forms.ListView listViewMain;
        private System.Windows.Forms.ListView listViewAdd3;
        private System.Windows.Forms.ListView listViewAdd2;
        private System.Windows.Forms.ToolStripButton tAdd;
        private System.Windows.Forms.ToolStripButton tFix;
        private System.Windows.Forms.ToolStripButton tRefill;
        private System.Windows.Forms.ToolStripButton tCopy;
        private System.Windows.Forms.ContextMenuStrip contextMenuMain;
        private System.Windows.Forms.ToolStripMenuItem cmAdd;
        private System.Windows.Forms.ToolStripMenuItem cmCopy;
        private System.Windows.Forms.ToolStripMenuItem cmEdit;
        private System.Windows.Forms.ToolStripMenuItem cmDelete;
        private System.Windows.Forms.ToolStripMenuItem cmMove;
        private System.Windows.Forms.ImageList imageListThree;
        private System.Windows.Forms.ToolStripMenuItem menuService;
        private System.Windows.Forms.ToolStripMenuItem menuProperties;
        private System.Windows.Forms.ToolStripButton tShowAll;
        private System.Windows.Forms.ToolStripMenuItem menuView;
        private System.Windows.Forms.ToolStripMenuItem menuShowAll;
    }
}

