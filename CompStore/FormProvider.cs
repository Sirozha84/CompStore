using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace CompStore
{
    public partial class FormFilial : Form
    {
        List<string> names;

        public FormFilial(Filial filial)
        {
            InitializeComponent();
            names = DB.NamesLoad("filials");
            if (filial.name != "") names.Remove(filial.name);

            textName.DataBindings.Add("Text", filial, "name");
            
            textAdress.DataBindings.Add("Text", filial, "adress");
            
            textCom.DataBindings.Add("Text", filial, "comment");
            
            if (filial.name != null)
                Text = "Редактирование филиала \"" + filial.name + "\"";
            else
                Text = "Добавление нового филиала";
            CheckField(null, null);
        }

        private void CheckField(object sender, EventArgs e)
        {
            bool en = textName.Text != "";
            bool ex = names.Find(o => o == textName.Text) != null;
            
            textName.BackColor = en & !ex ? Color.LightGreen : Color.LightPink;
            if (ex)
                toolTip.Show("Такой филиал уже существует", textName);
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
