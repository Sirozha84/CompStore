using System;
using System.Windows.Forms;

namespace CompStore
{
    public partial class FormRoom : Form
    {
        Room room;

        public FormRoom(Room room)
        {
            InitializeComponent();
            this.room = room;
            
            comboFilial.DataSource = DB.FilialsLoad();
            comboFilial.DisplayMember = "name";
            comboFilial.ValueMember = "ID";
            if (room.filial != 0) comboFilial.SelectedValue = room.filial; else comboFilial.SelectedValue = "";
            FilialSelect(null, null);
            
            comboBuilding.DisplayMember = "name";
            comboBuilding.ValueMember = "ID";
            if (room.building != 0) comboBuilding.SelectedValue = room.building; else comboBuilding.SelectedValue = "";
            
            textName.Text = room.name;
            textCom.Text = room.comment;

            if (room.name != null)
                Text = "Редактирование помещения \"" + room.name + "\"";
            else
                Text = "Добавление нового помещения";
        }

        private void OK(object sender, EventArgs e)
        {
            if (comboFilial.SelectedValue != null) room.filial = (int)comboFilial.SelectedValue;
            if (comboBuilding.SelectedValue != null) room.building = (int)comboBuilding.SelectedValue;
            room.name = textName.Text;
            room.comment = textCom.Text;
            DialogResult = DialogResult.OK;
        }

        private void FilialSelect(object sender, EventArgs e)
        {
            //if (comboFilial.SelectedValue is int)
              //  comboBuilding.DataSource = DB.BuildingsLoad(comboFilial.SelectedValue.ToString());
        }
    }
}
