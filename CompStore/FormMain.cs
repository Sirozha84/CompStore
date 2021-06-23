using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;

namespace CompStore
{
    public partial class FormMain : Form
    {
        List<Filial> filials;
        List<Building> buildings;
        List<Room> rooms;
        List<Dep> deps;
        List<Post> posts;
        List<User> users;

        public FormMain()
        {
            InitializeComponent();
            treeMenu.ExpandAll();

            //Костыль, но пока не придумал как по другому: в конструкторе все панели в разных местах,
            //а при старте сдвигаем все в одноу точку
            Point defLoc = new Point(163, 27);
            panelFilials.Location = defLoc;
            panelBuildings.Location = defLoc;
            panelRooms.Location = defLoc;
            panelDeps.Location = defLoc;
            panelPosts.Location = defLoc;
            panelUsers.Location = defLoc;
            panelEquipment.Location = defLoc;

            //Отладочное: выбираем вкладку по умолчанию, потом это будет, например, последняя открытая
            treeMenu.SelectedNode = treeMenu.Nodes.Find("nodeRooms", true)[0];
        }

        private void TabChange(object sender, TreeViewEventArgs e)
        {
            panelFilials.Visible = treeMenu.SelectedNode.Name == "nodeFilials";
            panelBuildings.Visible = treeMenu.SelectedNode.Name == "nodeBuildings";
            panelRooms.Visible = treeMenu.SelectedNode.Name == "nodeRooms";
            panelDeps.Visible = treeMenu.SelectedNode.Name == "nodeDeps";
            panelPosts.Visible = treeMenu.SelectedNode.Name == "nodePosts";
            panelUsers.Visible = treeMenu.SelectedNode.Name == "nodeUsers";
            panelEquipment.Visible = treeMenu.SelectedNode.Name == "nodeEquipment";
        }

        private void инициализацияToolStripMenuItem_Click(object sender, EventArgs e) { DB.Init(); }

        #region Филиалы
        private void panelFilials_VisibleChanged(object sender, EventArgs e)
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
                if (filial.Contains(textFilialFilter.Text))
                    listFilials.Items.Add(filial.ToListView());
            listFilials.EndUpdate();
            FilialsSelChange(null, null);
        }
        private void FilialsSelChange(object sender, EventArgs e)
        {
            bool sel = listFilials.SelectedIndices.Count > 0;
            buttonFEdit.Enabled = sel;
            buttonFDel.Enabled = sel;
        }
        private void FilialFilterReset(object sender, EventArgs e) { textFilialFilter.Text = ""; }

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
            if (MessageBox.Show("Уверены что хотите удалить филиал \"" + filial.name + "\"?",
                "Удаление записи", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                DB.FilialDelete(filial);
                FilialsRefresh();
            }
        }
        #endregion

        #region Помещения
        private void panelRooms_VisibleChanged(object sender, EventArgs e)
        {
            if (panelRooms.Visible) RoomsRefresh();
        }

        void RoomsRefresh()
        {
            rooms = DB.RoomsLoad("");
            RoomsDraw(null, null);
        }

        private void RoomsDraw(object sender, EventArgs e)
        {
            listRooms.BeginUpdate();
            listRooms.Items.Clear();
            foreach (Room room in rooms)
                if (room.Contains(textRoomFilter.Text))
                    listRooms.Items.Add(room.ToListView());
            listRooms.EndUpdate();
            FilialsSelChange(null, null);
        }
        private void RoomsSelChange(object sender, EventArgs e)
        {
            bool sel = listRooms.SelectedIndices.Count > 0;
            buttonRoomEdit.Enabled = sel;
            buttonRoomDelete.Enabled = sel;
        }
        private void buttonRoomsFilterReset_Click(object sender, EventArgs e) { textRoomFilter.Text = ""; }

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
            if (MessageBox.Show("Уверены что хотите удалить филиал \"" + room.name + "\"?",
                "Удаление записи", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                DB.RoomDelete(room);
                RoomsRefresh();
            }
        }
        #endregion
        
