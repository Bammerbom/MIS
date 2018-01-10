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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormZoeken));
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.OppasCheckBox = new System.Windows.Forms.CheckBox();
            this.UitlaatCheckBox = new System.Windows.Forms.CheckBox();
            this.VerifiedCheckBox = new System.Windows.Forms.CheckBox();
            this.ExtraLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.AndersCheckBox = new System.Windows.Forms.CheckBox();
            this.InsectCheckBox = new System.Windows.Forms.CheckBox();
            this.SDierLabel = new System.Windows.Forms.Label();
            this.VogelCheckBox = new System.Windows.Forms.CheckBox();
            this.ReptielAmfibieCheckBox = new System.Windows.Forms.CheckBox();
            this.KnaagdierCheckBox = new System.Windows.Forms.CheckBox();
            this.HondKatCheckBox = new System.Windows.Forms.CheckBox();
            this.ZoektextBox = new System.Windows.Forms.TextBox();
            this.ZoekButton = new System.Windows.Forms.Button();
            this.@__Label = new System.Windows.Forms.Label();
            this.TotLabel = new System.Windows.Forms.Label();
            this.dateTimePickerTot = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerVan = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(59, 287);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(835, 393);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 54;
            this.pictureBox1.TabStop = false;
            // 
            // OppasCheckBox
            // 
            this.OppasCheckBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.OppasCheckBox.AutoSize = true;
            this.OppasCheckBox.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.OppasCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OppasCheckBox.Location = new System.Drawing.Point(678, 98);
            this.OppasCheckBox.Margin = new System.Windows.Forms.Padding(4);
            this.OppasCheckBox.Name = "OppasCheckBox";
            this.OppasCheckBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.OppasCheckBox.Size = new System.Drawing.Size(135, 21);
            this.OppasCheckBox.TabIndex = 78;
            this.OppasCheckBox.Text = "Alleen oppassen";
            this.OppasCheckBox.UseVisualStyleBackColor = true;
            // 
            // UitlaatCheckBox
            // 
            this.UitlaatCheckBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.UitlaatCheckBox.AutoSize = true;
            this.UitlaatCheckBox.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.UitlaatCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UitlaatCheckBox.Location = new System.Drawing.Point(678, 69);
            this.UitlaatCheckBox.Margin = new System.Windows.Forms.Padding(4);
            this.UitlaatCheckBox.Name = "UitlaatCheckBox";
            this.UitlaatCheckBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.UitlaatCheckBox.Size = new System.Drawing.Size(119, 21);
            this.UitlaatCheckBox.TabIndex = 77;
            this.UitlaatCheckBox.Text = "Alleen uitlaten";
            this.UitlaatCheckBox.UseVisualStyleBackColor = true;
            // 
            // VerifiedCheckBox
            // 
            this.VerifiedCheckBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.VerifiedCheckBox.AutoSize = true;
            this.VerifiedCheckBox.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.VerifiedCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VerifiedCheckBox.Location = new System.Drawing.Point(678, 41);
            this.VerifiedCheckBox.Margin = new System.Windows.Forms.Padding(4);
            this.VerifiedCheckBox.Name = "VerifiedCheckBox";
            this.VerifiedCheckBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.VerifiedCheckBox.Size = new System.Drawing.Size(163, 21);
            this.VerifiedCheckBox.TabIndex = 76;
            this.VerifiedCheckBox.Text = "Alleen gecertificeerd ";
            this.VerifiedCheckBox.UseVisualStyleBackColor = true;
            // 
            // ExtraLabel
            // 
            this.ExtraLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ExtraLabel.AutoSize = true;
            this.ExtraLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExtraLabel.Location = new System.Drawing.Point(675, 13);
            this.ExtraLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ExtraLabel.Name = "ExtraLabel";
            this.ExtraLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ExtraLabel.Size = new System.Drawing.Size(50, 17);
            this.ExtraLabel.TabIndex = 75;
            this.ExtraLabel.Text = "Extra:";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(-152, 123);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1496, 17);
            this.label1.TabIndex = 74;
            this.label1.Text = "_________________________________________________________________________________" +
    "________________________________________________________________________________" +
    "_________________________";
            // 
            // AndersCheckBox
            // 
            this.AndersCheckBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.AndersCheckBox.AutoSize = true;
            this.AndersCheckBox.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.AndersCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AndersCheckBox.Location = new System.Drawing.Point(542, 98);
            this.AndersCheckBox.Margin = new System.Windows.Forms.Padding(4);
            this.AndersCheckBox.Name = "AndersCheckBox";
            this.AndersCheckBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.AndersCheckBox.Size = new System.Drawing.Size(75, 21);
            this.AndersCheckBox.TabIndex = 73;
            this.AndersCheckBox.Text = "Anders";
            this.AndersCheckBox.UseVisualStyleBackColor = true;
            // 
            // InsectCheckBox
            // 
            this.InsectCheckBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.InsectCheckBox.AutoSize = true;
            this.InsectCheckBox.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.InsectCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InsectCheckBox.Location = new System.Drawing.Point(542, 69);
            this.InsectCheckBox.Margin = new System.Windows.Forms.Padding(4);
            this.InsectCheckBox.Name = "InsectCheckBox";
            this.InsectCheckBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.InsectCheckBox.Size = new System.Drawing.Size(67, 21);
            this.InsectCheckBox.TabIndex = 72;
            this.InsectCheckBox.Text = "Insect";
            this.InsectCheckBox.UseVisualStyleBackColor = true;
            // 
            // SDierLabel
            // 
            this.SDierLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.SDierLabel.AutoSize = true;
            this.SDierLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SDierLabel.Location = new System.Drawing.Point(442, 13);
            this.SDierLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.SDierLabel.Name = "SDierLabel";
            this.SDierLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.SDierLabel.Size = new System.Drawing.Size(87, 17);
            this.SDierLabel.TabIndex = 71;
            this.SDierLabel.Text = "Soort Dier:";
            // 
            // VogelCheckBox
            // 
            this.VogelCheckBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.VogelCheckBox.AutoSize = true;
            this.VogelCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VogelCheckBox.Location = new System.Drawing.Point(445, 98);
            this.VogelCheckBox.Margin = new System.Windows.Forms.Padding(4);
            this.VogelCheckBox.Name = "VogelCheckBox";
            this.VogelCheckBox.Size = new System.Drawing.Size(66, 21);
            this.VogelCheckBox.TabIndex = 70;
            this.VogelCheckBox.Text = "Vogel";
            this.VogelCheckBox.UseVisualStyleBackColor = true;
            // 
            // ReptielAmfibieCheckBox
            // 
            this.ReptielAmfibieCheckBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ReptielAmfibieCheckBox.AutoSize = true;
            this.ReptielAmfibieCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReptielAmfibieCheckBox.Location = new System.Drawing.Point(542, 41);
            this.ReptielAmfibieCheckBox.Margin = new System.Windows.Forms.Padding(4);
            this.ReptielAmfibieCheckBox.Name = "ReptielAmfibieCheckBox";
            this.ReptielAmfibieCheckBox.Size = new System.Drawing.Size(124, 21);
            this.ReptielAmfibieCheckBox.TabIndex = 69;
            this.ReptielAmfibieCheckBox.Text = "Reptiel/Amfibie";
            this.ReptielAmfibieCheckBox.UseVisualStyleBackColor = true;
            // 
            // KnaagdierCheckBox
            // 
            this.KnaagdierCheckBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.KnaagdierCheckBox.AutoSize = true;
            this.KnaagdierCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KnaagdierCheckBox.Location = new System.Drawing.Point(445, 70);
            this.KnaagdierCheckBox.Margin = new System.Windows.Forms.Padding(4);
            this.KnaagdierCheckBox.Name = "KnaagdierCheckBox";
            this.KnaagdierCheckBox.Size = new System.Drawing.Size(95, 21);
            this.KnaagdierCheckBox.TabIndex = 68;
            this.KnaagdierCheckBox.Text = "Knaagdier";
            this.KnaagdierCheckBox.UseVisualStyleBackColor = true;
            // 
            // HondKatCheckBox
            // 
            this.HondKatCheckBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.HondKatCheckBox.AutoSize = true;
            this.HondKatCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HondKatCheckBox.Location = new System.Drawing.Point(445, 41);
            this.HondKatCheckBox.Margin = new System.Windows.Forms.Padding(4);
            this.HondKatCheckBox.Name = "HondKatCheckBox";
            this.HondKatCheckBox.Size = new System.Drawing.Size(89, 21);
            this.HondKatCheckBox.TabIndex = 67;
            this.HondKatCheckBox.Text = "Hond/Kat";
            this.HondKatCheckBox.UseVisualStyleBackColor = true;
            // 
            // ZoektextBox
            // 
            this.ZoektextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ZoektextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ZoektextBox.Location = new System.Drawing.Point(36, 13);
            this.ZoektextBox.Margin = new System.Windows.Forms.Padding(4);
            this.ZoektextBox.Name = "ZoektextBox";
            this.ZoektextBox.Size = new System.Drawing.Size(273, 22);
            this.ZoektextBox.TabIndex = 66;
            // 
            // ZoekButton
            // 
            this.ZoekButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ZoekButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ZoekButton.Location = new System.Drawing.Point(307, 12);
            this.ZoekButton.Margin = new System.Windows.Forms.Padding(4);
            this.ZoekButton.Name = "ZoekButton";
            this.ZoekButton.Size = new System.Drawing.Size(104, 24);
            this.ZoekButton.TabIndex = 65;
            this.ZoekButton.Text = "Zoek";
            this.ZoekButton.UseVisualStyleBackColor = true;
            // 
            // __Label
            // 
            this.@__Label.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.@__Label.AutoSize = true;
            this.@__Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.@__Label.Location = new System.Drawing.Point(175, 70);
            this.@__Label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.@__Label.Name = "__Label";
            this.@__Label.Size = new System.Drawing.Size(44, 17);
            this.@__Label.TabIndex = 64;
            this.@__Label.Text = "------";
            // 
            // TotLabel
            // 
            this.TotLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TotLabel.AutoSize = true;
            this.TotLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotLabel.Location = new System.Drawing.Point(219, 65);
            this.TotLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.TotLabel.Name = "TotLabel";
            this.TotLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.TotLabel.Size = new System.Drawing.Size(37, 17);
            this.TotLabel.TabIndex = 63;
            this.TotLabel.Text = "Tot:";
            // 
            // dateTimePickerTot
            // 
            this.dateTimePickerTot.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dateTimePickerTot.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerTot.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerTot.Location = new System.Drawing.Point(264, 65);
            this.dateTimePickerTot.Margin = new System.Windows.Forms.Padding(4);
            this.dateTimePickerTot.Name = "dateTimePickerTot";
            this.dateTimePickerTot.Size = new System.Drawing.Size(131, 22);
            this.dateTimePickerTot.TabIndex = 62;
            // 
            // dateTimePickerVan
            // 
            this.dateTimePickerVan.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dateTimePickerVan.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerVan.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerVan.Location = new System.Drawing.Point(36, 65);
            this.dateTimePickerVan.Margin = new System.Windows.Forms.Padding(4);
            this.dateTimePickerVan.Name = "dateTimePickerVan";
            this.dateTimePickerVan.Size = new System.Drawing.Size(131, 22);
            this.dateTimePickerVan.TabIndex = 61;
            // 
            // FormZoeken
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 653);
            this.Controls.Add(this.OppasCheckBox);
            this.Controls.Add(this.UitlaatCheckBox);
            this.Controls.Add(this.VerifiedCheckBox);
            this.Controls.Add(this.ExtraLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.AndersCheckBox);
            this.Controls.Add(this.InsectCheckBox);
            this.Controls.Add(this.SDierLabel);
            this.Controls.Add(this.VogelCheckBox);
            this.Controls.Add(this.ReptielAmfibieCheckBox);
            this.Controls.Add(this.KnaagdierCheckBox);
            this.Controls.Add(this.HondKatCheckBox);
            this.Controls.Add(this.ZoektextBox);
            this.Controls.Add(this.ZoekButton);
            this.Controls.Add(this.@__Label);
            this.Controls.Add(this.TotLabel);
            this.Controls.Add(this.dateTimePickerTot);
            this.Controls.Add(this.dateTimePickerVan);
            this.Controls.Add(this.pictureBox1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FormZoeken";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.CheckBox OppasCheckBox;
        private System.Windows.Forms.CheckBox UitlaatCheckBox;
        private System.Windows.Forms.CheckBox VerifiedCheckBox;
        private System.Windows.Forms.Label ExtraLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox AndersCheckBox;
        private System.Windows.Forms.CheckBox InsectCheckBox;
        private System.Windows.Forms.Label SDierLabel;
        private System.Windows.Forms.CheckBox VogelCheckBox;
        private System.Windows.Forms.CheckBox ReptielAmfibieCheckBox;
        private System.Windows.Forms.CheckBox KnaagdierCheckBox;
        private System.Windows.Forms.CheckBox HondKatCheckBox;
        private System.Windows.Forms.TextBox ZoektextBox;
        private System.Windows.Forms.Button ZoekButton;
        private System.Windows.Forms.Label __Label;
        private System.Windows.Forms.Label TotLabel;
        private System.Windows.Forms.DateTimePicker dateTimePickerTot;
        private System.Windows.Forms.DateTimePicker dateTimePickerVan;
    }
}

