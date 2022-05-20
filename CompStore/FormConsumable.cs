using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace CompStore
{
    public partial class FormConsumable : Form
    {
        List<string> names;

        public FormConsumable(Consumable consumable)
        {
            InitializeComponent();
            names = DB.NamesLoad("consumables");
            if (consumable.name != "") names.Remove(consumable.name);

            textName.DataBindings.Add("Text", consumable, "name");

            textCom.DataBindings.Add("Text", consumable, "comment");

            if (consumable.name != null)
                Text = "Редактирование расходного материала \"" + consumable.name + "\"";
            else
                Text = "Добавление расходника";
            CheckField(null, null);
        }
        private void CheckField(object sender, EventArgs e)
        {
            bool en = textName.Text != "";
            bool ex = names.Find(o => o == textName.Text) != null;

            textName.BackColor = en & !ex ? Color.LightGreen : Color.LightPink;
            if (ex)
                toolTip.Show("Такой расходник уже существует", textName);
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
