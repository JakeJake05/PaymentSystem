<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PaymentWindow
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PaymentWindow))
        TableLayoutPanel1 = New TableLayoutPanel()
        header = New PictureBox()
        TableLayoutPanel2 = New TableLayoutPanel()
        TableLayoutPanel8 = New TableLayoutPanel()
        info_con = New TableLayoutPanel()
        total_amount_con = New TableLayoutPanel()
        TableLayoutPanel5 = New TableLayoutPanel()
        TableLayoutPanel3 = New TableLayoutPanel()
        TextBox3 = New TextBox()
        Label7 = New Label()
        TextBox2 = New TextBox()
        Label6 = New Label()
        TableLayoutPanel12 = New TableLayoutPanel()
        Label8 = New Label()
        Label1 = New Label()
        buttons_con = New TableLayoutPanel()
        cancel_pay_button = New Button()
        confirm_button = New Button()
        note_con = New TableLayoutPanel()
        TableLayoutPanel9 = New TableLayoutPanel()
        Label5 = New Label()
        notice_lbl2 = New Label()
        notice_lbl1 = New Label()
        insertLabel = New Label()
        TableLayoutPanel4 = New TableLayoutPanel()
        Label4 = New Label()
        TableLayoutPanel6 = New TableLayoutPanel()
        TableLayoutPanel7 = New TableLayoutPanel()
        Label3 = New Label()
        TextBox1 = New TextBox()
        Label2 = New Label()
        TableLayoutPanel1.SuspendLayout()
        CType(header, ComponentModel.ISupportInitialize).BeginInit()
        TableLayoutPanel2.SuspendLayout()
        TableLayoutPanel8.SuspendLayout()
        info_con.SuspendLayout()
        total_amount_con.SuspendLayout()
        TableLayoutPanel5.SuspendLayout()
        TableLayoutPanel3.SuspendLayout()
        TableLayoutPanel12.SuspendLayout()
        buttons_con.SuspendLayout()
        note_con.SuspendLayout()
        TableLayoutPanel9.SuspendLayout()
        TableLayoutPanel4.SuspendLayout()
        TableLayoutPanel6.SuspendLayout()
        TableLayoutPanel7.SuspendLayout()
        SuspendLayout()
        ' 
        ' TableLayoutPanel1
        ' 
        TableLayoutPanel1.BackColor = Color.Maroon
        TableLayoutPanel1.ColumnCount = 1
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50F))
        TableLayoutPanel1.Controls.Add(header, 0, 0)
        TableLayoutPanel1.Controls.Add(TableLayoutPanel2, 0, 1)
        TableLayoutPanel1.Dock = DockStyle.Fill
        TableLayoutPanel1.Location = New Point(0, 0)
        TableLayoutPanel1.Margin = New Padding(0)
        TableLayoutPanel1.Name = "TableLayoutPanel1"
        TableLayoutPanel1.RowCount = 2
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 12.4444447F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 87.55556F))
        TableLayoutPanel1.Size = New Size(800, 450)
        TableLayoutPanel1.TabIndex = 0
        ' 
        ' header
        ' 
        header.Dock = DockStyle.Fill
        header.Image = My.Resources.Resources.header
        header.Location = New Point(0, 0)
        header.Margin = New Padding(0)
        header.Name = "header"
        header.Size = New Size(800, 56)
        header.SizeMode = PictureBoxSizeMode.Zoom
        header.TabIndex = 0
        header.TabStop = False
        ' 
        ' TableLayoutPanel2
        ' 
        TableLayoutPanel2.ColumnCount = 1
        TableLayoutPanel2.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50F))
        TableLayoutPanel2.Controls.Add(TableLayoutPanel8, 0, 0)
        TableLayoutPanel2.Dock = DockStyle.Fill
        TableLayoutPanel2.Location = New Point(3, 59)
        TableLayoutPanel2.Name = "TableLayoutPanel2"
        TableLayoutPanel2.RowCount = 1
        TableLayoutPanel2.RowStyles.Add(New RowStyle(SizeType.Percent, 87.62887F))
        TableLayoutPanel2.Size = New Size(794, 388)
        TableLayoutPanel2.TabIndex = 1
        ' 
        ' TableLayoutPanel8
        ' 
        TableLayoutPanel8.ColumnCount = 1
        TableLayoutPanel8.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50F))
        TableLayoutPanel8.Controls.Add(info_con, 0, 0)
        TableLayoutPanel8.Dock = DockStyle.Fill
        TableLayoutPanel8.Location = New Point(0, 0)
        TableLayoutPanel8.Margin = New Padding(0)
        TableLayoutPanel8.Name = "TableLayoutPanel8"
        TableLayoutPanel8.RowCount = 1
        TableLayoutPanel8.RowStyles.Add(New RowStyle(SizeType.Percent, 85.66879F))
        TableLayoutPanel8.Size = New Size(794, 388)
        TableLayoutPanel8.TabIndex = 3
        ' 
        ' info_con
        ' 
        info_con.Anchor = AnchorStyles.None
        info_con.BackColor = Color.Maroon
        info_con.ColumnCount = 1
        info_con.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50F))
        info_con.Controls.Add(total_amount_con, 0, 1)
        info_con.Controls.Add(buttons_con, 0, 3)
        info_con.Controls.Add(note_con, 0, 2)
        info_con.Controls.Add(TableLayoutPanel4, 0, 0)
        info_con.Location = New Point(75, 3)
        info_con.Name = "info_con"
        info_con.RowCount = 4
        info_con.RowStyles.Add(New RowStyle(SizeType.Percent, 33.91813F))
        info_con.RowStyles.Add(New RowStyle(SizeType.Percent, 66.08187F))
        info_con.RowStyles.Add(New RowStyle(SizeType.Absolute, 145F))
        info_con.RowStyles.Add(New RowStyle(SizeType.Absolute, 65F))
        info_con.Size = New Size(644, 382)
        info_con.TabIndex = 0
        ' 
        ' total_amount_con
        ' 
        total_amount_con.Anchor = AnchorStyles.None
        total_amount_con.BackColor = Color.Maroon
        total_amount_con.CellBorderStyle = TableLayoutPanelCellBorderStyle.InsetDouble
        total_amount_con.ColumnCount = 1
        total_amount_con.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50F))
        total_amount_con.Controls.Add(TableLayoutPanel5, 0, 0)
        total_amount_con.Location = New Point(58, 58)
        total_amount_con.Margin = New Padding(2, 0, 2, 0)
        total_amount_con.Name = "total_amount_con"
        total_amount_con.RowCount = 1
        total_amount_con.RowStyles.Add(New RowStyle(SizeType.Percent, 50F))
        total_amount_con.Size = New Size(527, 112)
        total_amount_con.TabIndex = 7
        ' 
        ' TableLayoutPanel5
        ' 
        TableLayoutPanel5.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left
        TableLayoutPanel5.ColumnCount = 2
        TableLayoutPanel5.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50F))
        TableLayoutPanel5.ColumnStyles.Add(New ColumnStyle(SizeType.Absolute, 372F))
        TableLayoutPanel5.Controls.Add(TableLayoutPanel3, 0, 0)
        TableLayoutPanel5.Controls.Add(TableLayoutPanel12, 0, 0)
        TableLayoutPanel5.Location = New Point(6, 6)
        TableLayoutPanel5.Name = "TableLayoutPanel5"
        TableLayoutPanel5.RowCount = 1
        TableLayoutPanel5.RowStyles.Add(New RowStyle(SizeType.Percent, 50F))
        TableLayoutPanel5.RowStyles.Add(New RowStyle(SizeType.Absolute, 20F))
        TableLayoutPanel5.Size = New Size(511, 100)
        TableLayoutPanel5.TabIndex = 5
        ' 
        ' TableLayoutPanel3
        ' 
        TableLayoutPanel3.ColumnCount = 2
        TableLayoutPanel3.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50F))
        TableLayoutPanel3.ColumnStyles.Add(New ColumnStyle(SizeType.Absolute, 343F))
        TableLayoutPanel3.Controls.Add(TextBox3, 1, 1)
        TableLayoutPanel3.Controls.Add(Label7, 0, 1)
        TableLayoutPanel3.Controls.Add(TextBox2, 1, 0)
        TableLayoutPanel3.Controls.Add(Label6, 0, 0)
        TableLayoutPanel3.Location = New Point(142, 3)
        TableLayoutPanel3.Name = "TableLayoutPanel3"
        TableLayoutPanel3.RowCount = 2
        TableLayoutPanel3.RowStyles.Add(New RowStyle(SizeType.Percent, 50F))
        TableLayoutPanel3.RowStyles.Add(New RowStyle(SizeType.Absolute, 44F))
        TableLayoutPanel3.Size = New Size(366, 94)
        TableLayoutPanel3.TabIndex = 6
        ' 
        ' TextBox3
        ' 
        TextBox3.Anchor = AnchorStyles.Left
        TextBox3.Font = New Font("Arial Narrow", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        TextBox3.Location = New Point(26, 58)
        TextBox3.Name = "TextBox3"
        TextBox3.PlaceholderText = "Total Amount"
        TextBox3.Size = New Size(236, 27)
        TextBox3.TabIndex = 3
        ' 
        ' Label7
        ' 
        Label7.Anchor = AnchorStyles.Left
        Label7.AutoSize = True
        Label7.Font = New Font("Arial", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label7.ForeColor = Color.Gold
        Label7.Location = New Point(3, 62)
        Label7.Name = "Label7"
        Label7.Size = New Size(17, 19)
        Label7.TabIndex = 2
        Label7.Text = "₱"
        ' 
        ' TextBox2
        ' 
        TextBox2.Anchor = AnchorStyles.Left
        TextBox2.Enabled = False
        TextBox2.Location = New Point(26, 11)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(236, 27)
        TextBox2.TabIndex = 0
        TextBox2.Text = "20000.00"
        ' 
        ' Label6
        ' 
        Label6.Anchor = AnchorStyles.Left
        Label6.AutoSize = True
        Label6.Font = New Font("Arial", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label6.ForeColor = Color.Gold
        Label6.Location = New Point(3, 15)
        Label6.Name = "Label6"
        Label6.Size = New Size(17, 19)
        Label6.TabIndex = 1
        Label6.Text = "₱"
        ' 
        ' TableLayoutPanel12
        ' 
        TableLayoutPanel12.ColumnCount = 1
        TableLayoutPanel12.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50F))
        TableLayoutPanel12.Controls.Add(Label8, 0, 1)
        TableLayoutPanel12.Controls.Add(Label1, 0, 0)
        TableLayoutPanel12.Location = New Point(3, 3)
        TableLayoutPanel12.Name = "TableLayoutPanel12"
        TableLayoutPanel12.RowCount = 2
        TableLayoutPanel12.RowStyles.Add(New RowStyle(SizeType.Percent, 50F))
        TableLayoutPanel12.RowStyles.Add(New RowStyle(SizeType.Absolute, 44F))
        TableLayoutPanel12.Size = New Size(133, 94)
        TableLayoutPanel12.TabIndex = 5
        ' 
        ' Label8
        ' 
        Label8.Anchor = AnchorStyles.Left
        Label8.AutoSize = True
        Label8.Font = New Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label8.ForeColor = Color.Gold
        Label8.Location = New Point(3, 62)
        Label8.Name = "Label8"
        Label8.Size = New Size(94, 19)
        Label8.TabIndex = 0
        Label8.Text = "Insert Bills: "
        ' 
        ' Label1
        ' 
        Label1.Anchor = AnchorStyles.Left
        Label1.AutoSize = True
        Label1.Font = New Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.Gold
        Label1.Location = New Point(3, 15)
        Label1.Name = "Label1"
        Label1.Size = New Size(120, 19)
        Label1.TabIndex = 0
        Label1.Text = "Total Balance : "
        ' 
        ' buttons_con
        ' 
        buttons_con.Anchor = AnchorStyles.Top
        buttons_con.ColumnCount = 2
        buttons_con.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50F))
        buttons_con.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50F))
        buttons_con.Controls.Add(cancel_pay_button, 1, 0)
        buttons_con.Controls.Add(confirm_button, 0, 0)
        buttons_con.Location = New Point(170, 319)
        buttons_con.Name = "buttons_con"
        buttons_con.RowCount = 1
        buttons_con.RowStyles.Add(New RowStyle(SizeType.Percent, 50F))
        buttons_con.Size = New Size(304, 52)
        buttons_con.TabIndex = 2
        ' 
        ' cancel_pay_button
        ' 
        cancel_pay_button.Anchor = AnchorStyles.Top
        cancel_pay_button.Font = New Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        cancel_pay_button.Location = New Point(178, 3)
        cancel_pay_button.Name = "cancel_pay_button"
        cancel_pay_button.Size = New Size(100, 32)
        cancel_pay_button.TabIndex = 1
        cancel_pay_button.Text = "Cancel"
        cancel_pay_button.UseVisualStyleBackColor = True
        ' 
        ' confirm_button
        ' 
        confirm_button.Anchor = AnchorStyles.Top
        confirm_button.Font = New Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        confirm_button.Location = New Point(26, 3)
        confirm_button.Name = "confirm_button"
        confirm_button.Size = New Size(100, 32)
        confirm_button.TabIndex = 0
        confirm_button.Text = "Confirm"
        confirm_button.UseVisualStyleBackColor = True
        ' 
        ' note_con
        ' 
        note_con.Anchor = AnchorStyles.None
        note_con.BackColor = Color.Maroon
        note_con.CellBorderStyle = TableLayoutPanelCellBorderStyle.InsetDouble
        note_con.ColumnCount = 1
        note_con.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50F))
        note_con.Controls.Add(TableLayoutPanel9, 0, 1)
        note_con.Controls.Add(insertLabel, 0, 0)
        note_con.Location = New Point(58, 176)
        note_con.Margin = New Padding(0)
        note_con.Name = "note_con"
        note_con.RowCount = 2
        note_con.RowStyles.Add(New RowStyle(SizeType.Percent, 29.4117641F))
        note_con.RowStyles.Add(New RowStyle(SizeType.Percent, 70.5882339F))
        note_con.Size = New Size(528, 135)
        note_con.TabIndex = 9
        ' 
        ' TableLayoutPanel9
        ' 
        TableLayoutPanel9.BackgroundImageLayout = ImageLayout.None
        TableLayoutPanel9.ColumnCount = 1
        TableLayoutPanel9.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50F))
        TableLayoutPanel9.Controls.Add(Label5, 0, 0)
        TableLayoutPanel9.Controls.Add(notice_lbl1, 0, 1)
        TableLayoutPanel9.Controls.Add(notice_lbl2, 0, 2)
        TableLayoutPanel9.Location = New Point(3, 43)
        TableLayoutPanel9.Margin = New Padding(0)
        TableLayoutPanel9.Name = "TableLayoutPanel9"
        TableLayoutPanel9.RowCount = 3
        TableLayoutPanel9.RowStyles.Add(New RowStyle(SizeType.Percent, 46.2962952F))
        TableLayoutPanel9.RowStyles.Add(New RowStyle(SizeType.Percent, 53.7037048F))
        TableLayoutPanel9.RowStyles.Add(New RowStyle(SizeType.Absolute, 41F))
        TableLayoutPanel9.Size = New Size(522, 89)
        TableLayoutPanel9.TabIndex = 1
        ' 
        ' Label5
        ' 
        Label5.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left
        Label5.AutoSize = True
        Label5.Font = New Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label5.ForeColor = Color.Gold
        Label5.Location = New Point(0, 3)
        Label5.Margin = New Padding(0)
        Label5.Name = "Label5"
        Label5.Size = New Size(59, 19)
        Label5.TabIndex = 0
        Label5.Text = "* Note:"
        ' 
        ' notice_lbl2
        ' 
        notice_lbl2.AutoSize = True
        notice_lbl2.BackColor = Color.Transparent
        notice_lbl2.Font = New Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        notice_lbl2.ForeColor = Color.Gold
        notice_lbl2.Location = New Point(0, 47)
        notice_lbl2.Margin = New Padding(0)
        notice_lbl2.Name = "notice_lbl2"
        notice_lbl2.Size = New Size(254, 17)
        notice_lbl2.TabIndex = 2
        notice_lbl2.Text = "1000's , 500's, 200's, 100's, 50's, 20's" & vbCrLf
        ' 
        ' notice_lbl1
        ' 
        notice_lbl1.Anchor = AnchorStyles.Left
        notice_lbl1.AutoSize = True
        notice_lbl1.Font = New Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        notice_lbl1.ForeColor = Color.Gold
        notice_lbl1.Location = New Point(0, 25)
        notice_lbl1.Margin = New Padding(0)
        notice_lbl1.Name = "notice_lbl1"
        notice_lbl1.Size = New Size(431, 19)
        notice_lbl1.TabIndex = 1
        notice_lbl1.Text = "Payment should be made in denomination of bills such as:"
        ' 
        ' insertLabel
        ' 
        insertLabel.Anchor = AnchorStyles.None
        insertLabel.AutoSize = True
        insertLabel.Font = New Font("Arial", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        insertLabel.ForeColor = Color.Gold
        insertLabel.Location = New Point(141, 12)
        insertLabel.Name = "insertLabel"
        insertLabel.Size = New Size(245, 19)
        insertLabel.TabIndex = 2
        insertLabel.Text = "Insert Bills in the Bill Acceptor"
        ' 
        ' TableLayoutPanel4
        ' 
        TableLayoutPanel4.Anchor = AnchorStyles.None
        TableLayoutPanel4.BackColor = Color.Maroon
        TableLayoutPanel4.CellBorderStyle = TableLayoutPanelCellBorderStyle.InsetDouble
        TableLayoutPanel4.ColumnCount = 1
        TableLayoutPanel4.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50F))
        TableLayoutPanel4.Controls.Add(Label4, 0, 0)
        TableLayoutPanel4.Location = New Point(58, 5)
        TableLayoutPanel4.Margin = New Padding(0)
        TableLayoutPanel4.Name = "TableLayoutPanel4"
        TableLayoutPanel4.RowCount = 1
        TableLayoutPanel4.RowStyles.Add(New RowStyle(SizeType.Percent, 50F))
        TableLayoutPanel4.Size = New Size(528, 47)
        TableLayoutPanel4.TabIndex = 10
        ' 
        ' Label4
        ' 
        Label4.Anchor = AnchorStyles.None
        Label4.AutoSize = True
        Label4.Font = New Font("Arial Narrow", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label4.ForeColor = Color.Gold
        Label4.Location = New Point(205, 6)
        Label4.Name = "Label4"
        Label4.Size = New Size(118, 35)
        Label4.TabIndex = 8
        Label4.Text = "Payment"
        ' 
        ' TableLayoutPanel6
        ' 
        TableLayoutPanel6.ColumnCount = 2
        TableLayoutPanel6.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50F))
        TableLayoutPanel6.ColumnStyles.Add(New ColumnStyle(SizeType.Absolute, 383F))
        TableLayoutPanel6.Controls.Add(TableLayoutPanel7, 1, 0)
        TableLayoutPanel6.Location = New Point(0, 0)
        TableLayoutPanel6.Name = "TableLayoutPanel6"
        TableLayoutPanel6.RowCount = 1
        TableLayoutPanel6.RowStyles.Add(New RowStyle(SizeType.Absolute, 20F))
        TableLayoutPanel6.Size = New Size(200, 100)
        TableLayoutPanel6.TabIndex = 0
        ' 
        ' TableLayoutPanel7
        ' 
        TableLayoutPanel7.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left
        TableLayoutPanel7.ColumnCount = 2
        TableLayoutPanel7.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 7.908163F))
        TableLayoutPanel7.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 92.091835F))
        TableLayoutPanel7.Controls.Add(Label3, 0, 0)
        TableLayoutPanel7.Controls.Add(TextBox1, 1, 0)
        TableLayoutPanel7.Location = New Point(-180, 64)
        TableLayoutPanel7.Name = "TableLayoutPanel7"
        TableLayoutPanel7.RowCount = 1
        TableLayoutPanel7.RowStyles.Add(New RowStyle(SizeType.Percent, 50F))
        TableLayoutPanel7.Size = New Size(377, 33)
        TableLayoutPanel7.TabIndex = 2
        ' 
        ' Label3
        ' 
        Label3.Anchor = AnchorStyles.Left
        Label3.AutoSize = True
        Label3.Font = New Font("Arial", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.ForeColor = Color.Gold
        Label3.Location = New Point(5, 7)
        Label3.Margin = New Padding(5, 0, 0, 0)
        Label3.Name = "Label3"
        Label3.Size = New Size(20, 19)
        Label3.TabIndex = 2
        Label3.Text = "₱"
        ' 
        ' TextBox1
        ' 
        TextBox1.Anchor = AnchorStyles.Left
        TextBox1.Font = New Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        TextBox1.Location = New Point(32, 3)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(212, 27)
        TextBox1.TabIndex = 3
        ' 
        ' Label2
        ' 
        Label2.Anchor = AnchorStyles.Left
        Label2.AutoSize = True
        Label2.Font = New Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = Color.Gold
        Label2.Location = New Point(3, 40)
        Label2.Name = "Label2"
        Label2.Size = New Size(1, 19)
        Label2.TabIndex = 3
        Label2.Text = "Enter Amount :"
        ' 
        ' PaymentWindow
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.Maroon
        ClientSize = New Size(800, 450)
        ControlBox = False
        Controls.Add(TableLayoutPanel1)
        FormBorderStyle = FormBorderStyle.None
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Name = "PaymentWindow"
        StartPosition = FormStartPosition.CenterScreen
        Text = "PaymentWindow"
        WindowState = FormWindowState.Maximized
        TableLayoutPanel1.ResumeLayout(False)
        CType(header, ComponentModel.ISupportInitialize).EndInit()
        TableLayoutPanel2.ResumeLayout(False)
        TableLayoutPanel8.ResumeLayout(False)
        info_con.ResumeLayout(False)
        total_amount_con.ResumeLayout(False)
        TableLayoutPanel5.ResumeLayout(False)
        TableLayoutPanel3.ResumeLayout(False)
        TableLayoutPanel3.PerformLayout()
        TableLayoutPanel12.ResumeLayout(False)
        TableLayoutPanel12.PerformLayout()
        buttons_con.ResumeLayout(False)
        note_con.ResumeLayout(False)
        note_con.PerformLayout()
        TableLayoutPanel9.ResumeLayout(False)
        TableLayoutPanel9.PerformLayout()
        TableLayoutPanel4.ResumeLayout(False)
        TableLayoutPanel4.PerformLayout()
        TableLayoutPanel6.ResumeLayout(False)
        TableLayoutPanel7.ResumeLayout(False)
        TableLayoutPanel7.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents header As PictureBox
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents info_con As TableLayoutPanel
    Friend WithEvents TableLayoutPanel5 As TableLayoutPanel
    Friend WithEvents total_amount_con As TableLayoutPanel
    Friend WithEvents Button1 As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents note_con As TableLayoutPanel
    Friend WithEvents Label5 As Label
    Friend WithEvents TableLayoutPanel9 As TableLayoutPanel
    Friend WithEvents notice_lbl1 As Label
    Friend WithEvents notice_lbl2 As Label
    Friend WithEvents TableLayoutPanel4 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel8 As TableLayoutPanel
    Friend WithEvents buttons_con As TableLayoutPanel
    Friend WithEvents cancel_pay_button As Button
    Friend WithEvents confirm_button As Button
    Friend WithEvents TableLayoutPanel6 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel7 As TableLayoutPanel
    Friend WithEvents Label3 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents TableLayoutPanel12 As TableLayoutPanel
    Friend WithEvents Label8 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents TableLayoutPanel3 As TableLayoutPanel
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents insertLabel As Label
End Class
