namespace MitBank
{
    partial class LoginForm
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
            this.username = new System.Windows.Forms.TextBox();
            this.passwd = new System.Windows.Forms.TextBox();
            this.LoginButtonOK = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // username
            // 
            this.username.Location = new System.Drawing.Point(86, 72);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(100, 20);
            this.username.TabIndex = 0;
            // 
            // passwd
            // 
            this.passwd.Location = new System.Drawing.Point(86, 111);
            this.passwd.Name = "passwd";
            this.passwd.Size = new System.Drawing.Size(100, 20);
            this.passwd.TabIndex = 1;
            // 
            // LoginButtonOK
            // 
            this.LoginButtonOK.Location = new System.Drawing.Point(101, 152);
            this.LoginButtonOK.Name = "LoginButtonOK";
            this.LoginButtonOK.Size = new System.Drawing.Size(75, 23);
            this.LoginButtonOK.TabIndex = 3;
            this.LoginButtonOK.Text = "OK";
            this.LoginButtonOK.UseVisualStyleBackColor = true;
            this.LoginButtonOK.Click += new System.EventHandler(this.LoginButtonOK_Click);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.LoginButtonOK);
            this.Controls.Add(this.passwd);
            this.Controls.Add(this.username);
            this.Name = "LoginForm";
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox username;
        private System.Windows.Forms.TextBox passwd;
        private System.Windows.Forms.Button LoginButtonOK;
    }
}

