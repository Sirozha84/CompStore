﻿using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace CompStore
{
    public partial class FormMove : Form
    {
        bool pack;
        Move move;
        List<User> users;

        public FormMove(Move move, bool pack)
        {
            InitializeComponent();
            this.move = move;
            this.pack = pack;

            if (move.date < dateMove.MinDate) move.date = DateTime.Now;

            comboEquipment.DataSource = DB.EquipmentsLoad();
            comboEquipment.DisplayMember = "nameINText";
            comboEquipment.ValueMember = "ID";
            comboEquipment.SelectedValue = move.equipment;
            comboEquipment.Enabled = !pack;
            

            users = DB.UsersLoad();
            comboUser.DataSource = users;
            comboUser.DisplayMember = "nameText";
            comboUser.ValueMember = "ID";
            comboUser.SelectedValue = move.user;

            comboRoom.DataSource = DB.RoomsLoad();
            comboRoom.DisplayMember = "nameText";
            comboRoom.ValueMember = "ID";
            comboRoom.SelectedValue = move.room;

            dateMove.DataBindings.Add("Value", move, "date");

            textCom.DataBindings.Add("Text", move, "comment");

            if (move.eqText != null)
                Text = "Редактирование перемещения \"" + move.eqText + "\"";
            else
                Text = pack ? "Перемещение объектов" : "Добавление нового перемещения";
        }

        private void UserSelect(object sender, EventArgs e)
        {
            try
            {
                comboRoom.SelectedValue = users.Find(o => o.ID == (int)comboUser.SelectedValue).room;
                EnterCheck(null, null);
            }
            catch { }
        }

        private void EnterCheck(object sender, EventArgs e)
        {
            buttonOK.Enabled = (pack | comboEquipment.SelectedIndex >= 0) & 
                               comboUser.SelectedIndex >= 0;
        }

        private void OK(object sender, EventArgs e)
        {
            move.equipment = pack ? 0 : (int)comboEquipment.SelectedValue;
            move.user = (int)comboUser.SelectedValue;
            move.room = (int)comboRoom.SelectedValue;
            DialogResult = DialogResult.OK;
        }

        private void EquipmentAdd(object sender, EventArgs e)
        {
            Equipment equipment = new Equipment();
            FormEquipment form = new FormEquipment(equipment);
            if (form.ShowDialog() == DialogResult.OK)
            {
                DB.EquipmentAdd(equipment);
                List<Equipment> equipmentds = DB.EquipmentsLoad();
                comboEquipment.DataSource = equipmentds;
                int max = 0;
                foreach (Equipment f in equipmentds)
                    if (max < f.ID) max = f.ID;
                comboEquipment.SelectedValue = max;
            }
        }

        private void UserAdd(object sender, EventArgs e)
        {
            User user = new User();
            FormUser form = new FormUser(user);
            if (form.ShowDialog() == DialogResult.OK)
            {
                DB.UserAdd(user);
                users = DB.UsersLoad();
                comboUser.DataSource = users;
                comboRoom.DataSource = DB.RoomsLoad();
                int max = 0;
                foreach (User f in users)
                    if (max < f.ID) max = f.ID;
                comboUser.SelectedValue = max;
            }
        }

        private void RoomAdd(object sender, EventArgs e)
        {
            Room room = new Room();
            FormRoom form = new FormRoom(room);
            if (form.ShowDialog() == DialogResult.OK)
            {
                DB.RoomAdd(room);
                List<Room> roomds = DB.RoomsLoad();
                comboRoom.DataSource = roomds;
                int max = 0;
                foreach (Room f in roomds)
                    if (max < f.ID) max = f.ID;
                comboRoom.SelectedValue = max;
            }
        }
    }
}
