using System;
using System.Collections.Generic;
using System.Data.SQLite;

namespace CompStore
{
    static class DB
    {
        const string dataSource = @"DataSource=c:\Users\sgordeev\Desktop\CS.db; Version=3;";
        
        #region Инициализация таблиц
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
                    "[building] INTEGER, " +
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

                com.CommandText = "CREATE TABLE IF NOT EXISTS [users] ( " +
                    "[ID] INTEGER PRIMARY KEY AUTOINCREMENT NOT NULL, " +
                    "[f] TEXT, " +
                    "[i] TEXT, " +
                    "[o] TEXT, " +
                    "[post] INTEGER, " +
                    "[dep] INTEGER, " +
                    "[filial] INTEGER, " +
                    "[building] INTEGER, " +
                    "[room] INTEGER, " +
                    "[emp] BOOLEAN, " +
                    "[empdate] TEXT, " +
                    "[dis] BOOLEAN, " +
                    "[disdate] TEXT, " +
                    "[comment] TEXT)";
                com.ExecuteNonQuery();

                connect.Close();
            }
        }
        #endregion

        #region Филиалы [filials]
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
        
        #region Помещения [rooms]
        public static List<Room> RoomsLoad(string building)
        {
            List<Room> rooms = new List<Room>();
            List<Filial> filials = FilialsLoad();
            List<Building> buildings = BuildingsLoad("");
            using (SQLiteConnection connect = new SQLiteConnection(dataSource))
            {
                connect.Open();
                SQLiteCommand com = new SQLiteCommand(connect);
                com.CommandText = "SELECT * FROM [rooms]" + (building != "" ? " WHERE [building] = " + building : "") + " ORDER BY [filial], [building], [name]";
                using (SQLiteDataReader reader = com.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Room room = new Room();
                        room.ID = reader.GetInt32(0);
                        room.filial = reader.GetInt32(1);
                        Filial f = filials.Find(o => o.ID == room.filial);
                        room.filialText = f != null ? f.name : "";
                        room.building = reader.GetInt32(2);
                        Building b = buildings.Find(o => o.ID == room.building);
                        room.buildingText = b != null ? b.name : "";
                        room.name = reader.GetString(3);
                        room.comment = reader.GetString(4);
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
                com.CommandText = "INSERT INTO [rooms] (filial, building, name, comment) VALUES ('" +
                    room.filial + "', '" +
                    room.building + "', '" +
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
                    "[building] = '" + room.building + "', " +
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

        #region Должности [posts]
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

        #region Отделы [deps]
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

        #region Здания [buildings]
        public static List<Building> BuildingsLoad(string filial)
        {
            List<Building> buildings = new List<Building>();
            List<Filial> filials = FilialsLoad();
            using (SQLiteConnection connect = new SQLiteConnection(dataSource))
            {
                connect.Open();
                SQLiteCommand com = new SQLiteCommand(connect);
                com.CommandText = "SELECT * FROM [buildings]" + (filial != "" ? " WHERE [filial] = " + filial : "") + " ORDER BY [filial], [name]";
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

        #region Сотрудники [users]
        public static List<User> UsersLoad()
        {
            List<User> users = new List<User>();
            List<Post> posts = PostsLoad();
            List<Dep> deps = DepsLoad();
            List<Filial> filials = FilialsLoad();
            List<Building> buildings = BuildingsLoad("");
            List<Room> rooms = RoomsLoad("");
            using (SQLiteConnection connect = new SQLiteConnection(dataSource))
            {
                connect.Open();
                SQLiteCommand com = new SQLiteCommand(connect);
                //com.CommandText = "SELECT * FROM [buildings]" + (filial != "" ? " WHERE [filial] = " + filial : "") + " ORDER BY [filial], [name]";
                com.CommandText = "SELECT * FROM [users] ORDER BY [f], [i], [o]";
                using (SQLiteDataReader reader = com.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        User user = new User();
                        user.ID = reader.GetInt32(0);
                        user.f = reader.GetString(1);
                        user.i = reader.GetString(2);
                        user.o = reader.GetString(3);
                        user.post = reader.GetInt32(4);
                        user.dep = reader.GetInt32(5);
                        user.filial = reader.GetInt32(6);
                        user.building = reader.GetInt32(7);
                        user.room = reader.GetInt32(8);
                        user.emp = (bool)reader.GetValue(9);
                        user.empDate = DateTime.Parse(reader.GetString(10));
                        user.dis = (bool)reader.GetValue(11);
                        user.disDate = DateTime.Parse(reader.GetString(10));
                        user.comment = reader.GetString(13);

                        user.fioText = (user.f != "" ? user.f + " " : "") +
                                       (user.i != "" ? user.i + " " : "") +
                                       (user.o != "" ? user.o : "");

                        Post p = posts.Find(o => o.ID == user.post);
                        user.postText = (p != null ? p.name : "");

                        Dep d = deps.Find(o => o.ID == user.dep);
                        user.depText = (d != null ? d.name : "");

                        Filial f = filials.Find(o => o.ID == user.filial);
                        Building b = buildings.Find(o => o.ID == user.building);
                        Room r = rooms.Find(o => o.ID == user.room);
                        user.roomText = (f != null ? f.name + ", " : "") +
                                        (b != null ? b.name + ", " : "") +
                                        (r != null ? r.name : "");


                        users.Add(user);
                    }
                }
                connect.Close();
            }
            return users;
        }
        public static void UserAdd(User user)
        {
            using (SQLiteConnection connect = new SQLiteConnection(dataSource))
            {
                connect.Open();
                SQLiteCommand com = new SQLiteCommand(connect);
                com.CommandText = "INSERT INTO [users] (f, i, o, post, dep, filial, building, room, " +
                                  "emp, empdate, dis, disdate, comment) VALUES ('" +
                                  user.f + "', '" +
                                  user.i + "', '" +
                                  user.o + "', '" +
                                  user.post + "', '" +
                                  user.dep + "', '" +
                                  user.filial + "', '" +
                                  user.building + "', '" +
                                  user.room + "', '" +
                                  user.emp + "', '" +
                                  user.empDate + "', '" +
                                  user.dis + "', '" +
                                  user.disDate + "', '" +
                                  user.comment + "')";
                com.ExecuteNonQuery();
                connect.Close();
            }
        }
        public static void UserUpdate(User user)
        {
            using (SQLiteConnection connect = new SQLiteConnection(dataSource))
            {
                connect.Open();
                SQLiteCommand com = new SQLiteCommand(connect);
                com.CommandText = "UPDATE [users] SET " +
                                  "[f] = '" + user.f + "', " +
                                  "[i] = '" + user.i + "', " +
                                  "[o] = '" + user.o + "', " +
                                  "[post] = '" + user.post + "', " +
                                  "[dep] = '" + user.dep + "', " +
                                  "[filial] = '" + user.filial + "', " +
                                  "[building] = '" + user.building + "', " +
                                  "[room] = '" + user.room + "', " +
                                  "[emp] = '" + user.emp + "', " +
                                  "[empdate] = '" + user.empDate + "', " +
                                  "[dis] = '" + user.dis + "', " +
                                  "[disdate] = '" + user.disDate + "', " +
                                  "[comment] = '" + user.comment + "' WHERE ID = " + user.ID;
                com.ExecuteNonQuery();
                connect.Close();
            }
        }

        public static void UserDelete(User user)
        {
            using (SQLiteConnection connect = new SQLiteConnection(dataSource))
            {
                connect.Open();
                SQLiteCommand com = new SQLiteCommand(connect);
                com.CommandText = "DELETE FROM [users] WHERE ID = " + user.ID;
                com.ExecuteNonQuery();
                connect.Close();
            }
        }
        #endregion
    }
}
