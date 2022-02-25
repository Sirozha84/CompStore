using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace CompStore
{
    public partial class FormMove : Form
    {
        bool pack;  //true - означает что перемещается комплект и надо сделать недоступным для выбора поле "Оборудование"
        Move move;
        List<User> users;
        List<Record> equipments;

        public FormMove(Move move, bool pack)
        {
            InitializeComponent();
            this.move = move;
            this.pack = pack;

            if (move.date < dateMove.MinDate) move.date = DateTime.Now;

            equipments = DB.Load("equipments");
            comboEquipment.DataSource = equipments;
            comboEquipment.DisplayMember = "nameINText";
            comboEquipment.ValueMember = "ID";
            comboEquipment.SelectedValue = move.equipment;
            comboEquipment.Enabled = !pack;

            users = DB.UsersLoad();
            comboUser.DataSource = users;
            comboUser.DisplayMember = "nameText";
            comboUser.ValueMember = "ID";
            comboUser.SelectedValue = move.user;

            comboRoom.DataSource = DB.Load("rooms");
            comboRoom.DisplayMember = "nameText";
            comboRoom.ValueMember = "ID";
            comboRoom.SelectedValue = move.room;

            dateMove.DataBindings.Add("Value", move, "date");

            comboMOL.DataSource = users.ToArray();
            comboMOL.DisplayMember = "nameText";
            comboMOL.ValueMember = "ID";
            comboMOL.SelectedValue = move.mol;

            textCom.DataBindings.Add("Text", move, "comment");

            if (move.eqText != null)
                Text = "Редактирование перемещения \"" + move.eqText + "\"";
            else
                Text = pack ? "Перемещение нескольких объектов" : "Добавление нового перемещения";

            EquipmentSelect(null, null);
        }

        private void EquipmentSelect(object sender, EventArgs e)
        {
            try
            {
                comboMOL.SelectedValue = equipments.Find(o => o.ID == (int)comboEquipment.SelectedValue).mol;
                EnterCheck(null, null);
            }
            catch { }
        }

        private void UserSelect(object sender, EventArgs e)
        {
            try
            {
                comboRoom.SelectedValue = users.Find(o => o.ID == (int)comboUser.SelectedValue).room;
                EnterCheck(null, null);
            }
            catch { }
        }

        private void EnterCheck(object sender, EventArgs e)
        {
            buttonOK.Enabled = (pack | comboEquipment.SelectedIndex >= 0) & 
                               comboUser.SelectedIndex >= 0;
        }

        private void OK(object sender, EventArgs e)
        {
            move.equipment = pack ? 0 : (int)comboEquipment.SelectedValue;
            move.user = (int)comboUser.SelectedValue;
            move.room = comboRoom.SelectedValue != null ? (int)comboRoom.SelectedValue : 0;
            move.mol = comboMOL.SelectedValue != null ? (int)comboMOL.SelectedValue : 0;
            DialogResult = DialogResult.OK;
        }

        private void EquipmentAdd(object sender, EventArgs e)
        {
            Equipment equipment = new Equipment();
            FormEquipment form = new FormEquipment(equipment);
            if (form.ShowDialog() == DialogResult.OK)
            {
                DB.Add("equipment", equipment);
                List<Record> equipmentds = DB.Load("equipment");
                comboEquipment.DataSource = equipmentds;
                int max = 0;
                foreach (Equipment f in equipmentds)
                    if (max < f.ID) max = f.ID;
                comboEquipment.SelectedValue = max;
            }
        }

        private void UserAdd(object sender, EventArgs e)
        {
            User user = new User();
            FormUser form = new FormUser(user);
            if (form.ShowDialog() == DialogResult.OK)
            {
                DB.UserAdd(user);
                users = DB.UsersLoad();
                comboUser.DataSource = users;
                comboRoom.DataSource = DB.Load("rooms");
                comboMOL.DataSource = users;
                int max = 0;
                foreach (User f in users)
                    if (max < f.ID) max = f.ID;
                comboUser.SelectedValue = max;
            }
        }

        private void RoomAdd(object sender, EventArgs e)
        {
            Room room = new Room();
            FormRoom form = new FormRoom(room);
            if (form.ShowDialog() == DialogResult.OK)
            {
                DB.Add("rooms", room);
                List<Record> roomds = DB.Load("rooms");
                comboRoom.DataSource = roomds;
                int max = 0;
                foreach (Room f in roomds)
                    if (max < f.ID) max = f.ID;
                comboRoom.SelectedValue = max;
            }
        }

        private void MOLAdd(object sender, EventArgs e)
        {
            User user = new User();
            FormUser form = new FormUser(user);
            if (form.ShowDialog() == DialogResult.OK)
            {
                DB.UserAdd(user);
                users = DB.UsersLoad();
                comboUser.DataSource = users;
                comboRoom.DataSource = DB.Load("rooms");
                comboMOL.DataSource = users.ToArray();
                int max = 0;
                foreach (User f in users)
                    if (max < f.ID) max = f.ID;
                comboMOL.SelectedValue = max;
            }
        }
    }
}
