using System;
using System.Windows.Forms;

namespace CompStore
{
    public partial class FormBuilding : Form
    {
        public FormBuilding(Building building)
        {
            InitializeComponent();
            comboFilial.DataSource = DB.FilialsLoad();
            comboFilial.DisplayMember = "name";
            comboFilial.ValueMember = "ID";
            comboFilial.DataBindings.Add("SelectedValue", building, "filial");
            textName.DataBindings.Add("Text", building, "name");
            textCom.DataBindings.Add("Text", building, "comment");

            if (building.name != null)
                Text = "Редактирование здания \"" + building.name + "\"";
            else
                Text = "Добавление нового здания";
        }
        private void OK(object sender, EventArgs e)
        {
            comboFilial.DataBindings[0].WriteValue(); //Грёбаный костыль, но без этого данные не меняются если крутить колесом
            DialogResult = DialogResult.OK;
        }
    }
}
