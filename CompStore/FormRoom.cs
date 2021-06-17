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
        public FormRoom(Room room)
        {
            InitializeComponent();
            this.room = room;
            if (room.name != null)
            {
                Text = "Редактирование помещения \"" + room.name + "\"";
                textName.Text = room.name;
                textCom.Text = room.comment;
            }
            else
            {
                Text = "Добавление нового помещения";
            }
        }
        private void buttonOK_Click(object sender, EventArgs e)
        {
            room.name = textName.Text;
            room.comment = textCom.Text;
            DialogResult = DialogResult.OK;
        }
    }
}
