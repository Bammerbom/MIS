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
            this.AdminDatagrid.Size = new System.Drawing.Size(959, 636);
            this.AdminDatagrid.TabIndex = 0;
            this.AdminDatagrid.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.AdminDatagrid_CellMouseClick);
            // 
            // FormAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 661);
            this.Controls.Add(this.AdminDatagrid);
            this.Name = "FormAdmin";
            this.Text = "Admin pagina";
            this.Load += new System.EventHandler(this.FormAdmin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.AdminDatagrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView AdminDatagrid;
    }
}