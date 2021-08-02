using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace CompStore
{
    public partial class FormEquipment : Form
    {
        Equipment equipment;
        List<string> sNs;
        List<string> iNs;

        public FormEquipment(Equipment equipment)
        {
            InitializeComponent();
            this.equipment = equipment;
            sNs = new List<string>();
            iNs = new List<string>();
            DB.NamesLoad("equipments").ForEach(delegate (string nums)
            {
                sNs.Add(nums.Split('‼')[0]);
                iNs.Add(nums.Split('‼')[1]);
            });
            if (equipment.sn != "") sNs.Remove(equipment.sn);
            if (equipment.iN != "") iNs.Remove(equipment.iN);

            if (equipment.buyDate < dateBuy.MinDate) equipment.buyDate = DateTime.Now;

            comboModel.DataSource = DB.ModelsLoad();
            comboModel.DisplayMember = "nameText";
            comboModel.ValueMember = "ID";
            comboModel.SelectedValue = equipment.model;

            textSN.DataBindings.Add("Text", equipment, "sn");

            textIN.DataBindings.Add("Text", equipment, "iN");

            dateBuy.Checked = equipment.buy;
            dateBuy.Value = equipment.buyDate;

            textCom.DataBindings.Add("Text", equipment, "comment");

            if (equipment.nameText != null)
                Text = "Редактирование оборудования \"" + equipment.nameText + "\"";
            else
                Text = "Добавление нового оборудования";
        }

        private void CheckField(object sender, EventArgs e)
        {
            bool ens = textSN.Text != "";
            bool eni = textIN.Text != "";
            bool exs = textSN.Text != "" & sNs.Find(o => o == textSN.Text) != null;
            bool exi = textIN.Text != "" & iNs.Find(o => o == textIN.Text) != null;

            textSN.BackColor = ens & !exs ? Color.LightGreen : Color.LightPink;
            if (exs)
                toolTipS.Show("Такой серийный номер уже существует", textSN);
            else
                toolTipS.Hide(textSN);

            textIN.BackColor = eni & !exi ? Color.LightGreen : Color.LightPink;
            if (exi)
                toolTipI.Show("Такой инвентарный номер уже существует", textIN);
            else
                toolTipI.Hide(textIN);

            buttonOK.Enabled = comboModel.SelectedIndex >= 0 & (textIN.Text != "" | textSN.Text != "");
        }

        private void OK(object sender, EventArgs e)
        {
            equipment.model = comboModel.SelectedValue != null ? (int)comboModel.SelectedValue : 0;
            equipment.buy = dateBuy.Checked;
            equipment.buyDate = dateBuy.Value;
            DialogResult = DialogResult.OK;
        }

        private void ModelAdd(object sender, EventArgs e)
        {
            Model model = new Model();
            FormModel form = new FormModel(model);
            if (form.ShowDialog() == DialogResult.OK)
            {
                DB.ModelAdd(model);
                List<Model> modelds = DB.ModelsLoad();
                comboModel.DataSource = modelds;
                int max = 0;
                foreach (Model f in modelds)
                    if (max < f.ID) max = f.ID;
                comboModel.SelectedValue = max;
            }
        }
    }
}
