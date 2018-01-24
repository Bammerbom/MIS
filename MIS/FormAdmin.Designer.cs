namespace MIS
{
    partial class FormAdmin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.AdminDatagrid = new System.Windows.Forms.DataGridView();
            this.VoornaamAdmin = new System.Windows.Forms.TextBox();
            this.AchternaamAdmin = new System.Windows.Forms.TextBox();
            this.WoonplaatsAdmin = new System.Windows.Forms.TextBox();
            this.VraagprijsAdmin = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.AdminAdminLabel = new System.Windows.Forms.Label();
            this.VerifiedAdmin = new System.Windows.Forms.CheckBox();
            this.AdminAdmin = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.OppassenAdmin = new System.Windows.Forms.CheckBox();
            this.UitlatenAdmin = new System.Windows.Forms.CheckBox();
            this.label8 = new System.Windows.Forms.Label();
            this.UpdateButton = new System.Windows.Forms.Button();
            this.AmfibieCheckboxAdmin = new System.Windows.Forms.CheckBox();
            this.KatCheckboxAdmin = new System.Windows.Forms.CheckBox();
            this.VissenCheckboxAdmin = new System.Windows.Forms.CheckBox();
            this.InsectCheckboxAdmin = new System.Windows.Forms.CheckBox();
            this.VogelCheckboxAdmin = new System.Windows.Forms.CheckBox();
            this.ReptielCheckboxAdmin = new System.Windows.Forms.CheckBox();
            this.KnaagdierCheckboxAdmin = new System.Windows.Forms.CheckBox();
            this.HondCheckboxAdmin = new System.Windows.Forms.CheckBox();
            this.VerwijderButton = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.EmailAdmin = new System.Windows.Forms.TextBox();
            this.WachtwoordAdmin = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.AdminDatagrid)).BeginInit();
            this.SuspendLayout();
            // 
            // AdminDatagrid
            // 
            this.AdminDatagrid.AllowUserToAddRows = false;
            this.AdminDatagrid.AllowUserToDeleteRows = false;
            this.AdminDatagrid.AllowUserToResizeColumns = false;
            this.AdminDatagrid.AllowUserToResizeRows = false;
            this.AdminDatagrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.AdminDatagrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AdminDatagrid.Location = new System.Drawing.Point(13, 13);
            this.AdminDatagrid.Name = "AdminDatagrid";
            this.AdminDatagrid.ReadOnly = true;
            this.AdminDatagrid.Size = new System.Drawing.Size(1159, 736);
            this.AdminDatagrid.TabIndex = 0;
            this.AdminDatagrid.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.AdminDatagrid_RowHeaderMouseClick_1);
            // 
            // VoornaamAdmin
            // 
            this.VoornaamAdmin.Location = new System.Drawing.Point(1281, 15);
            this.VoornaamAdmin.Name = "VoornaamAdmin";
            this.VoornaamAdmin.Size = new System.Drawing.Size(100, 20);
            this.VoornaamAdmin.TabIndex = 3;
            // 
            // AchternaamAdmin
            // 
            this.AchternaamAdmin.Location = new System.Drawing.Point(1281, 42);
            this.AchternaamAdmin.Name = "AchternaamAdmin";
            this.AchternaamAdmin.Size = new System.Drawing.Size(100, 20);
            this.AchternaamAdmin.TabIndex = 4;
            // 
            // WoonplaatsAdmin
            // 
            this.WoonplaatsAdmin.Location = new System.Drawing.Point(1281, 68);
            this.WoonplaatsAdmin.Name = "WoonplaatsAdmin";
            this.WoonplaatsAdmin.Size = new System.Drawing.Size(100, 20);
            this.WoonplaatsAdmin.TabIndex = 5;
            // 
            // VraagprijsAdmin
            // 
            this.VraagprijsAdmin.Location = new System.Drawing.Point(1281, 94);
            this.VraagprijsAdmin.Name = "VraagprijsAdmin";
            this.VraagprijsAdmin.Size = new System.Drawing.Size(100, 20);
            this.VraagprijsAdmin.TabIndex = 6;
            this.VraagprijsAdmin.TextChanged += new System.EventHandler(this.VraagprijsAdmin_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(1178, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 18);
            this.label1.TabIndex = 7;
            this.label1.Text = "Voornaam";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(1178, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 18);
            this.label2.TabIndex = 8;
            this.label2.Text = "Achternaam";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(1177, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 18);
            this.label3.TabIndex = 9;
            this.label3.Text = "Woonplaats";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(1178, 96);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 18);
            this.label4.TabIndex = 10;
            this.label4.Text = "Vraagprijs";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(1181, 132);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 18);
            this.label5.TabIndex = 11;
            this.label5.Text = "Verified";
            // 
            // AdminAdminLabel
            // 
            this.AdminAdminLabel.AutoSize = true;
            this.AdminAdminLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AdminAdminLabel.Location = new System.Drawing.Point(1280, 131);
            this.AdminAdminLabel.Name = "AdminAdminLabel";
            this.AdminAdminLabel.Size = new System.Drawing.Size(49, 18);
            this.AdminAdminLabel.TabIndex = 12;
            this.AdminAdminLabel.Text = "Admin";
            // 
            // VerifiedAdmin
            // 
            this.VerifiedAdmin.AutoSize = true;
            this.VerifiedAdmin.Location = new System.Drawing.Point(1262, 135);
            this.VerifiedAdmin.Name = "VerifiedAdmin";
            this.VerifiedAdmin.Size = new System.Drawing.Size(15, 14);
            this.VerifiedAdmin.TabIndex = 13;
            this.VerifiedAdmin.UseVisualStyleBackColor = true;
            // 
            // AdminAdmin
            // 
            this.AdminAdmin.AutoSize = true;
            this.AdminAdmin.Location = new System.Drawing.Point(1356, 135);
            this.AdminAdmin.Name = "AdminAdmin";
            this.AdminAdmin.Size = new System.Drawing.Size(15, 14);
            this.AdminAdmin.TabIndex = 14;
            this.AdminAdmin.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(1178, 183);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 18);
            this.label6.TabIndex = 15;
            this.label6.Text = "Oppassen";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(1280, 183);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 18);
            this.label7.TabIndex = 16;
            this.label7.Text = "Uitlaten";
            // 
            // OppassenAdmin
            // 
            this.OppassenAdmin.AutoSize = true;
            this.OppassenAdmin.Location = new System.Drawing.Point(1263, 187);
            this.OppassenAdmin.Name = "OppassenAdmin";
            this.OppassenAdmin.Size = new System.Drawing.Size(15, 14);
            this.OppassenAdmin.TabIndex = 17;
            this.OppassenAdmin.UseVisualStyleBackColor = true;
            // 
            // UitlatenAdmin
            // 
            this.UitlatenAdmin.AutoSize = true;
            this.UitlatenAdmin.Location = new System.Drawing.Point(1356, 187);
            this.UitlatenAdmin.Name = "UitlatenAdmin";
            this.UitlatenAdmin.Size = new System.Drawing.Size(15, 14);
            this.UitlatenAdmin.TabIndex = 18;
            this.UitlatenAdmin.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(1178, 237);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(79, 18);
            this.label8.TabIndex = 19;
            this.label8.Text = "Diertypes";
            // 
            // UpdateButton
            // 
            this.UpdateButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UpdateButton.Location = new System.Drawing.Point(1297, 726);
            this.UpdateButton.Name = "UpdateButton";
            this.UpdateButton.Size = new System.Drawing.Size(75, 23);
            this.UpdateButton.TabIndex = 22;
            this.UpdateButton.Text = "Update";
            this.UpdateButton.UseVisualStyleBackColor = true;
            this.UpdateButton.Click += new System.EventHandler(this.UpdateButton_Click);
            // 
            // AmfibieCheckboxAdmin
            // 
            this.AmfibieCheckboxAdmin.AutoSize = true;
            this.AmfibieCheckboxAdmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AmfibieCheckboxAdmin.Location = new System.Drawing.Point(1184, 373);
            this.AmfibieCheckboxAdmin.Name = "AmfibieCheckboxAdmin";
            this.AmfibieCheckboxAdmin.Size = new System.Drawing.Size(75, 22);
            this.AmfibieCheckboxAdmin.TabIndex = 42;
            this.AmfibieCheckboxAdmin.Text = "Amfibie";
            this.AmfibieCheckboxAdmin.UseVisualStyleBackColor = true;
            // 
            // KatCheckboxAdmin
            // 
            this.KatCheckboxAdmin.AutoSize = true;
            this.KatCheckboxAdmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KatCheckboxAdmin.Location = new System.Drawing.Point(1184, 281);
            this.KatCheckboxAdmin.Name = "KatCheckboxAdmin";
            this.KatCheckboxAdmin.Size = new System.Drawing.Size(49, 22);
            this.KatCheckboxAdmin.TabIndex = 41;
            this.KatCheckboxAdmin.Text = "Kat";
            this.KatCheckboxAdmin.UseVisualStyleBackColor = true;
            // 
            // VissenCheckboxAdmin
            // 
            this.VissenCheckboxAdmin.AutoSize = true;
            this.VissenCheckboxAdmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VissenCheckboxAdmin.Location = new System.Drawing.Point(1184, 419);
            this.VissenCheckboxAdmin.Name = "VissenCheckboxAdmin";
            this.VissenCheckboxAdmin.Size = new System.Drawing.Size(71, 22);
            this.VissenCheckboxAdmin.TabIndex = 40;
            this.VissenCheckboxAdmin.Text = "Vissen";
            this.VissenCheckboxAdmin.UseVisualStyleBackColor = true;
            // 
            // InsectCheckboxAdmin
            // 
            this.InsectCheckboxAdmin.AutoSize = true;
            this.InsectCheckboxAdmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InsectCheckboxAdmin.Location = new System.Drawing.Point(1184, 396);
            this.InsectCheckboxAdmin.Name = "InsectCheckboxAdmin";
            this.InsectCheckboxAdmin.Size = new System.Drawing.Size(66, 22);
            this.InsectCheckboxAdmin.TabIndex = 39;
            this.InsectCheckboxAdmin.Text = "Insect";
            this.InsectCheckboxAdmin.UseVisualStyleBackColor = true;
            // 
            // VogelCheckboxAdmin
            // 
            this.VogelCheckboxAdmin.AutoSize = true;
            this.VogelCheckboxAdmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VogelCheckboxAdmin.Location = new System.Drawing.Point(1184, 327);
            this.VogelCheckboxAdmin.Name = "VogelCheckboxAdmin";
            this.VogelCheckboxAdmin.Size = new System.Drawing.Size(64, 22);
            this.VogelCheckboxAdmin.TabIndex = 38;
            this.VogelCheckboxAdmin.Text = "Vogel";
            this.VogelCheckboxAdmin.UseVisualStyleBackColor = true;
            // 
            // ReptielCheckboxAdmin
            // 
            this.ReptielCheckboxAdmin.AutoSize = true;
            this.ReptielCheckboxAdmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReptielCheckboxAdmin.Location = new System.Drawing.Point(1184, 350);
            this.ReptielCheckboxAdmin.Name = "ReptielCheckboxAdmin";
            this.ReptielCheckboxAdmin.Size = new System.Drawing.Size(72, 22);
            this.ReptielCheckboxAdmin.TabIndex = 37;
            this.ReptielCheckboxAdmin.Text = "Reptiel";
            this.ReptielCheckboxAdmin.UseVisualStyleBackColor = true;
            // 
            // KnaagdierCheckboxAdmin
            // 
            this.KnaagdierCheckboxAdmin.AutoSize = true;
            this.KnaagdierCheckboxAdmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KnaagdierCheckboxAdmin.Location = new System.Drawing.Point(1184, 304);
            this.KnaagdierCheckboxAdmin.Name = "KnaagdierCheckboxAdmin";
            this.KnaagdierCheckboxAdmin.Size = new System.Drawing.Size(93, 22);
            this.KnaagdierCheckboxAdmin.TabIndex = 36;
            this.KnaagdierCheckboxAdmin.Text = "Knaagdier";
            this.KnaagdierCheckboxAdmin.UseVisualStyleBackColor = true;
            // 
            // HondCheckboxAdmin
            // 
            this.HondCheckboxAdmin.AutoSize = true;
            this.HondCheckboxAdmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HondCheckboxAdmin.Location = new System.Drawing.Point(1184, 258);
            this.HondCheckboxAdmin.Name = "HondCheckboxAdmin";
            this.HondCheckboxAdmin.Size = new System.Drawing.Size(63, 22);
            this.HondCheckboxAdmin.TabIndex = 35;
            this.HondCheckboxAdmin.Text = "Hond";
            this.HondCheckboxAdmin.UseVisualStyleBackColor = true;
            // 
            // VerwijderButton
            // 
            this.VerwijderButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VerwijderButton.Location = new System.Drawing.Point(1184, 726);
            this.VerwijderButton.Name = "VerwijderButton";
            this.VerwijderButton.Size = new System.Drawing.Size(81, 23);
            this.VerwijderButton.TabIndex = 43;
            this.VerwijderButton.Text = "Verwijderen";
            this.VerwijderButton.UseVisualStyleBackColor = true;
            this.VerwijderButton.Click += new System.EventHandler(this.VerwijderButton_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(1175, 450);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(50, 18);
            this.label10.TabIndex = 44;
            this.label10.Text = "Email";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(1177, 494);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(103, 18);
            this.label11.TabIndex = 45;
            this.label11.Text = "Wachtwoord";
            // 
            // EmailAdmin
            // 
            this.EmailAdmin.Location = new System.Drawing.Point(1178, 471);
            this.EmailAdmin.Name = "EmailAdmin";
            this.EmailAdmin.Size = new System.Drawing.Size(114, 20);
            this.EmailAdmin.TabIndex = 46;
            // 
            // WachtwoordAdmin
            // 
            this.WachtwoordAdmin.Location = new System.Drawing.Point(1178, 515);
            this.WachtwoordAdmin.Name = "WachtwoordAdmin";
            this.WachtwoordAdmin.Size = new System.Drawing.Size(117, 20);
            this.WachtwoordAdmin.TabIndex = 47;
            this.WachtwoordAdmin.TextChanged += new System.EventHandler(this.WachtwoordAdmin_TextChanged);
            // 
            // FormAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1384, 761);
            this.Controls.Add(this.WachtwoordAdmin);
            this.Controls.Add(this.EmailAdmin);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.VerwijderButton);
            this.Controls.Add(this.AmfibieCheckboxAdmin);
            this.Controls.Add(this.KatCheckboxAdmin);
            this.Controls.Add(this.VissenCheckboxAdmin);
            this.Controls.Add(this.InsectCheckboxAdmin);
            this.Controls.Add(this.VogelCheckboxAdmin);
            this.Controls.Add(this.ReptielCheckboxAdmin);
            this.Controls.Add(this.KnaagdierCheckboxAdmin);
            this.Controls.Add(this.HondCheckboxAdmin);
            this.Controls.Add(this.UpdateButton);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.UitlatenAdmin);
            this.Controls.Add(this.OppassenAdmin);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.AdminAdmin);
            this.Controls.Add(this.VerifiedAdmin);
            this.Controls.Add(this.AdminAdminLabel);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.VraagprijsAdmin);
            this.Controls.Add(this.WoonplaatsAdmin);
            this.Controls.Add(this.AchternaamAdmin);
            this.Controls.Add(this.VoornaamAdmin);
            this.Controls.Add(this.AdminDatagrid);
            this.Name = "FormAdmin";
            this.Text = "Pet & Breakfast: Admin Pagina";
            this.Load += new System.EventHandler(this.FormAdmin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.AdminDatagrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView AdminDatagrid;
        private System.Windows.Forms.TextBox VoornaamAdmin;
        private System.Windows.Forms.TextBox AchternaamAdmin;
        private System.Windows.Forms.TextBox WoonplaatsAdmin;
        private System.Windows.Forms.TextBox VraagprijsAdmin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label AdminAdminLabel;
        private System.Windows.Forms.CheckBox VerifiedAdmin;
        private System.Windows.Forms.CheckBox AdminAdmin;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.CheckBox OppassenAdmin;
        private System.Windows.Forms.CheckBox UitlatenAdmin;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button UpdateButton;
        private System.Windows.Forms.CheckBox AmfibieCheckboxAdmin;
        private System.Windows.Forms.CheckBox KatCheckboxAdmin;
        private System.Windows.Forms.CheckBox VissenCheckboxAdmin;
        private System.Windows.Forms.CheckBox InsectCheckboxAdmin;
        private System.Windows.Forms.CheckBox VogelCheckboxAdmin;
        private System.Windows.Forms.CheckBox ReptielCheckboxAdmin;
        private System.Windows.Forms.CheckBox KnaagdierCheckboxAdmin;
        private System.Windows.Forms.CheckBox HondCheckboxAdmin;
        private System.Windows.Forms.Button VerwijderButton;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox EmailAdmin;
        private System.Windows.Forms.TextBox WachtwoordAdmin;
    }
}