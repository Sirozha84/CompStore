using System;
using System.Windows.Forms;

namespace CompStore
{
    public partial class FormUser : Form
    {
        User user;

        public FormUser(User user)
        {
            InitializeComponent();
            this.user = user;

            textF.Text = user.f;
            textI.Text = user.i;
            textO.Text = user.o;
            
            comboPost.DataSource = DB.PostsLoad();
            comboPost.DisplayMember = "name";
            comboPost.ValueMember = "ID";
            if (user.post != 0) comboPost.SelectedValue = user.post; else comboPost.SelectedValue = "";
            
            comboDep.DataSource = DB.DepsLoad();
            comboDep.DisplayMember = "name";
            comboDep.ValueMember = "ID";
            if (user.dep != 0) comboDep.SelectedValue = user.dep; else comboDep.SelectedValue = "";
            
            comboFilial.DataSource = DB.FilialsLoad();
            comboFilial.DisplayMember = "name";
            comboFilial.ValueMember = "ID";
            if (user.filial != 0) comboFilial.SelectedValue = user.filial; else comboFilial.SelectedValue = "";
            
            FilialSelect(null, null);
            comboBuilding.DisplayMember = "name";
            comboBuilding.ValueMember = "ID";
            if (user.building != 0) comboBuilding.SelectedValue = user.building; else comboBuilding.SelectedValue = "";
            
            BuildingSelect(null, null);
            comboRoom.DisplayMember = "name";
            comboRoom.ValueMember = "ID";
            if (user.room != 0) comboRoom.SelectedValue = user.room; else comboRoom.SelectedValue = "";
            
            dateEmp.Checked = user.emp;
            dateEmp.Value = user.emp ? user.empDate : DateTime.Now;
            dateDis.Checked = user.dis;
            dateDis.Value = user.dis ? user.disDate : DateTime.Now;
            textCom.Text = user.comment;

            if (user.fioText != null)
                Text = "Редактирование сотрудника \"" + user.fioText + "\"";
            else
                Text = "Добавление нового сотрудника";

        }

        private void OK(object sender, EventArgs e)
        {
            user.f = textF.Text;
            user.i = textI.Text;
            user.o = textO.Text;
            if (comboPost.SelectedValue != null) user.post = (int)comboPost.SelectedValue;
            if (comboDep.SelectedValue != null) user.dep = (int)comboDep.SelectedValue;
            if (comboFilial.SelectedValue != null) user.filial = (int)comboFilial.SelectedValue;
            if (comboBuilding.SelectedValue != null) user.building = (int)comboBuilding.SelectedValue;
            if (comboRoom.SelectedValue != null) user.room = (int)comboRoom.SelectedValue;
            user.emp = dateEmp.Checked;
            user.empDate = dateEmp.Value;
            user.dis = dateDis.Checked;
            user.disDate = dateDis.Value;
            user.comment = textCom.Text;
            DialogResult = DialogResult.OK;
        }

        private void FilialSelect(object sender, EventArgs e)
        {
            if (comboFilial.SelectedValue is int)
                comboBuilding.DataSource = DB.BuildingsLoad(comboFilial.SelectedValue.ToString());
        }

        private void BuildingSelect(object sender, EventArgs e)
        {
            if (comboBuilding.SelectedValue is int)
                comboRoom.DataSource = DB.RoomsLoad(comboBuilding.SelectedValue.ToString());
        }
    }
}
