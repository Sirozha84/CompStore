using System;
using System.Windows.Forms;

namespace CompStore
{
    public partial class FormFilial : Form
    {
        public FormFilial(Filial filial)
        {
            InitializeComponent();
            
            textName.DataBindings.Add("Text", filial, "name");
            
            textAdress.DataBindings.Add("Text", filial, "adress");
            
            textCom.DataBindings.Add("Text", filial, "comment");
            
            if (filial.name != null)
                Text = "Редактирование филиала \"" + filial.name + "\"";
            else
                Text = "Добавление нового филиала";
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }
    }
}
