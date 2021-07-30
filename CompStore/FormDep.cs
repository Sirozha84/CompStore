using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace CompStore
{
    public partial class FormDep : Form
    {
        List<string> names;

        public FormDep(Dep dep)
        {
            InitializeComponent();
            names = DB.NamesLoad("deps");
            if (dep.name != "") names.Remove(dep.name);

            textName.DataBindings.Add("Text", dep, "name");
            
            textCom.DataBindings.Add("Text", dep, "comment");

            if (dep.name != null)
                Text = "Редактирование подразделения \"" + dep.name + "\"";
            else
                Text = "Добавление нового подразделения";
            CheckField(null, null);
        }

        private void CheckField(object sender, EventArgs e)
        {
            bool en = textName.Text != "";
            bool ex = names.Find(o => o == textName.Text) != null;

            textName.BackColor = en & !ex ? Color.LightGreen : Color.LightPink;
            if (ex)
                toolTip.Show("Такой отодел уже существует", textName);
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
