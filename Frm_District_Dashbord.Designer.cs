namespace project
{
    partial class Frm_District_Dashbord
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lbl_district = new System.Windows.Forms.Label();
            this.cmb_District = new System.Windows.Forms.ComboBox();
            this.Btn_Exit = new System.Windows.Forms.Button();
            this.cmb_State = new System.Windows.Forms.ComboBox();
            this.lbl_State = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.panel1.Controls.Add(this.Lbl_Dashbord);
            this.panel1.ForeColor = System.Drawing.Color.DimGray;
            this.panel1.Location = new System.Drawing.Point(2, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1144, 107);
            this.panel1.TabIndex = 5;
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
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(-1, 183);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1144, 250);
            this.dataGridView1.TabIndex = 7;
            // 
            // lbl_district
            // 
            this.lbl_district.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_district.AutoSize = true;
            this.lbl_district.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_district.Location = new System.Drawing.Point(784, 9);
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
            this.cmb_District.Location = new System.Drawing.Point(683, 44);
            this.cmb_District.Name = "cmb_District";
            this.cmb_District.Size = new System.Drawing.Size(260, 29);
            this.cmb_District.TabIndex = 14;
            // 
            // Btn_Exit
            // 
            this.Btn_Exit.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.Btn_Exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Exit.Location = new System.Drawing.Point(506, 439);
            this.Btn_Exit.Name = "Btn_Exit";
            this.Btn_Exit.Size = new System.Drawing.Size(132, 49);
            this.Btn_Exit.TabIndex = 8;
            this.Btn_Exit.Text = "Exit";
            this.Btn_Exit.UseVisualStyleBackColor = true;
            // 
            // cmb_State
            // 
            this.cmb_State.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmb_State.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_State.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_State.FormattingEnabled = true;
            this.cmb_State.Location = new System.Drawing.Point(199, 44);
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
            this.lbl_State.Location = new System.Drawing.Point(306, 9);
            this.lbl_State.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_State.Name = "lbl_State";
            this.lbl_State.Size = new System.Drawing.Size(46, 21);
            this.lbl_State.TabIndex = 12;
            this.lbl_State.Text = "State";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 7.626807F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 42.37115F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 42.37115F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 7.630875F));
            this.tableLayoutPanel1.Controls.Add(this.lbl_district, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.cmb_District, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.cmb_State, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.lbl_State, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(2, 104);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1144, 78);
            this.tableLayoutPanel1.TabIndex = 6;
            // 
            // Frm_District_Dashbord
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1145, 487);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.Btn_Exit);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Frm_District_Dashbord";
            this.Text = "Frm_District_Dashbord";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label Lbl_Dashbord;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lbl_district;
        private System.Windows.Forms.ComboBox cmb_District;
        private System.Windows.Forms.Button Btn_Exit;
        private System.Windows.Forms.ComboBox cmb_State;
        private System.Windows.Forms.Label lbl_State;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    }
}