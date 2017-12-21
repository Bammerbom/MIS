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
            bool isNew = !File.Exists(FilePath);
            if (isNew) {
                SQLiteConnection.CreateFile(FilePath);
            }
            Connection = new SQLiteConnection("Data Source=" + FilePath + ";Version=3;");
            Connection.Open();
            if (isNew) {
                ExecNonQuery("CREATE TABLE test (text sample)");
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