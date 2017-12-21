using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MIS {
    public class SqlTools {
        public static SQLiteConnection Connection;

        /// <summary>
        /// Laad een sqlite database vanaf een bestand, verbind daarmee, en sla die verbinding op in <see cref="Connection"/>
        /// </summary>
        /// <param name="file"></param>
        public static void LoadDatabase(string file) {
            
        }

        /// <summary>
        /// Voert een commando uit wat geen query is (bv. insert)
        /// </summary>
        /// <param name="query">De query</param>
        /// <returns>Of de query succesvol was</returns>
        public static bool ExecNonQuery(string query) {
            return false;
        }

        /// <summary>
        /// Voert een commando is wat een query is (bv. select)
        /// </summary>
        /// <param name="query"></param>
        /// <returns>De resultaten van de query</returns>
        public static SQLiteDataReader ExecQuery(string query) {
            return null;
        }
    }
}