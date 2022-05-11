using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace CompStore
{
    public partial class FormVendor : Form
    {
        List<string> names;

        public FormVendor(Vendor vendor)
        {
            InitializeComponent();
            names = DB.NamesLoad("vendors");
            if (vendor.name != "") names.Remove(vendor.name);

            textName.DataBindings.Add("Text", vendor, "name");
            
            textCom.DataBindings.Add("Text", vendor, "comment");

            if (vendor.name != null)
                Text = "Редактирование производителя \"" + vendor.name + "\"";
            else
                Text = "Добавление нового производителя";
            CheckField(null, null);
        }

        private void CheckField(object sender, EventArgs e)
        {
            bool en = textName.Text != "";
            string nm = textName.Text;
            bool ex = names.Find(o => o == nm) != null;

            textName.BackColor = en & !ex ? Color.LightGreen : Color.LightPink;
            if (ex)
                toolTip.Show("Такой производитель уже существует", textName);
            else
                toolTip.Hide(textName);

            buttonOK.Enabled = en;
        }


        private void OK(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }
    }
}
