using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MIS
{
    public class SessionManager
    {
        /// <summary>
        /// Userid van degene die momenteel is ingelogd
        /// </summary>
        static int? currentuser = null;

        /// <summary>
        /// Returned of er iemand is ingelogd
        /// </summary>
        public static bool IsLoggedIn() => currentuser != null;

        /// <summary>
        /// Verkrijg de ingelogde gebruiker
        /// </summary>
        public static Gebruiker? GetCurrentUser() {
            if (currentuser == null) return null;
            return GebruikerManager.GebruikerOpvragen((int)currentuser);
        }

        /// <summary>
        /// Zet de ingelogde gebruiker
        /// </summary>
        public static void SetCurrentUser(int? userid)
        {
            currentuser = userid;
        }
    }
}
