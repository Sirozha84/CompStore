using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CompStore
{
    public partial class FormRoom : Form
    {
        Room room;
        List<Filial> filials;
        public FormRoom(Room room)
        {
            InitializeComponent();
            this.room = room;
            
            filials = DB.FilialsLoad();
            comboFilial.DataSource = filials;
            comboFilial.DisplayMember = "name";
            comboFilial.ValueMember = "ID";

            if (room.name != null)
            {
                Text = "Редактирование помещения \"" + room.name + "\"";
                comboFilial.SelectedValue = room.filial;
                textName.Text = room.name;
                textCom.Text = room.comment;
            }
            else
            {
                comboFilial.SelectedValue = "";
                Text = "Добавление нового помещения";
            }
        }
        private void buttonOK_Click(object sender, EventArgs e)
        {
            try
            {
                room.filial = (int)comboFilial.SelectedValue;
                if (textName.Text == "") throw new Exception();
                room.name = textName.Text;
                room.comment = textCom.Text;
                DialogResult = DialogResult.OK;
            }
            catch
            {
                MessageBox.Show("Не все необходимые поля заполнены!");
            }
        }
    }
}
