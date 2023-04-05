using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Globalization;

namespace CompStore
{
    static class DB
    {
        public const string dataSource = @"DataSource=CS.db; Version=3;";
        static SQLiteConnection connect;
        static SQLiteDataReader reader;

        #region Инициализация таблиц
        public static void Init()
        {
            //SQLiteConnection.CreateFile(FileDB); 
            connect = new SQLiteConnection(dataSource);
            connect.Open();
            SQLiteCommand com = new SQLiteCommand(connect);

            com.CommandText = "CREATE TABLE IF NOT EXISTS [properties] ( " +
                "[name] TEXT, " +
                "[value] TEXT)";
            com.ExecuteNonQuery();

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

            com.CommandText = "CREATE TABLE IF NOT EXISTS [vendors] ( " +
                "[ID] INTEGER PRIMARY KEY AUTOINCREMENT NOT NULL, " +
                "[name] TEXT, " +
                "[comment] TEXT)";
            com.ExecuteNonQuery();

            com.CommandText = "CREATE TABLE IF NOT EXISTS [eqtypes] ( " +
                "[ID] INTEGER PRIMARY KEY AUTOINCREMENT NOT NULL, " +
                "[name] TEXT, " +
                "[printer] TEXT)";
            com.ExecuteNonQuery();

            com.CommandText = "CREATE TABLE IF NOT EXISTS [models] ( " +
                "[ID] INTEGER PRIMARY KEY AUTOINCREMENT NOT NULL, " +
                "[eqtype] INTEGER, " +
                "[vendor] INTEGER, " +
                "[name] TEXT, " +
                "[consumable] TEXT, " +
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
                "[price] TEXT, " +
                "[provider] INTEGER, " +
                "[buy] TEXT, " +
                "[buydate] TEXT, " +
                "[dec] TEXT, " +
                "[decdate] TEXT, " +
                "[printer] TEXT, " +
                "[consumable] INTEGER, " +
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

            com.CommandText = "CREATE TABLE IF NOT EXISTS [services] ( " +
                "[ID] INTEGER PRIMARY KEY AUTOINCREMENT NOT NULL, " +
                "[equipment] INTEGER, " +
                "[date] TEXT, " +
                "[work] INTEGER, " +
                "[consumable] INTEGER, " +
                "[counter] INTEGER, " +
                "[rate] INTEGER, " +
                "[comment] TEXT)";
            com.ExecuteNonQuery();

            com.CommandText = "CREATE TABLE IF NOT EXISTS [consumables] ( " +
                "[ID] INTEGER PRIMARY KEY AUTOINCREMENT NOT NULL, " +
                "[name] TEXT, " +
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
        #endregion

        #region Загрузка данных
        public static List<Record> Load(string type)
        {
            List<Record> list = new List<Record>();
            connect = new SQLiteConnection(dataSource);
            connect.Open();
            SQLiteCommand com = new SQLiteCommand(connect);
            if (type == "filials")
            {
                com.CommandText = "SELECT * FROM filials ORDER BY name";
                reader = com.ExecuteReader();
                while (reader.Read())
                {
                    Filial filial = new Filial();
                    filial.ID = ReadInt(0);
                    filial.name = filial.nameText = ReadStr(1);
                    filial.adress = ReadStr(2);
                    filial.comment = ReadStr(3);
                    list.Add(filial);
                }
            }
            if (type == "buildings")
            {
                com.CommandText = "SELECT buildings.ID, buildings.filial, buildings.name, buildings.comment, " +
                    "filials.name AS filialText, " +
                    "filials.name || \", зд. \" || [buildings].name " +
                    "FROM buildings " +
                    "LEFT JOIN filials ON buildings.filial = filials.ID " +
                    "ORDER BY filials.name, buildings.name";
                reader = com.ExecuteReader();
                while (reader.Read())
                {
                    Building building = new Building();
                    building.ID = ReadInt(0);
                    building.filial = ReadInt(1);
                    building.name = ReadStr(2);
                    building.comment = ReadStr(3);
                    building.filialText = ReadStr(4, building.filial);
                    building.nameText = ReadStr(5, building.filial);
                    list.Add(building);
                }
            }
            if (type == "rooms")
            {
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
                reader = com.ExecuteReader();
                while (reader.Read())
                {
                    Room room = new Room();
                    room.ID = ReadInt(0);
                    room.building = ReadInt(1);
                    room.name = ReadStr(2);
                    room.comment = ReadStr(3);
                    room.filialText = ReadStr(4, room.building);
                    room.buildingText = ReadStr(5, room.building);
                    room.nameText = ReadStr(6, room.building);
                    list.Add(room);
                }
            }
            if (type == "deps")
            {
                com.CommandText = "SELECT * FROM deps ORDER BY name";
                reader = com.ExecuteReader();
                while (reader.Read())
                {
                    Dep dep = new Dep();
                    dep.ID = ReadInt(0);
                    dep.name = dep.nameText = ReadStr(1);
                    dep.comment = ReadStr(2);
                    list.Add(dep);
                }
            }
            if (type == "posts")
            {
                com.CommandText = "SELECT * FROM posts ORDER BY name";
                reader = com.ExecuteReader();
                while (reader.Read())
                {
                    Post post = new Post();
                    post.ID = ReadInt(0);
                    post.name =ReadStr(1);
                    list.Add(post);
                }
            }
            if (type == "users")
            {
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
                    "posts.name, " +
                    "deps.name, " +
                    "filials.name || \", зд. \" || buildings.name || \", пом. \" || rooms.name " +
                    "FROM users " +
                    "LEFT JOIN posts ON users.post = posts.ID " +
                    "LEFT JOIN deps ON users.dep = deps.ID " +
                    "LEFT JOIN rooms ON users.room = rooms.ID " +
                    "LEFT JOIN buildings ON rooms.building = buildings.ID " +
                    "LEFT JOIN filials ON buildings.filial = filials.ID " +
                    "WHERE users.type = 'u' ORDER BY users.f, users.i, users.o";
                reader = com.ExecuteReader();
                while (reader.Read())
                {
                    User user = new User();
                    user.ID = ReadInt(0);
                    user.f = ReadStr(1);
                    user.i = ReadStr(2);
                    user.o = ReadStr(3);
                    user.post = ReadInt(4);
                    user.dep = ReadInt(5);
                    user.room = ReadInt(6);
                    user.emp = ReadBool(7);
                    user.empDate = ReadDate(8);
                    user.dis = ReadBool(9);
                    user.disDate = ReadDate(10);
                    user.comment = ReadStr(11);
                    user.nameText = ReadStr(12);
                    user.postText = ReadStr(13, user.post);
                    user.depText = ReadStr(14, user.dep);
                    user.roomText = ReadStr(15, user.room);
                    list.Add(user);
                }
            }
            if (type == "equipments")
            {
                com.CommandText = "SELECT " +
                    "equipments.ID, " +
                    "equipments.model, " +
                    "equipments.sn, " +
                    "equipments.[in], " +
                    "equipments.inv, " +
                    "equipments.mac, " +
                    "equipments.ip, " +
                    "equipments.prop, " +
                    "equipments.price, " +
                    "equipments.provider, " +
                    "equipments.buy, " +
                    "equipments.buydate, " +
                    "equipments.dec, " +
                    "equipments.decdate, " +
                    "equipments.comment, " +
                    "eqtypes.name || \" \" || vendors.name || \" \" || models.name AS nameText, " +
                    "eqtypes.name || \" \" || vendors.name || \" \" || models.name || \" (\" || equipments.sn || \")\", " +
                    "users.f || \" \" || SUBSTR(users.i, 1, 1) || \".\" || SUBSTR(users.o, 1, 1) || \".\" AS userText, " +
                    "users.dis, " +
                    "buildings.name || \", \" || rooms.name, " +
                    "m.date, " +
                    "providers.name, " +
                    "users.ID, " +
                    "mols.ID, " +
                    "mols.f || \" \" || SUBSTR(mols.i, 1, 1) || \".\" || SUBSTR(mols.o, 1, 1) || \".\" AS molText, " +
                    "eqtypes.printer as printer, " +
                    "models.consumable " +
                    "FROM equipments " +
                    "LEFT JOIN models ON equipments.model = models.ID " +
                    "LEFT JOIN eqtypes ON models.eqtype = eqtypes.ID " +
                    "LEFT JOIN vendors ON models.vendor = vendors.ID " +
                    "LEFT JOIN (SELECT equipment, user, room, mol, date, max(date) FROM moves GROUP BY equipment) m ON equipments.ID = m.equipment " +
                    "LEFT JOIN users ON m.user = users.ID " +
                    "LEFT JOIN rooms ON m.room = rooms.ID " +
                    "LEFT JOIN buildings ON rooms.building = buildings.ID " +
                    "LEFT JOIN providers ON equipments.provider = providers.ID " +
                    "LEFT JOIN users mols ON m.mol = mols.ID " +
                    "ORDER BY nameText, [in]";
                reader = com.ExecuteReader();
                while (reader.Read())
                {
                    Equipment equipment = new Equipment();
                    equipment.ID = ReadInt(0);
                    equipment.model = ReadInt(1);
                    equipment.sn = ReadStr(2);
                    equipment.iN = ReadStr(3);
                    equipment.iNv = ReadBool(4);
                    equipment.mac = ReadStr(5);
                    equipment.ip = ReadStr(6);
                    equipment.prop = ReadStr(7);
                    equipment.price = ReadStr(8);
                    equipment.provider = ReadInt(9);
                    equipment.buy = ReadBool(10);
                    equipment.buyDate = ReadDate(11);
                    equipment.dis = ReadBool(12);
                    equipment.disDate = ReadDate(13);
                    equipment.comment = ReadStr(14);
                    equipment.nameText = ReadStr(15);
                    equipment.nameINText = ReadStr(16);
                    equipment.userText = ReadStr(17);
                    if (ReadBool(18)) equipment.userText += " (УВОЛЕН!)";
                    equipment.roomText = ReadStr(19);
                    equipment.isDtText = ReadStr(20);
                    equipment.provText = ReadStr(21);
                    equipment.user = ReadInt(22);
                    equipment.mol = ReadInt(23);
                    equipment.molText = ReadStr(24);
                    equipment.printer = ReadBool(25);
                    equipment.consumable = ReadInt(26);
                    list.Add(equipment);
                }
            }
            if (type == "moves")
            {
                com.CommandText = "SELECT " +
                    "moves.ID, " +
                    "moves.equipment, " +
                    "moves.user, " +
                    "moves.room, " +
                    "moves.date, " +
                    "moves.mol, " +
                    "moves.comment, " +
                    "eqtypes.name || \" \" || vendors.name || \" \" || models.name || \" (\" || equipments.sn || \")\", " +
                    "users.f || \" \" || users.i || \" \" || users.o, " +
                    "buildings.name || \", \" || rooms.name, " +
                    "mols.f || \" \" || mols.i || \" \" || mols.o " +
                    "FROM moves " +
                    "LEFT JOIN equipments ON moves.equipment = equipments.ID " +
                    "LEFT JOIN models ON equipments.model = models.ID " +
                    "LEFT JOIN eqtypes ON models.eqtype = eqtypes.ID " +
                    "LEFT JOIN vendors ON models.vendor = vendors.ID " +
                    "LEFT JOIN users ON moves.user = users.ID " +
                    "LEFT JOIN rooms ON moves.room = rooms.ID " +
                    "LEFT JOIN buildings ON rooms.building = buildings.ID " +
                    "LEFT JOIN users mols ON moves.mol = mols.ID " +
                    "ORDER BY moves.date";
                reader = com.ExecuteReader();
                while (reader.Read())
                {
                    Move move = new Move();
                    move.ID = ReadInt(0);
                    move.equipment = ReadInt(1);
                    move.user = ReadInt(2);
                    move.room = ReadInt(3);
                    move.date = ReadDate(4);
                    move.mol = ReadInt(5);
                    move.comment = ReadStr(6);
                    move.eqText = ReadStr(7, move.equipment);
                    move.userText = ReadStr(8, move.user);
                    move.roomText = ReadStr(9, move.room);
                    move.molText = ReadStr(10, move.mol);
                    list.Add(move);
                }
            }
            if (type == "services")
            {
                com.CommandText = "SELECT " +
                    "services.ID, " +
                    "services.equipment, " +
                    "services.date, " +
                    "services.work, " +
                    "services.consumable, " +
                    "services.counter, " +
                    "services.rate, " +
                    "services.comment, " +
                    "eqtypes.name || \" \" || vendors.name || \" \" || models.name || \" (\" || equipments.sn || \")\", " +
                    "consumables.name, " +
                    "users.f || \" \" || SUBSTR(users.i, 1, 1) || \".\" || SUBSTR(users.o, 1, 1) || \".\" AS userText, " +
                    "deps.name as depText " +
                    "FROM services " +
                    "LEFT JOIN equipments ON services.equipment = equipments.ID " +
                    "LEFT JOIN models ON equipments.model = models.ID " +
                    "LEFT JOIN eqtypes ON models.eqtype = eqtypes.ID " +
                    "LEFT JOIN vendors ON models.vendor = vendors.ID " +
                    "LEFT JOIN consumables ON services.consumable = consumables.ID " +
                    "LEFT JOIN (SELECT equipment, user, room, max(date) FROM moves GROUP BY equipment) m ON equipments.ID = m.equipment " +
                    "LEFT JOIN users ON m.user = users.ID " + 
                    "LEFT JOIN deps ON users.dep = deps.ID " +
                    "ORDER BY services.date";
                reader = com.ExecuteReader();
                while (reader.Read())
                {
                    Service service = new Service();
                    service.ID = ReadInt(0);
                    service.equipment = ReadInt(1);
                    service.date = ReadDate(2);
                    service.work = ReadInt(3);
                    service.consumable = ReadInt(4);
                    service.counter = ReadInt(5);
                    service.rate = ReadInt(6);
                    service.comment = ReadStr(7);
                    service.eqText = ReadStr(8);
                    service.cnText = ReadStr(9);
                    service.usrText = ReadStr(10);
                    service.depText = ReadStr(11);
                    list.Add(service);
                }
            }
            if (type == "eqtypes")
            {
                com.CommandText = "SELECT * FROM eqtypes ORDER BY name";
                reader = com.ExecuteReader();
                while (reader.Read())
                {
                    EqType eqType = new EqType();
                    eqType.ID = ReadInt(0);
                    eqType.name = ReadStr(1);
                    eqType.printer = ReadBool(2);
                    list.Add(eqType);
                }
            }
            if (type == "vendors")
            {
                com.CommandText = "SELECT * FROM vendors ORDER BY name";
                reader = com.ExecuteReader();
                while (reader.Read())
                {
                    Vendor vendor = new Vendor();
                    vendor.ID = ReadInt(0);
                    vendor.name = ReadStr(1);
                    vendor.comment = ReadStr(2);
                    list.Add(vendor);
                }
            }
            if (type == "models")
            {
                com.CommandText = "SELECT " +
                    "models.id, " +
                    "models.eqtype, " +
                    "models.vendor, " +
                    "models.name, " +
                    "models.consumable, " +
                    "models.comment, " +
                    "eqtypes.name AS modelText, " +
                    "vendors.name AS vendorText, " +
                    "eqtypes.name || \" \" || vendors.name || \" \" || models.name, " +
                    "consumables.name " +
                    "FROM models " +
                    "LEFT JOIN eqtypes ON models.eqtype = eqtypes.ID " +
                    "LEFT JOIN vendors ON models.vendor = vendors.ID " +
                    "LEFT JOIN consumables ON models.consumable = consumables.ID " +
                    "ORDER BY eqtypes.name, vendors.name, models.name";
                reader = com.ExecuteReader();
                while (reader.Read())
                {
                    Model model = new Model();
                    model.ID = ReadInt(0);
                    model.eqType = ReadInt(1);
                    model.vendor = ReadInt(2);
                    model.name = ReadStr(3);
                    model.consumable = ReadInt(4);
                    model.comment = ReadStr(5);
                    model.eqTypeText = ReadStr(6, model.eqType);
                    model.vendorText = ReadStr(7, model.vendor);
                    model.nameText = ReadStr(8, model.eqType);
                    model.conText = ReadStr(9);
                    list.Add(model);
                }
            }
            if (type == "consumables")
            {
                com.CommandText = "SELECT * FROM consumables ORDER BY name";
                reader = com.ExecuteReader();
                while (reader.Read())
                {
                    Consumable con = new Consumable();
                    con.ID = ReadInt(0);
                    con.name = con.nameText = ReadStr(1);
                    con.comment = ReadStr(2);
                    list.Add(con);
                }
            }
            if (type == "providers")
            {
                com.CommandText = "SELECT * FROM providers ORDER BY name";
                reader = com.ExecuteReader();
                while (reader.Read())
                {
                    Provider provider = new Provider();
                    provider.ID = ReadInt(0);
                    provider.name = ReadStr(1);
                    provider.adress = ReadStr(2);
                    provider.phone = ReadStr(3);
                    provider.manager = ReadStr(4);
                    provider.comment = ReadStr(5);
                    list.Add(provider);
                }
            }

            connect.Close();
            return list;
        }

        static int ReadInt(int i) { return !reader.IsDBNull(i) ? reader.GetInt32(i) : 0; }
        static string ReadStr(int i, int s) { return s != 0 ? (!reader.IsDBNull(i) ? reader.GetString(i) : "#Н/Д") : ""; }
        static string ReadStr(int i) { return !reader.IsDBNull(i) ? reader.GetString(i) : ""; }
        static bool ReadBool(int i) { return !reader.IsDBNull(i) ? (reader.GetString(i) == "1") : false; }
        static DateTime ReadDate(int i) { return !reader.IsDBNull(i) ? DateTime.ParseExact(reader.GetString(i), "yyyyMMdd", CultureInfo.InvariantCulture) : DateTime.Now; }
        #endregion

        #region Добавление записей
        public static void Add(string type, Record item)
        {
            connect = new SQLiteConnection(dataSource);
            connect.Open();
            SQLiteCommand com = new SQLiteCommand(connect);
            if (type == "filials")
            {
                Filial filial = (Filial)item;
                com.CommandText = "INSERT INTO filials (name, adress, comment) VALUES ('" +
                    filial.name + "', '" +
                    filial.adress + "', '" +
                    filial.comment + "')";
            }
            if (type == "buildings")
            {
                Building building = (Building)item;
                com.CommandText = "INSERT INTO buildings (filial, name, comment) VALUES ('" +
                    building.filial + "', '" +
                    building.name + "', '" +
                    building.comment + "')";
            }
            if (type == "rooms")
            {
                Room room = (Room)item;
                com.CommandText = "INSERT INTO rooms (building, name, comment) VALUES ('" +
                    room.building + "', '" +
                    room.name + "', '" +
                    room.comment + "')";
            }
            if (type == "deps")
            {
                Dep dep = (Dep)item;
                com.CommandText = "INSERT INTO deps (name, comment) VALUES ('" +
                    dep.name + "', '" +
                    dep.comment + "')";
            }
            if (type == "posts")
            {
                Post post = (Post)item;
                com.CommandText = "INSERT INTO posts (name) VALUES ('" +
                    post.name + "')";
            }
            if (type == "users")
            {
                User user = (User)item;
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
            }
            if (type == "equipments")
            {
                Equipment equipment = (Equipment)item;
                com.CommandText = "INSERT INTO equipments (model, sn, [in], inv, mac, ip, prop, price, " +
                    "provider, buy, buydate, dec, decdate, comment) VALUES ('" +
                    equipment.model + "', '" +
                    equipment.sn + "', '" +
                    equipment.iN + "', '" +
                    (equipment.iNv ? "1" : "0") + "', '" +
                    equipment.mac + "', '" +
                    equipment.ip + "', '" +
                    equipment.prop + "', '" +
                    equipment.price + "', '" +
                    equipment.provider + "', '" +
                    (equipment.buy ? "1" : "0") + "', '" +
                    equipment.buyDate.ToString("yyyyMMdd") + "', '" +
                    (equipment.dis ? "1" : "0") + "', '" +
                    equipment.disDate.ToString("yyyyMMdd") + "', '" +
                    equipment.comment + "')";
            }
            if (type == "moves")
            {
                Move move = (Move)item;
                com.CommandText = "INSERT INTO moves (equipment, user, room, date, mol, comment) VALUES ('" +
                    move.equipment + "', '" +
                    move.user + "', '" +
                    move.room + "', '" +
                    move.date.ToString("yyyyMMdd") + "', '" +
                    move.mol + "', '" +
                    move.comment + "')";
            }
            if (type == "services")
            {
                Service service = (Service)item;
                com.CommandText = "INSERT INTO services (equipment, date, work, consumable, counter, rate, comment) VALUES ('" +
                    service.equipment + "', '" +
                    service.date.ToString("yyyyMMdd") + "', '" +
                    service.work + "', '" +
                    service.consumable + "', '" +
                    service.counter + "', '" +
                    service.rate + "', '" +
                    service.comment + "')";
            }
            if (type == "eqtypes")
            {
                EqType eqType = (EqType)item;
                com.CommandText = "INSERT INTO eqtypes (name, printer) VALUES ('" +
                    eqType.name + "'," +
                    (eqType.printer ? "1" : "0") + ")";
            }
            if (type == "vendors")
            {
                Vendor vendor = (Vendor)item;
                com.CommandText = "INSERT INTO vendors (name, comment) VALUES ('" +
                    vendor.name + "', '" +
                    vendor.comment + "')";
            }
            if (type == "models")
            {
                Model model = (Model)item;
                com.CommandText = "INSERT INTO models (eqtype, vendor, name, consumable, comment) VALUES ('" +
                     model.eqType + "', '" +
                     model.vendor + "', '" +
                     model.name + "', '" +
                     model.consumable + "', '" +
                     model.comment + "')";
            }
            if (type == "consumables")
            {
                Consumable con = (Consumable)item;
                com.CommandText = "INSERT INTO consumables (name, comment) VALUES ('" +
                    con.name + "', '" +
                    con.comment + "')";
            }
            if (type == "providers")
            {
                Provider provider = (Provider)item;
                com.CommandText = "INSERT INTO providers (name, adress, phone, manager, comment) VALUES ('" +
                    provider.name + "', '" +
                    provider.adress + "', '" +
                    provider.phone + "', '" +
                    provider.manager + "', '" +
                    provider.comment + "')";
            }


            com.ExecuteNonQuery();
            connect.Close();
        }
        #endregion

        #region Обновление записей
        public static void Update(string type, Record item)
        {
            connect = new SQLiteConnection(dataSource);
            connect.Open();
            SQLiteCommand com = new SQLiteCommand(connect);
            if (type == "filials")
            {
                Filial filial = (Filial)item;
                com.CommandText = "UPDATE filials SET " +
                    "name = '" + filial.name + "', " +
                    "adress = '" + filial.adress + "', " +
                    "comment = '" + filial.comment + "' WHERE ID = " + filial.ID;
            }
            if (type == "buildings")
            {
                Building building = (Building)item;
                com.CommandText = "UPDATE buildings SET " +
                    "filial = '" + building.filial + "', " +
                    "name = '" + building.name + "', " +
                    "comment = '" + building.comment + "' WHERE ID = " + building.ID;
            }
            if (type == "rooms")
            {
                Room room = (Room)item;
                com.CommandText = "UPDATE rooms SET " +
                    "building = '" + room.building + "', " +
                    "name = '" + room.name + "', " +
                    "comment = '" + room.comment + "' WHERE ID = " + room.ID;
            }
            if (type == "deps")
            {
                Dep dep = (Dep)item;
                com.CommandText = "UPDATE deps SET " +
                    "name = '" + dep.name + "', " +
                    "comment = '" + dep.comment + "' WHERE ID = " + dep.ID;
            }
            if (type == "posts")
            {
                Post post = (Post)item;
                com.CommandText = "UPDATE posts SET " +
                    "name = '" + post.name + "' WHERE ID = " + post.ID;
            }
            if (type == "users")
            {
                User user = (User)item;
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
            }
            if (type == "equipments")
            {
                Equipment equipment = (Equipment)item;
                com.CommandText = "UPDATE equipments SET " +
                    "model = '" + equipment.model + "', " +
                    "sn = '" + equipment.sn + "', " +
                    "[in] = '" + equipment.iN + "', " +
                    "inv = '" + (equipment.iNv ? "1" : "0") + "', " +
                    "mac = '" + equipment.mac + "', " +
                    "ip = '" + equipment.ip + "', " +
                    "prop = '" + equipment.prop + "', " +
                    "price = '" + equipment.price + "', " +
                    "provider = '" + equipment.provider + "', " +
                    "buy = '" + (equipment.buy ? "1" : "0") + "', " +
                    "buydate = '" + equipment.buyDate.ToString("yyyyMMdd") + "', " +
                    "dec = '" + (equipment.dis ? "1" : "0") + "', " +
                    "decdate = '" + equipment.disDate.ToString("yyyyMMdd") + "', " +
                    "comment = '" + equipment.comment + "' WHERE ID = " + equipment.ID;
            }
            if (type == "moves")
            {
                Move move = (Move)item;
                com.CommandText = "UPDATE moves SET " +
                    "equipment = '" + move.equipment + "', " +
                    "user = '" + move.user + "', " +
                    "room = '" + move.room + "', " +
                    "date = '" + move.date.ToString("yyyyMMdd") + "', " +
                    "mol = '" + move.mol + "', " +
                    "comment = '" + move.comment + "' WHERE ID = " + move.ID;
            }
            if (type == "services")
            {
                Service service = (Service)item;
                com.CommandText = "UPDATE services SET " +
                    "equipment = '" + service.equipment + "', " +
                    "date = '" + service.date.ToString("yyyyMMdd") + "', " +
                    "work = '" + service.work + "', " +
                    "consumable = '" + service.consumable + "', " +
                    "counter = '" + service.counter + "', " +
                    "rate = '" + service.rate + "', " +
                    "comment = '" + service.comment + "' WHERE ID = " + service.ID;
            }
            if (type == "eqtypes")
            {
                EqType eqType = (EqType)item;
                com.CommandText = "UPDATE eqtypes SET " +
                    "name = '" + eqType.name + "', " +
                    "printer = '" + (eqType.printer ? "1" : "0") + "' WHERE ID = " + eqType.ID;
            }
            if (type == "vendors")
            {
                Vendor vendor = (Vendor)item;
                com.CommandText = "UPDATE vendors SET " +
                    "name = '" + vendor.name + "', " +
                    "comment = '" + vendor.comment + "' WHERE ID = " + vendor.ID;
            }
            if (type == "models")
            {
                Model model = (Model)item;
                com.CommandText = "UPDATE models SET " +
                    "eqtype = '" + model.eqType + "', " +
                    "vendor = '" + model.vendor + "', " +
                    "name = '" + model.name + "', " +
                    "consumable = '" +model.consumable + "', " +
                    "comment = '" + model.comment + "' WHERE ID = " + model.ID;
            }
            if (type == "consumables")
            {
                Consumable con = (Consumable)item;
                com.CommandText = "UPDATE consumables SET " +
                    "name = '" + con.name + "', " +
                    "comment = '" + con.comment + "' WHERE ID = " + con.ID;
            }
            if (type == "providers")
            {
                Provider provider = (Provider)item;
                com.CommandText = "UPDATE providers SET " +
                    "name = '" + provider.name + "', " +
                    "adress = '" + provider.adress + "', " +
                    "phone = '" + provider.phone + "', " +
                    "manager = '" + provider.manager + "', " +
                    "comment = '" + provider.comment + "' WHERE ID = " + provider.ID;
            }

            com.ExecuteNonQuery();
            connect.Close();
        }
        #endregion

        public static void Delete(string type, Record item)
        {
            connect = new SQLiteConnection(dataSource);
            connect.Open();
            SQLiteCommand com = new SQLiteCommand(connect);
            com.CommandText = "DELETE FROM " + type + " WHERE ID = " + item.ID;
            com.ExecuteNonQuery();
            connect.Close();
        }

        public static List<string> NamesLoad(string table)
        {
            List<string> list = new List<string>();
            connect = new SQLiteConnection(dataSource);
            connect.Open();
            SQLiteCommand com = new SQLiteCommand(connect);
            com.CommandText = "SELECT name FROM " + table;
            if (table == "buildings") com.CommandText = "SELECT filial || \"‼\" || name FROM buildings";
            if (table == "rooms") com.CommandText = "SELECT building || \"‼\" || name FROM rooms";
            if (table == "users") com.CommandText = "SELECT f || \"‼\" || i || \"‼\" || o FROM users";
            if (table == "models") com.CommandText = "SELECT vendor || \"‼\" || name FROM models";
            if (table == "equipments") com.CommandText = "SELECT sn || \"‼\" || [in] FROM equipments";
            using (SQLiteDataReader reader = com.ExecuteReader())
                while (reader.Read())
                    list.Add(reader.GetString(0));
            connect.Close();
            return list;
        }
    }
}
