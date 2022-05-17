using System;
using System.Windows.Forms;

namespace CompStore
{
    public partial class FormProperties : Form
    {
        public FormProperties()
        {
            InitializeComponent();
            CompanyProperties.Load();
            textComp.Text = CompanyProperties.Companay;
            textDep.Text = CompanyProperties.Departament;
        }

        private void OK(object sender, EventArgs e)
        {
            CompanyProperties.Companay = textComp.Text;
            CompanyProperties.Departament = textDep.Text;
            CompanyProperties.Save();
            Close();
        }
    }
}
