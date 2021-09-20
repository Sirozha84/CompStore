﻿using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Globalization;

namespace CompStore
{
    static class DB
    {
        const string dataSource = @"DataSource=CS.db; Version=3;";
        const string ND = "#Н/Д";

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
                    "[type] TEXT, " +
                    "[f] TEXT, " +
                    "[i] TEXT, " +
                    "[o] TEXT, " +
                    "[post] INTEGER, " +
                    "[dep] INTEGER, " +
                    "[room] INTEGER, " +
                    "[emp] TEXT, " +
                    "[empdate] TEXT, " +
                    "[dis] TEXT, " +
                    "[disdate] TEXT, " +
                    "[comment] TEXT)";
                com.ExecuteNonQuery();

                com.CommandText = "CREATE TABLE IF NOT EXISTS [brands] ( " +
                    "[ID] INTEGER PRIMARY KEY AUTOINCREMENT NOT NULL, " +
                    "[name] TEXT, " +
                    "[comment] TEXT)";
                com.ExecuteNonQuery();

                com.CommandText = "CREATE TABLE IF NOT EXISTS [eqtypes] ( " +
                    "[ID] INTEGER PRIMARY KEY AUTOINCREMENT NOT NULL, " +
                    "[name] TEXT)";
                com.ExecuteNonQuery();

                com.CommandText = "CREATE TABLE IF NOT EXISTS [models] ( " +
                    "[ID] INTEGER PRIMARY KEY AUTOINCREMENT NOT NULL, " +
                    "[eqtype] INTEGER, " +
                    "[brand] INTEGER, " +
                    "[name] TEXT, " +
                    "[comment] TEXT)";
                com.ExecuteNonQuery();

                com.CommandText = "CREATE TABLE IF NOT EXISTS [equipments] ( " +
                    "[ID] INTEGER PRIMARY KEY AUTOINCREMENT NOT NULL, " +
                    "[model] INTEGER, " +
                    "[sn] TEXT, " +
                    "[in] TEXT, " +
                    "[inv] TEXT, " +
                    "[mac] TEXT, " +
                    "[ip] TEXT, " +
                    "[prop] TEXT, " +
                    "[buy] TEXT, " +
                    "[buydate] TEXT, " +
                    "[price] TEXT, " +
                    "[provider] INTEGER, " +
                    "[comment] TEXT)";
                com.ExecuteNonQuery();
                
                com.CommandText = "CREATE TABLE IF NOT EXISTS [moves] ( " +
                    "[ID] INTEGER PRIMARY KEY AUTOINCREMENT NOT NULL, " +
                    "[equipment] INTEGER, " +
                    "[user] INTEGER, " +
                    "[room] INTEGER, " +
                    "[date] TEXT, " +
                    "[mol] INTEGER, " +
                    "[comment] TEXT)";
                com.ExecuteNonQuery();

