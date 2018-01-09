using System;
using System.Data.SQLite;
using System.IO;

namespace MIS {
    public class SqlTools {
        public static SQLiteConnection Connection;
        private const string FilePath = "PetBreakfast.sqlite";

        /// <summary>
        /// Laad een sqlite database vanaf een bestand, verbind daarmee, en sla die verbinding op in <see cref="Connection"/>
        /// </summary>
        /// <param name="file"></param>
        /// <returns>Whether this was the first start</returns>
        public static bool LoadDatabase() {
            //Create connection
            bool isNew = !File.Exists(FilePath);
            if (isNew) {
                SQLiteConnection.CreateFile(FilePath);
            }

            //Open connection
            Connection = new SQLiteConnection("Data Source=" + FilePath + ";Version=3;");
            Connection.Open();

            return isNew;
            
//
//            //Test code
//            SQLiteDataReader reader = ExecQuery("SELECT * FROM test2");
//            while (reader.Read())
//            {
//                Console.WriteLine(reader["sample"] + " | " + reader["sample2"]);
//            }
        }
    }
}