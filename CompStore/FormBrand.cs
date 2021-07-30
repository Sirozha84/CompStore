using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace CompStore
{
    public partial class FormBrand : Form
    {
        List<string> names;

        public FormBrand(Brand brand)
        {
            InitializeComponent();
            names = DB.NamesLoad("brands");
            if (brand.name != "") names.Remove(brand.name);

            textName.DataBindings.Add("Text", brand, "name");
            
            textCom.DataBindings.Add("Text", brand, "comment");

            if (brand.name != null)
                Text = "Редактирование производителя \"" + brand.name + "\"";
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
