using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace CompStore
{
    public partial class FormService : Form
    {
        Service service;
        List<Record> equipments;
        List<Record> consumables;

        public FormService(Service service)
        {
            InitializeComponent();
            this.service = service;

            equipments = DB.Load("equipments");
            comboEquipment.DataSource = equipments;
            comboEquipment.DisplayMember = "nameINText";
            comboEquipment.ValueMember = "ID";
            comboEquipment.SelectedValue = service.equipment;

            consumables = DB.Load("consumables");
            comboCon.DataSource = consumables;
            comboCon.DisplayMember = "nameText";
            comboCon.ValueMember = "ID";
            comboCon.SelectedValue = service.consumable;

            if (service.nameText != null)
                Text = "Редактирование обслуживания \"" + service.nameText + "\"";
            else
                Text = "Добавление нового обслуживания";

            EquipmentSelect(null, null);
        }

        private void EquipmentSelect(object sender, EventArgs e)
        {
            try
            {
                int i = comboEquipment.SelectedValue != null ? (int)comboEquipment.SelectedValue : 0;
                Equipment t = (Equipment)equipments.Find(o => o.ID == i);
                checkPrinter.Enabled = t != null ? t.printer : false;
                checkPrinter.Checked = false;
                buttonOK.Enabled = comboEquipment.SelectedIndex >= 0;
            }
            catch { }
        }

        private void PrinterCheck(object sender, EventArgs e)
        {
            textCount.Enabled = checkPrinter.Checked;
            textCount.Text = "";
        }

        private void OK(object sender, EventArgs e)
        {
            service.equipment = comboEquipment.SelectedValue != null ? (int)comboEquipment.SelectedValue : 0;
            service.consumable = comboCon.SelectedValue != null ? (int)comboCon.SelectedValue : 0;
            DialogResult = DialogResult.OK;
        }

    }
}
