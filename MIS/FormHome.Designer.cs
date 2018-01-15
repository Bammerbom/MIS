namespace MIS
{
    partial class FormHome
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
            this.panelH = new System.Windows.Forms.Panel();
            this.panelB = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // panelH
            // 
            this.panelH.Location = new System.Drawing.Point(0, 0);
            this.panelH.Margin = new System.Windows.Forms.Padding(0);
            this.panelH.Name = "panelH";
            this.panelH.Size = new System.Drawing.Size(985, 109);
            this.panelH.TabIndex = 0;
            // 
            // panelB
            // 
            this.panelB.Location = new System.Drawing.Point(0, 109);
            this.panelB.Margin = new System.Windows.Forms.Padding(0);
            this.panelB.Name = "panelB";
            this.panelB.Size = new System.Drawing.Size(985, 554);
            this.panelB.TabIndex = 1;
            // 
            // FormHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 661);
            this.Controls.Add(this.panelB);
            this.Controls.Add(this.panelH);
            this.Name = "FormHome";
            this.Text = "Pet & Breakfast";
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Panel panelH;
        public System.Windows.Forms.Panel panelB;
    }
}