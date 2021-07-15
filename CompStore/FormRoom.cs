using System;
using System.Windows.Forms;

namespace CompStore
{
    public partial class FormRoom : Form
    {
        public FormRoom(Room room)
        {
            InitializeComponent();

            comboBuilding.DataSource = DB.BuildingsLoad();
            comboBuilding.DisplayMember = "nameText";
            comboBuilding.ValueMember = "ID";
            comboBuilding.DataBindings.Add("SelectedValue", room, "building");
            textName.DataBindings.Add("Text", room, "name");
            textCom.DataBindings.Add("Text", room, "comment");

            if (room.name != null)
                Text = "Редактирование помещения \"" + room.name + "\"";
            else
                Text = "Добавление нового помещения";
        }

        private void OK(object sender, EventArgs e) 
        {
            DialogResult = DialogResult.OK; 
        }
    }
}
