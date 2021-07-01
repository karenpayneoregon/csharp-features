
namespace GetStackTrace
{
    partial class Form1
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
            this.Demo1Button = new System.Windows.Forms.Button();
            this.Demo2Button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Demo1Button
            // 
            this.Demo1Button.Enabled = false;
            this.Demo1Button.Location = new System.Drawing.Point(12, 12);
            this.Demo1Button.Name = "Demo1Button";
            this.Demo1Button.Size = new System.Drawing.Size(120, 23);
            this.Demo1Button.TabIndex = 0;
            this.Demo1Button.Text = "Demo 1";
            this.Demo1Button.UseVisualStyleBackColor = true;
            this.Demo1Button.Click += new System.EventHandler(this.Demo1Button_Click);
            // 
            // Demo2Button
            // 
            this.Demo2Button.Enabled = false;
            this.Demo2Button.Location = new System.Drawing.Point(12, 41);
            this.Demo2Button.Name = "Demo2Button";
            this.Demo2Button.Size = new System.Drawing.Size(120, 23);
            this.Demo2Button.TabIndex = 1;
            this.Demo2Button.Text = "Demo 2";
            this.Demo2Button.UseVisualStyleBackColor = true;
            this.Demo2Button.Click += new System.EventHandler(this.Demo2Button_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(153, 80);
            this.Controls.Add(this.Demo2Button);
            this.Controls.Add(this.Demo1Button);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Demo";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Demo1Button;
        private System.Windows.Forms.Button Demo2Button;
    }
}

