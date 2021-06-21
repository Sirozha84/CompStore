using System.Collections.Generic;
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

                com.CommandText = "CREATE TABLE IF NOT EXISTS [posts] ( " +
                    "[ID] INTEGER PRIMARY KEY AUTOINCREMENT NOT NULL, " +
                    "[name] TEXT)";
                com.ExecuteNonQuery();

                com.CommandText = "CREATE TABLE IF NOT EXISTS [deps] ( " +
                    "[ID] INTEGER PRIMARY KEY AUTOINCREMENT NOT NULL, " +
                    "[name] TEXT, " +
                    "[comment] TEXT)";
                com.ExecuteNonQuery();

                com.CommandText = "CREATE TABLE IF NOT EXISTS [buildings] ( " +
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
                com.CommandText = "SELECT * FROM [rooms] ORDER BY [filial], [name]";
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

        #region Должности
        public static List<Post> PostsLoad()
        {
            List<Post> posts = new List<Post>();
            using (SQLiteConnection connect = new SQLiteConnection(dataSource))
            {
                connect.Open();
                SQLiteCommand com = new SQLiteCommand(connect);
                com.CommandText = "SELECT * FROM [posts] ORDER BY [name]";
                using (SQLiteDataReader reader = com.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Post post = new Post();
                        post.ID = reader.GetInt32(0);
                        post.name = reader.GetString(1);
                        posts.Add(post);
                    }
                }
                connect.Close();
            }
            return posts;
        }
        public static void PostAdd(Post post)
        {
            using (SQLiteConnection connect = new SQLiteConnection(dataSource))
            {
                connect.Open();
                SQLiteCommand com = new SQLiteCommand(connect);
                com.CommandText = "INSERT INTO [posts] (name) VALUES ('" + post.name + "')";
                com.ExecuteNonQuery();
                connect.Close();
            }
        }
        public static void PostUpdate(Post post)
        {
            using (SQLiteConnection connect = new SQLiteConnection(dataSource))
            {
                connect.Open();
                SQLiteCommand com = new SQLiteCommand(connect);
                com.CommandText = "UPDATE [posts] SET " + "[name] = '" + post.name + "' WHERE ID = " + post.ID;
                com.ExecuteNonQuery();
                connect.Close();
            }
        }

        public static void PostDelete(Post post)
        {
            using (SQLiteConnection connect = new SQLiteConnection(dataSource))
            {
                connect.Open();
                SQLiteCommand com = new SQLiteCommand(connect);
                com.CommandText = "DELETE FROM [posts] WHERE ID = " + post.ID;
                com.ExecuteNonQuery();
                connect.Close();
            }
        }
        #endregion

        #region Отделы
        public static List<Dep> DepsLoad()
        {
            List<Dep> deps = new List<Dep>();
            using (SQLiteConnection connect = new SQLiteConnection(dataSource))
            {
                connect.Open();
                SQLiteCommand com = new SQLiteCommand(connect);
                com.CommandText = "SELECT * FROM [deps] ORDER BY [name]";
                using (SQLiteDataReader reader = com.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Dep dep = new Dep();
                        dep.ID = reader.GetInt32(0);
                        dep.name = reader.GetString(1);
                        dep.comment = reader.GetString(2);
                        deps.Add(dep);
                    }
                }
                connect.Close();
            }
            return deps;
        }

        public static void DepAdd(Dep dep)
        {
            using (SQLiteConnection connect = new SQLiteConnection(dataSource))
            {
                connect.Open();
                SQLiteCommand com = new SQLiteCommand(connect);
                com.CommandText = "INSERT INTO [deps] (name, comment) VALUES ('" +
                    dep.name + "', '" +
                    dep.comment + "')";
                com.ExecuteNonQuery();
                connect.Close();
            }
        }

        public static void DepUpdate(Dep dep)
        {
            using (SQLiteConnection connect = new SQLiteConnection(dataSource))
            {
                connect.Open();
                SQLiteCommand com = new SQLiteCommand(connect);
                com.CommandText = "UPDATE [deps] SET " +
                    "[name] = '" + dep.name + "', " +
                    "[comment] = '" + dep.comment + "' WHERE ID = " + dep.ID;
                com.ExecuteNonQuery();
                connect.Close();
            }
        }

        public static void DepDelete(Dep dep)
        {
            using (SQLiteConnection connect = new SQLiteConnection(dataSource))
            {
                connect.Open();
                SQLiteCommand com = new SQLiteCommand(connect);
                com.CommandText = "DELETE FROM [deps] WHERE ID = " + dep.ID;
                com.ExecuteNonQuery();
                connect.Close();
            }
        }
        #endregion

        #region Здания
        public static List<Building> BuildingsLoad()
        {
            List<Building> buildings = new List<Building>();
            List<Filial> filials = FilialsLoad();
            using (SQLiteConnection connect = new SQLiteConnection(dataSource))
            {
                connect.Open();
                SQLiteCommand com = new SQLiteCommand(connect);
                com.CommandText = "SELECT * FROM [buildings] ORDER BY [filial], [name]";
                using (SQLiteDataReader reader = com.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Building building = new Building();
                        building.ID = reader.GetInt32(0);
                        building.filial = reader.GetInt32(1);
                        Filial f = filials.Find(o => o.ID == building.filial);
                        building.filialText = f != null ? f.name : "";
                        building.name = reader.GetString(2);
                        building.comment = reader.GetString(3);
                        buildings.Add(building);
                    }
                }
                connect.Close();
            }
            return buildings;
        }
        public static void BuildingAdd(Building building)
        {
            using (SQLiteConnection connect = new SQLiteConnection(dataSource))
            {
                connect.Open();
                SQLiteCommand com = new SQLiteCommand(connect);
                com.CommandText = "INSERT INTO [buildings] (filial, name, comment) VALUES ('" +
                    building.filial + "', '" +
                    building.name + "', '" +
                    building.comment + "')";
                com.ExecuteNonQuery();
                connect.Close();
            }
        }
        public static void BuildingUpdate(Building building)
        {
            using (SQLiteConnection connect = new SQLiteConnection(dataSource))
            {
                connect.Open();
                SQLiteCommand com = new SQLiteCommand(connect);
                com.CommandText = "UPDATE [buildings] SET " +
                    "[filial] = '" + building.filial + "', " +
                    "[name] = '" + building.name + "', " +
                    "[comment] = '" + building.comment + "' WHERE ID = " + building.ID;
                com.ExecuteNonQuery();
                connect.Close();
            }
        }

        public static void BuildingDelete(Building building)
        {
            using (SQLiteConnection connect = new SQLiteConnection(dataSource))
            {
                connect.Open();
                SQLiteCommand com = new SQLiteCommand(connect);
                com.CommandText = "DELETE FROM [buildings] WHERE ID = " + building.ID;
                com.ExecuteNonQuery();
                connect.Close();
            }
        }
        #endregion
    }
}
