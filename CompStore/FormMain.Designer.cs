
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
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Филиалы", 5, 5);
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Здания", 3, 3);
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("Помещения", 6, 6);
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("Подразделения", 7, 7);
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("Должности", 8, 8);
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("Сотрудники", 2, 2);
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("Предприятие", 4, 4, new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2,
            treeNode3,
            treeNode4,
            treeNode5,
            treeNode6});
            System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode("Перемещения", 1, 1);
            System.Windows.Forms.TreeNode treeNode9 = new System.Windows.Forms.TreeNode("Оборудование", 0, 0, new System.Windows.Forms.TreeNode[] {
            treeNode8});
            System.Windows.Forms.TreeNode treeNode10 = new System.Windows.Forms.TreeNode("Типы оборудования");
            System.Windows.Forms.TreeNode treeNode11 = new System.Windows.Forms.TreeNode("Производители");
            System.Windows.Forms.TreeNode treeNode12 = new System.Windows.Forms.TreeNode("Модели");
            System.Windows.Forms.TreeNode treeNode13 = new System.Windows.Forms.TreeNode("Поставщики");
            System.Windows.Forms.TreeNode treeNode14 = new System.Windows.Forms.TreeNode("Общие разделы", new System.Windows.Forms.TreeNode[] {
            treeNode10,
            treeNode11,
            treeNode12,
            treeNode13});
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
            this.menuHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.menuAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.statusCount = new System.Windows.Forms.ToolStripStatusLabel();
            this.panelBrands = new System.Windows.Forms.Panel();
            this.toolStripBrands = new System.Windows.Forms.ToolStrip();
            this.toolBrandLabel = new System.Windows.Forms.ToolStripLabel();
            this.toolBrandAdd = new System.Windows.Forms.ToolStripButton();
            this.toolBrandEdit = new System.Windows.Forms.ToolStripButton();
            this.toolBrandDelete = new System.Windows.Forms.ToolStripButton();
            this.toolBrandFilterReset = new System.Windows.Forms.ToolStripButton();
            this.toolBrandFilter = new System.Windows.Forms.ToolStripTextBox();
            this.toolBrandFilterLabel = new System.Windows.Forms.ToolStripLabel();
            this.listBrands = new System.Windows.Forms.ListView();
            this.columnBrandName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnBrandCom = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.contextMenuBrands = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.cmBrandAdd = new System.Windows.Forms.ToolStripMenuItem();
            this.cmBrandEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.cmBrandDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.panelEqTypes = new System.Windows.Forms.Panel();
            this.toolStripEqTypes = new System.Windows.Forms.ToolStrip();
            this.toolETLabel = new System.Windows.Forms.ToolStripLabel();
            this.toolETAdd = new System.Windows.Forms.ToolStripButton();
            this.toolETEdit = new System.Windows.Forms.ToolStripButton();
            this.toolETDelete = new System.Windows.Forms.ToolStripButton();
            this.toolETFilterReset = new System.Windows.Forms.ToolStripButton();
            this.toolETFilter = new System.Windows.Forms.ToolStripTextBox();
            this.toolETFilterLabel = new System.Windows.Forms.ToolStripLabel();
            this.listEqTypes = new System.Windows.Forms.ListView();
            this.columnEqType = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.contextMenuEqTypes = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.cmETAdd = new System.Windows.Forms.ToolStripMenuItem();
            this.cmETEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.cmETDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.panelModels = new System.Windows.Forms.Panel();
            this.toolStripModels = new System.Windows.Forms.ToolStrip();
            this.toolModelLabelLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolModelAdd = new System.Windows.Forms.ToolStripButton();
            this.toolModelEdit = new System.Windows.Forms.ToolStripButton();
            this.toolModelDelete = new System.Windows.Forms.ToolStripButton();
            this.toolModelFilterReset = new System.Windows.Forms.ToolStripButton();
            this.toolModelFilter = new System.Windows.Forms.ToolStripTextBox();
            this.toolModelFilterLabel = new System.Windows.Forms.ToolStripLabel();
            this.listModels = new System.Windows.Forms.ListView();
            this.columnModelEqType = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnModelBrand = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnModelName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnModelComment = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.contextMenuModels = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.cmModelAdd = new System.Windows.Forms.ToolStripMenuItem();
            this.cmModelEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.cmModelDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.panelProviders = new System.Windows.Forms.Panel();
            this.toolStripProviders = new System.Windows.Forms.ToolStrip();
            this.toolStripLabelProviders = new System.Windows.Forms.ToolStripLabel();
            this.toolProviderAdd = new System.Windows.Forms.ToolStripButton();
            this.toolProviderEdit = new System.Windows.Forms.ToolStripButton();
            this.toolProviderDelete = new System.Windows.Forms.ToolStripButton();
            this.toolProviderFilterReset = new System.Windows.Forms.ToolStripButton();
            this.toolProviderFilter = new System.Windows.Forms.ToolStripTextBox();
            this.toolProviderFilterLabel = new System.Windows.Forms.ToolStripLabel();
            this.listProviders = new System.Windows.Forms.ListView();
            this.columnProviderName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnProviderAdress = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnProviderPhone = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnProviderManager = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnProviderComment = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.contextMenuProviders = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.cmProviderAdd = new System.Windows.Forms.ToolStripMenuItem();
            this.cmProviderEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.cmProviderDelete = new System.Windows.Forms.ToolStripMenuItem();
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
            this.mainMenu.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.panelBrands.SuspendLayout();
            this.toolStripBrands.SuspendLayout();
            this.contextMenuBrands.SuspendLayout();
            this.panelEqTypes.SuspendLayout();
            this.toolStripEqTypes.SuspendLayout();
            this.contextMenuEqTypes.SuspendLayout();
            this.panelModels.SuspendLayout();
            this.toolStripModels.SuspendLayout();
            this.contextMenuModels.SuspendLayout();
            this.panelProviders.SuspendLayout();
            this.toolStripProviders.SuspendLayout();
            this.contextMenuProviders.SuspendLayout();
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
            treeNode1.ImageIndex = 5;
            treeNode1.Name = "nodeFilials";
            treeNode1.SelectedImageIndex = 5;
            treeNode1.Text = "Филиалы";
            treeNode2.ImageIndex = 3;
            treeNode2.Name = "nodeBuildings";
            treeNode2.SelectedImageIndex = 3;
            treeNode2.Text = "Здания";
            treeNode3.ImageIndex = 6;
            treeNode3.Name = "nodeRooms";
            treeNode3.SelectedImageIndex = 6;
            treeNode3.Text = "Помещения";
            treeNode4.ImageIndex = 7;
            treeNode4.Name = "nodeDeps";
            treeNode4.SelectedImageIndex = 7;
            treeNode4.Text = "Подразделения";
            treeNode5.ImageIndex = 8;
            treeNode5.Name = "nodePosts";
            treeNode5.SelectedImageIndex = 8;
            treeNode5.Text = "Должности";
            treeNode6.ImageIndex = 2;
            treeNode6.Name = "nodeUsers";
            treeNode6.SelectedImageIndex = 2;
            treeNode6.Text = "Сотрудники";
            treeNode7.ImageIndex = 4;
            treeNode7.Name = "nodeCompany";
            treeNode7.SelectedImageIndex = 4;
            treeNode7.Text = "Предприятие";
            treeNode8.ImageIndex = 1;
            treeNode8.Name = "nodeMoves";
            treeNode8.SelectedImageIndex = 1;
            treeNode8.Text = "Перемещения";
            treeNode9.ImageIndex = 0;
            treeNode9.Name = "nodeEquipment";
            treeNode9.SelectedImageIndex = 0;
            treeNode9.Text = "Оборудование";
            treeNode10.Name = "nodeEqType";
            treeNode10.Text = "Типы оборудования";
            treeNode11.Name = "nodeBrands";
            treeNode11.Text = "Производители";
            treeNode12.Name = "nodeModels";
            treeNode12.Text = "Модели";
            treeNode13.Name = "nodeProviders";
            treeNode13.Text = "Поставщики";
            treeNode14.ImageIndex = -2;
            treeNode14.Name = "nodeCommon";
            treeNode14.Text = "Общие разделы";
            this.treeMenu.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode7,
            treeNode9,
            treeNode14});
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
            // 
            // mainMenu
            // 
            this.mainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuFile,
            this.menuReports,
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
            this.menuUserCard.Enabled = false;
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
            // panelBrands
            // 
            this.panelBrands.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelBrands.Controls.Add(this.toolStripBrands);
            this.panelBrands.Controls.Add(this.listBrands);
            this.panelBrands.Location = new System.Drawing.Point(163, 27);
            this.panelBrands.Name = "panelBrands";
            this.panelBrands.Size = new System.Drawing.Size(1021, 709);
            this.panelBrands.TabIndex = 14;
            this.panelBrands.Visible = false;
            this.panelBrands.VisibleChanged += new System.EventHandler(this.BrandsView);
            // 
            // toolStripBrands
            // 
            this.toolStripBrands.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStripBrands.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolBrandLabel,
            this.toolBrandAdd,
            this.toolBrandEdit,
            this.toolBrandDelete,
            this.toolBrandFilterReset,
            this.toolBrandFilter,
            this.toolBrandFilterLabel});
            this.toolStripBrands.Location = new System.Drawing.Point(0, 0);
            this.toolStripBrands.Name = "toolStripBrands";
            this.toolStripBrands.Size = new System.Drawing.Size(1021, 25);
            this.toolStripBrands.TabIndex = 16;
            this.toolStripBrands.Text = "123";
            // 
            // toolBrandLabel
            // 
            this.toolBrandLabel.AutoSize = false;
            this.toolBrandLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.toolBrandLabel.Name = "toolBrandLabel";
            this.toolBrandLabel.Size = new System.Drawing.Size(170, 22);
            this.toolBrandLabel.Text = "Производители";
            this.toolBrandLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // toolBrandAdd
            // 
            this.toolBrandAdd.Image = global::CompStore.Properties.Resources.add;
            this.toolBrandAdd.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolBrandAdd.Name = "toolBrandAdd";
            this.toolBrandAdd.Size = new System.Drawing.Size(79, 22);
            this.toolBrandAdd.Text = "Добавить";
            this.toolBrandAdd.Click += new System.EventHandler(this.BrandAdd);
            // 
            // toolBrandEdit
            // 
            this.toolBrandEdit.Image = global::CompStore.Properties.Resources.edit;
            this.toolBrandEdit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolBrandEdit.Name = "toolBrandEdit";
            this.toolBrandEdit.Size = new System.Drawing.Size(81, 22);
            this.toolBrandEdit.Text = "Изменить";
            this.toolBrandEdit.Click += new System.EventHandler(this.BrandEdit);
            // 
            // toolBrandDelete
            // 
            this.toolBrandDelete.Image = ((System.Drawing.Image)(resources.GetObject("toolBrandDelete.Image")));
            this.toolBrandDelete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolBrandDelete.Name = "toolBrandDelete";
            this.toolBrandDelete.Size = new System.Drawing.Size(71, 22);
            this.toolBrandDelete.Text = "Удалить";
            this.toolBrandDelete.Click += new System.EventHandler(this.BrandDelete);
            // 
            // toolBrandFilterReset
            // 
            this.toolBrandFilterReset.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolBrandFilterReset.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolBrandFilterReset.Image = global::CompStore.Properties.Resources.cancel;
            this.toolBrandFilterReset.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolBrandFilterReset.Name = "toolBrandFilterReset";
            this.toolBrandFilterReset.Size = new System.Drawing.Size(23, 22);
            this.toolBrandFilterReset.Click += new System.EventHandler(this.BrandFilterReset);
            // 
            // toolBrandFilter
            // 
            this.toolBrandFilter.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolBrandFilter.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.toolBrandFilter.Name = "toolBrandFilter";
            this.toolBrandFilter.Size = new System.Drawing.Size(300, 25);
            this.toolBrandFilter.TextChanged += new System.EventHandler(this.BrandsDraw);
            // 
            // toolBrandFilterLabel
            // 
            this.toolBrandFilterLabel.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolBrandFilterLabel.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolBrandFilterLabel.Image = global::CompStore.Properties.Resources.search;
            this.toolBrandFilterLabel.Name = "toolBrandFilterLabel";
            this.toolBrandFilterLabel.Size = new System.Drawing.Size(16, 22);
            // 
            // listBrands
            // 
            this.listBrands.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listBrands.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnBrandName,
            this.columnBrandCom});
            this.listBrands.ContextMenuStrip = this.contextMenuBrands;
            this.listBrands.FullRowSelect = true;
            this.listBrands.HideSelection = false;
            this.listBrands.Location = new System.Drawing.Point(0, 25);
            this.listBrands.MultiSelect = false;
            this.listBrands.Name = "listBrands";
            this.listBrands.Size = new System.Drawing.Size(1021, 684);
            this.listBrands.TabIndex = 2;
            this.listBrands.UseCompatibleStateImageBehavior = false;
            this.listBrands.View = System.Windows.Forms.View.Details;
            this.listBrands.SelectedIndexChanged += new System.EventHandler(this.BrandsSelChange);
            this.listBrands.DoubleClick += new System.EventHandler(this.BrandEdit);
            this.listBrands.KeyDown += new System.Windows.Forms.KeyEventHandler(this.BrandsKeyboard);
            // 
            // columnBrandName
            // 
            this.columnBrandName.Text = "Название";
            this.columnBrandName.Width = 200;
            // 
            // columnBrandCom
            // 
            this.columnBrandCom.Text = "Примечание";
            this.columnBrandCom.Width = 790;
            // 
            // contextMenuBrands
            // 
            this.contextMenuBrands.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cmBrandAdd,
            this.cmBrandEdit,
            this.cmBrandDelete});
            this.contextMenuBrands.Name = "contextMenuEquipment";
            this.contextMenuBrands.Size = new System.Drawing.Size(149, 70);
            // 
            // cmBrandAdd
            // 
            this.cmBrandAdd.Image = global::CompStore.Properties.Resources.add;
            this.cmBrandAdd.Name = "cmBrandAdd";
            this.cmBrandAdd.ShortcutKeys = System.Windows.Forms.Keys.Insert;
            this.cmBrandAdd.Size = new System.Drawing.Size(148, 22);
            this.cmBrandAdd.Text = "Добавить";
            this.cmBrandAdd.Click += new System.EventHandler(this.BrandAdd);
            // 
            // cmBrandEdit
            // 
            this.cmBrandEdit.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.cmBrandEdit.Image = global::CompStore.Properties.Resources.edit;
            this.cmBrandEdit.Name = "cmBrandEdit";
            this.cmBrandEdit.Size = new System.Drawing.Size(148, 22);
            this.cmBrandEdit.Text = "Изменить";
            this.cmBrandEdit.Click += new System.EventHandler(this.BrandEdit);
            // 
            // cmBrandDelete
            // 
            this.cmBrandDelete.Image = ((System.Drawing.Image)(resources.GetObject("cmBrandDelete.Image")));
            this.cmBrandDelete.Name = "cmBrandDelete";
            this.cmBrandDelete.ShortcutKeys = System.Windows.Forms.Keys.Delete;
            this.cmBrandDelete.Size = new System.Drawing.Size(148, 22);
            this.cmBrandDelete.Text = "Удалить";
            this.cmBrandDelete.Click += new System.EventHandler(this.BrandDelete);
            // 
            // panelEqTypes
            // 
            this.panelEqTypes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelEqTypes.Controls.Add(this.toolStripEqTypes);
            this.panelEqTypes.Controls.Add(this.listEqTypes);
            this.panelEqTypes.Location = new System.Drawing.Point(163, 27);
            this.panelEqTypes.Name = "panelEqTypes";
            this.panelEqTypes.Size = new System.Drawing.Size(1021, 709);
            this.panelEqTypes.TabIndex = 15;
            this.panelEqTypes.Visible = false;
            this.panelEqTypes.VisibleChanged += new System.EventHandler(this.EqTypesView);
            // 
            // toolStripEqTypes
            // 
            this.toolStripEqTypes.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStripEqTypes.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolETLabel,
            this.toolETAdd,
            this.toolETEdit,
            this.toolETDelete,
            this.toolETFilterReset,
            this.toolETFilter,
            this.toolETFilterLabel});
            this.toolStripEqTypes.Location = new System.Drawing.Point(0, 0);
            this.toolStripEqTypes.Name = "toolStripEqTypes";
            this.toolStripEqTypes.Size = new System.Drawing.Size(1021, 25);
            this.toolStripEqTypes.TabIndex = 10;
            this.toolStripEqTypes.Text = "toolStrip1";
            // 
            // toolETLabel
            // 
            this.toolETLabel.AutoSize = false;
            this.toolETLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.toolETLabel.Name = "toolETLabel";
            this.toolETLabel.Size = new System.Drawing.Size(170, 22);
            this.toolETLabel.Text = "Типы оборудования";
            this.toolETLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // toolETAdd
            // 
            this.toolETAdd.Image = global::CompStore.Properties.Resources.add;
            this.toolETAdd.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolETAdd.Name = "toolETAdd";
            this.toolETAdd.Size = new System.Drawing.Size(79, 22);
            this.toolETAdd.Text = "Добавить";
            this.toolETAdd.Click += new System.EventHandler(this.EqTypeAdd);
            // 
            // toolETEdit
            // 
            this.toolETEdit.Image = global::CompStore.Properties.Resources.edit;
            this.toolETEdit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolETEdit.Name = "toolETEdit";
            this.toolETEdit.Size = new System.Drawing.Size(81, 22);
            this.toolETEdit.Text = "Изменить";
            this.toolETEdit.Click += new System.EventHandler(this.EqTypeEdit);
            // 
            // toolETDelete
            // 
            this.toolETDelete.Image = ((System.Drawing.Image)(resources.GetObject("toolETDelete.Image")));
            this.toolETDelete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolETDelete.Name = "toolETDelete";
            this.toolETDelete.Size = new System.Drawing.Size(71, 22);
            this.toolETDelete.Text = "Удалить";
            this.toolETDelete.Click += new System.EventHandler(this.EqTypeDelete);
            // 
            // toolETFilterReset
            // 
            this.toolETFilterReset.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolETFilterReset.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolETFilterReset.Image = global::CompStore.Properties.Resources.cancel;
            this.toolETFilterReset.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolETFilterReset.Name = "toolETFilterReset";
            this.toolETFilterReset.Size = new System.Drawing.Size(23, 22);
            this.toolETFilterReset.Click += new System.EventHandler(this.EqTypeFilterReset);
            // 
            // toolETFilter
            // 
            this.toolETFilter.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolETFilter.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.toolETFilter.Name = "toolETFilter";
            this.toolETFilter.Size = new System.Drawing.Size(300, 25);
            this.toolETFilter.TextChanged += new System.EventHandler(this.EqTypesDraw);
            // 
            // toolETFilterLabel
            // 
            this.toolETFilterLabel.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolETFilterLabel.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolETFilterLabel.Image = global::CompStore.Properties.Resources.search;
            this.toolETFilterLabel.Name = "toolETFilterLabel";
            this.toolETFilterLabel.Size = new System.Drawing.Size(16, 22);
            // 
            // listEqTypes
            // 
            this.listEqTypes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listEqTypes.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnEqType});
            this.listEqTypes.ContextMenuStrip = this.contextMenuEqTypes;
            this.listEqTypes.FullRowSelect = true;
            this.listEqTypes.HideSelection = false;
            this.listEqTypes.Location = new System.Drawing.Point(0, 25);
            this.listEqTypes.MultiSelect = false;
            this.listEqTypes.Name = "listEqTypes";
            this.listEqTypes.Size = new System.Drawing.Size(1021, 684);
            this.listEqTypes.TabIndex = 2;
            this.listEqTypes.UseCompatibleStateImageBehavior = false;
            this.listEqTypes.View = System.Windows.Forms.View.Details;
            this.listEqTypes.SelectedIndexChanged += new System.EventHandler(this.EqTypesSelChange);
            this.listEqTypes.DoubleClick += new System.EventHandler(this.EqTypeEdit);
            this.listEqTypes.KeyDown += new System.Windows.Forms.KeyEventHandler(this.EqTypesKeyboard);
            // 
            // columnEqType
            // 
            this.columnEqType.Text = "Название";
            this.columnEqType.Width = 990;
            // 
            // contextMenuEqTypes
            // 
            this.contextMenuEqTypes.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cmETAdd,
            this.cmETEdit,
            this.cmETDelete});
            this.contextMenuEqTypes.Name = "contextMenuEquipment";
            this.contextMenuEqTypes.Size = new System.Drawing.Size(149, 70);
            // 
            // cmETAdd
            // 
            this.cmETAdd.Image = global::CompStore.Properties.Resources.add;
            this.cmETAdd.Name = "cmETAdd";
            this.cmETAdd.ShortcutKeys = System.Windows.Forms.Keys.Insert;
            this.cmETAdd.Size = new System.Drawing.Size(148, 22);
            this.cmETAdd.Text = "Добавить";
            this.cmETAdd.Click += new System.EventHandler(this.EqTypeAdd);
            // 
            // cmETEdit
            // 
            this.cmETEdit.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.cmETEdit.Image = global::CompStore.Properties.Resources.edit;
            this.cmETEdit.Name = "cmETEdit";
            this.cmETEdit.Size = new System.Drawing.Size(148, 22);
            this.cmETEdit.Text = "Изменить";
            this.cmETEdit.Click += new System.EventHandler(this.EqTypeEdit);
            // 
            // cmETDelete
            // 
            this.cmETDelete.Image = ((System.Drawing.Image)(resources.GetObject("cmETDelete.Image")));
            this.cmETDelete.Name = "cmETDelete";
            this.cmETDelete.ShortcutKeys = System.Windows.Forms.Keys.Delete;
            this.cmETDelete.Size = new System.Drawing.Size(148, 22);
            this.cmETDelete.Text = "Удалить";
            this.cmETDelete.Click += new System.EventHandler(this.EqTypeDelete);
            // 
            // panelModels
            // 
            this.panelModels.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelModels.Controls.Add(this.toolStripModels);
            this.panelModels.Controls.Add(this.listModels);
            this.panelModels.Location = new System.Drawing.Point(163, 27);
            this.panelModels.Name = "panelModels";
            this.panelModels.Size = new System.Drawing.Size(1021, 709);
            this.panelModels.TabIndex = 16;
            this.panelModels.Visible = false;
            this.panelModels.VisibleChanged += new System.EventHandler(this.ModelsView);
            // 
            // toolStripModels
            // 
            this.toolStripModels.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStripModels.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolModelLabelLabel1,
            this.toolModelAdd,
            this.toolModelEdit,
            this.toolModelDelete,
            this.toolModelFilterReset,
            this.toolModelFilter,
            this.toolModelFilterLabel});
            this.toolStripModels.Location = new System.Drawing.Point(0, 0);
            this.toolStripModels.Name = "toolStripModels";
            this.toolStripModels.Size = new System.Drawing.Size(1021, 25);
            this.toolStripModels.TabIndex = 10;
            this.toolStripModels.Text = "toolStrip1";
            // 
            // toolModelLabelLabel1
            // 
            this.toolModelLabelLabel1.AutoSize = false;
            this.toolModelLabelLabel1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.toolModelLabelLabel1.Name = "toolModelLabelLabel1";
            this.toolModelLabelLabel1.Size = new System.Drawing.Size(170, 22);
            this.toolModelLabelLabel1.Text = "Модели";
            this.toolModelLabelLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // toolModelAdd
            // 
            this.toolModelAdd.Image = global::CompStore.Properties.Resources.add;
            this.toolModelAdd.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolModelAdd.Name = "toolModelAdd";
            this.toolModelAdd.Size = new System.Drawing.Size(79, 22);
            this.toolModelAdd.Text = "Добавить";
            this.toolModelAdd.Click += new System.EventHandler(this.ModelAdd);
            // 
            // toolModelEdit
            // 
            this.toolModelEdit.Image = global::CompStore.Properties.Resources.edit;
            this.toolModelEdit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolModelEdit.Name = "toolModelEdit";
            this.toolModelEdit.Size = new System.Drawing.Size(81, 22);
            this.toolModelEdit.Text = "Изменить";
            this.toolModelEdit.Click += new System.EventHandler(this.ModelEdit);
            // 
            // toolModelDelete
            // 
            this.toolModelDelete.Image = ((System.Drawing.Image)(resources.GetObject("toolModelDelete.Image")));
            this.toolModelDelete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolModelDelete.Name = "toolModelDelete";
            this.toolModelDelete.Size = new System.Drawing.Size(71, 22);
            this.toolModelDelete.Text = "Удалить";
            this.toolModelDelete.Click += new System.EventHandler(this.ModelEdit);
            // 
            // toolModelFilterReset
            // 
            this.toolModelFilterReset.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolModelFilterReset.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolModelFilterReset.Image = global::CompStore.Properties.Resources.cancel;
            this.toolModelFilterReset.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolModelFilterReset.Name = "toolModelFilterReset";
            this.toolModelFilterReset.Size = new System.Drawing.Size(23, 22);
            this.toolModelFilterReset.Click += new System.EventHandler(this.ModelFilterReset);
            // 
            // toolModelFilter
            // 
            this.toolModelFilter.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolModelFilter.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.toolModelFilter.Name = "toolModelFilter";
            this.toolModelFilter.Size = new System.Drawing.Size(300, 25);
            this.toolModelFilter.TextChanged += new System.EventHandler(this.ModelsDraw);
            // 
            // toolModelFilterLabel
            // 
            this.toolModelFilterLabel.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolModelFilterLabel.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolModelFilterLabel.Image = global::CompStore.Properties.Resources.search;
            this.toolModelFilterLabel.Name = "toolModelFilterLabel";
            this.toolModelFilterLabel.Size = new System.Drawing.Size(16, 22);
            // 
            // listModels
            // 
            this.listModels.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listModels.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnModelEqType,
            this.columnModelBrand,
            this.columnModelName,
            this.columnModelComment});
            this.listModels.ContextMenuStrip = this.contextMenuModels;
            this.listModels.FullRowSelect = true;
            this.listModels.HideSelection = false;
            this.listModels.Location = new System.Drawing.Point(0, 25);
            this.listModels.MultiSelect = false;
            this.listModels.Name = "listModels";
            this.listModels.Size = new System.Drawing.Size(1021, 684);
            this.listModels.TabIndex = 2;
            this.listModels.UseCompatibleStateImageBehavior = false;
            this.listModels.View = System.Windows.Forms.View.Details;
            this.listModels.SelectedIndexChanged += new System.EventHandler(this.ModelsSelChange);
            this.listModels.DoubleClick += new System.EventHandler(this.ModelEdit);
            this.listModels.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ModelsKeyboard);
            // 
            // columnModelEqType
            // 
            this.columnModelEqType.Text = "Тип оборудования";
            this.columnModelEqType.Width = 200;
            // 
            // columnModelBrand
            // 
            this.columnModelBrand.Text = "Производитель";
            this.columnModelBrand.Width = 200;
            // 
            // columnModelName
            // 
            this.columnModelName.Text = "Название";
            this.columnModelName.Width = 200;
            // 
            // columnModelComment
            // 
            this.columnModelComment.Text = "Примечание";
            this.columnModelComment.Width = 390;
            // 
            // contextMenuModels
            // 
            this.contextMenuModels.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cmModelAdd,
            this.cmModelEdit,
            this.cmModelDelete});
            this.contextMenuModels.Name = "contextMenuEquipment";
            this.contextMenuModels.Size = new System.Drawing.Size(149, 70);
            // 
            // cmModelAdd
            // 
            this.cmModelAdd.Image = global::CompStore.Properties.Resources.add;
            this.cmModelAdd.Name = "cmModelAdd";
            this.cmModelAdd.ShortcutKeys = System.Windows.Forms.Keys.Insert;
            this.cmModelAdd.Size = new System.Drawing.Size(148, 22);
            this.cmModelAdd.Text = "Добавить";
            this.cmModelAdd.Click += new System.EventHandler(this.ModelAdd);
            // 
            // cmModelEdit
            // 
            this.cmModelEdit.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.cmModelEdit.Image = global::CompStore.Properties.Resources.edit;
            this.cmModelEdit.Name = "cmModelEdit";
            this.cmModelEdit.Size = new System.Drawing.Size(148, 22);
            this.cmModelEdit.Text = "Изменить";
            this.cmModelEdit.Click += new System.EventHandler(this.ModelEdit);
            // 
            // cmModelDelete
            // 
            this.cmModelDelete.Image = ((System.Drawing.Image)(resources.GetObject("cmModelDelete.Image")));
            this.cmModelDelete.Name = "cmModelDelete";
            this.cmModelDelete.ShortcutKeys = System.Windows.Forms.Keys.Delete;
            this.cmModelDelete.Size = new System.Drawing.Size(148, 22);
            this.cmModelDelete.Text = "Удалить";
            this.cmModelDelete.Click += new System.EventHandler(this.ModelDelete);
            // 
            // panelProviders
            // 
            this.panelProviders.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelProviders.Controls.Add(this.toolStripProviders);
            this.panelProviders.Controls.Add(this.listProviders);
            this.panelProviders.Location = new System.Drawing.Point(163, 27);
            this.panelProviders.Name = "panelProviders";
            this.panelProviders.Size = new System.Drawing.Size(1021, 709);
            this.panelProviders.TabIndex = 18;
            this.panelProviders.Visible = false;
            this.panelProviders.VisibleChanged += new System.EventHandler(this.ProvidersView);
            // 
            // toolStripProviders
            // 
            this.toolStripProviders.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStripProviders.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabelProviders,
            this.toolProviderAdd,
            this.toolProviderEdit,
            this.toolProviderDelete,
            this.toolProviderFilterReset,
            this.toolProviderFilter,
            this.toolProviderFilterLabel});
            this.toolStripProviders.Location = new System.Drawing.Point(0, 0);
            this.toolStripProviders.Name = "toolStripProviders";
            this.toolStripProviders.Size = new System.Drawing.Size(1021, 25);
            this.toolStripProviders.TabIndex = 13;
            this.toolStripProviders.Text = "toolStrip1";
            // 
            // toolStripLabelProviders
            // 
            this.toolStripLabelProviders.AutoSize = false;
            this.toolStripLabelProviders.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.toolStripLabelProviders.Name = "toolStripLabelProviders";
            this.toolStripLabelProviders.Size = new System.Drawing.Size(170, 22);
            this.toolStripLabelProviders.Text = "Филиалы";
            this.toolStripLabelProviders.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // toolProviderAdd
            // 
            this.toolProviderAdd.Image = global::CompStore.Properties.Resources.add;
            this.toolProviderAdd.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolProviderAdd.Name = "toolProviderAdd";
            this.toolProviderAdd.Size = new System.Drawing.Size(79, 22);
            this.toolProviderAdd.Text = "Добавить";
            this.toolProviderAdd.Click += new System.EventHandler(this.ProviderAdd);
            // 
            // toolProviderEdit
            // 
            this.toolProviderEdit.Image = global::CompStore.Properties.Resources.edit;
            this.toolProviderEdit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolProviderEdit.Name = "toolProviderEdit";
            this.toolProviderEdit.Size = new System.Drawing.Size(81, 22);
            this.toolProviderEdit.Text = "Изменить";
            this.toolProviderEdit.Click += new System.EventHandler(this.ProviderEdit);
            // 
            // toolProviderDelete
            // 
            this.toolProviderDelete.Image = ((System.Drawing.Image)(resources.GetObject("toolProviderDelete.Image")));
            this.toolProviderDelete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolProviderDelete.Name = "toolProviderDelete";
            this.toolProviderDelete.Size = new System.Drawing.Size(71, 22);
            this.toolProviderDelete.Text = "Удалить";
            this.toolProviderDelete.Click += new System.EventHandler(this.ProviderDelete);
            // 
            // toolProviderFilterReset
            // 
            this.toolProviderFilterReset.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolProviderFilterReset.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolProviderFilterReset.Image = global::CompStore.Properties.Resources.cancel;
            this.toolProviderFilterReset.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolProviderFilterReset.Name = "toolProviderFilterReset";
            this.toolProviderFilterReset.Size = new System.Drawing.Size(23, 22);
            this.toolProviderFilterReset.Click += new System.EventHandler(this.ProviderFilterReset);
            // 
            // toolProviderFilter
            // 
            this.toolProviderFilter.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolProviderFilter.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.toolProviderFilter.Name = "toolProviderFilter";
            this.toolProviderFilter.Size = new System.Drawing.Size(300, 25);
            this.toolProviderFilter.TextChanged += new System.EventHandler(this.ProvidersDraw);
            // 
            // toolProviderFilterLabel
            // 
            this.toolProviderFilterLabel.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolProviderFilterLabel.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolProviderFilterLabel.Image = global::CompStore.Properties.Resources.search;
            this.toolProviderFilterLabel.Name = "toolProviderFilterLabel";
            this.toolProviderFilterLabel.Size = new System.Drawing.Size(16, 22);
            // 
            // listProviders
            // 
            this.listProviders.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listProviders.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnProviderName,
            this.columnProviderAdress,
            this.columnProviderPhone,
            this.columnProviderManager,
            this.columnProviderComment});
            this.listProviders.ContextMenuStrip = this.contextMenuProviders;
            this.listProviders.FullRowSelect = true;
            this.listProviders.HideSelection = false;
            this.listProviders.Location = new System.Drawing.Point(0, 25);
            this.listProviders.MultiSelect = false;
            this.listProviders.Name = "listProviders";
            this.listProviders.Size = new System.Drawing.Size(1021, 684);
            this.listProviders.TabIndex = 2;
            this.listProviders.UseCompatibleStateImageBehavior = false;
            this.listProviders.View = System.Windows.Forms.View.Details;
            this.listProviders.SelectedIndexChanged += new System.EventHandler(this.ProvidersSelChange);
            this.listProviders.DoubleClick += new System.EventHandler(this.ProviderEdit);
            this.listProviders.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ProvidersKeyboard);
            // 
            // columnProviderName
            // 
            this.columnProviderName.Text = "Название";
            this.columnProviderName.Width = 200;
            // 
            // columnProviderAdress
            // 
            this.columnProviderAdress.Text = "Адрес";
            this.columnProviderAdress.Width = 200;
            // 
            // columnProviderPhone
            // 
            this.columnProviderPhone.Text = "Телефоны";
            this.columnProviderPhone.Width = 200;
            // 
            // columnProviderManager
            // 
            this.columnProviderManager.Text = "Контактное лицо";
            this.columnProviderManager.Width = 200;
            // 
            // columnProviderComment
            // 
            this.columnProviderComment.Text = "Примечание";
            this.columnProviderComment.Width = 190;
            // 
            // contextMenuProviders
            // 
            this.contextMenuProviders.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cmProviderAdd,
            this.cmProviderEdit,
            this.cmProviderDelete});
            this.contextMenuProviders.Name = "contextMenuEquipment";
            this.contextMenuProviders.Size = new System.Drawing.Size(149, 70);
            // 
            // cmProviderAdd
            // 
            this.cmProviderAdd.Image = global::CompStore.Properties.Resources.add;
            this.cmProviderAdd.Name = "cmProviderAdd";
            this.cmProviderAdd.ShortcutKeys = System.Windows.Forms.Keys.Insert;
            this.cmProviderAdd.Size = new System.Drawing.Size(148, 22);
            this.cmProviderAdd.Text = "Добавить";
            this.cmProviderAdd.Click += new System.EventHandler(this.ProviderAdd);
            // 
            // cmProviderEdit
            // 
            this.cmProviderEdit.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.cmProviderEdit.Image = global::CompStore.Properties.Resources.edit;
            this.cmProviderEdit.Name = "cmProviderEdit";
            this.cmProviderEdit.Size = new System.Drawing.Size(148, 22);
            this.cmProviderEdit.Text = "Изменить";
            this.cmProviderEdit.Click += new System.EventHandler(this.ProviderEdit);
            // 
            // cmProviderDelete
            // 
            this.cmProviderDelete.Image = ((System.Drawing.Image)(resources.GetObject("cmProviderDelete.Image")));
            this.cmProviderDelete.Name = "cmProviderDelete";
            this.cmProviderDelete.ShortcutKeys = System.Windows.Forms.Keys.Delete;
            this.cmProviderDelete.Size = new System.Drawing.Size(148, 22);
            this.cmProviderDelete.Text = "Удалить";
            this.cmProviderDelete.Click += new System.EventHandler(this.ProviderDelete);
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
            this.tRefill});
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
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 761);
            this.Controls.Add(this.panelList);
            this.Controls.Add(this.panelProviders);
            this.Controls.Add(this.panelEqTypes);
            this.Controls.Add(this.panelBrands);
            this.Controls.Add(this.panelModels);
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
            this.panelBrands.ResumeLayout(false);
            this.panelBrands.PerformLayout();
            this.toolStripBrands.ResumeLayout(false);
            this.toolStripBrands.PerformLayout();
            this.contextMenuBrands.ResumeLayout(false);
            this.panelEqTypes.ResumeLayout(false);
            this.panelEqTypes.PerformLayout();
            this.toolStripEqTypes.ResumeLayout(false);
            this.toolStripEqTypes.PerformLayout();
            this.contextMenuEqTypes.ResumeLayout(false);
            this.panelModels.ResumeLayout(false);
            this.panelModels.PerformLayout();
            this.toolStripModels.ResumeLayout(false);
            this.toolStripModels.PerformLayout();
            this.contextMenuModels.ResumeLayout(false);
            this.panelProviders.ResumeLayout(false);
            this.panelProviders.PerformLayout();
            this.toolStripProviders.ResumeLayout(false);
            this.toolStripProviders.PerformLayout();
            this.contextMenuProviders.ResumeLayout(false);
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
        private System.Windows.Forms.Panel panelBrands;
        private System.Windows.Forms.ListView listBrands;
        private System.Windows.Forms.ColumnHeader columnBrandName;
        private System.Windows.Forms.ColumnHeader columnBrandCom;
        private System.Windows.Forms.Panel panelEqTypes;
        private System.Windows.Forms.ListView listEqTypes;
        private System.Windows.Forms.ColumnHeader columnEqType;
        private System.Windows.Forms.Panel panelModels;
        private System.Windows.Forms.ListView listModels;
        private System.Windows.Forms.ColumnHeader columnModelEqType;
        private System.Windows.Forms.ColumnHeader columnModelBrand;
        private System.Windows.Forms.ColumnHeader columnModelName;
        private System.Windows.Forms.ColumnHeader columnModelComment;
        private System.Windows.Forms.ToolStrip toolStripEqTypes;
        private System.Windows.Forms.ToolStripLabel toolETLabel;
        private System.Windows.Forms.ToolStripButton toolETAdd;
        private System.Windows.Forms.ToolStripButton toolETEdit;
        private System.Windows.Forms.ToolStripButton toolETDelete;
        private System.Windows.Forms.ToolStripButton toolETFilterReset;
        private System.Windows.Forms.ToolStripTextBox toolETFilter;
        private System.Windows.Forms.ToolStripLabel toolETFilterLabel;
        private System.Windows.Forms.ToolStrip toolStripModels;
        private System.Windows.Forms.ToolStripLabel toolModelLabelLabel1;
        private System.Windows.Forms.ToolStripButton toolModelAdd;
        private System.Windows.Forms.ToolStripButton toolModelEdit;
        private System.Windows.Forms.ToolStripButton toolModelDelete;
        private System.Windows.Forms.ToolStripButton toolModelFilterReset;
        private System.Windows.Forms.ToolStripTextBox toolModelFilter;
        private System.Windows.Forms.ToolStripLabel toolModelFilterLabel;
        private System.Windows.Forms.ToolStrip toolStripBrands;
        private System.Windows.Forms.ToolStripLabel toolBrandLabel;
        private System.Windows.Forms.ToolStripButton toolBrandAdd;
        private System.Windows.Forms.ToolStripButton toolBrandEdit;
        private System.Windows.Forms.ToolStripButton toolBrandDelete;
        private System.Windows.Forms.ToolStripButton toolBrandFilterReset;
        private System.Windows.Forms.ToolStripTextBox toolBrandFilter;
        private System.Windows.Forms.ToolStripLabel toolBrandFilterLabel;
        private System.Windows.Forms.ContextMenuStrip contextMenuBrands;
        private System.Windows.Forms.ToolStripMenuItem cmBrandAdd;
        private System.Windows.Forms.ToolStripMenuItem cmBrandEdit;
        private System.Windows.Forms.ToolStripMenuItem cmBrandDelete;
        private System.Windows.Forms.ContextMenuStrip contextMenuEqTypes;
        private System.Windows.Forms.ToolStripMenuItem cmETAdd;
        private System.Windows.Forms.ToolStripMenuItem cmETEdit;
        private System.Windows.Forms.ToolStripMenuItem cmETDelete;
        private System.Windows.Forms.ContextMenuStrip contextMenuModels;
        private System.Windows.Forms.ToolStripMenuItem cmModelAdd;
        private System.Windows.Forms.ToolStripMenuItem cmModelEdit;
        private System.Windows.Forms.ToolStripMenuItem cmModelDelete;
        private System.Windows.Forms.Panel panelProviders;
        private System.Windows.Forms.ToolStrip toolStripProviders;
        private System.Windows.Forms.ToolStripLabel toolStripLabelProviders;
        private System.Windows.Forms.ToolStripButton toolProviderAdd;
        private System.Windows.Forms.ToolStripButton toolProviderEdit;
        private System.Windows.Forms.ToolStripButton toolProviderDelete;
        private System.Windows.Forms.ToolStripButton toolProviderFilterReset;
        private System.Windows.Forms.ToolStripTextBox toolProviderFilter;
        private System.Windows.Forms.ToolStripLabel toolProviderFilterLabel;
        private System.Windows.Forms.ListView listProviders;
        private System.Windows.Forms.ColumnHeader columnProviderName;
        private System.Windows.Forms.ColumnHeader columnProviderAdress;
        private System.Windows.Forms.ColumnHeader columnProviderPhone;
        private System.Windows.Forms.ColumnHeader columnProviderManager;
        private System.Windows.Forms.ColumnHeader columnProviderComment;
        private System.Windows.Forms.ContextMenuStrip contextMenuProviders;
        private System.Windows.Forms.ToolStripMenuItem cmProviderAdd;
        private System.Windows.Forms.ToolStripMenuItem cmProviderEdit;
        private System.Windows.Forms.ToolStripMenuItem cmProviderDelete;
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
    }
}

