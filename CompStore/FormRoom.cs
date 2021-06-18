using System;
using System.Windows.Forms;

namespace CompStore
{
    public partial class FormRoom : Form
    {
        public FormRoom(Room room)
        {
            InitializeComponent();
            comboFilial.DataSource = DB.FilialsLoad();
            comboFilial.DisplayMember = "name";
            comboFilial.ValueMember = "ID";
            comboFilial.DataBindings.Add("SelectedValue", room, "filial");
            textName.DataBindings.Add("Text", room, "name");
            textCom.DataBindings.Add("Text", room, "comment");

            if (room.name != null)
                Text = "Редактирование помещения \"" + room.name + "\"";
            else
                Text = "Добавление нового помещения";
        }
        private void buttonOK_Click(object sender, EventArgs e)
        {
            comboFilial.DataBindings[0].WriteValue(); //Грёбаный костыль, но без этого данные не меняются если крутить колесом
            DialogResult = DialogResult.OK;
        }
    }
}
