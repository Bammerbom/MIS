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
        public static void LoadDatabase() {
            //Create connection
            bool isNew = !File.Exists(FilePath);
            if (isNew) {
                SQLiteConnection.CreateFile(FilePath);
            }

            //Open connection
            Connection = new SQLiteConnection("Data Source=" + FilePath + ";Version=3;");
            Connection.Open();
            
            //Initital setup
            if (isNew) {
                ExecNonQuery("CREATE TABLE test2 (sample text, sample2 text)");

                //Test data
                ExecNonQuery("INSERT INTO test2 (sample, sample2) VALUES ('hoi', 'hoi2')");
                ExecNonQuery("INSERT INTO test2 (sample, sample2) VALUES ('doei', 'doei2')");
            }

            //Test code
            SQLiteDataReader reader = ExecQuery("SELECT * FROM test2");
            while (reader.Read())
            {
                Console.WriteLine(reader["sample"] + " | " + reader["sample2"]);
            }
        }

        /// <summary>
        /// Voert een commando uit wat geen query is (bv. insert)
        /// </summary>
        /// <param name="query">De query</param>
        /// <returns>Of de query succesvol was</returns>
        public static void ExecNonQuery(string query) {
            var cmd = new SQLiteCommand(query, Connection);
            cmd.ExecuteNonQuery();
        }

        /// <summary>
        /// Voert een commando is wat een query is (bv. select)
        /// </summary>
        /// <param name="query"></param>
        /// <returns>De resultaten van de query</returns>
        public static SQLiteDataReader ExecQuery(string query) {
            var cmd = new SQLiteCommand(query, Connection);
            return cmd.ExecuteReader();
        }
    }
}