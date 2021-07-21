using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace CompStore
{
    public partial class FormMove : Form
    {
        bool pack;
        Move move;
        List<User> users;

        public FormMove(Move move, bool pack)
        {
            InitializeComponent();
            this.move = move;
            this.pack = pack;

            if (move.date < dateMove.MinDate) move.date = DateTime.Now;

            comboEquipment.DataSource = DB.EquipmentsLoad();
            comboEquipment.DisplayMember = "nameINText";
            comboEquipment.ValueMember = "ID";
            comboEquipment.SelectedValue = move.equipment;
            comboEquipment.Enabled = !pack;

            users = DB.UsersLoad();
            comboUser.DataSource = users;
            comboUser.DisplayMember = "nameText";
            comboUser.ValueMember = "ID";
            comboUser.SelectedValue = move.user;

            comboRoom.DataSource = DB.RoomsLoad();
            comboRoom.DisplayMember = "nameText";
            comboRoom.ValueMember = "ID";
            comboRoom.SelectedValue = move.room;

            dateMove.DataBindings.Add("Value", move, "date");

            textCom.DataBindings.Add("Text", move, "comment");

            if (move.eqText != null)
                Text = "Редактирование перемещения \"" + move.eqText + "\"";
            else
                Text = pack ? "Перемещение объектов" : "Добавление нового перемещения";
        }

        private void comboUser_SelectedIndexChanged(object sender, EventArgs e)
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
            move.room = (int)comboRoom.SelectedValue;
            DialogResult = DialogResult.OK;
        }               
    }
}
