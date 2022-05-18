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
            textLastUCN.Text = CompanyProperties.LastUserCardNum.ToString();
        }

        private void OK(object sender, EventArgs e)
        {
            CompanyProperties.Companay = textComp.Text;
            CompanyProperties.Departament = textDep.Text;
            try { CompanyProperties.LastUserCardNum = Convert.ToInt32(textLastUCN.Text); }
            catch { CompanyProperties.LastUserCardNum = 1; }
            CompanyProperties.Save();
            Close();
        }
    }
}
