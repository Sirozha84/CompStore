﻿using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace CompStore
{
    public partial class FormMain : Form
    {
        List<Record> records;   //Записи выбранной вкладки (абстрактный класс)
        List<Record> moves;
        string curType;         //Текущий тип элемента
        string curName;         //Текущий тип элемента (на человеческом)
        string[] tabs;          //Здесь храним имена вкладок

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
            panelPosts.Visible = treeMenu.SelectedNode.Name == "nodePosts";
            panelUsers.Visible = treeMenu.SelectedNode.Name == "nodeUsers";
            panelBrands.Visible = treeMenu.SelectedNode.Name == "nodeBrands";
            panelEqTypes.Visible = treeMenu.SelectedNode.Name == "nodeEqType";
            panelModels.Visible = treeMenu.SelectedNode.Name == "nodeModels";
            panelProviders.Visible = treeMenu.SelectedNode.Name == "nodeProviders";
            
            panelList.Visible = true;   //Потом она останется одна и эта строка будет не нужна (ну и по умолчанию визибл ей надо будет сделать тру)
            if (treeMenu.SelectedNode.Name == "nodeFilials")
                PreparePage("filials", "Филиалы");
            if (treeMenu.SelectedNode.Name == "nodeBuildings")
                PreparePage("buildings", "Здания");
            if (treeMenu.SelectedNode.Name == "nodeRooms")
                PreparePage("rooms", "Помещения");
            if (treeMenu.SelectedNode.Name == "nodeDeps")
                PreparePage("deps", "Подразделения");


            if (treeMenu.SelectedNode.Name == "nodeEquipment")
            {
                PreparePage("equipments", "Оборудование","Перемещения", "Ремонты", "Заправки");
                PrepareListView(listViewAdd1, "moves");
            }
            if (treeMenu.SelectedNode.Name == "nodeMoves")
                PreparePage("moves", "Перемещения");

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

        #region *** Универсальная форма ***

        void ListViewRefresh()
        {
            records = DB.Load(curType);
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
            Form form = null;
            if (curType == "filials")
            {
                item = new Filial();
                form = new FormFilial((Filial)item);
            }
            if (curType == "buildings")
            {
                item = new Building();
                form = new FormBuilding((Building)item);
            }
            if (curType == "rooms")
            {
                item = new Room();
                form = new FormRoom((Room)item);
            }
            if (curType == "deps")
            {
                item = new Dep();
                form = new FormDep((Dep)item);
            }


            if (curType == "equipments")
            {
                item = new Equipment();
                form = new FormEquipment((Equipment)item);
            }
            if (curType == "moves")
            {
                item = new Move();
                form = new FormMove((Move)item, false);
            }
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
            Form form = null;
            if (listViewMain.SelectedIndices.Count == 0) return;
            item = (Record)listViewMain.SelectedItems[0].Tag;
            if (curType == "filials") form = new FormFilial((Filial)item);
            if (curType == "buildings") form = new FormBuilding((Building)item);
            if (curType == "rooms") form = new FormRoom((Room)item);
            if (curType == "deps") form = new FormDep((Dep)item);


            if (curType == "equipments") form = new FormEquipment((Equipment)item);
            if (curType == "moves") form = new FormMove((Move)item, false);
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

        #region Сотрудники
        private void UsersView(object sender, EventArgs e)
        {
            if (panelUsers.Visible) UsersRefresh();
        }

        void UsersRefresh()
        {
            users = DB.UsersLoad();
            //equipments = DB.EquipmentsLoad();
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
            //cmMoveDelete.Enabled = sel;
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
