namespace BakeryInventorySystem
{
    partial class Form1
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
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsBread = new System.Windows.Forms.ToolStripButton();
            this.tsListofProducts = new System.Windows.Forms.ToolStripButton();
            this.tsStockin = new System.Windows.Forms.ToolStripButton();
            this.tsStockout = new System.Windows.Forms.ToolStripButton();
            this.tsUser = new System.Windows.Forms.ToolStripButton();
            this.tsReport = new System.Windows.Forms.ToolStripButton();
            this.tsLogin = new System.Windows.Forms.ToolStripButton();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(60, 50);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsBread,
            this.tsListofProducts,
            this.tsStockin,
            this.tsStockout,
            this.tsUser,
            this.tsReport,
            this.tsLogin});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(664, 72);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsBread
            // 
            this.tsBread.Image = global::BakeryInventorySystem.Properties.Resources.plus;
            this.tsBread.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsBread.Name = "tsBread";
            this.tsBread.Size = new System.Drawing.Size(105, 69);
            this.tsBread.Text = "Add New Product";
            this.tsBread.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsBread.Click += new System.EventHandler(this.tsBread_Click);
            // 
            // tsListofProducts
            // 
            this.tsListofProducts.Image = global::BakeryInventorySystem.Properties.Resources.list;
            this.tsListofProducts.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsListofProducts.Name = "tsListofProducts";
            this.tsListofProducts.Size = new System.Drawing.Size(93, 69);
            this.tsListofProducts.Text = "List of Products";
            this.tsListofProducts.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsListofProducts.Click += new System.EventHandler(this.tsListofProducts_Click);
            // 
            // tsStockin
            // 
            this.tsStockin.Image = global::BakeryInventorySystem.Properties.Resources.ben;
            this.tsStockin.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsStockin.Name = "tsStockin";
            this.tsStockin.Size = new System.Drawing.Size(80, 69);
            this.tsStockin.Text = "Add To Stock";
            this.tsStockin.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsStockin.Click += new System.EventHandler(this.tsStockin_Click);
            // 
            // tsStockout
            // 
            this.tsStockout.Image = global::BakeryInventorySystem.Properties.Resources.Sell2;
            this.tsStockout.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsStockout.Name = "tsStockout";
            this.tsStockout.Size = new System.Drawing.Size(64, 69);
            this.tsStockout.Text = "Sending";
            this.tsStockout.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsStockout.Click += new System.EventHandler(this.tsStockout_Click);
            // 
            // tsUser
            // 
            this.tsUser.Image = global::BakeryInventorySystem.Properties.Resources.people;
            this.tsUser.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsUser.Name = "tsUser";
            this.tsUser.Size = new System.Drawing.Size(85, 69);
            this.tsUser.Text = "Manage Users";
            this.tsUser.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsUser.Click += new System.EventHandler(this.tsUser_Click);
            // 
            // tsReport
            // 
            this.tsReport.Image = global::BakeryInventorySystem.Properties.Resources.report;
            this.tsReport.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsReport.Name = "tsReport";
            this.tsReport.Size = new System.Drawing.Size(96, 69);
            this.tsReport.Text = "View All Actions";
            this.tsReport.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsReport.ToolTipText = "Inventory Reports";
            this.tsReport.Click += new System.EventHandler(this.tsReport_Click);
            // 
            // tsLogin
            // 
            this.tsLogin.Image = global::BakeryInventorySystem.Properties.Resources.login;
            this.tsLogin.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsLogin.Name = "tsLogin";
            this.tsLogin.Size = new System.Drawing.Size(64, 69);
            this.tsLogin.Text = "Login";
            this.tsLogin.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsLogin.Click += new System.EventHandler(this.tsLogin_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.Font = new System.Drawing.Font("Harrington", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(614, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(38, 32);
            this.button1.TabIndex = 2;
            this.button1.Text = "X";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::BakeryInventorySystem.Properties.Resources.backA;
            this.pictureBox1.Location = new System.Drawing.Point(0, 72);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(664, 419);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Location = new System.Drawing.Point(0, 72);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(664, 5);
            this.panel1.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(664, 491);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.toolStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsBread;
        private System.Windows.Forms.ToolStripButton tsStockin;
        private System.Windows.Forms.ToolStripButton tsStockout;
        private System.Windows.Forms.ToolStripButton tsUser;
        private System.Windows.Forms.ToolStripButton tsReport;
        private System.Windows.Forms.ToolStripButton tsLogin;
        private System.Windows.Forms.ToolStripButton tsListofProducts;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel1;
    }
}

