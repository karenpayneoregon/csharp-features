
namespace WinControlsTest
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
            this.GetCheckBoxIdentifierButton = new System.Windows.Forms.Button();
            this.GetTextBoxIdentifierButton = new System.Windows.Forms.Button();
            this.textBoxCustom1 = new WinControls.TextBoxCustom();
            this.checkBoxCustom1 = new WinControls.CheckBoxCustom();
            this.SuspendLayout();
            // 
            // GetCheckBoxIdentifierButton
            // 
            this.GetCheckBoxIdentifierButton.Location = new System.Drawing.Point(177, 8);
            this.GetCheckBoxIdentifierButton.Name = "GetCheckBoxIdentifierButton";
            this.GetCheckBoxIdentifierButton.Size = new System.Drawing.Size(75, 23);
            this.GetCheckBoxIdentifierButton.TabIndex = 1;
            this.GetCheckBoxIdentifierButton.Text = "Get Id";
            this.GetCheckBoxIdentifierButton.UseVisualStyleBackColor = true;
            this.GetCheckBoxIdentifierButton.Click += new System.EventHandler(this.GetCheckBoxIdentifierButton_Click);
            // 
            // GetTextBoxIdentifierButton
            // 
            this.GetTextBoxIdentifierButton.Location = new System.Drawing.Point(177, 46);
            this.GetTextBoxIdentifierButton.Name = "GetTextBoxIdentifierButton";
            this.GetTextBoxIdentifierButton.Size = new System.Drawing.Size(75, 23);
            this.GetTextBoxIdentifierButton.TabIndex = 3;
            this.GetTextBoxIdentifierButton.Text = "Get Id";
            this.GetTextBoxIdentifierButton.UseVisualStyleBackColor = true;
            this.GetTextBoxIdentifierButton.Click += new System.EventHandler(this.GetTextBoxIdentifierButton_Click);
            // 
            // textBoxCustom1
            // 
            this.textBoxCustom1.Id = 20;
            this.textBoxCustom1.Location = new System.Drawing.Point(35, 46);
            this.textBoxCustom1.Name = "textBoxCustom1";
            this.textBoxCustom1.Size = new System.Drawing.Size(108, 20);
            this.textBoxCustom1.TabIndex = 2;
            // 
            // checkBoxCustom1
            // 
            this.checkBoxCustom1.AutoSize = true;
            this.checkBoxCustom1.Id = null;
            this.checkBoxCustom1.Location = new System.Drawing.Point(35, 12);
            this.checkBoxCustom1.Name = "checkBoxCustom1";
            this.checkBoxCustom1.Size = new System.Drawing.Size(115, 17);
            this.checkBoxCustom1.TabIndex = 0;
            this.checkBoxCustom1.Text = "checkBoxCustom1";
            this.checkBoxCustom1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(408, 155);
            this.Controls.Add(this.GetTextBoxIdentifierButton);
            this.Controls.Add(this.textBoxCustom1);
            this.Controls.Add(this.GetCheckBoxIdentifierButton);
            this.Controls.Add(this.checkBoxCustom1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Custom controls";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private WinControls.CheckBoxCustom checkBoxCustom1;
        private System.Windows.Forms.Button GetCheckBoxIdentifierButton;
        private WinControls.TextBoxCustom textBoxCustom1;
        private System.Windows.Forms.Button GetTextBoxIdentifierButton;
    }
}

