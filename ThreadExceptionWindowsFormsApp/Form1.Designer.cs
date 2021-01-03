
namespace ThreadExceptionWindowsFormsApp
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.BadCastButton = new System.Windows.Forms.Button();
            this.ViewLogButton = new System.Windows.Forms.Button();
            this.ThrowOnCloseCheckBox = new System.Windows.Forms.CheckBox();
            this.MissingFileButton = new System.Windows.Forms.Button();
            this.BadThreadButton = new System.Windows.Forms.Button();
            this.MyExceptionButton = new System.Windows.Forms.Button();
            this.CustomExceptionTextTextBox = new System.Windows.Forms.TextBox();
            this.ArgumentNullExceptionButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(167, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "See program.cs";
            // 
            // BadCastButton
            // 
            this.BadCastButton.Location = new System.Drawing.Point(12, 12);
            this.BadCastButton.Name = "BadCastButton";
            this.BadCastButton.Size = new System.Drawing.Size(105, 23);
            this.BadCastButton.TabIndex = 1;
            this.BadCastButton.Text = "Bad Cast";
            this.BadCastButton.UseVisualStyleBackColor = true;
            this.BadCastButton.Click += new System.EventHandler(this.BadCastButton_Click);
            // 
            // ViewLogButton
            // 
            this.ViewLogButton.Location = new System.Drawing.Point(12, 162);
            this.ViewLogButton.Name = "ViewLogButton";
            this.ViewLogButton.Size = new System.Drawing.Size(105, 23);
            this.ViewLogButton.TabIndex = 2;
            this.ViewLogButton.Text = "View log";
            this.ViewLogButton.UseVisualStyleBackColor = true;
            this.ViewLogButton.Click += new System.EventHandler(this.ViewLogButton_Click);
            // 
            // ThrowOnCloseCheckBox
            // 
            this.ThrowOnCloseCheckBox.AutoSize = true;
            this.ThrowOnCloseCheckBox.Location = new System.Drawing.Point(262, 16);
            this.ThrowOnCloseCheckBox.Name = "ThrowOnCloseCheckBox";
            this.ThrowOnCloseCheckBox.Size = new System.Drawing.Size(161, 19);
            this.ThrowOnCloseCheckBox.TabIndex = 3;
            this.ThrowOnCloseCheckBox.Text = "Throw exception on close";
            this.ThrowOnCloseCheckBox.UseVisualStyleBackColor = true;
            // 
            // MissingFileButton
            // 
            this.MissingFileButton.Location = new System.Drawing.Point(12, 41);
            this.MissingFileButton.Name = "MissingFileButton";
            this.MissingFileButton.Size = new System.Drawing.Size(105, 23);
            this.MissingFileButton.TabIndex = 4;
            this.MissingFileButton.Text = "Missing file";
            this.MissingFileButton.UseVisualStyleBackColor = true;
            this.MissingFileButton.Click += new System.EventHandler(this.MissingFileButton_Click);
            // 
            // BadThreadButton
            // 
            this.BadThreadButton.Location = new System.Drawing.Point(12, 70);
            this.BadThreadButton.Name = "BadThreadButton";
            this.BadThreadButton.Size = new System.Drawing.Size(105, 23);
            this.BadThreadButton.TabIndex = 5;
            this.BadThreadButton.Text = "Bad thread";
            this.BadThreadButton.UseVisualStyleBackColor = true;
            this.BadThreadButton.Click += new System.EventHandler(this.BadThreadButton_Click);
            // 
            // MyExceptionButton
            // 
            this.MyExceptionButton.Location = new System.Drawing.Point(12, 99);
            this.MyExceptionButton.Name = "MyExceptionButton";
            this.MyExceptionButton.Size = new System.Drawing.Size(105, 23);
            this.MyExceptionButton.TabIndex = 6;
            this.MyExceptionButton.Text = "My exception";
            this.MyExceptionButton.UseVisualStyleBackColor = true;
            this.MyExceptionButton.Click += new System.EventHandler(this.MyExceptionButton_Click);
            // 
            // CustomExceptionTextTextBox
            // 
            this.CustomExceptionTextTextBox.Location = new System.Drawing.Point(123, 100);
            this.CustomExceptionTextTextBox.Name = "CustomExceptionTextTextBox";
            this.CustomExceptionTextTextBox.Size = new System.Drawing.Size(287, 23);
            this.CustomExceptionTextTextBox.TabIndex = 7;
            // 
            // ArgumentNullExceptionButton
            // 
            this.ArgumentNullExceptionButton.Location = new System.Drawing.Point(12, 128);
            this.ArgumentNullExceptionButton.Name = "ArgumentNullExceptionButton";
            this.ArgumentNullExceptionButton.Size = new System.Drawing.Size(105, 23);
            this.ArgumentNullExceptionButton.TabIndex = 8;
            this.ArgumentNullExceptionButton.Text = "Null";
            this.ArgumentNullExceptionButton.UseVisualStyleBackColor = true;
            this.ArgumentNullExceptionButton.Click += new System.EventHandler(this.ArgumentNullExceptionButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(422, 197);
            this.Controls.Add(this.ArgumentNullExceptionButton);
            this.Controls.Add(this.CustomExceptionTextTextBox);
            this.Controls.Add(this.MyExceptionButton);
            this.Controls.Add(this.BadThreadButton);
            this.Controls.Add(this.MissingFileButton);
            this.Controls.Add(this.ThrowOnCloseCheckBox);
            this.Controls.Add(this.ViewLogButton);
            this.Controls.Add(this.BadCastButton);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Unhandle exceptions at runtime logging";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BadCastButton;
        private System.Windows.Forms.Button ViewLogButton;
        private System.Windows.Forms.CheckBox ThrowOnCloseCheckBox;
        private System.Windows.Forms.Button MissingFileButton;
        private System.Windows.Forms.Button BadThreadButton;
        private System.Windows.Forms.Button MyExceptionButton;
        private System.Windows.Forms.TextBox CustomExceptionTextTextBox;
        private System.Windows.Forms.Button ArgumentNullExceptionButton;
    }
}

