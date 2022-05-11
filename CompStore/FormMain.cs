using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace CompStore
{
    public partial class FormMain : Form
    {
        List<Record> records;   //Записи выбранной вкладки (абстрактный класс)
        List<Record> equipments;
        List<Record> moves;
        string curType;         //Текущий тип элемента
        string curName;         //Текущий тип элемента (на человеческом)
        string[] tabs;          //Здесь храним имена вкладок

        //Далее должно быть изничтожено:
        List<Provider> providers;

        public FormMain()
        {
            InitializeComponent();
            treeMenu.ExpandAll();
            menuPrintPreview.Checked = Properties.Settings.Default.PrintPreview;
            //Отладочное: выбираем вкладку по умолчанию, потом это будет, например, последняя открытая
            treeMenu.SelectedNode = treeMenu.Nodes.Find("nodeEquipment", true)[0];
        }

        private void TabChange(object sender, TreeViewEventArgs e)
        {
            
            panelList.Visible = true;   //Потом она останется одна и эта строка будет не нужна (ну и по умолчанию визибл ей надо будет сделать тру)
            if (treeMenu.SelectedNode.Name == "nodeFilials")
                PreparePage("filials", "Филиалы");
            if (treeMenu.SelectedNode.Name == "nodeBuildings")
                PreparePage("buildings", "Здания");
            if (treeMenu.SelectedNode.Name == "nodeRooms")
                PreparePage("rooms", "Помещения");
            if (treeMenu.SelectedNode.Name == "nodeDeps")
                PreparePage("deps", "Подразделения");
            if (treeMenu.SelectedNode.Name == "nodePosts")
                PreparePage("posts", "Должности");
            if (treeMenu.SelectedNode.Name == "nodeUsers")
            {
                PreparePage("users", "Сотрудники", "Оборудование");
                PrepareListView(listViewAdd1, "equipments");
            }
            if (treeMenu.SelectedNode.Name == "nodeEquipment")
            {
                PreparePage("equipments", "Оборудование", "Перемещения", "Ремонты", "Заправки");
                PrepareListView(listViewAdd1, "moves");
            }
            if (treeMenu.SelectedNode.Name == "nodeMoves")
                PreparePage("moves", "Перемещения");
            if (treeMenu.SelectedNode.Name == "nodeEqType")
                PreparePage("eqtypes", "Типы оборудования");
            if (treeMenu.SelectedNode.Name == "nodeVendors")
                PreparePage("vendors", "Типы оборудования");
            if (treeMenu.SelectedNode.Name == "nodeModels")
                PreparePage("models", "Модели");
            if (treeMenu.SelectedNode.Name == "nodeProviders")
                PreparePage("providers", "Поставщики");


            PrepareListView(listViewMain, curType);
            ListViewRefresh();
        }
        void PreparePage(string type, string name, params string[] tabs)
        {
            curType = type;
            curName = name;
            this.tabs = tabs;
            toolStripLabelName.Text = name;
            if (tabs.Length==0)
            {
                panelDown.Visible = false;
                splitterH.Visible = false;
                panelUp.Dock = DockStyle.Fill;
            }
            else
            {
                panelUp.Dock = DockStyle.Top;
                panelDown.Visible = true;
                splitterH.Visible = true;
                tabControl.TabPages.Clear();
                foreach(string t in tabs)
                tabControl.TabPages.Add(t);
                treeMenu.Focus();
            }
            int i = 0;
            if (tabs.Length > 0) listViewAdd1.Parent = tabControl.TabPages[i++];
            if (tabs.Length > 1) listViewAdd2.Parent = tabControl.TabPages[i++];
            if (tabs.Length > 2) listViewAdd3.Parent = tabControl.TabPages[i++];
            tCopy.Visible = cmCopy.Visible = type == "equipments";
            tMove.Visible = type == "equipments";
            tFix.Visible = type == "equipments";
            tRefill.Visible = type == "equipments";
        }
        
        void PrepareListView(ListView list, string type)
        {
            list.Clear();
            if (type == "filials")
            {
                list.Columns.Add("Наименование", 200);
                list.Columns.Add("Адрес", 200);
                list.Columns.Add("Примечание", 200);
            }
            if (type == "buildings")
            {
                list.Columns.Add("Филиал", 200);
                list.Columns.Add("Наименование", 200);
                list.Columns.Add("Примечание", 200);
            }
            if (type == "rooms")
            {
                list.Columns.Add("Филиал", 160);
                list.Columns.Add("Здание", 160);
                list.Columns.Add("Название", 160);
                list.Columns.Add("Примечание", 160);
            }
            if (type == "deps")
            {
                list.Columns.Add("Наименование", 200);
                list.Columns.Add("Примечание", 200);
            }
            if (type == "posts")
            {
                list.Columns.Add("Наименование", 200);
            }
            if (type == "users")
            {
                list.Columns.Add("Фамилия Имя Отчество", 200);
                list.Columns.Add("Подразделение", 160);
                list.Columns.Add("Должность", 160);
                list.Columns.Add("Расположение", 280);
                list.Columns.Add("Примечание", 140);
            }
            if (type == "equipments")
            {
                list.Columns.Add("Оборудование", 200);
                list.Columns.Add("Серийный номер", 160);
                list.Columns.Add("Инвентарный номер", 160);
                list.Columns.Add("Сотрудник", 100);
                list.Columns.Add("Помещение", 100);
                list.Columns.Add("Mac", 50);
                list.Columns.Add("IP", 50);
                list.Columns.Add("Выдано", 66);
                list.Columns.Add("Куплено", 66);
                list.Columns.Add("Списано", 66);
                list.Columns.Add("М.О.Л.", 100);
                list.Columns.Add("Примечание", 100);
            }
            if (type == "moves")
            {
                list.Columns.Add("Дата", 66);
                list.Columns.Add("Оборудование", 200);
                list.Columns.Add("Ответственный", 200);
                list.Columns.Add("Помещение", 100);
                list.Columns.Add("М.О.Л.", 100);
                list.Columns.Add("Примечание", 100);
            }
            if (type == "eqtypes")
            {
                list.Columns.Add("Наименование", 200);
            }
            if (type == "vendors")
            {
                list.Columns.Add("Наименование", 200);
                list.Columns.Add("Примечание", 400);
            }
            if (type == "models")
            {
                list.Columns.Add("Тип оборудования", 200);
                list.Columns.Add("Производитель", 200);
                list.Columns.Add("Наименование", 200);
                list.Columns.Add("Примечание", 200);
            }
            if (type == "providers")
            {
                list.Columns.Add("Наименование", 200);
                list.Columns.Add("Адрес", 200);
                list.Columns.Add("Телефон", 200);
                list.Columns.Add("Контактное лицо", 200);
            }
        }
        #region Главное меню
        private void инициализацияToolStripMenuItem_Click(object sender, EventArgs e) { DB.Init(); }
        
        private void Exit(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void UserCard(object sender, EventArgs e)
        {
            /*if (listUsers.SelectedItems.Count == 0) return;
            List<User> users = new List<User>();
            foreach (ListViewItem u in listUsers.SelectedItems)
                users.Add((User)u.Tag);
            Reports.UserCard(Properties.Settings.Default.PrintPreview, users, equipments);*/
        }

        private void CheckPrintPreview(object sender, EventArgs e)
        {
            Properties.Settings.Default.PrintPreview ^= true;
            Properties.Settings.Default.Save();
            menuPrintPreview.Checked = Properties.Settings.Default.PrintPreview;
        }

        private void About(object sender, EventArgs e)
        {
            MessageBox.Show("CompStore\nВерсия: 0.1 (01.07.2021)\nАвтор: Сергей Гордеев", "О программе");
        }
        #endregion

        #region *** Универсальная форма ***

        void ListViewRefresh()
        {
            records = DB.Load(curType);
            if (curType == "users") equipments = DB.Load("equipments");
            if (curType == "equipments") moves = DB.Load("moves");
            ListViewDraw(null, null);
        }

        private void ListViewDraw(object sender, EventArgs e)
        {
            listViewMain.BeginUpdate();
            listViewMain.Items.Clear();
            foreach (Record rec in records)
                if (rec.Contains(tFilter.Text))
                    listViewMain.Items.Add(rec.ToListView());
            listViewMain.EndUpdate();
            StatusCount(records.Count, listViewMain);
            ItemSelChange(null, null);
        }

        private void ItemSelChange(object sender, EventArgs e)
        {
            int sel = listViewMain.SelectedIndices.Count;
            tCopy.Enabled = cmCopy.Enabled = sel == 1;
            tEdit.Enabled = cmEdit.Enabled = sel == 1;
            tDelete.Enabled = cmDelete.Enabled = sel == 1;
            tMove.Enabled = cmMove.Enabled = sel > 0;
            tFix.Enabled = sel == 1;    //Как будет в контекстном меню - добавить и его
            tRefill.Enabled = sel == 1;

            //Перерисовка нижней панели
            if (curType == "users")
            {
                listViewAdd1.BeginUpdate();
                listViewAdd1.Items.Clear();
                if (sel== 1)
                    foreach (Equipment eq in equipments)
                        foreach (ListViewItem item in listViewMain.SelectedItems)
                            if (((User)item.Tag).ID == eq.user)
                                listViewAdd1.Items.Add(eq.ToListView());
                listViewAdd1.EndUpdate();
                tabControl.TabPages[0].Text = tabs[0] + ListCount(listViewAdd1);
            }
            if (curType == "equipments")
            {
                listViewAdd1.BeginUpdate();
                listViewAdd1.Items.Clear();
                if (sel == 1)
                    foreach (Move m in moves)
                        foreach (ListViewItem item in listViewMain.SelectedItems)
                            if (((Equipment)item.Tag).ID == m.equipment)
                                listViewAdd1.Items.Add(m.ToListView());
                listViewAdd1.EndUpdate();
                tabControl.TabPages[0].Text = tabs[0] + ListCount(listViewAdd1);
            }
        }

        private void FilterReset(object sender, EventArgs e) { tFilter.Text = ""; }

        private void ItemAdd(object sender, EventArgs e)
        {
            Record item = null;
            if (curType == "filials") item = new Filial();
            if (curType == "buildings") item = new Building();
            if (curType == "rooms") item = new Room();
            if (curType == "deps") item = new Dep();
            if (curType == "posts") item = new Post();
            if (curType == "users") item = new User();
            if (curType == "equipments") item = new Equipment();
            if (curType == "moves") item = new Move();
            if (curType == "eqtypes") item = new EqType();
            if (curType == "vendors") item = new Vendor();
            if (curType == "models") item = new Model();
            if (curType == "providers") item = new Provider();

            Form form = itemForm(item);
            if (form.ShowDialog() == DialogResult.OK)
            {
                DB.Add(curType, item);
                ListViewRefresh();
            }
        }
    

        private void ItemCopy(object sender, EventArgs e)   //Пока работает только для оборудования
        {
            Record item = null;
            if (listViewMain.SelectedIndices.Count != 1) return;
            Equipment equipmentOr = (Equipment)listViewMain.SelectedItems[0].Tag;
            Equipment equipment = new Equipment();
            equipment.model = equipmentOr.model;
            equipment.iNv = equipmentOr.iNv;
            equipment.buy = equipmentOr.buy;
            equipment.buyDate = equipmentOr.buyDate;
            equipment.price = equipmentOr.price;
            equipment.provider = equipmentOr.provider;
            equipment.comment = equipmentOr.comment;
            FormEquipment form = new FormEquipment(equipment);
            if (form.ShowDialog() == DialogResult.OK)
            {
                DB.Add(curType, item);
                ListViewRefresh();
            }
        }

        private void ItemEdit(object sender, EventArgs e)
        {
            Record item = null;
            if (listViewMain.SelectedIndices.Count == 0) return;
            item = (Record)listViewMain.SelectedItems[0].Tag;
            Form form = itemForm(item);
            if (form.ShowDialog() == DialogResult.OK)
            {
                DB.Update(curType, item);
                ListViewRefresh();
            }
        }

        private void ItemDelete(object sender, EventArgs e)
        {
            if (listViewMain.SelectedIndices.Count == 0) return;
            Record rec = (Record)listViewMain.SelectedItems[0].Tag;
            if (DeleteRecord(curName, rec.nameText))
            {
                DB.Delete(curType, rec);
                ListViewRefresh();
            }
        }

        private void Keyboard(object sender, KeyEventArgs e)
        {
            if (listViewMain.SelectedIndices.Count == 0) return;
            if (e.KeyCode == Keys.Enter) ItemEdit(null, null);
            if (e.KeyCode == Keys.Delete) ItemDelete(null, null);
        }

        private void Move(object sender, EventArgs e)
        {
            if (listViewMain.SelectedIndices.Count == 0) return;
            bool pack = listViewMain.SelectedIndices.Count > 1;
            Move move = new Move();
            if (!pack) move.equipment = ((Equipment)listViewMain.SelectedItems[0].Tag).ID;

            FormMove form = new FormMove(move, pack);
            if (form.ShowDialog() == DialogResult.OK)
            {
                foreach (ListViewItem item in listViewMain.SelectedItems)
                    DB.Add("moves", move.newMove(((Equipment)item.Tag).ID));
                ListViewRefresh();
            }
        }

        private void MoveEditFromAdd(object sender, EventArgs e)
        {
            string t = "";
            Record subitem = null;
            Form form = null;
            if (curType == "equipments" && tabControl.SelectedIndex == 0)
            {
                if (listViewAdd1.SelectedIndices.Count == 0) return;
                subitem = (Move)listViewAdd1.SelectedItems[0].Tag;
                form = new FormMove((Move)subitem, false);
                t = "moves";
            }
            if (t != "" && form.ShowDialog() == DialogResult.OK)
            {
                DB.Update("moves", subitem);
                ListViewRefresh();
            }
        }

        Form itemForm(Record item)
        {
            if (curType == "filials") return new FormFilial((Filial)item);
            if (curType == "buildings") return new FormBuilding((Building)item);
            if (curType == "rooms") return new FormRoom((Room)item);
            if (curType == "deps") return new FormDep((Dep)item);
            if (curType == "posts") return new FormPost((Post)item);
            if (curType == "users") return new FormUser((User)item);
            if (curType == "equipments") return new FormEquipment((Equipment)item);
            if (curType == "moves") return new FormMove((Move)item, false);
            if (curType == "eqtypes") return new FormEqType((EqType)item);
            if (curType == "vendors") return new FormVendor((Vendor)item);
            if (curType == "models") return new FormModel((Model)item);
            if (curType == "providers") return new FormProvider((Provider)item);
            return null;
        }

        #endregion

        // Вопрос об удалении записи в справочнике/журнале
        bool DeleteRecord(string listName, string recordName)
        {
            return MessageBox.Show("Внимание!\nВы уверены что хотите удалить " + listName + "\n\"" + recordName + "\"?",
                "Удаление записи", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK;
        }

        // Строка с подписью числа в скобках для вкладок из листвью.
        string ListCount(ListView list)
        {
            string c = list.Items.Count.ToString();
            return c != "0" ? " (" + c + ")" : "";
        }

        void StatusCount(int all, ListView view)
        {
            int viewed = view.Items.Count;
            statusCount.Text = "Позиций: " + viewed.ToString() + 
                (all != viewed ? " из " + all.ToString() : "");
        }
    }
}
