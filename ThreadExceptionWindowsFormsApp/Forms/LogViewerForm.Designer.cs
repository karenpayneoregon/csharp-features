
namespace ThreadExceptionWindowsFormsApp.Forms
{
    partial class LogViewerForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LogViewerForm));
            this.LogListView = new System.Windows.Forms.ListView();
            this.LevelColumn = new System.Windows.Forms.ColumnHeader();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.CopyToClipboardButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LogListView
            // 
            this.LogListView.BackColor = System.Drawing.Color.Black;
            this.LogListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.LevelColumn,
            this.columnHeader1});
            this.LogListView.ForeColor = System.Drawing.Color.White;
            this.LogListView.FullRowSelect = true;
            this.LogListView.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.LogListView.HideSelection = false;
            this.LogListView.Location = new System.Drawing.Point(12, 17);
            this.LogListView.MultiSelect = false;
            this.LogListView.Name = "LogListView";
            this.LogListView.Size = new System.Drawing.Size(774, 264);
            this.LogListView.TabIndex = 0;
            this.LogListView.UseCompatibleStateImageBehavior = false;
            this.LogListView.View = System.Windows.Forms.View.Details;
            // 
            // LevelColumn
            // 
            this.LevelColumn.Name = "LevelColumn";
            this.LevelColumn.Text = "Level";
            // 
            // columnHeader1
            // 
            this.columnHeader1.Name = "columnHeader1";
            this.columnHeader1.Text = "Date/Time";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.Black;
            this.textBox1.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox1.ForeColor = System.Drawing.Color.White;
            this.textBox1.Location = new System.Drawing.Point(12, 312);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBox1.Size = new System.Drawing.Size(774, 151);
            this.textBox1.TabIndex = 1;
            this.textBox1.WordWrap = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 289);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Details";
            // 
            // CopyToClipboardButton
            // 
            this.CopyToClipboardButton.Image = ((System.Drawing.Image)(resources.GetObject("CopyToClipboardButton.Image")));
            this.CopyToClipboardButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.CopyToClipboardButton.Location = new System.Drawing.Point(12, 482);
            this.CopyToClipboardButton.Name = "CopyToClipboardButton";
            this.CopyToClipboardButton.Size = new System.Drawing.Size(150, 23);
            this.CopyToClipboardButton.TabIndex = 3;
            this.CopyToClipboardButton.Text = "Copy current";
            this.CopyToClipboardButton.UseVisualStyleBackColor = true;
            this.CopyToClipboardButton.Click += new System.EventHandler(this.CopyToClipboardButton_Click);
            // 
            // button1
            // 
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(638, 482);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(150, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Close";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // LogViewerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 526);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.CopyToClipboardButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.LogListView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "LogViewerForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Log Viewer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView LogListView;
        private System.Windows.Forms.ColumnHeader LevelColumn;
        private System.Windows.Forms.ColumnHeader DatecolumnHeader;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button CopyToClipboardButton;
        private System.Windows.Forms.Button button1;
    }
}