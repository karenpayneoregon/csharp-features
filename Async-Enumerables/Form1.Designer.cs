
namespace Async_Enumerables
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
            this.BasicExampleStartButton = new System.Windows.Forms.Button();
            this.BasicExampleCancelButton = new System.Windows.Forms.Button();
            this.BasicExampleLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BasicExampleStartButton
            // 
            this.BasicExampleStartButton.Location = new System.Drawing.Point(12, 12);
            this.BasicExampleStartButton.Name = "BasicExampleStartButton";
            this.BasicExampleStartButton.Size = new System.Drawing.Size(181, 23);
            this.BasicExampleStartButton.TabIndex = 0;
            this.BasicExampleStartButton.Text = "Basic example start";
            this.BasicExampleStartButton.UseVisualStyleBackColor = true;
            this.BasicExampleStartButton.Click += new System.EventHandler(this.BasicExampleStartButton_Click);
            // 
            // BasicExampleCancelButton
            // 
            this.BasicExampleCancelButton.Location = new System.Drawing.Point(211, 12);
            this.BasicExampleCancelButton.Name = "BasicExampleCancelButton";
            this.BasicExampleCancelButton.Size = new System.Drawing.Size(181, 23);
            this.BasicExampleCancelButton.TabIndex = 1;
            this.BasicExampleCancelButton.Text = "Basic example cancel";
            this.BasicExampleCancelButton.UseVisualStyleBackColor = true;
            this.BasicExampleCancelButton.Click += new System.EventHandler(this.BasicExampleCancelButton_Click);
            // 
            // BasicExampleLabel
            // 
            this.BasicExampleLabel.AutoSize = true;
            this.BasicExampleLabel.Location = new System.Drawing.Point(411, 16);
            this.BasicExampleLabel.Name = "BasicExampleLabel";
            this.BasicExampleLabel.Size = new System.Drawing.Size(13, 15);
            this.BasicExampleLabel.TabIndex = 2;
            this.BasicExampleLabel.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(556, 235);
            this.Controls.Add(this.BasicExampleLabel);
            this.Controls.Add(this.BasicExampleCancelButton);
            this.Controls.Add(this.BasicExampleStartButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BasicExampleStartButton;
        private System.Windows.Forms.Button BasicExampleCancelButton;
        private System.Windows.Forms.Label BasicExampleLabel;
    }
}

