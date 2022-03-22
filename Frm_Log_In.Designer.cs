namespace project
{
    partial class Frm_Log_In
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
            this.cmb_UserRole = new System.Windows.Forms.ComboBox();
            this.pnl_Main = new System.Windows.Forms.Panel();
            this.lnl_Show = new System.Windows.Forms.LinkLabel();
            this.lbl_forget_pw = new System.Windows.Forms.Label();
            this.lbl_UserRole = new System.Windows.Forms.Label();
            this.tb_Password = new System.Windows.Forms.TextBox();
            this.tb_Username = new System.Windows.Forms.TextBox();
            this.lbl_Password = new System.Windows.Forms.Label();
            this.btn_Login = new System.Windows.Forms.Button();
            this.lbl_Note = new System.Windows.Forms.Label();
            this.lbl_Username = new System.Windows.Forms.Label();
            this.lbl_Login = new System.Windows.Forms.Label();
            this.lbl_Registration = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pnl_Main.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmb_UserRole
            // 
            this.cmb_UserRole.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_UserRole.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_UserRole.FormattingEnabled = true;
            this.cmb_UserRole.Items.AddRange(new object[] {
            "Survair",
            "Taluka Officer",
            "District Officer"});
            this.cmb_UserRole.Location = new System.Drawing.Point(56, 254);
            this.cmb_UserRole.Margin = new System.Windows.Forms.Padding(2);
            this.cmb_UserRole.Name = "cmb_UserRole";
            this.cmb_UserRole.Size = new System.Drawing.Size(233, 29);
            this.cmb_UserRole.TabIndex = 3;
            // 
            // pnl_Main
            // 
            this.pnl_Main.BackColor = System.Drawing.Color.Wheat;
            this.pnl_Main.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnl_Main.Controls.Add(this.lnl_Show);
            this.pnl_Main.Controls.Add(this.lbl_forget_pw);
            this.pnl_Main.Controls.Add(this.cmb_UserRole);
            this.pnl_Main.Controls.Add(this.lbl_UserRole);
            this.pnl_Main.Controls.Add(this.tb_Password);
            this.pnl_Main.Controls.Add(this.tb_Username);
            this.pnl_Main.Controls.Add(this.lbl_Password);
            this.pnl_Main.Controls.Add(this.btn_Login);
            this.pnl_Main.Controls.Add(this.lbl_Note);
            this.pnl_Main.Controls.Add(this.lbl_Username);
            this.pnl_Main.Controls.Add(this.lbl_Login);
            this.pnl_Main.Location = new System.Drawing.Point(222, 29);
            this.pnl_Main.Margin = new System.Windows.Forms.Padding(2);
            this.pnl_Main.Name = "pnl_Main";
            this.pnl_Main.Size = new System.Drawing.Size(343, 406);
            this.pnl_Main.TabIndex = 6;
            this.pnl_Main.Paint += new System.Windows.Forms.PaintEventHandler(this.pnl_Main_Paint);
            // 
            // lnl_Show
            // 
            this.lnl_Show.ActiveLinkColor = System.Drawing.Color.Red;
            this.lnl_Show.AutoSize = true;
            this.lnl_Show.BackColor = System.Drawing.Color.Thistle;
            this.lnl_Show.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnl_Show.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.lnl_Show.LinkColor = System.Drawing.Color.White;
            this.lnl_Show.Location = new System.Drawing.Point(292, 193);
            this.lnl_Show.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lnl_Show.Name = "lnl_Show";
            this.lnl_Show.Size = new System.Drawing.Size(37, 15);
            this.lnl_Show.TabIndex = 9;
            this.lnl_Show.TabStop = true;
            this.lnl_Show.Text = "Show";
            // 
            // lbl_forget_pw
            // 
            this.lbl_forget_pw.AutoSize = true;
            this.lbl_forget_pw.BackColor = System.Drawing.Color.Transparent;
            this.lbl_forget_pw.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbl_forget_pw.Font = new System.Drawing.Font("Segoe UI", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_forget_pw.ForeColor = System.Drawing.Color.White;
            this.lbl_forget_pw.Location = new System.Drawing.Point(206, 378);
            this.lbl_forget_pw.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_forget_pw.Name = "lbl_forget_pw";
            this.lbl_forget_pw.Size = new System.Drawing.Size(126, 13);
            this.lbl_forget_pw.TabIndex = 8;
            this.lbl_forget_pw.Text = "Forget Your Password?";
            // 
            // lbl_UserRole
            // 
            this.lbl_UserRole.AutoSize = true;
            this.lbl_UserRole.BackColor = System.Drawing.Color.Transparent;
            this.lbl_UserRole.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_UserRole.Location = new System.Drawing.Point(52, 225);
            this.lbl_UserRole.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_UserRole.Name = "lbl_UserRole";
            this.lbl_UserRole.Size = new System.Drawing.Size(92, 25);
            this.lbl_UserRole.TabIndex = 7;
            this.lbl_UserRole.Text = "User Role";
            // 
            // tb_Password
            // 
            this.tb_Password.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Password.Location = new System.Drawing.Point(56, 184);
            this.tb_Password.Margin = new System.Windows.Forms.Padding(2);
            this.tb_Password.MaxLength = 10;
            this.tb_Password.Name = "tb_Password";
            this.tb_Password.PasswordChar = '*';
            this.tb_Password.Size = new System.Drawing.Size(233, 29);
            this.tb_Password.TabIndex = 2;
            // 
            // tb_Username
            // 
            this.tb_Username.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Username.Location = new System.Drawing.Point(56, 120);
            this.tb_Username.Margin = new System.Windows.Forms.Padding(2);
            this.tb_Username.MaxLength = 20;
            this.tb_Username.Name = "tb_Username";
            this.tb_Username.Size = new System.Drawing.Size(233, 27);
            this.tb_Username.TabIndex = 1;
            // 
            // lbl_Password
            // 
            this.lbl_Password.AutoSize = true;
            this.lbl_Password.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Password.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Password.Location = new System.Drawing.Point(52, 156);
            this.lbl_Password.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_Password.Name = "lbl_Password";
            this.lbl_Password.Size = new System.Drawing.Size(91, 25);
            this.lbl_Password.TabIndex = 5;
            this.lbl_Password.Text = "Password";
            // 
            // btn_Login
            // 
            this.btn_Login.BackColor = System.Drawing.Color.Transparent;
            this.btn_Login.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Login.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_Login.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_Login.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Login.Font = new System.Drawing.Font("Elephant", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Login.ForeColor = System.Drawing.Color.Orange;
            this.btn_Login.Location = new System.Drawing.Point(104, 324);
            this.btn_Login.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Login.Name = "btn_Login";
            this.btn_Login.Size = new System.Drawing.Size(137, 52);
            this.btn_Login.TabIndex = 4;
            this.btn_Login.Text = "Log In";
            this.btn_Login.UseVisualStyleBackColor = false;
            this.btn_Login.Click += new System.EventHandler(this.btn_Login_Click);
            // 
            // lbl_Note
            // 
            this.lbl_Note.AutoSize = true;
            this.lbl_Note.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Note.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Note.ForeColor = System.Drawing.Color.Blue;
            this.lbl_Note.Location = new System.Drawing.Point(44, 290);
            this.lbl_Note.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_Note.Name = "lbl_Note";
            this.lbl_Note.Size = new System.Drawing.Size(263, 21);
            this.lbl_Note.TabIndex = 3;
            this.lbl_Note.Text = "Please Enter Username && Password";
            // 
            // lbl_Username
            // 
            this.lbl_Username.AutoSize = true;
            this.lbl_Username.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Username.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Username.Location = new System.Drawing.Point(52, 92);
            this.lbl_Username.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_Username.Name = "lbl_Username";
            this.lbl_Username.Size = new System.Drawing.Size(98, 25);
            this.lbl_Username.TabIndex = 1;
            this.lbl_Username.Text = "Username";
            // 
            // lbl_Login
            // 
            this.lbl_Login.AutoSize = true;
            this.lbl_Login.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Login.Font = new System.Drawing.Font("Elephant", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Login.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(31)))), ((int)(((byte)(85)))));
            this.lbl_Login.Location = new System.Drawing.Point(86, 24);
            this.lbl_Login.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_Login.Name = "lbl_Login";
            this.lbl_Login.Size = new System.Drawing.Size(176, 49);
            this.lbl_Login.TabIndex = 0;
            this.lbl_Login.Text = "LOGIN";
            // 
            // lbl_Registration
            // 
            this.lbl_Registration.AutoSize = true;
            this.lbl_Registration.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Registration.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbl_Registration.Font = new System.Drawing.Font("Segoe UI Semibold", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Registration.ForeColor = System.Drawing.Color.Orange;
            this.lbl_Registration.Location = new System.Drawing.Point(443, 410);
            this.lbl_Registration.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_Registration.Name = "lbl_Registration";
            this.lbl_Registration.Size = new System.Drawing.Size(80, 25);
            this.lbl_Registration.TabIndex = 7;
            this.lbl_Registration.Text = "Log Out";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.MediumVioletRed;
            this.label1.Location = new System.Drawing.Point(371, 456);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 25);
            this.label1.TabIndex = 8;
            this.label1.Text = "Sign In";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Frm_Log_In
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(755, 510);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pnl_Main);
            this.Controls.Add(this.lbl_Registration);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Frm_Log_In";
            this.Text = "Frm_Log_In";
            this.pnl_Main.ResumeLayout(false);
            this.pnl_Main.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmb_UserRole;
        private System.Windows.Forms.Panel pnl_Main;
        private System.Windows.Forms.LinkLabel lnl_Show;
        private System.Windows.Forms.Label lbl_forget_pw;
        private System.Windows.Forms.Label lbl_UserRole;
        private System.Windows.Forms.TextBox tb_Password;
        private System.Windows.Forms.TextBox tb_Username;
        private System.Windows.Forms.Label lbl_Password;
        private System.Windows.Forms.Button btn_Login;
        private System.Windows.Forms.Label lbl_Note;
        private System.Windows.Forms.Label lbl_Username;
        private System.Windows.Forms.Label lbl_Login;
        private System.Windows.Forms.Label lbl_Registration;
        private System.Windows.Forms.Label label1;


    }
}