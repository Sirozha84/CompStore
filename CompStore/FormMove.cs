using System;
using System.Windows.Forms;

namespace CompStore
{
    public partial class FormMove : Form
    {
        public FormMove(Move move)
        {
            InitializeComponent();

            if (move.date < dateMove.MinDate) move.date = DateTime.Now;

            comboEquipment.DataSource = DB.EquipmentsLoad();
            comboEquipment.DisplayMember = "nameText";
            comboEquipment.ValueMember = "ID";
            comboEquipment.DataBindings.Add("SelectedValue", move, "equipment");

            comboUser.DataSource = DB.UsersLoad();
            comboUser.DisplayMember = "nameText";
            comboUser.ValueMember = "ID";
            comboUser.DataBindings.Add("SelectedValue", move, "user");

            comboRoom.DataSource = DB.RoomsLoad();
            comboRoom.DisplayMember = "nameText";
            comboRoom.ValueMember = "ID";
            comboRoom.DataBindings.Add("SelectedValue", move, "room");

            dateMove.DataBindings.Add("Value", move, "date");

            textCom.DataBindings.Add("Text", move, "comment");

            if (move.eqText != null)
                Text = "Редактирование перемещения \"" + move.eqText + "\"";
            else
                Text = "Добавление нового перемещения";
        }

        private void OK(object sender, EventArgs e)
        {
            comboEquipment.DataBindings[0].WriteValue();
            comboUser.DataBindings[0].WriteValue();
            comboRoom.DataBindings[0].WriteValue();
            DialogResult = DialogResult.OK;
        }
    }
}
