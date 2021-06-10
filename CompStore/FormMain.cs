using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;

namespace CompStore
{
    public partial class FormMain : Form
    {
        const string FileDB = @"c:\Users\sgordeev\Desktop\Test.db";

        public FormMain()
        {
            InitializeComponent();
            treeMenu.ExpandAll();
            //Выбираем вкладку по умолчанию (потом переделать на последнюю активную, например, или какую-то главную)
            treeMenu.SelectedNode = treeMenu.Nodes.Find("nodeFilials", true)[0];

            //
        }

        private void TabChange(object sender, TreeViewEventArgs e)
        {
            panelFilials.Visible = treeMenu.SelectedNode.Name == "nodeFilials";
            panelUsers.Visible = treeMenu.SelectedNode.Name == "nodeUsers";
            panelEquipment.Visible = treeMenu.SelectedNode.Name == "nodeEquipment";
        }

        #region Инициализация базы данных
        private void инициализацияToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SQLiteConnection.CreateFile(FileDB);
            using (SQLiteConnection connect = new SQLiteConnection("DataSource=" + FileDB + "; Version=3;"))
            {
                string comText = "CREATE TABLE IF NOT EXISTS [Филиалы] ( " +
                    "[ID] INTEGER PRIMARY KEY AUTOINCREMENT NOT NULL, " +
                    "[Название] TEXT, " +
                    "[Адрес] TEXT, " +
                    "[Примечание] TEXT)";
                SQLiteCommand com = new SQLiteCommand(comText, connect);
                connect.Open();
                com.ExecuteNonQuery();
                connect.Close();
            }
        }
        #endregion

        #region Филиалы
        List<Filial> filials = new List<Filial>();

        private void panelFilials_VisibleChanged(object sender, EventArgs e)
        {
            if (!panelFilials.Visible) return;
            //Потом проверить почему это событие вызывается два раза
            FilialsRefresh();
            FilialsSelChange(null, null);
        }

        void FilialsRefresh()
        {
            filials.Clear();
            listFilials.BeginUpdate();
            listFilials.Items.Clear();
            using (SQLiteConnection connect = new SQLiteConnection("DataSource=" + FileDB + "; Version=3;"))
            {
                connect.Open();
                string comText = "SELECT * FROM [Филиалы]";
                SQLiteCommand com = new SQLiteCommand(comText, connect);
                using (SQLiteDataReader reader = com.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Filial filial = new Filial();
                        filial.ID = reader.GetInt32(0);
                        filial.name = reader.GetString(1);
                        filial.adress = reader.GetString(2);
                        filial.comment = reader.GetString(3);
                        filials.Add(filial);
                        listFilials.Items.Add(filial.ToListView());
                    }
                }
                connect.Close();
            }
            listFilials.EndUpdate();
        }

        private void buttonFAdd_Click(object sender, EventArgs e)
        {
            Filial filial = new Filial();
            FormFilial form = new FormFilial(filial);
            if (form.ShowDialog() == DialogResult.OK)
            {
                using (SQLiteConnection connect = new SQLiteConnection("DataSource=" + FileDB + "; Version=3;"))
                {
                    string comText = "INSERT INTO [Филиалы] (Название, Адрес, Примечание) VALUES ('" +
                        filial.name + "', '" +
                        filial.adress + "', '" +
                        filial.comment + "')";
                    SQLiteCommand com = new SQLiteCommand(comText, connect);
                    connect.Open();
                    com.ExecuteNonQuery();
                    connect.Close();
                }
            }
            FilialsRefresh();
        }
        private void FilialsSelChange(object sender, EventArgs e)
        {
            bool sel = listFilials.SelectedIndices.Count > 0;
            buttonFEdit.Enabled = sel;
            buttonFDel.Enabled = sel;
        }

        #endregion
    }
}
