using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace CompStore
{
    public partial class FormUser : Form
    {
        List<string> names;
        User user;

        public FormUser(User user)
        {
            InitializeComponent();
            this.user = user;
            names = DB.NamesLoad("users");
            string name = user.f + "‼" + user.i + "‼" + user.o;
            if (name != "‼‼") names.Remove(name);

            if (user.empDate < dateEmp.MinDate) user.empDate = DateTime.Now;
            if (user.disDate < dateDis.MinDate) user.disDate = DateTime.Now;

            textF.DataBindings.Add("Text", user, "f");
            
            textI.DataBindings.Add("Text", user, "i");
            
            textO.DataBindings.Add("Text", user, "o");

            comboPost.DataSource = DB.PostsLoad();
            comboPost.DisplayMember = "name";
            comboPost.ValueMember = "ID";
            comboPost.SelectedValue = user.post;

            comboDep.DataSource = DB.DepsLoad();
            comboDep.DisplayMember = "name";
            comboDep.ValueMember = "ID";
            comboDep.SelectedValue = user.dep;

            comboRoom.DataSource = DB.RoomsLoad();
            comboRoom.DisplayMember = "nameText";
            comboRoom.ValueMember = "ID";
            comboRoom.SelectedValue = user.room;

            checkEmp.DataBindings.Add("Checked", user, "emp");
            dateEmp.DataBindings.Add("Value", user, "empDate");
            dateEmp.DataBindings.Add("Enabled", checkEmp, "Checked");
            
            checkDis.DataBindings.Add("Checked", user, "dis");
            dateDis.DataBindings.Add("Value", user, "disDate");
            dateDis.DataBindings.Add("Enabled", checkDis, "Checked");

            textCom.DataBindings.Add("Text", user, "comment");

            if (user.nameText != null)
                Text = "Редактирование сотрудника \"" + user.nameText + "\"";
            else
                Text = "Добавление нового сотрудника";
            CheckField(null, null);
        }

        private void CheckField(object sender, EventArgs e)
        {
            bool ex = names.Find(o => o == textF.Text + "‼" + textI.Text + "‼" + textO.Text) != null;

            textF.BackColor = textF.Text != "" & !ex ? Color.LightGreen : Color.LightPink;
            textI.BackColor = textI.Text != "" & !ex ? Color.LightGreen : Color.LightPink;
            textO.BackColor = textO.Text != "" & !ex ? Color.LightGreen : Color.LightPink;
            if (ex)
                toolTip.Show("Такой сотрудник уже существует", textF);
            else
                toolTip.Hide(textF);

            buttonOK.Enabled = textF.Text != "" | textI.Text != "" | textO.Text != "";
        }

        private void OK(object sender, EventArgs e)
        {
            user.post = comboPost.SelectedValue != null  ? (int)comboPost.SelectedValue : 0;
            user.dep = comboDep.SelectedValue != null ? (int)comboDep.SelectedValue : 0;
            user.room = comboRoom.SelectedValue != null ? (int)comboRoom.SelectedValue : 0;
            DialogResult = DialogResult.OK;
        }
    }
}
