using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CompStore
{
    public partial class FormFilial : Form
    {
        Filial filial;
        public FormFilial(Filial filial)
        {
            InitializeComponent();
            this.filial = filial;
            if (filial.name != null)
            {
                Text = "Редактирование филиала \"" + filial.name + "\"";
                textName.Text = filial.name;
                textAdress.Text = filial.adress;
                textCom.Text = filial.comment;
            }
            else
            {
                Text = "Добавление нового филиала";
            }
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            filial.name = textName.Text;
            filial.adress = textAdress.Text;
            filial.comment = textCom.Text;
            DialogResult = DialogResult.OK;
        }
    }
}
