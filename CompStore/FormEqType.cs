using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace CompStore
{
    public partial class FormEqType : Form
    {
        List<string> names;

        public FormEqType(EqType eqtype)
        {
            InitializeComponent();
            names = DB.NamesLoad("eqtypes");
            if (eqtype.name != "") names.Remove(eqtype.name);

            textName.DataBindings.Add("Text", eqtype, "name");

            checkPrinter.DataBindings.Add("Checked", eqtype, "printer");

            if (eqtype.name != null)
                Text = "Редактирование типа оборудования \"" + eqtype.name + "\"";
            else
                Text = "Добавление нового типа оборудования";
            CheckField(null, null);
        }

        private void CheckField(object sender, EventArgs e)
        {
            bool en = textName.Text != "";
            bool ex = names.Find(o => o == textName.Text) != null;

            textName.BackColor = en & !ex ? Color.LightGreen : Color.LightPink;
            if (ex)
                toolTip.Show("Такой тип оборудования уже существует", textName);
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
