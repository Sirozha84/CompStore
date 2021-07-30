using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace CompStore
{
    public partial class FormPost : Form
    {
        List<string> names;

        public FormPost(Post post)
        {
            InitializeComponent();
            names = DB.NamesLoad("posts");
            if (post.name != "") names.Remove(post.name);

            textName.DataBindings.Add("Text", post, "name");
            
            if (post.name != null)
                Text = "Редактирование должности \"" + post.name + "\"";
            else
                Text = "Добавление новой должности";
            CheckField(null, null);
        }

        private void CheckField(object sender, EventArgs e)
        {
            bool en = textName.Text != "";
            bool ex = names.Find(o => o == textName.Text) != null;

            textName.BackColor = en & !ex ? Color.LightGreen : Color.LightPink;
            if (ex)
                toolTip.Show("Такая должность уже существует", textName);
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
