using System;
using System.Windows.Forms;

namespace CompStore
{
    public partial class FormBrand : Form
    {
        public FormBrand(Brand brand)
        {
            InitializeComponent();
            
            textName.DataBindings.Add("Text", brand, "name");
            
            textCom.DataBindings.Add("Text", brand, "comment");

            if (brand.name != null)
                Text = "Редактирование производителя \"" + brand.name + "\"";
            else
                Text = "Добавление нового производителя";
        }

        private void OK(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }
    }
}
