using System;
using System.Windows.Forms;

namespace CompStore
{
    public partial class FormUser : Form
    {
        public FormUser(User user)
        {
            InitializeComponent();

            if (user.empDate < dateEmp.MinDate) user.empDate = DateTime.Now;
            if (user.disDate < dateDis.MinDate) user.disDate = DateTime.Now;

            textF.DataBindings.Add("Text", user, "f");
            
            textI.DataBindings.Add("Text", user, "i");
            
            textO.DataBindings.Add("Text", user, "o");

            comboPost.DataSource = DB.PostsLoad();
            comboPost.DisplayMember = "name";
            comboPost.ValueMember = "ID";
            comboPost.DataBindings.Add("SelectedValue", user, "post");

            comboDep.DataSource = DB.DepsLoad();
            comboDep.DisplayMember = "name";
            comboDep.ValueMember = "ID";
            comboDep.DataBindings.Add("SelectedValue", user, "dep");

            comboRoom.DataSource = DB.RoomsLoad();
            comboRoom.DisplayMember = "nameText";
            comboRoom.ValueMember = "ID";
            comboRoom.DataBindings.Add("SelectedValue", user, "room");

            dateEmp.DataBindings.Add("Value", user, "empDate"); //Если сделать сначала чекед, потом время, то чекед всегда тру.
            dateEmp.DataBindings.Add("Checked", user, "emp");   //Наверное активируется при изменении значения времени.
            
            dateDis.DataBindings.Add("Value", user, "disDate");
            dateDis.DataBindings.Add("Checked", user, "dis");

            textCom.DataBindings.Add("Text", user, "comment");

            if (user.nameText != null)
                Text = "Редактирование сотрудника \"" + user.nameText + "\"";
            else
                Text = "Добавление нового сотрудника";
        }

        private void OK(object sender, EventArgs e)
        {
            if (comboPost.SelectedValue != null) comboPost.DataBindings[0].WriteValue();
            if (comboDep.SelectedValue != null) comboDep.DataBindings[0].WriteValue();
            if (comboRoom.SelectedValue != null) comboRoom.DataBindings[0].WriteValue();
            DialogResult = DialogResult.OK;
        }
    }
}
