namespace login2
{
    partial class AdminMainForm
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
            this.ButonDepunereNumerar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ButonDepunereNumerar
            // 
            this.ButonDepunereNumerar.Location = new System.Drawing.Point(43, 60);
            this.ButonDepunereNumerar.Name = "ButonDepunereNumerar";
            this.ButonDepunereNumerar.Size = new System.Drawing.Size(75, 23);
            this.ButonDepunereNumerar.TabIndex = 0;
            this.ButonDepunereNumerar.Text = "button1";
            this.ButonDepunereNumerar.UseVisualStyleBackColor = true;
            this.ButonDepunereNumerar.Click += new System.EventHandler(this.ButonDepunereNumerar_Click);
            // 
            // AdminMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.ButonDepunereNumerar);
            this.Name = "AdminMainForm";
            this.Text = "AdminMainForm";
            this.Load += new System.EventHandler(this.AdminMainForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ButonDepunereNumerar;
    }
}