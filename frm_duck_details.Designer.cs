namespace project
{
    partial class frm_duck_details
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
            this.pnl_cattel_properties = new System.Windows.Forms.Panel();
            this.btn_next = new System.Windows.Forms.Button();
            this.btn_Reentry = new System.Windows.Forms.Button();
            this.btn_save = new System.Windows.Forms.Button();
            this.tblpnl_cattle_details = new System.Windows.Forms.TableLayoutPanel();
            this.tb_Duckling = new System.Windows.Forms.TextBox();
            this.tb_Male_Duck = new System.Windows.Forms.TextBox();
            this.tb_Female_Duck = new System.Windows.Forms.TextBox();
            this.lbl_duckling = new System.Windows.Forms.Label();
            this.lbl_female_duck = new System.Windows.Forms.Label();
            this.lbl_male_duck = new System.Windows.Forms.Label();
            this.tb_subtotal = new System.Windows.Forms.TextBox();
            this.lbl_SubTotal = new System.Windows.Forms.Label();
            this.lbl_Error_Duckling = new System.Windows.Forms.Label();
            this.lbl_Error_Male_Duck = new System.Windows.Forms.Label();
            this.lbl_Error_Female_Duck = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.cmb_Breed_Name = new System.Windows.Forms.ComboBox();
            this.lbl_bread_name = new System.Windows.Forms.Label();
            this.lbl_duck_details = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnl_cattel_properties.SuspendLayout();
            this.tblpnl_cattle_details.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_cattel_properties
            // 
            this.pnl_cattel_properties.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.pnl_cattel_properties.Controls.Add(this.btn_next);
            this.pnl_cattel_properties.Controls.Add(this.btn_Reentry);
            this.pnl_cattel_properties.Controls.Add(this.btn_save);
            this.pnl_cattel_properties.Controls.Add(this.tblpnl_cattle_details);
            this.pnl_cattel_properties.Controls.Add(this.tableLayoutPanel1);
            this.pnl_cattel_properties.Location = new System.Drawing.Point(12, 117);
            this.pnl_cattel_properties.Margin = new System.Windows.Forms.Padding(4);
            this.pnl_cattel_properties.Name = "pnl_cattel_properties";
            this.pnl_cattel_properties.Size = new System.Drawing.Size(864, 486);
            this.pnl_cattel_properties.TabIndex = 8;
            // 
            // btn_next
            // 
            this.btn_next.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btn_next.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_next.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_next.Location = new System.Drawing.Point(652, 427);
            this.btn_next.Margin = new System.Windows.Forms.Padding(4);
            this.btn_next.Name = "btn_next";
            this.btn_next.Size = new System.Drawing.Size(135, 42);
            this.btn_next.TabIndex = 17;
            this.btn_next.Text = "Next";
            this.btn_next.UseVisualStyleBackColor = false;
            this.btn_next.Click += new System.EventHandler(this.btn_next_Click);
            // 
            // btn_Reentry
            // 
            this.btn_Reentry.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btn_Reentry.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_Reentry.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Reentry.Location = new System.Drawing.Point(120, 427);
            this.btn_Reentry.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Reentry.Name = "btn_Reentry";
            this.btn_Reentry.Size = new System.Drawing.Size(135, 42);
            this.btn_Reentry.TabIndex = 16;
            this.btn_Reentry.Text = "ReEntry";
            this.btn_Reentry.UseVisualStyleBackColor = false;
            // 
            // btn_save
            // 
            this.btn_save.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btn_save.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_save.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_save.Location = new System.Drawing.Point(377, 427);
            this.btn_save.Margin = new System.Windows.Forms.Padding(4);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(135, 42);
            this.btn_save.TabIndex = 15;
            this.btn_save.Text = "Save";
            this.btn_save.UseVisualStyleBackColor = false;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // tblpnl_cattle_details
            // 
            this.tblpnl_cattle_details.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tblpnl_cattle_details.ColumnCount = 5;
            this.tblpnl_cattle_details.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tblpnl_cattle_details.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tblpnl_cattle_details.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tblpnl_cattle_details.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tblpnl_cattle_details.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tblpnl_cattle_details.Controls.Add(this.tb_Duckling, 1, 1);
            this.tblpnl_cattle_details.Controls.Add(this.tb_Male_Duck, 2, 1);
            this.tblpnl_cattle_details.Controls.Add(this.tb_Female_Duck, 3, 1);
            this.tblpnl_cattle_details.Controls.Add(this.lbl_duckling, 1, 0);
            this.tblpnl_cattle_details.Controls.Add(this.lbl_female_duck, 3, 0);
            this.tblpnl_cattle_details.Controls.Add(this.lbl_male_duck, 2, 0);
            this.tblpnl_cattle_details.Controls.Add(this.tb_subtotal, 2, 4);
            this.tblpnl_cattle_details.Controls.Add(this.lbl_SubTotal, 2, 3);
            this.tblpnl_cattle_details.Controls.Add(this.lbl_Error_Duckling, 1, 2);
            this.tblpnl_cattle_details.Controls.Add(this.lbl_Error_Male_Duck, 2, 2);
            this.tblpnl_cattle_details.Controls.Add(this.lbl_Error_Female_Duck, 3, 2);
            this.tblpnl_cattle_details.Enabled = false;
            this.tblpnl_cattle_details.Location = new System.Drawing.Point(4, 145);
            this.tblpnl_cattle_details.Margin = new System.Windows.Forms.Padding(4);
            this.tblpnl_cattle_details.Name = "tblpnl_cattle_details";
            this.tblpnl_cattle_details.RowCount = 5;
            this.tblpnl_cattle_details.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tblpnl_cattle_details.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tblpnl_cattle_details.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tblpnl_cattle_details.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tblpnl_cattle_details.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tblpnl_cattle_details.Size = new System.Drawing.Size(856, 274);
            this.tblpnl_cattle_details.TabIndex = 14;
            // 
            // tb_Duckling
            // 
            this.tb_Duckling.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_Duckling.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.tb_Duckling.Location = new System.Drawing.Point(175, 66);
            this.tb_Duckling.Margin = new System.Windows.Forms.Padding(4);
            this.tb_Duckling.Name = "tb_Duckling";
            this.tb_Duckling.Size = new System.Drawing.Size(163, 30);
            this.tb_Duckling.TabIndex = 27;
            this.tb_Duckling.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tb_Duckling.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_Duckling_KeyPress);
            // 
            // tb_Male_Duck
            // 
            this.tb_Male_Duck.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_Male_Duck.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.tb_Male_Duck.Location = new System.Drawing.Point(346, 66);
            this.tb_Male_Duck.Margin = new System.Windows.Forms.Padding(4);
            this.tb_Male_Duck.Name = "tb_Male_Duck";
            this.tb_Male_Duck.Size = new System.Drawing.Size(163, 30);
            this.tb_Male_Duck.TabIndex = 28;
            this.tb_Male_Duck.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tb_Male_Duck.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_Male_Duck_KeyPress);
            // 
            // tb_Female_Duck
            // 
            this.tb_Female_Duck.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_Female_Duck.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Female_Duck.Location = new System.Drawing.Point(517, 66);
            this.tb_Female_Duck.Margin = new System.Windows.Forms.Padding(4);
            this.tb_Female_Duck.Name = "tb_Female_Duck";
            this.tb_Female_Duck.Size = new System.Drawing.Size(163, 30);
            this.tb_Female_Duck.TabIndex = 29;
            this.tb_Female_Duck.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tb_Female_Duck.TextChanged += new System.EventHandler(this.tb_Female_Duck_TextChanged);
            this.tb_Female_Duck.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_Female_Duck_KeyPress);
            // 
            // lbl_duckling
            // 
            this.lbl_duckling.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_duckling.AutoSize = true;
            this.lbl_duckling.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_duckling.Location = new System.Drawing.Point(204, 14);
            this.lbl_duckling.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_duckling.Name = "lbl_duckling";
            this.lbl_duckling.Size = new System.Drawing.Size(104, 25);
            this.lbl_duckling.TabIndex = 9;
            this.lbl_duckling.Text = "Duckling`s";
            this.lbl_duckling.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_female_duck
            // 
            this.lbl_female_duck.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_female_duck.AutoSize = true;
            this.lbl_female_duck.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_female_duck.Location = new System.Drawing.Point(535, 14);
            this.lbl_female_duck.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_female_duck.Name = "lbl_female_duck";
            this.lbl_female_duck.Size = new System.Drawing.Size(127, 25);
            this.lbl_female_duck.TabIndex = 15;
            this.lbl_female_duck.Text = "Female Duck";
            this.lbl_female_duck.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_male_duck
            // 
            this.lbl_male_duck.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_male_duck.AutoSize = true;
            this.lbl_male_duck.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_male_duck.Location = new System.Drawing.Point(375, 14);
            this.lbl_male_duck.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_male_duck.Name = "lbl_male_duck";
            this.lbl_male_duck.Size = new System.Drawing.Size(105, 25);
            this.lbl_male_duck.TabIndex = 11;
            this.lbl_male_duck.Text = "Male Duck";
            this.lbl_male_duck.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tb_subtotal
            // 
            this.tb_subtotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_subtotal.Enabled = false;
            this.tb_subtotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.tb_subtotal.Location = new System.Drawing.Point(346, 230);
            this.tb_subtotal.Margin = new System.Windows.Forms.Padding(4);
            this.tb_subtotal.Name = "tb_subtotal";
            this.tb_subtotal.Size = new System.Drawing.Size(163, 30);
            this.tb_subtotal.TabIndex = 32;
            this.tb_subtotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lbl_SubTotal
            // 
            this.lbl_SubTotal.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_SubTotal.AutoSize = true;
            this.lbl_SubTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_SubTotal.Location = new System.Drawing.Point(385, 176);
            this.lbl_SubTotal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_SubTotal.Name = "lbl_SubTotal";
            this.lbl_SubTotal.Size = new System.Drawing.Size(84, 25);
            this.lbl_SubTotal.TabIndex = 31;
            this.lbl_SubTotal.Text = "Subtotal";
            this.lbl_SubTotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_Error_Duckling
            // 
            this.lbl_Error_Duckling.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_Error_Duckling.AutoSize = true;
            this.lbl_Error_Duckling.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Error_Duckling.ForeColor = System.Drawing.Color.Chocolate;
            this.lbl_Error_Duckling.Location = new System.Drawing.Point(256, 126);
            this.lbl_Error_Duckling.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Error_Duckling.Name = "lbl_Error_Duckling";
            this.lbl_Error_Duckling.Size = new System.Drawing.Size(0, 18);
            this.lbl_Error_Duckling.TabIndex = 33;
            this.lbl_Error_Duckling.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_Error_Male_Duck
            // 
            this.lbl_Error_Male_Duck.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_Error_Male_Duck.AutoSize = true;
            this.lbl_Error_Male_Duck.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Error_Male_Duck.ForeColor = System.Drawing.Color.Chocolate;
            this.lbl_Error_Male_Duck.Location = new System.Drawing.Point(427, 126);
            this.lbl_Error_Male_Duck.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Error_Male_Duck.Name = "lbl_Error_Male_Duck";
            this.lbl_Error_Male_Duck.Size = new System.Drawing.Size(0, 18);
            this.lbl_Error_Male_Duck.TabIndex = 34;
            this.lbl_Error_Male_Duck.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_Error_Female_Duck
            // 
            this.lbl_Error_Female_Duck.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_Error_Female_Duck.AutoSize = true;
            this.lbl_Error_Female_Duck.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Error_Female_Duck.ForeColor = System.Drawing.Color.Chocolate;
            this.lbl_Error_Female_Duck.Location = new System.Drawing.Point(598, 126);
            this.lbl_Error_Female_Duck.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Error_Female_Duck.Name = "lbl_Error_Female_Duck";
            this.lbl_Error_Female_Duck.Size = new System.Drawing.Size(0, 18);
            this.lbl_Error_Female_Duck.TabIndex = 35;
            this.lbl_Error_Female_Duck.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.2866F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 71.43299F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28041F));
            this.tableLayoutPanel1.Controls.Add(this.cmb_Breed_Name, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.lbl_bread_name, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(4, 15);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(856, 123);
            this.tableLayoutPanel1.TabIndex = 13;
            // 
            // cmb_Breed_Name
            // 
            this.cmb_Breed_Name.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmb_Breed_Name.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_Breed_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_Breed_Name.FormattingEnabled = true;
            this.cmb_Breed_Name.Location = new System.Drawing.Point(307, 78);
            this.cmb_Breed_Name.Margin = new System.Windows.Forms.Padding(4);
            this.cmb_Breed_Name.Name = "cmb_Breed_Name";
            this.cmb_Breed_Name.Size = new System.Drawing.Size(241, 28);
            this.cmb_Breed_Name.TabIndex = 11;
            this.cmb_Breed_Name.SelectedIndexChanged += new System.EventHandler(this.cmb_Breed_Name_SelectedIndexChanged);
            // 
            // lbl_bread_name
            // 
            this.lbl_bread_name.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_bread_name.AutoSize = true;
            this.lbl_bread_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_bread_name.Location = new System.Drawing.Point(345, 15);
            this.lbl_bread_name.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_bread_name.Name = "lbl_bread_name";
            this.lbl_bread_name.Size = new System.Drawing.Size(165, 31);
            this.lbl_bread_name.TabIndex = 8;
            this.lbl_bread_name.Text = "Breed Name";
            // 
            // lbl_duck_details
            // 
            this.lbl_duck_details.BackColor = System.Drawing.Color.Moccasin;
            this.lbl_duck_details.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbl_duck_details.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_duck_details.Location = new System.Drawing.Point(0, 0);
            this.lbl_duck_details.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_duck_details.Name = "lbl_duck_details";
            this.lbl_duck_details.Size = new System.Drawing.Size(892, 95);
            this.lbl_duck_details.TabIndex = 0;
            this.lbl_duck_details.Text = "Duck Details";
            this.lbl_duck_details.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Bisque;
            this.panel1.Controls.Add(this.lbl_duck_details);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.ForeColor = System.Drawing.Color.Olive;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(892, 95);
            this.panel1.TabIndex = 9;
            // 
            // frm_duck_details
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(892, 603);
            this.Controls.Add(this.pnl_cattel_properties);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frm_duck_details";
            this.Text = "frm_duck_details";
            this.Load += new System.EventHandler(this.frm_duck_details_Load);
            this.pnl_cattel_properties.ResumeLayout(false);
            this.tblpnl_cattle_details.ResumeLayout(false);
            this.tblpnl_cattle_details.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_cattel_properties;
        private System.Windows.Forms.Button btn_next;
        private System.Windows.Forms.Button btn_Reentry;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.TableLayoutPanel tblpnl_cattle_details;
        private System.Windows.Forms.TextBox tb_Duckling;
        private System.Windows.Forms.TextBox tb_Male_Duck;
        private System.Windows.Forms.TextBox tb_Female_Duck;
        private System.Windows.Forms.Label lbl_duckling;
        private System.Windows.Forms.TextBox tb_subtotal;
        private System.Windows.Forms.Label lbl_SubTotal;
        private System.Windows.Forms.Label lbl_female_duck;
        private System.Windows.Forms.Label lbl_male_duck;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.ComboBox cmb_Breed_Name;
        private System.Windows.Forms.Label lbl_bread_name;
        private System.Windows.Forms.Label lbl_duck_details;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbl_Error_Duckling;
        private System.Windows.Forms.Label lbl_Error_Male_Duck;
        private System.Windows.Forms.Label lbl_Error_Female_Duck;
    }
}