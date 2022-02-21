
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
            System.Windows.Forms.TreeNode treeNode18 = new System.Windows.Forms.TreeNode("Филиалы");
            System.Windows.Forms.TreeNode treeNode19 = new System.Windows.Forms.TreeNode("Здания");
            System.Windows.Forms.TreeNode treeNode20 = new System.Windows.Forms.TreeNode("Помещения");
            System.Windows.Forms.TreeNode treeNode21 = new System.Windows.Forms.TreeNode("Подразделения");
            System.Windows.Forms.TreeNode treeNode22 = new System.Windows.Forms.TreeNode("Должности");
            System.Windows.Forms.TreeNode treeNode23 = new System.Windows.Forms.TreeNode("Сотрудники");
            System.Windows.Forms.TreeNode treeNode24 = new System.Windows.Forms.TreeNode("Предприятие", new System.Windows.Forms.TreeNode[] {
            treeNode18,
            treeNode19,
            treeNode20,
            treeNode21,
            treeNode22,
            treeNode23});
            System.Windows.Forms.TreeNode treeNode25 = new System.Windows.Forms.TreeNode("Перемещения");
            System.Windows.Forms.TreeNode treeNode26 = new System.Windows.Forms.TreeNode("Оборудование", new System.Windows.Forms.TreeNode[] {
            treeNode25});
            System.Windows.Forms.TreeNode treeNode27 = new System.Windows.Forms.TreeNode("Типы оборудования");
            System.Windows.Forms.TreeNode treeNode28 = new System.Windows.Forms.TreeNode("Производители");
            System.Windows.Forms.TreeNode treeNode29 = new System.Windows.Forms.TreeNode("Модели");
            System.Windows.Forms.TreeNode treeNode30 = new System.Windows.Forms.TreeNode("Поставщики");
            System.Windows.Forms.TreeNode treeNode31 = new System.Windows.Forms.TreeNode("Общие разделы", new System.Windows.Forms.TreeNode[] {
            treeNode27,
            treeNode28,
            treeNode29,
            treeNode30});
            System.Windows.Forms.TreeNode treeNode32 = new System.Windows.Forms.TreeNode("Тест1");
            System.Windows.Forms.TreeNode treeNode33 = new System.Windows.Forms.TreeNode("Тест2");
            System.Windows.Forms.TreeNode treeNode34 = new System.Windows.Forms.TreeNode("Тест3");
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.treeMenu = new System.Windows.Forms.TreeView();
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
            this.panelEquipments = new System.Windows.Forms.Panel();
            this.panelEqDown = new System.Windows.Forms.Panel();
            this.tabEquipments = new System.Windows.Forms.TabControl();
            this.tabEqMoves = new System.Windows.Forms.TabPage();
            this.listEqMoves = new System.Windows.Forms.ListView();
            this.columnEMDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnEMEquipment = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnEMUser = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnEMRoom = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnEMComment = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.splitterEq = new System.Windows.Forms.Splitter();
            this.panelEqUp = new System.Windows.Forms.Panel();
            this.toolStripEquipments = new System.Windows.Forms.ToolStrip();
            this.toolEqLabel = new System.Windows.Forms.ToolStripLabel();
            this.toolEqAdd = new System.Windows.Forms.ToolStripSplitButton();
            this.toolEqCopy = new System.Windows.Forms.ToolStripMenuItem();
            this.toolEqEdit = new System.Windows.Forms.ToolStripButton();
            this.toolEqDelete = new System.Windows.Forms.ToolStripButton();
            this.toolEqFilterReset = new System.Windows.Forms.ToolStripButton();
            this.toolEqFilter = new System.Windows.Forms.ToolStripTextBox();
            this.toolEqFilterLabel = new System.Windows.Forms.ToolStripLabel();
            this.toolEqMove = new System.Windows.Forms.ToolStripButton();
            this.listEquipments = new System.Windows.Forms.ListView();
            this.columnEqName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnEqSN = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnEqIN = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnEqUser = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnEqPlace = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnIssDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnEqBuyDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnEqMOL = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnEqComment = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.contextMenuEquipment = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.cmEqAdd = new System.Windows.Forms.ToolStripMenuItem();
            this.cmEqCopy = new System.Windows.Forms.ToolStripMenuItem();
            this.cmEqEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.cmEqDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.cmEqMove = new System.Windows.Forms.ToolStripMenuItem();
            this.panelFilials = new System.Windows.Forms.Panel();
            this.toolStripFilials = new System.Windows.Forms.ToolStrip();
            this.toolFilialLabel = new System.Windows.Forms.ToolStripLabel();
            this.toolFilialAdd = new System.Windows.Forms.ToolStripButton();
            this.toolFilialEdit = new System.Windows.Forms.ToolStripButton();
            this.toolFilialDelete = new System.Windows.Forms.ToolStripButton();
            this.toolFilialFilterReset = new System.Windows.Forms.ToolStripButton();
            this.toolFilialFilter = new System.Windows.Forms.ToolStripTextBox();
            this.toolFilialFilterLabel = new System.Windows.Forms.ToolStripLabel();
            this.listFilials = new System.Windows.Forms.ListView();
            this.colFilName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colFilAdress = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colFilCom = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.contextMenuFilials = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.cmFilialAdd = new System.Windows.Forms.ToolStripMenuItem();
            this.cmFilialEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.cmFilialDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.panelRooms = new System.Windows.Forms.Panel();
            this.toolStripRooms = new System.Windows.Forms.ToolStrip();
            this.toolRoomLabel = new System.Windows.Forms.ToolStripLabel();
            this.toolRoomAdd = new System.Windows.Forms.ToolStripButton();
            this.toolRoomEdit = new System.Windows.Forms.ToolStripButton();
            this.toolRoomDelete = new System.Windows.Forms.ToolStripButton();
            this.toolRoomFilterReset = new System.Windows.Forms.ToolStripButton();
            this.toolRoomFilter = new System.Windows.Forms.ToolStripTextBox();
            this.toolRoomFilterLabel = new System.Windows.Forms.ToolStripLabel();
            this.listRooms = new System.Windows.Forms.ListView();
            this.columnRoomFilial = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnRoomBuilding = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnRoomName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnRoomCom = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.contextMenuRooms = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.cmRoomAdd = new System.Windows.Forms.ToolStripMenuItem();
            this.cmRoomEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.cmRoomDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.panelPosts = new System.Windows.Forms.Panel();
            this.toolStripPosts = new System.Windows.Forms.ToolStrip();
            this.toolPostLabel = new System.Windows.Forms.ToolStripLabel();
            this.toolPostAdd = new System.Windows.Forms.ToolStripButton();
            this.toolPostEdit = new System.Windows.Forms.ToolStripButton();
            this.toolPostDelete = new System.Windows.Forms.ToolStripButton();
            this.toolPostFilterReset = new System.Windows.Forms.ToolStripButton();
            this.toolPostFilter = new System.Windows.Forms.ToolStripTextBox();
            this.toolPostFilterLabel = new System.Windows.Forms.ToolStripLabel();
            this.listPosts = new System.Windows.Forms.ListView();
            this.columnPostName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.contextMenuPosts = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.cmPostAdd = new System.Windows.Forms.ToolStripMenuItem();
            this.cmPostEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.cmPostDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.panelBuildings = new System.Windows.Forms.Panel();
            this.toolStripBuildings = new System.Windows.Forms.ToolStrip();
            this.toolBuildingLabel = new System.Windows.Forms.ToolStripLabel();
            this.toolBuildingAdd = new System.Windows.Forms.ToolStripButton();
            this.toolBuildingEdit = new System.Windows.Forms.ToolStripButton();
            this.toolBuildingDelete = new System.Windows.Forms.ToolStripButton();
            this.toolBuildingFilterReset = new System.Windows.Forms.ToolStripButton();
            this.toolBuildingFilter = new System.Windows.Forms.ToolStripTextBox();
            this.toolBuildingFilterLabel = new System.Windows.Forms.ToolStripLabel();
            this.listBuildings = new System.Windows.Forms.ListView();
            this.columnBuildingFilial = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnBuildingName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnBuildingComment = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.contextMenuBuildings = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.cmBuildingAdd = new System.Windows.Forms.ToolStripMenuItem();
            this.cmBuildingEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.cmBuildingDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.panelDeps = new System.Windows.Forms.Panel();
            this.toolStripDeps = new System.Windows.Forms.ToolStrip();
            this.toolDepLabel = new System.Windows.Forms.ToolStripLabel();
            this.toolDepAdd = new System.Windows.Forms.ToolStripButton();
            this.toolDepEdit = new System.Windows.Forms.ToolStripButton();
            this.toolDepDelete = new System.Windows.Forms.ToolStripButton();
            this.toolDepFilterReset = new System.Windows.Forms.ToolStripButton();
            this.toolDepFilter = new System.Windows.Forms.ToolStripTextBox();
            this.toolDepFilterLabel = new System.Windows.Forms.ToolStripLabel();
            this.listDeps = new System.Windows.Forms.ListView();
            this.columnDepName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnDepComment = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.contextMenuDeps = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.cmDepAdd = new System.Windows.Forms.ToolStripMenuItem();
            this.cmDepEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.cmDepDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.panelUsers = new System.Windows.Forms.Panel();
            this.panelUsDown = new System.Windows.Forms.Panel();
            this.tabUsers = new System.Windows.Forms.TabControl();
            this.tabUsEquipments = new System.Windows.Forms.TabPage();
            this.listUsEquipment = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.splitterUsers = new System.Windows.Forms.Splitter();
            this.panelUsUp = new System.Windows.Forms.Panel();
            this.listUsers = new System.Windows.Forms.ListView();
            this.columnUserName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnUserDep = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnUserPost = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnUserPlace = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnUserCom = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.contextMenuUsers = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.cmUserAdd = new System.Windows.Forms.ToolStripMenuItem();
            this.cmUserEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.cmUserDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripUsers = new System.Windows.Forms.ToolStrip();
            this.toolUserLabel = new System.Windows.Forms.ToolStripLabel();
            this.toolUserAdd = new System.Windows.Forms.ToolStripButton();
            this.toolUserEdit = new System.Windows.Forms.ToolStripButton();
            this.toolUserDelete = new System.Windows.Forms.ToolStripButton();
            this.toolUserFilterReset = new System.Windows.Forms.ToolStripButton();
            this.toolUserFilter = new System.Windows.Forms.ToolStripTextBox();
            this.toolUserFilterLabel = new System.Windows.Forms.ToolStripLabel();
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
            this.panelMoves = new System.Windows.Forms.Panel();
            this.toolStripMoves = new System.Windows.Forms.ToolStrip();
            this.toolMoveLabel = new System.Windows.Forms.ToolStripLabel();
            this.toolMoveAdd = new System.Windows.Forms.ToolStripButton();
            this.toolMoveEdit = new System.Windows.Forms.ToolStripButton();
            this.toolMoveDelete = new System.Windows.Forms.ToolStripButton();
            this.toolMoveFilterReset = new System.Windows.Forms.ToolStripButton();
            this.toolMoveFilter = new System.Windows.Forms.ToolStripTextBox();
            this.toolMoveFilterLabel = new System.Windows.Forms.ToolStripLabel();
            this.listMoves = new System.Windows.Forms.ListView();
            this.columnMoveDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnMoveEq = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnMoveUser = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnMoveRoom = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnMoveMOL = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnMoveCom = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.contextMenuMoves = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.cmMoveAdd = new System.Windows.Forms.ToolStripMenuItem();
            this.cmMoveEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.cmMoveDelete = new System.Windows.Forms.ToolStripMenuItem();
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.listViewAdd1 = new System.Windows.Forms.ListView();
            this.splitterH = new System.Windows.Forms.Splitter();
            this.panelUp = new System.Windows.Forms.Panel();
            this.toolStrip = new System.Windows.Forms.ToolStrip();
            this.toolStripLabelName = new System.Windows.Forms.ToolStripLabel();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.toolStripTextBox1 = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripButton4 = new System.Windows.Forms.ToolStripButton();
            this.listViewMain = new System.Windows.Forms.ListView();
            this.columnHeader14 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader15 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader16 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader17 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader18 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader19 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader20 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader21 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader22 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listViewAdd2 = new System.Windows.Forms.ListView();
            this.listViewAdd3 = new System.Windows.Forms.ListView();
            this.toolStripButtonAdd = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton5 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton6 = new System.Windows.Forms.ToolStripButton();
            this.mainMenu.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.panelEquipments.SuspendLayout();
            this.panelEqDown.SuspendLayout();
            this.tabEquipments.SuspendLayout();
            this.tabEqMoves.SuspendLayout();
            this.panelEqUp.SuspendLayout();
            this.toolStripEquipments.SuspendLayout();
            this.contextMenuEquipment.SuspendLayout();
            this.panelFilials.SuspendLayout();
            this.toolStripFilials.SuspendLayout();
            this.contextMenuFilials.SuspendLayout();
            this.panelRooms.SuspendLayout();
            this.toolStripRooms.SuspendLayout();
            this.contextMenuRooms.SuspendLayout();
            this.panelPosts.SuspendLayout();
            this.toolStripPosts.SuspendLayout();
            this.contextMenuPosts.SuspendLayout();
            this.panelBuildings.SuspendLayout();
            this.toolStripBuildings.SuspendLayout();
            this.contextMenuBuildings.SuspendLayout();
            this.panelDeps.SuspendLayout();
            this.toolStripDeps.SuspendLayout();
            this.contextMenuDeps.SuspendLayout();
            this.panelUsers.SuspendLayout();
            this.panelUsDown.SuspendLayout();
            this.tabUsers.SuspendLayout();
            this.tabUsEquipments.SuspendLayout();
            this.panelUsUp.SuspendLayout();
            this.contextMenuUsers.SuspendLayout();
            this.toolStripUsers.SuspendLayout();
            this.panelBrands.SuspendLayout();
            this.toolStripBrands.SuspendLayout();
            this.contextMenuBrands.SuspendLayout();
            this.panelEqTypes.SuspendLayout();
            this.toolStripEqTypes.SuspendLayout();
            this.contextMenuEqTypes.SuspendLayout();
            this.panelModels.SuspendLayout();
            this.toolStripModels.SuspendLayout();
            this.contextMenuModels.SuspendLayout();
            this.panelMoves.SuspendLayout();
            this.toolStripMoves.SuspendLayout();
            this.contextMenuMoves.SuspendLayout();
            this.panelProviders.SuspendLayout();
            this.toolStripProviders.SuspendLayout();
            this.contextMenuProviders.SuspendLayout();
            this.panelList.SuspendLayout();
            this.panelDown.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.panelUp.SuspendLayout();
            this.toolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // treeMenu
            // 
            this.treeMenu.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.treeMenu.ItemHeight = 24;
            this.treeMenu.Location = new System.Drawing.Point(0, 27);
            this.treeMenu.Name = "treeMenu";
            treeNode18.Name = "nodeFilials";
            treeNode18.Text = "Филиалы";
            treeNode19.Name = "nodeBuildings";
            treeNode19.Text = "Здания";
            treeNode20.Name = "nodeRooms";
            treeNode20.Text = "Помещения";
            treeNode21.Name = "nodeDeps";
            treeNode21.Text = "Подразделения";
            treeNode22.Name = "nodePosts";
            treeNode22.Text = "Должности";
            treeNode23.Name = "nodeUsers";
            treeNode23.Text = "Сотрудники";
            treeNode24.Name = "nodeCompany";
            treeNode24.Text = "Предприятие";
            treeNode25.Name = "nodeMoves";
            treeNode25.Text = "Перемещения";
            treeNode26.Name = "nodeEquipment";
            treeNode26.Text = "Оборудование";
            treeNode27.Name = "nodeEqType";
            treeNode27.Text = "Типы оборудования";
            treeNode28.Name = "nodeBrands";
            treeNode28.Text = "Производители";
            treeNode29.Name = "nodeModels";
            treeNode29.Text = "Модели";
            treeNode30.Name = "nodeProviders";
            treeNode30.Text = "Поставщики";
            treeNode31.Name = "nodeCommon";
            treeNode31.Text = "Общие разделы";
            treeNode32.Name = "nodeTest1";
            treeNode32.Text = "Тест1";
            treeNode33.Name = "nodeTest2";
            treeNode33.Text = "Тест2";
            treeNode34.Name = "nodeTest3";
            treeNode34.Text = "Тест3";
            this.treeMenu.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode24,
            treeNode26,
            treeNode31,
            treeNode32,
            treeNode33,
            treeNode34});
            this.treeMenu.Size = new System.Drawing.Size(157, 709);
            this.treeMenu.TabIndex = 0;
            this.treeMenu.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.TabChange);
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
            // panelEquipments
            // 
            this.panelEquipments.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelEquipments.Controls.Add(this.panelEqDown);
            this.panelEquipments.Controls.Add(this.splitterEq);
            this.panelEquipments.Controls.Add(this.panelEqUp);
            this.panelEquipments.Location = new System.Drawing.Point(163, 27);
            this.panelEquipments.Name = "panelEquipments";
            this.panelEquipments.Size = new System.Drawing.Size(1021, 709);
            this.panelEquipments.TabIndex = 5;
            this.panelEquipments.Visible = false;
            this.panelEquipments.VisibleChanged += new System.EventHandler(this.EquipmentsView);
            // 
            // panelEqDown
            // 
            this.panelEqDown.Controls.Add(this.tabEquipments);
            this.panelEqDown.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelEqDown.Location = new System.Drawing.Point(0, 408);
            this.panelEqDown.Name = "panelEqDown";
            this.panelEqDown.Size = new System.Drawing.Size(1021, 301);
            this.panelEqDown.TabIndex = 21;
            // 
            // tabEquipments
            // 
            this.tabEquipments.Controls.Add(this.tabEqMoves);
            this.tabEquipments.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabEquipments.Location = new System.Drawing.Point(0, 0);
            this.tabEquipments.Name = "tabEquipments";
            this.tabEquipments.SelectedIndex = 0;
            this.tabEquipments.Size = new System.Drawing.Size(1021, 301);
            this.tabEquipments.TabIndex = 0;
            // 
            // tabEqMoves
            // 
            this.tabEqMoves.Controls.Add(this.listEqMoves);
            this.tabEqMoves.Location = new System.Drawing.Point(4, 22);
            this.tabEqMoves.Name = "tabEqMoves";
            this.tabEqMoves.Padding = new System.Windows.Forms.Padding(3);
            this.tabEqMoves.Size = new System.Drawing.Size(1013, 275);
            this.tabEqMoves.TabIndex = 0;
            this.tabEqMoves.Text = "Перемещения";
            this.tabEqMoves.UseVisualStyleBackColor = true;
            // 
            // listEqMoves
            // 
            this.listEqMoves.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnEMDate,
            this.columnEMEquipment,
            this.columnEMUser,
            this.columnEMRoom,
            this.columnEMComment});
            this.listEqMoves.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listEqMoves.FullRowSelect = true;
            this.listEqMoves.HideSelection = false;
            this.listEqMoves.Location = new System.Drawing.Point(3, 3);
            this.listEqMoves.MultiSelect = false;
            this.listEqMoves.Name = "listEqMoves";
            this.listEqMoves.Size = new System.Drawing.Size(1007, 269);
            this.listEqMoves.TabIndex = 3;
            this.listEqMoves.UseCompatibleStateImageBehavior = false;
            this.listEqMoves.View = System.Windows.Forms.View.Details;
            this.listEqMoves.DoubleClick += new System.EventHandler(this.MoveEditFromEquipment);
            // 
            // columnEMDate
            // 
            this.columnEMDate.Text = "Дата";
            this.columnEMDate.Width = 100;
            // 
            // columnEMEquipment
            // 
            this.columnEMEquipment.Text = "Оборудование";
            this.columnEMEquipment.Width = 200;
            // 
            // columnEMUser
            // 
            this.columnEMUser.Text = "Ответственный";
            this.columnEMUser.Width = 200;
            // 
            // columnEMRoom
            // 
            this.columnEMRoom.Text = "Помещение";
            this.columnEMRoom.Width = 200;
            // 
            // columnEMComment
            // 
            this.columnEMComment.Text = "Примечание";
            this.columnEMComment.Width = 280;
            // 
            // splitterEq
            // 
            this.splitterEq.Dock = System.Windows.Forms.DockStyle.Top;
            this.splitterEq.Location = new System.Drawing.Point(0, 400);
            this.splitterEq.Name = "splitterEq";
            this.splitterEq.Size = new System.Drawing.Size(1021, 8);
            this.splitterEq.TabIndex = 20;
            this.splitterEq.TabStop = false;
            // 
            // panelEqUp
            // 
            this.panelEqUp.Controls.Add(this.toolStripEquipments);
            this.panelEqUp.Controls.Add(this.listEquipments);
            this.panelEqUp.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelEqUp.Location = new System.Drawing.Point(0, 0);
            this.panelEqUp.Name = "panelEqUp";
            this.panelEqUp.Size = new System.Drawing.Size(1021, 400);
            this.panelEqUp.TabIndex = 17;
            // 
            // toolStripEquipments
            // 
            this.toolStripEquipments.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStripEquipments.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolEqLabel,
            this.toolEqAdd,
            this.toolEqEdit,
            this.toolEqDelete,
            this.toolEqFilterReset,
            this.toolEqFilter,
            this.toolEqFilterLabel,
            this.toolEqMove});
            this.toolStripEquipments.Location = new System.Drawing.Point(0, 0);
            this.toolStripEquipments.Name = "toolStripEquipments";
            this.toolStripEquipments.Size = new System.Drawing.Size(1021, 25);
            this.toolStripEquipments.TabIndex = 22;
            // 
            // toolEqLabel
            // 
            this.toolEqLabel.AutoSize = false;
            this.toolEqLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.toolEqLabel.Name = "toolEqLabel";
            this.toolEqLabel.Size = new System.Drawing.Size(170, 22);
            this.toolEqLabel.Text = "Оборудование";
            this.toolEqLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // toolEqAdd
            // 
            this.toolEqAdd.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolEqCopy});
            this.toolEqAdd.Image = global::CompStore.Properties.Resources.add;
            this.toolEqAdd.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolEqAdd.Name = "toolEqAdd";
            this.toolEqAdd.Size = new System.Drawing.Size(91, 22);
            this.toolEqAdd.Text = "Добавить";
            this.toolEqAdd.Click += new System.EventHandler(this.EquipmentAdd);
            // 
            // toolEqCopy
            // 
            this.toolEqCopy.Image = global::CompStore.Properties.Resources.copy;
            this.toolEqCopy.Name = "toolEqCopy";
            this.toolEqCopy.Size = new System.Drawing.Size(211, 22);
            this.toolEqCopy.Text = "Добавить копированием";
            this.toolEqCopy.Click += new System.EventHandler(this.EquipmentCopy);
            // 
            // toolEqEdit
            // 
            this.toolEqEdit.Image = global::CompStore.Properties.Resources.edit;
            this.toolEqEdit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolEqEdit.Name = "toolEqEdit";
            this.toolEqEdit.Size = new System.Drawing.Size(81, 22);
            this.toolEqEdit.Text = "Изменить";
            this.toolEqEdit.Click += new System.EventHandler(this.EquipmentEdit);
            // 
            // toolEqDelete
            // 
            this.toolEqDelete.Image = global::CompStore.Properties.Resources.delete;
            this.toolEqDelete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolEqDelete.Name = "toolEqDelete";
            this.toolEqDelete.Size = new System.Drawing.Size(71, 22);
            this.toolEqDelete.Text = "Удалить";
            this.toolEqDelete.Click += new System.EventHandler(this.EquipmentDelete);
            // 
            // toolEqFilterReset
            // 
            this.toolEqFilterReset.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolEqFilterReset.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolEqFilterReset.Image = global::CompStore.Properties.Resources.cancel;
            this.toolEqFilterReset.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolEqFilterReset.Name = "toolEqFilterReset";
            this.toolEqFilterReset.Size = new System.Drawing.Size(23, 22);
            this.toolEqFilterReset.Click += new System.EventHandler(this.EquipmentFilterReset);
            // 
            // toolEqFilter
            // 
            this.toolEqFilter.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolEqFilter.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.toolEqFilter.Name = "toolEqFilter";
            this.toolEqFilter.Size = new System.Drawing.Size(300, 25);
            this.toolEqFilter.TextChanged += new System.EventHandler(this.EquipmentsDraw);
            // 
            // toolEqFilterLabel
            // 
            this.toolEqFilterLabel.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolEqFilterLabel.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolEqFilterLabel.Image = global::CompStore.Properties.Resources.search;
            this.toolEqFilterLabel.Name = "toolEqFilterLabel";
            this.toolEqFilterLabel.Size = new System.Drawing.Size(16, 22);
            // 
            // toolEqMove
            // 
            this.toolEqMove.Image = global::CompStore.Properties.Resources.move;
            this.toolEqMove.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolEqMove.Name = "toolEqMove";
            this.toolEqMove.Size = new System.Drawing.Size(99, 22);
            this.toolEqMove.Text = "Переместить";
            this.toolEqMove.Click += new System.EventHandler(this.EquipmentsMove);
            // 
            // listEquipments
            // 
            this.listEquipments.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listEquipments.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnEqName,
            this.columnEqSN,
            this.columnEqIN,
            this.columnEqUser,
            this.columnEqPlace,
            this.columnIssDate,
            this.columnEqBuyDate,
            this.columnEqMOL,
            this.columnEqComment});
            this.listEquipments.ContextMenuStrip = this.contextMenuEquipment;
            this.listEquipments.FullRowSelect = true;
            this.listEquipments.HideSelection = false;
            this.listEquipments.Location = new System.Drawing.Point(0, 25);
            this.listEquipments.Name = "listEquipments";
            this.listEquipments.Size = new System.Drawing.Size(1021, 375);
            this.listEquipments.TabIndex = 10;
            this.listEquipments.UseCompatibleStateImageBehavior = false;
            this.listEquipments.View = System.Windows.Forms.View.Details;
            this.listEquipments.SelectedIndexChanged += new System.EventHandler(this.EquipmentsSelChange);
            this.listEquipments.DoubleClick += new System.EventHandler(this.EquipmentEdit);
            this.listEquipments.KeyDown += new System.Windows.Forms.KeyEventHandler(this.EquipmentsKeyboard);
            // 
            // columnEqName
            // 
            this.columnEqName.Text = "Наименование";
            this.columnEqName.Width = 170;
            // 
            // columnEqSN
            // 
            this.columnEqSN.Text = "Серийный номер";
            this.columnEqSN.Width = 125;
            // 
            // columnEqIN
            // 
            this.columnEqIN.Text = "Инвентарный номер";
            this.columnEqIN.Width = 125;
            // 
            // columnEqUser
            // 
            this.columnEqUser.Text = "Сотрудник";
            this.columnEqUser.Width = 120;
            // 
            // columnEqPlace
            // 
            this.columnEqPlace.Text = "Помещение";
            this.columnEqPlace.Width = 100;
            // 
            // columnIssDate
            // 
            this.columnIssDate.Text = "Выдано";
            this.columnIssDate.Width = 70;
            // 
            // columnEqBuyDate
            // 
            this.columnEqBuyDate.Text = "Куплено";
            this.columnEqBuyDate.Width = 70;
            // 
            // columnEqMOL
            // 
            this.columnEqMOL.Text = "М.О.Л.";
            // 
            // columnEqComment
            // 
            this.columnEqComment.Text = "Примечание";
            this.columnEqComment.Width = 150;
            // 
            // contextMenuEquipment
            // 
            this.contextMenuEquipment.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cmEqAdd,
            this.cmEqCopy,
            this.cmEqEdit,
            this.cmEqDelete,
            this.cmEqMove});
            this.contextMenuEquipment.Name = "contextMenuEquipment";
            this.contextMenuEquipment.Size = new System.Drawing.Size(266, 114);
            // 
            // cmEqAdd
            // 
            this.cmEqAdd.Image = global::CompStore.Properties.Resources.add;
            this.cmEqAdd.Name = "cmEqAdd";
            this.cmEqAdd.ShortcutKeys = System.Windows.Forms.Keys.Insert;
            this.cmEqAdd.Size = new System.Drawing.Size(265, 22);
            this.cmEqAdd.Text = "Добавить";
            this.cmEqAdd.Click += new System.EventHandler(this.EquipmentAdd);
            // 
            // cmEqCopy
            // 
            this.cmEqCopy.Image = global::CompStore.Properties.Resources.copy;
            this.cmEqCopy.Name = "cmEqCopy";
            this.cmEqCopy.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Shift | System.Windows.Forms.Keys.Insert)));
            this.cmEqCopy.Size = new System.Drawing.Size(265, 22);
            this.cmEqCopy.Text = "Добавить копированием";
            this.cmEqCopy.Click += new System.EventHandler(this.EquipmentCopy);
            // 
            // cmEqEdit
            // 
            this.cmEqEdit.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.cmEqEdit.Image = global::CompStore.Properties.Resources.edit;
            this.cmEqEdit.Name = "cmEqEdit";
            this.cmEqEdit.Size = new System.Drawing.Size(265, 22);
            this.cmEqEdit.Text = "Изменить";
            this.cmEqEdit.Click += new System.EventHandler(this.EquipmentEdit);
            // 
            // cmEqDelete
            // 
            this.cmEqDelete.Image = global::CompStore.Properties.Resources.delete;
            this.cmEqDelete.Name = "cmEqDelete";
            this.cmEqDelete.ShortcutKeys = System.Windows.Forms.Keys.Delete;
            this.cmEqDelete.Size = new System.Drawing.Size(265, 22);
            this.cmEqDelete.Text = "Удалить";
            this.cmEqDelete.Click += new System.EventHandler(this.EquipmentDelete);
            // 
            // cmEqMove
            // 
            this.cmEqMove.Image = global::CompStore.Properties.Resources.move;
            this.cmEqMove.Name = "cmEqMove";
            this.cmEqMove.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Right)));
            this.cmEqMove.Size = new System.Drawing.Size(265, 22);
            this.cmEqMove.Text = "Переместить";
            this.cmEqMove.Click += new System.EventHandler(this.EquipmentsMove);
            // 
            // panelFilials
            // 
            this.panelFilials.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelFilials.Controls.Add(this.toolStripFilials);
            this.panelFilials.Controls.Add(this.listFilials);
            this.panelFilials.Location = new System.Drawing.Point(163, 27);
            this.panelFilials.Name = "panelFilials";
            this.panelFilials.Size = new System.Drawing.Size(1021, 709);
            this.panelFilials.TabIndex = 6;
            this.panelFilials.Visible = false;
            this.panelFilials.VisibleChanged += new System.EventHandler(this.FilialsView);
            // 
            // toolStripFilials
            // 
            this.toolStripFilials.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStripFilials.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolFilialLabel,
            this.toolFilialAdd,
            this.toolFilialEdit,
            this.toolFilialDelete,
            this.toolFilialFilterReset,
            this.toolFilialFilter,
            this.toolFilialFilterLabel});
            this.toolStripFilials.Location = new System.Drawing.Point(0, 0);
            this.toolStripFilials.Name = "toolStripFilials";
            this.toolStripFilials.Size = new System.Drawing.Size(1021, 25);
            this.toolStripFilials.TabIndex = 13;
            this.toolStripFilials.Text = "toolStrip1";
            // 
            // toolFilialLabel
            // 
            this.toolFilialLabel.AutoSize = false;
            this.toolFilialLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.toolFilialLabel.Name = "toolFilialLabel";
            this.toolFilialLabel.Size = new System.Drawing.Size(170, 22);
            this.toolFilialLabel.Text = "Филиалы";
            this.toolFilialLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // toolFilialAdd
            // 
            this.toolFilialAdd.Image = global::CompStore.Properties.Resources.add;
            this.toolFilialAdd.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolFilialAdd.Name = "toolFilialAdd";
            this.toolFilialAdd.Size = new System.Drawing.Size(79, 22);
            this.toolFilialAdd.Text = "Добавить";
            this.toolFilialAdd.Click += new System.EventHandler(this.FilialAdd);
            // 
            // toolFilialEdit
            // 
            this.toolFilialEdit.Image = global::CompStore.Properties.Resources.edit;
            this.toolFilialEdit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolFilialEdit.Name = "toolFilialEdit";
            this.toolFilialEdit.Size = new System.Drawing.Size(81, 22);
            this.toolFilialEdit.Text = "Изменить";
            this.toolFilialEdit.Click += new System.EventHandler(this.FilialEdit);
            // 
            // toolFilialDelete
            // 
            this.toolFilialDelete.Image = global::CompStore.Properties.Resources.delete;
            this.toolFilialDelete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolFilialDelete.Name = "toolFilialDelete";
            this.toolFilialDelete.Size = new System.Drawing.Size(71, 22);
            this.toolFilialDelete.Text = "Удалить";
            this.toolFilialDelete.Click += new System.EventHandler(this.FilialDelete);
            // 
            // toolFilialFilterReset
            // 
            this.toolFilialFilterReset.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolFilialFilterReset.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolFilialFilterReset.Image = global::CompStore.Properties.Resources.cancel;
            this.toolFilialFilterReset.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolFilialFilterReset.Name = "toolFilialFilterReset";
            this.toolFilialFilterReset.Size = new System.Drawing.Size(23, 22);
            this.toolFilialFilterReset.Click += new System.EventHandler(this.FilialFilterReset);
            // 
            // toolFilialFilter
            // 
            this.toolFilialFilter.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolFilialFilter.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.toolFilialFilter.Name = "toolFilialFilter";
            this.toolFilialFilter.Size = new System.Drawing.Size(300, 25);
            this.toolFilialFilter.TextChanged += new System.EventHandler(this.FilialsDraw);
            // 
            // toolFilialFilterLabel
            // 
            this.toolFilialFilterLabel.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolFilialFilterLabel.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolFilialFilterLabel.Image = global::CompStore.Properties.Resources.search;
            this.toolFilialFilterLabel.Name = "toolFilialFilterLabel";
            this.toolFilialFilterLabel.Size = new System.Drawing.Size(16, 22);
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
            this.listFilials.ContextMenuStrip = this.contextMenuFilials;
            this.listFilials.FullRowSelect = true;
            this.listFilials.HideSelection = false;
            this.listFilials.Location = new System.Drawing.Point(0, 25);
            this.listFilials.MultiSelect = false;
            this.listFilials.Name = "listFilials";
            this.listFilials.Size = new System.Drawing.Size(1021, 684);
            this.listFilials.TabIndex = 2;
            this.listFilials.UseCompatibleStateImageBehavior = false;
            this.listFilials.View = System.Windows.Forms.View.Details;
            this.listFilials.SelectedIndexChanged += new System.EventHandler(this.FilialsSelChange);
            this.listFilials.DoubleClick += new System.EventHandler(this.FilialEdit);
            this.listFilials.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FilialsKeyboard);
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
            // contextMenuFilials
            // 
            this.contextMenuFilials.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cmFilialAdd,
            this.cmFilialEdit,
            this.cmFilialDelete});
            this.contextMenuFilials.Name = "contextMenuEquipment";
            this.contextMenuFilials.Size = new System.Drawing.Size(149, 70);
            // 
            // cmFilialAdd
            // 
            this.cmFilialAdd.Image = global::CompStore.Properties.Resources.add;
            this.cmFilialAdd.Name = "cmFilialAdd";
            this.cmFilialAdd.ShortcutKeys = System.Windows.Forms.Keys.Insert;
            this.cmFilialAdd.Size = new System.Drawing.Size(148, 22);
            this.cmFilialAdd.Text = "Добавить";
            this.cmFilialAdd.Click += new System.EventHandler(this.FilialAdd);
            // 
            // cmFilialEdit
            // 
            this.cmFilialEdit.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.cmFilialEdit.Image = global::CompStore.Properties.Resources.edit;
            this.cmFilialEdit.Name = "cmFilialEdit";
            this.cmFilialEdit.Size = new System.Drawing.Size(148, 22);
            this.cmFilialEdit.Text = "Изменить";
            this.cmFilialEdit.Click += new System.EventHandler(this.FilialEdit);
            // 
            // cmFilialDelete
            // 
            this.cmFilialDelete.Image = global::CompStore.Properties.Resources.delete;
            this.cmFilialDelete.Name = "cmFilialDelete";
            this.cmFilialDelete.ShortcutKeys = System.Windows.Forms.Keys.Delete;
            this.cmFilialDelete.Size = new System.Drawing.Size(148, 22);
            this.cmFilialDelete.Text = "Удалить";
            this.cmFilialDelete.Click += new System.EventHandler(this.FilialDelete);
            // 
            // panelRooms
            // 
            this.panelRooms.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelRooms.Controls.Add(this.toolStripRooms);
            this.panelRooms.Controls.Add(this.listRooms);
            this.panelRooms.Location = new System.Drawing.Point(163, 27);
            this.panelRooms.Name = "panelRooms";
            this.panelRooms.Size = new System.Drawing.Size(1021, 709);
            this.panelRooms.TabIndex = 10;
            this.panelRooms.Visible = false;
            this.panelRooms.VisibleChanged += new System.EventHandler(this.RoomsView);
            // 
            // toolStripRooms
            // 
            this.toolStripRooms.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStripRooms.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolRoomLabel,
            this.toolRoomAdd,
            this.toolRoomEdit,
            this.toolRoomDelete,
            this.toolRoomFilterReset,
            this.toolRoomFilter,
            this.toolRoomFilterLabel});
            this.toolStripRooms.Location = new System.Drawing.Point(0, 0);
            this.toolStripRooms.Name = "toolStripRooms";
            this.toolStripRooms.Size = new System.Drawing.Size(1021, 25);
            this.toolStripRooms.TabIndex = 15;
            this.toolStripRooms.Text = "123";
            // 
            // toolRoomLabel
            // 
            this.toolRoomLabel.AutoSize = false;
            this.toolRoomLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.toolRoomLabel.Name = "toolRoomLabel";
            this.toolRoomLabel.Size = new System.Drawing.Size(170, 22);
            this.toolRoomLabel.Text = "Помещения";
            this.toolRoomLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // toolRoomAdd
            // 
            this.toolRoomAdd.Image = global::CompStore.Properties.Resources.add;
            this.toolRoomAdd.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolRoomAdd.Name = "toolRoomAdd";
            this.toolRoomAdd.Size = new System.Drawing.Size(79, 22);
            this.toolRoomAdd.Text = "Добавить";
            this.toolRoomAdd.Click += new System.EventHandler(this.RoomAdd);
            // 
            // toolRoomEdit
            // 
            this.toolRoomEdit.Image = global::CompStore.Properties.Resources.edit;
            this.toolRoomEdit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolRoomEdit.Name = "toolRoomEdit";
            this.toolRoomEdit.Size = new System.Drawing.Size(81, 22);
            this.toolRoomEdit.Text = "Изменить";
            this.toolRoomEdit.Click += new System.EventHandler(this.RoomEdit);
            // 
            // toolRoomDelete
            // 
            this.toolRoomDelete.Image = global::CompStore.Properties.Resources.delete;
            this.toolRoomDelete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolRoomDelete.Name = "toolRoomDelete";
            this.toolRoomDelete.Size = new System.Drawing.Size(71, 22);
            this.toolRoomDelete.Text = "Удалить";
            this.toolRoomDelete.Click += new System.EventHandler(this.RoomDelete);
            // 
            // toolRoomFilterReset
            // 
            this.toolRoomFilterReset.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolRoomFilterReset.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolRoomFilterReset.Image = global::CompStore.Properties.Resources.cancel;
            this.toolRoomFilterReset.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolRoomFilterReset.Name = "toolRoomFilterReset";
            this.toolRoomFilterReset.Size = new System.Drawing.Size(23, 22);
            this.toolRoomFilterReset.Click += new System.EventHandler(this.RoomFilterReset);
            // 
            // toolRoomFilter
            // 
            this.toolRoomFilter.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolRoomFilter.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.toolRoomFilter.Name = "toolRoomFilter";
            this.toolRoomFilter.Size = new System.Drawing.Size(300, 25);
            this.toolRoomFilter.TextChanged += new System.EventHandler(this.RoomsDraw);
            // 
            // toolRoomFilterLabel
            // 
            this.toolRoomFilterLabel.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolRoomFilterLabel.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolRoomFilterLabel.Image = global::CompStore.Properties.Resources.search;
            this.toolRoomFilterLabel.Name = "toolRoomFilterLabel";
            this.toolRoomFilterLabel.Size = new System.Drawing.Size(16, 22);
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
            this.listRooms.ContextMenuStrip = this.contextMenuRooms;
            this.listRooms.FullRowSelect = true;
            this.listRooms.HideSelection = false;
            this.listRooms.Location = new System.Drawing.Point(0, 25);
            this.listRooms.MultiSelect = false;
            this.listRooms.Name = "listRooms";
            this.listRooms.Size = new System.Drawing.Size(1021, 684);
            this.listRooms.TabIndex = 2;
            this.listRooms.UseCompatibleStateImageBehavior = false;
            this.listRooms.View = System.Windows.Forms.View.Details;
            this.listRooms.SelectedIndexChanged += new System.EventHandler(this.RoomsSelChange);
            this.listRooms.DoubleClick += new System.EventHandler(this.RoomEdit);
            this.listRooms.KeyDown += new System.Windows.Forms.KeyEventHandler(this.RoomsKeyboard);
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
            // contextMenuRooms
            // 
            this.contextMenuRooms.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cmRoomAdd,
            this.cmRoomEdit,
            this.cmRoomDelete});
            this.contextMenuRooms.Name = "contextMenuEquipment";
            this.contextMenuRooms.Size = new System.Drawing.Size(149, 70);
            // 
            // cmRoomAdd
            // 
            this.cmRoomAdd.Image = global::CompStore.Properties.Resources.add;
            this.cmRoomAdd.Name = "cmRoomAdd";
            this.cmRoomAdd.ShortcutKeys = System.Windows.Forms.Keys.Insert;
            this.cmRoomAdd.Size = new System.Drawing.Size(148, 22);
            this.cmRoomAdd.Text = "Добавить";
            this.cmRoomAdd.Click += new System.EventHandler(this.RoomAdd);
            // 
            // cmRoomEdit
            // 
            this.cmRoomEdit.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.cmRoomEdit.Image = global::CompStore.Properties.Resources.edit;
            this.cmRoomEdit.Name = "cmRoomEdit";
            this.cmRoomEdit.Size = new System.Drawing.Size(148, 22);
            this.cmRoomEdit.Text = "Изменить";
            this.cmRoomEdit.Click += new System.EventHandler(this.RoomEdit);
            // 
            // cmRoomDelete
            // 
            this.cmRoomDelete.Image = global::CompStore.Properties.Resources.delete;
            this.cmRoomDelete.Name = "cmRoomDelete";
            this.cmRoomDelete.ShortcutKeys = System.Windows.Forms.Keys.Delete;
            this.cmRoomDelete.Size = new System.Drawing.Size(148, 22);
            this.cmRoomDelete.Text = "Удалить";
            this.cmRoomDelete.Click += new System.EventHandler(this.RoomDelete);
            // 
            // panelPosts
            // 
            this.panelPosts.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelPosts.Controls.Add(this.toolStripPosts);
            this.panelPosts.Controls.Add(this.listPosts);
            this.panelPosts.Location = new System.Drawing.Point(163, 27);
            this.panelPosts.Name = "panelPosts";
            this.panelPosts.Size = new System.Drawing.Size(1021, 709);
            this.panelPosts.TabIndex = 11;
            this.panelPosts.Visible = false;
            this.panelPosts.VisibleChanged += new System.EventHandler(this.PostsView);
            // 
            // toolStripPosts
            // 
            this.toolStripPosts.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStripPosts.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolPostLabel,
            this.toolPostAdd,
            this.toolPostEdit,
            this.toolPostDelete,
            this.toolPostFilterReset,
            this.toolPostFilter,
            this.toolPostFilterLabel});
            this.toolStripPosts.Location = new System.Drawing.Point(0, 0);
            this.toolStripPosts.Name = "toolStripPosts";
            this.toolStripPosts.Size = new System.Drawing.Size(1021, 25);
            this.toolStripPosts.TabIndex = 9;
            this.toolStripPosts.Text = "toolStrip1";
            // 
            // toolPostLabel
            // 
            this.toolPostLabel.AutoSize = false;
            this.toolPostLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.toolPostLabel.Name = "toolPostLabel";
            this.toolPostLabel.Size = new System.Drawing.Size(170, 22);
            this.toolPostLabel.Text = "Должности";
            this.toolPostLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // toolPostAdd
            // 
            this.toolPostAdd.Image = global::CompStore.Properties.Resources.add;
            this.toolPostAdd.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolPostAdd.Name = "toolPostAdd";
            this.toolPostAdd.Size = new System.Drawing.Size(79, 22);
            this.toolPostAdd.Text = "Добавить";
            this.toolPostAdd.Click += new System.EventHandler(this.PostAdd);
            // 
            // toolPostEdit
            // 
            this.toolPostEdit.Image = global::CompStore.Properties.Resources.edit;
            this.toolPostEdit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolPostEdit.Name = "toolPostEdit";
            this.toolPostEdit.Size = new System.Drawing.Size(81, 22);
            this.toolPostEdit.Text = "Изменить";
            this.toolPostEdit.Click += new System.EventHandler(this.PostEdit);
            // 
            // toolPostDelete
            // 
            this.toolPostDelete.Image = global::CompStore.Properties.Resources.delete;
            this.toolPostDelete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolPostDelete.Name = "toolPostDelete";
            this.toolPostDelete.Size = new System.Drawing.Size(71, 22);
            this.toolPostDelete.Text = "Удалить";
            this.toolPostDelete.Click += new System.EventHandler(this.PostDelete);
            // 
            // toolPostFilterReset
            // 
            this.toolPostFilterReset.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolPostFilterReset.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolPostFilterReset.Image = global::CompStore.Properties.Resources.cancel;
            this.toolPostFilterReset.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolPostFilterReset.Name = "toolPostFilterReset";
            this.toolPostFilterReset.Size = new System.Drawing.Size(23, 22);
            this.toolPostFilterReset.Click += new System.EventHandler(this.PostFilterReset);
            // 
            // toolPostFilter
            // 
            this.toolPostFilter.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolPostFilter.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.toolPostFilter.Name = "toolPostFilter";
            this.toolPostFilter.Size = new System.Drawing.Size(300, 25);
            this.toolPostFilter.TextChanged += new System.EventHandler(this.PostsDraw);
            // 
            // toolPostFilterLabel
            // 
            this.toolPostFilterLabel.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolPostFilterLabel.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolPostFilterLabel.Image = global::CompStore.Properties.Resources.search;
            this.toolPostFilterLabel.Name = "toolPostFilterLabel";
            this.toolPostFilterLabel.Size = new System.Drawing.Size(16, 22);
            // 
            // listPosts
            // 
            this.listPosts.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnPostName});
            this.listPosts.ContextMenuStrip = this.contextMenuPosts;
            this.listPosts.FullRowSelect = true;
            this.listPosts.HideSelection = false;
            this.listPosts.Location = new System.Drawing.Point(0, 25);
            this.listPosts.MultiSelect = false;
            this.listPosts.Name = "listPosts";
            this.listPosts.Size = new System.Drawing.Size(1021, 684);
            this.listPosts.TabIndex = 2;
            this.listPosts.UseCompatibleStateImageBehavior = false;
            this.listPosts.View = System.Windows.Forms.View.Details;
            this.listPosts.SelectedIndexChanged += new System.EventHandler(this.PostsSelChange);
            this.listPosts.DoubleClick += new System.EventHandler(this.PostEdit);
            this.listPosts.KeyDown += new System.Windows.Forms.KeyEventHandler(this.PostsKeyboard);
            // 
            // columnPostName
            // 
            this.columnPostName.Text = "Название";
            this.columnPostName.Width = 990;
            // 
            // contextMenuPosts
            // 
            this.contextMenuPosts.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cmPostAdd,
            this.cmPostEdit,
            this.cmPostDelete});
            this.contextMenuPosts.Name = "contextMenuEquipment";
            this.contextMenuPosts.Size = new System.Drawing.Size(149, 70);
            // 
            // cmPostAdd
            // 
            this.cmPostAdd.Image = global::CompStore.Properties.Resources.add;
            this.cmPostAdd.Name = "cmPostAdd";
            this.cmPostAdd.ShortcutKeys = System.Windows.Forms.Keys.Insert;
            this.cmPostAdd.Size = new System.Drawing.Size(148, 22);
            this.cmPostAdd.Text = "Добавить";
            this.cmPostAdd.Click += new System.EventHandler(this.PostAdd);
            // 
            // cmPostEdit
            // 
            this.cmPostEdit.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.cmPostEdit.Image = global::CompStore.Properties.Resources.edit;
            this.cmPostEdit.Name = "cmPostEdit";
            this.cmPostEdit.Size = new System.Drawing.Size(148, 22);
            this.cmPostEdit.Text = "Изменить";
            this.cmPostEdit.Click += new System.EventHandler(this.PostEdit);
            // 
            // cmPostDelete
            // 
            this.cmPostDelete.Image = global::CompStore.Properties.Resources.delete;
            this.cmPostDelete.Name = "cmPostDelete";
            this.cmPostDelete.ShortcutKeys = System.Windows.Forms.Keys.Delete;
            this.cmPostDelete.Size = new System.Drawing.Size(148, 22);
            this.cmPostDelete.Text = "Удалить";
            this.cmPostDelete.Click += new System.EventHandler(this.PostDelete);
            // 
            // panelBuildings
            // 
            this.panelBuildings.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelBuildings.Controls.Add(this.toolStripBuildings);
            this.panelBuildings.Controls.Add(this.listBuildings);
            this.panelBuildings.Location = new System.Drawing.Point(163, 27);
            this.panelBuildings.Name = "panelBuildings";
            this.panelBuildings.Size = new System.Drawing.Size(1021, 709);
            this.panelBuildings.TabIndex = 11;
            this.panelBuildings.Visible = false;
            this.panelBuildings.VisibleChanged += new System.EventHandler(this.BuildingsView);
            // 
            // toolStripBuildings
            // 
            this.toolStripBuildings.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStripBuildings.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolBuildingLabel,
            this.toolBuildingAdd,
            this.toolBuildingEdit,
            this.toolBuildingDelete,
            this.toolBuildingFilterReset,
            this.toolBuildingFilter,
            this.toolBuildingFilterLabel});
            this.toolStripBuildings.Location = new System.Drawing.Point(0, 0);
            this.toolStripBuildings.Name = "toolStripBuildings";
            this.toolStripBuildings.Size = new System.Drawing.Size(1021, 25);
            this.toolStripBuildings.TabIndex = 14;
            this.toolStripBuildings.Text = "123";
            // 
            // toolBuildingLabel
            // 
            this.toolBuildingLabel.AutoSize = false;
            this.toolBuildingLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.toolBuildingLabel.Name = "toolBuildingLabel";
            this.toolBuildingLabel.Size = new System.Drawing.Size(170, 22);
            this.toolBuildingLabel.Text = "Здания";
            this.toolBuildingLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // toolBuildingAdd
            // 
            this.toolBuildingAdd.Image = global::CompStore.Properties.Resources.add;
            this.toolBuildingAdd.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolBuildingAdd.Name = "toolBuildingAdd";
            this.toolBuildingAdd.Size = new System.Drawing.Size(79, 22);
            this.toolBuildingAdd.Text = "Добавить";
            this.toolBuildingAdd.Click += new System.EventHandler(this.BuildingAdd);
            // 
            // toolBuildingEdit
            // 
            this.toolBuildingEdit.Image = global::CompStore.Properties.Resources.edit;
            this.toolBuildingEdit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolBuildingEdit.Name = "toolBuildingEdit";
            this.toolBuildingEdit.Size = new System.Drawing.Size(81, 22);
            this.toolBuildingEdit.Text = "Изменить";
            this.toolBuildingEdit.Click += new System.EventHandler(this.BuildingEdit);
            // 
            // toolBuildingDelete
            // 
            this.toolBuildingDelete.Image = global::CompStore.Properties.Resources.delete;
            this.toolBuildingDelete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolBuildingDelete.Name = "toolBuildingDelete";
            this.toolBuildingDelete.Size = new System.Drawing.Size(71, 22);
            this.toolBuildingDelete.Text = "Удалить";
            this.toolBuildingDelete.Click += new System.EventHandler(this.BuildingDelete);
            // 
            // toolBuildingFilterReset
            // 
            this.toolBuildingFilterReset.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolBuildingFilterReset.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolBuildingFilterReset.Image = global::CompStore.Properties.Resources.cancel;
            this.toolBuildingFilterReset.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolBuildingFilterReset.Name = "toolBuildingFilterReset";
            this.toolBuildingFilterReset.Size = new System.Drawing.Size(23, 22);
            this.toolBuildingFilterReset.Click += new System.EventHandler(this.BuildingsFilterReset);
            // 
            // toolBuildingFilter
            // 
            this.toolBuildingFilter.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolBuildingFilter.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.toolBuildingFilter.Name = "toolBuildingFilter";
            this.toolBuildingFilter.Size = new System.Drawing.Size(300, 25);
            this.toolBuildingFilter.TextChanged += new System.EventHandler(this.BuildingsDraw);
            // 
            // toolBuildingFilterLabel
            // 
            this.toolBuildingFilterLabel.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolBuildingFilterLabel.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolBuildingFilterLabel.Image = global::CompStore.Properties.Resources.search;
            this.toolBuildingFilterLabel.Name = "toolBuildingFilterLabel";
            this.toolBuildingFilterLabel.Size = new System.Drawing.Size(16, 22);
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
            this.listBuildings.ContextMenuStrip = this.contextMenuBuildings;
            this.listBuildings.FullRowSelect = true;
            this.listBuildings.HideSelection = false;
            this.listBuildings.Location = new System.Drawing.Point(0, 25);
            this.listBuildings.MultiSelect = false;
            this.listBuildings.Name = "listBuildings";
            this.listBuildings.Size = new System.Drawing.Size(1021, 684);
            this.listBuildings.TabIndex = 2;
            this.listBuildings.UseCompatibleStateImageBehavior = false;
            this.listBuildings.View = System.Windows.Forms.View.Details;
            this.listBuildings.SelectedIndexChanged += new System.EventHandler(this.BuildingsSelChange);
            this.listBuildings.DoubleClick += new System.EventHandler(this.BuildingEdit);
            this.listBuildings.KeyDown += new System.Windows.Forms.KeyEventHandler(this.BuildingsKeyboard);
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
            // contextMenuBuildings
            // 
            this.contextMenuBuildings.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cmBuildingAdd,
            this.cmBuildingEdit,
            this.cmBuildingDelete});
            this.contextMenuBuildings.Name = "contextMenuEquipment";
            this.contextMenuBuildings.Size = new System.Drawing.Size(149, 70);
            // 
            // cmBuildingAdd
            // 
            this.cmBuildingAdd.Image = global::CompStore.Properties.Resources.add;
            this.cmBuildingAdd.Name = "cmBuildingAdd";
            this.cmBuildingAdd.ShortcutKeys = System.Windows.Forms.Keys.Insert;
            this.cmBuildingAdd.Size = new System.Drawing.Size(148, 22);
            this.cmBuildingAdd.Text = "Добавить";
            this.cmBuildingAdd.Click += new System.EventHandler(this.BuildingAdd);
            // 
            // cmBuildingEdit
            // 
            this.cmBuildingEdit.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.cmBuildingEdit.Image = global::CompStore.Properties.Resources.edit;
            this.cmBuildingEdit.Name = "cmBuildingEdit";
            this.cmBuildingEdit.Size = new System.Drawing.Size(148, 22);
            this.cmBuildingEdit.Text = "Изменить";
            this.cmBuildingEdit.Click += new System.EventHandler(this.BuildingEdit);
            // 
            // cmBuildingDelete
            // 
            this.cmBuildingDelete.Image = global::CompStore.Properties.Resources.delete;
            this.cmBuildingDelete.Name = "cmBuildingDelete";
            this.cmBuildingDelete.ShortcutKeys = System.Windows.Forms.Keys.Delete;
            this.cmBuildingDelete.Size = new System.Drawing.Size(148, 22);
            this.cmBuildingDelete.Text = "Удалить";
            this.cmBuildingDelete.Click += new System.EventHandler(this.BuildingDelete);
            // 
            // panelDeps
            // 
            this.panelDeps.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelDeps.Controls.Add(this.toolStripDeps);
            this.panelDeps.Controls.Add(this.listDeps);
            this.panelDeps.Location = new System.Drawing.Point(163, 27);
            this.panelDeps.Name = "panelDeps";
            this.panelDeps.Size = new System.Drawing.Size(1021, 709);
            this.panelDeps.TabIndex = 12;
            this.panelDeps.Visible = false;
            this.panelDeps.VisibleChanged += new System.EventHandler(this.DepsView);
            // 
            // toolStripDeps
            // 
            this.toolStripDeps.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStripDeps.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolDepLabel,
            this.toolDepAdd,
            this.toolDepEdit,
            this.toolDepDelete,
            this.toolDepFilterReset,
            this.toolDepFilter,
            this.toolDepFilterLabel});
            this.toolStripDeps.Location = new System.Drawing.Point(0, 0);
            this.toolStripDeps.Name = "toolStripDeps";
            this.toolStripDeps.Size = new System.Drawing.Size(1021, 25);
            this.toolStripDeps.TabIndex = 11;
            this.toolStripDeps.Text = "toolStrip1";
            // 
            // toolDepLabel
            // 
            this.toolDepLabel.AutoSize = false;
            this.toolDepLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.toolDepLabel.Name = "toolDepLabel";
            this.toolDepLabel.Size = new System.Drawing.Size(170, 22);
            this.toolDepLabel.Text = "Подразделения";
            this.toolDepLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // toolDepAdd
            // 
            this.toolDepAdd.Image = global::CompStore.Properties.Resources.add;
            this.toolDepAdd.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolDepAdd.Name = "toolDepAdd";
            this.toolDepAdd.Size = new System.Drawing.Size(79, 22);
            this.toolDepAdd.Text = "Добавить";
            this.toolDepAdd.Click += new System.EventHandler(this.DepAdd);
            // 
            // toolDepEdit
            // 
            this.toolDepEdit.Image = global::CompStore.Properties.Resources.edit;
            this.toolDepEdit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolDepEdit.Name = "toolDepEdit";
            this.toolDepEdit.Size = new System.Drawing.Size(81, 22);
            this.toolDepEdit.Text = "Изменить";
            this.toolDepEdit.Click += new System.EventHandler(this.DepEdit);
            // 
            // toolDepDelete
            // 
            this.toolDepDelete.Image = global::CompStore.Properties.Resources.delete;
            this.toolDepDelete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolDepDelete.Name = "toolDepDelete";
            this.toolDepDelete.Size = new System.Drawing.Size(71, 22);
            this.toolDepDelete.Text = "Удалить";
            this.toolDepDelete.Click += new System.EventHandler(this.DepDelete);
            // 
            // toolDepFilterReset
            // 
            this.toolDepFilterReset.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolDepFilterReset.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolDepFilterReset.Image = global::CompStore.Properties.Resources.cancel;
            this.toolDepFilterReset.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolDepFilterReset.Name = "toolDepFilterReset";
            this.toolDepFilterReset.Size = new System.Drawing.Size(23, 22);
            this.toolDepFilterReset.Click += new System.EventHandler(this.DepFilterReset);
            // 
            // toolDepFilter
            // 
            this.toolDepFilter.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolDepFilter.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.toolDepFilter.Name = "toolDepFilter";
            this.toolDepFilter.Size = new System.Drawing.Size(300, 25);
            this.toolDepFilter.TextChanged += new System.EventHandler(this.DepsDraw);
            // 
            // toolDepFilterLabel
            // 
            this.toolDepFilterLabel.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolDepFilterLabel.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolDepFilterLabel.Image = global::CompStore.Properties.Resources.search;
            this.toolDepFilterLabel.Name = "toolDepFilterLabel";
            this.toolDepFilterLabel.Size = new System.Drawing.Size(16, 22);
            // 
            // listDeps
            // 
            this.listDeps.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listDeps.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnDepName,
            this.columnDepComment});
            this.listDeps.ContextMenuStrip = this.contextMenuDeps;
            this.listDeps.FullRowSelect = true;
            this.listDeps.HideSelection = false;
            this.listDeps.Location = new System.Drawing.Point(0, 25);
            this.listDeps.MultiSelect = false;
            this.listDeps.Name = "listDeps";
            this.listDeps.Size = new System.Drawing.Size(1021, 684);
            this.listDeps.TabIndex = 2;
            this.listDeps.UseCompatibleStateImageBehavior = false;
            this.listDeps.View = System.Windows.Forms.View.Details;
            this.listDeps.SelectedIndexChanged += new System.EventHandler(this.DepsSelChange);
            this.listDeps.DoubleClick += new System.EventHandler(this.DepEdit);
            this.listDeps.KeyDown += new System.Windows.Forms.KeyEventHandler(this.DepsKeyboard);
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
            // contextMenuDeps
            // 
            this.contextMenuDeps.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cmDepAdd,
            this.cmDepEdit,
            this.cmDepDelete});
            this.contextMenuDeps.Name = "contextMenuEquipment";
            this.contextMenuDeps.Size = new System.Drawing.Size(149, 70);
            // 
            // cmDepAdd
            // 
            this.cmDepAdd.Image = global::CompStore.Properties.Resources.add;
            this.cmDepAdd.Name = "cmDepAdd";
            this.cmDepAdd.ShortcutKeys = System.Windows.Forms.Keys.Insert;
            this.cmDepAdd.Size = new System.Drawing.Size(148, 22);
            this.cmDepAdd.Text = "Добавить";
            this.cmDepAdd.Click += new System.EventHandler(this.DepAdd);
            // 
            // cmDepEdit
            // 
            this.cmDepEdit.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.cmDepEdit.Image = global::CompStore.Properties.Resources.edit;
            this.cmDepEdit.Name = "cmDepEdit";
            this.cmDepEdit.Size = new System.Drawing.Size(148, 22);
            this.cmDepEdit.Text = "Изменить";
            this.cmDepEdit.Click += new System.EventHandler(this.DepEdit);
            // 
            // cmDepDelete
            // 
            this.cmDepDelete.Image = global::CompStore.Properties.Resources.delete;
            this.cmDepDelete.Name = "cmDepDelete";
            this.cmDepDelete.ShortcutKeys = System.Windows.Forms.Keys.Delete;
            this.cmDepDelete.Size = new System.Drawing.Size(148, 22);
            this.cmDepDelete.Text = "Удалить";
            this.cmDepDelete.Click += new System.EventHandler(this.DepDelete);
            // 
            // panelUsers
            // 
            this.panelUsers.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelUsers.Controls.Add(this.panelUsDown);
            this.panelUsers.Controls.Add(this.splitterUsers);
            this.panelUsers.Controls.Add(this.panelUsUp);
            this.panelUsers.Location = new System.Drawing.Point(163, 27);
            this.panelUsers.Name = "panelUsers";
            this.panelUsers.Size = new System.Drawing.Size(1021, 709);
            this.panelUsers.TabIndex = 13;
            this.panelUsers.Visible = false;
            this.panelUsers.VisibleChanged += new System.EventHandler(this.UsersView);
            // 
            // panelUsDown
            // 
            this.panelUsDown.Controls.Add(this.tabUsers);
            this.panelUsDown.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelUsDown.Location = new System.Drawing.Point(0, 408);
            this.panelUsDown.Name = "panelUsDown";
            this.panelUsDown.Size = new System.Drawing.Size(1021, 301);
            this.panelUsDown.TabIndex = 16;
            // 
            // tabUsers
            // 
            this.tabUsers.Controls.Add(this.tabUsEquipments);
            this.tabUsers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabUsers.Location = new System.Drawing.Point(0, 0);
            this.tabUsers.Name = "tabUsers";
            this.tabUsers.SelectedIndex = 0;
            this.tabUsers.Size = new System.Drawing.Size(1021, 301);
            this.tabUsers.TabIndex = 0;
            // 
            // tabUsEquipments
            // 
            this.tabUsEquipments.Controls.Add(this.listUsEquipment);
            this.tabUsEquipments.Location = new System.Drawing.Point(4, 22);
            this.tabUsEquipments.Name = "tabUsEquipments";
            this.tabUsEquipments.Padding = new System.Windows.Forms.Padding(3);
            this.tabUsEquipments.Size = new System.Drawing.Size(1013, 275);
            this.tabUsEquipments.TabIndex = 0;
            this.tabUsEquipments.Text = "Оборудование";
            this.tabUsEquipments.UseVisualStyleBackColor = true;
            // 
            // listUsEquipment
            // 
            this.listUsEquipment.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8});
            this.listUsEquipment.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listUsEquipment.FullRowSelect = true;
            this.listUsEquipment.HideSelection = false;
            this.listUsEquipment.Location = new System.Drawing.Point(3, 3);
            this.listUsEquipment.Name = "listUsEquipment";
            this.listUsEquipment.Size = new System.Drawing.Size(1007, 269);
            this.listUsEquipment.TabIndex = 11;
            this.listUsEquipment.UseCompatibleStateImageBehavior = false;
            this.listUsEquipment.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Наименование";
            this.columnHeader1.Width = 180;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Серийный номер";
            this.columnHeader2.Width = 125;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Инвентарный номер";
            this.columnHeader3.Width = 125;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Ответственный";
            this.columnHeader4.Width = 140;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Помещение";
            this.columnHeader5.Width = 120;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Выдано";
            this.columnHeader6.Width = 70;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Куплено";
            this.columnHeader7.Width = 70;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Примечание";
            this.columnHeader8.Width = 160;
            // 
            // splitterUsers
            // 
            this.splitterUsers.Dock = System.Windows.Forms.DockStyle.Top;
            this.splitterUsers.Location = new System.Drawing.Point(0, 400);
            this.splitterUsers.Name = "splitterUsers";
            this.splitterUsers.Size = new System.Drawing.Size(1021, 8);
            this.splitterUsers.TabIndex = 15;
            this.splitterUsers.TabStop = false;
            // 
            // panelUsUp
            // 
            this.panelUsUp.Controls.Add(this.listUsers);
            this.panelUsUp.Controls.Add(this.toolStripUsers);
            this.panelUsUp.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelUsUp.Location = new System.Drawing.Point(0, 0);
            this.panelUsUp.Name = "panelUsUp";
            this.panelUsUp.Size = new System.Drawing.Size(1021, 400);
            this.panelUsUp.TabIndex = 14;
            // 
            // listUsers
            // 
            this.listUsers.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnUserName,
            this.columnUserDep,
            this.columnUserPost,
            this.columnUserPlace,
            this.columnUserCom});
            this.listUsers.ContextMenuStrip = this.contextMenuUsers;
            this.listUsers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listUsers.FullRowSelect = true;
            this.listUsers.HideSelection = false;
            this.listUsers.Location = new System.Drawing.Point(0, 25);
            this.listUsers.Name = "listUsers";
            this.listUsers.Size = new System.Drawing.Size(1021, 375);
            this.listUsers.TabIndex = 2;
            this.listUsers.UseCompatibleStateImageBehavior = false;
            this.listUsers.View = System.Windows.Forms.View.Details;
            this.listUsers.SelectedIndexChanged += new System.EventHandler(this.UsersSelChange);
            this.listUsers.DoubleClick += new System.EventHandler(this.UserEdit);
            this.listUsers.KeyDown += new System.Windows.Forms.KeyEventHandler(this.UsersKeyboard);
            // 
            // columnUserName
            // 
            this.columnUserName.Text = "ФИО";
            this.columnUserName.Width = 230;
            // 
            // columnUserDep
            // 
            this.columnUserDep.Text = "Подразделение";
            this.columnUserDep.Width = 190;
            // 
            // columnUserPost
            // 
            this.columnUserPost.Text = "Должность";
            this.columnUserPost.Width = 190;
            // 
            // columnUserPlace
            // 
            this.columnUserPlace.Text = "Расположение";
            this.columnUserPlace.Width = 230;
            // 
            // columnUserCom
            // 
            this.columnUserCom.Text = "Примечание";
            this.columnUserCom.Width = 150;
            // 
            // contextMenuUsers
            // 
            this.contextMenuUsers.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cmUserAdd,
            this.cmUserEdit,
            this.cmUserDelete});
            this.contextMenuUsers.Name = "contextMenuEquipment";
            this.contextMenuUsers.Size = new System.Drawing.Size(149, 70);
            // 
            // cmUserAdd
            // 
            this.cmUserAdd.Image = global::CompStore.Properties.Resources.add;
            this.cmUserAdd.Name = "cmUserAdd";
            this.cmUserAdd.ShortcutKeys = System.Windows.Forms.Keys.Insert;
            this.cmUserAdd.Size = new System.Drawing.Size(148, 22);
            this.cmUserAdd.Text = "Добавить";
            this.cmUserAdd.Click += new System.EventHandler(this.UserAdd);
            // 
            // cmUserEdit
            // 
            this.cmUserEdit.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.cmUserEdit.Image = global::CompStore.Properties.Resources.edit;
            this.cmUserEdit.Name = "cmUserEdit";
            this.cmUserEdit.Size = new System.Drawing.Size(148, 22);
            this.cmUserEdit.Text = "Изменить";
            this.cmUserEdit.Click += new System.EventHandler(this.UserEdit);
            // 
            // cmUserDelete
            // 
            this.cmUserDelete.Image = global::CompStore.Properties.Resources.delete;
            this.cmUserDelete.Name = "cmUserDelete";
            this.cmUserDelete.ShortcutKeys = System.Windows.Forms.Keys.Delete;
            this.cmUserDelete.Size = new System.Drawing.Size(148, 22);
            this.cmUserDelete.Text = "Удалить";
            this.cmUserDelete.Click += new System.EventHandler(this.UserDelete);
            // 
            // toolStripUsers
            // 
            this.toolStripUsers.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStripUsers.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolUserLabel,
            this.toolUserAdd,
            this.toolUserEdit,
            this.toolUserDelete,
            this.toolUserFilterReset,
            this.toolUserFilter,
            this.toolUserFilterLabel});
            this.toolStripUsers.Location = new System.Drawing.Point(0, 0);
            this.toolStripUsers.Name = "toolStripUsers";
            this.toolStripUsers.Size = new System.Drawing.Size(1021, 25);
            this.toolStripUsers.TabIndex = 13;
            // 
            // toolUserLabel
            // 
            this.toolUserLabel.AutoSize = false;
            this.toolUserLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.toolUserLabel.Name = "toolUserLabel";
            this.toolUserLabel.Size = new System.Drawing.Size(170, 22);
            this.toolUserLabel.Text = "Сотрудники";
            this.toolUserLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // toolUserAdd
            // 
            this.toolUserAdd.Image = global::CompStore.Properties.Resources.add;
            this.toolUserAdd.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolUserAdd.Name = "toolUserAdd";
            this.toolUserAdd.Size = new System.Drawing.Size(79, 22);
            this.toolUserAdd.Text = "Добавить";
            this.toolUserAdd.Click += new System.EventHandler(this.UserAdd);
            // 
            // toolUserEdit
            // 
            this.toolUserEdit.Image = global::CompStore.Properties.Resources.edit;
            this.toolUserEdit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolUserEdit.Name = "toolUserEdit";
            this.toolUserEdit.Size = new System.Drawing.Size(81, 22);
            this.toolUserEdit.Text = "Изменить";
            this.toolUserEdit.Click += new System.EventHandler(this.UserEdit);
            // 
            // toolUserDelete
            // 
            this.toolUserDelete.Image = global::CompStore.Properties.Resources.delete;
            this.toolUserDelete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolUserDelete.Name = "toolUserDelete";
            this.toolUserDelete.Size = new System.Drawing.Size(71, 22);
            this.toolUserDelete.Text = "Удалить";
            this.toolUserDelete.Click += new System.EventHandler(this.UserDelete);
            // 
            // toolUserFilterReset
            // 
            this.toolUserFilterReset.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolUserFilterReset.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolUserFilterReset.Image = global::CompStore.Properties.Resources.cancel;
            this.toolUserFilterReset.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolUserFilterReset.Name = "toolUserFilterReset";
            this.toolUserFilterReset.Size = new System.Drawing.Size(23, 22);
            this.toolUserFilterReset.Click += new System.EventHandler(this.UserFilterReset);
            // 
            // toolUserFilter
            // 
            this.toolUserFilter.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolUserFilter.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.toolUserFilter.Name = "toolUserFilter";
            this.toolUserFilter.Size = new System.Drawing.Size(300, 25);
            this.toolUserFilter.TextChanged += new System.EventHandler(this.UsersDraw);
            // 
            // toolUserFilterLabel
            // 
            this.toolUserFilterLabel.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolUserFilterLabel.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolUserFilterLabel.Image = global::CompStore.Properties.Resources.search;
            this.toolUserFilterLabel.Name = "toolUserFilterLabel";
            this.toolUserFilterLabel.Size = new System.Drawing.Size(16, 22);
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
            this.toolBrandDelete.Image = global::CompStore.Properties.Resources.delete;
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
            this.cmBrandDelete.Image = global::CompStore.Properties.Resources.delete;
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
            this.toolETDelete.Image = global::CompStore.Properties.Resources.delete;
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
            this.cmETDelete.Image = global::CompStore.Properties.Resources.delete;
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
            this.toolModelDelete.Image = global::CompStore.Properties.Resources.delete;
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
            this.cmModelDelete.Image = global::CompStore.Properties.Resources.delete;
            this.cmModelDelete.Name = "cmModelDelete";
            this.cmModelDelete.ShortcutKeys = System.Windows.Forms.Keys.Delete;
            this.cmModelDelete.Size = new System.Drawing.Size(148, 22);
            this.cmModelDelete.Text = "Удалить";
            this.cmModelDelete.Click += new System.EventHandler(this.ModelDelete);
            // 
            // panelMoves
            // 
            this.panelMoves.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelMoves.Controls.Add(this.toolStripMoves);
            this.panelMoves.Controls.Add(this.listMoves);
            this.panelMoves.Location = new System.Drawing.Point(163, 27);
            this.panelMoves.Name = "panelMoves";
            this.panelMoves.Size = new System.Drawing.Size(1021, 709);
            this.panelMoves.TabIndex = 17;
            this.panelMoves.Visible = false;
            this.panelMoves.VisibleChanged += new System.EventHandler(this.MovesView);
            // 
            // toolStripMoves
            // 
            this.toolStripMoves.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStripMoves.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolMoveLabel,
            this.toolMoveAdd,
            this.toolMoveEdit,
            this.toolMoveDelete,
            this.toolMoveFilterReset,
            this.toolMoveFilter,
            this.toolMoveFilterLabel});
            this.toolStripMoves.Location = new System.Drawing.Point(0, 0);
            this.toolStripMoves.Name = "toolStripMoves";
            this.toolStripMoves.Size = new System.Drawing.Size(1021, 25);
            this.toolStripMoves.TabIndex = 12;
            this.toolStripMoves.Text = "toolStrip1";
            // 
            // toolMoveLabel
            // 
            this.toolMoveLabel.AutoSize = false;
            this.toolMoveLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.toolMoveLabel.Name = "toolMoveLabel";
            this.toolMoveLabel.Size = new System.Drawing.Size(170, 22);
            this.toolMoveLabel.Text = "Перемещения";
            this.toolMoveLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // toolMoveAdd
            // 
            this.toolMoveAdd.Image = global::CompStore.Properties.Resources.add;
            this.toolMoveAdd.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolMoveAdd.Name = "toolMoveAdd";
            this.toolMoveAdd.Size = new System.Drawing.Size(79, 22);
            this.toolMoveAdd.Text = "Добавить";
            this.toolMoveAdd.Click += new System.EventHandler(this.MoveAdd);
            // 
            // toolMoveEdit
            // 
            this.toolMoveEdit.Image = global::CompStore.Properties.Resources.edit;
            this.toolMoveEdit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolMoveEdit.Name = "toolMoveEdit";
            this.toolMoveEdit.Size = new System.Drawing.Size(81, 22);
            this.toolMoveEdit.Text = "Изменить";
            this.toolMoveEdit.Click += new System.EventHandler(this.MoveEdit);
            // 
            // toolMoveDelete
            // 
            this.toolMoveDelete.Image = global::CompStore.Properties.Resources.delete;
            this.toolMoveDelete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolMoveDelete.Name = "toolMoveDelete";
            this.toolMoveDelete.Size = new System.Drawing.Size(71, 22);
            this.toolMoveDelete.Text = "Удалить";
            this.toolMoveDelete.Click += new System.EventHandler(this.MoveDelete);
            // 
            // toolMoveFilterReset
            // 
            this.toolMoveFilterReset.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolMoveFilterReset.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolMoveFilterReset.Image = global::CompStore.Properties.Resources.cancel;
            this.toolMoveFilterReset.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolMoveFilterReset.Name = "toolMoveFilterReset";
            this.toolMoveFilterReset.Size = new System.Drawing.Size(23, 22);
            this.toolMoveFilterReset.Click += new System.EventHandler(this.MoveFilterReset);
            // 
            // toolMoveFilter
            // 
            this.toolMoveFilter.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolMoveFilter.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.toolMoveFilter.Name = "toolMoveFilter";
            this.toolMoveFilter.Size = new System.Drawing.Size(300, 25);
            this.toolMoveFilter.TextChanged += new System.EventHandler(this.MovesDraw);
            // 
            // toolMoveFilterLabel
            // 
            this.toolMoveFilterLabel.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolMoveFilterLabel.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolMoveFilterLabel.Image = global::CompStore.Properties.Resources.search;
            this.toolMoveFilterLabel.Name = "toolMoveFilterLabel";
            this.toolMoveFilterLabel.Size = new System.Drawing.Size(16, 22);
            // 
            // listMoves
            // 
            this.listMoves.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listMoves.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnMoveDate,
            this.columnMoveEq,
            this.columnMoveUser,
            this.columnMoveRoom,
            this.columnMoveMOL,
            this.columnMoveCom});
            this.listMoves.ContextMenuStrip = this.contextMenuMoves;
            this.listMoves.FullRowSelect = true;
            this.listMoves.HideSelection = false;
            this.listMoves.Location = new System.Drawing.Point(0, 25);
            this.listMoves.MultiSelect = false;
            this.listMoves.Name = "listMoves";
            this.listMoves.Size = new System.Drawing.Size(1021, 684);
            this.listMoves.TabIndex = 2;
            this.listMoves.UseCompatibleStateImageBehavior = false;
            this.listMoves.View = System.Windows.Forms.View.Details;
            this.listMoves.SelectedIndexChanged += new System.EventHandler(this.MovesSelChange);
            this.listMoves.DoubleClick += new System.EventHandler(this.MoveEdit);
            this.listMoves.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MovesKeyboard);
            // 
            // columnMoveDate
            // 
            this.columnMoveDate.Text = "Дата";
            this.columnMoveDate.Width = 100;
            // 
            // columnMoveEq
            // 
            this.columnMoveEq.Text = "Оборудование";
            this.columnMoveEq.Width = 190;
            // 
            // columnMoveUser
            // 
            this.columnMoveUser.Text = "Сотрудник";
            this.columnMoveUser.Width = 200;
            // 
            // columnMoveRoom
            // 
            this.columnMoveRoom.Text = "Помещение";
            this.columnMoveRoom.Width = 140;
            // 
            // columnMoveMOL
            // 
            this.columnMoveMOL.Text = "М.О.Л.";
            this.columnMoveMOL.Width = 200;
            // 
            // columnMoveCom
            // 
            this.columnMoveCom.Text = "Комментарий";
            this.columnMoveCom.Width = 160;
            // 
            // contextMenuMoves
            // 
            this.contextMenuMoves.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cmMoveAdd,
            this.cmMoveEdit,
            this.cmMoveDelete});
            this.contextMenuMoves.Name = "contextMenuEquipment";
            this.contextMenuMoves.Size = new System.Drawing.Size(149, 70);
            // 
            // cmMoveAdd
            // 
            this.cmMoveAdd.Image = global::CompStore.Properties.Resources.add;
            this.cmMoveAdd.Name = "cmMoveAdd";
            this.cmMoveAdd.ShortcutKeys = System.Windows.Forms.Keys.Insert;
            this.cmMoveAdd.Size = new System.Drawing.Size(148, 22);
            this.cmMoveAdd.Text = "Добавить";
            this.cmMoveAdd.Click += new System.EventHandler(this.MoveAdd);
            // 
            // cmMoveEdit
            // 
            this.cmMoveEdit.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.cmMoveEdit.Image = global::CompStore.Properties.Resources.edit;
            this.cmMoveEdit.Name = "cmMoveEdit";
            this.cmMoveEdit.Size = new System.Drawing.Size(148, 22);
            this.cmMoveEdit.Text = "Изменить";
            this.cmMoveEdit.Click += new System.EventHandler(this.MoveEdit);
            // 
            // cmMoveDelete
            // 
            this.cmMoveDelete.Image = global::CompStore.Properties.Resources.delete;
            this.cmMoveDelete.Name = "cmMoveDelete";
            this.cmMoveDelete.ShortcutKeys = System.Windows.Forms.Keys.Delete;
            this.cmMoveDelete.Size = new System.Drawing.Size(148, 22);
            this.cmMoveDelete.Text = "Удалить";
            this.cmMoveDelete.Click += new System.EventHandler(this.MoveDelete);
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
            this.toolProviderDelete.Image = global::CompStore.Properties.Resources.delete;
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
            this.cmProviderDelete.Image = global::CompStore.Properties.Resources.delete;
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
            this.panelDown.Controls.Add(this.tabControl1);
            this.panelDown.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDown.Location = new System.Drawing.Point(0, 408);
            this.panelDown.Name = "panelDown";
            this.panelDown.Size = new System.Drawing.Size(1021, 301);
            this.panelDown.TabIndex = 21;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1021, 301);
            this.tabControl1.TabIndex = 0;
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
            this.tabPage1.Text = "Перемещения";
            this.tabPage1.UseVisualStyleBackColor = true;
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
            this.toolStripButtonAdd,
            this.toolStripButton1,
            this.toolStripButton2,
            this.toolStripButton3,
            this.toolStripTextBox1,
            this.toolStripLabel2,
            this.toolStripButton4,
            this.toolStripButton5,
            this.toolStripButton6});
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
            this.toolStripLabelName.Text = "Тест";
            this.toolStripLabelName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.Image = global::CompStore.Properties.Resources.edit;
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(81, 22);
            this.toolStripButton1.Text = "Изменить";
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.Image = global::CompStore.Properties.Resources.delete;
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(71, 22);
            this.toolStripButton2.Text = "Удалить";
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton3.Image = global::CompStore.Properties.Resources.cancel;
            this.toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.Size = new System.Drawing.Size(23, 22);
            // 
            // toolStripTextBox1
            // 
            this.toolStripTextBox1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripTextBox1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.toolStripTextBox1.Name = "toolStripTextBox1";
            this.toolStripTextBox1.Size = new System.Drawing.Size(160, 25);
            // 
            // toolStripLabel2
            // 
            this.toolStripLabel2.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripLabel2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripLabel2.Image = global::CompStore.Properties.Resources.search;
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Size = new System.Drawing.Size(16, 22);
            // 
            // toolStripButton4
            // 
            this.toolStripButton4.Image = global::CompStore.Properties.Resources.move;
            this.toolStripButton4.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton4.Name = "toolStripButton4";
            this.toolStripButton4.Size = new System.Drawing.Size(99, 22);
            this.toolStripButton4.Text = "Переместить";
            // 
            // listViewMain
            // 
            this.listViewMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listViewMain.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader14,
            this.columnHeader15,
            this.columnHeader16,
            this.columnHeader17,
            this.columnHeader18,
            this.columnHeader19,
            this.columnHeader20,
            this.columnHeader21,
            this.columnHeader22});
            this.listViewMain.ContextMenuStrip = this.contextMenuEquipment;
            this.listViewMain.FullRowSelect = true;
            this.listViewMain.HideSelection = false;
            this.listViewMain.Location = new System.Drawing.Point(0, 25);
            this.listViewMain.Name = "listViewMain";
            this.listViewMain.Size = new System.Drawing.Size(1021, 375);
            this.listViewMain.TabIndex = 10;
            this.listViewMain.UseCompatibleStateImageBehavior = false;
            this.listViewMain.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader14
            // 
            this.columnHeader14.Text = "Наименование";
            this.columnHeader14.Width = 170;
            // 
            // columnHeader15
            // 
            this.columnHeader15.Text = "Серийный номер";
            this.columnHeader15.Width = 125;
            // 
            // columnHeader16
            // 
            this.columnHeader16.Text = "Инвентарный номер";
            this.columnHeader16.Width = 125;
            // 
            // columnHeader17
            // 
            this.columnHeader17.Text = "Сотрудник";
            this.columnHeader17.Width = 120;
            // 
            // columnHeader18
            // 
            this.columnHeader18.Text = "Помещение";
            this.columnHeader18.Width = 100;
            // 
            // columnHeader19
            // 
            this.columnHeader19.Text = "Выдано";
            this.columnHeader19.Width = 70;
            // 
            // columnHeader20
            // 
            this.columnHeader20.Text = "Куплено";
            this.columnHeader20.Width = 70;
            // 
            // columnHeader21
            // 
            this.columnHeader21.Text = "М.О.Л.";
            // 
            // columnHeader22
            // 
            this.columnHeader22.Text = "Примечание";
            this.columnHeader22.Width = 150;
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
            // 
            // toolStripButtonAdd
            // 
            this.toolStripButtonAdd.Image = global::CompStore.Properties.Resources.add;
            this.toolStripButtonAdd.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonAdd.Name = "toolStripButtonAdd";
            this.toolStripButtonAdd.Size = new System.Drawing.Size(79, 22);
            this.toolStripButtonAdd.Text = "Добавить";
            // 
            // toolStripButton5
            // 
            this.toolStripButton5.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton5.Image")));
            this.toolStripButton5.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton5.Name = "toolStripButton5";
            this.toolStripButton5.Size = new System.Drawing.Size(68, 22);
            this.toolStripButton5.Text = "Ремонт";
            // 
            // toolStripButton6
            // 
            this.toolStripButton6.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton6.Image")));
            this.toolStripButton6.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton6.Name = "toolStripButton6";
            this.toolStripButton6.Size = new System.Drawing.Size(78, 22);
            this.toolStripButton6.Text = "Заправка";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 761);
            this.Controls.Add(this.panelList);
            this.Controls.Add(this.panelEquipments);
            this.Controls.Add(this.panelMoves);
            this.Controls.Add(this.panelUsers);
            this.Controls.Add(this.panelProviders);
            this.Controls.Add(this.panelEqTypes);
            this.Controls.Add(this.panelBuildings);
            this.Controls.Add(this.panelFilials);
            this.Controls.Add(this.panelBrands);
            this.Controls.Add(this.panelRooms);
            this.Controls.Add(this.panelDeps);
            this.Controls.Add(this.panelModels);
            this.Controls.Add(this.panelPosts);
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
            this.panelEquipments.ResumeLayout(false);
            this.panelEqDown.ResumeLayout(false);
            this.tabEquipments.ResumeLayout(false);
            this.tabEqMoves.ResumeLayout(false);
            this.panelEqUp.ResumeLayout(false);
            this.panelEqUp.PerformLayout();
            this.toolStripEquipments.ResumeLayout(false);
            this.toolStripEquipments.PerformLayout();
            this.contextMenuEquipment.ResumeLayout(false);
            this.panelFilials.ResumeLayout(false);
            this.panelFilials.PerformLayout();
            this.toolStripFilials.ResumeLayout(false);
            this.toolStripFilials.PerformLayout();
            this.contextMenuFilials.ResumeLayout(false);
            this.panelRooms.ResumeLayout(false);
            this.panelRooms.PerformLayout();
            this.toolStripRooms.ResumeLayout(false);
            this.toolStripRooms.PerformLayout();
            this.contextMenuRooms.ResumeLayout(false);
            this.panelPosts.ResumeLayout(false);
            this.panelPosts.PerformLayout();
            this.toolStripPosts.ResumeLayout(false);
            this.toolStripPosts.PerformLayout();
            this.contextMenuPosts.ResumeLayout(false);
            this.panelBuildings.ResumeLayout(false);
            this.panelBuildings.PerformLayout();
            this.toolStripBuildings.ResumeLayout(false);
            this.toolStripBuildings.PerformLayout();
            this.contextMenuBuildings.ResumeLayout(false);
            this.panelDeps.ResumeLayout(false);
            this.panelDeps.PerformLayout();
            this.toolStripDeps.ResumeLayout(false);
            this.toolStripDeps.PerformLayout();
            this.contextMenuDeps.ResumeLayout(false);
            this.panelUsers.ResumeLayout(false);
            this.panelUsDown.ResumeLayout(false);
            this.tabUsers.ResumeLayout(false);
            this.tabUsEquipments.ResumeLayout(false);
            this.panelUsUp.ResumeLayout(false);
            this.panelUsUp.PerformLayout();
            this.contextMenuUsers.ResumeLayout(false);
            this.toolStripUsers.ResumeLayout(false);
            this.toolStripUsers.PerformLayout();
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
            this.panelMoves.ResumeLayout(false);
            this.panelMoves.PerformLayout();
            this.toolStripMoves.ResumeLayout(false);
            this.toolStripMoves.PerformLayout();
            this.contextMenuMoves.ResumeLayout(false);
            this.panelProviders.ResumeLayout(false);
            this.panelProviders.PerformLayout();
            this.toolStripProviders.ResumeLayout(false);
            this.toolStripProviders.PerformLayout();
            this.contextMenuProviders.ResumeLayout(false);
            this.panelList.ResumeLayout(false);
            this.panelDown.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.panelUp.ResumeLayout(false);
            this.panelUp.PerformLayout();
            this.toolStrip.ResumeLayout(false);
            this.toolStrip.PerformLayout();
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
        private System.Windows.Forms.Panel panelEquipments;
        private System.Windows.Forms.Panel panelFilials;
        private System.Windows.Forms.ListView listFilials;
        private System.Windows.Forms.ColumnHeader colFilName;
        private System.Windows.Forms.ColumnHeader colFilAdress;
        private System.Windows.Forms.ColumnHeader colFilCom;
        private System.Windows.Forms.ToolStripMenuItem menuInitDB;
        private System.Windows.Forms.Panel panelRooms;
        private System.Windows.Forms.ListView listRooms;
        private System.Windows.Forms.ColumnHeader columnRoomFilial;
        private System.Windows.Forms.ColumnHeader columnRoomName;
        private System.Windows.Forms.ColumnHeader columnRoomCom;
        private System.Windows.Forms.Panel panelPosts;
        private System.Windows.Forms.ListView listPosts;
        private System.Windows.Forms.ColumnHeader columnPostName;
        private System.Windows.Forms.Panel panelBuildings;
        private System.Windows.Forms.ListView listBuildings;
        private System.Windows.Forms.ColumnHeader columnBuildingFilial;
        private System.Windows.Forms.ColumnHeader columnBuildingName;
        private System.Windows.Forms.ColumnHeader columnBuildingComment;
        private System.Windows.Forms.Panel panelDeps;
        private System.Windows.Forms.ListView listDeps;
        private System.Windows.Forms.ColumnHeader columnDepName;
        private System.Windows.Forms.ColumnHeader columnDepComment;
        private System.Windows.Forms.ColumnHeader columnRoomBuilding;
        private System.Windows.Forms.Panel panelUsers;
        private System.Windows.Forms.ListView listUsers;
        private System.Windows.Forms.ColumnHeader columnUserName;
        private System.Windows.Forms.ColumnHeader columnUserPost;
        private System.Windows.Forms.ColumnHeader columnUserDep;
        private System.Windows.Forms.ColumnHeader columnUserPlace;
        private System.Windows.Forms.ColumnHeader columnUserCom;
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
        private System.Windows.Forms.ListView listEquipments;
        private System.Windows.Forms.ColumnHeader columnEqName;
        private System.Windows.Forms.ColumnHeader columnEqSN;
        private System.Windows.Forms.ColumnHeader columnEqIN;
        private System.Windows.Forms.ColumnHeader columnEqComment;
        private System.Windows.Forms.ColumnHeader columnEqUser;
        private System.Windows.Forms.ColumnHeader columnEqPlace;
        private System.Windows.Forms.ColumnHeader columnEqBuyDate;
        private System.Windows.Forms.Panel panelMoves;
        private System.Windows.Forms.ListView listMoves;
        private System.Windows.Forms.ColumnHeader columnMoveDate;
        private System.Windows.Forms.ColumnHeader columnMoveEq;
        private System.Windows.Forms.ColumnHeader columnMoveUser;
        private System.Windows.Forms.ColumnHeader columnMoveRoom;
        private System.Windows.Forms.ColumnHeader columnMoveMOL;
        private System.Windows.Forms.ColumnHeader columnIssDate;
        private System.Windows.Forms.Panel panelEqUp;
        private System.Windows.Forms.Panel panelEqDown;
        private System.Windows.Forms.Splitter splitterEq;
        private System.Windows.Forms.TabControl tabEquipments;
        private System.Windows.Forms.TabPage tabEqMoves;
        private System.Windows.Forms.ListView listEqMoves;
        private System.Windows.Forms.ColumnHeader columnEMDate;
        private System.Windows.Forms.ColumnHeader columnEMUser;
        private System.Windows.Forms.ColumnHeader columnEMRoom;
        private System.Windows.Forms.ColumnHeader columnEMComment;
        private System.Windows.Forms.ColumnHeader columnEMEquipment;
        private System.Windows.Forms.ToolStrip toolStripPosts;
        private System.Windows.Forms.ToolStripLabel toolPostLabel;
        private System.Windows.Forms.ToolStripButton toolPostAdd;
        private System.Windows.Forms.ToolStripButton toolPostEdit;
        private System.Windows.Forms.ToolStripButton toolPostDelete;
        private System.Windows.Forms.ToolStripLabel toolPostFilterLabel;
        private System.Windows.Forms.ToolStripTextBox toolPostFilter;
        private System.Windows.Forms.ToolStripButton toolPostFilterReset;
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
        private System.Windows.Forms.ToolStrip toolStripDeps;
        private System.Windows.Forms.ToolStripLabel toolDepLabel;
        private System.Windows.Forms.ToolStripButton toolDepAdd;
        private System.Windows.Forms.ToolStripButton toolDepEdit;
        private System.Windows.Forms.ToolStripButton toolDepDelete;
        private System.Windows.Forms.ToolStripButton toolDepFilterReset;
        private System.Windows.Forms.ToolStripTextBox toolDepFilter;
        private System.Windows.Forms.ToolStripLabel toolDepFilterLabel;
        private System.Windows.Forms.ToolStrip toolStripMoves;
        private System.Windows.Forms.ToolStripLabel toolMoveLabel;
        private System.Windows.Forms.ToolStripButton toolMoveAdd;
        private System.Windows.Forms.ToolStripButton toolMoveEdit;
        private System.Windows.Forms.ToolStripButton toolMoveDelete;
        private System.Windows.Forms.ToolStripButton toolMoveFilterReset;
        private System.Windows.Forms.ToolStripTextBox toolMoveFilter;
        private System.Windows.Forms.ToolStripLabel toolMoveFilterLabel;
        private System.Windows.Forms.ToolStrip toolStripFilials;
        private System.Windows.Forms.ToolStripLabel toolFilialLabel;
        private System.Windows.Forms.ToolStripButton toolFilialAdd;
        private System.Windows.Forms.ToolStripButton toolFilialEdit;
        private System.Windows.Forms.ToolStripButton toolFilialDelete;
        private System.Windows.Forms.ToolStripButton toolFilialFilterReset;
        private System.Windows.Forms.ToolStripTextBox toolFilialFilter;
        private System.Windows.Forms.ToolStripLabel toolFilialFilterLabel;
        private System.Windows.Forms.ToolStrip toolStripEquipments;
        private System.Windows.Forms.ToolStripLabel toolEqLabel;
        private System.Windows.Forms.ToolStripButton toolEqEdit;
        private System.Windows.Forms.ToolStripButton toolEqDelete;
        private System.Windows.Forms.ToolStripButton toolEqFilterReset;
        private System.Windows.Forms.ToolStripTextBox toolEqFilter;
        private System.Windows.Forms.ToolStripLabel toolEqFilterLabel;
        private System.Windows.Forms.ToolStripButton toolEqMove;
        private System.Windows.Forms.ToolStrip toolStripUsers;
        private System.Windows.Forms.ToolStripLabel toolUserLabel;
        private System.Windows.Forms.ToolStripButton toolUserAdd;
        private System.Windows.Forms.ToolStripButton toolUserEdit;
        private System.Windows.Forms.ToolStripButton toolUserDelete;
        private System.Windows.Forms.ToolStripButton toolUserFilterReset;
        private System.Windows.Forms.ToolStripTextBox toolUserFilter;
        private System.Windows.Forms.ToolStripLabel toolUserFilterLabel;
        private System.Windows.Forms.ToolStrip toolStripBuildings;
        private System.Windows.Forms.ToolStripLabel toolBuildingLabel;
        private System.Windows.Forms.ToolStripButton toolBuildingAdd;
        private System.Windows.Forms.ToolStripButton toolBuildingEdit;
        private System.Windows.Forms.ToolStripButton toolBuildingDelete;
        private System.Windows.Forms.ToolStripButton toolBuildingFilterReset;
        private System.Windows.Forms.ToolStripTextBox toolBuildingFilter;
        private System.Windows.Forms.ToolStripLabel toolBuildingFilterLabel;
        private System.Windows.Forms.ToolStrip toolStripRooms;
        private System.Windows.Forms.ToolStripLabel toolRoomLabel;
        private System.Windows.Forms.ToolStripButton toolRoomAdd;
        private System.Windows.Forms.ToolStripButton toolRoomEdit;
        private System.Windows.Forms.ToolStripButton toolRoomDelete;
        private System.Windows.Forms.ToolStripButton toolRoomFilterReset;
        private System.Windows.Forms.ToolStripTextBox toolRoomFilter;
        private System.Windows.Forms.ToolStripLabel toolRoomFilterLabel;
        private System.Windows.Forms.ToolStrip toolStripBrands;
        private System.Windows.Forms.ToolStripLabel toolBrandLabel;
        private System.Windows.Forms.ToolStripButton toolBrandAdd;
        private System.Windows.Forms.ToolStripButton toolBrandEdit;
        private System.Windows.Forms.ToolStripButton toolBrandDelete;
        private System.Windows.Forms.ToolStripButton toolBrandFilterReset;
        private System.Windows.Forms.ToolStripTextBox toolBrandFilter;
        private System.Windows.Forms.ToolStripLabel toolBrandFilterLabel;
        private System.Windows.Forms.ContextMenuStrip contextMenuEquipment;
        private System.Windows.Forms.ToolStripMenuItem cmEqAdd;
        private System.Windows.Forms.ToolStripMenuItem cmEqEdit;
        private System.Windows.Forms.ToolStripMenuItem cmEqDelete;
        private System.Windows.Forms.ToolStripMenuItem cmEqMove;
        private System.Windows.Forms.ContextMenuStrip contextMenuFilials;
        private System.Windows.Forms.ToolStripMenuItem cmFilialAdd;
        private System.Windows.Forms.ToolStripMenuItem cmFilialEdit;
        private System.Windows.Forms.ToolStripMenuItem cmFilialDelete;
        private System.Windows.Forms.ContextMenuStrip contextMenuBuildings;
        private System.Windows.Forms.ToolStripMenuItem cmBuildingAdd;
        private System.Windows.Forms.ToolStripMenuItem cmBuildingEdit;
        private System.Windows.Forms.ToolStripMenuItem cmBuildingDelete;
        private System.Windows.Forms.ContextMenuStrip contextMenuRooms;
        private System.Windows.Forms.ToolStripMenuItem cmRoomAdd;
        private System.Windows.Forms.ToolStripMenuItem cmRoomEdit;
        private System.Windows.Forms.ToolStripMenuItem cmRoomDelete;
        private System.Windows.Forms.ContextMenuStrip contextMenuDeps;
        private System.Windows.Forms.ToolStripMenuItem cmDepAdd;
        private System.Windows.Forms.ToolStripMenuItem cmDepEdit;
        private System.Windows.Forms.ToolStripMenuItem cmDepDelete;
        private System.Windows.Forms.ContextMenuStrip contextMenuPosts;
        private System.Windows.Forms.ToolStripMenuItem cmPostAdd;
        private System.Windows.Forms.ToolStripMenuItem cmPostEdit;
        private System.Windows.Forms.ToolStripMenuItem cmPostDelete;
        private System.Windows.Forms.ContextMenuStrip contextMenuUsers;
        private System.Windows.Forms.ToolStripMenuItem cmUserAdd;
        private System.Windows.Forms.ToolStripMenuItem cmUserEdit;
        private System.Windows.Forms.ToolStripMenuItem cmUserDelete;
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
        private System.Windows.Forms.ContextMenuStrip contextMenuMoves;
        private System.Windows.Forms.ToolStripMenuItem cmMoveAdd;
        private System.Windows.Forms.ToolStripMenuItem cmMoveEdit;
        private System.Windows.Forms.ToolStripMenuItem cmMoveDelete;
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
        private System.Windows.Forms.ToolStripSplitButton toolEqAdd;
        private System.Windows.Forms.ToolStripMenuItem toolEqCopy;
        private System.Windows.Forms.ToolStripMenuItem cmEqCopy;
        private System.Windows.Forms.Panel panelUsDown;
        private System.Windows.Forms.Splitter splitterUsers;
        private System.Windows.Forms.Panel panelUsUp;
        private System.Windows.Forms.TabControl tabUsers;
        private System.Windows.Forms.TabPage tabUsEquipments;
        private System.Windows.Forms.ListView listUsEquipment;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ToolStripStatusLabel statusCount;
        private System.Windows.Forms.ToolStripMenuItem menuReports;
        private System.Windows.Forms.ToolStripMenuItem menuUserCard;
        private System.Windows.Forms.ToolStripSeparator menuSep1;
        private System.Windows.Forms.ToolStripMenuItem menuPrintPreview;
        private System.Windows.Forms.ColumnHeader columnMoveCom;
        private System.Windows.Forms.ColumnHeader columnEqMOL;
        private System.Windows.Forms.Panel panelList;
        private System.Windows.Forms.Panel panelDown;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.ListView listViewAdd1;
        private System.Windows.Forms.Splitter splitterH;
        private System.Windows.Forms.Panel panelUp;
        private System.Windows.Forms.ToolStrip toolStrip;
        private System.Windows.Forms.ToolStripLabel toolStripLabelName;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private System.Windows.Forms.ToolStripButton toolStripButton4;
        private System.Windows.Forms.ListView listViewMain;
        private System.Windows.Forms.ColumnHeader columnHeader14;
        private System.Windows.Forms.ColumnHeader columnHeader15;
        private System.Windows.Forms.ColumnHeader columnHeader16;
        private System.Windows.Forms.ColumnHeader columnHeader17;
        private System.Windows.Forms.ColumnHeader columnHeader18;
        private System.Windows.Forms.ColumnHeader columnHeader19;
        private System.Windows.Forms.ColumnHeader columnHeader20;
        private System.Windows.Forms.ColumnHeader columnHeader21;
        private System.Windows.Forms.ColumnHeader columnHeader22;
        private System.Windows.Forms.ListView listViewAdd3;
        private System.Windows.Forms.ListView listViewAdd2;
        private System.Windows.Forms.ToolStripButton toolStripButtonAdd;
        private System.Windows.Forms.ToolStripButton toolStripButton5;
        private System.Windows.Forms.ToolStripButton toolStripButton6;
    }
}

