using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace CompStore
{
    public partial class FormModel : Form
    {
        Model model;
        List<string> names;
        public FormModel(Model model)
        {
            InitializeComponent();
            this.model = model;
            names = DB.NamesLoad("models");
            if (model.name != "") names.Remove(model.brand.ToString() + "‼" + model.name);

            comboEqType.DataSource = DB.EqTypesLoad();
            comboEqType.DisplayMember = "name";
            comboEqType.ValueMember = "ID";
            comboEqType.SelectedValue = model.eqType;

            comboBrand.DataSource = DB.BrandsLoad();
            comboBrand.DisplayMember = "name";
            comboBrand.ValueMember = "ID";
            comboBrand.SelectedValue = model.brand;

            textName.DataBindings.Add("Text", model, "name");

            textCom.DataBindings.Add("Text", model, "comment");

            if (model.name != null)
                Text = "Редактирование модели \"" + model.name + "\"";
            else
                Text = "Добавление новой модели";
            CheckField(null, null);
        }

        private void CheckField(object sender, EventArgs e)
        {
            bool en = comboEqType.SelectedIndex>=0 & comboBrand.SelectedIndex >= 0 & textName.Text != "";
            bool ex = names.Find(o => o == Brand() + "‼" + textName.Text) != null;

            textName.BackColor = en & !ex ? Color.LightGreen : Color.LightPink;
            if (ex)
                toolTip.Show("Такая модель уже существует у выбранного производителя", textName);
            else
                toolTip.Hide(textName);

            buttonOK.Enabled = en;
        }

        private void OK(object sender, EventArgs e)
        {
            model.eqType = comboEqType.SelectedValue != null ? (int)comboEqType.SelectedValue : 0;
            model.brand = Brand();
            DialogResult = DialogResult.OK;
        }

        int Brand()
        {
            return comboBrand.SelectedValue != null & comboBrand.Text != "CompStore.Brand" ? (int)comboBrand.SelectedValue : 0;
        }
    }
}
