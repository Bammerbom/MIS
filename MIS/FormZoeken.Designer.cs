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
            this.VanLabel.Size = new System.Drawing.Size(29, 13);
            this.VanLabel.TabIndex = 2;
            this.VanLabel.Text = "Van:";
            // 
            // TotLabel
            // 
            this.TotLabel.AutoSize = true;
            this.TotLabel.Location = new System.Drawing.Point(848, 16);
            this.TotLabel.Name = "TotLabel";
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
            // FormZoeken
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 661);
            this.Controls.Add(this.@__Label);
            this.Controls.Add(this.TotLabel);
            this.Controls.Add(this.VanLabel);
            this.Controls.Add(this.dateTimePickerTot);
            this.Controls.Add(this.dateTimePickerVan);
            this.Name = "FormZoeken";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimePickerVan;
        private System.Windows.Forms.DateTimePicker dateTimePickerTot;
        private System.Windows.Forms.Label VanLabel;
        private System.Windows.Forms.Label TotLabel;
        private System.Windows.Forms.Label __Label;
    }
}

