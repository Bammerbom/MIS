using System;
using System.Collections.Generic;
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
                                      "oppassen boolean, " +
                                      "uitlaten boolean, " +
                                      "woonplaats text, " +
                                      "diertypes text)", SqlTools.Connection);
                cmd.ExecuteNonQuery();
            }
        }

        /// <summary>
        /// Voegt een nieuwe gebruiker toe
        /// </summary>
        /// <param name="gebruiker">De gebruiker</param>
        /// <returns>Het gebuikersid van de nieuwe gebruiker</returns>
        public static int GebruikerToevoegen(Gebruiker gebruiker)
        {
            //Create insert command
            var cmd = new SQLiteCommand("INSERT INTO gebruikers (voornaam, achternaam, verified, admin, vraagprijs, oppassen, uitlaten, woonplaats, diertypes) " +
                "VALUES (@voornaam, @achternaam, @verified, @admin, @vraagprijs, @oppassen, @uitlaten, @woonplaats, @diertypes)", SqlTools.Connection);
            cmd.Parameters.Add("@voornaam", DbType.String).Value = gebruiker.voornaam;
            cmd.Parameters.Add("@achternaam", DbType.String).Value = gebruiker.achternaam;
            cmd.Parameters.Add("@verified", DbType.Boolean).Value = gebruiker.verified;
            cmd.Parameters.Add("@admin", DbType.Boolean).Value = gebruiker.admin;
            cmd.Parameters.Add("@vraagprijs", DbType.Double).Value = gebruiker.vraagprijs;
            cmd.Parameters.Add("@oppassen", DbType.Boolean).Value = gebruiker.oppassen;
            cmd.Parameters.Add("@uitlaten", DbType.Boolean).Value = gebruiker.uitlaten;
            cmd.Parameters.Add("@woonplaats", DbType.String).Value = gebruiker.woonplaats;
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

            //Sla data op in een gebruiker struct
            return new Gebruiker
            {
                voornaam = (string)reader["voornaam"],
                achternaam = (string)reader["achternaam"],
                verified = (bool)reader["verified"],
                admin = (bool)reader["admin"],
                vraagprijs = Convert.ToDouble(reader["vraagprijs"]),
                oppassen = (bool)reader["oppassen"],
                uitlaten = (bool)reader["uitlaten"],
                woonplaats = (string)reader["woonplaats"],
                diertypes = (string)reader["diertypes"]
            };
        }

        /// <summary>
        /// Wijzigt de gegevens van de gebruiker met het gegeven id
        /// </summary>
        /// <param name="userid">Het gebruikers id</param>
        /// <param name="gebruiker">De gegevens</param>
        /// <returns>Of de verandering succesvol is</returns>
        public static bool GebruikerWijzigen(int userid, Gebruiker gebruiker)
        {
            //Create update command
            var cmd = new SQLiteCommand("UPDATE gebruikers SET " +
                "voornaam = @voornaam, achternaam = @achternaam, verified = @verified, admin = @admin, " +
                "vraagprijs = @vraagprijs, oppassen = @oppassen, uitlaten = @uitlaten, woonplaats = @woonplaats, diertypes = @diertypes " +
                "WHERE userid = @userid", SqlTools.Connection);
            cmd.Parameters.Add("@userid", DbType.Int32).Value = userid;
            cmd.Parameters.Add("@voornaam", DbType.String).Value = gebruiker.voornaam;
            cmd.Parameters.Add("@achternaam", DbType.String).Value = gebruiker.achternaam;
            cmd.Parameters.Add("@verified", DbType.Boolean).Value = gebruiker.verified;
            cmd.Parameters.Add("@admin", DbType.Boolean).Value = gebruiker.admin;
            cmd.Parameters.Add("@vraagprijs", DbType.Double).Value = gebruiker.vraagprijs;
            cmd.Parameters.Add("@oppassen", DbType.Boolean).Value = gebruiker.oppassen;
            cmd.Parameters.Add("@uitlaten", DbType.Boolean).Value = gebruiker.uitlaten;
            cmd.Parameters.Add("@woonplaats", DbType.String).Value = gebruiker.woonplaats;
            cmd.Parameters.Add("@diertypes", DbType.String).Value = gebruiker.diertypes;
            return cmd.ExecuteNonQuery() > 0;
        }

        /// <summary>
        /// Verwijderd de gebruiker met het gegeven id
        /// </summary>
        /// <param name="userid">Het gebruikers id</param>
        /// <returns>Of het verwijderen succesvol is</returns>
        public static bool GebruikerVerwijderen(int userid)
        {
            //Create delete command
            var cmd = new SQLiteCommand("DELETE FROM gebruikers WHERE userid = @userid", SqlTools.Connection);
            cmd.Parameters.Add("@userid", DbType.String).Value = userid;
            return cmd.ExecuteNonQuery() > 0;
        }

        /// <summary>
        /// Verkrijg een array van alle gebruikers
        /// </summary>
        /// <returns>Een array van alle gebruikers</returns>
        public static Gebruiker[] AlleGebruikers()
        {
            //Create select command
            var cmd = new SQLiteCommand("SELECT * FROM gebruikers", SqlTools.Connection);
            var reader = cmd.ExecuteReader();

            //Verander resultaten data in lijst van gebruikers
            var gebruikers = new List<Gebruiker>();
            while (reader.Read())
            {
                gebruikers.Add(new Gebruiker
                {
                    voornaam = (string)reader["voornaam"],
                    achternaam = (string)reader["achternaam"],
                    verified = (bool)reader["verified"],
                    admin = (bool)reader["admin"],
                    vraagprijs = Convert.ToDouble(reader["vraagprijs"]),
                    oppassen = (bool)reader["oppassen"],
                    uitlaten = (bool)reader["uitlaten"],
                    woonplaats = (string)reader["woonplaats"],
                    diertypes = (string)reader["diertypes"]
                });
            }

            //Return
            return gebruikers.ToArray();
        }
    }

    /// <summary>
    /// De data van een gebruiker, exclusief gebruikers id
    /// </summary>
    public struct Gebruiker
    {
        public string voornaam;
        public string achternaam;
        public bool verified;
        public bool admin;
        public double vraagprijs;
        public bool oppassen;
        public bool uitlaten;
        public string woonplaats;
        public string diertypes;
    }
}