using System;
using System.Windows.Forms;

namespace CompStore
{
    public partial class FormModel : Form
    {
        public FormModel(Model model)
        {
            InitializeComponent();

            comboEqType.DataSource = DB.EqTypesLoad();
            comboEqType.DisplayMember = "name";
            comboEqType.ValueMember = "ID";
            comboEqType.DataBindings.Add("SelectedValue", model, "eqType");

            comboBrand.DataSource = DB.BrandsLoad();
            comboBrand.DisplayMember = "name";
            comboBrand.ValueMember = "ID";
            comboBrand.DataBindings.Add("SelectedValue", model, "brand");

            textName.DataBindings.Add("Text", model, "name");

            textCom.DataBindings.Add("Text", model, "comment");

            if (model.name != null)
                Text = "Редактирование модели \"" + model.name + "\"";
            else
                Text = "Добавление новой модели";
        }

        private void OK(object sender, EventArgs e)
        {
            comboEqType.DataBindings[0].WriteValue();
            comboBrand.DataBindings[0].WriteValue();    //А вот тут, почему-то, данные не пишутся если крутить колесом!!!!!
            DialogResult = DialogResult.OK;
        }
    }
}
