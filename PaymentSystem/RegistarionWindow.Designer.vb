<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class RegistarionWindow
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        components = New ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(RegistarionWindow))
        TableLayoutPanel1 = New TableLayoutPanel()
        TableLayoutPanel2 = New TableLayoutPanel()
        Label1 = New Label()
        TableLayoutPanel3 = New TableLayoutPanel()
        middlename_TextBox = New TextBox()
        Label4 = New Label()
        re_exit_button = New Button()
        lastname_TextBox = New TextBox()
        Id_number = New Label()
        Label3 = New Label()
        Label5 = New Label()
        firstname_TextBox = New TextBox()
        Course_ComboBox = New ComboBox()
        ID_TextBox = New TextBox()
        Label6 = New Label()
        Label2 = New Label()
        re_register_button = New Button()
        year_NumericUpDown = New NumericUpDown()
        ContextMenuStrip1 = New ContextMenuStrip(components)
        TableLayoutPanel1.SuspendLayout()
        TableLayoutPanel2.SuspendLayout()
        TableLayoutPanel3.SuspendLayout()
        CType(year_NumericUpDown, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' TableLayoutPanel1
        ' 
        TableLayoutPanel1.Anchor = AnchorStyles.None
        TableLayoutPanel1.BackColor = Color.White
        TableLayoutPanel1.ColumnCount = 1
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50F))
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50F))
        TableLayoutPanel1.Controls.Add(TableLayoutPanel2, 0, 0)
        TableLayoutPanel1.Location = New Point(63, 35)
        TableLayoutPanel1.Name = "TableLayoutPanel1"
        TableLayoutPanel1.RowCount = 1
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 50F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 50F))
        TableLayoutPanel1.Size = New Size(678, 378)
        TableLayoutPanel1.TabIndex = 1
        ' 
        ' TableLayoutPanel2
        ' 
        TableLayoutPanel2.Anchor = AnchorStyles.None
        TableLayoutPanel2.BackColor = Color.Maroon
        TableLayoutPanel2.ColumnCount = 1
        TableLayoutPanel2.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50F))
        TableLayoutPanel2.Controls.Add(Label1, 0, 0)
        TableLayoutPanel2.Controls.Add(TableLayoutPanel3, 0, 1)
        TableLayoutPanel2.Location = New Point(5, 8)
        TableLayoutPanel2.Name = "TableLayoutPanel2"
        TableLayoutPanel2.RowCount = 3
        TableLayoutPanel2.RowStyles.Add(New RowStyle(SizeType.Percent, 16.97531F))
        TableLayoutPanel2.RowStyles.Add(New RowStyle(SizeType.Percent, 83.02469F))
        TableLayoutPanel2.RowStyles.Add(New RowStyle(SizeType.Absolute, 36F))
        TableLayoutPanel2.Size = New Size(667, 361)
        TableLayoutPanel2.TabIndex = 0
        ' 
        ' Label1
        ' 
        Label1.Anchor = AnchorStyles.None
        Label1.AutoSize = True
        Label1.Font = New Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.White
        Label1.Location = New Point(254, 15)
        Label1.Name = "Label1"
        Label1.Size = New Size(158, 24)
        Label1.TabIndex = 0
        Label1.Text = "REGISTRATION"
        ' 
        ' TableLayoutPanel3
        ' 
        TableLayoutPanel3.Anchor = AnchorStyles.None
        TableLayoutPanel3.ColumnCount = 4
        TableLayoutPanel3.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 16.4901657F))
        TableLayoutPanel3.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 26.4750385F))
        TableLayoutPanel3.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 12.5567322F))
        TableLayoutPanel3.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 44.47806F))
        TableLayoutPanel3.Controls.Add(middlename_TextBox, 1, 3)
        TableLayoutPanel3.Controls.Add(Label4, 1, 4)
        TableLayoutPanel3.Controls.Add(re_exit_button, 3, 6)
        TableLayoutPanel3.Controls.Add(lastname_TextBox, 1, 5)
        TableLayoutPanel3.Controls.Add(Id_number, 3, 0)
        TableLayoutPanel3.Controls.Add(Label3, 1, 0)
        TableLayoutPanel3.Controls.Add(Label5, 1, 2)
        TableLayoutPanel3.Controls.Add(firstname_TextBox, 1, 1)
        TableLayoutPanel3.Controls.Add(Course_ComboBox, 3, 3)
        TableLayoutPanel3.Controls.Add(ID_TextBox, 3, 1)
        TableLayoutPanel3.Controls.Add(Label6, 3, 4)
        TableLayoutPanel3.Controls.Add(Label2, 3, 2)
        TableLayoutPanel3.Controls.Add(re_register_button, 1, 6)
        TableLayoutPanel3.Controls.Add(year_NumericUpDown, 3, 5)
        TableLayoutPanel3.Location = New Point(3, 58)
        TableLayoutPanel3.Name = "TableLayoutPanel3"
        TableLayoutPanel3.RowCount = 7
        TableLayoutPanel3.RowStyles.Add(New RowStyle(SizeType.Percent, 52.80899F))
        TableLayoutPanel3.RowStyles.Add(New RowStyle(SizeType.Percent, 47.19101F))
        TableLayoutPanel3.RowStyles.Add(New RowStyle(SizeType.Absolute, 27F))
        TableLayoutPanel3.RowStyles.Add(New RowStyle(SizeType.Absolute, 33F))
        TableLayoutPanel3.RowStyles.Add(New RowStyle(SizeType.Absolute, 25F))
        TableLayoutPanel3.RowStyles.Add(New RowStyle(SizeType.Absolute, 37F))
        TableLayoutPanel3.RowStyles.Add(New RowStyle(SizeType.Absolute, 64F))
        TableLayoutPanel3.Size = New Size(661, 263)
        TableLayoutPanel3.TabIndex = 1
        ' 
        ' middlename_TextBox
        ' 
        middlename_TextBox.Anchor = AnchorStyles.Left
        middlename_TextBox.Font = New Font("Times New Roman", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        middlename_TextBox.Location = New Point(112, 106)
        middlename_TextBox.Name = "middlename_TextBox"
        middlename_TextBox.Size = New Size(168, 27)
        middlename_TextBox.TabIndex = 5
        ' 
        ' Label4
        ' 
        Label4.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left
        Label4.AutoSize = True
        Label4.Font = New Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label4.ForeColor = Color.White
        Label4.Location = New Point(109, 142)
        Label4.Margin = New Padding(0, 0, 3, 0)
        Label4.Name = "Label4"
        Label4.Size = New Size(101, 19)
        Label4.TabIndex = 2
        Label4.Text = "Last Name : "
        Label4.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' re_exit_button
        ' 
        re_exit_button.Anchor = AnchorStyles.Left
        re_exit_button.BackColor = Color.White
        re_exit_button.FlatStyle = FlatStyle.System
        re_exit_button.Font = New Font("Times New Roman", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        re_exit_button.Location = New Point(370, 216)
        re_exit_button.Name = "re_exit_button"
        re_exit_button.Size = New Size(94, 29)
        re_exit_button.TabIndex = 15
        re_exit_button.Text = "Exit"
        re_exit_button.UseVisualStyleBackColor = False
        ' 
        ' lastname_TextBox
        ' 
        lastname_TextBox.Anchor = AnchorStyles.Left
        lastname_TextBox.Font = New Font("Times New Roman", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lastname_TextBox.Location = New Point(112, 166)
        lastname_TextBox.Name = "lastname_TextBox"
        lastname_TextBox.Size = New Size(168, 27)
        lastname_TextBox.TabIndex = 6
        ' 
        ' Id_number
        ' 
        Id_number.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left
        Id_number.AutoSize = True
        Id_number.Font = New Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Id_number.ForeColor = Color.White
        Id_number.Location = New Point(367, 21)
        Id_number.Margin = New Padding(0, 0, 3, 0)
        Id_number.Name = "Id_number"
        Id_number.Size = New Size(98, 19)
        Id_number.TabIndex = 0
        Id_number.Text = "ID Number :"
        Id_number.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label3
        ' 
        Label3.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left
        Label3.AutoSize = True
        Label3.Font = New Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label3.ForeColor = Color.White
        Label3.Location = New Point(109, 21)
        Label3.Margin = New Padding(0, 0, 3, 0)
        Label3.Name = "Label3"
        Label3.Size = New Size(98, 19)
        Label3.TabIndex = 1
        Label3.Text = "First Name :"
        Label3.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' Label5
        ' 
        Label5.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left
        Label5.AutoSize = True
        Label5.Font = New Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label5.ForeColor = Color.White
        Label5.Location = New Point(109, 84)
        Label5.Margin = New Padding(0, 0, 3, 0)
        Label5.Name = "Label5"
        Label5.Size = New Size(113, 19)
        Label5.TabIndex = 3
        Label5.Text = "Middle Name :"
        Label5.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' firstname_TextBox
        ' 
        firstname_TextBox.Anchor = AnchorStyles.Left
        firstname_TextBox.Font = New Font("Times New Roman", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        firstname_TextBox.Location = New Point(112, 44)
        firstname_TextBox.Name = "firstname_TextBox"
        firstname_TextBox.Size = New Size(168, 27)
        firstname_TextBox.TabIndex = 4
        ' 
        ' Course_ComboBox
        ' 
        Course_ComboBox.Anchor = AnchorStyles.Left
        Course_ComboBox.DropDownWidth = 260
        Course_ComboBox.Font = New Font("Times New Roman", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Course_ComboBox.FormattingEnabled = True
        Course_ComboBox.Items.AddRange(New Object() {"", "BA Political Science", "B Elementary Education", "B Secondary Education", "B Physical Education", "BS Public Administration", "BS Social Work", "BSBA", "BS HRM", "BS Criminology", "BS Electrical Engineering", "BS Mechanical Engineering", "BS Computer Engineering", "BS Information Technology", "BS Electrical Technology", "BS Industrial Technology", "Automotive Servicing NCII", "BS Nursing", "BS Midwifery", "Diploma in Midwifery", "BS Maritime Engineering", "BS Maritime Transportation", "PhD", "PhD CJ", "DPA", "MS Arts in Education", "MS Business Administration", "MS Public Administration", "MS Science in Criminology", "Juris Doctor", "Junior High School", "SHS - ABM", "SHS - HUMSS", "SHS - STEM", "SHS - GAS", "SHS - PBME", "SHS - ICT", "SHS - IA", "Kinder", "Elementary", "Prepatory"})
        Course_ComboBox.Location = New Point(370, 106)
        Course_ComboBox.Name = "Course_ComboBox"
        Course_ComboBox.Size = New Size(170, 27)
        Course_ComboBox.TabIndex = 13
        ' 
        ' ID_TextBox
        ' 
        ID_TextBox.Anchor = AnchorStyles.Left
        ID_TextBox.Font = New Font("Times New Roman", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        ID_TextBox.Location = New Point(370, 44)
        ID_TextBox.Name = "ID_TextBox"
        ID_TextBox.Size = New Size(170, 27)
        ID_TextBox.TabIndex = 7
        ' 
        ' Label6
        ' 
        Label6.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left
        Label6.AutoSize = True
        Label6.Font = New Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label6.ForeColor = Color.White
        Label6.Location = New Point(367, 142)
        Label6.Margin = New Padding(0, 0, 3, 0)
        Label6.Name = "Label6"
        Label6.Size = New Size(52, 19)
        Label6.TabIndex = 9
        Label6.Text = "Year :"
        Label6.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' Label2
        ' 
        Label2.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left
        Label2.AutoSize = True
        Label2.Font = New Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = Color.White
        Label2.Location = New Point(367, 84)
        Label2.Margin = New Padding(0, 0, 3, 0)
        Label2.Name = "Label2"
        Label2.Size = New Size(72, 19)
        Label2.TabIndex = 8
        Label2.Text = "Course :"
        Label2.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' re_register_button
        ' 
        re_register_button.Anchor = AnchorStyles.Right
        re_register_button.BackColor = Color.White
        re_register_button.FlatStyle = FlatStyle.System
        re_register_button.Font = New Font("Times New Roman", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        re_register_button.Location = New Point(187, 216)
        re_register_button.Name = "re_register_button"
        re_register_button.Size = New Size(94, 29)
        re_register_button.TabIndex = 14
        re_register_button.Text = "Register"
        re_register_button.UseVisualStyleBackColor = False
        ' 
        ' year_NumericUpDown
        ' 
        year_NumericUpDown.Font = New Font("Times New Roman", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        year_NumericUpDown.Location = New Point(370, 166)
        year_NumericUpDown.Margin = New Padding(3, 5, 3, 3)
        year_NumericUpDown.Maximum = New Decimal(New Integer() {20, 0, 0, 0})
        year_NumericUpDown.Name = "year_NumericUpDown"
        year_NumericUpDown.Size = New Size(67, 25)
        year_NumericUpDown.TabIndex = 12
        ' 
        ' ContextMenuStrip1
        ' 
        ContextMenuStrip1.ImageScalingSize = New Size(20, 20)
        ContextMenuStrip1.Name = "ContextMenuStrip1"
        ContextMenuStrip1.Size = New Size(61, 4)
        ' 
        ' RegistarionWindow
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.Maroon
        ClientSize = New Size(800, 450)
        Controls.Add(TableLayoutPanel1)
        FormBorderStyle = FormBorderStyle.None
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        MaximizeBox = False
        MinimizeBox = False
        Name = "RegistarionWindow"
        ShowInTaskbar = False
        StartPosition = FormStartPosition.CenterScreen
        Text = "Payment System"
        WindowState = FormWindowState.Maximized
        TableLayoutPanel1.ResumeLayout(False)
        TableLayoutPanel2.ResumeLayout(False)
        TableLayoutPanel2.PerformLayout()
        TableLayoutPanel3.ResumeLayout(False)
        TableLayoutPanel3.PerformLayout()
        CType(year_NumericUpDown, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents Label1 As Label
    Friend WithEvents TableLayoutPanel3 As TableLayoutPanel
    Friend WithEvents Id_number As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents firstname_TextBox As TextBox
    Friend WithEvents middlename_TextBox As TextBox
    Friend WithEvents lastname_TextBox As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents ID_TextBox As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents year_NumericUpDown As NumericUpDown
    Friend WithEvents Course_ComboBox As ComboBox
    Friend WithEvents re_register_button As Button
    Friend WithEvents re_exit_button As Button
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip

End Class
