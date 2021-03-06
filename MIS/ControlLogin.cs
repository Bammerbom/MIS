﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MIS
{
    public partial class ControlLogin : UserControl
    {
        public ControlLogin()
        {
            InitializeComponent();
        }

        private void buttonInloggen_Click(object sender, EventArgs e)
        {
            //Vraag variabelen op van WF
            string email = tbEmail.Text;
            string password = tbPassword.Text;

            //Zoek de gebruiker die de email matched
            Gebruiker gebruiker = new Gebruiker(); // C# doet vreselijk autistisch, dus gooi hier een standaard value in
            bool found = false;
            foreach(Gebruiker gebr in GebruikerManager.AlleGebruikers())
            {
                //Niet hoofdletter gevoelig
                if (!(gebr.email.ToLower() == email.ToLower())) continue;
                gebruiker = gebr;
                found = true;
            }

            //Check email
            if(!found)
            {
                MessageBox.Show("Je email adres is niet gevonden.");
                return;
            }
            
            //Check wachtwoord
            if(!GebruikerManager.PasswordCompare(gebruiker.password_hash, password))
            {
                MessageBox.Show("Je wachtwoord is incorrect.");
                return;
            }

            //Ga naar zoekscherm
            SessionManager.SetCurrentUser(gebruiker.userid);
            FormHome.Home.NaarZoeken();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormHome.Home.NaarZoeken();
            SessionManager.SetCurrentUser(null);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormHome.Home.Naar(new ControlMakenProfiel());
        }
    }
}
