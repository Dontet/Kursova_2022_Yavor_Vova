namespace BakeryInventorySystem
{
    partial class frmInventoryReports
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.Label5 = new System.Windows.Forms.Label();
            this.Label1 = new System.Windows.Forms.Label();
            this.cboCateg = new System.Windows.Forms.ComboBox();
            this.Panel3 = new System.Windows.Forms.Panel();
            this.dtglist = new System.Windows.Forms.DataGridView();
            this.LBLLIST = new System.Windows.Forms.Label();
            this.dtpFrom = new System.Windows.Forms.DateTimePicker();
            this.dtpTo = new System.Windows.Forms.DateTimePicker();
            this.btnSearch = new System.Windows.Forms.Button();
            this.rdoWeekly = new System.Windows.Forms.RadioButton();
            this.rdoMonthly = new System.Windows.Forms.RadioButton();
            this.BTNSEARCHGRID = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.Label4 = new System.Windows.Forms.Label();
            this.rdoToday = new System.Windows.Forms.RadioButton();
            this.Panel1 = new System.Windows.Forms.Panel();
            this.GroupBox2 = new System.Windows.Forms.GroupBox();
            this.Panel2 = new System.Windows.Forms.Panel();
            this.GroupBox1 = new System.Windows.Forms.GroupBox();
            this.rdoProduct = new System.Windows.Forms.RadioButton();
            this.rdoStockIn = new System.Windows.Forms.RadioButton();
            this.rdoStockOut = new System.Windows.Forms.RadioButton();
            this.CloseLogin = new System.Windows.Forms.Label();
            this.Panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtglist)).BeginInit();
            this.Panel1.SuspendLayout();
            this.GroupBox2.SuspendLayout();
            this.Panel2.SuspendLayout();
            this.GroupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Label5
            // 
            this.Label5.AutoSize = true;
            this.Label5.BackColor = System.Drawing.Color.White;
            this.Label5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Label5.Font = new System.Drawing.Font("Harrington", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label5.ForeColor = System.Drawing.Color.Black;
            this.Label5.Location = new System.Drawing.Point(518, 64);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(81, 24);
            this.Label5.TabIndex = 43;
            this.Label5.Text = "Product";
            this.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Label1
            // 
            this.Label1.BackColor = System.Drawing.Color.LightGray;
            this.Label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.Label1.Font = new System.Drawing.Font("Harrington", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Label1.Location = new System.Drawing.Point(193, 0);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(808, 52);
            this.Label1.TabIndex = 45;
            this.Label1.Text = "View All Actions";
            this.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cboCateg
            // 
            this.cboCateg.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cboCateg.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboCateg.Font = new System.Drawing.Font("Harrington", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboCateg.Items.AddRange(new object[] {
            "Bread",
            "Cake",
            "Pastry"});
            this.cboCateg.Location = new System.Drawing.Point(3, -1);
            this.cboCateg.Name = "cboCateg";
            this.cboCateg.Size = new System.Drawing.Size(206, 30);
            this.cboCateg.TabIndex = 6;
            this.cboCateg.Text = "Bread";
            // 
            // Panel3
            // 
            this.Panel3.Controls.Add(this.dtglist);
            this.Panel3.Controls.Add(this.LBLLIST);
            this.Panel3.Controls.Add(this.dtpFrom);
            this.Panel3.Controls.Add(this.dtpTo);
            this.Panel3.Controls.Add(this.btnSearch);
            this.Panel3.Location = new System.Drawing.Point(199, 124);
            this.Panel3.Name = "Panel3";
            this.Panel3.Size = new System.Drawing.Size(793, 325);
            this.Panel3.TabIndex = 40;
            // 
            // dtglist
            // 
            this.dtglist.AllowUserToAddRows = false;
            this.dtglist.AllowUserToDeleteRows = false;
            this.dtglist.AllowUserToResizeColumns = false;
            this.dtglist.AllowUserToResizeRows = false;
            this.dtglist.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dtglist.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dtglist.BackgroundColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Harrington", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtglist.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dtglist.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Himalaya", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtglist.DefaultCellStyle = dataGridViewCellStyle4;
            this.dtglist.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtglist.Location = new System.Drawing.Point(0, 28);
            this.dtglist.Name = "dtglist";
            this.dtglist.ReadOnly = true;
            this.dtglist.RowHeadersVisible = false;
            this.dtglist.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtglist.Size = new System.Drawing.Size(793, 297);
            this.dtglist.TabIndex = 1;
            // 
            // LBLLIST
            // 
            this.LBLLIST.BackColor = System.Drawing.Color.LightGray;
            this.LBLLIST.Dock = System.Windows.Forms.DockStyle.Top;
            this.LBLLIST.Font = new System.Drawing.Font("Harrington", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBLLIST.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.LBLLIST.Location = new System.Drawing.Point(0, 0);
            this.LBLLIST.Name = "LBLLIST";
            this.LBLLIST.Size = new System.Drawing.Size(793, 28);
            this.LBLLIST.TabIndex = 2;
            this.LBLLIST.Text = "List";
            this.LBLLIST.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dtpFrom
            // 
            this.dtpFrom.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFrom.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFrom.Location = new System.Drawing.Point(23, 302);
            this.dtpFrom.Name = "dtpFrom";
            this.dtpFrom.Size = new System.Drawing.Size(10, 20);
            this.dtpFrom.TabIndex = 0;
            // 
            // dtpTo
            // 
            this.dtpTo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpTo.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpTo.Location = new System.Drawing.Point(39, 302);
            this.dtpTo.Name = "dtpTo";
            this.dtpTo.Size = new System.Drawing.Size(10, 20);
            this.dtpTo.TabIndex = 0;
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Location = new System.Drawing.Point(67, 277);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(10, 13);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // rdoWeekly
            // 
            this.rdoWeekly.AutoSize = true;
            this.rdoWeekly.Font = new System.Drawing.Font("Harrington", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoWeekly.Location = new System.Drawing.Point(6, 62);
            this.rdoWeekly.Name = "rdoWeekly";
            this.rdoWeekly.Size = new System.Drawing.Size(84, 23);
            this.rdoWeekly.TabIndex = 2;
            this.rdoWeekly.TabStop = true;
            this.rdoWeekly.Text = "Weekly";
            this.rdoWeekly.UseVisualStyleBackColor = true;
            this.rdoWeekly.CheckedChanged += new System.EventHandler(this.rdoWeekly_CheckedChanged);
            // 
            // rdoMonthly
            // 
            this.rdoMonthly.AutoSize = true;
            this.rdoMonthly.Font = new System.Drawing.Font("Harrington", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoMonthly.Location = new System.Drawing.Point(90, 62);
            this.rdoMonthly.Name = "rdoMonthly";
            this.rdoMonthly.Size = new System.Drawing.Size(91, 23);
            this.rdoMonthly.TabIndex = 2;
            this.rdoMonthly.TabStop = true;
            this.rdoMonthly.Text = "Monthly";
            this.rdoMonthly.UseVisualStyleBackColor = true;
            this.rdoMonthly.CheckedChanged += new System.EventHandler(this.rdoMonthly_CheckedChanged);
            // 
            // BTNSEARCHGRID
            // 
            this.BTNSEARCHGRID.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTNSEARCHGRID.Font = new System.Drawing.Font("Harrington", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNSEARCHGRID.Location = new System.Drawing.Point(810, 92);
            this.BTNSEARCHGRID.Name = "BTNSEARCHGRID";
            this.BTNSEARCHGRID.Size = new System.Drawing.Size(102, 30);
            this.BTNSEARCHGRID.TabIndex = 41;
            this.BTNSEARCHGRID.Text = "Search";
            this.BTNSEARCHGRID.UseVisualStyleBackColor = true;
            this.BTNSEARCHGRID.Click += new System.EventHandler(this.BTNSEARCHGRID_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSearch.Font = new System.Drawing.Font("Harrington", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Location = new System.Drawing.Point(509, 92);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(295, 30);
            this.txtSearch.TabIndex = 39;
            // 
            // Label4
            // 
            this.Label4.BackColor = System.Drawing.Color.White;
            this.Label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Label4.Font = new System.Drawing.Font("Harrington", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label4.Location = new System.Drawing.Point(281, 64);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(54, 26);
            this.Label4.TabIndex = 46;
            this.Label4.Text = "Type";
            // 
            // rdoToday
            // 
            this.rdoToday.AutoSize = true;
            this.rdoToday.Font = new System.Drawing.Font("Harrington", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoToday.Location = new System.Drawing.Point(46, 39);
            this.rdoToday.Name = "rdoToday";
            this.rdoToday.Size = new System.Drawing.Size(76, 23);
            this.rdoToday.TabIndex = 2;
            this.rdoToday.TabStop = true;
            this.rdoToday.Text = "Today";
            this.rdoToday.UseVisualStyleBackColor = true;
            this.rdoToday.CheckedChanged += new System.EventHandler(this.rdoToday_CheckedChanged);
            // 
            // Panel1
            // 
            this.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Panel1.Controls.Add(this.cboCateg);
            this.Panel1.Location = new System.Drawing.Point(281, 93);
            this.Panel1.Name = "Panel1";
            this.Panel1.Size = new System.Drawing.Size(222, 28);
            this.Panel1.TabIndex = 42;
            // 
            // GroupBox2
            // 
            this.GroupBox2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.GroupBox2.Controls.Add(this.rdoWeekly);
            this.GroupBox2.Controls.Add(this.rdoMonthly);
            this.GroupBox2.Controls.Add(this.rdoToday);
            this.GroupBox2.Font = new System.Drawing.Font("Harrington", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GroupBox2.Location = new System.Drawing.Point(3, 155);
            this.GroupBox2.Name = "GroupBox2";
            this.GroupBox2.Size = new System.Drawing.Size(184, 91);
            this.GroupBox2.TabIndex = 25;
            this.GroupBox2.TabStop = false;
            this.GroupBox2.Text = "Date Filter";
            // 
            // Panel2
            // 
            this.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Panel2.Controls.Add(this.GroupBox2);
            this.Panel2.Controls.Add(this.GroupBox1);
            this.Panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.Panel2.Location = new System.Drawing.Point(0, 0);
            this.Panel2.Name = "Panel2";
            this.Panel2.Size = new System.Drawing.Size(193, 464);
            this.Panel2.TabIndex = 44;
            // 
            // GroupBox1
            // 
            this.GroupBox1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.GroupBox1.Controls.Add(this.rdoProduct);
            this.GroupBox1.Controls.Add(this.rdoStockIn);
            this.GroupBox1.Controls.Add(this.rdoStockOut);
            this.GroupBox1.Font = new System.Drawing.Font("Harrington", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GroupBox1.Location = new System.Drawing.Point(2, 3);
            this.GroupBox1.Name = "GroupBox1";
            this.GroupBox1.Size = new System.Drawing.Size(186, 146);
            this.GroupBox1.TabIndex = 3;
            this.GroupBox1.TabStop = false;
            this.GroupBox1.Text = "Inventory of Products";
            // 
            // rdoProduct
            // 
            this.rdoProduct.AutoSize = true;
            this.rdoProduct.Checked = true;
            this.rdoProduct.Font = new System.Drawing.Font("Harrington", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoProduct.Location = new System.Drawing.Point(27, 45);
            this.rdoProduct.Name = "rdoProduct";
            this.rdoProduct.Size = new System.Drawing.Size(48, 21);
            this.rdoProduct.TabIndex = 14;
            this.rdoProduct.TabStop = true;
            this.rdoProduct.Text = "All";
            this.rdoProduct.UseVisualStyleBackColor = true;
            this.rdoProduct.CheckedChanged += new System.EventHandler(this.rdoProduct_CheckedChanged);
            // 
            // rdoStockIn
            // 
            this.rdoStockIn.AutoSize = true;
            this.rdoStockIn.Font = new System.Drawing.Font("Harrington", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoStockIn.Location = new System.Drawing.Point(27, 73);
            this.rdoStockIn.Name = "rdoStockIn";
            this.rdoStockIn.Size = new System.Drawing.Size(87, 21);
            this.rdoStockIn.TabIndex = 0;
            this.rdoStockIn.TabStop = true;
            this.rdoStockIn.Text = "Stock-In";
            this.rdoStockIn.UseVisualStyleBackColor = true;
            this.rdoStockIn.CheckedChanged += new System.EventHandler(this.rdoStockIn_CheckedChanged);
            // 
            // rdoStockOut
            // 
            this.rdoStockOut.AutoSize = true;
            this.rdoStockOut.Font = new System.Drawing.Font("Harrington", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoStockOut.Location = new System.Drawing.Point(27, 96);
            this.rdoStockOut.Name = "rdoStockOut";
            this.rdoStockOut.Size = new System.Drawing.Size(60, 21);
            this.rdoStockOut.TabIndex = 0;
            this.rdoStockOut.TabStop = true;
            this.rdoStockOut.Text = "Sold";
            this.rdoStockOut.UseVisualStyleBackColor = true;
            this.rdoStockOut.CheckedChanged += new System.EventHandler(this.rdoStockOut_CheckedChanged);
            // 
            // CloseLogin
            // 
            this.CloseLogin.AutoSize = true;
            this.CloseLogin.BackColor = System.Drawing.Color.LightGray;
            this.CloseLogin.Font = new System.Drawing.Font("Harrington", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CloseLogin.Location = new System.Drawing.Point(958, 9);
            this.CloseLogin.Name = "CloseLogin";
            this.CloseLogin.Size = new System.Drawing.Size(28, 29);
            this.CloseLogin.TabIndex = 47;
            this.CloseLogin.Text = "X";
            this.CloseLogin.Click += new System.EventHandler(this.CloseLogin_Click);
            // 
            // frmInventoryReports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::BakeryInventorySystem.Properties.Resources.backA;
            this.ClientSize = new System.Drawing.Size(1001, 464);
            this.Controls.Add(this.CloseLogin);
            this.Controls.Add(this.Label5);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.Panel3);
            this.Controls.Add(this.BTNSEARCHGRID);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.Label4);
            this.Controls.Add(this.Panel1);
            this.Controls.Add(this.Panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmInventoryReports";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reports";
            this.Load += new System.EventHandler(this.frmInventoryReports_Load);
            this.Panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtglist)).EndInit();
            this.Panel1.ResumeLayout(false);
            this.GroupBox2.ResumeLayout(false);
            this.GroupBox2.PerformLayout();
            this.Panel2.ResumeLayout(false);
            this.GroupBox1.ResumeLayout(false);
            this.GroupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Label Label5;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.ComboBox cboCateg;
        internal System.Windows.Forms.Panel Panel3;
        internal System.Windows.Forms.DataGridView dtglist;
        internal System.Windows.Forms.Label LBLLIST;
        internal System.Windows.Forms.Button btnSearch;
        internal System.Windows.Forms.RadioButton rdoWeekly;
        internal System.Windows.Forms.RadioButton rdoMonthly;
        internal System.Windows.Forms.DateTimePicker dtpFrom;
        internal System.Windows.Forms.Button BTNSEARCHGRID;
        internal System.Windows.Forms.TextBox txtSearch;
        internal System.Windows.Forms.Label Label4;
        internal System.Windows.Forms.RadioButton rdoToday;
        internal System.Windows.Forms.DateTimePicker dtpTo;
        internal System.Windows.Forms.Panel Panel1;
        internal System.Windows.Forms.GroupBox GroupBox2;
        internal System.Windows.Forms.Panel Panel2;
        internal System.Windows.Forms.GroupBox GroupBox1;
        internal System.Windows.Forms.RadioButton rdoProduct;
        internal System.Windows.Forms.RadioButton rdoStockIn;
        internal System.Windows.Forms.RadioButton rdoStockOut;
        private System.Windows.Forms.Label CloseLogin;
    }
}