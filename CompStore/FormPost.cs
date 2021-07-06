using System;
using System.Windows.Forms;

namespace CompStore
{
    public partial class FormPost : Form
    {
        public FormPost(Post post)
        {
            InitializeComponent();
            textName.DataBindings.Add("Text", post, "name");
            if (post.name != null)
                Text = "Редактирование должности \"" + post.name + "\"";
            else
                Text = "Добавление новой должности";
        }

        private void OK(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }
    }
}
