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
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.label1 = new System.Windows.Forms.Label();
            this.AndersCheckBox = new System.Windows.Forms.CheckBox();
            this.InsectCheckBox = new System.Windows.Forms.CheckBox();
            this.SDierLabel = new System.Windows.Forms.Label();
            this.LocatieLabel = new System.Windows.Forms.Label();
            this.VogelCheckBox = new System.Windows.Forms.CheckBox();
            this.ReptielAmfibieCheckBox = new System.Windows.Forms.CheckBox();
            this.KnaagdierCheckBox = new System.Windows.Forms.CheckBox();
            this.HondKatCheckBox = new System.Windows.Forms.CheckBox();
            this.ZoektextBox = new System.Windows.Forms.TextBox();
            this.ZoekButton = new System.Windows.Forms.Button();
            this.@__Label = new System.Windows.Forms.Label();
            this.TotLabel = new System.Windows.Forms.Label();
            this.VanLabel = new System.Windows.Forms.Label();
            this.dateTimePickerTot = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerVan = new System.Windows.Forms.DateTimePicker();
            this.ExtraLabel = new System.Windows.Forms.Label();
            this.OppasCheckBox = new System.Windows.Forms.CheckBox();
            this.UitlaatCheckBox = new System.Windows.Forms.CheckBox();
            this.VerifiedCheckBox = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(-1, 92);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1123, 13);
            this.label1.TabIndex = 48;
            this.label1.Text = "_________________________________________________________________________________" +
    "________________________________________________________________________________" +
    "_________________________";
            // 
            // AndersCheckBox
            // 
            this.AndersCheckBox.AutoSize = true;
            this.AndersCheckBox.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.AndersCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AndersCheckBox.Location = new System.Drawing.Point(523, 72);
            this.AndersCheckBox.Name = "AndersCheckBox";
            this.AndersCheckBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.AndersCheckBox.Size = new System.Drawing.Size(72, 21);
            this.AndersCheckBox.TabIndex = 47;
            this.AndersCheckBox.Text = "Anders";
            this.AndersCheckBox.UseVisualStyleBackColor = true;
            this.AndersCheckBox.CheckedChanged += new System.EventHandler(this.Huisdierbox_CheckedChanged);
            // 
            // InsectCheckBox
            // 
            this.InsectCheckBox.AutoSize = true;
            this.InsectCheckBox.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.InsectCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InsectCheckBox.Location = new System.Drawing.Point(531, 53);
            this.InsectCheckBox.Name = "InsectCheckBox";
            this.InsectCheckBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.InsectCheckBox.Size = new System.Drawing.Size(64, 21);
            this.InsectCheckBox.TabIndex = 46;
            this.InsectCheckBox.Text = "Insect";
            this.InsectCheckBox.UseVisualStyleBackColor = true;
            this.InsectCheckBox.CheckedChanged += new System.EventHandler(this.Huisdierbox_CheckedChanged);
            // 
            // SDierLabel
            // 
            this.SDierLabel.AutoSize = true;
            this.SDierLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SDierLabel.Location = new System.Drawing.Point(384, 15);
            this.SDierLabel.Name = "SDierLabel";
            this.SDierLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.SDierLabel.Size = new System.Drawing.Size(76, 17);
            this.SDierLabel.TabIndex = 45;
            this.SDierLabel.Text = "Soort Dier:";
            // 
            // LocatieLabel
            // 
            this.LocatieLabel.AutoSize = true;
            this.LocatieLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LocatieLabel.Location = new System.Drawing.Point(6, 15);
            this.LocatieLabel.Name = "LocatieLabel";
            this.LocatieLabel.Size = new System.Drawing.Size(87, 17);
            this.LocatieLabel.TabIndex = 44;
            this.LocatieLabel.Text = "Woonplaats:";
            // 
            // VogelCheckBox
            // 
            this.VogelCheckBox.AutoSize = true;
            this.VogelCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VogelCheckBox.Location = new System.Drawing.Point(410, 72);
            this.VogelCheckBox.Name = "VogelCheckBox";
            this.VogelCheckBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.VogelCheckBox.Size = new System.Drawing.Size(63, 21);
            this.VogelCheckBox.TabIndex = 43;
            this.VogelCheckBox.Text = "Vogel";
            this.VogelCheckBox.UseVisualStyleBackColor = true;
            this.VogelCheckBox.CheckedChanged += new System.EventHandler(this.Huisdierbox_CheckedChanged);
            // 
            // ReptielAmfibieCheckBox
            // 
            this.ReptielAmfibieCheckBox.AutoSize = true;
            this.ReptielAmfibieCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReptielAmfibieCheckBox.Location = new System.Drawing.Point(474, 33);
            this.ReptielAmfibieCheckBox.Name = "ReptielAmfibieCheckBox";
            this.ReptielAmfibieCheckBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ReptielAmfibieCheckBox.Size = new System.Drawing.Size(121, 21);
            this.ReptielAmfibieCheckBox.TabIndex = 42;
            this.ReptielAmfibieCheckBox.Text = "Reptiel/Amfibie";
            this.ReptielAmfibieCheckBox.UseVisualStyleBackColor = true;
            this.ReptielAmfibieCheckBox.CheckedChanged += new System.EventHandler(this.Huisdierbox_CheckedChanged);
            // 
            // KnaagdierCheckBox
            // 
            this.KnaagdierCheckBox.AutoSize = true;
            this.KnaagdierCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KnaagdierCheckBox.Location = new System.Drawing.Point(381, 53);
            this.KnaagdierCheckBox.Name = "KnaagdierCheckBox";
            this.KnaagdierCheckBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.KnaagdierCheckBox.Size = new System.Drawing.Size(92, 21);
            this.KnaagdierCheckBox.TabIndex = 41;
            this.KnaagdierCheckBox.Text = "Knaagdier";
            this.KnaagdierCheckBox.UseVisualStyleBackColor = true;
            this.KnaagdierCheckBox.CheckedChanged += new System.EventHandler(this.Huisdierbox_CheckedChanged);
            // 
            // HondKatCheckBox
            // 
            this.HondKatCheckBox.AutoSize = true;
            this.HondKatCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HondKatCheckBox.Location = new System.Drawing.Point(387, 33);
            this.HondKatCheckBox.Name = "HondKatCheckBox";
            this.HondKatCheckBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.HondKatCheckBox.Size = new System.Drawing.Size(86, 21);
            this.HondKatCheckBox.TabIndex = 40;
            this.HondKatCheckBox.Text = "Hond/Kat";
            this.HondKatCheckBox.UseVisualStyleBackColor = true;
            this.HondKatCheckBox.CheckedChanged += new System.EventHandler(this.Huisdierbox_CheckedChanged);
            // 
            // ZoektextBox
            // 
            this.ZoektextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ZoektextBox.Location = new System.Drawing.Point(99, 12);
            this.ZoektextBox.Name = "ZoektextBox";
            this.ZoektextBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ZoektextBox.Size = new System.Drawing.Size(206, 23);
            this.ZoektextBox.TabIndex = 39;
            // 
            // ZoekButton
            // 
            this.ZoekButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ZoekButton.Location = new System.Drawing.Point(306, 12);
            this.ZoekButton.Name = "ZoekButton";
            this.ZoekButton.Size = new System.Drawing.Size(75, 23);
            this.ZoekButton.TabIndex = 38;
            this.ZoekButton.Text = "Zoek";
            this.ZoekButton.UseVisualStyleBackColor = true;
            this.ZoekButton.Click += new System.EventHandler(this.ZoekButton_Click);
            // 
            // __Label
            // 
            this.@__Label.AutoSize = true;
            this.@__Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.@__Label.Location = new System.Drawing.Point(114, 71);
            this.@__Label.Name = "__Label";
            this.@__Label.Size = new System.Drawing.Size(38, 17);
            this.@__Label.TabIndex = 37;
            this.@__Label.Text = "------";
            // 
            // TotLabel
            // 
            this.TotLabel.AutoSize = true;
            this.TotLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotLabel.Location = new System.Drawing.Point(158, 71);
            this.TotLabel.Name = "TotLabel";
            this.TotLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.TotLabel.Size = new System.Drawing.Size(33, 17);
            this.TotLabel.TabIndex = 36;
            this.TotLabel.Text = "Tot:";
            // 
            // VanLabel
            // 
            this.VanLabel.AutoSize = true;
            this.VanLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VanLabel.Location = new System.Drawing.Point(6, 46);
            this.VanLabel.Name = "VanLabel";
            this.VanLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.VanLabel.Size = new System.Drawing.Size(37, 17);
            this.VanLabel.TabIndex = 35;
            this.VanLabel.Text = "Van:";
            // 
            // dateTimePickerTot
            // 
            this.dateTimePickerTot.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerTot.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerTot.Location = new System.Drawing.Point(192, 66);
            this.dateTimePickerTot.Name = "dateTimePickerTot";
            this.dateTimePickerTot.Size = new System.Drawing.Size(99, 23);
            this.dateTimePickerTot.TabIndex = 34;
            // 
            // dateTimePickerVan
            // 
            this.dateTimePickerVan.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerVan.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerVan.Location = new System.Drawing.Point(9, 66);
            this.dateTimePickerVan.Name = "dateTimePickerVan";
            this.dateTimePickerVan.Size = new System.Drawing.Size(99, 23);
            this.dateTimePickerVan.TabIndex = 33;
            // 
            // ExtraLabel
            // 
            this.ExtraLabel.AutoSize = true;
            this.ExtraLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExtraLabel.Location = new System.Drawing.Point(598, 15);
            this.ExtraLabel.Name = "ExtraLabel";
            this.ExtraLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ExtraLabel.Size = new System.Drawing.Size(44, 17);
            this.ExtraLabel.TabIndex = 50;
            this.ExtraLabel.Text = "Extra:";
            // 
            // OppasCheckBox
            // 
            this.OppasCheckBox.AutoSize = true;
            this.OppasCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OppasCheckBox.Location = new System.Drawing.Point(629, 72);
            this.OppasCheckBox.Name = "OppasCheckBox";
            this.OppasCheckBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.OppasCheckBox.Size = new System.Drawing.Size(132, 21);
            this.OppasCheckBox.TabIndex = 53;
            this.OppasCheckBox.Text = "Alleen oppassen";
            this.OppasCheckBox.UseVisualStyleBackColor = true;
            this.OppasCheckBox.CheckedChanged += new System.EventHandler(this.Extra_CheckedChanged);
            // 
            // UitlaatCheckBox
            // 
            this.UitlaatCheckBox.AutoSize = true;
            this.UitlaatCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UitlaatCheckBox.Location = new System.Drawing.Point(645, 53);
            this.UitlaatCheckBox.Name = "UitlaatCheckBox";
            this.UitlaatCheckBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.UitlaatCheckBox.Size = new System.Drawing.Size(116, 21);
            this.UitlaatCheckBox.TabIndex = 52;
            this.UitlaatCheckBox.Text = "Alleen uitlaten";
            this.UitlaatCheckBox.UseVisualStyleBackColor = true;
            this.UitlaatCheckBox.CheckedChanged += new System.EventHandler(this.Extra_CheckedChanged);
            // 
            // VerifiedCheckBox
            // 
            this.VerifiedCheckBox.AutoSize = true;
            this.VerifiedCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VerifiedCheckBox.Location = new System.Drawing.Point(601, 33);
            this.VerifiedCheckBox.Name = "VerifiedCheckBox";
            this.VerifiedCheckBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.VerifiedCheckBox.Size = new System.Drawing.Size(160, 21);
            this.VerifiedCheckBox.TabIndex = 51;
            this.VerifiedCheckBox.Text = "Alleen gecertificeerd ";
            this.VerifiedCheckBox.UseVisualStyleBackColor = true;
            // 
            // FormZoeken
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 661);
            this.Controls.Add(this.OppasCheckBox);
            this.Controls.Add(this.UitlaatCheckBox);
            this.Controls.Add(this.VerifiedCheckBox);
            this.Controls.Add(this.ExtraLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.AndersCheckBox);
            this.Controls.Add(this.InsectCheckBox);
            this.Controls.Add(this.SDierLabel);
            this.Controls.Add(this.LocatieLabel);
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
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox AndersCheckBox;
        private System.Windows.Forms.CheckBox InsectCheckBox;
        private System.Windows.Forms.Label SDierLabel;
        private System.Windows.Forms.Label LocatieLabel;
        private System.Windows.Forms.CheckBox VogelCheckBox;
        private System.Windows.Forms.CheckBox ReptielAmfibieCheckBox;
        private System.Windows.Forms.CheckBox KnaagdierCheckBox;
        private System.Windows.Forms.CheckBox HondKatCheckBox;
        private System.Windows.Forms.TextBox ZoektextBox;
        private System.Windows.Forms.Button ZoekButton;
        private System.Windows.Forms.Label __Label;
        private System.Windows.Forms.Label TotLabel;
        private System.Windows.Forms.Label VanLabel;
        private System.Windows.Forms.DateTimePicker dateTimePickerTot;
        private System.Windows.Forms.DateTimePicker dateTimePickerVan;
        private System.Windows.Forms.Label ExtraLabel;
        private System.Windows.Forms.CheckBox OppasCheckBox;
        private System.Windows.Forms.CheckBox UitlaatCheckBox;
        private System.Windows.Forms.CheckBox VerifiedCheckBox;
    }
}

