<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LoggedExitConfirmation
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
        Yes_Button = New Button()
        Cancel_Button = New Button()
        exir_question = New Label()
        TableLayoutPanel2 = New TableLayoutPanel()
        TableLayoutPanel1.SuspendLayout()
        TableLayoutPanel2.SuspendLayout()
        SuspendLayout()
        ' 
        ' TableLayoutPanel1
        ' 
        TableLayoutPanel1.Anchor = AnchorStyles.None
        TableLayoutPanel1.ColumnCount = 2
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50F))
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50F))
        TableLayoutPanel1.Controls.Add(Yes_Button, 0, 0)
        TableLayoutPanel1.Controls.Add(Cancel_Button, 1, 0)
        TableLayoutPanel1.Font = New Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        TableLayoutPanel1.Location = New Point(56, 141)
        TableLayoutPanel1.Margin = New Padding(4)
        TableLayoutPanel1.Name = "TableLayoutPanel1"
        TableLayoutPanel1.RowCount = 1
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 50F))
        TableLayoutPanel1.Size = New Size(195, 38)
        TableLayoutPanel1.TabIndex = 0
        ' 
        ' Yes_Button
        ' 
        Yes_Button.Anchor = AnchorStyles.None
        Yes_Button.BackColor = Color.White
        Yes_Button.Location = New Point(4, 4)
        Yes_Button.Margin = New Padding(4)
        Yes_Button.Name = "Yes_Button"
        Yes_Button.Size = New Size(89, 30)
        Yes_Button.TabIndex = 0
        Yes_Button.Text = "Yes"
        Yes_Button.UseVisualStyleBackColor = False
        ' 
        ' Cancel_Button
        ' 
        Cancel_Button.Anchor = AnchorStyles.None
        Cancel_Button.BackColor = Color.White
        Cancel_Button.ForeColor = Color.Black
        Cancel_Button.Location = New Point(101, 4)
        Cancel_Button.Margin = New Padding(4)
        Cancel_Button.Name = "Cancel_Button"
        Cancel_Button.Size = New Size(89, 30)
        Cancel_Button.TabIndex = 1
        Cancel_Button.Text = "Cancel"
        Cancel_Button.UseVisualStyleBackColor = False
        ' 
        ' exir_question
        ' 
        exir_question.Anchor = AnchorStyles.Bottom
        exir_question.AutoSize = True
        exir_question.Font = New Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        exir_question.ForeColor = Color.Gold
        exir_question.Location = New Point(15, 64)
        exir_question.Name = "exir_question"
        exir_question.Size = New Size(277, 23)
        exir_question.TabIndex = 1
        exir_question.Text = "Are you sure you want to exit?"
        ' 
        ' TableLayoutPanel2
        ' 
        TableLayoutPanel2.ColumnCount = 1
        TableLayoutPanel2.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50F))
        TableLayoutPanel2.Controls.Add(exir_question, 0, 0)
        TableLayoutPanel2.Controls.Add(TableLayoutPanel1, 0, 1)
        TableLayoutPanel2.Location = New Point(12, 12)
        TableLayoutPanel2.Name = "TableLayoutPanel2"
        TableLayoutPanel2.RowCount = 2
        TableLayoutPanel2.RowStyles.Add(New RowStyle(SizeType.Percent, 37.1794853F))
        TableLayoutPanel2.RowStyles.Add(New RowStyle(SizeType.Percent, 62.8205147F))
        TableLayoutPanel2.Size = New Size(308, 234)
        TableLayoutPanel2.TabIndex = 2
        ' 
        ' LoggedExitConfirmation
        ' 
        AcceptButton = Yes_Button
        AutoScaleDimensions = New SizeF(8F, 17F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.Maroon
        CancelButton = Cancel_Button
        ClientSize = New Size(332, 258)
        ControlBox = False
        Controls.Add(TableLayoutPanel2)
        Font = New Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        FormBorderStyle = FormBorderStyle.FixedDialog
        Margin = New Padding(4)
        MaximizeBox = False
        MdiChildrenMinimizedAnchorBottom = False
        MinimizeBox = False
        Name = "LoggedExitConfirmation"
        ShowInTaskbar = False
        StartPosition = FormStartPosition.CenterScreen
        Text = "Confirm Exit"
        TableLayoutPanel1.ResumeLayout(False)
        TableLayoutPanel2.ResumeLayout(False)
        TableLayoutPanel2.PerformLayout()
        ResumeLayout(False)

    End Sub
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents Yes_Button As System.Windows.Forms.Button
    Friend WithEvents Cancel_Button As System.Windows.Forms.Button
    Friend WithEvents exir_question As Label
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel

End Class
