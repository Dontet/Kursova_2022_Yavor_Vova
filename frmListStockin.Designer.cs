namespace BakeryInventorySystem
{
    partial class frmListStockin
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnNew = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.Label17 = new System.Windows.Forms.Label();
            this.Label16 = new System.Windows.Forms.Label();
            this.DTPFROM = new System.Windows.Forms.DateTimePicker();
            this.DTPTO = new System.Windows.Forms.DateTimePicker();
            this.Label10 = new System.Windows.Forms.Label();
            this.Button1 = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.TXTSEARCH = new System.Windows.Forms.TextBox();
            this.DTGLIST = new System.Windows.Forms.DataGridView();
            this.CloseEdtiPr = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DTGLIST)).BeginInit();
            this.SuspendLayout();
            // 
            // btnNew
            // 
            this.btnNew.Font = new System.Drawing.Font("Harrington", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNew.Location = new System.Drawing.Point(583, 465);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(75, 29);
            this.btnNew.TabIndex = 62;
            this.btnNew.Text = "New";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Font = new System.Drawing.Font("Harrington", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefresh.Location = new System.Drawing.Point(493, 465);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(84, 29);
            this.btnRefresh.TabIndex = 60;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // Label17
            // 
            this.Label17.AutoSize = true;
            this.Label17.Location = new System.Drawing.Point(638, 78);
            this.Label17.Name = "Label17";
            this.Label17.Size = new System.Drawing.Size(20, 13);
            this.Label17.TabIndex = 59;
            this.Label17.Text = "To";
            // 
            // Label16
            // 
            this.Label16.AutoSize = true;
            this.Label16.Location = new System.Drawing.Point(448, 78);
            this.Label16.Name = "Label16";
            this.Label16.Size = new System.Drawing.Size(30, 13);
            this.Label16.TabIndex = 58;
            this.Label16.Text = "From";
            // 
            // DTPFROM
            // 
            this.DTPFROM.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DTPFROM.Location = new System.Drawing.Point(494, 73);
            this.DTPFROM.Name = "DTPFROM";
            this.DTPFROM.Size = new System.Drawing.Size(139, 20);
            this.DTPFROM.TabIndex = 56;
            // 
            // DTPTO
            // 
            this.DTPTO.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DTPTO.Location = new System.Drawing.Point(667, 73);
            this.DTPTO.Name = "DTPTO";
            this.DTPTO.Size = new System.Drawing.Size(132, 20);
            this.DTPTO.TabIndex = 57;
            // 
            // Label10
            // 
            this.Label10.AutoSize = true;
            this.Label10.BackColor = System.Drawing.Color.White;
            this.Label10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Label10.Font = new System.Drawing.Font("Harrington", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label10.Location = new System.Drawing.Point(140, 10);
            this.Label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Label10.Name = "Label10";
            this.Label10.Size = new System.Drawing.Size(86, 24);
            this.Label10.TabIndex = 55;
            this.Label10.Text = "Search :";
            // 
            // Button1
            // 
            this.Button1.Font = new System.Drawing.Font("Harrington", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button1.Location = new System.Drawing.Point(745, 465);
            this.Button1.Name = "Button1";
            this.Button1.Size = new System.Drawing.Size(75, 29);
            this.Button1.TabIndex = 54;
            this.Button1.Text = "Close";
            this.Button1.UseVisualStyleBackColor = true;
            this.Button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Harrington", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(664, 465);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 29);
            this.btnDelete.TabIndex = 53;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // TXTSEARCH
            // 
            this.TXTSEARCH.BackColor = System.Drawing.Color.White;
            this.TXTSEARCH.Font = new System.Drawing.Font("Harrington", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXTSEARCH.Location = new System.Drawing.Point(228, 7);
            this.TXTSEARCH.Margin = new System.Windows.Forms.Padding(2);
            this.TXTSEARCH.Name = "TXTSEARCH";
            this.TXTSEARCH.Size = new System.Drawing.Size(392, 30);
            this.TXTSEARCH.TabIndex = 51;
            this.TXTSEARCH.TextChanged += new System.EventHandler(this.TXTSEARCH_TextChanged);
            // 
            // DTGLIST
            // 
            this.DTGLIST.AllowUserToAddRows = false;
            this.DTGLIST.AllowUserToDeleteRows = false;
            this.DTGLIST.AllowUserToResizeColumns = false;
            this.DTGLIST.AllowUserToResizeRows = false;
            this.DTGLIST.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.DTGLIST.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Harrington", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DTGLIST.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DTGLIST.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DTGLIST.Cursor = System.Windows.Forms.Cursors.Arrow;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Himalaya", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DTGLIST.DefaultCellStyle = dataGridViewCellStyle2;
            this.DTGLIST.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.DTGLIST.Location = new System.Drawing.Point(6, 43);
            this.DTGLIST.Margin = new System.Windows.Forms.Padding(2);
            this.DTGLIST.Name = "DTGLIST";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Himalaya", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DTGLIST.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.DTGLIST.RowHeadersVisible = false;
            this.DTGLIST.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DTGLIST.Size = new System.Drawing.Size(814, 416);
            this.DTGLIST.TabIndex = 52;
            // 
            // CloseEdtiPr
            // 
            this.CloseEdtiPr.BackColor = System.Drawing.Color.White;
            this.CloseEdtiPr.Font = new System.Drawing.Font("Harrington", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CloseEdtiPr.Location = new System.Drawing.Point(775, 6);
            this.CloseEdtiPr.Name = "CloseEdtiPr";
            this.CloseEdtiPr.Size = new System.Drawing.Size(38, 32);
            this.CloseEdtiPr.TabIndex = 71;
            this.CloseEdtiPr.Text = "X";
            this.CloseEdtiPr.UseVisualStyleBackColor = false;
            this.CloseEdtiPr.Click += new System.EventHandler(this.CloseEdtiPr_Click);
            // 
            // frmListStockin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::BakeryInventorySystem.Properties.Resources.backA;
            this.ClientSize = new System.Drawing.Size(825, 509);
            this.Controls.Add(this.CloseEdtiPr);
            this.Controls.Add(this.DTGLIST);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.Label17);
            this.Controls.Add(this.Label16);
            this.Controls.Add(this.DTPFROM);
            this.Controls.Add(this.DTPTO);
            this.Controls.Add(this.Label10);
            this.Controls.Add(this.Button1);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.TXTSEARCH);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmListStockin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "List of Recieved Products";
            this.Load += new System.EventHandler(this.frmListStockin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DTGLIST)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Button btnNew;
        internal System.Windows.Forms.Button btnRefresh;
        internal System.Windows.Forms.Label Label17;
        internal System.Windows.Forms.Label Label16;
        internal System.Windows.Forms.DateTimePicker DTPFROM;
        internal System.Windows.Forms.DateTimePicker DTPTO;
        internal System.Windows.Forms.Label Label10;
        internal System.Windows.Forms.Button Button1;
        internal System.Windows.Forms.Button btnDelete;
        internal System.Windows.Forms.TextBox TXTSEARCH;
        internal System.Windows.Forms.DataGridView DTGLIST;
        private System.Windows.Forms.Button CloseEdtiPr;
    }
}