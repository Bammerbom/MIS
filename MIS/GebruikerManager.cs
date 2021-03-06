﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Data.SQLite;
using System.Security.Cryptography;

namespace MIS {
    public class GebruikerManager {

        /// <summary>
        /// Laad de database, of maak een nieuwe als hij nog niet bestaat
        /// </summary>
        public static void Init() {
            //Open connection
            bool isNew = SqlTools.LoadDatabase();
            var con = SqlTools.Connection;

            //Create new tables
            if (isNew)
            {
                var cmd = new SQLiteCommand("CREATE TABLE gebruikers (" +
                                      "userid integer NOT NULL PRIMARY KEY AUTOINCREMENT, " +
                                      "voornaam text, " +
                                      "overmij text, " +
                                      "achternaam text, " +
                                      "verified boolean, " +
                                      "admin boolean, " +
                                      "vraagprijs decimal, " +
                                      "oppassen boolean, " +
                                      "uitlaten boolean, " +
                                      "woonplaats text, " +
                                      "diertypes text, " +
                                      "email text," +
                                      "password text)", SqlTools.Connection);
                cmd.ExecuteNonQuery();

                var cmd2 = new SQLiteCommand("CREATE TABLE reviews (" +
                                      "reviewid integer NOT NULL PRIMARY KEY AUTOINCREMENT, " +
                                      "reviewedid integer, " +
                                      "reviewerid integer, " +
                                      "rating integer, " +
                                      "title text, " +
                                      "body text)", SqlTools.Connection);
                cmd2.ExecuteNonQuery();
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
            var cmd = new SQLiteCommand("INSERT INTO gebruikers (voornaam, achternaam, overmij, verified, admin, vraagprijs, oppassen, uitlaten, woonplaats, diertypes, email, password) " +
                "VALUES (@voornaam, @achternaam, @overmij, @verified, @admin, @vraagprijs, @oppassen, @uitlaten, @woonplaats, @diertypes, @email, @password)", SqlTools.Connection);
            cmd = GebruikerNaarData(cmd, gebruiker);
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
            cmd.Parameters.Add("@userid", DbType.Int32).Value = userid;
            var reader = cmd.ExecuteReader();
            reader.Read();

            //Sla data op in een gebruiker struct
            return GebruikerVanData(reader);
        }

        /// <summary>
        /// Wijzigt de gegevens van de gebruiker met het gegeven id
        /// </summary>
        /// <param name="userid">Het gebruikers id</param>
        /// <param name="gebruiker">De gegevens</param>
        /// <returns>Of de verandering succesvol is</returns>
        public static bool GebruikerWijzigen(Gebruiker gebruiker)
        {
            //Create update command
            var cmd = new SQLiteCommand("UPDATE gebruikers SET " +
                "voornaam = @voornaam, achternaam = @achternaam, overmij = @overmij, verified = @verified, admin = @admin, " +
                "vraagprijs = @vraagprijs, oppassen = @oppassen, uitlaten = @uitlaten, woonplaats = @woonplaats, diertypes = @diertypes, email = @email, password = @password " +
                "WHERE userid = @userid", SqlTools.Connection);
            cmd = GebruikerNaarData(cmd, gebruiker);
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
                gebruikers.Add(GebruikerVanData(reader));
            }

            //Return
            return gebruikers.ToArray();
        }

        public static string PasswordHash(string password)
        {
            //CREDITS: https://stackoverflow.com/questions/4181198/how-to-hash-a-password/10402129#10402129

            //Genereer een salt
            byte[] salt;
            new RNGCryptoServiceProvider().GetBytes(salt = new byte[16]);

            //Hash password + salt
            var pbkdf2 = new Rfc2898DeriveBytes(password, salt, 10000);
            byte[] hash = pbkdf2.GetBytes(20);

            //Combineer password + salt
            byte[] hashBytes = new byte[36];
            Array.Copy(salt, 0, hashBytes, 0, 16);
            Array.Copy(hash, 0, hashBytes, 16, 20);

            //Naar string for la database
            return Convert.ToBase64String(hashBytes);
        }

        public static bool PasswordCompare(string savedPasswordHash, string password)
        {
            //Als hash niet valid is, return false
            if (savedPasswordHash.Length != 48) return false;

            // Exctract bytes
            byte[] hashBytes = Convert.FromBase64String(savedPasswordHash);

            // Salt van hash
            byte[] salt = new byte[16];
            Array.Copy(hashBytes, 0, salt, 0, 16);

            // Compute hash van wachtwoord
            var pbkdf2 = new Rfc2898DeriveBytes(password, salt, 10000);
            byte[] hash = pbkdf2.GetBytes(20);

            // Compare hashes
            for (int i = 0; i < 20; i++)
                if (hashBytes[i + 16] != hash[i])
                    return false;
            return true;
        }

