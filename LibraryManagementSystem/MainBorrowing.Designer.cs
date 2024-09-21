namespace LibraryManagementSystem
{
	partial class MainBorrowing
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainBorrowing));
			this.BorrowView = new System.Windows.Forms.DataGridView();
			this.label1 = new System.Windows.Forms.Label();
			this.toolStrip1 = new System.Windows.Forms.ToolStrip();
			this.btnBorrow = new System.Windows.Forms.ToolStripButton();
			this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
			this.btnReturn = new System.Windows.Forms.ToolStripButton();
			this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
			this.btnMBorrow = new System.Windows.Forms.ToolStripButton();
			this.BmemberList = new System.Windows.Forms.ToolStripComboBox();
			this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
			this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
			this.btnOverDue = new System.Windows.Forms.ToolStripButton();
			this.btnHome = new System.Windows.Forms.ToolStripButton();
			((System.ComponentModel.ISupportInitialize)(this.BorrowView)).BeginInit();
			this.toolStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// BorrowView
			// 
			this.BorrowView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.BorrowView.BackgroundColor = System.Drawing.Color.Linen;
			this.BorrowView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.BorrowView.Location = new System.Drawing.Point(12, 122);
			this.BorrowView.Name = "BorrowView";
			this.BorrowView.RowHeadersWidth = 51;
			this.BorrowView.RowTemplate.Height = 24;
			this.BorrowView.Size = new System.Drawing.Size(1119, 316);
			this.BorrowView.TabIndex = 0;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Mongolian Baiti", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(7, 80);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(200, 30);
			this.label1.TabIndex = 1;
			this.label1.Text = "Borrwing Data ";
			// 
			// toolStrip1
			// 
			this.toolStrip1.BackColor = System.Drawing.Color.FloralWhite;
			this.toolStrip1.ImageScalingSize = new System.Drawing.Size(30, 30);
			this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnBorrow,
            this.toolStripSeparator2,
            this.btnReturn,
            this.toolStripSeparator1,
            this.btnMBorrow,
            this.BmemberList,
            this.toolStripSeparator3,
            this.toolStripSeparator4,
            this.btnOverDue,
            this.btnHome});
			this.toolStrip1.Location = new System.Drawing.Point(0, 0);
			this.toolStrip1.Name = "toolStrip1";
			this.toolStrip1.Size = new System.Drawing.Size(1143, 37);
			this.toolStrip1.TabIndex = 2;
			this.toolStrip1.Text = "toolStrip1";
			// 
			// btnBorrow
			// 
			this.btnBorrow.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnBorrow.Image = ((System.Drawing.Image)(resources.GetObject("btnBorrow.Image")));
			this.btnBorrow.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.btnBorrow.Name = "btnBorrow";
			this.btnBorrow.Size = new System.Drawing.Size(98, 34);
			this.btnBorrow.Text = "Borrow";
			this.btnBorrow.Click += new System.EventHandler(this.btnBorrow_Click);
			// 
			// toolStripSeparator2
			// 
			this.toolStripSeparator2.Name = "toolStripSeparator2";
			this.toolStripSeparator2.Size = new System.Drawing.Size(6, 37);
			// 
			// btnReturn
			// 
			this.btnReturn.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnReturn.Image = ((System.Drawing.Image)(resources.GetObject("btnReturn.Image")));
			this.btnReturn.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.btnReturn.Name = "btnReturn";
			this.btnReturn.Size = new System.Drawing.Size(95, 34);
			this.btnReturn.Text = "Return";
			this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
			// 
			// toolStripSeparator1
			// 
			this.toolStripSeparator1.Name = "toolStripSeparator1";
			this.toolStripSeparator1.Size = new System.Drawing.Size(6, 37);
			// 
			// btnMBorrow
			// 
			this.btnMBorrow.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnMBorrow.Image = ((System.Drawing.Image)(resources.GetObject("btnMBorrow.Image")));
			this.btnMBorrow.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.btnMBorrow.Name = "btnMBorrow";
			this.btnMBorrow.Size = new System.Drawing.Size(199, 34);
			this.btnMBorrow.Text = "Books Borrowed By :";
			this.btnMBorrow.Click += new System.EventHandler(this.btnMBorrow_Click);
			// 
			// BmemberList
			// 
			this.BmemberList.BackColor = System.Drawing.Color.FloralWhite;
			this.BmemberList.DropDownWidth = 125;
			this.BmemberList.ForeColor = System.Drawing.SystemColors.WindowFrame;
			this.BmemberList.Name = "BmemberList";
			this.BmemberList.Size = new System.Drawing.Size(140, 37);
			this.BmemberList.Text = "Members Name";
			// 
			// toolStripSeparator3
			// 
			this.toolStripSeparator3.Name = "toolStripSeparator3";
			this.toolStripSeparator3.Size = new System.Drawing.Size(6, 37);
			// 
			// toolStripSeparator4
			// 
			this.toolStripSeparator4.Name = "toolStripSeparator4";
			this.toolStripSeparator4.Size = new System.Drawing.Size(6, 37);
			// 
			// btnOverDue
			// 
			this.btnOverDue.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnOverDue.ForeColor = System.Drawing.Color.DarkRed;
			this.btnOverDue.Image = ((System.Drawing.Image)(resources.GetObject("btnOverDue.Image")));
			this.btnOverDue.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.btnOverDue.Name = "btnOverDue";
			this.btnOverDue.Size = new System.Drawing.Size(116, 34);
			this.btnOverDue.Text = "OverDue!";
			this.btnOverDue.Click += new System.EventHandler(this.btnOverDue_Click);
			// 
			// btnHome
			// 
			this.btnHome.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
			this.btnHome.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.btnHome.Image = ((System.Drawing.Image)(resources.GetObject("btnHome.Image")));
			this.btnHome.ImageAlign = System.Drawing.ContentAlignment.TopRight;
			this.btnHome.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.btnHome.Name = "btnHome";
			this.btnHome.Size = new System.Drawing.Size(34, 34);
			this.btnHome.Text = "toolStripButton1";
			this.btnHome.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
			this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
			// 
			// MainBorrowing
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Linen;
			this.ClientSize = new System.Drawing.Size(1143, 450);
			this.Controls.Add(this.toolStrip1);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.BorrowView);
			this.Name = "MainBorrowing";
			((System.ComponentModel.ISupportInitialize)(this.BorrowView)).EndInit();
			this.toolStrip1.ResumeLayout(false);
			this.toolStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.DataGridView BorrowView;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ToolStrip toolStrip1;
		private System.Windows.Forms.ToolStripButton btnBorrow;
		private System.Windows.Forms.ToolStripButton btnReturn;
		private System.Windows.Forms.ToolStripButton btnMBorrow;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
		private System.Windows.Forms.ToolStripComboBox BmemberList;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
		private System.Windows.Forms.ToolStripButton btnOverDue;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
		private System.Windows.Forms.ToolStripButton btnHome;
	}
}