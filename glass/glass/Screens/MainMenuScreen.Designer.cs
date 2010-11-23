﻿/*
 * User: Axel
 * Date: 2010-11-17
 * Time: 19:14
 */
namespace glass.Screens
{
	partial class MainMenuScreen
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.picPrepositions = new System.Windows.Forms.PictureBox();
			this.picBack = new System.Windows.Forms.PictureBox();
			this.tableLayoutPanel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.picPrepositions)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.picBack)).BeginInit();
			this.SuspendLayout();
			// 
			// tableLayoutPanel1
			// 
			this.tableLayoutPanel1.ColumnCount = 3;
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
			this.tableLayoutPanel1.Controls.Add(this.picPrepositions, 0, 0);
			this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 12);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.Padding = new System.Windows.Forms.Padding(2);
			this.tableLayoutPanel1.RowCount = 3;
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
			this.tableLayoutPanel1.Size = new System.Drawing.Size(776, 538);
			this.tableLayoutPanel1.TabIndex = 2;
			// 
			// picPrepositions
			// 
			this.picPrepositions.Dock = System.Windows.Forms.DockStyle.Fill;
			this.picPrepositions.Image = global::glass.Resources.rum_prepositioner;
			this.picPrepositions.Location = new System.Drawing.Point(5, 5);
			this.picPrepositions.Name = "picPrepositions";
			this.picPrepositions.Size = new System.Drawing.Size(251, 172);
			this.picPrepositions.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.picPrepositions.TabIndex = 0;
			this.picPrepositions.TabStop = false;
			this.picPrepositions.Click += new System.EventHandler(this.PicPrepositionsClick);
			// 
			// picBack
			// 
			this.picBack.Image = global::glass.Resources.exit;
			this.picBack.Location = new System.Drawing.Point(12, 556);
			this.picBack.Name = "picBack";
			this.picBack.Size = new System.Drawing.Size(32, 32);
			this.picBack.TabIndex = 3;
			this.picBack.TabStop = false;
			this.picBack.Click += new System.EventHandler(this.PicBackClick);
			// 
			// MainMenuScreen
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Lime;
			this.ClientSize = new System.Drawing.Size(800, 600);
			this.Controls.Add(this.picBack);
			this.Controls.Add(this.tableLayoutPanel1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "MainMenuScreen";
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "MainMenu";
			this.TopMost = true;
			this.tableLayoutPanel1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.picPrepositions)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.picBack)).EndInit();
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.PictureBox picPrepositions;
		private System.Windows.Forms.PictureBox picBack;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
	}
}
