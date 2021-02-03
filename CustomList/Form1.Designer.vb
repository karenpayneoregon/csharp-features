<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.PopulateButton = New System.Windows.Forms.Button()
        Me.TotalButton = New System.Windows.Forms.Button()
        Me.ChangeButton = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.QuantityTextBox = New System.Windows.Forms.TextBox()
        Me.TotalLabel = New System.Windows.Forms.Label()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PopulateButton
        '
        Me.PopulateButton.Location = New System.Drawing.Point(15, 166)
        Me.PopulateButton.Name = "PopulateButton"
        Me.PopulateButton.Size = New System.Drawing.Size(166, 23)
        Me.PopulateButton.TabIndex = 0
        Me.PopulateButton.Text = "Populate with mocked data"
        Me.PopulateButton.UseVisualStyleBackColor = True
        '
        'TotalButton
        '
        Me.TotalButton.Location = New System.Drawing.Point(187, 166)
        Me.TotalButton.Name = "TotalButton"
        Me.TotalButton.Size = New System.Drawing.Size(166, 23)
        Me.TotalButton.TabIndex = 1
        Me.TotalButton.Text = "Get total"
        Me.TotalButton.UseVisualStyleBackColor = True
        '
        'ChangeButton
        '
        Me.ChangeButton.Location = New System.Drawing.Point(12, 208)
        Me.ChangeButton.Name = "ChangeButton"
        Me.ChangeButton.Size = New System.Drawing.Size(169, 23)
        Me.ChangeButton.TabIndex = 2
        Me.ChangeButton.Text = "Change first item Quantity"
        Me.ChangeButton.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(15, 10)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(464, 141)
        Me.DataGridView1.TabIndex = 3
        '
        'QuantityTextBox
        '
        Me.QuantityTextBox.Location = New System.Drawing.Point(187, 210)
        Me.QuantityTextBox.Name = "QuantityTextBox"
        Me.QuantityTextBox.Size = New System.Drawing.Size(100, 20)
        Me.QuantityTextBox.TabIndex = 4
        Me.QuantityTextBox.Text = "4"
        '
        'TotalLabel
        '
        Me.TotalLabel.AutoSize = True
        Me.TotalLabel.Location = New System.Drawing.Point(380, 170)
        Me.TotalLabel.Name = "TotalLabel"
        Me.TotalLabel.Size = New System.Drawing.Size(25, 13)
        Me.TotalLabel.TabIndex = 5
        Me.TotalLabel.Text = "000"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(495, 246)
        Me.Controls.Add(Me.TotalLabel)
        Me.Controls.Add(Me.QuantityTextBox)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.ChangeButton)
        Me.Controls.Add(Me.TotalButton)
        Me.Controls.Add(Me.PopulateButton)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Totals"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PopulateButton As Button
    Friend WithEvents TotalButton As Button
    Friend WithEvents ChangeButton As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents QuantityTextBox As TextBox
    Friend WithEvents TotalLabel As Label
End Class
