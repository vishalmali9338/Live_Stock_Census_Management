namespace project
{
    partial class Frm_Taluka_Dashbord
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lbl_Taluka = new System.Windows.Forms.Label();
            this.lbl_district = new System.Windows.Forms.Label();
            this.cmb_District = new System.Windows.Forms.ComboBox();
            this.cmb_State = new System.Windows.Forms.ComboBox();
            this.lbl_State = new System.Windows.Forms.Label();
            this.cmb_Taluka = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Btn_Exit = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.panel1.Controls.Add(this.Lbl_Dashbord);
            this.panel1.ForeColor = System.Drawing.Color.DimGray;
            this.panel1.Location = new System.Drawing.Point(3, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1144, 107);
            this.panel1.TabIndex = 1;
            // 
            // Lbl_Dashbord
            // 
            this.Lbl_Dashbord.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.Lbl_Dashbord.AutoSize = true;
            this.Lbl_Dashbord.BackColor = System.Drawing.Color.MistyRose;
            this.Lbl_Dashbord.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Dashbord.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Lbl_Dashbord.Location = new System.Drawing.Point(444, 28);
            this.Lbl_Dashbord.Name = "Lbl_Dashbord";
            this.Lbl_Dashbord.Size = new System.Drawing.Size(234, 55);
            this.Lbl_Dashbord.TabIndex = 0;
            this.Lbl_Dashbord.Text = "Dashbord";
            this.Lbl_Dashbord.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 5;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5.357143F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 29.76191F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 29.76191F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 29.76191F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5.357143F));
            this.tableLayoutPanel1.Controls.Add(this.cmb_Taluka, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.lbl_Taluka, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.lbl_district, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.cmb_District, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.cmb_State, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.lbl_State, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 106);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1144, 78);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // lbl_Taluka
            // 
            this.lbl_Taluka.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_Taluka.AutoSize = true;
            this.lbl_Taluka.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Taluka.Location = new System.Drawing.Point(882, 9);
            this.lbl_Taluka.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Taluka.Name = "lbl_Taluka";
            this.lbl_Taluka.Size = new System.Drawing.Size(58, 21);
            this.lbl_Taluka.TabIndex = 14;
            this.lbl_Taluka.Text = "Taluka";
            this.lbl_Taluka.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_district
            // 
            this.lbl_district.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_district.AutoSize = true;
            this.lbl_district.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_district.Location = new System.Drawing.Point(542, 9);
            this.lbl_district.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_district.Name = "lbl_district";
            this.lbl_district.Size = new System.Drawing.Size(57, 21);
            this.lbl_district.TabIndex = 15;
            this.lbl_district.Text = "District";
            // 
            // cmb_District
            // 
            this.cmb_District.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmb_District.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_District.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_District.FormattingEnabled = true;
            this.cmb_District.Location = new System.Drawing.Point(441, 44);
            this.cmb_District.Name = "cmb_District";
            this.cmb_District.Size = new System.Drawing.Size(260, 29);
            this.cmb_District.TabIndex = 14;
            // 
            // cmb_State
            // 
            this.cmb_State.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmb_State.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_State.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_State.FormattingEnabled = true;
            this.cmb_State.Location = new System.Drawing.Point(101, 44);
            this.cmb_State.Name = "cmb_State";
            this.cmb_State.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cmb_State.Size = new System.Drawing.Size(260, 29);
            this.cmb_State.TabIndex = 2;
            this.cmb_State.Tag = "";
            // 
            // lbl_State
            // 
            this.lbl_State.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_State.AutoSize = true;
            this.lbl_State.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_State.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbl_State.Location = new System.Drawing.Point(208, 9);
            this.lbl_State.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_State.Name = "lbl_State";
            this.lbl_State.Size = new System.Drawing.Size(46, 21);
            this.lbl_State.TabIndex = 12;
            this.lbl_State.Text = "State";
            // 
            // cmb_Taluka
            // 
            this.cmb_Taluka.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmb_Taluka.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_Taluka.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_Taluka.FormattingEnabled = true;
            this.cmb_Taluka.Location = new System.Drawing.Point(781, 44);
            this.cmb_Taluka.Name = "cmb_Taluka";
            this.cmb_Taluka.Size = new System.Drawing.Size(260, 29);
            this.cmb_Taluka.TabIndex = 13;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(0, 185);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1144, 250);
            this.dataGridView1.TabIndex = 3;
            // 
            // Btn_Exit
            // 
            this.Btn_Exit.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.Btn_Exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Exit.Location = new System.Drawing.Point(507, 441);
            this.Btn_Exit.Name = "Btn_Exit";
            this.Btn_Exit.Size = new System.Drawing.Size(132, 49);
            this.Btn_Exit.TabIndex = 4;
            this.Btn_Exit.Text = "Exit";
            this.Btn_Exit.UseVisualStyleBackColor = true;
            // 
            // Frm_Taluka_Dashbord
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1145, 487);
            this.Controls.Add(this.Btn_Exit);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.panel1);
            this.Name = "Frm_Taluka_Dashbord";
            this.Text = "Frm_Taluka_Dashbord";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label Lbl_Dashbord;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.ComboBox cmb_State;
        private System.Windows.Forms.Label lbl_State;
        private System.Windows.Forms.Label lbl_district;
        private System.Windows.Forms.ComboBox cmb_District;
        private System.Windows.Forms.Label lbl_Taluka;
        private System.Windows.Forms.ComboBox cmb_Taluka;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button Btn_Exit;
    }
}