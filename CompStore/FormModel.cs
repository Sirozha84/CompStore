using System;
using System.Windows.Forms;

namespace CompStore
{
    public partial class FormModel : Form
    {
        Model model;
        public FormModel(Model model)
        {
            InitializeComponent();
            this.model = model;

            comboEqType.DataSource = DB.EqTypesLoad();
            comboEqType.DisplayMember = "name";
            comboEqType.ValueMember = "ID";
            if (model.eqType != 0) comboEqType.SelectedValue = model.eqType; else comboEqType.SelectedValue = "";

            comboBrand.DataSource = DB.BrandsLoad();
            comboBrand.DisplayMember = "name";
            comboBrand.ValueMember = "ID";
            if (model.brand != 0) comboBrand.SelectedValue = model.brand; else comboBrand.SelectedValue = "";
            
            textName.Text = model.name;
            textCom.Text = model.comment;

            if (model.name != null)
                Text = "Редактирование модели \"" + model.name + "\"";
            else
                Text = "Добавление новой модели";
        }

        private void OK(object sender, EventArgs e)
        {
            if (comboEqType.SelectedValue != null) model.eqType = (int)comboEqType.SelectedValue;
            if (comboBrand.SelectedValue != null) model.brand = (int)comboBrand.SelectedValue;
            model.name = textName.Text;
            model.comment = textCom.Text;
            DialogResult = DialogResult.OK;
        }
    }
}
