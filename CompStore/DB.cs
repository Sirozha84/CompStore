using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.SQLite;

namespace CompStore
{
    static class DB
    {
        const string dataSource = @"DataSource=c:\Users\sgordeev\Desktop\Test.db; Version=3;";

        public static void Init()
        {
            //SQLiteConnection.CreateFile(FileDB); 
            using (SQLiteConnection connect = new SQLiteConnection(dataSource))
            {
                connect.Open();
                SQLiteCommand com = new SQLiteCommand(connect);

                com.CommandText = "CREATE TABLE IF NOT EXISTS [filials] ( " +
                    "[ID] INTEGER PRIMARY KEY AUTOINCREMENT NOT NULL, " +
                    "[name] TEXT, " +
                    "[adress] TEXT, " +
                    "[comment] TEXT)";
                com.ExecuteNonQuery();

                com.CommandText = "CREATE TABLE IF NOT EXISTS [rooms] ( " +
                    "[ID] INTEGER PRIMARY KEY AUTOINCREMENT NOT NULL, " +
                    "[filial] INTEGER, " +
                    "[name] TEXT, " +
                    "[comment] TEXT)";
                com.ExecuteNonQuery();

                connect.Close();
            }
        }

        #region Филиалы
        public static List<Filial> FilialsLoad()
        {
            List<Filial> filials = new List<Filial>();
            using (SQLiteConnection connect = new SQLiteConnection(dataSource))
            {
                connect.Open();
                SQLiteCommand com = new SQLiteCommand(connect);
                com.CommandText = "SELECT * FROM [filials] ORDER BY [name]";
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
                    }
                }
                connect.Close();
            }
            return filials;
        }

        public static void FilialAdd(Filial filial)
        {
            using (SQLiteConnection connect = new SQLiteConnection(dataSource))
            {
                connect.Open();
                SQLiteCommand com = new SQLiteCommand(connect);
                com.CommandText = "INSERT INTO [filials] (name, adress, comment) VALUES ('" +
                    filial.name + "', '" +
                    filial.adress + "', '" +
                    filial.comment + "')";
                com.ExecuteNonQuery();
                connect.Close();
            }
        }

        public static void FilialUpdate(Filial filial)
        {
            using (SQLiteConnection connect = new SQLiteConnection(dataSource))
            {
                connect.Open();
                SQLiteCommand com = new SQLiteCommand(connect);
                com.CommandText = "UPDATE [filials] SET " +
                    "[name] = '" + filial.name + "', " +
                    "[adress] = '" + filial.adress + "', " +
                    "[comment] = '" + filial.comment + "' WHERE ID = " + filial.ID;
                com.ExecuteNonQuery();
                connect.Close();
            }
        }

        public static void FilialDelete(Filial filial)
        {
            using (SQLiteConnection connect = new SQLiteConnection(dataSource))
            {
                connect.Open();
                SQLiteCommand com = new SQLiteCommand(connect);
                com.CommandText = "DELETE FROM [filials] WHERE ID = " + filial.ID;
                com.ExecuteNonQuery();
                connect.Close();
            }
        }
        #endregion
        
        #region Помещения
        public static List<Room> RoomsLoad()
        {
            List<Room> rooms = new List<Room>();
            List<Filial> filials = FilialsLoad();
            using (SQLiteConnection connect = new SQLiteConnection(dataSource))
            {
                connect.Open();
                SQLiteCommand com = new SQLiteCommand(connect);
                com.CommandText = "SELECT * FROM [rooms] ORDER BY [name]";
                using (SQLiteDataReader reader = com.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Room room = new Room();
                        room.ID = reader.GetInt32(0);
                        room.filial = reader.GetInt32(1);
                        Filial f = filials.Find(o => o.ID == room.filial);
                        room.filialText = f != null ? f.name : "";
                        room.name = reader.GetString(2);
                        room.comment = reader.GetString(3);
                        rooms.Add(room);
                    }
                }
                connect.Close();
            }
            return rooms;
        }
        public static void RoomAdd(Room room)
        {
            using (SQLiteConnection connect = new SQLiteConnection(dataSource))
            {
                connect.Open();
                SQLiteCommand com = new SQLiteCommand(connect);
                com.CommandText = "INSERT INTO [rooms] (filial, name, comment) VALUES ('" +
                    room.filial + "', '" +
                    room.name + "', '" +
                    room.comment + "')";
                com.ExecuteNonQuery();
                connect.Close();
            }
        }
        public static void RoomUpdate(Room room)
        {
            using (SQLiteConnection connect = new SQLiteConnection(dataSource))
            {
                connect.Open();
                SQLiteCommand com = new SQLiteCommand(connect);
                com.CommandText = "UPDATE [rooms] SET " +
                    "[filial] = '" + room.filial + "', " +
                    "[name] = '" + room.name + "', " +
                    "[comment] = '" + room.comment + "' WHERE ID = " + room.ID;
                com.ExecuteNonQuery();
                connect.Close();
            }
        }

        public static void RoomDelete(Room room)
        {
            using (SQLiteConnection connect = new SQLiteConnection(dataSource))
            {
                connect.Open();
                SQLiteCommand com = new SQLiteCommand(connect);
                com.CommandText = "DELETE FROM [rooms] WHERE ID = " + room.ID;
                com.ExecuteNonQuery();
                connect.Close();
            }
        }
        #endregion
    }
}
