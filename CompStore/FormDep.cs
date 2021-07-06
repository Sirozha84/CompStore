using System;
using System.Windows.Forms;

namespace CompStore
{
    public partial class FormDep : Form
    {
        public FormDep(Dep dep)
        {
            InitializeComponent();
            textName.DataBindings.Add("Text", dep, "name");
            textCom.DataBindings.Add("Text", dep, "comment");

            if (dep.name != null)
                Text = "Редактирование подразделения \"" + dep.name + "\"";
            else
                Text = "Добавление нового подразделения";
        }

        private void OK(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }
    }
}
