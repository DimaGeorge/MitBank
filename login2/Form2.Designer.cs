namespace login2
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.label11 = new System.Windows.Forms.Label();
            this.LabelShowAccounts = new System.Windows.Forms.Label();
            this.header = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.Dashboard = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuFlatButton2 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuFlatButton3 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuFlatButton4 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuFlatButton5 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.label3 = new System.Windows.Forms.Label();
            this.label4LastName = new System.Windows.Forms.Label();
            this.logoutButton = new Bunifu.Framework.UI.BunifuFlatButton();
            this.panelMainDashboard = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panelMainPaySomething = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.panelMainTransfer = new System.Windows.Forms.Panel();
            this.labelcurrencyToIban = new System.Windows.Forms.Label();
            this.textoxValueToTransfer = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.label14 = new System.Windows.Forms.Label();
            this.labelComisionValue = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.comboBoxSelectTransfer = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.labelshowcurrency = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.labelshowsold = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.label6 = new System.Windows.Forms.Label();
            this.comboBoxIBAN = new System.Windows.Forms.ComboBox();
            this.comboBoxToTransferMyIBAN = new System.Windows.Forms.ComboBox();
            this.textBoxWriteIBAN = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.panelMainSendMail = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.panelMainSettings = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.radioButtonCheckIBAN = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.header.SuspendLayout();
            this.panelMainDashboard.SuspendLayout();
            this.panelMainPaySomething.SuspendLayout();
            this.panelMainTransfer.SuspendLayout();
            this.panelMainSendMail.SuspendLayout();
            this.panelMainSettings.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(0, 0);
            this.pictureBox4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(65, 66);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 11;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Click += new System.EventHandler(this.pictureBox4_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Elephant", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(1161, 7);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(27, 26);
            this.label11.TabIndex = 10;
            this.label11.Text = "X";
            this.label11.Click += new System.EventHandler(this.label11_Click);
            // 
            // LabelShowAccounts
            // 
            this.LabelShowAccounts.AutoSize = true;
            this.LabelShowAccounts.Font = new System.Drawing.Font("Palatino Linotype", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelShowAccounts.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(125)))), ((int)(((byte)(0)))));
            this.LabelShowAccounts.Location = new System.Drawing.Point(432, 356);
            this.LabelShowAccounts.Name = "LabelShowAccounts";
            this.LabelShowAccounts.Size = new System.Drawing.Size(98, 26);
            this.LabelShowAccounts.TabIndex = 2;
            this.LabelShowAccounts.Text = "Welcome, ";
            // 
            // header
            // 
            this.header.AutoSize = true;
            this.header.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.header.Controls.Add(this.label5);
            this.header.Controls.Add(this.label1);
            this.header.Controls.Add(this.label11);
            this.header.Controls.Add(this.pictureBox4);
            this.header.Dock = System.Windows.Forms.DockStyle.Top;
            this.header.Location = new System.Drawing.Point(0, 0);
            this.header.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.header.Name = "header";
            this.header.Size = new System.Drawing.Size(1200, 68);
            this.header.TabIndex = 18;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Elephant", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(71, 11);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(224, 38);
            this.label5.TabIndex = 19;
            this.label5.Text = "MIT Banking";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Elephant", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(1124, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(22, 26);
            this.label1.TabIndex = 12;
            this.label1.Text = "_";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.header;
            this.bunifuDragControl1.Vertical = true;
            // 
            // Dashboard
            // 
            this.Dashboard.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(40)))));
            this.Dashboard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(40)))));
            this.Dashboard.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Dashboard.BorderRadius = 0;
            this.Dashboard.ButtonText = " Dashboard";
            this.Dashboard.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Dashboard.DisabledColor = System.Drawing.Color.Gray;
            this.Dashboard.Iconcolor = System.Drawing.Color.Transparent;
            this.Dashboard.Iconimage = ((System.Drawing.Image)(resources.GetObject("Dashboard.Iconimage")));
            this.Dashboard.Iconimage_right = null;
            this.Dashboard.Iconimage_right_Selected = null;
            this.Dashboard.Iconimage_Selected = null;
            this.Dashboard.IconMarginLeft = 0;
            this.Dashboard.IconMarginRight = 0;
            this.Dashboard.IconRightVisible = true;
            this.Dashboard.IconRightZoom = 0D;
            this.Dashboard.IconVisible = true;
            this.Dashboard.IconZoom = 90D;
            this.Dashboard.IsTab = true;
            this.Dashboard.Location = new System.Drawing.Point(0, 135);
            this.Dashboard.Margin = new System.Windows.Forms.Padding(5);
            this.Dashboard.Name = "Dashboard";
            this.Dashboard.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(28)))), ((int)(((byte)(38)))));
            this.Dashboard.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.Dashboard.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(125)))), ((int)(((byte)(0)))));
            this.Dashboard.selected = true;
            this.Dashboard.Size = new System.Drawing.Size(221, 59);
            this.Dashboard.TabIndex = 0;
            this.Dashboard.Text = " Dashboard";
            this.Dashboard.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Dashboard.Textcolor = System.Drawing.Color.White;
            this.Dashboard.TextFont = new System.Drawing.Font("Segoe UI Emoji", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Dashboard.Click += new System.EventHandler(this.Dashboard_Click);
            // 
            // bunifuFlatButton2
            // 
            this.bunifuFlatButton2.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(40)))));
            this.bunifuFlatButton2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(28)))), ((int)(((byte)(38)))));
            this.bunifuFlatButton2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.bunifuFlatButton2.BorderRadius = 0;
            this.bunifuFlatButton2.ButtonText = "      Pay something";
            this.bunifuFlatButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuFlatButton2.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton2.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton2.Iconimage = ((System.Drawing.Image)(resources.GetObject("bunifuFlatButton2.Iconimage")));
            this.bunifuFlatButton2.Iconimage_right = null;
            this.bunifuFlatButton2.Iconimage_right_Selected = null;
            this.bunifuFlatButton2.Iconimage_Selected = null;
            this.bunifuFlatButton2.IconMarginLeft = 0;
            this.bunifuFlatButton2.IconMarginRight = 0;
            this.bunifuFlatButton2.IconRightVisible = true;
            this.bunifuFlatButton2.IconRightZoom = 0D;
            this.bunifuFlatButton2.IconVisible = true;
            this.bunifuFlatButton2.IconZoom = 90D;
            this.bunifuFlatButton2.IsTab = true;
            this.bunifuFlatButton2.Location = new System.Drawing.Point(0, 229);
            this.bunifuFlatButton2.Margin = new System.Windows.Forms.Padding(5);
            this.bunifuFlatButton2.Name = "bunifuFlatButton2";
            this.bunifuFlatButton2.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(28)))), ((int)(((byte)(38)))));
            this.bunifuFlatButton2.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.bunifuFlatButton2.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(125)))), ((int)(((byte)(0)))));
            this.bunifuFlatButton2.selected = false;
            this.bunifuFlatButton2.Size = new System.Drawing.Size(221, 59);
            this.bunifuFlatButton2.TabIndex = 1;
            this.bunifuFlatButton2.Text = "      Pay something";
            this.bunifuFlatButton2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuFlatButton2.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButton2.TextFont = new System.Drawing.Font("Segoe UI Emoji", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuFlatButton2.Click += new System.EventHandler(this.bunifuFlatButton2_Click);
            // 
            // bunifuFlatButton3
            // 
            this.bunifuFlatButton3.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(40)))));
            this.bunifuFlatButton3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(28)))), ((int)(((byte)(38)))));
            this.bunifuFlatButton3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.bunifuFlatButton3.BorderRadius = 0;
            this.bunifuFlatButton3.ButtonText = "Transfer";
            this.bunifuFlatButton3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuFlatButton3.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton3.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton3.Iconimage = ((System.Drawing.Image)(resources.GetObject("bunifuFlatButton3.Iconimage")));
            this.bunifuFlatButton3.Iconimage_right = null;
            this.bunifuFlatButton3.Iconimage_right_Selected = null;
            this.bunifuFlatButton3.Iconimage_Selected = null;
            this.bunifuFlatButton3.IconMarginLeft = 0;
            this.bunifuFlatButton3.IconMarginRight = 0;
            this.bunifuFlatButton3.IconRightVisible = true;
            this.bunifuFlatButton3.IconRightZoom = 0D;
            this.bunifuFlatButton3.IconVisible = true;
            this.bunifuFlatButton3.IconZoom = 90D;
            this.bunifuFlatButton3.IsTab = true;
            this.bunifuFlatButton3.Location = new System.Drawing.Point(0, 320);
            this.bunifuFlatButton3.Margin = new System.Windows.Forms.Padding(5);
            this.bunifuFlatButton3.Name = "bunifuFlatButton3";
            this.bunifuFlatButton3.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(28)))), ((int)(((byte)(38)))));
            this.bunifuFlatButton3.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.bunifuFlatButton3.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(125)))), ((int)(((byte)(0)))));
            this.bunifuFlatButton3.selected = false;
            this.bunifuFlatButton3.Size = new System.Drawing.Size(221, 59);
            this.bunifuFlatButton3.TabIndex = 2;
            this.bunifuFlatButton3.Text = "Transfer";
            this.bunifuFlatButton3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuFlatButton3.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButton3.TextFont = new System.Drawing.Font("Segoe UI Emoji", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuFlatButton3.Click += new System.EventHandler(this.bunifuFlatButton3_Click);
            // 
            // bunifuFlatButton4
            // 
            this.bunifuFlatButton4.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(40)))));
            this.bunifuFlatButton4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(28)))), ((int)(((byte)(38)))));
            this.bunifuFlatButton4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.bunifuFlatButton4.BorderRadius = 0;
            this.bunifuFlatButton4.ButtonText = "  Send mail";
            this.bunifuFlatButton4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuFlatButton4.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton4.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton4.Iconimage = ((System.Drawing.Image)(resources.GetObject("bunifuFlatButton4.Iconimage")));
            this.bunifuFlatButton4.Iconimage_right = null;
            this.bunifuFlatButton4.Iconimage_right_Selected = null;
            this.bunifuFlatButton4.Iconimage_Selected = null;
            this.bunifuFlatButton4.IconMarginLeft = 0;
            this.bunifuFlatButton4.IconMarginRight = 0;
            this.bunifuFlatButton4.IconRightVisible = true;
            this.bunifuFlatButton4.IconRightZoom = 0D;
            this.bunifuFlatButton4.IconVisible = true;
            this.bunifuFlatButton4.IconZoom = 90D;
            this.bunifuFlatButton4.IsTab = true;
            this.bunifuFlatButton4.Location = new System.Drawing.Point(0, 409);
            this.bunifuFlatButton4.Margin = new System.Windows.Forms.Padding(5);
            this.bunifuFlatButton4.Name = "bunifuFlatButton4";
            this.bunifuFlatButton4.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(28)))), ((int)(((byte)(38)))));
            this.bunifuFlatButton4.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.bunifuFlatButton4.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(125)))), ((int)(((byte)(0)))));
            this.bunifuFlatButton4.selected = false;
            this.bunifuFlatButton4.Size = new System.Drawing.Size(221, 59);
            this.bunifuFlatButton4.TabIndex = 3;
            this.bunifuFlatButton4.Text = "  Send mail";
            this.bunifuFlatButton4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuFlatButton4.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButton4.TextFont = new System.Drawing.Font("Segoe UI Emoji", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuFlatButton4.Click += new System.EventHandler(this.bunifuFlatButton4_Click);
            // 
            // bunifuFlatButton5
            // 
            this.bunifuFlatButton5.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(40)))));
            this.bunifuFlatButton5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(28)))), ((int)(((byte)(38)))));
            this.bunifuFlatButton5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.bunifuFlatButton5.BorderRadius = 0;
            this.bunifuFlatButton5.ButtonText = "  Settings";
            this.bunifuFlatButton5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuFlatButton5.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton5.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton5.Iconimage = ((System.Drawing.Image)(resources.GetObject("bunifuFlatButton5.Iconimage")));
            this.bunifuFlatButton5.Iconimage_right = null;
            this.bunifuFlatButton5.Iconimage_right_Selected = null;
            this.bunifuFlatButton5.Iconimage_Selected = null;
            this.bunifuFlatButton5.IconMarginLeft = 0;
            this.bunifuFlatButton5.IconMarginRight = 0;
            this.bunifuFlatButton5.IconRightVisible = true;
            this.bunifuFlatButton5.IconRightZoom = 0D;
            this.bunifuFlatButton5.IconVisible = true;
            this.bunifuFlatButton5.IconZoom = 90D;
            this.bunifuFlatButton5.IsTab = true;
            this.bunifuFlatButton5.Location = new System.Drawing.Point(0, 507);
            this.bunifuFlatButton5.Margin = new System.Windows.Forms.Padding(5);
            this.bunifuFlatButton5.Name = "bunifuFlatButton5";
            this.bunifuFlatButton5.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(28)))), ((int)(((byte)(38)))));
            this.bunifuFlatButton5.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.bunifuFlatButton5.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(125)))), ((int)(((byte)(0)))));
            this.bunifuFlatButton5.selected = false;
            this.bunifuFlatButton5.Size = new System.Drawing.Size(221, 59);
            this.bunifuFlatButton5.TabIndex = 4;
            this.bunifuFlatButton5.Text = "  Settings";
            this.bunifuFlatButton5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuFlatButton5.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButton5.TextFont = new System.Drawing.Font("Segoe UI Emoji", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuFlatButton5.Click += new System.EventHandler(this.bunifuFlatButton5_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Palatino Linotype", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(125)))), ((int)(((byte)(0)))));
            this.label3.Location = new System.Drawing.Point(1, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 26);
            this.label3.TabIndex = 1;
            this.label3.Text = "Welcome, ";
            // 
            // label4LastName
            // 
            this.label4LastName.AutoSize = true;
            this.label4LastName.Font = new System.Drawing.Font("Palatino Linotype", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4LastName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(125)))), ((int)(((byte)(0)))));
            this.label4LastName.Location = new System.Drawing.Point(99, 69);
            this.label4LastName.Name = "label4LastName";
            this.label4LastName.Size = new System.Drawing.Size(0, 26);
            this.label4LastName.TabIndex = 20;
            // 
            // logoutButton
            // 
            this.logoutButton.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(40)))));
            this.logoutButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(40)))));
            this.logoutButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.logoutButton.BorderRadius = 0;
            this.logoutButton.ButtonText = "Logout";
            this.logoutButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.logoutButton.DisabledColor = System.Drawing.Color.Gray;
            this.logoutButton.Iconcolor = System.Drawing.Color.Transparent;
            this.logoutButton.Iconimage = ((System.Drawing.Image)(resources.GetObject("logoutButton.Iconimage")));
            this.logoutButton.Iconimage_right = null;
            this.logoutButton.Iconimage_right_Selected = null;
            this.logoutButton.Iconimage_Selected = null;
            this.logoutButton.IconMarginLeft = 0;
            this.logoutButton.IconMarginRight = 0;
            this.logoutButton.IconRightVisible = true;
            this.logoutButton.IconRightZoom = 0D;
            this.logoutButton.IconVisible = true;
            this.logoutButton.IconZoom = 90D;
            this.logoutButton.IsTab = true;
            this.logoutButton.Location = new System.Drawing.Point(0, 686);
            this.logoutButton.Margin = new System.Windows.Forms.Padding(5);
            this.logoutButton.Name = "logoutButton";
            this.logoutButton.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(28)))), ((int)(((byte)(38)))));
            this.logoutButton.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.logoutButton.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(125)))), ((int)(((byte)(0)))));
            this.logoutButton.selected = true;
            this.logoutButton.Size = new System.Drawing.Size(221, 59);
            this.logoutButton.TabIndex = 21;
            this.logoutButton.Text = "Logout";
            this.logoutButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.logoutButton.Textcolor = System.Drawing.Color.White;
            this.logoutButton.TextFont = new System.Drawing.Font("Segoe UI Emoji", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logoutButton.Click += new System.EventHandler(this.logoutButton_Click);
            // 
            // panelMainDashboard
            // 
            this.panelMainDashboard.Controls.Add(this.LabelShowAccounts);
            this.panelMainDashboard.Controls.Add(this.label2);
            this.panelMainDashboard.Location = new System.Drawing.Point(222, 85);
            this.panelMainDashboard.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelMainDashboard.Name = "panelMainDashboard";
            this.panelMainDashboard.Size = new System.Drawing.Size(1378, 868);
            this.panelMainDashboard.TabIndex = 22;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "label2";
            // 
            // panelMainPaySomething
            // 
            this.panelMainPaySomething.Controls.Add(this.label4);
            this.panelMainPaySomething.Location = new System.Drawing.Point(222, 85);
            this.panelMainPaySomething.Margin = new System.Windows.Forms.Padding(4);
            this.panelMainPaySomething.Name = "panelMainPaySomething";
            this.panelMainPaySomething.Size = new System.Drawing.Size(1378, 868);
            this.panelMainPaySomething.TabIndex = 23;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(37, 50);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 17);
            this.label4.TabIndex = 0;
            this.label4.Text = "label4";
            // 
            // panelMainTransfer
            // 
            this.panelMainTransfer.Controls.Add(this.radioButtonCheckIBAN);
            this.panelMainTransfer.Controls.Add(this.labelcurrencyToIban);
            this.panelMainTransfer.Controls.Add(this.textoxValueToTransfer);
            this.panelMainTransfer.Controls.Add(this.label14);
            this.panelMainTransfer.Controls.Add(this.labelComisionValue);
            this.panelMainTransfer.Controls.Add(this.label13);
            this.panelMainTransfer.Controls.Add(this.label12);
            this.panelMainTransfer.Controls.Add(this.comboBoxSelectTransfer);
            this.panelMainTransfer.Controls.Add(this.label10);
            this.panelMainTransfer.Controls.Add(this.label9);
            this.panelMainTransfer.Controls.Add(this.labelshowcurrency);
            this.panelMainTransfer.Controls.Add(this.labelshowsold);
            this.panelMainTransfer.Controls.Add(this.label6);
            this.panelMainTransfer.Controls.Add(this.comboBoxIBAN);
            this.panelMainTransfer.Controls.Add(this.textBoxWriteIBAN);
            this.panelMainTransfer.Controls.Add(this.comboBoxToTransferMyIBAN);
            this.panelMainTransfer.Location = new System.Drawing.Point(222, 85);
            this.panelMainTransfer.Margin = new System.Windows.Forms.Padding(4);
            this.panelMainTransfer.Name = "panelMainTransfer";
            this.panelMainTransfer.Size = new System.Drawing.Size(1378, 868);
            this.panelMainTransfer.TabIndex = 24;
            // 
            // labelcurrencyToIban
            // 
            this.labelcurrencyToIban.AutoSize = true;
            this.labelcurrencyToIban.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelcurrencyToIban.ForeColor = System.Drawing.Color.Snow;
            this.labelcurrencyToIban.Location = new System.Drawing.Point(35, 298);
            this.labelcurrencyToIban.Name = "labelcurrencyToIban";
            this.labelcurrencyToIban.Size = new System.Drawing.Size(19, 25);
            this.labelcurrencyToIban.TabIndex = 17;
            this.labelcurrencyToIban.Text = "-";
            // 
            // textoxValueToTransfer
            // 
            this.textoxValueToTransfer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.textoxValueToTransfer.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.textoxValueToTransfer.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.textoxValueToTransfer.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(40)))));
            this.textoxValueToTransfer.BorderThickness = 3;
            this.textoxValueToTransfer.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textoxValueToTransfer.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textoxValueToTransfer.ForeColor = System.Drawing.Color.White;
            this.textoxValueToTransfer.isPassword = false;
            this.textoxValueToTransfer.Location = new System.Drawing.Point(101, 337);
            this.textoxValueToTransfer.Margin = new System.Windows.Forms.Padding(4);
            this.textoxValueToTransfer.Name = "textoxValueToTransfer";
            this.textoxValueToTransfer.Size = new System.Drawing.Size(167, 30);
            this.textoxValueToTransfer.TabIndex = 15;
            this.textoxValueToTransfer.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.textoxValueToTransfer.OnValueChanged += new System.EventHandler(this.textoxValueToTransfer_OnValueChanged);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.Snow;
            this.label14.Location = new System.Drawing.Point(31, 337);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(63, 25);
            this.label14.TabIndex = 14;
            this.label14.Text = "Value";
            // 
            // labelComisionValue
            // 
            this.labelComisionValue.AutoSize = true;
            this.labelComisionValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelComisionValue.ForeColor = System.Drawing.Color.Snow;
            this.labelComisionValue.Location = new System.Drawing.Point(153, 386);
            this.labelComisionValue.Name = "labelComisionValue";
            this.labelComisionValue.Size = new System.Drawing.Size(19, 25);
            this.labelComisionValue.TabIndex = 13;
            this.labelComisionValue.Text = "-";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.Snow;
            this.label13.Location = new System.Drawing.Point(31, 386);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(94, 25);
            this.label13.TabIndex = 12;
            this.label13.Text = "Comision";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.Snow;
            this.label12.Location = new System.Drawing.Point(35, 235);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(109, 25);
            this.label12.TabIndex = 11;
            this.label12.Text = "Write IBAN";
            // 
            // comboBoxSelectTransfer
            // 
            this.comboBoxSelectTransfer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.comboBoxSelectTransfer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxSelectTransfer.ForeColor = System.Drawing.Color.White;
            this.comboBoxSelectTransfer.FormattingEnabled = true;
            this.comboBoxSelectTransfer.Items.AddRange(new object[] {
            "My another account",
            "Anyone else account"});
            this.comboBoxSelectTransfer.Location = new System.Drawing.Point(28, 188);
            this.comboBoxSelectTransfer.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxSelectTransfer.Name = "comboBoxSelectTransfer";
            this.comboBoxSelectTransfer.Size = new System.Drawing.Size(528, 26);
            this.comboBoxSelectTransfer.TabIndex = 7;
            this.comboBoxSelectTransfer.SelectedIndexChanged += new System.EventHandler(this.comboBoxSelectTransfer_SelectedIndexChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Snow;
            this.label10.Location = new System.Drawing.Point(31, 144);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(36, 25);
            this.label10.TabIndex = 6;
            this.label10.Text = "To";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Snow;
            this.label9.Location = new System.Drawing.Point(31, 25);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(174, 25);
            this.label9.TabIndex = 5;
            this.label9.Text = "From your account";
            // 
            // labelshowcurrency
            // 
            this.labelshowcurrency.AutoSize = true;
            this.labelshowcurrency.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelshowcurrency.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.labelshowcurrency.Location = new System.Drawing.Point(231, 107);
            this.labelshowcurrency.Name = "labelshowcurrency";
            this.labelshowcurrency.Size = new System.Drawing.Size(16, 24);
            this.labelshowcurrency.TabIndex = 4;
            this.labelshowcurrency.Text = "-";
            // 
            // labelshowsold
            // 
            this.labelshowsold.AutoSize = true;
            this.labelshowsold.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelshowsold.ForeColor = System.Drawing.Color.Snow;
            this.labelshowsold.Location = new System.Drawing.Point(127, 107);
            this.labelshowsold.Name = "labelshowsold";
            this.labelshowsold.Size = new System.Drawing.Size(16, 24);
            this.labelshowsold.TabIndex = 3;
            this.labelshowsold.Text = "-";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Location = new System.Drawing.Point(32, 107);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 22);
            this.label6.TabIndex = 2;
            this.label6.Text = "SOLD:  ";
            // 
            // comboBoxIBAN
            // 
            this.comboBoxIBAN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.comboBoxIBAN.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxIBAN.ForeColor = System.Drawing.Color.White;
            this.comboBoxIBAN.FormattingEnabled = true;
            this.comboBoxIBAN.Location = new System.Drawing.Point(28, 64);
            this.comboBoxIBAN.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxIBAN.Name = "comboBoxIBAN";
            this.comboBoxIBAN.Size = new System.Drawing.Size(528, 26);
            this.comboBoxIBAN.TabIndex = 1;
            this.comboBoxIBAN.SelectedIndexChanged += new System.EventHandler(this.comboBoxIBAN_SelectedIndexChanged);
            // 
            // comboBoxToTransferMyIBAN
            // 
            this.comboBoxToTransferMyIBAN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.comboBoxToTransferMyIBAN.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxToTransferMyIBAN.ForeColor = System.Drawing.Color.White;
            this.comboBoxToTransferMyIBAN.FormattingEnabled = true;
            this.comboBoxToTransferMyIBAN.Location = new System.Drawing.Point(28, 268);
            this.comboBoxToTransferMyIBAN.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxToTransferMyIBAN.Name = "comboBoxToTransferMyIBAN";
            this.comboBoxToTransferMyIBAN.Size = new System.Drawing.Size(528, 26);
            this.comboBoxToTransferMyIBAN.TabIndex = 8;
            this.comboBoxToTransferMyIBAN.SelectedIndexChanged += new System.EventHandler(this.comboBoxToTransferMyIBAN_SelectedIndexChanged);
            // 
            // textBoxWriteIBAN
            // 
            this.textBoxWriteIBAN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.textBoxWriteIBAN.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.textBoxWriteIBAN.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.textBoxWriteIBAN.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(40)))));
            this.textBoxWriteIBAN.BorderThickness = 3;
            this.textBoxWriteIBAN.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBoxWriteIBAN.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxWriteIBAN.ForeColor = System.Drawing.Color.White;
            this.textBoxWriteIBAN.isPassword = false;
            this.textBoxWriteIBAN.Location = new System.Drawing.Point(28, 264);
            this.textBoxWriteIBAN.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxWriteIBAN.Name = "textBoxWriteIBAN";
            this.textBoxWriteIBAN.Size = new System.Drawing.Size(528, 30);
            this.textBoxWriteIBAN.TabIndex = 10;
            this.textBoxWriteIBAN.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // panelMainSendMail
            // 
            this.panelMainSendMail.Controls.Add(this.label7);
            this.panelMainSendMail.Location = new System.Drawing.Point(222, 85);
            this.panelMainSendMail.Margin = new System.Windows.Forms.Padding(4);
            this.panelMainSendMail.Name = "panelMainSendMail";
            this.panelMainSendMail.Size = new System.Drawing.Size(1378, 868);
            this.panelMainSendMail.TabIndex = 25;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(37, 50);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(46, 17);
            this.label7.TabIndex = 0;
            this.label7.Text = "label7";
            // 
            // panelMainSettings
            // 
            this.panelMainSettings.Controls.Add(this.label8);
            this.panelMainSettings.Location = new System.Drawing.Point(222, 85);
            this.panelMainSettings.Margin = new System.Windows.Forms.Padding(4);
            this.panelMainSettings.Name = "panelMainSettings";
            this.panelMainSettings.Size = new System.Drawing.Size(1378, 868);
            this.panelMainSettings.TabIndex = 26;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(37, 50);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(46, 17);
            this.label8.TabIndex = 0;
            this.label8.Text = "label8";
            // 
            // radioButtonCheckIBAN
            // 
            this.radioButtonCheckIBAN.AutoSize = true;
            this.radioButtonCheckIBAN.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.radioButtonCheckIBAN.Location = new System.Drawing.Point(101, 302);
            this.radioButtonCheckIBAN.Name = "radioButtonCheckIBAN";
            this.radioButtonCheckIBAN.Size = new System.Drawing.Size(163, 21);
            this.radioButtonCheckIBAN.TabIndex = 18;
            this.radioButtonCheckIBAN.TabStop = true;
            this.radioButtonCheckIBAN.Text = "Check if IBAN is Valid";
            this.radioButtonCheckIBAN.UseVisualStyleBackColor = true;
            this.radioButtonCheckIBAN.CheckedChanged += new System.EventHandler(this.radioButtonCheckIBAN_CheckedChanged);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(28)))), ((int)(((byte)(38)))));
            this.ClientSize = new System.Drawing.Size(1200, 786);
            this.Controls.Add(this.logoutButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4LastName);
            this.Controls.Add(this.bunifuFlatButton5);
            this.Controls.Add(this.header);
            this.Controls.Add(this.bunifuFlatButton4);
            this.Controls.Add(this.bunifuFlatButton3);
            this.Controls.Add(this.Dashboard);
            this.Controls.Add(this.bunifuFlatButton2);
            this.Controls.Add(this.panelMainTransfer);
            this.Controls.Add(this.panelMainPaySomething);
            this.Controls.Add(this.panelMainDashboard);
            this.Controls.Add(this.panelMainSettings);
            this.Controls.Add(this.panelMainSendMail);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.header.ResumeLayout(false);
            this.header.PerformLayout();
            this.panelMainDashboard.ResumeLayout(false);
            this.panelMainDashboard.PerformLayout();
            this.panelMainPaySomething.ResumeLayout(false);
            this.panelMainPaySomething.PerformLayout();
            this.panelMainTransfer.ResumeLayout(false);
            this.panelMainTransfer.PerformLayout();
            this.panelMainSendMail.ResumeLayout(false);
            this.panelMainSendMail.PerformLayout();
            this.panelMainSettings.ResumeLayout(false);
            this.panelMainSettings.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion



        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Panel header;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private Bunifu.Framework.UI.BunifuFlatButton Dashboard;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton2;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton3;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton4;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton5;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4LastName;
        private System.Windows.Forms.Label label3;
        private Bunifu.Framework.UI.BunifuFlatButton logoutButton;
        private System.Windows.Forms.Panel panelMainDashboard;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4_Click;
        private System.Windows.Forms.Label LabelShowAccounts;
        private System.Windows.Forms.Panel panelMainPaySomething;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panelMainTransfer;
        private System.Windows.Forms.Panel panelMainSendMail;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panelMainSettings;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox comboBoxIBAN;
        private System.Windows.Forms.Label label6;
        private Bunifu.Framework.UI.BunifuCustomLabel labelshowcurrency;
        private Bunifu.Framework.UI.BunifuCustomLabel labelshowsold;
        private System.Windows.Forms.ComboBox comboBoxSelectTransfer;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox comboBoxToTransferMyIBAN;
        private Bunifu.Framework.UI.BunifuMetroTextbox textBoxWriteIBAN;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label labelComisionValue;
        private Bunifu.Framework.UI.BunifuMetroTextbox textoxValueToTransfer;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label labelcurrencyToIban;
        private System.Windows.Forms.RadioButton radioButtonCheckIBAN;
    }
}