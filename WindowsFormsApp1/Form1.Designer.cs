
namespace WindowsFormsApp1
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
            this.FruitComboBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // FruitComboBox
            // 
            this.FruitComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.FruitComboBox.FormattingEnabled = true;
            this.FruitComboBox.Location = new System.Drawing.Point(17, 32);
            this.FruitComboBox.Name = "FruitComboBox";
            this.FruitComboBox.Size = new System.Drawing.Size(170, 21);
            this.FruitComboBox.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(237, 105);
            this.Controls.Add(this.FruitComboBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox FruitComboBox;
    }
}