        #region Utils
        public static string DiertypesVanBool(bool[] diertypes)
        {
            List<string> dierenstrings = new List<string>();
            if (diertypes[0]) dierenstrings.Add("Hond");
            if (diertypes[1]) dierenstrings.Add("Kat");
            if (diertypes[2]) dierenstrings.Add("Knaagdier");
            if (diertypes[3]) dierenstrings.Add("Vogel");
            if (diertypes[4]) dierenstrings.Add("Reptiel");
            if (diertypes[5]) dierenstrings.Add("Amfibie");
            if (diertypes[6]) dierenstrings.Add("Insect");
            if (diertypes[7]) dierenstrings.Add("Vissen");
            return string.Join(", ", dierenstrings);
        }

        public static bool[] DiertypesNaarBool(string diertypes)
        {
            bool[] rtrn = new bool[8];
            foreach (string dier in diertypes.Split(", ".ToCharArray()))
            {
                switch (dier)
                {
                    case "Hond":
                        rtrn[0] = true;
                        break;
                    case "Kat":
                        rtrn[1] = true;
                        break;
                    case "Knaagdier":
                        rtrn[2] = true;
                        break;
                    case "Vogel":
                        rtrn[3] = true;
                        break;
                    case "Reptiel":
                        rtrn[4] = true;
                        break;
                    case "Amfibie":
                        rtrn[5] = true;
                        break;
                    case "Insect":
                        rtrn[6] = true;
                        break;
                    case "Vissen":
                        rtrn[7] = true;
                        break;
                }
            }
            return rtrn;
        }

        private static Gebruiker GebruikerVanData(SQLiteDataReader reader)
        {
            return new Gebruiker
            {
                userid = Convert.ToInt32(reader["userid"]),
                voornaam = (string)reader["voornaam"],
                achternaam = (string)reader["achternaam"],
                overmij = (string)reader["overmij"],
                verified = (bool)reader["verified"],
                admin = (bool)reader["admin"],
                vraagprijs = Convert.ToDouble(reader["vraagprijs"]),
                oppassen = (bool)reader["oppassen"],
                uitlaten = (bool)reader["uitlaten"],
                woonplaats = (string)reader["woonplaats"],
                diertypes = (string)reader["diertypes"],
                email = (string)reader["email"],
                password_hash = (string)reader["password"],
            };
        }

        private static SQLiteCommand GebruikerNaarData(SQLiteCommand cmd, Gebruiker gebruiker)
        {
            cmd.Parameters.Add("@userid", DbType.String).Value = gebruiker.userid;
            cmd.Parameters.Add("@voornaam", DbType.String).Value = gebruiker.voornaam;
            cmd.Parameters.Add("@achternaam", DbType.String).Value = gebruiker.achternaam;
            cmd.Parameters.Add("@overmij", DbType.String).Value = gebruiker.overmij;
            cmd.Parameters.Add("@verified", DbType.Boolean).Value = gebruiker.verified;
            cmd.Parameters.Add("@admin", DbType.Boolean).Value = gebruiker.admin;
            cmd.Parameters.Add("@vraagprijs", DbType.Double).Value = gebruiker.vraagprijs;
            cmd.Parameters.Add("@oppassen", DbType.Boolean).Value = gebruiker.oppassen;
            cmd.Parameters.Add("@uitlaten", DbType.Boolean).Value = gebruiker.uitlaten;
            cmd.Parameters.Add("@woonplaats", DbType.String).Value = gebruiker.woonplaats;
            cmd.Parameters.Add("@diertypes", DbType.String).Value = gebruiker.diertypes;
            cmd.Parameters.Add("@email", DbType.String).Value = gebruiker.email;
            cmd.Parameters.Add("@password", DbType.String).Value = gebruiker.password_hash;
            return cmd;
        }
        #endregion Utils
    }

    /// <summary>
    /// De data van een gebruiker, exclusief gebruikers id
    /// </summary>
    public struct Gebruiker
    {
        public int userid;
        public string voornaam;
        public string achternaam;
        public string overmij;
        public bool verified;
        public bool admin;
        public double vraagprijs;
        public bool oppassen;
        public bool uitlaten;
        public string woonplaats;
        public string diertypes;
        public string email;
        public string password_hash;
    }
}