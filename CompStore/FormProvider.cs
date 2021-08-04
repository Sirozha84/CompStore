using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace CompStore
{
    public partial class FormProvider : Form
    {
        List<string> names;

        public FormProvider(Provider provider)
        {
            InitializeComponent();
            names = DB.NamesLoad("providers");
            if (provider.name != "") names.Remove(provider.name);

            textName.DataBindings.Add("Text", provider, "name");
            
            textAdress.DataBindings.Add("Text", provider, "adress");

            textPhone.DataBindings.Add("Text", provider, "phone");

            textManager.DataBindings.Add("Text", provider, "manager");

            textCom.DataBindings.Add("Text", provider, "comment");
            
            if (provider.name != null)
                Text = "Редактирование поставщика \"" + provider.name + "\"";
            else
                Text = "Добавление нового поставщика";
            CheckField(null, null);
        }

        private void CheckField(object sender, EventArgs e)
        {
            bool en = textName.Text != "";
            bool ex = names.Find(o => o == textName.Text) != null;
            
            textName.BackColor = en & !ex ? Color.LightGreen : Color.LightPink;
            if (ex)
                toolTip.Show("Такой поставщик уже существует", textName);
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
