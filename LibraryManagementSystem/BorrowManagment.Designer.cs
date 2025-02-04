﻿namespace LibraryManagementSystem
{
	partial class BorrowManagment
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
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.IDText = new System.Windows.Forms.TextBox();
			this.BookList = new System.Windows.Forms.ComboBox();
			this.MemberList = new System.Windows.Forms.ComboBox();
			this.label4 = new System.Windows.Forms.Label();
			this.btnSave = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(41, 108);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(135, 22);
			this.label1.TabIndex = 0;
			this.label1.Text = "Borrowing ID :";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(41, 158);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(114, 22);
			this.label2.TabIndex = 1;
			this.label2.Text = "Book Name :";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(41, 222);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(141, 22);
			this.label3.TabIndex = 2;
			this.label3.Text = "Member Name : ";
			// 
			// IDText
			// 
			this.IDText.Location = new System.Drawing.Point(189, 108);
			this.IDText.Name = "IDText";
			this.IDText.Size = new System.Drawing.Size(121, 22);
			this.IDText.TabIndex = 3;
			// 
			// BookList
			// 
			this.BookList.FormattingEnabled = true;
			this.BookList.Location = new System.Drawing.Point(189, 160);
			this.BookList.Name = "BookList";
			this.BookList.Size = new System.Drawing.Size(121, 24);
			this.BookList.TabIndex = 4;
			// 
			// MemberList
			// 
			this.MemberList.FormattingEnabled = true;
			this.MemberList.Location = new System.Drawing.Point(189, 220);
			this.MemberList.Name = "MemberList";
			this.MemberList.Size = new System.Drawing.Size(121, 24);
			this.MemberList.TabIndex = 5;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.BackColor = System.Drawing.Color.Linen;
			this.label4.Font = new System.Drawing.Font("Modern No. 20", 19.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(12, 27);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(247, 34);
			this.label4.TabIndex = 6;
			this.label4.Text = "Borrowing Data";
			// 
			// btnSave
			// 
			this.btnSave.BackColor = System.Drawing.Color.Bisque;
			this.btnSave.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnSave.Location = new System.Drawing.Point(129, 292);
			this.btnSave.Name = "btnSave";
			this.btnSave.Size = new System.Drawing.Size(108, 30);
			this.btnSave.TabIndex = 7;
			this.btnSave.Text = "Save";
			this.btnSave.UseVisualStyleBackColor = false;
			this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
			// 
			// BorrowManagment
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Linen;
			this.ClientSize = new System.Drawing.Size(387, 349);
			this.Controls.Add(this.btnSave);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.MemberList);
			this.Controls.Add(this.BookList);
			this.Controls.Add(this.IDText);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Name = "BorrowManagment";
			this.Text = "BorrowManagment";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox IDText;
		private System.Windows.Forms.ComboBox BookList;
		private System.Windows.Forms.ComboBox MemberList;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Button btnSave;
	}
}