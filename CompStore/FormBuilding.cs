using System;
using System.Windows.Forms;

namespace CompStore
{
    public partial class FormBuilding : Form
    {
        Building building;
        public FormBuilding(Building building)
        {
            InitializeComponent();
            this.building = building;
            
            comboFilial.DataSource = DB.FilialsLoad();
            comboFilial.DisplayMember = "name";
            comboFilial.ValueMember = "ID";
            if (building.filial != 0) comboFilial.SelectedValue = building.filial; else comboFilial.SelectedValue = "";
            textName.Text = building.name;
            textCom.Text = building.comment;

            if (building.name != null)
                Text = "Редактирование здания \"" + building.name + "\"";
            else
                Text = "Добавление нового здания";
        }
        private void OK(object sender, EventArgs e)
        {
            if (comboFilial.SelectedValue != null) building.filial = (int)comboFilial.SelectedValue;
            building.name = textName.Text;
            building.comment = textCom.Text;
            DialogResult = DialogResult.OK;
        }
    }
}
