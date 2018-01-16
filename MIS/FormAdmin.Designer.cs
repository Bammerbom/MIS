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
            this.label9 = new System.Windows.Forms.Label();
            this.RatingAdmin = new System.Windows.Forms.TextBox();
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
            ((System.ComponentModel.ISupportInitialize)(this.AdminDatagrid)).BeginInit();
            this.SuspendLayout();
            // 
            // AdminDatagrid
            // 
            this.AdminDatagrid.AllowUserToAddRows = false;
            this.AdminDatagrid.AllowUserToDeleteRows = false;
            this.AdminDatagrid.AllowUserToResizeColumns = false;
            this.AdminDatagrid.AllowUserToResizeRows = false;
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
            this.VoornaamAdmin.Location = new System.Drawing.Point(1272, 12);
            this.VoornaamAdmin.Name = "VoornaamAdmin";
            this.VoornaamAdmin.Size = new System.Drawing.Size(100, 20);
            this.VoornaamAdmin.TabIndex = 3;
            // 
            // AchternaamAdmin
            // 
            this.AchternaamAdmin.Location = new System.Drawing.Point(1272, 38);
            this.AchternaamAdmin.Name = "AchternaamAdmin";
            this.AchternaamAdmin.Size = new System.Drawing.Size(100, 20);
            this.AchternaamAdmin.TabIndex = 4;
            // 
            // WoonplaatsAdmin
            // 
            this.WoonplaatsAdmin.Location = new System.Drawing.Point(1272, 64);
            this.WoonplaatsAdmin.Name = "WoonplaatsAdmin";
            this.WoonplaatsAdmin.Size = new System.Drawing.Size(100, 20);
            this.WoonplaatsAdmin.TabIndex = 5;
            // 
            // VraagprijsAdmin
            // 
            this.VraagprijsAdmin.Location = new System.Drawing.Point(1272, 90);
            this.VraagprijsAdmin.Name = "VraagprijsAdmin";
            this.VraagprijsAdmin.Size = new System.Drawing.Size(100, 20);
            this.VraagprijsAdmin.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1178, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Voornaam";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1178, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Achternaam";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1178, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Woonplaats";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(1178, 93);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Vraagprijs";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(1181, 132);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Verified";
            // 
            // AdminAdminLabel
            // 
            this.AdminAdminLabel.AutoSize = true;
            this.AdminAdminLabel.Location = new System.Drawing.Point(1269, 131);
            this.AdminAdminLabel.Name = "AdminAdminLabel";
            this.AdminAdminLabel.Size = new System.Drawing.Size(36, 13);
            this.AdminAdminLabel.TabIndex = 12;
            this.AdminAdminLabel.Text = "Admin";
            // 
            // VerifiedAdmin
            // 
            this.VerifiedAdmin.AutoSize = true;
            this.VerifiedAdmin.Location = new System.Drawing.Point(1242, 132);
            this.VerifiedAdmin.Name = "VerifiedAdmin";
            this.VerifiedAdmin.Size = new System.Drawing.Size(15, 14);
            this.VerifiedAdmin.TabIndex = 13;
            this.VerifiedAdmin.UseVisualStyleBackColor = true;
            // 
            // AdminAdmin
            // 
            this.AdminAdmin.AutoSize = true;
            this.AdminAdmin.Location = new System.Drawing.Point(1318, 132);
            this.AdminAdmin.Name = "AdminAdmin";
            this.AdminAdmin.Size = new System.Drawing.Size(15, 14);
            this.AdminAdmin.TabIndex = 14;
            this.AdminAdmin.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(1181, 183);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "Oppassen";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(1269, 183);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(43, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "Uitlaten";
            // 
            // OppassenAdmin
            // 
            this.OppassenAdmin.AutoSize = true;
            this.OppassenAdmin.Location = new System.Drawing.Point(1242, 183);
            this.OppassenAdmin.Name = "OppassenAdmin";
            this.OppassenAdmin.Size = new System.Drawing.Size(15, 14);
            this.OppassenAdmin.TabIndex = 17;
            this.OppassenAdmin.UseVisualStyleBackColor = true;
            // 
            // UitlatenAdmin
            // 
            this.UitlatenAdmin.AutoSize = true;
            this.UitlatenAdmin.Location = new System.Drawing.Point(1318, 182);
            this.UitlatenAdmin.Name = "UitlatenAdmin";
            this.UitlatenAdmin.Size = new System.Drawing.Size(15, 14);
            this.UitlatenAdmin.TabIndex = 18;
            this.UitlatenAdmin.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(1181, 233);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(51, 13);
            this.label8.TabIndex = 19;
            this.label8.Text = "Diertypes";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(1178, 471);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(38, 13);
            this.label9.TabIndex = 20;
            this.label9.Text = "Rating";
            // 
            // RatingAdmin
            // 
            this.RatingAdmin.Location = new System.Drawing.Point(1272, 464);
            this.RatingAdmin.Name = "RatingAdmin";
            this.RatingAdmin.Size = new System.Drawing.Size(100, 20);
            this.RatingAdmin.TabIndex = 21;
            // 
            // UpdateButton
            // 
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
            this.AmfibieCheckboxAdmin.Location = new System.Drawing.Point(1184, 373);
            this.AmfibieCheckboxAdmin.Name = "AmfibieCheckboxAdmin";
            this.AmfibieCheckboxAdmin.Size = new System.Drawing.Size(60, 17);
            this.AmfibieCheckboxAdmin.TabIndex = 42;
            this.AmfibieCheckboxAdmin.Text = "Amfibie";
            this.AmfibieCheckboxAdmin.UseVisualStyleBackColor = true;
            // 
            // KatCheckboxAdmin
            // 
            this.KatCheckboxAdmin.AutoSize = true;
            this.KatCheckboxAdmin.Location = new System.Drawing.Point(1184, 281);
            this.KatCheckboxAdmin.Name = "KatCheckboxAdmin";
            this.KatCheckboxAdmin.Size = new System.Drawing.Size(42, 17);
            this.KatCheckboxAdmin.TabIndex = 41;
            this.KatCheckboxAdmin.Text = "Kat";
            this.KatCheckboxAdmin.UseVisualStyleBackColor = true;
            // 
            // VissenCheckboxAdmin
            // 
            this.VissenCheckboxAdmin.AutoSize = true;
            this.VissenCheckboxAdmin.Location = new System.Drawing.Point(1184, 419);
            this.VissenCheckboxAdmin.Name = "VissenCheckboxAdmin";
            this.VissenCheckboxAdmin.Size = new System.Drawing.Size(57, 17);
            this.VissenCheckboxAdmin.TabIndex = 40;
            this.VissenCheckboxAdmin.Text = "Vissen";
            this.VissenCheckboxAdmin.UseVisualStyleBackColor = true;
            // 
            // InsectCheckboxAdmin
            // 
            this.InsectCheckboxAdmin.AutoSize = true;
            this.InsectCheckboxAdmin.Location = new System.Drawing.Point(1184, 396);
            this.InsectCheckboxAdmin.Name = "InsectCheckboxAdmin";
            this.InsectCheckboxAdmin.Size = new System.Drawing.Size(55, 17);
            this.InsectCheckboxAdmin.TabIndex = 39;
            this.InsectCheckboxAdmin.Text = "Insect";
            this.InsectCheckboxAdmin.UseVisualStyleBackColor = true;
            // 
            // VogelCheckboxAdmin
            // 
            this.VogelCheckboxAdmin.AutoSize = true;
            this.VogelCheckboxAdmin.Location = new System.Drawing.Point(1184, 327);
            this.VogelCheckboxAdmin.Name = "VogelCheckboxAdmin";
            this.VogelCheckboxAdmin.Size = new System.Drawing.Size(53, 17);
            this.VogelCheckboxAdmin.TabIndex = 38;
            this.VogelCheckboxAdmin.Text = "Vogel";
            this.VogelCheckboxAdmin.UseVisualStyleBackColor = true;
            // 
            // ReptielCheckboxAdmin
            // 
            this.ReptielCheckboxAdmin.AutoSize = true;
            this.ReptielCheckboxAdmin.Location = new System.Drawing.Point(1184, 350);
            this.ReptielCheckboxAdmin.Name = "ReptielCheckboxAdmin";
            this.ReptielCheckboxAdmin.Size = new System.Drawing.Size(59, 17);
            this.ReptielCheckboxAdmin.TabIndex = 37;
            this.ReptielCheckboxAdmin.Text = "Reptiel";
            this.ReptielCheckboxAdmin.UseVisualStyleBackColor = true;
            // 
            // KnaagdierCheckboxAdmin
            // 
            this.KnaagdierCheckboxAdmin.AutoSize = true;
            this.KnaagdierCheckboxAdmin.Location = new System.Drawing.Point(1184, 304);
            this.KnaagdierCheckboxAdmin.Name = "KnaagdierCheckboxAdmin";
            this.KnaagdierCheckboxAdmin.Size = new System.Drawing.Size(74, 17);
            this.KnaagdierCheckboxAdmin.TabIndex = 36;
            this.KnaagdierCheckboxAdmin.Text = "Knaagdier";
            this.KnaagdierCheckboxAdmin.UseVisualStyleBackColor = true;
            // 
            // HondCheckboxAdmin
            // 
            this.HondCheckboxAdmin.AutoSize = true;
            this.HondCheckboxAdmin.Location = new System.Drawing.Point(1184, 258);
            this.HondCheckboxAdmin.Name = "HondCheckboxAdmin";
            this.HondCheckboxAdmin.Size = new System.Drawing.Size(52, 17);
            this.HondCheckboxAdmin.TabIndex = 35;
            this.HondCheckboxAdmin.Text = "Hond";
            this.HondCheckboxAdmin.UseVisualStyleBackColor = true;
            // 
            // VerwijderButton
            // 
            this.VerwijderButton.Location = new System.Drawing.Point(1184, 726);
            this.VerwijderButton.Name = "VerwijderButton";
            this.VerwijderButton.Size = new System.Drawing.Size(75, 23);
            this.VerwijderButton.TabIndex = 43;
            this.VerwijderButton.Text = "Verwijderen";
            this.VerwijderButton.UseVisualStyleBackColor = true;
            this.VerwijderButton.Click += new System.EventHandler(this.VerwijderButton_Click);
            // 
            // FormAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1384, 761);
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
            this.Controls.Add(this.RatingAdmin);
            this.Controls.Add(this.label9);
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
            this.Text = "FormAdmin";
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
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox RatingAdmin;
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
    }
}