        #region Должности
        private void panelPosts_VisibleChanged(object sender, EventArgs e)
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
                if (post.Contains(textRoomFilter.Text))
                    listPosts.Items.Add(post.ToListView());
            listPosts.EndUpdate();
            FilialsSelChange(null, null);
        }
        private void PostsSelChange(object sender, EventArgs e)
        {
            bool sel = listPosts.SelectedIndices.Count > 0;
            buttonPostEdit.Enabled = sel;
            buttonPostDelete.Enabled = sel;
        }
        private void PostFilterReset(object sender, EventArgs e) { textPostFilter.Text = ""; }

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
            if (MessageBox.Show("Уверены что хотите удалить филиал \"" + post.name + "\"?",
                "Удаление записи", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                DB.PostDelete(post);
                PostsRefresh();
            }
        }
        #endregion

        #region Отделы
        private void panelDeps_VisibleChanged(object sender, EventArgs e)
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
                if (dep.Contains(textRoomFilter.Text))
                    listDeps.Items.Add(dep.ToListView());
            listDeps.EndUpdate();
            DepsSelChange(null, null);
        }
        private void DepsSelChange(object sender, EventArgs e)
        {
            bool sel = listDeps.SelectedIndices.Count > 0;
            buttonDepEdit.Enabled = sel;
            buttonDepDelete.Enabled = sel;
        }
        private void DepFilterReset(object sender, EventArgs e) { textPostFilter.Text = ""; }

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
            if (MessageBox.Show("Уверены что хотите удалить отдел \"" + dep.name + "\"?",
                "Удаление записи", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                DB.DepDelete(dep);
                DepsRefresh();
            }
        }
        #endregion

        #region Здания
        private void panelBuildings_VisibleChanged(object sender, EventArgs e)
        {
            if (panelBuildings.Visible) BuildingsRefresh();
        }

        void BuildingsRefresh()
        {
            buildings = DB.BuildingsLoad("");
            BuildingsDraw(null, null);
        }

        private void BuildingsDraw(object sender, EventArgs e)
        {
            listBuildings.BeginUpdate();
            listBuildings.Items.Clear();
            foreach (Building building in buildings)
                if (building.Contains(textBuildingFilter.Text))
                    listBuildings.Items.Add(building.ToListView());
            listBuildings.EndUpdate();
            FilialsSelChange(null, null);
        }
        private void BuildingsSelChange(object sender, EventArgs e)
        {
            bool sel = listBuildings.SelectedIndices.Count > 0;
            buttonBuildingEdit.Enabled = sel;
            buttonBuildingDelete.Enabled = sel;
        }
        private void buttonBuildingsFilterReset_Click(object sender, EventArgs e) { textBuildingFilter.Text = ""; }

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
            if (MessageBox.Show("Уверены что хотите удалить филиал \"" + building.name + "\"?",
                "Удаление записи", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                DB.BuildingDelete(building);
                BuildingsRefresh();
            }
        }
        #endregion

        #region Сотрудники
        private void panelUsers_VisibleChanged(object sender, EventArgs e)
        {
            if (panelUsers.Visible) UsersRefresh();
        }

        void UsersRefresh()
        {
            users = DB.UsersLoad();
            UsersDraw(null, null);
        }

        private void UsersDraw(object sender, EventArgs e)
        {
            listUsers.BeginUpdate();
            listUsers.Items.Clear();
            foreach (User user in users)
                if (user.Contains(textUserFilter.Text))
                    listUsers.Items.Add(user.ToListView());
            listUsers.EndUpdate();
            UsersSelChange(null, null);
        }
        private void UsersSelChange(object sender, EventArgs e)
        {
            bool sel = listUsers.SelectedIndices.Count > 0;
            buttonUserEdit.Enabled = sel;
            buttonUserDelete.Enabled = sel;
        }
        private void UserFilterReset(object sender, EventArgs e) { textUserFilter.Text = ""; }

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
            if (MessageBox.Show("Уверены что хотите удалить сотрудника \"" + user.fioText + "\"?",
                "Удаление записи", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                DB.UserDelete(user);
                UsersRefresh();
            }
        }
        #endregion
    }
}
