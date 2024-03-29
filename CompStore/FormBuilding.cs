﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace CompStore
{
    public partial class FormBuilding : Form
    {
        Building building;
        List<string> names;

        public FormBuilding(Building building)
        {
            InitializeComponent();
            this.building = building;
            names = DB.NamesLoad("buildings");
            if (building.name != "") names.Remove(building.filial.ToString() + "‼" + building.name);

            comboFilial.DataSource = DB.Load("filials");
            comboFilial.DisplayMember = "nameText";
            comboFilial.ValueMember = "ID";
            comboFilial.SelectedValue = building.filial;
            
            textName.DataBindings.Add("Text", building, "name");
            
            textCom.DataBindings.Add("Text", building, "comment");

            if (building.name != null)
                Text = "Редактирование здания \"" + building.name + "\"";
            else
                Text = "Добавление нового здания";
            CheckField(null, null);
        }

        private void CheckField(object sender, EventArgs e)
        {
            bool en = comboFilial.SelectedIndex >= 0 & textName.Text != "";
            bool ex = names.Find(o => o == Filial() + "‼" + textName.Text) != null;

            textName.BackColor = en & !ex ? Color.LightGreen : Color.LightPink;
            if (ex)
                toolTip.Show("Такое здание уже существует в выбранном филиале", textName);
            else
                toolTip.Hide(textName);

            buttonOK.Enabled = en;
        }

        private void OK(object sender, EventArgs e)
        {
            building.filial = Filial();
            DialogResult = DialogResult.OK;
        }

        int Filial()
        {
            return comboFilial.SelectedValue != null & comboFilial.Text != "CompStore.Filial" ? (int)comboFilial.SelectedValue : 0;
        }

        private void FilialAdd(object sender, EventArgs e)
        {
            Record filial = new Filial();
            FormFilial form = new FormFilial((Filial)filial);
            if (form.ShowDialog() == DialogResult.OK)
            {
                DB.Add("filials", filial);
                List<Record> filials = DB.Load("filials");
                comboFilial.DataSource = filials;
                int max = 0;
                foreach (Filial f in filials)
                    if (max < f.ID) max = f.ID;
                comboFilial.SelectedValue = max;
            }
        }
    }
}
