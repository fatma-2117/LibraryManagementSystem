namespace LibraryManagementSystem
{
	partial class MainBook
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainBook));
			this.bookView = new System.Windows.Forms.DataGridView();
			this.label1 = new System.Windows.Forms.Label();
			this.toolStrip1 = new System.Windows.Forms.ToolStrip();
			this.Add = new System.Windows.Forms.ToolStripButton();
			this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
			this.Edite = new System.Windows.Forms.ToolStripButton();
			this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
			this.btnDelete = new System.Windows.Forms.ToolStripButton();
			this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
			this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
			this.btnSearch = new System.Windows.Forms.ToolStripButton();
			this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
			this.STitleText = new System.Windows.Forms.ToolStripTextBox();
			this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
			this.SAuthorText = new System.Windows.Forms.ToolStripTextBox();
			this.toolStripLabel3 = new System.Windows.Forms.ToolStripLabel();
			this.SISBNText = new System.Windows.Forms.ToolStripTextBox();
			this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
			this.btnCategoryType = new System.Windows.Forms.ToolStripButton();
			this.CategoryType = new System.Windows.Forms.ToolStripComboBox();
			this.btnHome = new System.Windows.Forms.ToolStripButton();
			((System.ComponentModel.ISupportInitialize)(this.bookView)).BeginInit();
			this.toolStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// bookView
			// 
			this.bookView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.bookView.BackgroundColor = System.Drawing.Color.Linen;
			this.bookView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.bookView.Location = new System.Drawing.Point(12, 90);
			this.bookView.Name = "bookView";
			this.bookView.RowHeadersWidth = 51;
			this.bookView.RowTemplate.Height = 24;
			this.bookView.Size = new System.Drawing.Size(1153, 463);
			this.bookView.TabIndex = 0;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Modern No. 20", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(12, 57);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(84, 30);
			this.label1.TabIndex = 1;
			this.label1.Text = "Books";
			// 
			// toolStrip1
			// 
			this.toolStrip1.BackColor = System.Drawing.Color.FloralWhite;
			this.toolStrip1.ImageScalingSize = new System.Drawing.Size(30, 30);
			this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Add,
            this.toolStripSeparator4,
            this.Edite,
            this.toolStripSeparator3,
            this.btnDelete,
            this.toolStripSeparator1,
            this.toolStripSeparator2,
            this.btnSearch,
            this.toolStripLabel1,
            this.STitleText,
            this.toolStripLabel2,
            this.SAuthorText,
            this.toolStripLabel3,
            this.SISBNText,
            this.toolStripSeparator5,
            this.btnCategoryType,
            this.CategoryType,
            this.btnHome});
			this.toolStrip1.Location = new System.Drawing.Point(0, 0);
			this.toolStrip1.Name = "toolStrip1";
			this.toolStrip1.Size = new System.Drawing.Size(1382, 37);
			this.toolStrip1.TabIndex = 2;
			this.toolStrip1.Text = "toolStrip1";
			// 
			// Add
			// 
			this.Add.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Add.Image = ((System.Drawing.Image)(resources.GetObject("Add.Image")));
			this.Add.ImageTransparentColor = System.Drawing.Color.Violet;
			this.Add.Name = "Add";
			this.Add.Size = new System.Drawing.Size(79, 34);
			this.Add.Text = "ADD";
			this.Add.Click += new System.EventHandler(this.Add_Click);
			// 
			// toolStripSeparator4
			// 
			this.toolStripSeparator4.Name = "toolStripSeparator4";
			this.toolStripSeparator4.Size = new System.Drawing.Size(6, 37);
			// 
			// Edite
			// 
			this.Edite.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Edite.Image = ((System.Drawing.Image)(resources.GetObject("Edite.Image")));
			this.Edite.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.Edite.Name = "Edite";
			this.Edite.Size = new System.Drawing.Size(82, 34);
			this.Edite.Text = "Edite";
			this.Edite.Click += new System.EventHandler(this.Edite_Click);
			// 
			// toolStripSeparator3
			// 
			this.toolStripSeparator3.Name = "toolStripSeparator3";
			this.toolStripSeparator3.Size = new System.Drawing.Size(6, 37);
			// 
			// btnDelete
			// 
			this.btnDelete.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnDelete.Image = ((System.Drawing.Image)(resources.GetObject("btnDelete.Image")));
			this.btnDelete.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.btnDelete.Name = "btnDelete";
			this.btnDelete.Size = new System.Drawing.Size(93, 34);
			this.btnDelete.Text = "Delete";
			this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
			// 
			// toolStripSeparator1
			// 
			this.toolStripSeparator1.Name = "toolStripSeparator1";
			this.toolStripSeparator1.Size = new System.Drawing.Size(6, 37);
			// 
			// toolStripSeparator2
			// 
			this.toolStripSeparator2.Name = "toolStripSeparator2";
			this.toolStripSeparator2.Size = new System.Drawing.Size(6, 37);
			// 
			// btnSearch
			// 
			this.btnSearch.Font = new System.Drawing.Font("Segoe UI", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnSearch.Image = ((System.Drawing.Image)(resources.GetObject("btnSearch.Image")));
			this.btnSearch.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.btnSearch.Name = "btnSearch";
			this.btnSearch.Size = new System.Drawing.Size(97, 34);
			this.btnSearch.Text = "Search";
			this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
			// 
			// toolStripLabel1
			// 
			this.toolStripLabel1.Name = "toolStripLabel1";
			this.toolStripLabel1.Size = new System.Drawing.Size(79, 34);
			this.toolStripLabel1.Text = "Book Title:";
			// 
			// STitleText
			// 
			this.STitleText.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.STitleText.ForeColor = System.Drawing.SystemColors.WindowFrame;
			this.STitleText.Name = "STitleText";
			this.STitleText.Size = new System.Drawing.Size(100, 37);
			// 
			// toolStripLabel2
			// 
			this.toolStripLabel2.Name = "toolStripLabel2";
			this.toolStripLabel2.Size = new System.Drawing.Size(61, 34);
			this.toolStripLabel2.Text = "Author :";
			// 
			// SAuthorText
			// 
			this.SAuthorText.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.SAuthorText.ForeColor = System.Drawing.SystemColors.WindowFrame;
			this.SAuthorText.Name = "SAuthorText";
			this.SAuthorText.Size = new System.Drawing.Size(100, 37);
			// 
			// toolStripLabel3
			// 
			this.toolStripLabel3.Name = "toolStripLabel3";
			this.toolStripLabel3.Size = new System.Drawing.Size(48, 34);
			this.toolStripLabel3.Text = "ISBN :";
			// 
			// SISBNText
			// 
			this.SISBNText.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.SISBNText.ForeColor = System.Drawing.SystemColors.WindowFrame;
			this.SISBNText.Name = "SISBNText";
			this.SISBNText.Size = new System.Drawing.Size(100, 37);
			// 
			// toolStripSeparator5
			// 
			this.toolStripSeparator5.Name = "toolStripSeparator5";
			this.toolStripSeparator5.Size = new System.Drawing.Size(6, 37);
			// 
			// btnCategoryType
			// 
			this.btnCategoryType.Image = ((System.Drawing.Image)(resources.GetObject("btnCategoryType.Image")));
			this.btnCategoryType.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.btnCategoryType.Name = "btnCategoryType";
			this.btnCategoryType.Size = new System.Drawing.Size(145, 34);
			this.btnCategoryType.Text = "Category Type :";
			this.btnCategoryType.Click += new System.EventHandler(this.btnCategoryType_Click);
			// 
			// CategoryType
			// 
			this.CategoryType.Name = "CategoryType";
			this.CategoryType.Size = new System.Drawing.Size(121, 37);
			// 
			// btnHome
			// 
			this.btnHome.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.btnHome.Image = ((System.Drawing.Image)(resources.GetObject("btnHome.Image")));
			this.btnHome.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.btnHome.Name = "btnHome";
			this.btnHome.Size = new System.Drawing.Size(34, 34);
			this.btnHome.Text = "toolStripButton1";
			this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
			// 
			// MainBook
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Linen;
			this.ClientSize = new System.Drawing.Size(1382, 565);
			this.Controls.Add(this.toolStrip1);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.bookView);
			this.Name = "MainBook";
			this.Text = "MainBook";
			((System.ComponentModel.ISupportInitialize)(this.bookView)).EndInit();
			this.toolStrip1.ResumeLayout(false);
			this.toolStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.DataGridView bookView;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ToolStrip toolStrip1;
		private System.Windows.Forms.ToolStripButton Add;
		private System.Windows.Forms.ToolStripButton Edite;
		private System.Windows.Forms.ToolStripButton btnDelete;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
		private System.Windows.Forms.ToolStripButton btnSearch;
		private System.Windows.Forms.ToolStripLabel toolStripLabel1;
		private System.Windows.Forms.ToolStripTextBox STitleText;
		private System.Windows.Forms.ToolStripLabel toolStripLabel2;
		private System.Windows.Forms.ToolStripTextBox SAuthorText;
		private System.Windows.Forms.ToolStripLabel toolStripLabel3;
		private System.Windows.Forms.ToolStripTextBox SISBNText;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
		private System.Windows.Forms.ToolStripButton btnCategoryType;
		private System.Windows.Forms.ToolStripComboBox CategoryType;
		private System.Windows.Forms.ToolStripButton btnHome;
	}
}