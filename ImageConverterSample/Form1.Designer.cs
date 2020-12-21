
namespace ImageConverterSample
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
            this.Agent1PictureBox = new System.Windows.Forms.PictureBox();
            this.cSharpPictureBox = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.ExcelPictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Agent1PictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cSharpPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ExcelPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // Agent1PictureBox
            // 
            this.Agent1PictureBox.Location = new System.Drawing.Point(22, 35);
            this.Agent1PictureBox.Name = "Agent1PictureBox";
            this.Agent1PictureBox.Size = new System.Drawing.Size(48, 42);
            this.Agent1PictureBox.TabIndex = 1;
            this.Agent1PictureBox.TabStop = false;
            // 
            // cSharpPictureBox
            // 
            this.cSharpPictureBox.Location = new System.Drawing.Point(101, 34);
            this.cSharpPictureBox.Name = "cSharpPictureBox";
            this.cSharpPictureBox.Size = new System.Drawing.Size(48, 42);
            this.cSharpPictureBox.TabIndex = 2;
            this.cSharpPictureBox.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "Agent";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(101, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(22, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "C#";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(193, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "Excel";
            // 
            // ExcelPictureBox
            // 
            this.ExcelPictureBox.Location = new System.Drawing.Point(193, 40);
            this.ExcelPictureBox.Name = "ExcelPictureBox";
            this.ExcelPictureBox.Size = new System.Drawing.Size(48, 23);
            this.ExcelPictureBox.TabIndex = 5;
            this.ExcelPictureBox.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(266, 94);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ExcelPictureBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cSharpPictureBox);
            this.Controls.Add(this.Agent1PictureBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Convert icon to bmp";
            ((System.ComponentModel.ISupportInitialize)(this.Agent1PictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cSharpPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ExcelPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox Agent1PictureBox;
        private System.Windows.Forms.PictureBox cSharpPictureBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox ExcelPictureBox;
    }
}

