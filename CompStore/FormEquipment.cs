using System;
using System.Windows.Forms;

namespace CompStore
{
    public partial class FormEquipment : Form
    {
        Equipment equipment;
        public FormEquipment(Equipment equipment)
        {
            InitializeComponent();
            this.equipment = equipment;

            comboEqType.DataSource = DB.EqTypesLoad();
            comboEqType.DisplayMember = "name";
            comboEqType.ValueMember = "ID";
            if (equipment.eqType != 0) comboEqType.SelectedValue = equipment.eqType; else comboEqType.SelectedValue = "";

            comboBrand.DataSource = DB.BrandsLoad();
            comboBrand.DisplayMember = "name";
            comboBrand.ValueMember = "ID";
            if (equipment.brand != 0) comboBrand.SelectedValue = equipment.brand; else comboBrand.SelectedValue = "";

            TypeOrBrandChange(null, null);
            comboModel.DisplayMember = "name";
            comboModel.ValueMember = "ID";
            if (equipment.model != 0) comboModel.SelectedValue = equipment.model; else comboModel.SelectedValue = "";

            textSN.Text = equipment.sn;
            textIN.Text = equipment.iN;
            textCom.Text = equipment.comment;

            if (equipment.nameText != null)
                Text = "Редактирование оборудования \"" + equipment.nameText + "\"";
            else
                Text = "Добавление нового оборудования";
        }

        void TypeOrBrandChange(object sender, EventArgs e)
        {
            if (comboEqType.SelectedValue is int & comboBrand.SelectedValue is int)
                comboModel.DataSource = DB.ModelsLoad(comboEqType.SelectedValue.ToString(), comboBrand.SelectedValue.ToString());
        }

        private void OK(object sender, EventArgs e)
        {
            if (comboEqType.SelectedValue != null) equipment.eqType = (int)comboEqType.SelectedValue;
            if (comboBrand.SelectedValue != null) equipment.brand = (int)comboBrand.SelectedValue;
            if (comboModel.SelectedValue != null) equipment.model = (int)comboModel.SelectedValue;
            equipment.sn = textSN.Text;
            equipment.iN = textIN.Text;
            equipment.comment = textCom.Text;
            DialogResult = DialogResult.OK;
        }

    }
}
