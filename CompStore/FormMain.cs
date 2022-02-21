using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace CompStore
{
    public partial class FormMain : Form
    {
        string[] tabs;          //Здесь храним имена вкладок
        List<Record> records;   //Записи выбранной вкладки (абстрактный класс)

        //Далее должно быть изничтожено:
        List<Filial> filials;
        List<Building> buildings;
        List<Room> rooms;
        List<Dep> deps;
        List<Post> posts;
        List<User> users;
        List<Brand> brands;
        List<EqType> eqTypes;
        List<Model> models;
        List<Equipment> equipments;
        List<Move> moves;
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
            panelFilials.Visible = treeMenu.SelectedNode.Name == "nodeFilials";
            panelBuildings.Visible = treeMenu.SelectedNode.Name == "nodeBuildings";
            panelRooms.Visible = treeMenu.SelectedNode.Name == "nodeRooms";
            panelDeps.Visible = treeMenu.SelectedNode.Name == "nodeDeps";
            panelPosts.Visible = treeMenu.SelectedNode.Name == "nodePosts";
            panelUsers.Visible = treeMenu.SelectedNode.Name == "nodeUsers";
            //panelEquipments.Visible = treeMenu.SelectedNode.Name == "nodeEquipment";
            panelBrands.Visible = treeMenu.SelectedNode.Name == "nodeBrands";
            panelEqTypes.Visible = treeMenu.SelectedNode.Name == "nodeEqType";
            panelModels.Visible = treeMenu.SelectedNode.Name == "nodeModels";
            panelMoves.Visible = treeMenu.SelectedNode.Name == "nodeMoves";
            panelProviders.Visible = treeMenu.SelectedNode.Name == "nodeProviders";
            //panelList.Visible = treeMenu.SelectedNode.Name == "nodeTest1" |
            //                    treeMenu.SelectedNode.Name == "nodeTest2" |
            //                    treeMenu.SelectedNode.Name == "nodeTest3"; ;
            
            panelList.Visible = true;
            if (treeMenu.SelectedNode.Name == "nodeEquipment")
            {
                PreparePage("Оборудование","Перемещения", "Ремонты", "Заправки");
                PrepareListView(listViewMain, "equipments");
                PrepareListView(listViewAdd1, "moves", 0);
                panelList.Visible = true;
            }
            
            if (treeMenu.SelectedNode.Name == "nodeTest1")
            {
                panelDown.Visible = false;
                splitterH.Visible = false;
                panelUp.Dock = DockStyle.Fill;
            }
            if (treeMenu.SelectedNode.Name == "nodeTest2")
            {
                panelUp.Dock = DockStyle.Top;
                panelDown.Visible = true;
                splitterH.Visible = true;
                tabControl1.TabPages.Clear();
                tabControl1.TabPages.Add("Оборудование");
                treeMenu.Focus();

                //CreateListWiew(listViewAdd1, "equipments", 0);
            }
            if (treeMenu.SelectedNode.Name == "nodeTest3")
            {
                panelUp.Dock = DockStyle.Top;
                panelDown.Visible = true;
                splitterH.Visible = true;
                tabControl1.TabPages.Clear();
                tabControl1.TabPages.Add("Перемещения");
                tabControl1.TabPages.Add("Ремонты");
                tabControl1.TabPages.Add("Заправки");
                treeMenu.Focus();

                //listViewMain.Clear();
                
            }
            ListViewRefresh();
        }
        void PreparePage(string name, params string[] tabs)
        {
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
                tabControl1.TabPages.Clear();
                foreach(string t in tabs)
                tabControl1.TabPages.Add(t);
                treeMenu.Focus();
            }
        }

        void PrepareListView(ListView list, string type, int tab = -1)
        {
            list.Clear();
            if (type == "equipments")
            {
                list.Columns.Add("Оборудование", 200);
                list.Columns.Add("Серийный номер", 160);
                list.Columns.Add("Инвентарный номер", 160);
                list.Columns.Add("Сотрудник", 100);
                list.Columns.Add("Помещение", 100);
                list.Columns.Add("Mac", 50);
                list.Columns.Add("IP", 50);
                list.Columns.Add("Выдано", 100);
                list.Columns.Add("Куплено", 100);
                list.Columns.Add("Списано", 100);
                list.Columns.Add("М.О.Л.", 100);
                list.Columns.Add("Примечание", 100);
            }
            if (type == "moves")
            {
                list.Columns.Add("Дата", 50);
                list.Columns.Add("Оборудование", 160);
                list.Columns.Add("Ответственный", 160);
                list.Columns.Add("Помещение", 100);
                list.Columns.Add("М.О.Л.", 100);
                list.Columns.Add("Примечание", 100);
            }
            if (tab >= 0) list.Parent = tabControl1.TabPages[tab];
        }
        #region Главное меню
        private void инициализацияToolStripMenuItem_Click(object sender, EventArgs e) { DB.Init(); }
        
        private void Exit(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void UserCard(object sender, EventArgs e)
        {
            if (listUsers.SelectedItems.Count == 0) return;
            List<User> users = new List<User>();
            foreach (ListViewItem u in listUsers.SelectedItems)
                users.Add((User)u.Tag);
            Reports.UserCard(Properties.Settings.Default.PrintPreview, users, equipments);
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

        #region Обоорудование
        /*private void EquipmentsView(object sender, EventArgs e)
        {
            if (panelEquipments.Visible) EquipmentsRefresh();
        }*/

        void ListViewRefresh()
        {
            records = DB.Load("equipments");
            //moves = DB.MovesLoad();
            ListViewDraw(null, null);
        }

        private void ListViewDraw(object sender, EventArgs e)
        {
            listViewMain.BeginUpdate();
            listViewMain.Items.Clear();
            foreach (Record rec in records)
                //if (rec.Contains(toolEqFilter.Text))
                listViewMain.Items.Add(rec.ToListView());
            listViewMain.EndUpdate();
            //StatusCount(equipments.Count, listEquipments);
            ItemSelChange(null, null);
        }

        private void ItemSelChange(object sender, EventArgs e)
        {
            int sel = listEquipments.SelectedIndices.Count;
            toolEqCopy.Enabled = sel == 1;
            toolEqEdit.Enabled = sel == 1;
            toolEqDelete.Enabled = sel == 1;
            toolEqMove.Enabled = sel > 0;
            cmEqCopy.Enabled = sel == 1;
            cmEqEdit.Enabled = sel == 1;
            cmEqDelete.Enabled = sel == 1;
            cmEqMove.Enabled = sel > 0;
            //Перерисовка нижней панели
            listEqMoves.BeginUpdate();
            listEqMoves.Items.Clear();
            if (sel == 1)
                foreach (Move m in moves)
                    foreach (ListViewItem item in listEquipments.SelectedItems)
                        if (((Equipment)item.Tag).ID == m.equipment)
                            listEqMoves.Items.Add(m.ToListView());
            listEqMoves.EndUpdate();
            tabEqMoves.Text = "Перемещения" + ListCount(listEqMoves);
        }

        private void FilterReset(object sender, EventArgs e) { toolEqFilter.Text = ""; }

        private void ItemAdd(object sender, EventArgs e)
        {
            Equipment equipment = new Equipment();
            FormEquipment form = new FormEquipment(equipment);
            if (form.ShowDialog() == DialogResult.OK)
            {
                //DB.EquipmentAdd(equipment);
                EquipmentsRefresh();
            }
        }

        private void ItemCopy(object sender, EventArgs e)
        {
            if (listEquipments.SelectedIndices.Count != 1) return;
            Equipment equipmentOr = (Equipment)listEquipments.SelectedItems[0].Tag;
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
                DB.EquipmentAdd(equipment);
                EquipmentsRefresh();
            }
        }

        private void ItemEdit(object sender, EventArgs e)
        {
            if (listEquipments.SelectedIndices.Count == 0) return;
            Equipment equipment = (Equipment)listEquipments.SelectedItems[0].Tag;
            FormEquipment form = new FormEquipment(equipment);
            if (form.ShowDialog() == DialogResult.OK)
            {
                DB.EquipmentUpdate(equipment);
                EquipmentsRefresh();
            }
        }

        private void ItemDelete(object sender, EventArgs e)
        {
            if (listEquipments.SelectedIndices.Count == 0) return;
            Equipment equipment = (Equipment)listEquipments.SelectedItems[0].Tag;
            if (DeleteRecord("оборудование", equipment.nameText))
            {
                DB.EquipmentDelete(equipment);
                EquipmentsRefresh();
            }
        }

        private void Keyboard(object sender, KeyEventArgs e)
        {
            if (listEquipments.SelectedIndices.Count == 0) return;
            if (e.KeyCode == Keys.Enter) EquipmentEdit(null, null);
            if (e.KeyCode == Keys.Delete) EquipmentDelete(null, null);
        }

        /*private void ItemMove(object sender, EventArgs e)
        {
            if (listEquipments.SelectedIndices.Count == 0) return;
            bool pack = listEquipments.SelectedIndices.Count > 1;
            Move move = new Move();
            if (!pack) move.equipment = ((Equipment)listEquipments.SelectedItems[0].Tag).ID;

            FormMove form = new FormMove(move, pack);
            if (form.ShowDialog() == DialogResult.OK)
            {
                foreach (ListViewItem item in listEquipments.SelectedItems)
                    DB.MoveAdd(move.newMove(((Equipment)item.Tag).ID));
                EquipmentsRefresh();
            }
        }*/

        /*private void MoveEditFromEquipment(object sender, EventArgs e)
        {
            if (listEqMoves.SelectedIndices.Count == 0) return;
            Move move = (Move)listEqMoves.SelectedItems[0].Tag;
            FormMove form = new FormMove(move, false);
            if (form.ShowDialog() == DialogResult.OK)
            {
                DB.MoveUpdate(move);
                EquipmentsRefresh();
            }
        }*/
        #endregion

        #region Филиалы
        private void FilialsView(object sender, EventArgs e)
        {
            if (panelFilials.Visible) FilialsRefresh();
        }

        void FilialsRefresh()
        {
            filials = DB.FilialsLoad();
            FilialsDraw(null, null);
        }

        private void FilialsDraw(object sender, EventArgs e)
        {
            listFilials.BeginUpdate();
            listFilials.Items.Clear();
            foreach (Filial filial in filials)
                if (filial.Contains(toolFilialFilter.Text))
                    listFilials.Items.Add(filial.ToListView());
            listFilials.EndUpdate();
            StatusCount(filials.Count, listFilials);
            FilialsSelChange(null, null);
        }
        private void FilialsSelChange(object sender, EventArgs e)
        {
            bool sel = listFilials.SelectedIndices.Count > 0;
            toolFilialEdit.Enabled = sel;
            toolFilialDelete.Enabled = sel;
            cmFilialEdit.Enabled = sel;
            cmFilialDelete.Enabled = sel;
        }
        private void FilialFilterReset(object sender, EventArgs e) { toolFilialFilter.Text = ""; }

        private void FilialAdd(object sender, EventArgs e)
        {
            Filial filial = new Filial();
            FormFilial form = new FormFilial(filial);
            if (form.ShowDialog() == DialogResult.OK)
            {
                DB.FilialAdd(filial);
                FilialsRefresh();
            }
        }

        private void FilialEdit(object sender, EventArgs e)
        {
            if (listFilials.SelectedIndices.Count == 0) return;
            Filial filial = (Filial)listFilials.SelectedItems[0].Tag;
            FormFilial form = new FormFilial(filial);
            if (form.ShowDialog() == DialogResult.OK)
            {
                DB.FilialUpdate(filial);
                FilialsRefresh();
            }
        }

        private void FilialDelete(object sender, EventArgs e)
        {
            if (listFilials.SelectedIndices.Count == 0) return;
            Filial filial = (Filial)listFilials.SelectedItems[0].Tag;
            if (DeleteRecord("филиал", filial.name))
            {
                DB.FilialDelete(filial);
                FilialsRefresh();
            }
        }

        private void FilialsKeyboard(object sender, KeyEventArgs e)
        {
            if (listFilials.SelectedIndices.Count == 0) return;
            if (e.KeyCode == Keys.Enter) FilialEdit(null, null);
        }
        #endregion

        #region Помещения
        private void RoomsView(object sender, EventArgs e)
        {
            if (panelRooms.Visible) RoomsRefresh();
        }

        void RoomsRefresh()
        {
            rooms = DB.RoomsLoad();
            RoomsDraw(null, null);
        }

        private void RoomsDraw(object sender, EventArgs e)
        {
            listRooms.BeginUpdate();
            listRooms.Items.Clear();
            foreach (Room room in rooms)
                if (room.Contains(toolRoomFilter.Text))
                    listRooms.Items.Add(room.ToListView());
            listRooms.EndUpdate();
            StatusCount(rooms.Count, listRooms);
            RoomsSelChange(null, null);
        }
        private void RoomsSelChange(object sender, EventArgs e)
        {
            bool sel = listRooms.SelectedIndices.Count > 0;
            toolRoomEdit.Enabled = sel;
            toolRoomDelete.Enabled = sel;
            cmRoomEdit.Enabled = sel;
            cmRoomDelete.Enabled = sel;
        }
        private void RoomFilterReset(object sender, EventArgs e) { toolRoomFilter.Text = ""; }

        private void RoomAdd(object sender, EventArgs e)
        {
            Room room = new Room();
            FormRoom form = new FormRoom(room);
            if (form.ShowDialog() == DialogResult.OK)
            {
                DB.RoomAdd(room);
                RoomsRefresh();
            }
        }
        private void RoomEdit(object sender, EventArgs e)
        {
            if (listRooms.SelectedIndices.Count == 0) return;
            Room room = (Room)listRooms.SelectedItems[0].Tag;
            FormRoom form = new FormRoom(room);
            if (form.ShowDialog() == DialogResult.OK)
            {
                DB.RoomUpdate(room);
                RoomsRefresh();
            }
        }

        private void RoomDelete(object sender, EventArgs e)
        {
            if (listRooms.SelectedIndices.Count == 0) return;
            Room room = (Room)listRooms.SelectedItems[0].Tag;
            if (DeleteRecord("помещение", room.name))
            {
                DB.RoomDelete(room);
                RoomsRefresh();
            }
        }

        private void RoomsKeyboard(object sender, KeyEventArgs e)
        {
            if (listRooms.SelectedIndices.Count == 0) return;
            if (e.KeyCode == Keys.Enter) RoomEdit(null, null);
        }
        #endregion

        #region Должности
        private void PostsView(object sender, EventArgs e)
        {
            if (panelPosts.Visible) PostsRefresh();
        }

        void PostsRefresh()
        {
            posts = DB.PostsLoad();
            PostsDraw(null, null);
        }

        private void PostsDraw(object sender, EventArgs e)
        {
            listPosts.BeginUpdate();
            listPosts.Items.Clear();
            foreach (Post post in posts)
                if (post.Contains(toolPostFilter.Text))
                    listPosts.Items.Add(post.ToListView());
            listPosts.EndUpdate();
            StatusCount(posts.Count, listPosts);
            PostsSelChange(null, null);
        }
        private void PostsSelChange(object sender, EventArgs e)
        {
            bool sel = listPosts.SelectedIndices.Count > 0;
            toolPostEdit.Enabled = sel;
            toolPostDelete.Enabled = sel;
            cmPostEdit.Enabled = sel;
            cmPostDelete.Enabled = sel;
        }
        private void PostFilterReset(object sender, EventArgs e) { toolPostFilter.Text = ""; }

        private void PostAdd(object sender, EventArgs e)
        {
            Post post = new Post();
            FormPost form = new FormPost(post);
            if (form.ShowDialog() == DialogResult.OK)
            {
                DB.PostAdd(post);
                PostsRefresh();
            }
        }
        private void PostEdit(object sender, EventArgs e)
        {
            if (listPosts.SelectedIndices.Count == 0) return;
            Post post = (Post)listPosts.SelectedItems[0].Tag;
            FormPost form = new FormPost(post);
            if (form.ShowDialog() == DialogResult.OK)
            {
                DB.PostUpdate(post);
                PostsRefresh();
            }
        }

        private void PostDelete(object sender, EventArgs e)
        {
            if (listPosts.SelectedIndices.Count == 0) return;
            Post post = (Post)listPosts.SelectedItems[0].Tag;
            if (DeleteRecord("должность", post.name))
            {
                DB.PostDelete(post);
                PostsRefresh();
            }
        }

        private void PostsKeyboard(object sender, KeyEventArgs e)
        {
            if (listPosts.SelectedIndices.Count == 0) return;
            if (e.KeyCode == Keys.Enter) PostEdit(null, null);
        }
        #endregion

        #region Подразделения
        private void DepsView(object sender, EventArgs e)
        {
            if (panelDeps.Visible) DepsRefresh();
        }

        void DepsRefresh()
        {
            deps = DB.DepsLoad();
            DepsDraw(null, null);
        }

        private void DepsDraw(object sender, EventArgs e)
        {
            listDeps.BeginUpdate();
            listDeps.Items.Clear();
            foreach (Dep dep in deps)
                if (dep.Contains(toolDepFilter.Text))
                    listDeps.Items.Add(dep.ToListView());
            listDeps.EndUpdate();
            StatusCount(deps.Count, listDeps);
            DepsSelChange(null, null);
        }
        private void DepsSelChange(object sender, EventArgs e)
        {
            bool sel = listDeps.SelectedIndices.Count > 0;
            toolDepEdit.Enabled = sel;
            toolDepDelete.Enabled = sel;
            cmDepEdit.Enabled = sel;
            cmDepDelete.Enabled = sel;
        }

        private void DepFilterReset(object sender, EventArgs e) { toolDepFilter.Text = ""; }

        private void DepAdd(object sender, EventArgs e)
        {
            Dep dep = new Dep();
            FormDep form = new FormDep(dep);
            if (form.ShowDialog() == DialogResult.OK)
            {
                DB.DepAdd(dep);
                DepsRefresh();
            }
        }
        private void DepEdit(object sender, EventArgs e)
        {
            if (listDeps.SelectedIndices.Count == 0) return;
            Dep dep = (Dep)listDeps.SelectedItems[0].Tag;
            FormDep form = new FormDep(dep);
            if (form.ShowDialog() == DialogResult.OK)
            {
                DB.DepUpdate(dep);
                DepsRefresh();
            }
        }

        private void DepDelete(object sender, EventArgs e)
        {
            if (listDeps.SelectedIndices.Count == 0) return;
            Dep dep = (Dep)listDeps.SelectedItems[0].Tag;
            if (DeleteRecord("подразделение", dep.name))
            {
                DB.DepDelete(dep);
                DepsRefresh();
            }
        }

        private void DepsKeyboard(object sender, KeyEventArgs e)
        {
            if (listDeps.SelectedIndices.Count == 0) return;
            if (e.KeyCode == Keys.Enter) DepEdit(null, null);
        }
        #endregion

        #region Здания
        private void BuildingsView(object sender, EventArgs e)
        {
            if (panelBuildings.Visible) BuildingsRefresh();
        }

        void BuildingsRefresh()
        {
            buildings = DB.BuildingsLoad();
            BuildingsDraw(null, null);
        }

        private void BuildingsDraw(object sender, EventArgs e)
        {
            listBuildings.BeginUpdate();
            listBuildings.Items.Clear();
            foreach (Building building in buildings)
                if (building.Contains(toolBuildingFilter.Text))
                    listBuildings.Items.Add(building.ToListView());
            listBuildings.EndUpdate();
            StatusCount(buildings.Count, listBuildings);
            BuildingsSelChange(null, null);
        }

        private void BuildingsSelChange(object sender, EventArgs e)
        {
            bool sel = listBuildings.SelectedIndices.Count > 0;
            toolBuildingEdit.Enabled = sel;
            toolBuildingDelete.Enabled = sel;
            cmBuildingEdit.Enabled = sel;
            cmBuildingDelete.Enabled = sel;
        }

        private void BuildingsFilterReset(object sender, EventArgs e) { toolBuildingFilter.Text = ""; }

        private void BuildingAdd(object sender, EventArgs e)
        {
            Building building = new Building();
            FormBuilding form = new FormBuilding(building);
            if (form.ShowDialog() == DialogResult.OK)
            {
                DB.BuildingAdd(building);
                BuildingsRefresh();
            }
        }
        private void BuildingEdit(object sender, EventArgs e)
        {
            if (listBuildings.SelectedIndices.Count == 0) return;
            Building building = (Building)listBuildings.SelectedItems[0].Tag;
            FormBuilding form = new FormBuilding(building);
            if (form.ShowDialog() == DialogResult.OK)
            {
                DB.BuildingUpdate(building);
                BuildingsRefresh();
            }
        }

        private void BuildingDelete(object sender, EventArgs e)
        {
            if (listBuildings.SelectedIndices.Count == 0) return;
            Building building = (Building)listBuildings.SelectedItems[0].Tag;
            if (DeleteRecord("здание", building.name))
            {
                DB.BuildingDelete(building);
                BuildingsRefresh();
            }
        }

        private void BuildingsKeyboard(object sender, KeyEventArgs e)
        {
            if (listBuildings.SelectedIndices.Count == 0) return;
            if (e.KeyCode == Keys.Enter) BuildingEdit(null, null);
        }
        #endregion

        #region Сотрудники
        private void UsersView(object sender, EventArgs e)
        {
            if (panelUsers.Visible) UsersRefresh();
        }

        void UsersRefresh()
        {
            users = DB.UsersLoad();
            equipments = DB.EquipmentsLoad();
            UsersDraw(null, null);
        }

        private void UsersDraw(object sender, EventArgs e)
        {
            listUsers.BeginUpdate();
            listUsers.Items.Clear();
            foreach (User user in users)
                if (user.Contains(toolUserFilter.Text))
                    listUsers.Items.Add(user.ToListView());
            listUsers.EndUpdate();
            StatusCount(users.Count, listUsers);
            UsersSelChange(null, null);
        }
        private void UsersSelChange(object sender, EventArgs e)
        {
            bool sel = listUsers.SelectedIndices.Count > 0;
            menuUserCard.Enabled = sel;
            toolUserEdit.Enabled = sel;
            toolUserDelete.Enabled = sel;
            cmUserEdit.Enabled = sel;
            cmUserDelete.Enabled = sel;
            //Перерисовка нижней панели
            listUsEquipment.BeginUpdate();
            listUsEquipment.Items.Clear();
            if (listUsers.SelectedIndices.Count == 1)
                foreach (Equipment eq in equipments)
                    foreach (ListViewItem item in listUsers.SelectedItems)
                        if (((User)item.Tag).ID == eq.user)
                            listUsEquipment.Items.Add(eq.ToListView());
            listUsEquipment.EndUpdate();
            tabUsEquipments.Text = "Оборудование" + ListCount(listUsEquipment);

        }
        private void UserFilterReset(object sender, EventArgs e) { toolUserFilter.Text = ""; }

        private void UserAdd(object sender, EventArgs e)
        {
            User user = new User();
            FormUser form = new FormUser(user);
            if (form.ShowDialog() == DialogResult.OK)
            {
                DB.UserAdd(user);
                UsersRefresh();
            }
        }
        private void UserEdit(object sender, EventArgs e)
        {
            if (listUsers.SelectedIndices.Count == 0) return;
            User user = (User)listUsers.SelectedItems[0].Tag;
            FormUser form = new FormUser(user);
            if (form.ShowDialog() == DialogResult.OK)
            {
                DB.UserUpdate(user);
                UsersRefresh();
            }
        }

        private void UserDelete(object sender, EventArgs e)
        {
            if (listUsers.SelectedIndices.Count == 0) return;
            User user = (User)listUsers.SelectedItems[0].Tag;
            if (DeleteRecord("сотрудника", user.nameText))
            {
                DB.UserDelete(user);
                UsersRefresh();
            }
        }

        private void UsersKeyboard(object sender, KeyEventArgs e)
        {
            if (listUsers.SelectedIndices.Count == 0) return;
            if (e.KeyCode == Keys.Enter) UserEdit(null, null);
        }
        #endregion

        #region Производители
        private void BrandsView(object sender, EventArgs e)
        {
            if (panelBrands.Visible) BrandsRefresh();
        }

        void BrandsRefresh()
        {
            brands = DB.BrandsLoad();
            BrandsDraw(null, null);
        }

        private void BrandsDraw(object sender, EventArgs e)
        {
            listBrands.BeginUpdate();
            listBrands.Items.Clear();
            foreach (Brand brand in brands)
                if (brand.Contains(toolBrandFilter.Text))
                    listBrands.Items.Add(brand.ToListView());
            listBrands.EndUpdate();
            StatusCount(brands.Count, listBrands);
            BrandsSelChange(null, null);
        }
        private void BrandsSelChange(object sender, EventArgs e)
        {
            bool sel = listBrands.SelectedIndices.Count > 0;
            toolBrandEdit.Enabled = sel;
            toolBrandDelete.Enabled = sel;
            cmBrandEdit.Enabled = sel;
            cmBrandDelete.Enabled = sel;
        }
        private void BrandFilterReset(object sender, EventArgs e) { toolBrandFilter.Text = ""; }

        private void BrandAdd(object sender, EventArgs e)
        {
            Brand brand = new Brand();
            FormBrand form = new FormBrand(brand);
            if (form.ShowDialog() == DialogResult.OK)
            {
                DB.BrandAdd(brand);
                BrandsRefresh();
            }
        }
        private void BrandEdit(object sender, EventArgs e)
        {
            if (listBrands.SelectedIndices.Count == 0) return;
            Brand brand = (Brand)listBrands.SelectedItems[0].Tag;
            FormBrand form = new FormBrand(brand);
            if (form.ShowDialog() == DialogResult.OK)
            {
                DB.BrandUpdate(brand);
                BrandsRefresh();
            }
        }

        private void BrandDelete(object sender, EventArgs e)
        {
            if (listBrands.SelectedIndices.Count == 0) return;
            Brand brand = (Brand)listBrands.SelectedItems[0].Tag;
            if (DeleteRecord("производителя", brand.name))
            {
                DB.BrandDelete(brand);
                BrandsRefresh();
            }
        }

        private void BrandsKeyboard(object sender, KeyEventArgs e)
        {
            if (listBrands.SelectedIndices.Count == 0) return;
            if (e.KeyCode == Keys.Enter) BrandEdit(null, null);
        }
        #endregion

        #region Типы оборудования
        private void EqTypesView(object sender, EventArgs e)
        {
            if (panelEqTypes.Visible) EqTypesRefresh();
        }

        void EqTypesRefresh()
        {
            eqTypes = DB.EqTypesLoad();
            EqTypesDraw(null, null);
        }

        private void EqTypesDraw(object sender, EventArgs e)
        {
            listEqTypes.BeginUpdate();
            listEqTypes.Items.Clear();
            foreach (EqType eqType in eqTypes)
                if (eqType.Contains(toolETFilter.Text))
                    listEqTypes.Items.Add(eqType.ToListView());
            listEqTypes.EndUpdate();
            StatusCount(eqTypes.Count, listEqTypes);
            EqTypesSelChange(null, null);
        }
        private void EqTypesSelChange(object sender, EventArgs e)
        {
            bool sel = listEqTypes.SelectedIndices.Count > 0;
            toolETEdit.Enabled = sel;
            toolETDelete.Enabled = sel;
            cmETEdit.Enabled = sel;
            cmETDelete.Enabled = sel;
        }
        private void EqTypeFilterReset(object sender, EventArgs e) { toolETFilter.Text = ""; }

        private void EqTypeAdd(object sender, EventArgs e)
        {
            EqType eqType = new EqType();
            FormEqType form = new FormEqType(eqType);
            if (form.ShowDialog() == DialogResult.OK)
            {
                DB.EqTypeAdd(eqType);
                EqTypesRefresh();
            }
        }
        private void EqTypeEdit(object sender, EventArgs e)
        {
            if (listEqTypes.SelectedIndices.Count == 0) return;
            EqType eqType = (EqType)listEqTypes.SelectedItems[0].Tag;
            FormEqType form = new FormEqType(eqType);
            if (form.ShowDialog() == DialogResult.OK)
            {
                DB.EqTypeUpdate(eqType);
                EqTypesRefresh();
            }
        }

        private void EqTypeDelete(object sender, EventArgs e)
        {
            if (listEqTypes.SelectedIndices.Count == 0) return;
            EqType eqType = (EqType)listEqTypes.SelectedItems[0].Tag;
            if (DeleteRecord("тип оборудования", eqType.name))
            {
                DB.EqTypeDelete(eqType);
                EqTypesRefresh();
            }
        }

        private void EqTypesKeyboard(object sender, KeyEventArgs e)
        {
            if (listEqTypes.SelectedIndices.Count == 0) return;
            if (e.KeyCode == Keys.Enter) EqTypeEdit(null, null);
        }
        #endregion

        #region Модели
        private void ModelsView(object sender, EventArgs e)
        {
            if (panelModels.Visible) ModelsRefresh();
        }

        void ModelsRefresh()
        {
            models = DB.ModelsLoad();
            ModelsDraw(null, null);
        }

        private void ModelsDraw(object sender, EventArgs e)
        {
            listModels.BeginUpdate();
            listModels.Items.Clear();
            foreach (Model model in models)
                if (model.Contains(toolModelFilter.Text))
                    listModels.Items.Add(model.ToListView());
            listModels.EndUpdate();
            StatusCount(models.Count, listModels);
            ModelsSelChange(null, null);
        }
        private void ModelsSelChange(object sender, EventArgs e)
        {
            bool sel = listModels.SelectedIndices.Count > 0;
            toolModelEdit.Enabled = sel;
            toolModelDelete.Enabled = sel;
            cmModelEdit.Enabled = sel;
            cmMoveDelete.Enabled = sel;
        }
        private void ModelFilterReset(object sender, EventArgs e) { toolModelFilter.Text = ""; }

        private void ModelAdd(object sender, EventArgs e)
        {
            Model model = new Model();
            FormModel form = new FormModel(model);
            if (form.ShowDialog() == DialogResult.OK)
            {
                DB.ModelAdd(model);
                ModelsRefresh();
            }
        }
        private void ModelEdit(object sender, EventArgs e)
        {
            if (listModels.SelectedIndices.Count == 0) return;
            Model model = (Model)listModels.SelectedItems[0].Tag;
            FormModel form = new FormModel(model);
            if (form.ShowDialog() == DialogResult.OK)
            {
                DB.ModelUpdate(model);
                ModelsRefresh();
            }
        }

        private void ModelDelete(object sender, EventArgs e)
        {
            if (listModels.SelectedIndices.Count == 0) return;
            Model model = (Model)listModels.SelectedItems[0].Tag;
            if (DeleteRecord("модель", model.name))
            {
                DB.ModelDelete(model);
                ModelsRefresh();
            }
        }

        private void ModelsKeyboard(object sender, KeyEventArgs e)
        {
            if (listModels.SelectedIndices.Count == 0) return;
            if (e.KeyCode == Keys.Enter) ModelEdit(null, null);
        }
        #endregion

        #region Обоорудование
        private void EquipmentsView(object sender, EventArgs e)
        {
            if (panelEquipments.Visible) EquipmentsRefresh();
        }

        void EquipmentsRefresh()
        {
            equipments = DB.EquipmentsLoad();
            moves = DB.MovesLoad();
            EquipmentsDraw(null, null);
        }

        private void EquipmentsDraw(object sender, EventArgs e)
        {
            listEquipments.BeginUpdate();
            listEquipments.Items.Clear();
            foreach (Equipment equipment in equipments)
                if (equipment.Contains(toolEqFilter.Text))
                    listEquipments.Items.Add(equipment.ToListView());
            listEquipments.EndUpdate();
            StatusCount(equipments.Count, listEquipments);
            EquipmentsSelChange(null, null);
        }
        
        private void EquipmentsSelChange(object sender, EventArgs e)
        {
            int sel = listEquipments.SelectedIndices.Count;
            toolEqCopy.Enabled = sel == 1;
            toolEqEdit.Enabled = sel == 1;
            toolEqDelete.Enabled = sel == 1;
            toolEqMove.Enabled = sel > 0;
            cmEqCopy.Enabled = sel == 1;
            cmEqEdit.Enabled = sel == 1;
            cmEqDelete.Enabled = sel == 1;
            cmEqMove.Enabled = sel > 0;
            //Перерисовка нижней панели
            listEqMoves.BeginUpdate();
            listEqMoves.Items.Clear();
            if (sel == 1)
                foreach (Move m in moves)
                    foreach (ListViewItem item in listEquipments.SelectedItems)
                        if (((Equipment)item.Tag).ID == m.equipment)
                            listEqMoves.Items.Add(m.ToListView());
            listEqMoves.EndUpdate();
            tabEqMoves.Text = "Перемещения" + ListCount(listEqMoves);
        }

        private void EquipmentFilterReset(object sender, EventArgs e) { toolEqFilter.Text = ""; }

        private void EquipmentAdd(object sender, EventArgs e)
        {
            Equipment equipment = new Equipment();
            FormEquipment form = new FormEquipment(equipment);
            if (form.ShowDialog() == DialogResult.OK)
            {
                DB.EquipmentAdd(equipment);
                EquipmentsRefresh();
            }
        }

        private void EquipmentCopy(object sender, EventArgs e)
        {
            if (listEquipments.SelectedIndices.Count != 1) return;
            Equipment equipmentOr = (Equipment)listEquipments.SelectedItems[0].Tag;
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
                DB.EquipmentAdd(equipment);
                EquipmentsRefresh();
            }
        }

        private void EquipmentEdit(object sender, EventArgs e)
        {
            if (listEquipments.SelectedIndices.Count == 0) return;
            Equipment equipment = (Equipment)listEquipments.SelectedItems[0].Tag;
            FormEquipment form = new FormEquipment(equipment);
            if (form.ShowDialog() == DialogResult.OK)
            {
                DB.EquipmentUpdate(equipment);
                EquipmentsRefresh();
            }
        }

        private void EquipmentDelete(object sender, EventArgs e)
        {
            if (listEquipments.SelectedIndices.Count == 0) return;
            Equipment equipment = (Equipment)listEquipments.SelectedItems[0].Tag;
            if (DeleteRecord("оборудование", equipment.nameText))
            {
                DB.EquipmentDelete(equipment);
                EquipmentsRefresh();
            }
        }

        private void EquipmentsKeyboard(object sender, KeyEventArgs e)
        {
            if (listEquipments.SelectedIndices.Count == 0) return;
            if (e.KeyCode == Keys.Enter) EquipmentEdit(null, null);
            if (e.KeyCode == Keys.Delete) EquipmentDelete(null, null);
        }

        private void EquipmentsMove(object sender, EventArgs e)
        {
            if (listEquipments.SelectedIndices.Count == 0) return;
            bool pack = listEquipments.SelectedIndices.Count > 1;
            Move move = new Move();
            if (!pack) move.equipment = ((Equipment)listEquipments.SelectedItems[0].Tag).ID;
            
            FormMove form = new FormMove(move, pack);
            if (form.ShowDialog() == DialogResult.OK)
            {
                foreach (ListViewItem item in listEquipments.SelectedItems)
                    DB.MoveAdd(move.newMove(((Equipment)item.Tag).ID));
                EquipmentsRefresh();
            }
        }

        private void MoveEditFromEquipment(object sender, EventArgs e)
        {
            if (listEqMoves.SelectedIndices.Count == 0) return;
            Move move = (Move)listEqMoves.SelectedItems[0].Tag;
            FormMove form = new FormMove(move, false);
            if (form.ShowDialog() == DialogResult.OK)
            {
                DB.MoveUpdate(move);
                EquipmentsRefresh();
            }
        }
        #endregion

        #region Перемещение
        private void MovesView(object sender, EventArgs e)
        {
            if (panelMoves.Visible) MovesRefresh();
        }

        void MovesRefresh()
        {
            moves = DB.MovesLoad();
            MovesDraw(null, null);
        }

        private void MovesDraw(object sender, EventArgs e)
        {
            listMoves.BeginUpdate();
            listMoves.Items.Clear();
            foreach (Move move in moves)
                if (move.Contains(toolMoveFilter.Text))
                    listMoves.Items.Add(move.ToListView());
            listMoves.EndUpdate();
            StatusCount(moves.Count, listMoves);
            MovesSelChange(null, null);
        }
        private void MovesSelChange(object sender, EventArgs e)
        {
            bool sel = listMoves.SelectedIndices.Count > 0;
            toolMoveEdit.Enabled = sel;
            toolMoveDelete.Enabled = sel;
            cmMoveEdit.Enabled = sel;
            cmMoveDelete.Enabled = sel;
        }
        private void MoveFilterReset(object sender, EventArgs e) { toolMoveFilter.Text = ""; }

        private void MoveAdd(object sender, EventArgs e)
        {
            Move move = new Move();
            FormMove form = new FormMove(move, false);
            if (form.ShowDialog() == DialogResult.OK)
            {
                DB.MoveAdd(move);
                MovesRefresh();
            }
        }
        private void MoveEdit(object sender, EventArgs e)
        {
            if (listMoves.SelectedIndices.Count == 0) return;
            Move move = (Move)listMoves.SelectedItems[0].Tag;
            FormMove form = new FormMove(move, false);
            if (form.ShowDialog() == DialogResult.OK)
            {
                DB.MoveUpdate(move);
                MovesRefresh();
            }
        }

        private void MoveDelete(object sender, EventArgs e)
        {
            if (listMoves.SelectedIndices.Count == 0) return;
            Move move = (Move)listMoves.SelectedItems[0].Tag;
            if (DeleteRecord("перемещение оборудования", move.eqText))
            {
                DB.MoveDelete(move);
                MovesRefresh();
            }
        }

        private void MovesKeyboard(object sender, KeyEventArgs e)
        {
            if (listMoves.SelectedIndices.Count == 0) return;
            if (e.KeyCode == Keys.Enter) MoveEdit(null, null);
        }
        #endregion

        #region Поставщики
        private void ProvidersView(object sender, EventArgs e)
        {
            if (panelProviders.Visible) ProvidersRefresh();
        }

        void ProvidersRefresh()
        {
            providers = DB.ProvidersLoad();
            ProvidersDraw(null, null);
        }

        private void ProvidersDraw(object sender, EventArgs e)
        {
            listProviders.BeginUpdate();
            listProviders.Items.Clear();
            foreach (Provider provider in providers)
                if (provider.Contains(toolProviderFilter.Text))
                    listProviders.Items.Add(provider.ToListView());
            listProviders.EndUpdate();
            StatusCount(providers.Count, listProviders);
            ProvidersSelChange(null, null);
        }
        private void ProvidersSelChange(object sender, EventArgs e)
        {
            bool sel = listProviders.SelectedIndices.Count > 0;
            toolProviderEdit.Enabled = sel;
            toolProviderDelete.Enabled = sel;
            cmProviderEdit.Enabled = sel;
            cmProviderDelete.Enabled = sel;
        }
        private void ProviderFilterReset(object sender, EventArgs e) { toolProviderFilter.Text = ""; }

        private void ProviderAdd(object sender, EventArgs e)
        {
            Provider provider = new Provider();
            FormProvider form = new FormProvider(provider);
            if (form.ShowDialog() == DialogResult.OK)
            {
                DB.ProviderAdd(provider);
                ProvidersRefresh();
            }
        }

        private void ProviderEdit(object sender, EventArgs e)
        {
            if (listProviders.SelectedIndices.Count == 0) return;
            Provider provider = (Provider)listProviders.SelectedItems[0].Tag;
            FormProvider form = new FormProvider(provider);
            if (form.ShowDialog() == DialogResult.OK)
            {
                DB.ProviderUpdate(provider);
                ProvidersRefresh();
            }
        }

        private void ProviderDelete(object sender, EventArgs e)
        {
            if (listProviders.SelectedIndices.Count == 0) return;
            Provider provider = (Provider)listProviders.SelectedItems[0].Tag;
            if (DeleteRecord("поставщика", provider.name))
            {
                DB.ProviderDelete(provider);
                ProvidersRefresh();
            }
        }

        private void ProvidersKeyboard(object sender, KeyEventArgs e)
        {
            if (listProviders.SelectedIndices.Count == 0) return;
            if (e.KeyCode == Keys.Enter) ProviderEdit(null, null);
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
