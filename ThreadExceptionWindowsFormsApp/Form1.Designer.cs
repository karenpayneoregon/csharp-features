
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
            this.button2 = new System.Windows.Forms.Button();
            this.ThrowOnCloseCheckBox = new System.Windows.Forms.CheckBox();
            this.MissingFileButton = new System.Windows.Forms.Button();
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
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(12, 91);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(422, 144);
            this.Controls.Add(this.MissingFileButton);
            this.Controls.Add(this.ThrowOnCloseCheckBox);
            this.Controls.Add(this.button2);
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
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.CheckBox ThrowOnCloseCheckBox;
        private System.Windows.Forms.Button MissingFileButton;
    }
}

