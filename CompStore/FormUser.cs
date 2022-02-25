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

            comboDep.DataSource = DB.Load("deps");
            comboDep.DisplayMember = "name";
            comboDep.ValueMember = "ID";
            comboDep.SelectedValue = user.dep;

            comboRoom.DataSource = DB.Load("rooms");
            comboRoom.DisplayMember = "nameText";
            comboRoom.ValueMember = "ID";
            comboRoom.SelectedValue = user.room;

            dateEmp.Checked = user.emp;
            dateEmp.Value = user.empDate;

            dateDis.Checked = user.dis;
            dateDis.Value = user.disDate;

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
            user.post = comboPost.SelectedValue != null ? (int)comboPost.SelectedValue : 0;
            user.dep = comboDep.SelectedValue != null ? (int)comboDep.SelectedValue : 0;
            user.room = comboRoom.SelectedValue != null ? (int)comboRoom.SelectedValue : 0;
            user.emp = dateEmp.Checked;
            user.empDate = dateEmp.Value;
            user.dis = dateDis.Checked;
            user.disDate = dateDis.Value;
            DialogResult = DialogResult.OK;
        }

        private void PostAdd(object sender, EventArgs e)
        {
            Post post = new Post();
            FormPost form = new FormPost(post);
            if (form.ShowDialog() == DialogResult.OK)
            {
                DB.PostAdd(post);
                List<Post> postds = DB.PostsLoad();
                comboPost.DataSource = postds;
                int max = 0;
                foreach (Post f in postds)
                    if (max < f.ID) max = f.ID;
                comboPost.SelectedValue = max;
            }
        }

        private void DepAdd(object sender, EventArgs e)
        {
            Dep dep = new Dep();
            FormDep form = new FormDep(dep);
            if (form.ShowDialog() == DialogResult.OK)
            {
                DB.Add("deps", dep);
                List<Record> depds = DB.Load("deps");
                comboDep.DataSource = depds;
                int max = 0;
                foreach (Dep f in depds)
                    if (max < f.ID) max = f.ID;
                comboDep.SelectedValue = max;
            }
        }

        private void RoomAdd(object sender, EventArgs e)
        {
            Room room = new Room();
            FormRoom form = new FormRoom(room);
            if (form.ShowDialog() == DialogResult.OK)
            {
                DB.Add("rooms", room);
                List<Record> rooms = DB.Load("rooms");
                comboRoom.DataSource = rooms;
                int max = 0;
                foreach (Room f in rooms)
                    if (max < f.ID) max = f.ID;
                comboRoom.SelectedValue = max;
            }
        }
    }
}
