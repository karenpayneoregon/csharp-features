
namespace JsonCodeSamples
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
            this.SerializeShipInfoButton = new System.Windows.Forms.Button();
            this.SerializeShipInfoListButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // SerializeShipInfoButton
            // 
            this.SerializeShipInfoButton.Location = new System.Drawing.Point(12, 12);
            this.SerializeShipInfoButton.Name = "SerializeShipInfoButton";
            this.SerializeShipInfoButton.Size = new System.Drawing.Size(152, 23);
            this.SerializeShipInfoButton.TabIndex = 0;
            this.SerializeShipInfoButton.Text = "Serialize ShipInfo";
            this.SerializeShipInfoButton.UseVisualStyleBackColor = true;
            this.SerializeShipInfoButton.Click += new System.EventHandler(this.SerializeShipInfoButton_Click);
            // 
            // SerializeShipInfoListButton
            // 
            this.SerializeShipInfoListButton.Location = new System.Drawing.Point(12, 41);
            this.SerializeShipInfoListButton.Name = "SerializeShipInfoListButton";
            this.SerializeShipInfoListButton.Size = new System.Drawing.Size(152, 23);
            this.SerializeShipInfoListButton.TabIndex = 1;
            this.SerializeShipInfoListButton.Text = "Serialize List of ShipInfo";
            this.SerializeShipInfoListButton.UseVisualStyleBackColor = true;
            this.SerializeShipInfoListButton.Click += new System.EventHandler(this.SerializeShipInfoListButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(189, 84);
            this.Controls.Add(this.SerializeShipInfoListButton);
            this.Controls.Add(this.SerializeShipInfoButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Json demos";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button SerializeShipInfoButton;
        private System.Windows.Forms.Button SerializeShipInfoListButton;
    }
}

