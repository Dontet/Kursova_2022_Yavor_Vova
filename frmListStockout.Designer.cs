﻿namespace BakeryInventorySystem
{
    partial class frmListStockout
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
            this.CloseStockout = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DTGLIST)).BeginInit();
            this.SuspendLayout();
            // 
            // btnNew
            // 
            this.btnNew.Font = new System.Drawing.Font("Harrington", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNew.Location = new System.Drawing.Point(576, 466);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(75, 29);
            this.btnNew.TabIndex = 74;
            this.btnNew.Text = "New";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Font = new System.Drawing.Font("Harrington", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefresh.Location = new System.Drawing.Point(493, 466);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(84, 29);
            this.btnRefresh.TabIndex = 72;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // Label17
            // 
            this.Label17.AutoSize = true;
            this.Label17.Location = new System.Drawing.Point(650, 108);
            this.Label17.Name = "Label17";
            this.Label17.Size = new System.Drawing.Size(20, 13);
            this.Label17.TabIndex = 71;
            this.Label17.Text = "To";
            // 
            // Label16
            // 
            this.Label16.AutoSize = true;
            this.Label16.Location = new System.Drawing.Point(460, 108);
            this.Label16.Name = "Label16";
            this.Label16.Size = new System.Drawing.Size(30, 13);
            this.Label16.TabIndex = 70;
            this.Label16.Text = "From";
            // 
            // DTPFROM
            // 
            this.DTPFROM.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DTPFROM.Location = new System.Drawing.Point(506, 103);
            this.DTPFROM.Name = "DTPFROM";
            this.DTPFROM.Size = new System.Drawing.Size(139, 20);
            this.DTPFROM.TabIndex = 68;
            // 
            // DTPTO
            // 
            this.DTPTO.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DTPTO.Location = new System.Drawing.Point(679, 103);
            this.DTPTO.Name = "DTPTO";
            this.DTPTO.Size = new System.Drawing.Size(132, 20);
            this.DTPTO.TabIndex = 69;
            // 
            // Label10
            // 
            this.Label10.AutoSize = true;
            this.Label10.BackColor = System.Drawing.Color.White;
            this.Label10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Label10.Font = new System.Drawing.Font("Harrington", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label10.Location = new System.Drawing.Point(108, 10);
            this.Label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Label10.Name = "Label10";
            this.Label10.Size = new System.Drawing.Size(86, 24);
            this.Label10.TabIndex = 67;
            this.Label10.Text = "Search :";
            // 
            // Button1
            // 
            this.Button1.Font = new System.Drawing.Font("Harrington", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button1.Location = new System.Drawing.Point(736, 466);
            this.Button1.Name = "Button1";
            this.Button1.Size = new System.Drawing.Size(75, 29);
            this.Button1.TabIndex = 66;
            this.Button1.Text = "Close";
            this.Button1.UseVisualStyleBackColor = true;
            this.Button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Harrington", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(655, 466);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 29);
            this.btnDelete.TabIndex = 65;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // TXTSEARCH
            // 
            this.TXTSEARCH.BackColor = System.Drawing.Color.White;
            this.TXTSEARCH.Font = new System.Drawing.Font("Harrington", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXTSEARCH.Location = new System.Drawing.Point(198, 7);
            this.TXTSEARCH.Margin = new System.Windows.Forms.Padding(2);
            this.TXTSEARCH.Name = "TXTSEARCH";
            this.TXTSEARCH.Size = new System.Drawing.Size(392, 30);
            this.TXTSEARCH.TabIndex = 63;
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
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Harrington", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.DTGLIST.Location = new System.Drawing.Point(3, 42);
            this.DTGLIST.Margin = new System.Windows.Forms.Padding(2);
            this.DTGLIST.Name = "DTGLIST";
            this.DTGLIST.RowHeadersVisible = false;
            this.DTGLIST.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DTGLIST.Size = new System.Drawing.Size(808, 419);
            this.DTGLIST.TabIndex = 64;
            // 
            // CloseStockout
            // 
            this.CloseStockout.BackColor = System.Drawing.Color.White;
            this.CloseStockout.Font = new System.Drawing.Font("Harrington", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CloseStockout.Location = new System.Drawing.Point(765, 5);
            this.CloseStockout.Name = "CloseStockout";
            this.CloseStockout.Size = new System.Drawing.Size(38, 32);
            this.CloseStockout.TabIndex = 75;
            this.CloseStockout.Text = "X";
            this.CloseStockout.UseVisualStyleBackColor = false;
            this.CloseStockout.Click += new System.EventHandler(this.CloseStockout_Click);
            // 
            // frmListStockout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::BakeryInventorySystem.Properties.Resources.backA;
            this.ClientSize = new System.Drawing.Size(815, 502);
            this.Controls.Add(this.CloseStockout);
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
            this.Name = "frmListStockout";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "List of Sold Items";
            this.Load += new System.EventHandler(this.frmListStockout_Load);
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
        private System.Windows.Forms.Button CloseStockout;
    }
}