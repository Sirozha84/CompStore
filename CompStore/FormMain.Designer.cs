
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
            System.Windows.Forms.TreeNode treeNode15 = new System.Windows.Forms.TreeNode("Филиалы");
            System.Windows.Forms.TreeNode treeNode16 = new System.Windows.Forms.TreeNode("Помещения");
            System.Windows.Forms.TreeNode treeNode17 = new System.Windows.Forms.TreeNode("Должности");
            System.Windows.Forms.TreeNode treeNode18 = new System.Windows.Forms.TreeNode("Сотрудники", new System.Windows.Forms.TreeNode[] {
            treeNode17});
            System.Windows.Forms.TreeNode treeNode19 = new System.Windows.Forms.TreeNode("Перемещения");
            System.Windows.Forms.TreeNode treeNode20 = new System.Windows.Forms.TreeNode("Оборудование", new System.Windows.Forms.TreeNode[] {
            treeNode19});
            System.Windows.Forms.TreeNode treeNode21 = new System.Windows.Forms.TreeNode("Предприятие", new System.Windows.Forms.TreeNode[] {
            treeNode15,
            treeNode16,
            treeNode18,
            treeNode20});
            this.treeMenu = new System.Windows.Forms.TreeView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.инициализацияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.справкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.оПрограммеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.panelUsers = new System.Windows.Forms.Panel();
            this.labelUsers = new System.Windows.Forms.Label();
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
            this.columnRoomName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnRoomCom = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.labelRooms = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.panelUsers.SuspendLayout();
            this.panelEquipment.SuspendLayout();
            this.panelFilials.SuspendLayout();
            this.panelRooms.SuspendLayout();
            this.SuspendLayout();
            // 
            // treeMenu
            // 
            this.treeMenu.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.treeMenu.ItemHeight = 24;
            this.treeMenu.Location = new System.Drawing.Point(0, 27);
            this.treeMenu.Name = "treeMenu";
            treeNode15.Name = "nodeFilials";
            treeNode15.Text = "Филиалы";
            treeNode16.Name = "nodeRooms";
            treeNode16.Text = "Помещения";
            treeNode17.Name = "nodePosts";
            treeNode17.Text = "Должности";
            treeNode18.Name = "nodeUsers";
            treeNode18.Text = "Сотрудники";
            treeNode19.Name = "nodeMoves";
            treeNode19.Text = "Перемещения";
            treeNode20.Name = "nodeEquipment";
            treeNode20.Text = "Оборудование";
            treeNode21.Name = "nodeCompany";
            treeNode21.Text = "Предприятие";
            this.treeMenu.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode21});
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
            // panelUsers
            // 
            this.panelUsers.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelUsers.Controls.Add(this.labelUsers);
            this.panelUsers.Location = new System.Drawing.Point(217, 387);
            this.panelUsers.Name = "panelUsers";
            this.panelUsers.Size = new System.Drawing.Size(1021, 709);
            this.panelUsers.TabIndex = 4;
            this.panelUsers.Visible = false;
            // 
            // labelUsers
            // 
            this.labelUsers.AutoSize = true;
            this.labelUsers.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelUsers.Location = new System.Drawing.Point(3, 0);
            this.labelUsers.Name = "labelUsers";
            this.labelUsers.Size = new System.Drawing.Size(110, 20);
            this.labelUsers.TabIndex = 0;
            this.labelUsers.Text = "Сотрудники";
            // 
            // panelEquipment
            // 
            this.panelEquipment.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelEquipment.Controls.Add(this.labelEquipment);
            this.panelEquipment.Location = new System.Drawing.Point(350, 288);
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
            this.panelFilials.Location = new System.Drawing.Point(711, 27);
            this.panelFilials.Name = "panelFilials";
            this.panelFilials.Size = new System.Drawing.Size(1021, 709);
            this.panelFilials.TabIndex = 6;
            this.panelFilials.Visible = false;
            this.panelFilials.VisibleChanged += new System.EventHandler(this.panelFilials_VisibleChanged);
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
            this.labelFilials.Location = new System.Drawing.Point(0, 0);
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
            this.panelRooms.Location = new System.Drawing.Point(163, 27);
            this.panelRooms.Name = "panelRooms";
            this.panelRooms.Size = new System.Drawing.Size(1021, 709);
            this.panelRooms.TabIndex = 10;
            this.panelRooms.Visible = false;
            this.panelRooms.VisibleChanged += new System.EventHandler(this.panelRooms_VisibleChanged);
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
            // columnRoomName
            // 
            this.columnRoomName.Text = "Название";
            this.columnRoomName.Width = 200;
            // 
            // columnRoomCom
            // 
            this.columnRoomCom.Text = "Примечание";
            this.columnRoomCom.Width = 590;
            // 
            // labelRooms
            // 
            this.labelRooms.AutoSize = true;
            this.labelRooms.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelRooms.Location = new System.Drawing.Point(0, 0);
            this.labelRooms.Name = "labelRooms";
            this.labelRooms.Size = new System.Drawing.Size(108, 20);
            this.labelRooms.TabIndex = 1;
            this.labelRooms.Text = "Помещения";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 761);
            this.Controls.Add(this.panelRooms);
            this.Controls.Add(this.panelEquipment);
            this.Controls.Add(this.panelFilials);
            this.Controls.Add(this.panelUsers);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.treeMenu);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(400, 300);
            this.Name = "FormMain";
            this.Text = "CompStore";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panelUsers.ResumeLayout(false);
            this.panelUsers.PerformLayout();
            this.panelEquipment.ResumeLayout(false);
            this.panelEquipment.PerformLayout();
            this.panelFilials.ResumeLayout(false);
            this.panelFilials.PerformLayout();
            this.panelRooms.ResumeLayout(false);
            this.panelRooms.PerformLayout();
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
        private System.Windows.Forms.Panel panelUsers;
        private System.Windows.Forms.Label labelUsers;
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
    }
}

