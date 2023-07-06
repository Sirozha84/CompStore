using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace CompStore
{
    public partial class FormActivity : Form
    {
        List<string> names;

        public FormActivity(Activity activity)
        {
            InitializeComponent();
            names = DB.NamesLoad("activitys");
            if (activity.name != "") names.Remove(activity.name);

            textName.DataBindings.Add("Text", activity, "name");

            if (activity.name != null)
                Text = "Редактирование вида деятельности \"" + activity.name + "\"";
            else
                Text = "Добавление нового вида деятельности должности";
            CheckField(null, null);
        }

        private void CheckField(object sender, EventArgs e)
        {
            bool en = textName.Text != "";
            bool ex = names.Find(o => o == textName.Text) != null;

            textName.BackColor = en & !ex ? Color.LightGreen : Color.LightPink;
            if (ex)
                toolTip.Show("Такой вид деятельности уже существует", textName);
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
