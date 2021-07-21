using System;
using System.Windows.Forms;

namespace CompStore
{
    public partial class FormEquipment : Form
    {
        public FormEquipment(Equipment equipment)
        {
            InitializeComponent();

            if (equipment.buyDate < dateBuy.MinDate) equipment.buyDate = DateTime.Now;

            comboModel.DataSource = DB.ModelsLoad();
            comboModel.DisplayMember = "nameText";
            comboModel.ValueMember = "ID";
            comboModel.DataBindings.Add("SelectedValue", equipment, "model");

            textSN.DataBindings.Add("Text", equipment, "sn");

            textIN.DataBindings.Add("Text", equipment, "iN");

            checkBuy.DataBindings.Add("Checked", equipment, "buy");
            dateBuy.DataBindings.Add("Value", equipment, "buyDate");
            dateBuy.DataBindings.Add("Enabled", checkBuy, "Checked");

            textCom.DataBindings.Add("Text", equipment, "comment");

            if (equipment.nameText != null)
                Text = "Редактирование оборудования \"" + equipment.nameText + "\"";
            else
                Text = "Добавление нового оборудования";
        }

        private void OK(object sender, EventArgs e)
        {
            comboModel.DataBindings[0].WriteValue();
            dateBuy.DataBindings[1].WriteValue();
            DialogResult = DialogResult.OK;
        }

    }
}
