namespace project
{
    partial class Frm_Personal_Details_Report
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
            this.lbl_Bufaalo_details = new System.Windows.Forms.Label();
            this.btn_Search = new System.Windows.Forms.Button();
            this.tb_Sr_No = new System.Windows.Forms.TextBox();
            this.crystalReportViewer1 = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // lbl_Bufaalo_details
            // 
            this.lbl_Bufaalo_details.BackColor = System.Drawing.Color.Moccasin;
            this.lbl_Bufaalo_details.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbl_Bufaalo_details.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Bufaalo_details.Location = new System.Drawing.Point(0, 0);
            this.lbl_Bufaalo_details.Name = "lbl_Bufaalo_details";
            this.lbl_Bufaalo_details.Size = new System.Drawing.Size(1003, 59);
            this.lbl_Bufaalo_details.TabIndex = 2;
            this.lbl_Bufaalo_details.Text = "Personal Report";
            this.lbl_Bufaalo_details.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btn_Search
            // 
            this.btn_Search.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btn_Search.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_Search.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Search.Location = new System.Drawing.Point(862, 14);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(122, 34);
            this.btn_Search.TabIndex = 19;
            this.btn_Search.Text = "Search";
            this.btn_Search.UseVisualStyleBackColor = false;
            this.btn_Search.Click += new System.EventHandler(this.btn_Search_Click);
            // 
            // tb_Sr_No
            // 
            this.tb_Sr_No.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tb_Sr_No.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Sr_No.Location = new System.Drawing.Point(635, 20);
            this.tb_Sr_No.Name = "tb_Sr_No";
            this.tb_Sr_No.Size = new System.Drawing.Size(187, 24);
            this.tb_Sr_No.TabIndex = 18;
            // 
            // crystalReportViewer1
            // 
            this.crystalReportViewer1.ActiveViewIndex = -1;
            this.crystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crystalReportViewer1.Location = new System.Drawing.Point(0, 59);
            this.crystalReportViewer1.Name = "crystalReportViewer1";
            this.crystalReportViewer1.Size = new System.Drawing.Size(1003, 404);
            this.crystalReportViewer1.TabIndex = 20;
            this.crystalReportViewer1.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // Frm_Personal_Details_Report
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1003, 463);
            this.Controls.Add(this.crystalReportViewer1);
            this.Controls.Add(this.btn_Search);
            this.Controls.Add(this.tb_Sr_No);
            this.Controls.Add(this.lbl_Bufaalo_details);
            this.Name = "Frm_Personal_Details_Report";
            this.Text = "Personal Details Report";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Bufaalo_details;
        private System.Windows.Forms.Button btn_Search;
        private System.Windows.Forms.TextBox tb_Sr_No;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer1;
    }
}