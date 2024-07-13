<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PasswordToExit
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
        TableLayoutPanel1 = New TableLayoutPanel()
        Cancel_Button = New Button()
        OK_Button = New Button()
        passwordtxtExit = New TextBox()
        Label1 = New Label()
        TableLayoutPanel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' TableLayoutPanel1
        ' 
        TableLayoutPanel1.Anchor = AnchorStyles.None
        TableLayoutPanel1.ColumnCount = 2
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50F))
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50F))
        TableLayoutPanel1.Controls.Add(Cancel_Button, 1, 0)
        TableLayoutPanel1.Controls.Add(OK_Button, 0, 0)
        TableLayoutPanel1.Location = New Point(30, 181)
        TableLayoutPanel1.Margin = New Padding(4, 5, 4, 5)
        TableLayoutPanel1.Name = "TableLayoutPanel1"
        TableLayoutPanel1.RowCount = 1
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 50F))
        TableLayoutPanel1.Size = New Size(275, 51)
        TableLayoutPanel1.TabIndex = 0
        ' 
        ' Cancel_Button
        ' 
        Cancel_Button.Anchor = AnchorStyles.None
        Cancel_Button.BackColor = Color.White
        Cancel_Button.Location = New Point(156, 9)
        Cancel_Button.Margin = New Padding(4, 5, 4, 5)
        Cancel_Button.Name = "Cancel_Button"
        Cancel_Button.Size = New Size(100, 33)
        Cancel_Button.TabIndex = 1
        Cancel_Button.Text = "Cancel"
        Cancel_Button.UseVisualStyleBackColor = False
        ' 
        ' OK_Button
        ' 
        OK_Button.Anchor = AnchorStyles.None
        OK_Button.BackColor = Color.White
        OK_Button.Location = New Point(18, 9)
        OK_Button.Margin = New Padding(4, 5, 4, 5)
        OK_Button.Name = "OK_Button"
        OK_Button.Size = New Size(100, 33)
        OK_Button.TabIndex = 0
        OK_Button.Text = "OK"
        OK_Button.UseVisualStyleBackColor = False
        ' 
        ' passwordtxtExit
        ' 
        passwordtxtExit.Location = New Point(44, 127)
        passwordtxtExit.Name = "passwordtxtExit"
        passwordtxtExit.PasswordChar = "*"c
        passwordtxtExit.PlaceholderText = "Password"
        passwordtxtExit.Size = New Size(250, 27)
        passwordtxtExit.TabIndex = 1
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.Gold
        Label1.Location = New Point(44, 80)
        Label1.Name = "Label1"
        Label1.Size = New Size(212, 23)
        Label1.TabIndex = 2
        Label1.Text = "Enter Password to Exit"
        ' 
        ' PasswordToExit
        ' 
        AcceptButton = OK_Button
        AutoScaleDimensions = New SizeF(9F, 19F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.Maroon
        CancelButton = Cancel_Button
        ClientSize = New Size(332, 303)
        ControlBox = False
        Controls.Add(Label1)
        Controls.Add(passwordtxtExit)
        Controls.Add(TableLayoutPanel1)
        Font = New Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        FormBorderStyle = FormBorderStyle.FixedDialog
        Margin = New Padding(4, 5, 4, 5)
        MaximizeBox = False
        MinimizeBox = False
        Name = "PasswordToExit"
        ShowInTaskbar = False
        SizeGripStyle = SizeGripStyle.Hide
        StartPosition = FormStartPosition.CenterScreen
        Text = "Exit Confirmation"
        TableLayoutPanel1.ResumeLayout(False)
        ResumeLayout(False)
        PerformLayout()

    End Sub
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents OK_Button As System.Windows.Forms.Button
    Friend WithEvents Cancel_Button As System.Windows.Forms.Button
    Friend WithEvents passwordtxtExit As TextBox
    Friend WithEvents Label1 As Label

End Class
