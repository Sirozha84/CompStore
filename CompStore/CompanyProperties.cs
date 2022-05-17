using System.Data.SQLite;

namespace CompStore
{
    static internal class CompanyProperties
    {
        public static string Companay;
        public static string Departament;

        public static void Load()
        {
            using (SQLiteConnection connect = new SQLiteConnection(DB.dataSource))
            {
                connect.Open();
                SQLiteCommand com = new SQLiteCommand(connect);
                com.CommandText = "SELECT * FROM properties";
                com.ExecuteNonQuery();
                using (SQLiteDataReader reader = com.ExecuteReader())
                    while (reader.Read())
                    {
                        if (reader.GetString(0) == "company") Companay = reader.GetString(1);
                        if (reader.GetString(0) == "departament") Departament = reader.GetString(1);
                    }
                connect.Close();
            }
        }

        public static void Save()
        {
            using (SQLiteConnection connect = new SQLiteConnection(DB.dataSource))
            {
                connect.Open();
                SQLiteCommand com = new SQLiteCommand(connect);
                com.CommandText = "DELETE FROM properties";
                com.ExecuteNonQuery();
                com.CommandText = "INSERT INTO properties (name, value) values ('company', '" + Companay + "')";
                com.ExecuteNonQuery();
                com.CommandText = "INSERT INTO properties (name, value) values ('departament', '" + Departament + "')";
                com.ExecuteNonQuery();
                connect.Close();
            }
        }
    }
}
