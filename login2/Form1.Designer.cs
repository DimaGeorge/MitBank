namespace login2
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.registrationPanel = new System.Windows.Forms.Panel();
            this.birtdateTxt = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.adressTxtbox = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.numberphoneTxtBox = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.firstnameTxtbox = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.emailTxtbox = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.retypepasswordTxtbox = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.passwordTxtbox = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.lastnameTxtbox = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label6 = new System.Windows.Forms.Label();
            this.registerButon = new Bunifu.Framework.UI.BunifuThinButton2();
            this.label5 = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.acceptTermsCheckBox = new Bunifu.Framework.UI.BunifuCheckbox();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.logInPanel = new System.Windows.Forms.Panel();
            this.codeTxtbox = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.loginButon = new Bunifu.Framework.UI.BunifuFlatButton();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.passwordLoginTxtbox = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.usernameLoginTxtbox = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.registrationPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.logInPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(758, 39);
            this.panel1.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Elephant", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(719, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 26);
            this.label3.TabIndex = 10;
            this.label3.Text = "X";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(176, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(168, 148);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // registrationPanel
            // 
            this.registrationPanel.Controls.Add(this.birtdateTxt);
            this.registrationPanel.Controls.Add(this.adressTxtbox);
            this.registrationPanel.Controls.Add(this.numberphoneTxtBox);
            this.registrationPanel.Controls.Add(this.firstnameTxtbox);
            this.registrationPanel.Controls.Add(this.emailTxtbox);
            this.registrationPanel.Controls.Add(this.retypepasswordTxtbox);
            this.registrationPanel.Controls.Add(this.passwordTxtbox);
            this.registrationPanel.Controls.Add(this.lastnameTxtbox);
            this.registrationPanel.Controls.Add(this.label6);
            this.registrationPanel.Controls.Add(this.registerButon);
            this.registrationPanel.Controls.Add(this.label5);
            this.registrationPanel.Controls.Add(this.pictureBox4);
            this.registrationPanel.Controls.Add(this.label4);
            this.registrationPanel.Controls.Add(this.acceptTermsCheckBox);
            this.registrationPanel.ForeColor = System.Drawing.Color.White;
            this.registrationPanel.Location = new System.Drawing.Point(54, 51);
            this.registrationPanel.Name = "registrationPanel";
            this.registrationPanel.Size = new System.Drawing.Size(704, 729);
            this.registrationPanel.TabIndex = 10;
            this.registrationPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // birtdateTxt
            // 
            this.birtdateTxt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.birtdateTxt.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.birtdateTxt.ForeColor = System.Drawing.Color.White;
            this.birtdateTxt.HintForeColor = System.Drawing.Color.White;
            this.birtdateTxt.HintText = "DD/MM/YY   Birthdate";
            this.birtdateTxt.isPassword = false;
            this.birtdateTxt.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(81)))), ((int)(((byte)(0)))));
            this.birtdateTxt.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(125)))), ((int)(((byte)(0)))));
            this.birtdateTxt.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(81)))), ((int)(((byte)(0)))));
            this.birtdateTxt.LineThickness = 3;
            this.birtdateTxt.Location = new System.Drawing.Point(413, 332);
            this.birtdateTxt.Margin = new System.Windows.Forms.Padding(4);
            this.birtdateTxt.Name = "birtdateTxt";
            this.birtdateTxt.Size = new System.Drawing.Size(255, 33);
            this.birtdateTxt.TabIndex = 14;
            this.birtdateTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // adressTxtbox
            // 
            this.adressTxtbox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.adressTxtbox.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.adressTxtbox.ForeColor = System.Drawing.Color.White;
            this.adressTxtbox.HintForeColor = System.Drawing.Color.White;
            this.adressTxtbox.HintText = "Full adress";
            this.adressTxtbox.isPassword = false;
            this.adressTxtbox.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(81)))), ((int)(((byte)(0)))));
            this.adressTxtbox.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(125)))), ((int)(((byte)(0)))));
            this.adressTxtbox.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(81)))), ((int)(((byte)(0)))));
            this.adressTxtbox.LineThickness = 3;
            this.adressTxtbox.Location = new System.Drawing.Point(4, 410);
            this.adressTxtbox.Margin = new System.Windows.Forms.Padding(4);
            this.adressTxtbox.Name = "adressTxtbox";
            this.adressTxtbox.Size = new System.Drawing.Size(664, 33);
            this.adressTxtbox.TabIndex = 6;
            this.adressTxtbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // numberphoneTxtBox
            // 
            this.numberphoneTxtBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.numberphoneTxtBox.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.numberphoneTxtBox.ForeColor = System.Drawing.Color.White;
            this.numberphoneTxtBox.HintForeColor = System.Drawing.Color.White;
            this.numberphoneTxtBox.HintText = "Number phone";
            this.numberphoneTxtBox.isPassword = false;
            this.numberphoneTxtBox.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(81)))), ((int)(((byte)(0)))));
            this.numberphoneTxtBox.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(125)))), ((int)(((byte)(0)))));
            this.numberphoneTxtBox.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(81)))), ((int)(((byte)(0)))));
            this.numberphoneTxtBox.LineThickness = 3;
            this.numberphoneTxtBox.Location = new System.Drawing.Point(4, 332);
            this.numberphoneTxtBox.Margin = new System.Windows.Forms.Padding(4);
            this.numberphoneTxtBox.Name = "numberphoneTxtBox";
            this.numberphoneTxtBox.Size = new System.Drawing.Size(255, 33);
            this.numberphoneTxtBox.TabIndex = 5;
            this.numberphoneTxtBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // firstnameTxtbox
            // 
            this.firstnameTxtbox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.firstnameTxtbox.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.firstnameTxtbox.ForeColor = System.Drawing.Color.White;
            this.firstnameTxtbox.HintForeColor = System.Drawing.Color.White;
            this.firstnameTxtbox.HintText = "First Name";
            this.firstnameTxtbox.isPassword = false;
            this.firstnameTxtbox.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(81)))), ((int)(((byte)(0)))));
            this.firstnameTxtbox.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(125)))), ((int)(((byte)(0)))));
            this.firstnameTxtbox.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(81)))), ((int)(((byte)(0)))));
            this.firstnameTxtbox.LineThickness = 3;
            this.firstnameTxtbox.Location = new System.Drawing.Point(4, 92);
            this.firstnameTxtbox.Margin = new System.Windows.Forms.Padding(4);
            this.firstnameTxtbox.Name = "firstnameTxtbox";
            this.firstnameTxtbox.Size = new System.Drawing.Size(255, 33);
            this.firstnameTxtbox.TabIndex = 0;
            this.firstnameTxtbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // emailTxtbox
            // 
            this.emailTxtbox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.emailTxtbox.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.emailTxtbox.ForeColor = System.Drawing.Color.White;
            this.emailTxtbox.HintForeColor = System.Drawing.Color.White;
            this.emailTxtbox.HintText = "Email";
            this.emailTxtbox.isPassword = false;
            this.emailTxtbox.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(81)))), ((int)(((byte)(0)))));
            this.emailTxtbox.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(125)))), ((int)(((byte)(0)))));
            this.emailTxtbox.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(81)))), ((int)(((byte)(0)))));
            this.emailTxtbox.LineThickness = 3;
            this.emailTxtbox.Location = new System.Drawing.Point(4, 260);
            this.emailTxtbox.Margin = new System.Windows.Forms.Padding(4);
            this.emailTxtbox.Name = "emailTxtbox";
            this.emailTxtbox.Size = new System.Drawing.Size(664, 33);
            this.emailTxtbox.TabIndex = 4;
            this.emailTxtbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // retypepasswordTxtbox
            // 
            this.retypepasswordTxtbox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.retypepasswordTxtbox.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.retypepasswordTxtbox.ForeColor = System.Drawing.Color.White;
            this.retypepasswordTxtbox.HintForeColor = System.Drawing.Color.White;
            this.retypepasswordTxtbox.HintText = "User Name";
            this.retypepasswordTxtbox.isPassword = true;
            this.retypepasswordTxtbox.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(81)))), ((int)(((byte)(0)))));
            this.retypepasswordTxtbox.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(125)))), ((int)(((byte)(0)))));
            this.retypepasswordTxtbox.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(81)))), ((int)(((byte)(0)))));
            this.retypepasswordTxtbox.LineThickness = 3;
            this.retypepasswordTxtbox.Location = new System.Drawing.Point(4, 204);
            this.retypepasswordTxtbox.Margin = new System.Windows.Forms.Padding(4);
            this.retypepasswordTxtbox.Name = "retypepasswordTxtbox";
            this.retypepasswordTxtbox.Size = new System.Drawing.Size(664, 33);
            this.retypepasswordTxtbox.TabIndex = 3;
            this.retypepasswordTxtbox.Text = "Re-type password";
            this.retypepasswordTxtbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // passwordTxtbox
            // 
            this.passwordTxtbox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.passwordTxtbox.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.passwordTxtbox.ForeColor = System.Drawing.Color.White;
            this.passwordTxtbox.HintForeColor = System.Drawing.Color.White;
            this.passwordTxtbox.HintText = "User Name";
            this.passwordTxtbox.isPassword = true;
            this.passwordTxtbox.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(81)))), ((int)(((byte)(0)))));
            this.passwordTxtbox.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(125)))), ((int)(((byte)(0)))));
            this.passwordTxtbox.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(81)))), ((int)(((byte)(0)))));
            this.passwordTxtbox.LineThickness = 3;
            this.passwordTxtbox.Location = new System.Drawing.Point(4, 148);
            this.passwordTxtbox.Margin = new System.Windows.Forms.Padding(4);
            this.passwordTxtbox.Name = "passwordTxtbox";
            this.passwordTxtbox.Size = new System.Drawing.Size(664, 33);
            this.passwordTxtbox.TabIndex = 2;
            this.passwordTxtbox.Text = "Password";
            this.passwordTxtbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // lastnameTxtbox
            // 
            this.lastnameTxtbox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.lastnameTxtbox.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.lastnameTxtbox.ForeColor = System.Drawing.Color.White;
            this.lastnameTxtbox.HintForeColor = System.Drawing.Color.White;
            this.lastnameTxtbox.HintText = "Last Name";
            this.lastnameTxtbox.isPassword = false;
            this.lastnameTxtbox.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(81)))), ((int)(((byte)(0)))));
            this.lastnameTxtbox.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(125)))), ((int)(((byte)(0)))));
            this.lastnameTxtbox.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(81)))), ((int)(((byte)(0)))));
            this.lastnameTxtbox.LineThickness = 3;
            this.lastnameTxtbox.Location = new System.Drawing.Point(413, 92);
            this.lastnameTxtbox.Margin = new System.Windows.Forms.Padding(4);
            this.lastnameTxtbox.Name = "lastnameTxtbox";
            this.lastnameTxtbox.Size = new System.Drawing.Size(255, 33);
            this.lastnameTxtbox.TabIndex = 1;
            this.lastnameTxtbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Elephant", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(183, 677);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 26);
            this.label6.TabIndex = 13;
            this.label6.Text = "LogIn";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // registerButon
            // 
            this.registerButon.ActiveBorderThickness = 1;
            this.registerButon.ActiveCornerRadius = 20;
            this.registerButon.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(81)))), ((int)(((byte)(0)))));
            this.registerButon.ActiveForecolor = System.Drawing.Color.White;
            this.registerButon.ActiveLineColor = System.Drawing.Color.White;
            this.registerButon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(28)))), ((int)(((byte)(38)))));
            this.registerButon.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("registerButon.BackgroundImage")));
            this.registerButon.ButtonText = "Register";
            this.registerButon.Cursor = System.Windows.Forms.Cursors.Hand;
            this.registerButon.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.registerButon.ForeColor = System.Drawing.Color.White;
            this.registerButon.IdleBorderThickness = 1;
            this.registerButon.IdleCornerRadius = 20;
            this.registerButon.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(125)))), ((int)(((byte)(0)))));
            this.registerButon.IdleForecolor = System.Drawing.Color.White;
            this.registerButon.IdleLineColor = System.Drawing.Color.White;
            this.registerButon.Location = new System.Drawing.Point(122, 605);
            this.registerButon.Margin = new System.Windows.Forms.Padding(5);
            this.registerButon.Name = "registerButon";
            this.registerButon.Size = new System.Drawing.Size(221, 41);
            this.registerButon.TabIndex = 12;
            this.registerButon.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Elephant", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(109, 23);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(248, 42);
            this.label5.TabIndex = 11;
            this.label5.Text = "MIT Banking";
            // 
            // pictureBox4
            // 
            this.pictureBox4.Location = new System.Drawing.Point(3, 0);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(70, 65);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 10;
            this.pictureBox4.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(95, 564);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(306, 21);
            this.label4.TabIndex = 9;
            this.label4.Text = "I Accept the Terms and Conditions ";
            // 
            // acceptTermsCheckBox
            // 
            this.acceptTermsCheckBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(205)))), ((int)(((byte)(117)))));
            this.acceptTermsCheckBox.ChechedOffColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(135)))), ((int)(((byte)(140)))));
            this.acceptTermsCheckBox.Checked = true;
            this.acceptTermsCheckBox.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(205)))), ((int)(((byte)(117)))));
            this.acceptTermsCheckBox.ForeColor = System.Drawing.Color.White;
            this.acceptTermsCheckBox.Location = new System.Drawing.Point(59, 567);
            this.acceptTermsCheckBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.acceptTermsCheckBox.Name = "acceptTermsCheckBox";
            this.acceptTermsCheckBox.Size = new System.Drawing.Size(20, 20);
            this.acceptTermsCheckBox.TabIndex = 8;
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = false;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this;
            this.bunifuDragControl1.Vertical = true;
            // 
            // logInPanel
            // 
            this.logInPanel.Controls.Add(this.codeTxtbox);
            this.logInPanel.Controls.Add(this.label2);
            this.logInPanel.Controls.Add(this.label1);
            this.logInPanel.Controls.Add(this.loginButon);
            this.logInPanel.Controls.Add(this.pictureBox3);
            this.logInPanel.Controls.Add(this.passwordLoginTxtbox);
            this.logInPanel.Controls.Add(this.pictureBox2);
            this.logInPanel.Controls.Add(this.usernameLoginTxtbox);
            this.logInPanel.Controls.Add(this.pictureBox1);
            this.logInPanel.Location = new System.Drawing.Point(38, 51);
            this.logInPanel.Name = "logInPanel";
            this.logInPanel.Size = new System.Drawing.Size(514, 750);
            this.logInPanel.TabIndex = 11;
            // 
            // codeTxtbox
            // 
            this.codeTxtbox.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(81)))), ((int)(((byte)(0)))));
            this.codeTxtbox.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(125)))), ((int)(((byte)(0)))));
            this.codeTxtbox.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(81)))), ((int)(((byte)(0)))));
            this.codeTxtbox.BorderThickness = 3;
            this.codeTxtbox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.codeTxtbox.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.codeTxtbox.ForeColor = System.Drawing.Color.White;
            this.codeTxtbox.isPassword = false;
            this.codeTxtbox.Location = new System.Drawing.Point(153, 420);
            this.codeTxtbox.Margin = new System.Windows.Forms.Padding(4);
            this.codeTxtbox.Name = "codeTxtbox";
            this.codeTxtbox.Size = new System.Drawing.Size(208, 38);
            this.codeTxtbox.TabIndex = 17;
            this.codeTxtbox.Text = "Code From SMS";
            this.codeTxtbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Elephant", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(208, 637);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 26);
            this.label2.TabIndex = 16;
            this.label2.Text = "SignUp";
            this.label2.Click += new System.EventHandler(this.label2_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(159, 369);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(185, 23);
            this.label1.TabIndex = 15;
            this.label1.Text = "Forget password?";
            // 
            // loginButon
            // 
            this.loginButon.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.loginButon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(125)))), ((int)(((byte)(0)))));
            this.loginButon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.loginButon.BorderRadius = 0;
            this.loginButon.ButtonText = "Login";
            this.loginButon.Cursor = System.Windows.Forms.Cursors.Hand;
            this.loginButon.DisabledColor = System.Drawing.Color.Gray;
            this.loginButon.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginButon.Iconcolor = System.Drawing.Color.Transparent;
            this.loginButon.Iconimage = null;
            this.loginButon.Iconimage_right = null;
            this.loginButon.Iconimage_right_Selected = null;
            this.loginButon.Iconimage_Selected = null;
            this.loginButon.IconMarginLeft = 0;
            this.loginButon.IconMarginRight = 0;
            this.loginButon.IconRightVisible = true;
            this.loginButon.IconRightZoom = 0D;
            this.loginButon.IconVisible = true;
            this.loginButon.IconZoom = 90D;
            this.loginButon.IsTab = false;
            this.loginButon.Location = new System.Drawing.Point(53, 573);
            this.loginButon.Margin = new System.Windows.Forms.Padding(4);
            this.loginButon.Name = "loginButon";
            this.loginButon.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(125)))), ((int)(((byte)(0)))));
            this.loginButon.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(81)))), ((int)(((byte)(0)))));
            this.loginButon.OnHoverTextColor = System.Drawing.Color.White;
            this.loginButon.selected = false;
            this.loginButon.Size = new System.Drawing.Size(399, 36);
            this.loginButon.TabIndex = 14;
            this.loginButon.Text = "Login";
            this.loginButon.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.loginButon.Textcolor = System.Drawing.Color.White;
            this.loginButon.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginButon.Click += new System.EventHandler(this.loginButon_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Location = new System.Drawing.Point(53, 320);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(38, 33);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 13;
            this.pictureBox3.TabStop = false;
            // 
            // passwordLoginTxtbox
            // 
            this.passwordLoginTxtbox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.passwordLoginTxtbox.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.passwordLoginTxtbox.ForeColor = System.Drawing.Color.White;
            this.passwordLoginTxtbox.HintForeColor = System.Drawing.Color.White;
            this.passwordLoginTxtbox.HintText = "Password";
            this.passwordLoginTxtbox.isPassword = true;
            this.passwordLoginTxtbox.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(81)))), ((int)(((byte)(0)))));
            this.passwordLoginTxtbox.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(125)))), ((int)(((byte)(0)))));
            this.passwordLoginTxtbox.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(81)))), ((int)(((byte)(0)))));
            this.passwordLoginTxtbox.LineThickness = 3;
            this.passwordLoginTxtbox.Location = new System.Drawing.Point(88, 320);
            this.passwordLoginTxtbox.Margin = new System.Windows.Forms.Padding(4);
            this.passwordLoginTxtbox.Name = "passwordLoginTxtbox";
            this.passwordLoginTxtbox.Size = new System.Drawing.Size(364, 33);
            this.passwordLoginTxtbox.TabIndex = 12;
            this.passwordLoginTxtbox.Text = "User Name";
            this.passwordLoginTxtbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(53, 211);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(38, 33);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 11;
            this.pictureBox2.TabStop = false;
            // 
            // usernameLoginTxtbox
            // 
            this.usernameLoginTxtbox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.usernameLoginTxtbox.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.usernameLoginTxtbox.ForeColor = System.Drawing.Color.White;
            this.usernameLoginTxtbox.HintForeColor = System.Drawing.Color.White;
            this.usernameLoginTxtbox.HintText = "User Name";
            this.usernameLoginTxtbox.isPassword = false;
            this.usernameLoginTxtbox.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(81)))), ((int)(((byte)(0)))));
            this.usernameLoginTxtbox.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(125)))), ((int)(((byte)(0)))));
            this.usernameLoginTxtbox.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(81)))), ((int)(((byte)(0)))));
            this.usernameLoginTxtbox.LineThickness = 3;
            this.usernameLoginTxtbox.Location = new System.Drawing.Point(88, 211);
            this.usernameLoginTxtbox.Margin = new System.Windows.Forms.Padding(4);
            this.usernameLoginTxtbox.Name = "usernameLoginTxtbox";
            this.usernameLoginTxtbox.Size = new System.Drawing.Size(364, 33);
            this.usernameLoginTxtbox.TabIndex = 10;
            this.usernameLoginTxtbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(28)))), ((int)(((byte)(38)))));
            this.ClientSize = new System.Drawing.Size(758, 786);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.logInPanel);
            this.Controls.Add(this.registrationPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.registrationPanel.ResumeLayout(false);
            this.registrationPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.logInPanel.ResumeLayout(false);
            this.logInPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel registrationPanel;
        private System.Windows.Forms.Label label6;
        private Bunifu.Framework.UI.BunifuThinButton2 registerButon;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label label4;
        private Bunifu.Framework.UI.BunifuCheckbox acceptTermsCheckBox;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private System.Windows.Forms.Panel logInPanel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuFlatButton loginButon;
        private System.Windows.Forms.PictureBox pictureBox3;
        private Bunifu.Framework.UI.BunifuMaterialTextbox passwordLoginTxtbox;
        private System.Windows.Forms.PictureBox pictureBox2;
        private Bunifu.Framework.UI.BunifuMaterialTextbox usernameLoginTxtbox;
        private Bunifu.Framework.UI.BunifuMetroTextbox codeTxtbox;
        private Bunifu.Framework.UI.BunifuMaterialTextbox emailTxtbox;
        private Bunifu.Framework.UI.BunifuMaterialTextbox retypepasswordTxtbox;
        private Bunifu.Framework.UI.BunifuMaterialTextbox passwordTxtbox;
        private Bunifu.Framework.UI.BunifuMaterialTextbox lastnameTxtbox;
        private Bunifu.Framework.UI.BunifuMaterialTextbox firstnameTxtbox;
        private Bunifu.Framework.UI.BunifuMaterialTextbox numberphoneTxtBox;
        private Bunifu.Framework.UI.BunifuMaterialTextbox adressTxtbox;
        private Bunifu.Framework.UI.BunifuMaterialTextbox birtdateTxt;
    }
}

