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
        List<Room> rooms;
        public FormMain()
        {
            InitializeComponent();
            treeMenu.ExpandAll();

            //Костыль, но пока не придумал как по другому: в конструкторе все панели в разных местах,
            //а при старте сдвигаем все в одноу точку
            Point defLoc = new Point(163, 27);
            panelFilials.Location = defLoc;
            panelRooms.Location = defLoc;
            panelUsers.Location = defLoc;
            panelEquipment.Location = defLoc;

            //Отладочное: выбираем вкладку по умолчанию, потом это будет, например, последняя открытая
            treeMenu.SelectedNode = treeMenu.Nodes.Find("nodeRooms", true)[0];
        }

        private void TabChange(object sender, TreeViewEventArgs e)
        {
            panelFilials.Visible = treeMenu.SelectedNode.Name == "nodeFilials";
            panelRooms.Visible = treeMenu.SelectedNode.Name == "nodeRooms";
            panelUsers.Visible = treeMenu.SelectedNode.Name == "nodeUsers";
            panelEquipment.Visible = treeMenu.SelectedNode.Name == "nodeEquipment";
        }

        private void инициализацияToolStripMenuItem_Click(object sender, EventArgs e) { DB.Init(); }

        #region Филиалы
        private void panelFilials_VisibleChanged(object sender, EventArgs e)
        {
            if (!panelFilials.Visible) return;
            FilialsRefresh();
            FilialsSelChange(null, null);
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
            if (!panelRooms.Visible) return;
            RoomsRefresh();
            RoomsSelChange(null, null);
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

    }
}
