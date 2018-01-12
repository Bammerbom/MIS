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
            this.EditButton = new System.Windows.Forms.Button();
            this.ReadButton = new System.Windows.Forms.Button();
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
            this.AdminDatagrid.Size = new System.Drawing.Size(1159, 690);
            this.AdminDatagrid.TabIndex = 0;
            this.AdminDatagrid.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.AdminDatagrid_CellMouseClick);
            // 
            // EditButton
            // 
            this.EditButton.Location = new System.Drawing.Point(1016, 709);
            this.EditButton.Name = "EditButton";
            this.EditButton.Size = new System.Drawing.Size(75, 23);
            this.EditButton.TabIndex = 1;
            this.EditButton.Text = "Edit Data";
            this.EditButton.UseVisualStyleBackColor = true;
            this.EditButton.Click += new System.EventHandler(this.EditButton_Click);
            // 
            // ReadButton
            // 
            this.ReadButton.Location = new System.Drawing.Point(1097, 709);
            this.ReadButton.Name = "ReadButton";
            this.ReadButton.Size = new System.Drawing.Size(75, 23);
            this.ReadButton.TabIndex = 2;
            this.ReadButton.Text = "Read Only";
            this.ReadButton.UseVisualStyleBackColor = true;
            this.ReadButton.Click += new System.EventHandler(this.ReadButton_Click);
            // 
            // FormAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 761);
            this.Controls.Add(this.ReadButton);
            this.Controls.Add(this.EditButton);
            this.Controls.Add(this.AdminDatagrid);
            this.Name = "FormAdmin";
            this.Text = "Admin pagina";
            this.Load += new System.EventHandler(this.FormAdmin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.AdminDatagrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView AdminDatagrid;
        private System.Windows.Forms.Button EditButton;
        private System.Windows.Forms.Button ReadButton;
    }
}