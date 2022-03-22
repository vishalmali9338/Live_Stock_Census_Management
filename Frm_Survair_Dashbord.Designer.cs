namespace project
{
    partial class Frm_Survair_Dashbord
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.Lbl_Dashbord = new System.Windows.Forms.Label();
            this.DG_S_Dashbord = new System.Windows.Forms.DataGridView();
            this.Btn_Exit = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DG_S_Dashbord)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MediumTurquoise;
            this.panel1.Controls.Add(this.Lbl_Dashbord);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1145, 107);
            this.panel1.TabIndex = 0;
            // 
            // Lbl_Dashbord
            // 
            this.Lbl_Dashbord.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.Lbl_Dashbord.AutoSize = true;
            this.Lbl_Dashbord.BackColor = System.Drawing.SystemColors.MenuBar;
            this.Lbl_Dashbord.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Dashbord.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Lbl_Dashbord.Location = new System.Drawing.Point(444, 28);
            this.Lbl_Dashbord.Name = "Lbl_Dashbord";
            this.Lbl_Dashbord.Size = new System.Drawing.Size(234, 55);
            this.Lbl_Dashbord.TabIndex = 0;
            this.Lbl_Dashbord.Text = "Dashbord";
            this.Lbl_Dashbord.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // DG_S_Dashbord
            // 
            this.DG_S_Dashbord.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.DG_S_Dashbord.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DG_S_Dashbord.Location = new System.Drawing.Point(0, 105);
            this.DG_S_Dashbord.Name = "DG_S_Dashbord";
            this.DG_S_Dashbord.Size = new System.Drawing.Size(1144, 315);
            this.DG_S_Dashbord.TabIndex = 1;
            // 
            // Btn_Exit
            // 
            this.Btn_Exit.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.Btn_Exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Exit.Location = new System.Drawing.Point(441, 426);
            this.Btn_Exit.Name = "Btn_Exit";
            this.Btn_Exit.Size = new System.Drawing.Size(132, 40);
            this.Btn_Exit.TabIndex = 2;
            this.Btn_Exit.Text = "Exit";
            this.Btn_Exit.UseVisualStyleBackColor = true;
            // 
            // Frm_Survair_Dashbord
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1145, 478);
            this.Controls.Add(this.Btn_Exit);
            this.Controls.Add(this.DG_S_Dashbord);
            this.Controls.Add(this.panel1);
            this.Name = "Frm_Survair_Dashbord";
            this.Text = "Frm_Survair_Dashbord";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Frm_Survair_Dashbord_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DG_S_Dashbord)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label Lbl_Dashbord;
        private System.Windows.Forms.DataGridView DG_S_Dashbord;
        private System.Windows.Forms.Button Btn_Exit;
    }
}