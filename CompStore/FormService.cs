using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace CompStore
{
    public partial class FormService : Form
    {
        Service service;
        Equipment equipment;
        List<Record> equipments;
        List<Record> consumables;
        bool isUser;
        public FormService(Service service)
        {
            InitializeComponent();
            this.service = service;
            if (service.date < dateService.MinDate) service.date = DateTime.Now;
            isUser = false;
            
            dateService.DataBindings.Add("Value", service, "date");

            equipments = DB.Load("equipments");
            comboEquipment.DataSource = equipments;
            comboEquipment.DisplayMember = "nameINText";
            comboEquipment.ValueMember = "ID";
            comboEquipment.SelectedValue = service.equipment;

            checkPrinter.Checked = service.work == 2;

            consumables = DB.Load("consumables");
            comboCon.DataSource = consumables;
            comboCon.DisplayMember = "nameText";
            comboCon.ValueMember = "ID";
            comboCon.SelectedValue = service.consumable;

            textCount.DataBindings.Add("Text", service, "counter");

            textCom.DataBindings.Add("Text", service, "comment");

            if (service.nameText != null)
                Text = "Редактирование обслуживания \"" + service.nameText + "\"";
            else
                Text = "Добавление нового обслуживания";

            EquipmentSelect(null, null);
            PrinterCheck(null, null);

            isUser = true;
        }

        private void OK(object sender, EventArgs e)
        {
            service.equipment = comboEquipment.SelectedValue != null ? (int)comboEquipment.SelectedValue : 0;
            service.consumable = comboCon.SelectedValue != null ? (int)comboCon.SelectedValue : 0;
            service.work = checkPrinter.Checked ? 2 : 1;
            DialogResult = DialogResult.OK;
        }

        private void EquipmentSelect(object sender, EventArgs e)
        {
            checkPrinter.Enabled = textCount.Enabled = equipment != null ? equipment.printer : false;
            if (!checkPrinter.Enabled) checkPrinter.Checked = false;
            buttonOK.Enabled = comboEquipment.SelectedIndex >= 0;
            try
            {
                int i = comboEquipment.SelectedValue != null ? (int)comboEquipment.SelectedValue : 0;
                equipment = (Equipment)equipments.Find(o => o.ID == i);
            }
            catch { }
        }

        private void PrinterCheck(object sender, EventArgs e)
        {
            if (!isUser) return;
            if (checkPrinter.Checked)
                comboCon.SelectedValue = equipment != null ? equipment.consumable : 0;
            else
                comboCon.SelectedValue = 0;
        }

        private void EquipmentAdd(object sender, EventArgs e)
        {
            Equipment equipment = new Equipment();
            FormEquipment form = new FormEquipment(equipment);
            if (form.ShowDialog() == DialogResult.OK)
            {
                DB.Add("equipment", equipment);
                List<Record> equipmentds = DB.Load("equipment");
                comboEquipment.DataSource = equipmentds;
                int max = 0;
                foreach (Equipment f in equipmentds)
                    if (max < f.ID) max = f.ID;
                comboEquipment.SelectedValue = max;
            }
        }

        private void ConsumableAdd(object sender, EventArgs e)
        {
            Consumable consumable = new Consumable();
            FormConsumable form = new FormConsumable(consumable);
            if (form.ShowDialog() == DialogResult.OK)
            {
                DB.Add("consumables", consumable);
                List<Record> consumables = DB.Load("consumables");
                comboCon.DataSource = consumables;
                int max = 0;
                foreach (Consumable c in consumables)
                    if (max < c.ID) max = c.ID;
                comboCon.SelectedValue = max;
            }
        }

    }
}