                com.CommandText = "CREATE TABLE IF NOT EXISTS [providers] ( " +
                    "[ID] INTEGER PRIMARY KEY AUTOINCREMENT NOT NULL, " +
                    "[name] TEXT, " +
                    "[adress] TEXT, " +
                    "[phone] TEXT, " +
                    "[manager] TEXT, " +
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
                com.CommandText = "SELECT * FROM filials ORDER BY name";
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
                com.CommandText = "INSERT INTO filials (name, adress, comment) VALUES ('" +
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
                com.CommandText = "UPDATE filials SET " +
                    "name = '" + filial.name + "', " +
                    "adress = '" + filial.adress + "', " +
                    "comment = '" + filial.comment + "' WHERE ID = " + filial.ID;
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
                com.CommandText = "DELETE FROM filials WHERE ID = " + filial.ID;
                com.ExecuteNonQuery();
                connect.Close();
            }
        }
        #endregion
        
        #region Помещения [rooms]
        public static List<Room> RoomsLoad()
        {
            List<Room> rooms = new List<Room>();
            using (SQLiteConnection connect = new SQLiteConnection(dataSource))
            {
                connect.Open();
                SQLiteCommand com = new SQLiteCommand(connect);
                com.CommandText = "SELECT " +
                    "rooms.ID, " +
                    "rooms.building, " +
                    "rooms.name, " +
                    "rooms.comment, " +
                    "filials.name, " +
                    "buildings.name, " +
                    "filials.name || \", зд. \" || buildings.name || \", пом. \" || rooms.name " +
                    "FROM rooms " +
                    "LEFT JOIN buildings ON rooms.building = buildings.ID " +
                    "LEFT JOIN filials ON buildings.filial = filials.ID " +
                    "ORDER BY filials.name, buildings.name, rooms.name";
                using (SQLiteDataReader reader = com.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Room room = new Room();
                        room.ID = reader.GetInt32(0);
                        room.building = reader.GetInt32(1);
                        room.name = reader.GetString(2);
                        room.comment = reader.GetString(3);
                        room.filialText = room.building != 0 ? (!reader.IsDBNull(4) ? reader.GetString(4) : ND) : "";
                        room.buildingText = room.building != 0 ? (!reader.IsDBNull(5) ? reader.GetString(5) : ND) : "";
                        room.nameText = room.building != 0 ? (!reader.IsDBNull(6) ? reader.GetString(6) : ND) : "";
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
                com.CommandText = "INSERT INTO rooms (building, name, comment) VALUES ('" +
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
                com.CommandText = "UPDATE rooms SET " +
                    "building = '" + room.building + "', " +
                    "name = '" + room.name + "', " +
                    "comment = '" + room.comment + "' WHERE ID = " + room.ID;
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
                com.CommandText = "DELETE FROM rooms WHERE ID = " + room.ID;
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
                com.CommandText = "SELECT * FROM posts ORDER BY name";
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
                com.CommandText = "INSERT INTO posts (name) VALUES ('" + post.name + "')";
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
                com.CommandText = "UPDATE posts SET " + "name = '" + post.name + "' WHERE ID = " + post.ID;
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
                com.CommandText = "DELETE FROM posts WHERE ID = " + post.ID;
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
                com.CommandText = "SELECT * FROM deps ORDER BY name";
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
                com.CommandText = "INSERT INTO deps (name, comment) VALUES ('" +
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
                com.CommandText = "UPDATE deps SET " +
                    "name = '" + dep.name + "', " +
                    "comment = '" + dep.comment + "' WHERE ID = " + dep.ID;
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
                com.CommandText = "DELETE FROM deps WHERE ID = " + dep.ID;
                com.ExecuteNonQuery();
                connect.Close();
            }
        }
        #endregion

        #region Здания [buildings]
        public static List<Building> BuildingsLoad()
        {
            List<Building> buildings = new List<Building>();
            using (SQLiteConnection connect = new SQLiteConnection(dataSource))
            {
                connect.Open();
                SQLiteCommand com = new SQLiteCommand(connect);
                com.CommandText = "SELECT buildings.ID, buildings.filial, buildings.name, buildings.comment, " +
                    "filials.name AS filialText, "+
                    "filials.name || \", зд. \" || [buildings].name " +
                    "FROM buildings " +
                    "LEFT JOIN filials ON buildings.filial = filials.ID " +
                    "ORDER BY filials.name, buildings.name";
                using (SQLiteDataReader reader = com.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Building building = new Building();
                        building.ID = reader.GetInt32(0);
                        building.filial = reader.GetInt32(1);
                        building.name = reader.GetString(2);
                        building.comment = reader.GetString(3);
                        building.filialText = building.filial != 0 ? (!reader.IsDBNull(4) ? reader.GetString(4) : ND) : "";
                        building.nameText = building.filial != 0 ? (!reader.IsDBNull(5) ? reader.GetString(5) : ND) : "";
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
                com.CommandText = "INSERT INTO buildings (filial, name, comment) VALUES ('" +
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
                com.CommandText = "UPDATE buildings SET " +
                    "filial = '" + building.filial + "', " +
                    "name = '" + building.name + "', " +
                    "comment = '" + building.comment + "' WHERE ID = " + building.ID;
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
                com.CommandText = "DELETE FROM buildings WHERE ID = " + building.ID;
                com.ExecuteNonQuery();
                connect.Close();
            }
        }
        #endregion

        #region Сотрудники [users]
        public static List<User> UsersLoad()
        {
            List<User> users = new List<User>();
            using (SQLiteConnection connect = new SQLiteConnection(dataSource))
            {
                connect.Open();
                SQLiteCommand com = new SQLiteCommand(connect);
                com.CommandText = "SELECT " +
                    "users.ID, " +
                    "users.f, " +
                    "users.i, " +
                    "users.o, " +
                    "users.post, " +
                    "users.dep, " +
                    "users.room, " +
                    "users.emp, " +
                    "users.empdate, " +
                    "users.dis, " +
                    "users.disdate, " +
                    "users.comment, " +
                    "users.f || \" \" || users.i || \" \" || users.o, " +
                    "posts.name, "+
                    "deps.name, "+
                    "filials.name || \", зд. \" || buildings.name || \", пом. \" || rooms.name " +
                    "FROM users " +
                    "LEFT JOIN posts ON users.post = posts.ID " +
                    "LEFT JOIN deps ON users.dep = deps.ID " +
                    "LEFT JOIN rooms ON users.room = rooms.ID " +
                    "LEFT JOIN buildings ON rooms.building = buildings.ID " +
                    "LEFT JOIN filials ON buildings.filial = filials.ID " +
                    "WHERE users.type = 'u' ORDER BY users.f, users.i, users.o";
;
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
                        user.room = reader.GetInt32(6);
                        user.emp = reader.GetString(7) == "1";
                        user.empDate = DateTime.ParseExact(reader.GetString(8), "yyyyMMdd", CultureInfo.InvariantCulture);
                        user.dis = reader.GetString(9) == "1";
                        user.disDate = DateTime.ParseExact(reader.GetString(10), "yyyyMMdd", CultureInfo.InvariantCulture);
                        user.comment = reader.GetString(11);
                        user.nameText = reader.GetString(12);
                        user.postText = user.post != 0 ? (!reader.IsDBNull(13) ? reader.GetString(13) : ND) : "";
                        user.depText = user.dep != 0 ? (!reader.IsDBNull(14) ? reader.GetString(14) : ND) : "";
                        user.roomText = user.room != 0 ? (!reader.IsDBNull(15) ? reader.GetString(15) : ND) : "";
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
                com.CommandText = "INSERT INTO users (type, f, i, o, post, dep, room, " +
                                  "emp, empdate, dis, disdate, comment) VALUES ('u', '" +
                                  user.f + "', '" +
                                  user.i + "', '" +
                                  user.o + "', '" +
                                  user.post + "', '" +
                                  user.dep + "', '" +
                                  user.room + "', '" +
                                  (user.emp ? "1" : "0") + "', '" +
                                  user.empDate.ToString("yyyyMMdd") + "', '" +
                                  (user.dis ? "1" : "0") + "', '" +
                                  user.disDate.ToString("yyyyMMdd") + "', '" +
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
                com.CommandText = "UPDATE users SET " +
                                  "f = '" + user.f + "', " +
                                  "i = '" + user.i + "', " +
                                  "o = '" + user.o + "', " +
                                  "post = '" + user.post + "', " +
                                  "dep = '" + user.dep + "', " +
                                  "room = '" + user.room + "', " +
                                  "emp = '" + (user.emp ? "1" : "0") + "', " +
                                  "empdate = '" + user.empDate.ToString("yyyyMMdd") + "', " +
                                  "dis = '" + (user.dis ? "1" : "0") + "', " +
                                  "disdate = '" + user.disDate.ToString("yyyyMMdd") + "', " +
                                  "comment = '" + user.comment + "' WHERE ID = " + user.ID;
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
                com.CommandText = "DELETE FROM users WHERE ID = " + user.ID;
                com.ExecuteNonQuery();
                connect.Close();
            }
        }
        #endregion

        #region Производители [brands]
        public static List<Brand> BrandsLoad()
        {
            List<Brand> brands = new List<Brand>();
            using (SQLiteConnection connect = new SQLiteConnection(dataSource))
            {
                connect.Open();
                SQLiteCommand com = new SQLiteCommand(connect);
                com.CommandText = "SELECT * FROM brands ORDER BY name";
                using (SQLiteDataReader reader = com.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Brand brand = new Brand();
                        brand.ID = reader.GetInt32(0);
                        brand.name = reader.GetString(1);
                        brand.comment = reader.GetString(2);
                        brands.Add(brand);
                    }
                }
                connect.Close();
            }
            return brands;
        }

        public static void BrandAdd(Brand brand)
        {
            using (SQLiteConnection connect = new SQLiteConnection(dataSource))
            {
                connect.Open();
                SQLiteCommand com = new SQLiteCommand(connect);
                com.CommandText = "INSERT INTO brands (name, comment) VALUES ('" +
                    brand.name + "', '" +
                    brand.comment + "')";
                com.ExecuteNonQuery();
                connect.Close();
            }
        }

        public static void BrandUpdate(Brand brand)
        {
            using (SQLiteConnection connect = new SQLiteConnection(dataSource))
            {
                connect.Open();
                SQLiteCommand com = new SQLiteCommand(connect);
                com.CommandText = "UPDATE brands SET " +
                    "name = '" + brand.name + "', " +
                    "comment = '" + brand.comment + "' WHERE ID = " + brand.ID;
                com.ExecuteNonQuery();
                connect.Close();
            }
        }

        public static void BrandDelete(Brand brand)
        {
            using (SQLiteConnection connect = new SQLiteConnection(dataSource))
            {
                connect.Open();
                SQLiteCommand com = new SQLiteCommand(connect);
                com.CommandText = "DELETE FROM brands WHERE ID = " + brand.ID;
                com.ExecuteNonQuery();
                connect.Close();
            }
        }
        #endregion

        #region Должности [eqtypes]
        public static List<EqType> EqTypesLoad()
        {
            List<EqType> eqTypes = new List<EqType>();
            using (SQLiteConnection connect = new SQLiteConnection(dataSource))
            {
                connect.Open();
                SQLiteCommand com = new SQLiteCommand(connect);
                com.CommandText = "SELECT * FROM eqtypes ORDER BY name";
                using (SQLiteDataReader reader = com.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        EqType eqType = new EqType();
                        eqType.ID = reader.GetInt32(0);
                        eqType.name = reader.GetString(1);
                        eqTypes.Add(eqType);
                    }
                }
                connect.Close();
            }
            return eqTypes;
        }
        public static void EqTypeAdd(EqType eqType)
        {
            using (SQLiteConnection connect = new SQLiteConnection(dataSource))
            {
                connect.Open();
                SQLiteCommand com = new SQLiteCommand(connect);
                com.CommandText = "INSERT INTO eqtypes (name) VALUES ('" + eqType.name + "')";
                com.ExecuteNonQuery();
                connect.Close();
            }
        }
        public static void EqTypeUpdate(EqType eqType)
        {
            using (SQLiteConnection connect = new SQLiteConnection(dataSource))
            {
                connect.Open();
                SQLiteCommand com = new SQLiteCommand(connect);
                com.CommandText = "UPDATE eqtypes SET " + "name = '" + eqType.name + "' WHERE ID = " + eqType.ID;
                com.ExecuteNonQuery();
                connect.Close();
            }
        }

        public static void EqTypeDelete(EqType eqType)
        {
            using (SQLiteConnection connect = new SQLiteConnection(dataSource))
            {
                connect.Open();
                SQLiteCommand com = new SQLiteCommand(connect);
                com.CommandText = "DELETE FROM eqtypes WHERE ID = " + eqType.ID;
                com.ExecuteNonQuery();
                connect.Close();
            }
        }
        #endregion

        #region Модели [models]
        public static List<Model> ModelsLoad()
        {
            List<Model> models = new List<Model>();
            using (SQLiteConnection connect = new SQLiteConnection(dataSource))
            {
                connect.Open();
                SQLiteCommand com = new SQLiteCommand(connect);
                com.CommandText = "SELECT "+
                    "models.id, " +
                    "models.eqtype, " +
                    "models.brand, " +
                    "models.name, " +
                    "models.comment, " +
                    "eqtypes.name AS modelText, " +
                    "brands.name AS brandText, " +
                    "eqtypes.name || \" \" || brands.name || \" \" || models.name " +
                    "FROM models " +
                    "LEFT JOIN eqtypes ON models.eqtype = eqtypes.ID " +
                    "LEFT JOIN brands ON models.brand = brands.ID " +
                    "ORDER BY modelText";
                using (SQLiteDataReader reader = com.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Model model = new Model();
                        model.ID = reader.GetInt32(0);
                        model.eqType = reader.GetInt32(1);
                        model.brand = reader.GetInt32(2);
                        model.name = reader.GetString(3);
                        model.comment = reader.GetString(4);
                        model.eqTypeText = model.eqType != 0 ? (!reader.IsDBNull(5) ? reader.GetString(5) : ND) : "";
                        model.brandText = model.brand != 0 ? (!reader.IsDBNull(6) ? reader.GetString(6) : ND) : "";
                        model.nameText = model.eqType != 0 & model.brand != 0 ? (!reader.IsDBNull(7) ? reader.GetString(7) : ND) : "";
                        models.Add(model);
                    }
                }
                connect.Close();
            }
            return models;
        }
        public static void ModelAdd(Model model)
        {
            using (SQLiteConnection connect = new SQLiteConnection(dataSource))
            {
                connect.Open();
                SQLiteCommand com = new SQLiteCommand(connect);
                com.CommandText = "INSERT INTO models (eqtype, brand, name, comment) VALUES ('" +
                    model.eqType + "', '" +
                    model.brand + "', '" +
                    model.name + "', '" +
                    model.comment + "')";
                com.ExecuteNonQuery();
                connect.Close();
            }
        }
        public static void ModelUpdate(Model model)
        {
            using (SQLiteConnection connect = new SQLiteConnection(dataSource))
            {
                connect.Open();
                SQLiteCommand com = new SQLiteCommand(connect);
                com.CommandText = "UPDATE models SET " +
                    "eqtype = '" + model.eqType + "', " +
                    "brand = '" + model.brand + "', " +
                    "name = '" + model.name + "', " +
                    "comment = '" + model.comment + "' WHERE ID = " + model.ID;
                com.ExecuteNonQuery();
                connect.Close();
            }
        }

        public static void ModelDelete(Model model)
        {
            using (SQLiteConnection connect = new SQLiteConnection(dataSource))
            {
                connect.Open();
                SQLiteCommand com = new SQLiteCommand(connect);
                com.CommandText = "DELETE FROM models WHERE ID = " + model.ID;
                com.ExecuteNonQuery();
                connect.Close();
            }
        }
        #endregion

        #region Оборудование [equipment]
        public static List<Equipment> EquipmentsLoad()
        {
            List<Equipment> equipments = new List<Equipment>();
            using (SQLiteConnection connect = new SQLiteConnection(dataSource))
            {
                connect.Open();
                SQLiteCommand com = new SQLiteCommand(connect);
                com.CommandText = "SELECT " +
                    "equipments.ID, " +
                    "equipments.model, " +
                    "equipments.sn, " +
                    "equipments.[in], " +
                    "equipments.inv, " +
                    "equipments.mac, " +
                    "equipments.ip, " +
                    "equipments.prop, " +
                    "equipments.buy, " +
                    "equipments.buydate, " +
                    "equipments.price, " +
                    "equipments.provider, " +
                    "equipments.comment, " +
                    "eqtypes.name || \" \" || brands.name || \" \" || models.name AS nameText, " +
                    "eqtypes.name || \" \" || brands.name || \" \" || models.name || \" (\" || equipments.sn || \")\", " +
                    "users.f || \" \" || SUBSTR(users.i, 1, 1) || \".\" || SUBSTR(users.o, 1, 1) || \".\" AS userText, " +
                    "buildings.name || \", \" || rooms.name, " +
                    "m.date, " +
                    "providers.name, " +
                    "users.ID, " +
                    "mols.f || \" \" || SUBSTR(mols.i, 1, 1) || \".\" || SUBSTR(mols.o, 1, 1) || \".\" AS molText " +
                    "FROM equipments " +
                    "LEFT JOIN models ON equipments.model = models.ID " +
                    "LEFT JOIN eqtypes ON models.eqtype = eqtypes.ID " +
                    "LEFT JOIN brands ON models.brand = brands.ID " +
                    "LEFT JOIN (SELECT equipment, user, room, mol, date, max(date) FROM moves GROUP BY equipment) m ON equipments.ID = m.equipment " +
                    "LEFT JOIN users ON m.user = users.ID " +
                    "LEFT JOIN rooms ON m.room = rooms.ID " +
                    "LEFT JOIN buildings ON rooms.building = buildings.ID " +
                    "LEFT JOIN providers ON equipments.provider = providers.ID " +
                    "LEFT JOIN users mols ON m.mol = mols.ID " +
                    "ORDER BY nameText, [in]";
                using (SQLiteDataReader reader = com.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Equipment equipment = new Equipment();
                        equipment.ID = reader.GetInt32(0);
                        equipment.model = reader.GetInt32(1);
                        equipment.sn = reader.GetString(2);
                        equipment.iN = reader.GetString(3);
                        equipment.iNv = !reader.IsDBNull(4) ? (reader.GetString(4) == "1") : false;
                        equipment.mac = !reader.IsDBNull(5) ? reader.GetString(5) : "";
                        equipment.ip = !reader.IsDBNull(6) ? reader.GetString(6) : "";
                        equipment.prop = !reader.IsDBNull(7) ? reader.GetString(7) : "";
                        equipment.buy = reader.GetString(8) == "1";
                        equipment.buyDate = DateTime.ParseExact(reader.GetString(9), "yyyyMMdd", CultureInfo.InvariantCulture);
                        equipment.price = !reader.IsDBNull(10) ? reader.GetString(10) : "";
                        equipment.provider = !reader.IsDBNull(11) ? reader.GetInt32(11) : 0;
                        equipment.comment = reader.GetString(12);
                        equipment.nameText = equipment.model != 0 ? (!reader.IsDBNull(13) ? reader.GetString(13) : ND) : "";
                        equipment.nameINText = equipment.model != 0 ? (!reader.IsDBNull(14) ? reader.GetString(14) : ND) : "";
                        equipment.userText = !reader.IsDBNull(15) ? reader.GetString(15) : "";
                        equipment.roomText = !reader.IsDBNull(16) ? reader.GetString(16) : "";
                        equipment.isDtText = !reader.IsDBNull(17) ?
                            DateTime.ParseExact(reader.GetString(17), "yyyyMMdd", CultureInfo.InvariantCulture).ToString("dd.MM.yyyy") : "";
                        equipment.provText = !reader.IsDBNull(18) ? reader.GetString(18) : "";
                        equipment.user = !reader.IsDBNull(19) ? reader.GetInt32(19) : 0;
                        equipment.molText = !reader.IsDBNull(20) ? reader.GetString(20) : "";
                        equipments.Add(equipment);
                    }
                }
                connect.Close();
            }
            return equipments;
        }
        public static void EquipmentAdd(Equipment equipment)
        {
            using (SQLiteConnection connect = new SQLiteConnection(dataSource))
            {
                connect.Open();
                SQLiteCommand com = new SQLiteCommand(connect);
                com.CommandText = "INSERT INTO equipments (model, sn, [in], inv, mac, ip, prop, buy, buydate, price, provider, comment) VALUES ('" +
                    equipment.model + "', '" +
                    equipment.sn + "', '" +
                    equipment.iN + "', '" +
                    (equipment.iNv ? "1" : "0") + "', '" +
                    equipment.mac + "', '" +
                    equipment.ip + "', '" +
                    equipment.prop + "', '" +
                    (equipment.buy ? "1" : "0") + "', '" +
                    equipment.buyDate.ToString("yyyyMMdd") + "', '" +
                    equipment.price + "', '" +
                    equipment.provider + "', '" +
                    equipment.comment + "')";
                com.ExecuteNonQuery();
                connect.Close();
            }
        }
        public static void EquipmentUpdate(Equipment equipment)
        {
            using (SQLiteConnection connect = new SQLiteConnection(dataSource))
            {
                connect.Open();
                SQLiteCommand com = new SQLiteCommand(connect);
                com.CommandText = "UPDATE equipments SET " +
                    "model = '" + equipment.model + "', " +
                    "sn = '" + equipment.sn + "', " +
                    "[in] = '" + equipment.iN + "', " +
                    "inv = '" + (equipment.iNv ? "1" : "0") + "', " +
                    "mac = '" + equipment.mac + "', " +
                    "ip = '" + equipment.ip + "', " +
                    "prop = '" + equipment.prop + "', " +
                    "buy = '" + (equipment.buy ? "1" : "0") + "', " +
                    "buydate = '" + equipment.buyDate.ToString("yyyyMMdd") + "', " +
                    "price = '" + equipment.price + "', " +
                    "provider = '" + equipment.provider + "', " +
                    "comment = '" + equipment.comment + "' WHERE ID = " + equipment.ID;
                com.ExecuteNonQuery();
                connect.Close();
            }
        }

        public static void EquipmentDelete(Equipment equipment)
        {
            using (SQLiteConnection connect = new SQLiteConnection(dataSource))
            {
                connect.Open();
                SQLiteCommand com = new SQLiteCommand(connect);
                com.CommandText = "DELETE FROM equipments WHERE ID = " + equipment.ID;
                com.ExecuteNonQuery();
                connect.Close();
            }
        }
        #endregion

        #region Перемещения [moves]
        public static List<Move> MovesLoad()
        {
            List<Move> moves = new List<Move>();
            List<Equipment> equipments = EquipmentsLoad();
            List<User> users = UsersLoad();
            List<Room> rooms = RoomsLoad();
            using (SQLiteConnection connect = new SQLiteConnection(dataSource))
            {
                connect.Open();
                SQLiteCommand com = new SQLiteCommand(connect);
                com.CommandText = "SELECT " +
                    "moves.ID, " +
                    "moves.equipment, " +
                    "moves.user, " +
                    "moves.room, " +
                    "moves.date, " +
                    "moves.mol, " +
                    "moves.comment, " +
                    "eqtypes.name || \" \" || brands.name || \" \" || models.name || \" (\" || equipments.sn || \")\", " +
                    "users.f || \" \" || users.i || \" \" || users.o, " +
                    "buildings.name || \", \" || rooms.name, " +
                    "mols.f || \" \" || mols.i || \" \" || mols.o " +
                    "FROM moves " +
                    "LEFT JOIN equipments ON moves.equipment = equipments.ID " +
                    "LEFT JOIN models ON equipments.model = models.ID " +
                    "LEFT JOIN eqtypes ON models.eqtype = eqtypes.ID " +
                    "LEFT JOIN brands ON models.brand = brands.ID " +
                    "LEFT JOIN users ON moves.user = users.ID " +
                    "LEFT JOIN rooms ON moves.room = rooms.ID " +
                    "LEFT JOIN buildings ON rooms.building = buildings.ID " +
                    "LEFT JOIN users mols ON moves.mol = mols.ID " +
                    "ORDER BY moves.date";
                using (SQLiteDataReader reader = com.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Move move = new Move();
                        move.ID = reader.GetInt32(0);
                        move.equipment = reader.GetInt32(1);
                        move.user = reader.GetInt32(2);
                        move.room = reader.GetInt32(3);
                        move.date = DateTime.ParseExact(reader.GetString(4), "yyyyMMdd", CultureInfo.InvariantCulture);
                        move.mol = !reader.IsDBNull(5) ? reader.GetInt32(5) : 0;
                        move.comment = reader.GetString(6);
                        move.eqText = move.equipment != 0 ? (!reader.IsDBNull(7) ? reader.GetString(7) : ND) : "";
                        move.userText = move.user != 0 ? (!reader.IsDBNull(8) ? reader.GetString(8) : ND) : "";
                        move.roomText = move.room != 0 ? (!reader.IsDBNull(9) ? reader.GetString(9) : ND) : "";
                        move.molText = move.mol != 0 ? (!reader.IsDBNull(10) ? reader.GetString(10) : ND) : "";
                        moves.Add(move);
                    }
                }
                connect.Close();
            }
            return moves;
        }
        public static void MoveAdd(Move move)
        {
            using (SQLiteConnection connect = new SQLiteConnection(dataSource))
            {
                connect.Open();
                SQLiteCommand com = new SQLiteCommand(connect);
                com.CommandText = "INSERT INTO [moves] (equipment, user, room, date, mol, comment) VALUES ('" +
                    move.equipment + "', '" +
                    move.user + "', '" +
                    move.room + "', '" +
                    move.date.ToString("yyyyMMdd") + "', '" +
                    move.mol + "', '" +
                    move.comment + "')";
                com.ExecuteNonQuery();
                connect.Close();
            }
        }
        public static void MoveUpdate(Move move)
        {
            using (SQLiteConnection connect = new SQLiteConnection(dataSource))
            {
                connect.Open();
                SQLiteCommand com = new SQLiteCommand(connect);
                com.CommandText = "UPDATE [moves] SET " +
                    "[equipment] = '" + move.equipment + "', " +
                    "[user] = '" + move.user + "', " +
                    "[room] = '" + move.room + "', " +
                    "[date] = '" + move.date.ToString("yyyyMMdd") + "', " +
                    "[mol] = '" + move.mol + "', " +
                    "[comment] = '" + move.comment + "' WHERE ID = " + move.ID;
                com.ExecuteNonQuery();
                connect.Close();
            }
        }

        public static void MoveDelete(Move move)
        {
            using (SQLiteConnection connect = new SQLiteConnection(dataSource))
            {
                connect.Open();
                SQLiteCommand com = new SQLiteCommand(connect);
                com.CommandText = "DELETE FROM [moves] WHERE ID = " + move.ID;
                com.ExecuteNonQuery();
                connect.Close();
            }
        }
        #endregion

        #region Поставщики [providers]
        public static List<Provider> ProvidersLoad()
        {
            List<Provider> providers = new List<Provider>();
            using (SQLiteConnection connect = new SQLiteConnection(dataSource))
            {
                connect.Open();
                SQLiteCommand com = new SQLiteCommand(connect);
                com.CommandText = "SELECT * FROM providers ORDER BY name";
                using (SQLiteDataReader reader = com.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Provider provider = new Provider();
                        provider.ID = reader.GetInt32(0);
                        provider.name = reader.GetString(1);
                        provider.adress = reader.GetString(2);
                        provider.phone = reader.GetString(3);
                        provider.manager = reader.GetString(4);
                        provider.comment = reader.GetString(5);
                        providers.Add(provider);
                    }
                }
                connect.Close();
            }
            return providers;
        }


        public static void ProviderAdd(Provider provider)
        {
            using (SQLiteConnection connect = new SQLiteConnection(dataSource))
            {
                connect.Open();
                SQLiteCommand com = new SQLiteCommand(connect);
                com.CommandText = "INSERT INTO providers (name, adress, phone, manager, comment) VALUES ('" +
                    provider.name + "', '" +
                    provider.adress + "', '" +
                    provider.phone + "', '" +
                    provider.manager + "', '" +
                    provider.comment + "')";
                com.ExecuteNonQuery();
                connect.Close();
            }
        }

        public static void ProviderUpdate(Provider provider)
        {
            using (SQLiteConnection connect = new SQLiteConnection(dataSource))
            {
                connect.Open();
                SQLiteCommand com = new SQLiteCommand(connect);
                com.CommandText = "UPDATE providers SET " +
                    "name = '" + provider.name + "', " +
                    "adress = '" + provider.adress + "', " +
                    "phone = '" + provider.phone + "', " +
                    "manager = '" + provider.manager + "', " +
                    "comment = '" + provider.comment + "' WHERE ID = " + provider.ID;
                com.ExecuteNonQuery();
                connect.Close();
            }
        }

        public static void ProviderDelete(Provider provider)
        {
            using (SQLiteConnection connect = new SQLiteConnection(dataSource))
            {
                connect.Open();
                SQLiteCommand com = new SQLiteCommand(connect);
                com.CommandText = "DELETE FROM providers WHERE ID = " + provider.ID;
                com.ExecuteNonQuery();
                connect.Close();
            }
        }
        #endregion

        public static List<string> NamesLoad(string table)
        {
            List<string> list = new List<string>();
            using (SQLiteConnection connect = new SQLiteConnection(dataSource))
            {
                connect.Open();
                SQLiteCommand com = new SQLiteCommand(connect);
                com.CommandText = "SELECT name FROM "+ table;
                if (table == "buildings") com.CommandText = "SELECT filial || \"‼\" || name FROM buildings";
                if (table == "rooms") com.CommandText = "SELECT building || \"‼\" || name FROM rooms";
                if (table == "users") com.CommandText = "SELECT f || \"‼\" || i || \"‼\" || o FROM users";
                if (table == "models") com.CommandText = "SELECT brand || \"‼\" || name FROM models";
                if (table == "equipments") com.CommandText = "SELECT sn || \"‼\" || [in] FROM equipments";
                using (SQLiteDataReader reader = com.ExecuteReader())
                    while (reader.Read())
                        list.Add(reader.GetString(0));
                connect.Close();
            }
            return list;
        }
    }
}
