
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
            System.Windows.Forms.TreeNode treeNode40 = new System.Windows.Forms.TreeNode("Филиалы");
            System.Windows.Forms.TreeNode treeNode41 = new System.Windows.Forms.TreeNode("Здания");
            System.Windows.Forms.TreeNode treeNode42 = new System.Windows.Forms.TreeNode("Помещения");
            System.Windows.Forms.TreeNode treeNode43 = new System.Windows.Forms.TreeNode("Подразделения");
            System.Windows.Forms.TreeNode treeNode44 = new System.Windows.Forms.TreeNode("Должности");
            System.Windows.Forms.TreeNode treeNode45 = new System.Windows.Forms.TreeNode("Сотрудники");
            System.Windows.Forms.TreeNode treeNode46 = new System.Windows.Forms.TreeNode("Предприятие", new System.Windows.Forms.TreeNode[] {
            treeNode40,
            treeNode41,
            treeNode42,
            treeNode43,
            treeNode44,
            treeNode45});
            System.Windows.Forms.TreeNode treeNode47 = new System.Windows.Forms.TreeNode("Перемещения");
            System.Windows.Forms.TreeNode treeNode48 = new System.Windows.Forms.TreeNode("Оборудование", new System.Windows.Forms.TreeNode[] {
            treeNode47});
            System.Windows.Forms.TreeNode treeNode49 = new System.Windows.Forms.TreeNode("Производители");
            System.Windows.Forms.TreeNode treeNode50 = new System.Windows.Forms.TreeNode("Типы оборудования");
            System.Windows.Forms.TreeNode treeNode51 = new System.Windows.Forms.TreeNode("Модели");
            System.Windows.Forms.TreeNode treeNode52 = new System.Windows.Forms.TreeNode("Общие разделы", new System.Windows.Forms.TreeNode[] {
            treeNode49,
            treeNode50,
            treeNode51});
            this.treeMenu = new System.Windows.Forms.TreeView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.инициализацияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.справкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.оПрограммеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.panelEquipment = new System.Windows.Forms.Panel();
            this.labelEquipment = new System.Windows.Forms.Label();
            this.panelFilials = new System.Windows.Forms.Panel();
            this.labelFilialFilter = new System.Windows.Forms.Label();
            this.buttonFilialResetFilter = new System.Windows.Forms.Button();
            this.textFilialFilter = new System.Windows.Forms.TextBox();
            this.buttonFDel = new System.Windows.Forms.Button();
            this.buttonFEdit = new System.Windows.Forms.Button();
            this.buttonFAdd = new System.Windows.Forms.Button();
            this.listFilials = new System.Windows.Forms.ListView();
            this.colFilName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colFilAdress = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colFilCom = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.labelFilials = new System.Windows.Forms.Label();
            this.panelRooms = new System.Windows.Forms.Panel();
            this.labelRoomsFilter = new System.Windows.Forms.Label();
            this.buttonRoomsFilterReset = new System.Windows.Forms.Button();
            this.textRoomFilter = new System.Windows.Forms.TextBox();
            this.buttonRoomDelete = new System.Windows.Forms.Button();
            this.buttonRoomEdit = new System.Windows.Forms.Button();
            this.buttonRoomAdd = new System.Windows.Forms.Button();
            this.listRooms = new System.Windows.Forms.ListView();
            this.columnRoomFilial = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnRoomBuilding = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnRoomName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnRoomCom = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.labelRooms = new System.Windows.Forms.Label();
            this.panelPosts = new System.Windows.Forms.Panel();
            this.labelPostFiltr = new System.Windows.Forms.Label();
            this.buttonPostFilterReset = new System.Windows.Forms.Button();
            this.textPostFilter = new System.Windows.Forms.TextBox();
            this.buttonPostDelete = new System.Windows.Forms.Button();
            this.buttonPostEdit = new System.Windows.Forms.Button();
            this.buttonPostAdd = new System.Windows.Forms.Button();
            this.listPosts = new System.Windows.Forms.ListView();
            this.columnPostName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.labelPosts = new System.Windows.Forms.Label();
            this.panelBuildings = new System.Windows.Forms.Panel();
            this.labelBuildingFilter = new System.Windows.Forms.Label();
            this.buttonBuildingFilterReset = new System.Windows.Forms.Button();
            this.textBuildingFilter = new System.Windows.Forms.TextBox();
            this.buttonBuildingDelete = new System.Windows.Forms.Button();
            this.buttonBuildingEdit = new System.Windows.Forms.Button();
            this.buttonBuildingAdd = new System.Windows.Forms.Button();
            this.listBuildings = new System.Windows.Forms.ListView();
            this.columnBuildingFilial = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnBuildingName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnBuildingComment = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.labelBuildings = new System.Windows.Forms.Label();
            this.panelDeps = new System.Windows.Forms.Panel();
            this.labelDepFilter = new System.Windows.Forms.Label();
            this.buttonDepFilterReset = new System.Windows.Forms.Button();
            this.textDepFilter = new System.Windows.Forms.TextBox();
            this.buttonDepDelete = new System.Windows.Forms.Button();
            this.buttonDepEdit = new System.Windows.Forms.Button();
            this.buttonDepAdd = new System.Windows.Forms.Button();
            this.listDeps = new System.Windows.Forms.ListView();
            this.columnDepName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnDepComment = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.labelDeps = new System.Windows.Forms.Label();
            this.panelUsers = new System.Windows.Forms.Panel();
            this.labelUserFilter = new System.Windows.Forms.Label();
            this.buttonUserFilterReset = new System.Windows.Forms.Button();
            this.textUserFilter = new System.Windows.Forms.TextBox();
            this.buttonUserDelete = new System.Windows.Forms.Button();
            this.buttonUserEdit = new System.Windows.Forms.Button();
            this.buttonUserAdd = new System.Windows.Forms.Button();
            this.listUsers = new System.Windows.Forms.ListView();
            this.columnUserName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnUserDep = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnUserPost = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnUserPlace = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnUserCom = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.labelUsers = new System.Windows.Forms.Label();
            this.panelBrands = new System.Windows.Forms.Panel();
            this.labelBrandFilter = new System.Windows.Forms.Label();
            this.buttonBrandFilterReset = new System.Windows.Forms.Button();
            this.textBrandFilter = new System.Windows.Forms.TextBox();
            this.buttonBrandDelete = new System.Windows.Forms.Button();
            this.buttonBrandEdit = new System.Windows.Forms.Button();
            this.buttonBrandAdd = new System.Windows.Forms.Button();
            this.listBrands = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.labelBrands = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.panelEquipment.SuspendLayout();
            this.panelFilials.SuspendLayout();
            this.panelRooms.SuspendLayout();
            this.panelPosts.SuspendLayout();
            this.panelBuildings.SuspendLayout();
            this.panelDeps.SuspendLayout();
            this.panelUsers.SuspendLayout();
            this.panelBrands.SuspendLayout();
            this.SuspendLayout();
            // 
            // treeMenu
            // 
            this.treeMenu.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.treeMenu.ItemHeight = 24;
            this.treeMenu.Location = new System.Drawing.Point(0, 27);
            this.treeMenu.Name = "treeMenu";
            treeNode40.Name = "nodeFilials";
            treeNode40.Text = "Филиалы";
            treeNode41.Name = "nodeBuildings";
            treeNode41.Text = "Здания";
            treeNode42.Name = "nodeRooms";
            treeNode42.Text = "Помещения";
            treeNode43.Name = "nodeDeps";
            treeNode43.Text = "Подразделения";
            treeNode44.Name = "nodePosts";
            treeNode44.Text = "Должности";
            treeNode45.Name = "nodeUsers";
            treeNode45.Text = "Сотрудники";
            treeNode46.Name = "nodeCompany";
            treeNode46.Text = "Предприятие";
            treeNode47.Name = "nodeMoves";
            treeNode47.Text = "Перемещения";
            treeNode48.Name = "nodeEquipment";
            treeNode48.Text = "Оборудование";
            treeNode49.Name = "nodeBrands";
            treeNode49.Text = "Производители";
            treeNode50.Name = "nodeEqType";
            treeNode50.Text = "Типы оборудования";
            treeNode51.Name = "nodeModels";
            treeNode51.Text = "Модели";
            treeNode52.Name = "nodeCommon";
            treeNode52.Text = "Общие разделы";
            this.treeMenu.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode46,
            treeNode48,
            treeNode52});
            this.treeMenu.Size = new System.Drawing.Size(157, 709);
            this.treeMenu.TabIndex = 0;
            this.treeMenu.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.TabChange);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.справкаToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1184, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.инициализацияToolStripMenuItem,
            this.выходToolStripMenuItem});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // инициализацияToolStripMenuItem
            // 
            this.инициализацияToolStripMenuItem.Name = "инициализацияToolStripMenuItem";
            this.инициализацияToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.инициализацияToolStripMenuItem.Text = "Инициализация";
            this.инициализацияToolStripMenuItem.Click += new System.EventHandler(this.инициализацияToolStripMenuItem_Click);
            // 
            // выходToolStripMenuItem
            // 
            this.выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            this.выходToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.выходToolStripMenuItem.Text = "Выход";
            // 
            // справкаToolStripMenuItem
            // 
            this.справкаToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.оПрограммеToolStripMenuItem});
            this.справкаToolStripMenuItem.Name = "справкаToolStripMenuItem";
            this.справкаToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.справкаToolStripMenuItem.Text = "Справка";
            // 
            // оПрограммеToolStripMenuItem
            // 
            this.оПрограммеToolStripMenuItem.Name = "оПрограммеToolStripMenuItem";
            this.оПрограммеToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.оПрограммеToolStripMenuItem.Text = "О программе";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 739);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1184, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // panelEquipment
            // 
            this.panelEquipment.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelEquipment.Controls.Add(this.labelEquipment);
            this.panelEquipment.Location = new System.Drawing.Point(237, 323);
            this.panelEquipment.Name = "panelEquipment";
            this.panelEquipment.Size = new System.Drawing.Size(1019, 709);
            this.panelEquipment.TabIndex = 5;
            this.panelEquipment.Visible = false;
            // 
            // labelEquipment
            // 
            this.labelEquipment.AutoSize = true;
            this.labelEquipment.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelEquipment.Location = new System.Drawing.Point(3, 0);
            this.labelEquipment.Name = "labelEquipment";
            this.labelEquipment.Size = new System.Drawing.Size(132, 20);
            this.labelEquipment.TabIndex = 1;
            this.labelEquipment.Text = "Оборудование";
            // 
            // panelFilials
            // 
            this.panelFilials.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelFilials.Controls.Add(this.labelFilialFilter);
            this.panelFilials.Controls.Add(this.buttonFilialResetFilter);
            this.panelFilials.Controls.Add(this.textFilialFilter);
            this.panelFilials.Controls.Add(this.buttonFDel);
            this.panelFilials.Controls.Add(this.buttonFEdit);
            this.panelFilials.Controls.Add(this.buttonFAdd);
            this.panelFilials.Controls.Add(this.listFilials);
            this.panelFilials.Controls.Add(this.labelFilials);
            this.panelFilials.Location = new System.Drawing.Point(813, 27);
            this.panelFilials.Name = "panelFilials";
            this.panelFilials.Size = new System.Drawing.Size(1021, 709);
            this.panelFilials.TabIndex = 6;
            this.panelFilials.Visible = false;
            this.panelFilials.VisibleChanged += new System.EventHandler(this.FilialsView);
            // 
            // labelFilialFilter
            // 
            this.labelFilialFilter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelFilialFilter.AutoSize = true;
            this.labelFilialFilter.Location = new System.Drawing.Point(575, 28);
            this.labelFilialFilter.Name = "labelFilialFilter";
            this.labelFilialFilter.Size = new System.Drawing.Size(47, 13);
            this.labelFilialFilter.TabIndex = 8;
            this.labelFilialFilter.Text = "Фильтр";
            // 
            // buttonFilialResetFilter
            // 
            this.buttonFilialResetFilter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonFilialResetFilter.Location = new System.Drawing.Point(934, 23);
            this.buttonFilialResetFilter.Name = "buttonFilialResetFilter";
            this.buttonFilialResetFilter.Size = new System.Drawing.Size(75, 23);
            this.buttonFilialResetFilter.TabIndex = 7;
            this.buttonFilialResetFilter.Text = "Очистить";
            this.buttonFilialResetFilter.UseVisualStyleBackColor = true;
            this.buttonFilialResetFilter.Click += new System.EventHandler(this.FilialFilterReset);
            // 
            // textFilialFilter
            // 
            this.textFilialFilter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textFilialFilter.Location = new System.Drawing.Point(628, 25);
            this.textFilialFilter.Name = "textFilialFilter";
            this.textFilialFilter.Size = new System.Drawing.Size(300, 20);
            this.textFilialFilter.TabIndex = 6;
            this.textFilialFilter.TextChanged += new System.EventHandler(this.FilialsDraw);
            // 
            // buttonFDel
            // 
            this.buttonFDel.Enabled = false;
            this.buttonFDel.Location = new System.Drawing.Point(162, 23);
            this.buttonFDel.Name = "buttonFDel";
            this.buttonFDel.Size = new System.Drawing.Size(75, 23);
            this.buttonFDel.TabIndex = 5;
            this.buttonFDel.Text = "Удалить";
            this.buttonFDel.UseVisualStyleBackColor = true;
            this.buttonFDel.Click += new System.EventHandler(this.FilialDelete);
            // 
            // buttonFEdit
            // 
            this.buttonFEdit.Enabled = false;
            this.buttonFEdit.Location = new System.Drawing.Point(81, 23);
            this.buttonFEdit.Name = "buttonFEdit";
            this.buttonFEdit.Size = new System.Drawing.Size(75, 23);
            this.buttonFEdit.TabIndex = 4;
            this.buttonFEdit.Text = "Править";
            this.buttonFEdit.UseVisualStyleBackColor = true;
            this.buttonFEdit.Click += new System.EventHandler(this.FilialEdit);
            // 
            // buttonFAdd
            // 
            this.buttonFAdd.Location = new System.Drawing.Point(0, 23);
            this.buttonFAdd.Name = "buttonFAdd";
            this.buttonFAdd.Size = new System.Drawing.Size(75, 23);
            this.buttonFAdd.TabIndex = 3;
            this.buttonFAdd.Text = "Добавить";
            this.buttonFAdd.UseVisualStyleBackColor = true;
            this.buttonFAdd.Click += new System.EventHandler(this.FilialAdd);
            // 
            // listFilials
            // 
            this.listFilials.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listFilials.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colFilName,
            this.colFilAdress,
            this.colFilCom});
            this.listFilials.FullRowSelect = true;
            this.listFilials.HideSelection = false;
            this.listFilials.Location = new System.Drawing.Point(0, 52);
            this.listFilials.MultiSelect = false;
            this.listFilials.Name = "listFilials";
            this.listFilials.Size = new System.Drawing.Size(1021, 657);
            this.listFilials.TabIndex = 2;
            this.listFilials.UseCompatibleStateImageBehavior = false;
            this.listFilials.View = System.Windows.Forms.View.Details;
            this.listFilials.SelectedIndexChanged += new System.EventHandler(this.FilialsSelChange);
            this.listFilials.DoubleClick += new System.EventHandler(this.FilialEdit);
            // 
            // colFilName
            // 
            this.colFilName.Text = "Название";
            this.colFilName.Width = 200;
            // 
            // colFilAdress
            // 
            this.colFilAdress.Text = "Адрес";
            this.colFilAdress.Width = 400;
            // 
            // colFilCom
            // 
            this.colFilCom.Text = "Примечание";
            this.colFilCom.Width = 390;
            // 
            // labelFilials
            // 
            this.labelFilials.AutoSize = true;
            this.labelFilials.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelFilials.Location = new System.Drawing.Point(3, 0);
            this.labelFilials.Name = "labelFilials";
            this.labelFilials.Size = new System.Drawing.Size(89, 20);
            this.labelFilials.TabIndex = 1;
            this.labelFilials.Text = "Филиалы";
            // 
            // panelRooms
            // 
            this.panelRooms.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelRooms.Controls.Add(this.labelRoomsFilter);
            this.panelRooms.Controls.Add(this.buttonRoomsFilterReset);
            this.panelRooms.Controls.Add(this.textRoomFilter);
            this.panelRooms.Controls.Add(this.buttonRoomDelete);
            this.panelRooms.Controls.Add(this.buttonRoomEdit);
            this.panelRooms.Controls.Add(this.buttonRoomAdd);
            this.panelRooms.Controls.Add(this.listRooms);
            this.panelRooms.Controls.Add(this.labelRooms);
            this.panelRooms.Location = new System.Drawing.Point(414, 179);
            this.panelRooms.Name = "panelRooms";
            this.panelRooms.Size = new System.Drawing.Size(1021, 709);
            this.panelRooms.TabIndex = 10;
            this.panelRooms.Visible = false;
            this.panelRooms.VisibleChanged += new System.EventHandler(this.RoomsView);
            // 
            // labelRoomsFilter
            // 
            this.labelRoomsFilter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelRoomsFilter.AutoSize = true;
            this.labelRoomsFilter.Location = new System.Drawing.Point(575, 28);
            this.labelRoomsFilter.Name = "labelRoomsFilter";
            this.labelRoomsFilter.Size = new System.Drawing.Size(47, 13);
            this.labelRoomsFilter.TabIndex = 8;
            this.labelRoomsFilter.Text = "Фильтр";
            // 
            // buttonRoomsFilterReset
            // 
            this.buttonRoomsFilterReset.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonRoomsFilterReset.Location = new System.Drawing.Point(934, 23);
            this.buttonRoomsFilterReset.Name = "buttonRoomsFilterReset";
            this.buttonRoomsFilterReset.Size = new System.Drawing.Size(75, 23);
            this.buttonRoomsFilterReset.TabIndex = 7;
            this.buttonRoomsFilterReset.Text = "Очистить";
            this.buttonRoomsFilterReset.UseVisualStyleBackColor = true;
            this.buttonRoomsFilterReset.Click += new System.EventHandler(this.buttonRoomsFilterReset_Click);
            // 
            // textRoomFilter
            // 
            this.textRoomFilter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textRoomFilter.Location = new System.Drawing.Point(628, 25);
            this.textRoomFilter.Name = "textRoomFilter";
            this.textRoomFilter.Size = new System.Drawing.Size(300, 20);
            this.textRoomFilter.TabIndex = 6;
            this.textRoomFilter.TextChanged += new System.EventHandler(this.RoomsDraw);
            // 
            // buttonRoomDelete
            // 
            this.buttonRoomDelete.Enabled = false;
            this.buttonRoomDelete.Location = new System.Drawing.Point(162, 23);
            this.buttonRoomDelete.Name = "buttonRoomDelete";
            this.buttonRoomDelete.Size = new System.Drawing.Size(75, 23);
            this.buttonRoomDelete.TabIndex = 5;
            this.buttonRoomDelete.Text = "Удалить";
            this.buttonRoomDelete.UseVisualStyleBackColor = true;
            this.buttonRoomDelete.Click += new System.EventHandler(this.RoomDelete);
            // 
            // buttonRoomEdit
            // 
            this.buttonRoomEdit.Enabled = false;
            this.buttonRoomEdit.Location = new System.Drawing.Point(81, 23);
            this.buttonRoomEdit.Name = "buttonRoomEdit";
            this.buttonRoomEdit.Size = new System.Drawing.Size(75, 23);
            this.buttonRoomEdit.TabIndex = 4;
            this.buttonRoomEdit.Text = "Править";
            this.buttonRoomEdit.UseVisualStyleBackColor = true;
            this.buttonRoomEdit.Click += new System.EventHandler(this.RoomEdit);
            // 
            // buttonRoomAdd
            // 
            this.buttonRoomAdd.Location = new System.Drawing.Point(0, 23);
            this.buttonRoomAdd.Name = "buttonRoomAdd";
            this.buttonRoomAdd.Size = new System.Drawing.Size(75, 23);
            this.buttonRoomAdd.TabIndex = 3;
            this.buttonRoomAdd.Text = "Добавить";
            this.buttonRoomAdd.UseVisualStyleBackColor = true;
            this.buttonRoomAdd.Click += new System.EventHandler(this.RoomAdd);
            // 
            // listRooms
            // 
            this.listRooms.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listRooms.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnRoomFilial,
            this.columnRoomBuilding,
            this.columnRoomName,
            this.columnRoomCom});
            this.listRooms.FullRowSelect = true;
            this.listRooms.HideSelection = false;
            this.listRooms.Location = new System.Drawing.Point(0, 52);
            this.listRooms.MultiSelect = false;
            this.listRooms.Name = "listRooms";
            this.listRooms.Size = new System.Drawing.Size(1021, 657);
            this.listRooms.TabIndex = 2;
            this.listRooms.UseCompatibleStateImageBehavior = false;
            this.listRooms.View = System.Windows.Forms.View.Details;
            this.listRooms.SelectedIndexChanged += new System.EventHandler(this.RoomsSelChange);
            this.listRooms.DoubleClick += new System.EventHandler(this.RoomEdit);
            // 
            // columnRoomFilial
            // 
            this.columnRoomFilial.Text = "Филиал";
            this.columnRoomFilial.Width = 200;
            // 
            // columnRoomBuilding
            // 
            this.columnRoomBuilding.Text = "Здание";
            this.columnRoomBuilding.Width = 200;
            // 
            // columnRoomName
            // 
            this.columnRoomName.Text = "Название";
            this.columnRoomName.Width = 200;
            // 
            // columnRoomCom
            // 
            this.columnRoomCom.Text = "Примечание";
            this.columnRoomCom.Width = 390;
            // 
            // labelRooms
            // 
            this.labelRooms.AutoSize = true;
            this.labelRooms.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelRooms.Location = new System.Drawing.Point(3, 0);
            this.labelRooms.Name = "labelRooms";
            this.labelRooms.Size = new System.Drawing.Size(108, 20);
            this.labelRooms.TabIndex = 1;
            this.labelRooms.Text = "Помещения";
            // 
            // panelPosts
            // 
            this.panelPosts.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelPosts.Controls.Add(this.labelPostFiltr);
            this.panelPosts.Controls.Add(this.buttonPostFilterReset);
            this.panelPosts.Controls.Add(this.textPostFilter);
            this.panelPosts.Controls.Add(this.buttonPostDelete);
            this.panelPosts.Controls.Add(this.buttonPostEdit);
            this.panelPosts.Controls.Add(this.buttonPostAdd);
            this.panelPosts.Controls.Add(this.listPosts);
            this.panelPosts.Controls.Add(this.labelPosts);
            this.panelPosts.Location = new System.Drawing.Point(313, 255);
            this.panelPosts.Name = "panelPosts";
            this.panelPosts.Size = new System.Drawing.Size(1021, 709);
            this.panelPosts.TabIndex = 11;
            this.panelPosts.Visible = false;
            this.panelPosts.VisibleChanged += new System.EventHandler(this.PostsView);
            // 
            // labelPostFiltr
            // 
            this.labelPostFiltr.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelPostFiltr.AutoSize = true;
            this.labelPostFiltr.Location = new System.Drawing.Point(575, 28);
            this.labelPostFiltr.Name = "labelPostFiltr";
            this.labelPostFiltr.Size = new System.Drawing.Size(47, 13);
            this.labelPostFiltr.TabIndex = 8;
            this.labelPostFiltr.Text = "Фильтр";
            // 
            // buttonPostFilterReset
            // 
            this.buttonPostFilterReset.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonPostFilterReset.Location = new System.Drawing.Point(934, 23);
            this.buttonPostFilterReset.Name = "buttonPostFilterReset";
            this.buttonPostFilterReset.Size = new System.Drawing.Size(75, 23);
            this.buttonPostFilterReset.TabIndex = 7;
            this.buttonPostFilterReset.Text = "Очистить";
            this.buttonPostFilterReset.UseVisualStyleBackColor = true;
            this.buttonPostFilterReset.Click += new System.EventHandler(this.PostFilterReset);
            // 
            // textPostFilter
            // 
            this.textPostFilter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textPostFilter.Location = new System.Drawing.Point(628, 25);
            this.textPostFilter.Name = "textPostFilter";
            this.textPostFilter.Size = new System.Drawing.Size(300, 20);
            this.textPostFilter.TabIndex = 6;
            // 
            // buttonPostDelete
            // 
            this.buttonPostDelete.Enabled = false;
            this.buttonPostDelete.Location = new System.Drawing.Point(162, 23);
            this.buttonPostDelete.Name = "buttonPostDelete";
            this.buttonPostDelete.Size = new System.Drawing.Size(75, 23);
            this.buttonPostDelete.TabIndex = 5;
            this.buttonPostDelete.Text = "Удалить";
            this.buttonPostDelete.UseVisualStyleBackColor = true;
            this.buttonPostDelete.Click += new System.EventHandler(this.PostDelete);
            // 
            // buttonPostEdit
            // 
            this.buttonPostEdit.Enabled = false;
            this.buttonPostEdit.Location = new System.Drawing.Point(81, 23);
            this.buttonPostEdit.Name = "buttonPostEdit";
            this.buttonPostEdit.Size = new System.Drawing.Size(75, 23);
            this.buttonPostEdit.TabIndex = 4;
            this.buttonPostEdit.Text = "Править";
            this.buttonPostEdit.UseVisualStyleBackColor = true;
            this.buttonPostEdit.Click += new System.EventHandler(this.PostEdit);
            // 
            // buttonPostAdd
            // 
            this.buttonPostAdd.Location = new System.Drawing.Point(0, 23);
            this.buttonPostAdd.Name = "buttonPostAdd";
            this.buttonPostAdd.Size = new System.Drawing.Size(75, 23);
            this.buttonPostAdd.TabIndex = 3;
            this.buttonPostAdd.Text = "Добавить";
            this.buttonPostAdd.UseVisualStyleBackColor = true;
            this.buttonPostAdd.Click += new System.EventHandler(this.PostAdd);
            // 
            // listPosts
            // 
            this.listPosts.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listPosts.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnPostName});
            this.listPosts.FullRowSelect = true;
            this.listPosts.HideSelection = false;
            this.listPosts.Location = new System.Drawing.Point(0, 52);
            this.listPosts.MultiSelect = false;
            this.listPosts.Name = "listPosts";
            this.listPosts.Size = new System.Drawing.Size(1021, 657);
            this.listPosts.TabIndex = 2;
            this.listPosts.UseCompatibleStateImageBehavior = false;
            this.listPosts.View = System.Windows.Forms.View.Details;
            this.listPosts.SelectedIndexChanged += new System.EventHandler(this.PostsSelChange);
            this.listPosts.DoubleClick += new System.EventHandler(this.PostEdit);
            // 
            // columnPostName
            // 
            this.columnPostName.Text = "Название";
            this.columnPostName.Width = 990;
            // 
            // labelPosts
            // 
            this.labelPosts.AutoSize = true;
            this.labelPosts.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelPosts.Location = new System.Drawing.Point(3, 0);
            this.labelPosts.Name = "labelPosts";
            this.labelPosts.Size = new System.Drawing.Size(104, 20);
            this.labelPosts.TabIndex = 1;
            this.labelPosts.Text = "Должности";
            // 
            // panelBuildings
            // 
            this.panelBuildings.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelBuildings.Controls.Add(this.labelBuildingFilter);
            this.panelBuildings.Controls.Add(this.buttonBuildingFilterReset);
            this.panelBuildings.Controls.Add(this.textBuildingFilter);
            this.panelBuildings.Controls.Add(this.buttonBuildingDelete);
            this.panelBuildings.Controls.Add(this.buttonBuildingEdit);
            this.panelBuildings.Controls.Add(this.buttonBuildingAdd);
            this.panelBuildings.Controls.Add(this.listBuildings);
            this.panelBuildings.Controls.Add(this.labelBuildings);
            this.panelBuildings.Location = new System.Drawing.Point(513, 127);
            this.panelBuildings.Name = "panelBuildings";
            this.panelBuildings.Size = new System.Drawing.Size(1021, 709);
            this.panelBuildings.TabIndex = 11;
            this.panelBuildings.Visible = false;
            this.panelBuildings.VisibleChanged += new System.EventHandler(this.BuildingsView);
            // 
            // labelBuildingFilter
            // 
            this.labelBuildingFilter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelBuildingFilter.AutoSize = true;
            this.labelBuildingFilter.Location = new System.Drawing.Point(575, 28);
            this.labelBuildingFilter.Name = "labelBuildingFilter";
            this.labelBuildingFilter.Size = new System.Drawing.Size(47, 13);
            this.labelBuildingFilter.TabIndex = 8;
            this.labelBuildingFilter.Text = "Фильтр";
            // 
            // buttonBuildingFilterReset
            // 
            this.buttonBuildingFilterReset.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonBuildingFilterReset.Location = new System.Drawing.Point(934, 23);
            this.buttonBuildingFilterReset.Name = "buttonBuildingFilterReset";
            this.buttonBuildingFilterReset.Size = new System.Drawing.Size(75, 23);
            this.buttonBuildingFilterReset.TabIndex = 7;
            this.buttonBuildingFilterReset.Text = "Очистить";
            this.buttonBuildingFilterReset.UseVisualStyleBackColor = true;
            // 
            // textBuildingFilter
            // 
            this.textBuildingFilter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBuildingFilter.Location = new System.Drawing.Point(628, 25);
            this.textBuildingFilter.Name = "textBuildingFilter";
            this.textBuildingFilter.Size = new System.Drawing.Size(300, 20);
            this.textBuildingFilter.TabIndex = 6;
            // 
            // buttonBuildingDelete
            // 
            this.buttonBuildingDelete.Enabled = false;
            this.buttonBuildingDelete.Location = new System.Drawing.Point(162, 23);
            this.buttonBuildingDelete.Name = "buttonBuildingDelete";
            this.buttonBuildingDelete.Size = new System.Drawing.Size(75, 23);
            this.buttonBuildingDelete.TabIndex = 5;
            this.buttonBuildingDelete.Text = "Удалить";
            this.buttonBuildingDelete.UseVisualStyleBackColor = true;
            this.buttonBuildingDelete.Click += new System.EventHandler(this.BuildingDelete);
            // 
            // buttonBuildingEdit
            // 
            this.buttonBuildingEdit.Enabled = false;
            this.buttonBuildingEdit.Location = new System.Drawing.Point(81, 23);
            this.buttonBuildingEdit.Name = "buttonBuildingEdit";
            this.buttonBuildingEdit.Size = new System.Drawing.Size(75, 23);
            this.buttonBuildingEdit.TabIndex = 4;
            this.buttonBuildingEdit.Text = "Править";
            this.buttonBuildingEdit.UseVisualStyleBackColor = true;
            this.buttonBuildingEdit.Click += new System.EventHandler(this.BuildingEdit);
            // 
            // buttonBuildingAdd
            // 
            this.buttonBuildingAdd.Location = new System.Drawing.Point(0, 23);
            this.buttonBuildingAdd.Name = "buttonBuildingAdd";
            this.buttonBuildingAdd.Size = new System.Drawing.Size(75, 23);
            this.buttonBuildingAdd.TabIndex = 3;
            this.buttonBuildingAdd.Text = "Добавить";
            this.buttonBuildingAdd.UseVisualStyleBackColor = true;
            this.buttonBuildingAdd.Click += new System.EventHandler(this.BuildingAdd);
            // 
            // listBuildings
            // 
            this.listBuildings.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listBuildings.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnBuildingFilial,
            this.columnBuildingName,
            this.columnBuildingComment});
            this.listBuildings.FullRowSelect = true;
            this.listBuildings.HideSelection = false;
            this.listBuildings.Location = new System.Drawing.Point(0, 52);
            this.listBuildings.MultiSelect = false;
            this.listBuildings.Name = "listBuildings";
            this.listBuildings.Size = new System.Drawing.Size(1021, 657);
            this.listBuildings.TabIndex = 2;
            this.listBuildings.UseCompatibleStateImageBehavior = false;
            this.listBuildings.View = System.Windows.Forms.View.Details;
            this.listBuildings.SelectedIndexChanged += new System.EventHandler(this.BuildingsSelChange);
            this.listBuildings.DoubleClick += new System.EventHandler(this.BuildingEdit);
            // 
            // columnBuildingFilial
            // 
            this.columnBuildingFilial.Text = "Филиал";
            this.columnBuildingFilial.Width = 200;
            // 
            // columnBuildingName
            // 
            this.columnBuildingName.Text = "Название";
            this.columnBuildingName.Width = 200;
            // 
            // columnBuildingComment
            // 
            this.columnBuildingComment.Text = "Примечание";
            this.columnBuildingComment.Width = 590;
            // 
            // labelBuildings
            // 
            this.labelBuildings.AutoSize = true;
            this.labelBuildings.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelBuildings.Location = new System.Drawing.Point(3, 0);
            this.labelBuildings.Name = "labelBuildings";
            this.labelBuildings.Size = new System.Drawing.Size(73, 20);
            this.labelBuildings.TabIndex = 1;
            this.labelBuildings.Text = "Здания";
            // 
            // panelDeps
            // 
            this.panelDeps.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelDeps.Controls.Add(this.labelDepFilter);
            this.panelDeps.Controls.Add(this.buttonDepFilterReset);
            this.panelDeps.Controls.Add(this.textDepFilter);
            this.panelDeps.Controls.Add(this.buttonDepDelete);
            this.panelDeps.Controls.Add(this.buttonDepEdit);
            this.panelDeps.Controls.Add(this.buttonDepAdd);
            this.panelDeps.Controls.Add(this.listDeps);
            this.panelDeps.Controls.Add(this.labelDeps);
            this.panelDeps.Location = new System.Drawing.Point(594, 79);
            this.panelDeps.Name = "panelDeps";
            this.panelDeps.Size = new System.Drawing.Size(1021, 709);
            this.panelDeps.TabIndex = 12;
            this.panelDeps.Visible = false;
            this.panelDeps.VisibleChanged += new System.EventHandler(this.DepsView);
            // 
            // labelDepFilter
            // 
            this.labelDepFilter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelDepFilter.AutoSize = true;
            this.labelDepFilter.Location = new System.Drawing.Point(575, 28);
            this.labelDepFilter.Name = "labelDepFilter";
            this.labelDepFilter.Size = new System.Drawing.Size(47, 13);
            this.labelDepFilter.TabIndex = 8;
            this.labelDepFilter.Text = "Фильтр";
            // 
            // buttonDepFilterReset
            // 
            this.buttonDepFilterReset.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonDepFilterReset.Location = new System.Drawing.Point(934, 23);
            this.buttonDepFilterReset.Name = "buttonDepFilterReset";
            this.buttonDepFilterReset.Size = new System.Drawing.Size(75, 23);
            this.buttonDepFilterReset.TabIndex = 7;
            this.buttonDepFilterReset.Text = "Очистить";
            this.buttonDepFilterReset.UseVisualStyleBackColor = true;
            this.buttonDepFilterReset.Click += new System.EventHandler(this.DepFilterReset);
            // 
            // textDepFilter
            // 
            this.textDepFilter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textDepFilter.Location = new System.Drawing.Point(628, 25);
            this.textDepFilter.Name = "textDepFilter";
            this.textDepFilter.Size = new System.Drawing.Size(300, 20);
            this.textDepFilter.TabIndex = 6;
            this.textDepFilter.TextChanged += new System.EventHandler(this.DepsDraw);
            // 
            // buttonDepDelete
            // 
            this.buttonDepDelete.Enabled = false;
            this.buttonDepDelete.Location = new System.Drawing.Point(162, 23);
            this.buttonDepDelete.Name = "buttonDepDelete";
            this.buttonDepDelete.Size = new System.Drawing.Size(75, 23);
            this.buttonDepDelete.TabIndex = 5;
            this.buttonDepDelete.Text = "Удалить";
            this.buttonDepDelete.UseVisualStyleBackColor = true;
            this.buttonDepDelete.Click += new System.EventHandler(this.DepDelete);
            // 
            // buttonDepEdit
            // 
            this.buttonDepEdit.Enabled = false;
            this.buttonDepEdit.Location = new System.Drawing.Point(81, 23);
            this.buttonDepEdit.Name = "buttonDepEdit";
            this.buttonDepEdit.Size = new System.Drawing.Size(75, 23);
            this.buttonDepEdit.TabIndex = 4;
            this.buttonDepEdit.Text = "Править";
            this.buttonDepEdit.UseVisualStyleBackColor = true;
            this.buttonDepEdit.Click += new System.EventHandler(this.DepEdit);
            // 
            // buttonDepAdd
            // 
            this.buttonDepAdd.Location = new System.Drawing.Point(0, 23);
            this.buttonDepAdd.Name = "buttonDepAdd";
            this.buttonDepAdd.Size = new System.Drawing.Size(75, 23);
            this.buttonDepAdd.TabIndex = 3;
            this.buttonDepAdd.Text = "Добавить";
            this.buttonDepAdd.UseVisualStyleBackColor = true;
            this.buttonDepAdd.Click += new System.EventHandler(this.DepAdd);
            // 
            // listDeps
            // 
            this.listDeps.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listDeps.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnDepName,
            this.columnDepComment});
            this.listDeps.FullRowSelect = true;
            this.listDeps.HideSelection = false;
            this.listDeps.Location = new System.Drawing.Point(0, 52);
            this.listDeps.MultiSelect = false;
            this.listDeps.Name = "listDeps";
            this.listDeps.Size = new System.Drawing.Size(1021, 657);
            this.listDeps.TabIndex = 2;
            this.listDeps.UseCompatibleStateImageBehavior = false;
            this.listDeps.View = System.Windows.Forms.View.Details;
            this.listDeps.SelectedIndexChanged += new System.EventHandler(this.DepsSelChange);
            this.listDeps.DoubleClick += new System.EventHandler(this.DepEdit);
            // 
            // columnDepName
            // 
            this.columnDepName.Text = "Название";
            this.columnDepName.Width = 200;
            // 
            // columnDepComment
            // 
            this.columnDepComment.Text = "Примечание";
            this.columnDepComment.Width = 790;
            // 
            // labelDeps
            // 
            this.labelDeps.AutoSize = true;
            this.labelDeps.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelDeps.Location = new System.Drawing.Point(3, 0);
            this.labelDeps.Name = "labelDeps";
            this.labelDeps.Size = new System.Drawing.Size(77, 20);
            this.labelDeps.TabIndex = 1;
            this.labelDeps.Text = "Отделы";
            // 
            // panelUsers
            // 
            this.panelUsers.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelUsers.Controls.Add(this.labelUserFilter);
            this.panelUsers.Controls.Add(this.buttonUserFilterReset);
            this.panelUsers.Controls.Add(this.textUserFilter);
            this.panelUsers.Controls.Add(this.buttonUserDelete);
            this.panelUsers.Controls.Add(this.buttonUserEdit);
            this.panelUsers.Controls.Add(this.buttonUserAdd);
            this.panelUsers.Controls.Add(this.listUsers);
            this.panelUsers.Controls.Add(this.labelUsers);
            this.panelUsers.Location = new System.Drawing.Point(657, 55);
            this.panelUsers.Name = "panelUsers";
            this.panelUsers.Size = new System.Drawing.Size(1021, 709);
            this.panelUsers.TabIndex = 13;
            this.panelUsers.Visible = false;
            this.panelUsers.VisibleChanged += new System.EventHandler(this.UsersView);
            // 
            // labelUserFilter
            // 
            this.labelUserFilter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelUserFilter.AutoSize = true;
            this.labelUserFilter.Location = new System.Drawing.Point(575, 28);
            this.labelUserFilter.Name = "labelUserFilter";
            this.labelUserFilter.Size = new System.Drawing.Size(47, 13);
            this.labelUserFilter.TabIndex = 8;
            this.labelUserFilter.Text = "Фильтр";
            // 
            // buttonUserFilterReset
            // 
            this.buttonUserFilterReset.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonUserFilterReset.Location = new System.Drawing.Point(934, 23);
            this.buttonUserFilterReset.Name = "buttonUserFilterReset";
            this.buttonUserFilterReset.Size = new System.Drawing.Size(75, 23);
            this.buttonUserFilterReset.TabIndex = 7;
            this.buttonUserFilterReset.Text = "Очистить";
            this.buttonUserFilterReset.UseVisualStyleBackColor = true;
            this.buttonUserFilterReset.Click += new System.EventHandler(this.UserFilterReset);
            // 
            // textUserFilter
            // 
            this.textUserFilter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textUserFilter.Location = new System.Drawing.Point(628, 25);
            this.textUserFilter.Name = "textUserFilter";
            this.textUserFilter.Size = new System.Drawing.Size(300, 20);
            this.textUserFilter.TabIndex = 6;
            this.textUserFilter.TextChanged += new System.EventHandler(this.UsersDraw);
            // 
            // buttonUserDelete
            // 
            this.buttonUserDelete.Enabled = false;
            this.buttonUserDelete.Location = new System.Drawing.Point(162, 23);
            this.buttonUserDelete.Name = "buttonUserDelete";
            this.buttonUserDelete.Size = new System.Drawing.Size(75, 23);
            this.buttonUserDelete.TabIndex = 5;
            this.buttonUserDelete.Text = "Удалить";
            this.buttonUserDelete.UseVisualStyleBackColor = true;
            this.buttonUserDelete.Click += new System.EventHandler(this.UserDelete);
            // 
            // buttonUserEdit
            // 
            this.buttonUserEdit.Enabled = false;
            this.buttonUserEdit.Location = new System.Drawing.Point(81, 23);
            this.buttonUserEdit.Name = "buttonUserEdit";
            this.buttonUserEdit.Size = new System.Drawing.Size(75, 23);
            this.buttonUserEdit.TabIndex = 4;
            this.buttonUserEdit.Text = "Править";
            this.buttonUserEdit.UseVisualStyleBackColor = true;
            this.buttonUserEdit.Click += new System.EventHandler(this.UserEdit);
            // 
            // buttonUserAdd
            // 
            this.buttonUserAdd.Location = new System.Drawing.Point(0, 23);
            this.buttonUserAdd.Name = "buttonUserAdd";
            this.buttonUserAdd.Size = new System.Drawing.Size(75, 23);
            this.buttonUserAdd.TabIndex = 3;
            this.buttonUserAdd.Text = "Добавить";
            this.buttonUserAdd.UseVisualStyleBackColor = true;
            this.buttonUserAdd.Click += new System.EventHandler(this.UserAdd);
            // 
            // listUsers
            // 
            this.listUsers.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listUsers.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnUserName,
            this.columnUserDep,
            this.columnUserPost,
            this.columnUserPlace,
            this.columnUserCom});
            this.listUsers.FullRowSelect = true;
            this.listUsers.HideSelection = false;
            this.listUsers.Location = new System.Drawing.Point(0, 52);
            this.listUsers.MultiSelect = false;
            this.listUsers.Name = "listUsers";
            this.listUsers.Size = new System.Drawing.Size(1021, 657);
            this.listUsers.TabIndex = 2;
            this.listUsers.UseCompatibleStateImageBehavior = false;
            this.listUsers.View = System.Windows.Forms.View.Details;
            this.listUsers.SelectedIndexChanged += new System.EventHandler(this.UsersSelChange);
            this.listUsers.DoubleClick += new System.EventHandler(this.UserEdit);
            // 
            // columnUserName
            // 
            this.columnUserName.Text = "ФИО";
            this.columnUserName.Width = 240;
            // 
            // columnUserDep
            // 
            this.columnUserDep.Text = "Подразделение";
            this.columnUserDep.Width = 200;
            // 
            // columnUserPost
            // 
            this.columnUserPost.Text = "Должность";
            this.columnUserPost.Width = 200;
            // 
            // columnUserPlace
            // 
            this.columnUserPlace.Text = "Расположение";
            this.columnUserPlace.Width = 200;
            // 
            // columnUserCom
            // 
            this.columnUserCom.Text = "Примечание";
            this.columnUserCom.Width = 150;
            // 
            // labelUsers
            // 
            this.labelUsers.AutoSize = true;
            this.labelUsers.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelUsers.Location = new System.Drawing.Point(3, 0);
            this.labelUsers.Name = "labelUsers";
            this.labelUsers.Size = new System.Drawing.Size(110, 20);
            this.labelUsers.TabIndex = 1;
            this.labelUsers.Text = "Сотрудники";
            // 
            // panelBrands
            // 
            this.panelBrands.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelBrands.Controls.Add(this.labelBrandFilter);
            this.panelBrands.Controls.Add(this.buttonBrandFilterReset);
            this.panelBrands.Controls.Add(this.textBrandFilter);
            this.panelBrands.Controls.Add(this.buttonBrandDelete);
            this.panelBrands.Controls.Add(this.buttonBrandEdit);
            this.panelBrands.Controls.Add(this.buttonBrandAdd);
            this.panelBrands.Controls.Add(this.listBrands);
            this.panelBrands.Controls.Add(this.labelBrands);
            this.panelBrands.Location = new System.Drawing.Point(163, 27);
            this.panelBrands.Name = "panelBrands";
            this.panelBrands.Size = new System.Drawing.Size(1021, 709);
            this.panelBrands.TabIndex = 14;
            this.panelBrands.Visible = false;
            this.panelBrands.VisibleChanged += new System.EventHandler(this.BrandsView);
            // 
            // labelBrandFilter
            // 
            this.labelBrandFilter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelBrandFilter.AutoSize = true;
            this.labelBrandFilter.Location = new System.Drawing.Point(575, 28);
            this.labelBrandFilter.Name = "labelBrandFilter";
            this.labelBrandFilter.Size = new System.Drawing.Size(47, 13);
            this.labelBrandFilter.TabIndex = 8;
            this.labelBrandFilter.Text = "Фильтр";
            // 
            // buttonBrandFilterReset
            // 
            this.buttonBrandFilterReset.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonBrandFilterReset.Location = new System.Drawing.Point(934, 23);
            this.buttonBrandFilterReset.Name = "buttonBrandFilterReset";
            this.buttonBrandFilterReset.Size = new System.Drawing.Size(75, 23);
            this.buttonBrandFilterReset.TabIndex = 7;
            this.buttonBrandFilterReset.Text = "Очистить";
            this.buttonBrandFilterReset.UseVisualStyleBackColor = true;
            this.buttonBrandFilterReset.Click += new System.EventHandler(this.BrandFilterReset);
            // 
            // textBrandFilter
            // 
            this.textBrandFilter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBrandFilter.Location = new System.Drawing.Point(628, 25);
            this.textBrandFilter.Name = "textBrandFilter";
            this.textBrandFilter.Size = new System.Drawing.Size(300, 20);
            this.textBrandFilter.TabIndex = 6;
            this.textBrandFilter.TextChanged += new System.EventHandler(this.BrandsDraw);
            // 
            // buttonBrandDelete
            // 
            this.buttonBrandDelete.Enabled = false;
            this.buttonBrandDelete.Location = new System.Drawing.Point(162, 23);
            this.buttonBrandDelete.Name = "buttonBrandDelete";
            this.buttonBrandDelete.Size = new System.Drawing.Size(75, 23);
            this.buttonBrandDelete.TabIndex = 5;
            this.buttonBrandDelete.Text = "Удалить";
            this.buttonBrandDelete.UseVisualStyleBackColor = true;
            this.buttonBrandDelete.Click += new System.EventHandler(this.BrandDelete);
            // 
            // buttonBrandEdit
            // 
            this.buttonBrandEdit.Enabled = false;
            this.buttonBrandEdit.Location = new System.Drawing.Point(81, 23);
            this.buttonBrandEdit.Name = "buttonBrandEdit";
            this.buttonBrandEdit.Size = new System.Drawing.Size(75, 23);
            this.buttonBrandEdit.TabIndex = 4;
            this.buttonBrandEdit.Text = "Править";
            this.buttonBrandEdit.UseVisualStyleBackColor = true;
            this.buttonBrandEdit.Click += new System.EventHandler(this.BrandEdit);
            // 
            // buttonBrandAdd
            // 
            this.buttonBrandAdd.Location = new System.Drawing.Point(0, 23);
            this.buttonBrandAdd.Name = "buttonBrandAdd";
            this.buttonBrandAdd.Size = new System.Drawing.Size(75, 23);
            this.buttonBrandAdd.TabIndex = 3;
            this.buttonBrandAdd.Text = "Добавить";
            this.buttonBrandAdd.UseVisualStyleBackColor = true;
            this.buttonBrandAdd.Click += new System.EventHandler(this.BrandAdd);
            // 
            // listBrands
            // 
            this.listBrands.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listBrands.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.listBrands.FullRowSelect = true;
            this.listBrands.HideSelection = false;
            this.listBrands.Location = new System.Drawing.Point(0, 52);
            this.listBrands.MultiSelect = false;
            this.listBrands.Name = "listBrands";
            this.listBrands.Size = new System.Drawing.Size(1021, 657);
            this.listBrands.TabIndex = 2;
            this.listBrands.UseCompatibleStateImageBehavior = false;
            this.listBrands.View = System.Windows.Forms.View.Details;
            this.listBrands.SelectedIndexChanged += new System.EventHandler(this.BrandsSelChange);
            this.listBrands.DoubleClick += new System.EventHandler(this.BrandEdit);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Название";
            this.columnHeader1.Width = 200;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Примечание";
            this.columnHeader2.Width = 790;
            // 
            // labelBrands
            // 
            this.labelBrands.AutoSize = true;
            this.labelBrands.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelBrands.Location = new System.Drawing.Point(3, 0);
            this.labelBrands.Name = "labelBrands";
            this.labelBrands.Size = new System.Drawing.Size(144, 20);
            this.labelBrands.TabIndex = 1;
            this.labelBrands.Text = "Производители";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 761);
            this.Controls.Add(this.panelBrands);
            this.Controls.Add(this.panelUsers);
            this.Controls.Add(this.panelRooms);
            this.Controls.Add(this.panelBuildings);
            this.Controls.Add(this.panelDeps);
            this.Controls.Add(this.panelPosts);
            this.Controls.Add(this.panelEquipment);
            this.Controls.Add(this.panelFilials);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.treeMenu);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(400, 300);
            this.Name = "FormMain";
            this.Text = "CompStore";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panelEquipment.ResumeLayout(false);
            this.panelEquipment.PerformLayout();
            this.panelFilials.ResumeLayout(false);
            this.panelFilials.PerformLayout();
            this.panelRooms.ResumeLayout(false);
            this.panelRooms.PerformLayout();
            this.panelPosts.ResumeLayout(false);
            this.panelPosts.PerformLayout();
            this.panelBuildings.ResumeLayout(false);
            this.panelBuildings.PerformLayout();
            this.panelDeps.ResumeLayout(false);
            this.panelDeps.PerformLayout();
            this.panelUsers.ResumeLayout(false);
            this.panelUsers.PerformLayout();
            this.panelBrands.ResumeLayout(false);
            this.panelBrands.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TreeView treeMenu;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem справкаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem оПрограммеToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.Panel panelEquipment;
        private System.Windows.Forms.Label labelEquipment;
        private System.Windows.Forms.Panel panelFilials;
        private System.Windows.Forms.Label labelFilials;
        private System.Windows.Forms.ListView listFilials;
        private System.Windows.Forms.ColumnHeader colFilName;
        private System.Windows.Forms.ColumnHeader colFilAdress;
        private System.Windows.Forms.ColumnHeader colFilCom;
        private System.Windows.Forms.Button buttonFDel;
        private System.Windows.Forms.Button buttonFEdit;
        private System.Windows.Forms.Button buttonFAdd;
        private System.Windows.Forms.ToolStripMenuItem инициализацияToolStripMenuItem;
        private System.Windows.Forms.TextBox textFilialFilter;
        private System.Windows.Forms.Label labelFilialFilter;
        private System.Windows.Forms.Button buttonFilialResetFilter;
        private System.Windows.Forms.Panel panelRooms;
        private System.Windows.Forms.Label labelRoomsFilter;
        private System.Windows.Forms.Button buttonRoomsFilterReset;
        private System.Windows.Forms.TextBox textRoomFilter;
        private System.Windows.Forms.Button buttonRoomDelete;
        private System.Windows.Forms.Button buttonRoomEdit;
        private System.Windows.Forms.Button buttonRoomAdd;
        private System.Windows.Forms.ListView listRooms;
        private System.Windows.Forms.ColumnHeader columnRoomFilial;
        private System.Windows.Forms.ColumnHeader columnRoomName;
        private System.Windows.Forms.ColumnHeader columnRoomCom;
        private System.Windows.Forms.Label labelRooms;
        private System.Windows.Forms.Panel panelPosts;
        private System.Windows.Forms.Label labelPostFiltr;
        private System.Windows.Forms.Button buttonPostFilterReset;
        private System.Windows.Forms.TextBox textPostFilter;
        private System.Windows.Forms.Button buttonPostDelete;
        private System.Windows.Forms.Button buttonPostEdit;
        private System.Windows.Forms.Button buttonPostAdd;
        private System.Windows.Forms.ListView listPosts;
        private System.Windows.Forms.ColumnHeader columnPostName;
        private System.Windows.Forms.Label labelPosts;
        private System.Windows.Forms.Panel panelBuildings;
        private System.Windows.Forms.Label labelBuildingFilter;
        private System.Windows.Forms.Button buttonBuildingFilterReset;
        private System.Windows.Forms.TextBox textBuildingFilter;
        private System.Windows.Forms.Button buttonBuildingDelete;
        private System.Windows.Forms.Button buttonBuildingEdit;
        private System.Windows.Forms.Button buttonBuildingAdd;
        private System.Windows.Forms.ListView listBuildings;
        private System.Windows.Forms.ColumnHeader columnBuildingFilial;
        private System.Windows.Forms.ColumnHeader columnBuildingName;
        private System.Windows.Forms.ColumnHeader columnBuildingComment;
        private System.Windows.Forms.Label labelBuildings;
        private System.Windows.Forms.Panel panelDeps;
        private System.Windows.Forms.Label labelDepFilter;
        private System.Windows.Forms.Button buttonDepFilterReset;
        private System.Windows.Forms.TextBox textDepFilter;
        private System.Windows.Forms.Button buttonDepDelete;
        private System.Windows.Forms.Button buttonDepEdit;
        private System.Windows.Forms.Button buttonDepAdd;
        private System.Windows.Forms.ListView listDeps;
        private System.Windows.Forms.ColumnHeader columnDepName;
        private System.Windows.Forms.ColumnHeader columnDepComment;
        private System.Windows.Forms.Label labelDeps;
        private System.Windows.Forms.ColumnHeader columnRoomBuilding;
        private System.Windows.Forms.Panel panelUsers;
        private System.Windows.Forms.Label labelUserFilter;
        private System.Windows.Forms.Button buttonUserFilterReset;
        private System.Windows.Forms.TextBox textUserFilter;
        private System.Windows.Forms.Button buttonUserDelete;
        private System.Windows.Forms.Button buttonUserEdit;
        private System.Windows.Forms.Button buttonUserAdd;
        private System.Windows.Forms.ListView listUsers;
        private System.Windows.Forms.ColumnHeader columnUserName;
        private System.Windows.Forms.ColumnHeader columnUserPost;
        private System.Windows.Forms.ColumnHeader columnUserDep;
        private System.Windows.Forms.ColumnHeader columnUserPlace;
        private System.Windows.Forms.ColumnHeader columnUserCom;
        private System.Windows.Forms.Label labelUsers;
        private System.Windows.Forms.Panel panelBrands;
        private System.Windows.Forms.Label labelBrandFilter;
        private System.Windows.Forms.Button buttonBrandFilterReset;
        private System.Windows.Forms.TextBox textBrandFilter;
        private System.Windows.Forms.Button buttonBrandDelete;
        private System.Windows.Forms.Button buttonBrandEdit;
        private System.Windows.Forms.Button buttonBrandAdd;
        private System.Windows.Forms.ListView listBrands;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.Label labelBrands;
    }
}

