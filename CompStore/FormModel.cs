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
            if (model.name != "") names.Remove(model.vendor.ToString() + "‼" + model.name);

            comboEqType.DataSource = DB.Load("eqtypes");
            comboEqType.DisplayMember = "name";
            comboEqType.ValueMember = "ID";
            comboEqType.SelectedValue = model.eqType;

            combovendor.DataSource = DB.Load("vendors");
            combovendor.DisplayMember = "name";
            combovendor.ValueMember = "ID";
            combovendor.SelectedValue = model.vendor;

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
            bool en = comboEqType.SelectedIndex>=0 & combovendor.SelectedIndex >= 0 & textName.Text != "";
            bool ex = names.Find(o => o == vendor() + "‼" + textName.Text) != null;

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
            model.vendor = vendor();
            DialogResult = DialogResult.OK;
        }

        int vendor()
        {
            return combovendor.SelectedValue != null & combovendor.Text != "CompStore.Vendor" ? (int)combovendor.SelectedValue : 0;
        }

        private void EquipmentTypeAdd(object sender, EventArgs e)
        {
            EqType eqtype = new EqType();
            FormEqType form = new FormEqType(eqtype);
            if (form.ShowDialog() == DialogResult.OK)
            {
                DB.Add("eqtypes", eqtype);
                List<Record> eqtypeds = DB.Load("eqtypes");
                comboEqType.DataSource = eqtypeds;
                int max = 0;
                foreach (EqType et in eqtypeds)
                    if (max < et.ID) max = et.ID;
                comboEqType.SelectedValue = max;
            }
        }

        private void vendorAdd(object sender, EventArgs e)
        {
            Vendor vendor = new Vendor();
            FormVendor form = new FormVendor(vendor);
            if (form.ShowDialog() == DialogResult.OK)
            {
                DB.Add("vendors", vendor);
                List<Record> vendors = DB.Load("vendors");
                combovendor.DataSource = vendors;
                int max = 0;
                foreach (Vendor v in vendors)
                    if (max < v.ID) max = v.ID;
                combovendor.SelectedValue = max;
            }
        }
    }
}
