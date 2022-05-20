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

            comboModel.DataSource = DB.Load("models");
            comboModel.DisplayMember = "nameText";
            comboModel.ValueMember = "ID";
            comboModel.SelectedValue = equipment.model;

            textSN.DataBindings.Add("Text", equipment, "sn");

            textIN.DataBindings.Add("Text", equipment, "iN");

            checkINV.DataBindings.Add("Checked", equipment, "iNv");

            textMac.DataBindings.Add("Text", equipment, "mac");

            textIP.DataBindings.Add("Text", equipment, "ip");

            textProp.DataBindings.Add("Text", equipment, "prop");

            textPrice.DataBindings.Add("Text", equipment, "price");

            comboProvider.DataSource = DB.Load("providers");
            comboProvider.DisplayMember = "name";
            comboProvider.ValueMember = "ID";
            comboProvider.SelectedValue = equipment.provider;

            dateBuy.Checked = equipment.buy;
            dateBuy.Value = equipment.buyDate;

            dateDec.Checked = equipment.dec;
            dateDec.Value = equipment.decDate;

            checkPrinter.DataBindings.Add("Checked", equipment, "printer");

            comboCon.DataSource = DB.Load("consumables");
            comboCon.DisplayMember = "name";
            comboCon.ValueMember = "ID";
            comboCon.SelectedValue = equipment.consumable;

            textCom.DataBindings.Add("Text", equipment, "comment");

            if (equipment.nameText != null)
                Text = "Редактирование оборудования \"" + equipment.nameText + "\"";
            else
                Text = "Добавление нового оборудования";

            checkPrinterChange(null, null);
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

            checkINV.Enabled = eni;
            buttonOK.Enabled = comboModel.SelectedIndex >= 0 & (textIN.Text != "" | textSN.Text != "");
        }

        private void ModelAdd(object sender, EventArgs e)
        {
            Model model = new Model();
            FormModel form = new FormModel(model);
            if (form.ShowDialog() == DialogResult.OK)
            {
                DB.Add("models", model);
                List<Record> models = DB.Load("models");
                comboModel.DataSource = models;
                int max = 0;
                foreach (Model f in models)
                    if (max < f.ID) max = f.ID;
                comboModel.SelectedValue = max;
            }
        }

        private void ProviderAdd(object sender, EventArgs e)
        {
            Provider provider = new Provider();
            FormProvider form = new FormProvider(provider);
            if (form.ShowDialog() == DialogResult.OK)
            {
                DB.Add("providers", provider);
                List<Record> providers = DB.Load("providers");
                comboProvider.DataSource = providers;
                int max = 0;
                foreach (Provider p in providers)
                    if (max < p.ID) max = p.ID;
                comboProvider.SelectedValue = max;
            }
        }


        private void checkPrinterChange(object sender, EventArgs e)
        {
            labelCon.Enabled = comboCon.Enabled = buttonConAdd.Enabled = checkPrinter.Checked;
        }

        private void ConAdd(object sender, EventArgs e)
        {
            Consumable con = new Consumable();
            FormConsumable form = new FormConsumable(con);
            if (form.ShowDialog() == DialogResult.OK)
            {
                DB.Add("consumables", con);
                List<Record> consumables = DB.Load("consumables");
                comboCon.DataSource = consumables;
                int max = 0;
                foreach (Consumable c in consumables)
                    if (max < c.ID) max = c.ID;
                comboCon.SelectedValue = max;
            }
        }

        private void OK(object sender, EventArgs e)
        {
            equipment.model = comboModel.SelectedValue != null ? (int)comboModel.SelectedValue : 0;
            equipment.buy = dateBuy.Checked;
            equipment.buyDate = dateBuy.Value;
            equipment.provider = comboProvider.SelectedValue != null ? (int)comboProvider.SelectedValue : 0;
            equipment.consumable = comboCon.SelectedValue != null ? (int)comboCon.SelectedValue : 0;
            DialogResult = DialogResult.OK;
        }
    }
}
