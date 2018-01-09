using System;
using System.Data;
using System.Data.SqlClient;
using System.Data.SQLite;

namespace MIS {
    public class DatabaseManager {
        public static void Init() {
            //Open connection
            bool isNew = SqlTools.LoadDatabase();
            var con = SqlTools.Connection;

            //Create new tables
            if (isNew) {
                var cmd = new SQLiteCommand("CREATE TABLE gebruikers (" +
                                      "userid integer NOT NULL PRIMARY KEY AUTOINCREMENT, " +
                                      "voornaam text, " +
                                      "achternaam text, " +
                                      "verified boolean, " +
                                      "admin boolean, " +
                                      "vraagprijs decimal, " +
                                      "diertypes text)", SqlTools.Connection);
                cmd.ExecuteNonQuery();
            }

            #region Test code
            //Maak een nieuwe gebruiker
            var gebruiker = new Gebruiker
            {
                voornaam = "Jonathan",
                achternaam = "Brouwer",
                verified = true,
                admin = true,
                vraagprijs = 9001.99,
                diertypes = "Hond, kat en je moeder"
            };
            int userid = GebruikerToevoegen(gebruiker);

            //Vraag gebruiker op
            var gebruiker2 = GebruikerOpvragen(userid);
            Console.WriteLine(gebruiker2.voornaam + " " + gebruiker2.achternaam);

            //Wijzig gebruiker
            gebruiker2.voornaam = "Nahtanoj";
            GebruikerWijzigen(userid, gebruiker2);

            //Vraag gebruiker opnieuw op
            var gebruiker3 = GebruikerOpvragen(userid);
            Console.WriteLine(gebruiker3.voornaam + " " + gebruiker3.achternaam);
            #endregion
        }

        /// <summary>
        /// Voegt een nieuwe gebruiker toe
        /// </summary>
        /// <param name="gebruiker">De gebruiker</param>
        /// <returns>Het gebuikersid van de nieuwe gebruiker</returns>
        public static int GebruikerToevoegen(Gebruiker gebruiker)
        {
            //Create insert command
            var cmd = new SQLiteCommand("INSERT INTO gebruikers (voornaam, achternaam, verified, admin, vraagprijs, diertypes) " +
                "VALUES (@voornaam, @achternaam, @verified, @admin, @vraagprijs, @diertypes)", SqlTools.Connection);
            cmd.Parameters.Add("@voornaam", DbType.String).Value = gebruiker.voornaam;
            cmd.Parameters.Add("@achternaam", DbType.String).Value = gebruiker.achternaam;
            cmd.Parameters.Add("@verified", DbType.Boolean).Value = gebruiker.verified;
            cmd.Parameters.Add("@admin", DbType.Boolean).Value = gebruiker.admin;
            cmd.Parameters.Add("@vraagprijs", DbType.Double).Value = gebruiker.vraagprijs;
            cmd.Parameters.Add("@diertypes", DbType.String).Value = gebruiker.diertypes;
            cmd.ExecuteNonQuery();

            //Verkrijg userid
            return (int) SqlTools.Connection.LastInsertRowId;
        }

        /// <summary>
        /// Vraagt de gebruiker op met het gegeven userid
        /// </summary>
        /// <param name="userid">Het gebruikers id</param>
        /// <returns>De gebruiker</returns>
        public static Gebruiker GebruikerOpvragen(int userid)
        {
            //Create select command
            var cmd = new SQLiteCommand("SELECT * FROM gebruikers WHERE userid = @userid", SqlTools.Connection);
            cmd.Parameters.Add("@userid", DbType.String).Value = userid;
            var reader = cmd.ExecuteReader();
            reader.Read();

            return new Gebruiker
            {
                voornaam = (string)reader["voornaam"],
                achternaam = (string)reader["achternaam"],
                verified = (bool)reader["verified"],
                admin = (bool)reader["admin"],
                vraagprijs = Convert.ToDouble(reader["vraagprijs"]),
                diertypes = (string)reader["diertypes"]
            };
        }

        /// <summary>
        /// Wijzigt de gegevens van de gebruiker met het gegeven id
        /// </summary>
        /// <param name="userid">Het gebeuikers id</param>
        /// <param name="gebruiker">De gegevens</param>
        /// <returns></returns>
        public static bool GebruikerWijzigen(int userid, Gebruiker gebruiker)
        {
            //Create update command
            var cmd = new SQLiteCommand("UPDATE gebruikers SET " +
                "voornaam = @voornaam, achternaam = @achternaam, verified = @verified, admin = @admin, vraagprijs = @vraagprijs, diertypes = @diertypes " +
                "WHERE userid = @userid", SqlTools.Connection);
            cmd.Parameters.Add("@userid", DbType.Int32).Value = userid;
            cmd.Parameters.Add("@voornaam", DbType.String).Value = gebruiker.voornaam;
            cmd.Parameters.Add("@achternaam", DbType.String).Value = gebruiker.achternaam;
            cmd.Parameters.Add("@verified", DbType.Boolean).Value = gebruiker.verified;
            cmd.Parameters.Add("@admin", DbType.Boolean).Value = gebruiker.admin;
            cmd.Parameters.Add("@vraagprijs", DbType.Double).Value = gebruiker.vraagprijs;
            cmd.Parameters.Add("@diertypes", DbType.String).Value = gebruiker.diertypes;
            return cmd.ExecuteNonQuery() > 0;
        }
    }

    public struct Gebruiker
    {
        public string voornaam;
        public string achternaam;
        public bool verified;
        public bool admin;
        public double vraagprijs;
        public string diertypes;
    }
}