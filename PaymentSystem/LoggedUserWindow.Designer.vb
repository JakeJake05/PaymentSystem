<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LoggedUserWindow
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(LoggedUserWindow))
        TableLayoutPanel1 = New TableLayoutPanel()
        TableLayoutPanel2 = New TableLayoutPanel()
        TableLayoutPanel3 = New TableLayoutPanel()
        TableLayoutPanel9 = New TableLayoutPanel()
        LU_exit_button = New Button()
        LU_pay_button = New Button()
        firstname_idno_container = New TableLayoutPanel()
        firstname_idno_tablegrid_front = New TableLayoutPanel()
        first_name = New Label()
        firstname_idno_mid = New TableLayoutPanel()
        TableLayoutPanel8 = New TableLayoutPanel()
        id_no_label = New Label()
        id_num_diplay = New Label()
        TableLayoutPanel4 = New TableLayoutPanel()
        TableLayoutPanel5 = New TableLayoutPanel()
        balance_label = New Label()
        TableLayoutPanel6 = New TableLayoutPanel()
        currency_display = New Label()
        balance_display = New Label()
        course_display = New Label()
        logocontainer_main = New TableLayoutPanel()
        ucv_logo = New PictureBox()
        TableLayoutPanel10 = New TableLayoutPanel()
        coe_logo = New PictureBox()
        icpepLogo = New PictureBox()
        TableLayoutPanel1.SuspendLayout()
        TableLayoutPanel2.SuspendLayout()
        TableLayoutPanel3.SuspendLayout()
        TableLayoutPanel9.SuspendLayout()
        firstname_idno_container.SuspendLayout()
        firstname_idno_tablegrid_front.SuspendLayout()
        TableLayoutPanel8.SuspendLayout()
        TableLayoutPanel4.SuspendLayout()
        TableLayoutPanel5.SuspendLayout()
        TableLayoutPanel6.SuspendLayout()
        logocontainer_main.SuspendLayout()
        CType(ucv_logo, ComponentModel.ISupportInitialize).BeginInit()
        TableLayoutPanel10.SuspendLayout()
        CType(coe_logo, ComponentModel.ISupportInitialize).BeginInit()
        CType(icpepLogo, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' TableLayoutPanel1
        ' 
        TableLayoutPanel1.Anchor = AnchorStyles.None
        TableLayoutPanel1.BackColor = Color.White
        TableLayoutPanel1.ColumnCount = 1
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50F))
        TableLayoutPanel1.Controls.Add(TableLayoutPanel2, 0, 0)
        TableLayoutPanel1.Location = New Point(33, 21)
        TableLayoutPanel1.Name = "TableLayoutPanel1"
        TableLayoutPanel1.RowCount = 1
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 50F))
        TableLayoutPanel1.Size = New Size(776, 426)
        TableLayoutPanel1.TabIndex = 0
        ' 
        ' TableLayoutPanel2
        ' 
        TableLayoutPanel2.Anchor = AnchorStyles.None
        TableLayoutPanel2.BackColor = Color.Maroon
        TableLayoutPanel2.ColumnCount = 2
        TableLayoutPanel2.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50F))
        TableLayoutPanel2.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50F))
        TableLayoutPanel2.Controls.Add(TableLayoutPanel3, 0, 0)
        TableLayoutPanel2.Controls.Add(logocontainer_main, 1, 0)
        TableLayoutPanel2.Location = New Point(3, 3)
        TableLayoutPanel2.Name = "TableLayoutPanel2"
        TableLayoutPanel2.RowCount = 1
        TableLayoutPanel2.RowStyles.Add(New RowStyle(SizeType.Percent, 50F))
        TableLayoutPanel2.Size = New Size(770, 420)
        TableLayoutPanel2.TabIndex = 0
        ' 
        ' TableLayoutPanel3
        ' 
        TableLayoutPanel3.Anchor = AnchorStyles.None
        TableLayoutPanel3.BackColor = Color.Teal
        TableLayoutPanel3.ColumnCount = 1
        TableLayoutPanel3.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50F))
        TableLayoutPanel3.Controls.Add(TableLayoutPanel9, 0, 2)
        TableLayoutPanel3.Controls.Add(firstname_idno_container, 0, 0)
        TableLayoutPanel3.Controls.Add(TableLayoutPanel4, 0, 1)
        TableLayoutPanel3.Location = New Point(14, 24)
        TableLayoutPanel3.Name = "TableLayoutPanel3"
        TableLayoutPanel3.RowCount = 3
        TableLayoutPanel3.RowStyles.Add(New RowStyle(SizeType.Percent, 28.15126F))
        TableLayoutPanel3.RowStyles.Add(New RowStyle(SizeType.Percent, 71.84874F))
        TableLayoutPanel3.RowStyles.Add(New RowStyle(SizeType.Absolute, 142F))
        TableLayoutPanel3.Size = New Size(357, 372)
        TableLayoutPanel3.TabIndex = 0
        ' 
        ' TableLayoutPanel9
        ' 
        TableLayoutPanel9.Anchor = AnchorStyles.None
        TableLayoutPanel9.BackColor = Color.Maroon
        TableLayoutPanel9.ColumnCount = 2
        TableLayoutPanel9.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50F))
        TableLayoutPanel9.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50F))
        TableLayoutPanel9.Controls.Add(LU_exit_button, 1, 0)
        TableLayoutPanel9.Controls.Add(LU_pay_button, 0, 0)
        TableLayoutPanel9.Location = New Point(3, 229)
        TableLayoutPanel9.Margin = New Padding(3, 0, 3, 5)
        TableLayoutPanel9.Name = "TableLayoutPanel9"
        TableLayoutPanel9.RowCount = 1
        TableLayoutPanel9.RowStyles.Add(New RowStyle(SizeType.Percent, 50F))
        TableLayoutPanel9.Size = New Size(351, 138)
        TableLayoutPanel9.TabIndex = 3
        ' 
        ' LU_exit_button
        ' 
        LU_exit_button.Anchor = AnchorStyles.None
        LU_exit_button.BackColor = Color.Teal
        LU_exit_button.FlatStyle = FlatStyle.System
        LU_exit_button.Font = New Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        LU_exit_button.ForeColor = Color.Gold
        LU_exit_button.Location = New Point(220, 50)
        LU_exit_button.Name = "LU_exit_button"
        LU_exit_button.Size = New Size(85, 37)
        LU_exit_button.TabIndex = 1
        LU_exit_button.Text = "Exit"
        LU_exit_button.UseVisualStyleBackColor = False
        ' 
        ' LU_pay_button
        ' 
        LU_pay_button.Anchor = AnchorStyles.None
        LU_pay_button.BackColor = Color.Teal
        LU_pay_button.FlatStyle = FlatStyle.System
        LU_pay_button.Font = New Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        LU_pay_button.ForeColor = Color.Gold
        LU_pay_button.Location = New Point(45, 50)
        LU_pay_button.Name = "LU_pay_button"
        LU_pay_button.Size = New Size(85, 37)
        LU_pay_button.TabIndex = 0
        LU_pay_button.Text = "Pay Now"
        LU_pay_button.UseVisualStyleBackColor = False
        ' 
        ' firstname_idno_container
        ' 
        firstname_idno_container.Anchor = AnchorStyles.None
        firstname_idno_container.BackColor = Color.Teal
        firstname_idno_container.ColumnCount = 1
        firstname_idno_container.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50F))
        firstname_idno_container.Controls.Add(firstname_idno_tablegrid_front, 0, 0)
        firstname_idno_container.ForeColor = SystemColors.Desktop
        firstname_idno_container.Location = New Point(1, 0)
        firstname_idno_container.Margin = New Padding(0)
        firstname_idno_container.Name = "firstname_idno_container"
        firstname_idno_container.RowCount = 1
        firstname_idno_container.RowStyles.Add(New RowStyle(SizeType.Percent, 50F))
        firstname_idno_container.Size = New Size(354, 63)
        firstname_idno_container.TabIndex = 4
        ' 
        ' firstname_idno_tablegrid_front
        ' 
        firstname_idno_tablegrid_front.Anchor = AnchorStyles.None
        firstname_idno_tablegrid_front.BackColor = Color.Maroon
        firstname_idno_tablegrid_front.ColumnCount = 3
        firstname_idno_tablegrid_front.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 93.37016F))
        firstname_idno_tablegrid_front.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 6.629834F))
        firstname_idno_tablegrid_front.ColumnStyles.Add(New ColumnStyle(SizeType.Absolute, 166F))
        firstname_idno_tablegrid_front.Controls.Add(first_name, 0, 0)
        firstname_idno_tablegrid_front.Controls.Add(firstname_idno_mid, 1, 0)
        firstname_idno_tablegrid_front.Controls.Add(TableLayoutPanel8, 2, 0)
        firstname_idno_tablegrid_front.ForeColor = Color.Gold
        firstname_idno_tablegrid_front.Location = New Point(2, 3)
        firstname_idno_tablegrid_front.Margin = New Padding(0, 3, 0, 3)
        firstname_idno_tablegrid_front.Name = "firstname_idno_tablegrid_front"
        firstname_idno_tablegrid_front.RowCount = 1
        firstname_idno_tablegrid_front.RowStyles.Add(New RowStyle(SizeType.Percent, 50F))
        firstname_idno_tablegrid_front.Size = New Size(350, 57)
        firstname_idno_tablegrid_front.TabIndex = 2
        ' 
        ' first_name
        ' 
        first_name.Anchor = AnchorStyles.Left
        first_name.AutoSize = True
        first_name.BackColor = Color.Transparent
        first_name.Font = New Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        first_name.Location = New Point(3, 16)
        first_name.Name = "first_name"
        first_name.Size = New Size(97, 24)
        first_name.TabIndex = 0
        first_name.Text = "Mary Joy"
        ' 
        ' firstname_idno_mid
        ' 
        firstname_idno_mid.Anchor = AnchorStyles.None
        firstname_idno_mid.BackColor = Color.Teal
        firstname_idno_mid.ColumnCount = 2
        firstname_idno_mid.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50F))
        firstname_idno_mid.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50F))
        firstname_idno_mid.Location = New Point(175, 2)
        firstname_idno_mid.Margin = New Padding(0)
        firstname_idno_mid.Name = "firstname_idno_mid"
        firstname_idno_mid.RowCount = 2
        firstname_idno_mid.RowStyles.Add(New RowStyle(SizeType.Percent, 50F))
        firstname_idno_mid.RowStyles.Add(New RowStyle(SizeType.Percent, 50F))
        firstname_idno_mid.Size = New Size(3, 53)
        firstname_idno_mid.TabIndex = 2
        ' 
        ' TableLayoutPanel8
        ' 
        TableLayoutPanel8.Anchor = AnchorStyles.Left
        TableLayoutPanel8.BackColor = Color.Maroon
        TableLayoutPanel8.ColumnCount = 2
        TableLayoutPanel8.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 33.54037F))
        TableLayoutPanel8.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 66.4596252F))
        TableLayoutPanel8.Controls.Add(id_no_label, 0, 0)
        TableLayoutPanel8.Controls.Add(id_num_diplay, 1, 0)
        TableLayoutPanel8.ForeColor = Color.Gold
        TableLayoutPanel8.Location = New Point(186, 5)
        TableLayoutPanel8.Name = "TableLayoutPanel8"
        TableLayoutPanel8.RowCount = 1
        TableLayoutPanel8.RowStyles.Add(New RowStyle(SizeType.Percent, 50F))
        TableLayoutPanel8.Size = New Size(161, 47)
        TableLayoutPanel8.TabIndex = 1
        ' 
        ' id_no_label
        ' 
        id_no_label.Anchor = AnchorStyles.Left
        id_no_label.AutoSize = True
        id_no_label.Font = New Font("Arial", 7.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        id_no_label.Location = New Point(3, 15)
        id_no_label.Name = "id_no_label"
        id_no_label.Size = New Size(47, 16)
        id_no_label.TabIndex = 0
        id_no_label.Text = "ID No : "
        ' 
        ' id_num_diplay
        ' 
        id_num_diplay.Anchor = AnchorStyles.Left
        id_num_diplay.AutoSize = True
        id_num_diplay.Font = New Font("Arial", 7.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        id_num_diplay.Location = New Point(53, 15)
        id_num_diplay.Margin = New Padding(0, 0, 3, 0)
        id_num_diplay.Name = "id_num_diplay"
        id_num_diplay.Size = New Size(69, 16)
        id_num_diplay.TabIndex = 1
        id_num_diplay.Text = "202011586"
        ' 
        ' TableLayoutPanel4
        ' 
        TableLayoutPanel4.Anchor = AnchorStyles.None
        TableLayoutPanel4.BackColor = Color.Maroon
        TableLayoutPanel4.ColumnCount = 1
        TableLayoutPanel4.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50F))
        TableLayoutPanel4.Controls.Add(TableLayoutPanel5, 0, 1)
        TableLayoutPanel4.Controls.Add(course_display, 0, 0)
        TableLayoutPanel4.Location = New Point(3, 64)
        TableLayoutPanel4.Margin = New Padding(3, 0, 3, 2)
        TableLayoutPanel4.Name = "TableLayoutPanel4"
        TableLayoutPanel4.RowCount = 2
        TableLayoutPanel4.RowStyles.Add(New RowStyle(SizeType.Percent, 32.727272F))
        TableLayoutPanel4.RowStyles.Add(New RowStyle(SizeType.Percent, 67.27273F))
        TableLayoutPanel4.Size = New Size(351, 163)
        TableLayoutPanel4.TabIndex = 1
        ' 
        ' TableLayoutPanel5
        ' 
        TableLayoutPanel5.Anchor = AnchorStyles.None
        TableLayoutPanel5.BackColor = Color.DarkGray
        TableLayoutPanel5.ColumnCount = 1
        TableLayoutPanel5.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50F))
        TableLayoutPanel5.Controls.Add(balance_label, 0, 0)
        TableLayoutPanel5.Controls.Add(TableLayoutPanel6, 0, 1)
        TableLayoutPanel5.ForeColor = Color.Gold
        TableLayoutPanel5.Location = New Point(6, 68)
        TableLayoutPanel5.Name = "TableLayoutPanel5"
        TableLayoutPanel5.RowCount = 2
        TableLayoutPanel5.RowStyles.Add(New RowStyle(SizeType.Percent, 44.3038F))
        TableLayoutPanel5.RowStyles.Add(New RowStyle(SizeType.Percent, 55.6962F))
        TableLayoutPanel5.Size = New Size(338, 79)
        TableLayoutPanel5.TabIndex = 1
        ' 
        ' balance_label
        ' 
        balance_label.Anchor = AnchorStyles.Left
        balance_label.AutoSize = True
        balance_label.Font = New Font("Arial Narrow", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        balance_label.ForeColor = Color.Black
        balance_label.Location = New Point(3, 6)
        balance_label.Name = "balance_label"
        balance_label.Size = New Size(74, 22)
        balance_label.TabIndex = 0
        balance_label.Text = "Balance :"
        ' 
        ' TableLayoutPanel6
        ' 
        TableLayoutPanel6.Anchor = AnchorStyles.None
        TableLayoutPanel6.BackColor = Color.Silver
        TableLayoutPanel6.ColumnCount = 2
        TableLayoutPanel6.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 9.638555F))
        TableLayoutPanel6.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 90.36144F))
        TableLayoutPanel6.Controls.Add(currency_display, 0, 0)
        TableLayoutPanel6.Controls.Add(balance_display, 1, 0)
        TableLayoutPanel6.Location = New Point(3, 39)
        TableLayoutPanel6.Name = "TableLayoutPanel6"
        TableLayoutPanel6.RowCount = 1
        TableLayoutPanel6.RowStyles.Add(New RowStyle(SizeType.Percent, 50F))
        TableLayoutPanel6.Size = New Size(332, 36)
        TableLayoutPanel6.TabIndex = 1
        ' 
        ' currency_display
        ' 
        currency_display.Anchor = AnchorStyles.Left
        currency_display.AutoSize = True
        currency_display.Font = New Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        currency_display.ForeColor = Color.Black
        currency_display.Location = New Point(7, 9)
        currency_display.Margin = New Padding(7, 0, 3, 0)
        currency_display.Name = "currency_display"
        currency_display.Size = New Size(18, 18)
        currency_display.TabIndex = 1
        currency_display.Text = "₱"
        ' 
        ' balance_display
        ' 
        balance_display.Anchor = AnchorStyles.Left
        balance_display.AutoSize = True
        balance_display.Font = New Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        balance_display.ForeColor = Color.Black
        balance_display.Location = New Point(35, 9)
        balance_display.Name = "balance_display"
        balance_display.Size = New Size(68, 17)
        balance_display.TabIndex = 2
        balance_display.Text = "20000.00"
        ' 
        ' course_display
        ' 
        course_display.Anchor = AnchorStyles.Left
        course_display.AutoSize = True
        course_display.BackColor = Color.Transparent
        course_display.Font = New Font("Arial", 7.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        course_display.ForeColor = Color.Gold
        course_display.Location = New Point(3, 18)
        course_display.Name = "course_display"
        course_display.Size = New Size(172, 16)
        course_display.TabIndex = 2
        course_display.Text = "BS Computer Engineering"
        ' 
        ' logocontainer_main
        ' 
        logocontainer_main.Anchor = AnchorStyles.None
        logocontainer_main.BackColor = Color.Silver
        logocontainer_main.ColumnCount = 1
        logocontainer_main.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50F))
        logocontainer_main.Controls.Add(ucv_logo, 0, 1)
        logocontainer_main.Controls.Add(TableLayoutPanel10, 0, 0)
        logocontainer_main.Location = New Point(403, 40)
        logocontainer_main.Name = "logocontainer_main"
        logocontainer_main.RowCount = 2
        logocontainer_main.RowStyles.Add(New RowStyle(SizeType.Percent, 50F))
        logocontainer_main.RowStyles.Add(New RowStyle(SizeType.Percent, 50F))
        logocontainer_main.Size = New Size(348, 340)
        logocontainer_main.TabIndex = 1
        ' 
        ' ucv_logo
        ' 
        ucv_logo.Anchor = AnchorStyles.None
        ucv_logo.BackColor = Color.Silver
        ucv_logo.Image = My.Resources.Resources.ucvlogo
        ucv_logo.Location = New Point(3, 173)
        ucv_logo.Name = "ucv_logo"
        ucv_logo.Size = New Size(342, 164)
        ucv_logo.SizeMode = PictureBoxSizeMode.Zoom
        ucv_logo.TabIndex = 1
        ucv_logo.TabStop = False
        ' 
        ' TableLayoutPanel10
        ' 
        TableLayoutPanel10.Anchor = AnchorStyles.None
        TableLayoutPanel10.ColumnCount = 2
        TableLayoutPanel10.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50F))
        TableLayoutPanel10.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50F))
        TableLayoutPanel10.Controls.Add(coe_logo, 1, 0)
        TableLayoutPanel10.Controls.Add(icpepLogo, 0, 0)
        TableLayoutPanel10.Location = New Point(0, 0)
        TableLayoutPanel10.Margin = New Padding(0)
        TableLayoutPanel10.Name = "TableLayoutPanel10"
        TableLayoutPanel10.RowCount = 1
        TableLayoutPanel10.RowStyles.Add(New RowStyle(SizeType.Percent, 50F))
        TableLayoutPanel10.Size = New Size(348, 170)
        TableLayoutPanel10.TabIndex = 2
        ' 
        ' coe_logo
        ' 
        coe_logo.Anchor = AnchorStyles.None
        coe_logo.Image = My.Resources.Resources.coelogo
        coe_logo.Location = New Point(177, 3)
        coe_logo.Name = "coe_logo"
        coe_logo.Size = New Size(168, 164)
        coe_logo.SizeMode = PictureBoxSizeMode.Zoom
        coe_logo.TabIndex = 1
        coe_logo.TabStop = False
        ' 
        ' icpepLogo
        ' 
        icpepLogo.Anchor = AnchorStyles.None
        icpepLogo.Image = My.Resources.Resources.icpeplogo
        icpepLogo.Location = New Point(3, 3)
        icpepLogo.Name = "icpepLogo"
        icpepLogo.Size = New Size(168, 164)
        icpepLogo.SizeMode = PictureBoxSizeMode.Zoom
        icpepLogo.TabIndex = 0
        icpepLogo.TabStop = False
        ' 
        ' LoggedUserWindow
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.Maroon
        ClientSize = New Size(838, 466)
        Controls.Add(TableLayoutPanel1)
        FormBorderStyle = FormBorderStyle.None
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Name = "LoggedUserWindow"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Payment System"
        WindowState = FormWindowState.Maximized
        TableLayoutPanel1.ResumeLayout(False)
        TableLayoutPanel2.ResumeLayout(False)
        TableLayoutPanel3.ResumeLayout(False)
        TableLayoutPanel9.ResumeLayout(False)
        firstname_idno_container.ResumeLayout(False)
        firstname_idno_tablegrid_front.ResumeLayout(False)
        firstname_idno_tablegrid_front.PerformLayout()
        TableLayoutPanel8.ResumeLayout(False)
        TableLayoutPanel8.PerformLayout()
        TableLayoutPanel4.ResumeLayout(False)
        TableLayoutPanel4.PerformLayout()
        TableLayoutPanel5.ResumeLayout(False)
        TableLayoutPanel5.PerformLayout()
        TableLayoutPanel6.ResumeLayout(False)
        TableLayoutPanel6.PerformLayout()
        logocontainer_main.ResumeLayout(False)
        CType(ucv_logo, ComponentModel.ISupportInitialize).EndInit()
        TableLayoutPanel10.ResumeLayout(False)
        CType(coe_logo, ComponentModel.ISupportInitialize).EndInit()
        CType(icpepLogo, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel3 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel9 As TableLayoutPanel
    Friend WithEvents LU_exit_button As Button
    Friend WithEvents LU_pay_button As Button
    Friend WithEvents firstname_idno_container As TableLayoutPanel
    Friend WithEvents firstname_idno_tablegrid_front As TableLayoutPanel
    Friend WithEvents first_name As Label
    Friend WithEvents firstname_idno_mid As TableLayoutPanel
    Friend WithEvents TableLayoutPanel8 As TableLayoutPanel
    Friend WithEvents id_no_label As Label
    Friend WithEvents id_num_diplay As Label
    Friend WithEvents TableLayoutPanel4 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel5 As TableLayoutPanel
    Friend WithEvents balance_label As Label
    Friend WithEvents TableLayoutPanel6 As TableLayoutPanel
    Friend WithEvents currency_display As Label
    Friend WithEvents balance_display As Label
    Friend WithEvents course_display As Label
    Friend WithEvents logocontainer_main As TableLayoutPanel
    Friend WithEvents icpepLogo As PictureBox
    Friend WithEvents ucv_logo As PictureBox
    Friend WithEvents TableLayoutPanel10 As TableLayoutPanel
    Friend WithEvents coe_logo As PictureBox
End Class
