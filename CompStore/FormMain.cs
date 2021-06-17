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
                string comText = "CREATE TABLE IF NOT EXISTS [filials] ( " +
                    "[ID] INTEGER PRIMARY KEY AUTOINCREMENT NOT NULL, " +
                    "[name] TEXT, " +
                    "[adress] TEXT, " +
                    "[comment] TEXT)";
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
            using (SQLiteConnection connect = new SQLiteConnection("DataSource=" + FileDB + "; Version=3;"))
            {
                connect.Open();
                string comText = "SELECT * FROM [filials] ORDER BY [name]";
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
                        //listFilials.Items.Add(filial.ToListView());
                    }
                }
                connect.Close();
            }
            FilialDraw(null, null);
        }

        private void FilialDraw(object sender, EventArgs e)
        {
            listFilials.BeginUpdate();
            listFilials.Items.Clear();
            foreach (Filial filial in filials)
            {
                if (filial.Contains(textFilialFilter.Text))
                    listFilials.Items.Add(filial.ToListView());
            }
            listFilials.EndUpdate();
            FilialsSelChange(null, null);
        }
        private void FilialsSelChange(object sender, EventArgs e)
        {
            bool sel = listFilials.SelectedIndices.Count > 0;
            buttonFEdit.Enabled = sel;
            buttonFDel.Enabled = sel;
        }
        private void buttonFilialResetFilter_Click(object sender, EventArgs e) { textFilialFilter.Text = ""; }

        private void buttonFAdd_Click(object sender, EventArgs e)
        {
            Filial filial = new Filial();
            FormFilial form = new FormFilial(filial);
            if (form.ShowDialog() == DialogResult.OK)
            {
                using (SQLiteConnection connect = new SQLiteConnection("DataSource=" + FileDB + "; Version=3;"))
                {
                    string comText = "INSERT INTO [filials] (name, adress, comment) VALUES ('" +
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

        private void FilialEdit(object sender, EventArgs e)
        {
            if (listFilials.SelectedIndices.Count == 0) return;
            Filial filial = (Filial)listFilials.SelectedItems[0].Tag;
            FormFilial form = new FormFilial(filial);
            if (form.ShowDialog() == DialogResult.OK)
            {
                using (SQLiteConnection connect = new SQLiteConnection("DataSource=" + FileDB + "; Version=3;"))
                {
                    string comText = "UPDATE [filials] SET " +
                        "[name] = '" + filial.name + "', " +
                        "[adress] = '" + filial.adress + "', " +
                        "[comment] = '" + filial.comment + "' WHERE ID = " + filial.ID;
                    SQLiteCommand com = new SQLiteCommand(comText, connect);
                    connect.Open();
                    com.ExecuteNonQuery();
                    connect.Close();
                }
                FilialsRefresh();
            }
        }

        private void FilialDelete(object sender, EventArgs e)
        {
            if (listFilials.SelectedIndices.Count == 0) return;
            Filial filial = (Filial)listFilials.SelectedItems[0].Tag;
            if (MessageBox.Show("Уверены что хотите удалить филиал \"" + filial.name + "\"?",
                "Удаление записи", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                using (SQLiteConnection connect = new SQLiteConnection("DataSource=" + FileDB + "; Version=3;"))
                {
                    string comText = "DELETE FROM [filials] WHERE ID = " + filial.ID;
                    SQLiteCommand com = new SQLiteCommand(comText, connect);
                    connect.Open();
                    com.ExecuteNonQuery();
                    connect.Close();
                }
                FilialsRefresh();
            }
        }
        #endregion

    }
}
