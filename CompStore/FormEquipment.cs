using System;
using System.Windows.Forms;

namespace CompStore
{
    public partial class FormEquipment : Form
    {
        public FormEquipment(Equipment equipment)
        {
            InitializeComponent();

            comboEqType.DataSource = DB.EqTypesLoad();
            comboEqType.DisplayMember = "name";
            comboEqType.ValueMember = "ID";
            comboEqType.DataBindings.Add("SelectedValue", equipment, "eqType");

            comboBrand.DataSource = DB.BrandsLoad();
            comboBrand.DisplayMember = "name";
            comboBrand.ValueMember = "ID";
            comboBrand.DataBindings.Add("SelectedValue", equipment, "brand");

            comboModel.DataSource = DB.ModelsLoad("", "");
            comboModel.DisplayMember = "name";
            comboModel.ValueMember = "ID";
            comboModel.DataBindings.Add("SelectedValue", equipment, "model");

            textSN.DataBindings.Add("Text", equipment, "sn");

            textIN.DataBindings.Add("Text", equipment, "iN");

            dateBuy.DataBindings.Add("Value", equipment, "buyDate");
            dateBuy.DataBindings.Add("Checked", equipment, "buy");

            textCom.DataBindings.Add("Text", equipment, "comment");

            if (equipment.nameText != null)
                Text = "Редактирование оборудования \"" + equipment.nameText + "\"";
            else
                Text = "Добавление нового оборудования";
        }

        private void BrandChange(object sender, EventArgs e)
        {
            if (comboBrand.SelectedValue == null || comboBrand.SelectedValue.ToString() == "CompStore.Brand") return;
            Text = comboEqType.SelectedValue.ToString() + comboBrand.SelectedValue.ToString();
            comboModel.DataSource = DB.ModelsLoad(comboEqType.SelectedValue.ToString(), comboBrand.SelectedValue.ToString());
        }

        private void OK(object sender, EventArgs e)
        {
            comboEqType.DataBindings[0].WriteValue();
            comboBrand.DataBindings[0].WriteValue();
            comboModel.DataBindings[0].WriteValue();
            DialogResult = DialogResult.OK;
        }

    }
}
