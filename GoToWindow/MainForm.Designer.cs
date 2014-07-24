﻿namespace GoToWindow
{
    partial class MainForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.windowsListBox = new System.Windows.Forms.ListBox();
			this.goToWindowButton = new System.Windows.Forms.Button();
			this.cancelButton = new System.Windows.Forms.Button();
			this.searchTextBox = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// windowsListBox
			// 
			this.windowsListBox.AccessibleRole = System.Windows.Forms.AccessibleRole.Dialog;
			this.windowsListBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.windowsListBox.BackColor = System.Drawing.SystemColors.Control;
			this.windowsListBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.windowsListBox.FormattingEnabled = true;
			this.windowsListBox.Location = new System.Drawing.Point(12, 38);
			this.windowsListBox.Name = "windowsListBox";
			this.windowsListBox.Size = new System.Drawing.Size(602, 247);
			this.windowsListBox.TabIndex = 2;
			// 
			// goToWindowButton
			// 
			this.goToWindowButton.Location = new System.Drawing.Point(539, 295);
			this.goToWindowButton.Name = "goToWindowButton";
			this.goToWindowButton.Size = new System.Drawing.Size(75, 23);
			this.goToWindowButton.TabIndex = 3;
			this.goToWindowButton.Text = "Go";
			this.goToWindowButton.UseVisualStyleBackColor = true;
			this.goToWindowButton.Click += new System.EventHandler(this.goToWindowButton_Click);
			// 
			// cancelButton
			// 
			this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.cancelButton.Location = new System.Drawing.Point(458, 295);
			this.cancelButton.Name = "cancelButton";
			this.cancelButton.Size = new System.Drawing.Size(75, 23);
			this.cancelButton.TabIndex = 4;
			this.cancelButton.Text = "Cancel";
			this.cancelButton.UseVisualStyleBackColor = true;
			this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
			// 
			// searchTextBox
			// 
			this.searchTextBox.Location = new System.Drawing.Point(12, 12);
			this.searchTextBox.Name = "searchTextBox";
			this.searchTextBox.Size = new System.Drawing.Size(602, 20);
			this.searchTextBox.TabIndex = 1;
			this.searchTextBox.TextChanged += new System.EventHandler(this.searchTextBox_TextChanged);
			this.searchTextBox.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.searchTextBox_PreviewKeyDown);
			// 
			// MainForm
			// 
			this.AcceptButton = this.goToWindowButton;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.CancelButton = this.cancelButton;
			this.ClientSize = new System.Drawing.Size(626, 330);
			this.ControlBox = false;
			this.Controls.Add(this.searchTextBox);
			this.Controls.Add(this.cancelButton);
			this.Controls.Add(this.goToWindowButton);
			this.Controls.Add(this.windowsListBox);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "MainForm";
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Go To Window";
			this.TopMost = true;
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox windowsListBox;
        private System.Windows.Forms.Button goToWindowButton;
        private System.Windows.Forms.Button cancelButton;
		private System.Windows.Forms.TextBox searchTextBox;
    }
}

