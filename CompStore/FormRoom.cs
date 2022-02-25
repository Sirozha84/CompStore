using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
namespace CompStore
{
    public partial class FormRoom : Form
    {
        Room room;
        List<string> names;

        public FormRoom(Room room)
        {
            InitializeComponent();
            this.room = room;
            names = DB.NamesLoad("rooms");
            if (room.name != "") names.Remove(room.building.ToString()+"‼"+ room.name);

            comboBuilding.DataSource = DB.Load("buildings");
            comboBuilding.DisplayMember = "nameText";
            comboBuilding.ValueMember = "ID";
            comboBuilding.SelectedValue = room.building;
            
            textName.DataBindings.Add("Text", room, "name");
            
            textCom.DataBindings.Add("Text", room, "comment");

            if (room.name != null)
                Text = "Редактирование помещения \"" + room.name + "\"";
            else
                Text = "Добавление нового помещения";
            CheckField(null, null);
        }

        private void CheckField(object sender, EventArgs e)
        {
            bool en = comboBuilding.SelectedIndex >= 0 & textName.Text != "";
            bool ex = names.Find(o => o == Build()+"‼"+ textName.Text) != null;
            
            textName.BackColor = en & !ex ? Color.LightGreen : Color.LightPink;
            if (ex)
                toolTip.Show("Такое помещение уже существует в выбранном здании", textName);
            else
                toolTip.Hide(textName);

            buttonOK.Enabled = en;
        }

        private void OK(object sender, EventArgs e) 
        {
            room.building = Build();
            DialogResult = DialogResult.OK; 
        }

        int Build()
        {
            return comboBuilding.SelectedValue != null & comboBuilding.Text!="CompStore.Building" ? (int)comboBuilding.SelectedValue : 0;
        }

        private void BuildingAddAdd(object sender, EventArgs e)
        {
            Building building = new Building();
            FormBuilding form = new FormBuilding(building);
            if (form.ShowDialog() == DialogResult.OK)
            {
                DB.Add("buildings",building);
                List<Record> buildings = DB.Load("buildings");
                comboBuilding.DataSource = buildings;
                int max = 0;
                foreach (Building b in buildings)
                    if (max < b.ID) max = b.ID;
                comboBuilding.SelectedValue = max;
            }
        }
    }
}
