<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PaymentConfirmation
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
        components = New ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PaymentConfirmation))
        TableLayoutPanel1 = New TableLayoutPanel()
        TableLayoutPanel2 = New TableLayoutPanel()
        TableLayoutPanel5 = New TableLayoutPanel()
        TableLayoutPanel3 = New TableLayoutPanel()
        Label1 = New Label()
        TableLayoutPanel4 = New TableLayoutPanel()
        exit_button_succ = New Button()
        print_button = New Button()
        PrintReceipt = New Printing.PrintDocument()
        systemTime = New Timer(components)
        TableLayoutPanel1.SuspendLayout()
        TableLayoutPanel2.SuspendLayout()
        TableLayoutPanel5.SuspendLayout()
        TableLayoutPanel3.SuspendLayout()
        TableLayoutPanel4.SuspendLayout()
        SuspendLayout()
        ' 
        ' TableLayoutPanel1
        ' 
        TableLayoutPanel1.Anchor = AnchorStyles.None
        TableLayoutPanel1.ColumnCount = 1
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50.5154648F))
        TableLayoutPanel1.Controls.Add(TableLayoutPanel2, 0, 0)
        TableLayoutPanel1.Location = New Point(12, 175)
        TableLayoutPanel1.Name = "TableLayoutPanel1"
        TableLayoutPanel1.RowCount = 1
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 50F))
        TableLayoutPanel1.Size = New Size(776, 463)
        TableLayoutPanel1.TabIndex = 0
        ' 
        ' TableLayoutPanel2
        ' 
        TableLayoutPanel2.Anchor = AnchorStyles.None
        TableLayoutPanel2.ColumnCount = 1
        TableLayoutPanel2.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 72.61484F))
        TableLayoutPanel2.Controls.Add(TableLayoutPanel5, 0, 0)
        TableLayoutPanel2.Location = New Point(3, 36)
        TableLayoutPanel2.Name = "TableLayoutPanel2"
        TableLayoutPanel2.RowCount = 1
        TableLayoutPanel2.RowStyles.Add(New RowStyle(SizeType.Percent, 50F))
        TableLayoutPanel2.Size = New Size(769, 391)
        TableLayoutPanel2.TabIndex = 0
        ' 
        ' TableLayoutPanel5
        ' 
        TableLayoutPanel5.ColumnCount = 1
        TableLayoutPanel5.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50F))
        TableLayoutPanel5.Controls.Add(TableLayoutPanel3, 0, 0)
        TableLayoutPanel5.Dock = DockStyle.Fill
        TableLayoutPanel5.Location = New Point(3, 3)
        TableLayoutPanel5.Name = "TableLayoutPanel5"
        TableLayoutPanel5.RowCount = 1
        TableLayoutPanel5.RowStyles.Add(New RowStyle(SizeType.Percent, 50F))
        TableLayoutPanel5.Size = New Size(763, 385)
        TableLayoutPanel5.TabIndex = 0
        ' 
        ' TableLayoutPanel3
        ' 
        TableLayoutPanel3.Anchor = AnchorStyles.None
        TableLayoutPanel3.BackColor = Color.Maroon
        TableLayoutPanel3.ColumnCount = 1
        TableLayoutPanel3.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50F))
        TableLayoutPanel3.Controls.Add(Label1, 0, 0)
        TableLayoutPanel3.Controls.Add(TableLayoutPanel4, 0, 1)
        TableLayoutPanel3.Location = New Point(194, 43)
        TableLayoutPanel3.Name = "TableLayoutPanel3"
        TableLayoutPanel3.RowCount = 2
        TableLayoutPanel3.RowStyles.Add(New RowStyle(SizeType.Percent, 36.45485F))
        TableLayoutPanel3.RowStyles.Add(New RowStyle(SizeType.Percent, 63.54515F))
        TableLayoutPanel3.Size = New Size(374, 299)
        TableLayoutPanel3.TabIndex = 3
        ' 
        ' Label1
        ' 
        Label1.Anchor = AnchorStyles.Bottom
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.Gold
        Label1.Location = New Point(85, 86)
        Label1.Name = "Label1"
        Label1.Size = New Size(204, 23)
        Label1.TabIndex = 2
        Label1.Text = "Payement Successful!"
        ' 
        ' TableLayoutPanel4
        ' 
        TableLayoutPanel4.Anchor = AnchorStyles.Top
        TableLayoutPanel4.ColumnCount = 2
        TableLayoutPanel4.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50F))
        TableLayoutPanel4.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50F))
        TableLayoutPanel4.Controls.Add(exit_button_succ, 1, 0)
        TableLayoutPanel4.Controls.Add(print_button, 0, 0)
        TableLayoutPanel4.Location = New Point(3, 112)
        TableLayoutPanel4.Name = "TableLayoutPanel4"
        TableLayoutPanel4.RowCount = 1
        TableLayoutPanel4.RowStyles.Add(New RowStyle(SizeType.Percent, 50F))
        TableLayoutPanel4.Size = New Size(368, 78)
        TableLayoutPanel4.TabIndex = 3
        ' 
        ' exit_button_succ
        ' 
        exit_button_succ.Anchor = AnchorStyles.None
        exit_button_succ.BackColor = Color.White
        exit_button_succ.FlatAppearance.BorderColor = Color.LightSkyBlue
        exit_button_succ.FlatAppearance.BorderSize = 5
        exit_button_succ.Font = New Font("Arial", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        exit_button_succ.ForeColor = SystemColors.ActiveCaptionText
        exit_button_succ.Location = New Point(207, 23)
        exit_button_succ.Name = "exit_button_succ"
        exit_button_succ.Size = New Size(137, 32)
        exit_button_succ.TabIndex = 2
        exit_button_succ.Text = "Exit"
        exit_button_succ.UseVisualStyleBackColor = False
        ' 
        ' print_button
        ' 
        print_button.Anchor = AnchorStyles.None
        print_button.BackColor = Color.White
        print_button.FlatAppearance.BorderColor = Color.LightSkyBlue
        print_button.FlatAppearance.BorderSize = 5
        print_button.Font = New Font("Arial", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        print_button.ForeColor = SystemColors.ActiveCaptionText
        print_button.Location = New Point(23, 23)
        print_button.Name = "print_button"
        print_button.Size = New Size(137, 32)
        print_button.TabIndex = 1
        print_button.Text = "Print Receipt"
        print_button.UseVisualStyleBackColor = False
        ' 
        ' PrintReceipt
        ' 
        ' 
        ' systemTime
        ' 
        systemTime.Interval = 1000
        ' 
        ' PaymentConfirmation
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.Maroon
        ClientSize = New Size(800, 800)
        ControlBox = False
        Controls.Add(TableLayoutPanel1)
        FormBorderStyle = FormBorderStyle.None
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Name = "PaymentConfirmation"
        StartPosition = FormStartPosition.CenterScreen
        Text = "PaymentConfirmation"
        WindowState = FormWindowState.Maximized
        TableLayoutPanel1.ResumeLayout(False)
        TableLayoutPanel2.ResumeLayout(False)
        TableLayoutPanel5.ResumeLayout(False)
        TableLayoutPanel3.ResumeLayout(False)
        TableLayoutPanel3.PerformLayout()
        TableLayoutPanel4.ResumeLayout(False)
        ResumeLayout(False)
    End Sub

    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents print_button As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents TableLayoutPanel3 As TableLayoutPanel
    Friend WithEvents PrintReceipt As Printing.PrintDocument
    Friend WithEvents TableLayoutPanel4 As TableLayoutPanel
    Friend WithEvents exit_button_succ As Button
    Friend WithEvents systemTime As Timer
    Friend WithEvents TableLayoutPanel5 As TableLayoutPanel
End Class
