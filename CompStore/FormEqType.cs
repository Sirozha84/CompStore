using System;
using System.Windows.Forms;

namespace CompStore
{
    public partial class FormEqType : Form
    {
        public FormEqType(EqType eqtype)
        {
            InitializeComponent();
            textName.DataBindings.Add("Text", eqtype, "name");
            if (eqtype.name != null)
                Text = "Редактирование типа оборудования \"" + eqtype.name + "\"";
            else
                Text = "Добавление нового типа оборудования";
        }

        private void OK(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }
    }
}
