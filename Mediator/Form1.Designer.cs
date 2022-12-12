namespace Mediator
{
	partial class MediatorExample
	{
		/// <summary>
		///  Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		///  Clean up any resources being used.
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
		///  Required method for Designer support - do not modify
		///  the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.AddNewItemButton = new System.Windows.Forms.Button();
			this.ItemTextBox = new System.Windows.Forms.TextBox();
			this.ItemListBox = new System.Windows.Forms.ListBox();
			this.label1 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// AddNewItemButton
			// 
			this.AddNewItemButton.Location = new System.Drawing.Point(12, 86);
			this.AddNewItemButton.Name = "AddNewItemButton";
			this.AddNewItemButton.Size = new System.Drawing.Size(94, 25);
			this.AddNewItemButton.TabIndex = 2;
			this.AddNewItemButton.Text = "Add";
			this.AddNewItemButton.UseVisualStyleBackColor = true;
			this.AddNewItemButton.Click += new System.EventHandler(this.AddNewItemButton_Click);
			// 
			// ItemTextBox
			// 
			this.ItemTextBox.Location = new System.Drawing.Point(13, 41);
			this.ItemTextBox.Name = "ItemTextBox";
			this.ItemTextBox.Size = new System.Drawing.Size(149, 24);
			this.ItemTextBox.TabIndex = 1;
			this.ItemTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ItemTextBox_KeyDown);
			// 
			// ItemListBox
			// 
			this.ItemListBox.FormattingEnabled = true;
			this.ItemListBox.ItemHeight = 17;
			this.ItemListBox.Location = new System.Drawing.Point(12, 128);
			this.ItemListBox.Name = "ItemListBox";
			this.ItemListBox.Size = new System.Drawing.Size(150, 89);
			this.ItemListBox.TabIndex = 2;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(13, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(149, 19);
			this.label1.TabIndex = 3;
			this.label1.Text = "Add new Item  here:";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// MediatorExample
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(344, 294);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.ItemListBox);
			this.Controls.Add(this.ItemTextBox);
			this.Controls.Add(this.AddNewItemButton);
			this.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.Name = "MediatorExample";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Form1";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		//Mediator pattern
		private Button AddNewItemButton;
		private TextBox ItemTextBox;
		private ListBox ItemListBox;
		private Label label1;
	}
}