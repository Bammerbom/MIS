namespace MIS
{
    partial class FormZoeken
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
            this.dateTimePickerVan = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerTot = new System.Windows.Forms.DateTimePicker();
            this.VanLabel = new System.Windows.Forms.Label();
            this.TotLabel = new System.Windows.Forms.Label();
            this.@__Label = new System.Windows.Forms.Label();
            this.ZoekButton = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.ZoektextBox = new System.Windows.Forms.TextBox();
            this.HondKatCheckBox = new System.Windows.Forms.CheckBox();
            this.KnaagdierCheckBox = new System.Windows.Forms.CheckBox();
            this.ReptielAmfibieCheckBox = new System.Windows.Forms.CheckBox();
            this.VogelCheckBox = new System.Windows.Forms.CheckBox();
            this.InsectCheckBox = new System.Windows.Forms.CheckBox();
            this.AndersCheckBox = new System.Windows.Forms.CheckBox();
            this.LocatieLabel = new System.Windows.Forms.Label();
            this.SDierLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // dateTimePickerVan
            // 
            this.dateTimePickerVan.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerVan.Location = new System.Drawing.Point(717, 32);
            this.dateTimePickerVan.Name = "dateTimePickerVan";
            this.dateTimePickerVan.Size = new System.Drawing.Size(99, 20);
            this.dateTimePickerVan.TabIndex = 0;
            // 
            // dateTimePickerTot
            // 
            this.dateTimePickerTot.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerTot.Location = new System.Drawing.Point(851, 32);
            this.dateTimePickerTot.Name = "dateTimePickerTot";
            this.dateTimePickerTot.Size = new System.Drawing.Size(99, 20);
            this.dateTimePickerTot.TabIndex = 1;
            // 
            // VanLabel
            // 
            this.VanLabel.AutoSize = true;
            this.VanLabel.Location = new System.Drawing.Point(714, 16);
            this.VanLabel.Name = "VanLabel";
            this.VanLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.VanLabel.Size = new System.Drawing.Size(29, 13);
            this.VanLabel.TabIndex = 2;
            this.VanLabel.Text = "Van:";
            // 
            // TotLabel
            // 
            this.TotLabel.AutoSize = true;
            this.TotLabel.Location = new System.Drawing.Point(848, 16);
            this.TotLabel.Name = "TotLabel";
            this.TotLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.TotLabel.Size = new System.Drawing.Size(26, 13);
            this.TotLabel.TabIndex = 3;
            this.TotLabel.Text = "Tot:";
            // 
            // __Label
            // 
            this.@__Label.AutoSize = true;
            this.@__Label.Location = new System.Drawing.Point(822, 38);
            this.@__Label.Name = "__Label";
            this.@__Label.Size = new System.Drawing.Size(25, 13);
            this.@__Label.TabIndex = 4;
            this.@__Label.Text = "------";
            // 
            // ZoekButton
            // 
            this.ZoekButton.Location = new System.Drawing.Point(559, 31);
            this.ZoekButton.Name = "ZoekButton";
            this.ZoekButton.Size = new System.Drawing.Size(75, 21);
            this.ZoekButton.TabIndex = 5;
            this.ZoekButton.Text = "Zoek";
            this.ZoekButton.UseVisualStyleBackColor = true;
            // 
            // ZoektextBox
            // 
            this.ZoektextBox.Location = new System.Drawing.Point(453, 32);
            this.ZoektextBox.Name = "ZoektextBox";
            this.ZoektextBox.Size = new System.Drawing.Size(100, 20);
            this.ZoektextBox.TabIndex = 6;
            // 
            // HondKatCheckBox
            // 
            this.HondKatCheckBox.AutoSize = true;
            this.HondKatCheckBox.Location = new System.Drawing.Point(75, 31);
            this.HondKatCheckBox.Name = "HondKatCheckBox";
            this.HondKatCheckBox.Size = new System.Drawing.Size(73, 17);
            this.HondKatCheckBox.TabIndex = 7;
            this.HondKatCheckBox.Text = "Hond/Kat";
            this.HondKatCheckBox.UseVisualStyleBackColor = true;
            // 
            // KnaagdierCheckBox
            // 
            this.KnaagdierCheckBox.AutoSize = true;
            this.KnaagdierCheckBox.Location = new System.Drawing.Point(74, 54);
            this.KnaagdierCheckBox.Name = "KnaagdierCheckBox";
            this.KnaagdierCheckBox.Size = new System.Drawing.Size(74, 17);
            this.KnaagdierCheckBox.TabIndex = 8;
            this.KnaagdierCheckBox.Text = "Knaagdier";
            this.KnaagdierCheckBox.UseVisualStyleBackColor = true;
            // 
            // ReptielAmfibieCheckBox
            // 
            this.ReptielAmfibieCheckBox.AutoSize = true;
            this.ReptielAmfibieCheckBox.Location = new System.Drawing.Point(50, 77);
            this.ReptielAmfibieCheckBox.Name = "ReptielAmfibieCheckBox";
            this.ReptielAmfibieCheckBox.Size = new System.Drawing.Size(98, 17);
            this.ReptielAmfibieCheckBox.TabIndex = 9;
            this.ReptielAmfibieCheckBox.Text = "Reptiel/Amfibie";
            this.ReptielAmfibieCheckBox.UseVisualStyleBackColor = true;
            // 
            // VogelCheckBox
            // 
            this.VogelCheckBox.AutoSize = true;
            this.VogelCheckBox.Location = new System.Drawing.Point(95, 100);
            this.VogelCheckBox.Name = "VogelCheckBox";
            this.VogelCheckBox.Size = new System.Drawing.Size(53, 17);
            this.VogelCheckBox.TabIndex = 10;
            this.VogelCheckBox.Text = "Vogel";
            this.VogelCheckBox.UseVisualStyleBackColor = true;
            // 
            // InsectCheckBox
            // 
            this.InsectCheckBox.AutoSize = true;
            this.InsectCheckBox.Location = new System.Drawing.Point(93, 123);
            this.InsectCheckBox.Name = "InsectCheckBox";
            this.InsectCheckBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.InsectCheckBox.Size = new System.Drawing.Size(55, 17);
            this.InsectCheckBox.TabIndex = 11;
            this.InsectCheckBox.Text = "Insect";
            this.InsectCheckBox.UseVisualStyleBackColor = true;
            // 
            // AndersCheckBox
            // 
            this.AndersCheckBox.AutoSize = true;
            this.AndersCheckBox.Location = new System.Drawing.Point(89, 146);
            this.AndersCheckBox.Name = "AndersCheckBox";
            this.AndersCheckBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.AndersCheckBox.Size = new System.Drawing.Size(59, 17);
            this.AndersCheckBox.TabIndex = 12;
            this.AndersCheckBox.Text = "Anders";
            this.AndersCheckBox.UseVisualStyleBackColor = true;
            // 
            // LocatieLabel
            // 
            this.LocatieLabel.AutoSize = true;
            this.LocatieLabel.Location = new System.Drawing.Point(405, 35);
            this.LocatieLabel.Name = "LocatieLabel";
            this.LocatieLabel.Size = new System.Drawing.Size(42, 13);
            this.LocatieLabel.TabIndex = 13;
            this.LocatieLabel.Text = "Locatie";
            // 
            // SDierLabel
            // 
            this.SDierLabel.AutoSize = true;
            this.SDierLabel.Location = new System.Drawing.Point(12, 31);
            this.SDierLabel.Name = "SDierLabel";
            this.SDierLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.SDierLabel.Size = new System.Drawing.Size(57, 13);
            this.SDierLabel.TabIndex = 14;
            this.SDierLabel.Text = "Soort Dier:";
            // 
            // FormZoeken
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 661);
            this.Controls.Add(this.SDierLabel);
            this.Controls.Add(this.LocatieLabel);
            this.Controls.Add(this.AndersCheckBox);
            this.Controls.Add(this.InsectCheckBox);
            this.Controls.Add(this.VogelCheckBox);
            this.Controls.Add(this.ReptielAmfibieCheckBox);
            this.Controls.Add(this.KnaagdierCheckBox);
            this.Controls.Add(this.HondKatCheckBox);
            this.Controls.Add(this.ZoektextBox);
            this.Controls.Add(this.ZoekButton);
            this.Controls.Add(this.@__Label);
            this.Controls.Add(this.TotLabel);
            this.Controls.Add(this.VanLabel);
            this.Controls.Add(this.dateTimePickerTot);
            this.Controls.Add(this.dateTimePickerVan);
            this.Name = "FormZoeken";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FormZoeken_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimePickerVan;
        private System.Windows.Forms.DateTimePicker dateTimePickerTot;
        private System.Windows.Forms.Label VanLabel;
        private System.Windows.Forms.Label TotLabel;
        private System.Windows.Forms.Label __Label;
        private System.Windows.Forms.Button ZoekButton;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.TextBox ZoektextBox;
        private System.Windows.Forms.CheckBox HondKatCheckBox;
        private System.Windows.Forms.CheckBox KnaagdierCheckBox;
        private System.Windows.Forms.CheckBox ReptielAmfibieCheckBox;
        private System.Windows.Forms.CheckBox VogelCheckBox;
        private System.Windows.Forms.CheckBox InsectCheckBox;
        private System.Windows.Forms.CheckBox AndersCheckBox;
        private System.Windows.Forms.Label LocatieLabel;
        private System.Windows.Forms.Label SDierLabel;
    }
}

