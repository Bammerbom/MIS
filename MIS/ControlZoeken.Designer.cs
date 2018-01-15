namespace MIS
{
    partial class ControlZoeken
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
            this.VisCheckBox = new System.Windows.Forms.CheckBox();
            this.InsectCheckBox = new System.Windows.Forms.CheckBox();
            this.SDierLabel = new System.Windows.Forms.Label();
            this.WoonplaatsLabel = new System.Windows.Forms.Label();
            this.VogelCheckBox = new System.Windows.Forms.CheckBox();
            this.ReptielCheckBox = new System.Windows.Forms.CheckBox();
            this.KnaagdierCheckBox = new System.Windows.Forms.CheckBox();
            this.HondCheckBox = new System.Windows.Forms.CheckBox();
            this.ZoektextBox = new System.Windows.Forms.TextBox();
            this.ZoekButton = new System.Windows.Forms.Button();
            this.PrijsLabel = new System.Windows.Forms.Label();
            this.ExtraLabel = new System.Windows.Forms.Label();
            this.OppasCheckBox = new System.Windows.Forms.CheckBox();
            this.UitlaatCheckBox = new System.Windows.Forms.CheckBox();
            this.VerifiedCheckBox = new System.Windows.Forms.CheckBox();
            this.PrijsTextBox = new System.Windows.Forms.TextBox();
            this.AmfibieCheckBox = new System.Windows.Forms.CheckBox();
            this.KatCheckBox = new System.Windows.Forms.CheckBox();
            this.panel = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(-3, 96);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1123, 13);
            this.label1.TabIndex = 48;
            this.label1.Text = "_________________________________________________________________________________" +
    "________________________________________________________________________________" +
    "_________________________";
            // 
            // VisCheckBox
            // 
            this.VisCheckBox.AutoSize = true;
            this.VisCheckBox.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.VisCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VisCheckBox.Location = new System.Drawing.Point(570, 72);
            this.VisCheckBox.Name = "VisCheckBox";
            this.VisCheckBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.VisCheckBox.Size = new System.Drawing.Size(46, 21);
            this.VisCheckBox.TabIndex = 47;
            this.VisCheckBox.Text = "Vis";
            this.VisCheckBox.UseVisualStyleBackColor = true;
            this.VisCheckBox.CheckedChanged += new System.EventHandler(this.Huisdierbox_CheckedChanged);
            // 
            // InsectCheckBox
            // 
            this.InsectCheckBox.AutoSize = true;
            this.InsectCheckBox.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.InsectCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InsectCheckBox.Location = new System.Drawing.Point(552, 55);
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
            this.SDierLabel.Location = new System.Drawing.Point(463, 0);
            this.SDierLabel.Name = "SDierLabel";
            this.SDierLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.SDierLabel.Size = new System.Drawing.Size(76, 17);
            this.SDierLabel.TabIndex = 45;
            this.SDierLabel.Text = "Soort Dier:";
            // 
            // WoonplaatsLabel
            // 
            this.WoonplaatsLabel.AutoSize = true;
            this.WoonplaatsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WoonplaatsLabel.Location = new System.Drawing.Point(10, 17);
            this.WoonplaatsLabel.Name = "WoonplaatsLabel";
            this.WoonplaatsLabel.Size = new System.Drawing.Size(87, 17);
            this.WoonplaatsLabel.TabIndex = 44;
            this.WoonplaatsLabel.Text = "Woonplaats:";
            // 
            // VogelCheckBox
            // 
            this.VogelCheckBox.AutoSize = true;
            this.VogelCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VogelCheckBox.Location = new System.Drawing.Point(476, 72);
            this.VogelCheckBox.Name = "VogelCheckBox";
            this.VogelCheckBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.VogelCheckBox.Size = new System.Drawing.Size(63, 21);
            this.VogelCheckBox.TabIndex = 43;
            this.VogelCheckBox.Text = "Vogel";
            this.VogelCheckBox.UseVisualStyleBackColor = true;
            this.VogelCheckBox.CheckedChanged += new System.EventHandler(this.Huisdierbox_CheckedChanged);
            // 
            // ReptielCheckBox
            // 
            this.ReptielCheckBox.AutoSize = true;
            this.ReptielCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReptielCheckBox.Location = new System.Drawing.Point(545, 19);
            this.ReptielCheckBox.Name = "ReptielCheckBox";
            this.ReptielCheckBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ReptielCheckBox.Size = new System.Drawing.Size(71, 21);
            this.ReptielCheckBox.TabIndex = 42;
            this.ReptielCheckBox.Text = "Reptiel";
            this.ReptielCheckBox.UseVisualStyleBackColor = true;
            this.ReptielCheckBox.CheckedChanged += new System.EventHandler(this.Huisdierbox_CheckedChanged);
            // 
            // KnaagdierCheckBox
            // 
            this.KnaagdierCheckBox.AutoSize = true;
            this.KnaagdierCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KnaagdierCheckBox.Location = new System.Drawing.Point(447, 55);
            this.KnaagdierCheckBox.Name = "KnaagdierCheckBox";
            this.KnaagdierCheckBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.KnaagdierCheckBox.Size = new System.Drawing.Size(92, 21);
            this.KnaagdierCheckBox.TabIndex = 41;
            this.KnaagdierCheckBox.Text = "Knaagdier";
            this.KnaagdierCheckBox.UseVisualStyleBackColor = true;
            this.KnaagdierCheckBox.CheckedChanged += new System.EventHandler(this.Huisdierbox_CheckedChanged);
            // 
            // HondCheckBox
            // 
            this.HondCheckBox.AutoSize = true;
            this.HondCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HondCheckBox.Location = new System.Drawing.Point(478, 19);
            this.HondCheckBox.Name = "HondCheckBox";
            this.HondCheckBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.HondCheckBox.Size = new System.Drawing.Size(61, 21);
            this.HondCheckBox.TabIndex = 40;
            this.HondCheckBox.Text = "Hond";
            this.HondCheckBox.UseVisualStyleBackColor = true;
            this.HondCheckBox.CheckedChanged += new System.EventHandler(this.Huisdierbox_CheckedChanged);
            // 
            // ZoektextBox
            // 
            this.ZoektextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ZoektextBox.Location = new System.Drawing.Point(103, 15);
            this.ZoektextBox.Name = "ZoektextBox";
            this.ZoektextBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ZoektextBox.Size = new System.Drawing.Size(206, 23);
            this.ZoektextBox.TabIndex = 39;
            // 
            // ZoekButton
            // 
            this.ZoekButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ZoekButton.Location = new System.Drawing.Point(310, 15);
            this.ZoekButton.Name = "ZoekButton";
            this.ZoekButton.Size = new System.Drawing.Size(75, 23);
            this.ZoekButton.TabIndex = 38;
            this.ZoekButton.Text = "Zoek";
            this.ZoekButton.UseVisualStyleBackColor = true;
            this.ZoekButton.Click += new System.EventHandler(this.ZoekButton_Click);
            // 
            // PrijsLabel
            // 
            this.PrijsLabel.AutoSize = true;
            this.PrijsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PrijsLabel.Location = new System.Drawing.Point(5, 55);
            this.PrijsLabel.Name = "PrijsLabel";
            this.PrijsLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.PrijsLabel.Size = new System.Drawing.Size(92, 17);
            this.PrijsLabel.TabIndex = 35;
            this.PrijsLabel.Text = "Prijs per dag:";
            // 
            // ExtraLabel
            // 
            this.ExtraLabel.AutoSize = true;
            this.ExtraLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExtraLabel.Location = new System.Drawing.Point(615, 0);
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
            this.OppasCheckBox.Location = new System.Drawing.Point(644, 55);
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
            this.UitlaatCheckBox.Location = new System.Drawing.Point(660, 37);
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
            this.VerifiedCheckBox.Location = new System.Drawing.Point(616, 19);
            this.VerifiedCheckBox.Name = "VerifiedCheckBox";
            this.VerifiedCheckBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.VerifiedCheckBox.Size = new System.Drawing.Size(160, 21);
            this.VerifiedCheckBox.TabIndex = 51;
            this.VerifiedCheckBox.Text = "Alleen gecertificeerd ";
            this.VerifiedCheckBox.UseVisualStyleBackColor = true;
            // 
            // PrijsTextBox
            // 
            this.PrijsTextBox.Location = new System.Drawing.Point(103, 55);
            this.PrijsTextBox.Name = "PrijsTextBox";
            this.PrijsTextBox.Size = new System.Drawing.Size(100, 20);
            this.PrijsTextBox.TabIndex = 54;
            // 
            // AmfibieCheckBox
            // 
            this.AmfibieCheckBox.AutoSize = true;
            this.AmfibieCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AmfibieCheckBox.Location = new System.Drawing.Point(543, 37);
            this.AmfibieCheckBox.Name = "AmfibieCheckBox";
            this.AmfibieCheckBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.AmfibieCheckBox.Size = new System.Drawing.Size(73, 21);
            this.AmfibieCheckBox.TabIndex = 55;
            this.AmfibieCheckBox.Text = "Amfibie";
            this.AmfibieCheckBox.UseVisualStyleBackColor = true;
            this.AmfibieCheckBox.CheckedChanged += new System.EventHandler(this.Huisdierbox_CheckedChanged);
            // 
            // KatCheckBox
            // 
            this.KatCheckBox.AutoSize = true;
            this.KatCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KatCheckBox.Location = new System.Drawing.Point(491, 37);
            this.KatCheckBox.Name = "KatCheckBox";
            this.KatCheckBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.KatCheckBox.Size = new System.Drawing.Size(48, 21);
            this.KatCheckBox.TabIndex = 56;
            this.KatCheckBox.Text = "Kat";
            this.KatCheckBox.UseVisualStyleBackColor = true;
            this.KatCheckBox.CheckedChanged += new System.EventHandler(this.Huisdierbox_CheckedChanged);
            // 
            // panel
            // 
            this.panel.AutoScroll = true;
            this.panel.Location = new System.Drawing.Point(0, 109);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(984, 549);
            this.panel.TabIndex = 57;
            // 
            // FormZoeken
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 661);
            this.Controls.Add(this.panel);
            this.Controls.Add(this.KatCheckBox);
            this.Controls.Add(this.AmfibieCheckBox);
            this.Controls.Add(this.PrijsTextBox);
            this.Controls.Add(this.OppasCheckBox);
            this.Controls.Add(this.UitlaatCheckBox);
            this.Controls.Add(this.VerifiedCheckBox);
            this.Controls.Add(this.ExtraLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.VisCheckBox);
            this.Controls.Add(this.InsectCheckBox);
            this.Controls.Add(this.SDierLabel);
            this.Controls.Add(this.WoonplaatsLabel);
            this.Controls.Add(this.VogelCheckBox);
            this.Controls.Add(this.ReptielCheckBox);
            this.Controls.Add(this.KnaagdierCheckBox);
            this.Controls.Add(this.HondCheckBox);
            this.Controls.Add(this.ZoektextBox);
            this.Controls.Add(this.ZoekButton);
            this.Controls.Add(this.PrijsLabel);
            this.Name = "FormZoeken";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Text = "Zoeken";
            this.Load += new System.EventHandler(this.FormZoeken_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox VisCheckBox;
        private System.Windows.Forms.CheckBox InsectCheckBox;
        private System.Windows.Forms.Label SDierLabel;
        private System.Windows.Forms.Label WoonplaatsLabel;
        private System.Windows.Forms.CheckBox VogelCheckBox;
        private System.Windows.Forms.CheckBox ReptielCheckBox;
        private System.Windows.Forms.CheckBox KnaagdierCheckBox;
        private System.Windows.Forms.CheckBox HondCheckBox;
        private System.Windows.Forms.TextBox ZoektextBox;
        private System.Windows.Forms.Button ZoekButton;
        private System.Windows.Forms.Label PrijsLabel;
        private System.Windows.Forms.Label ExtraLabel;
        private System.Windows.Forms.CheckBox OppasCheckBox;
        private System.Windows.Forms.CheckBox UitlaatCheckBox;
        private System.Windows.Forms.CheckBox VerifiedCheckBox;
        private System.Windows.Forms.TextBox PrijsTextBox;
        private System.Windows.Forms.CheckBox AmfibieCheckBox;
        private System.Windows.Forms.CheckBox KatCheckBox;
        private System.Windows.Forms.Panel panel;
    }
}
