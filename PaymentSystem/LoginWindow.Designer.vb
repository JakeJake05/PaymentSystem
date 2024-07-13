<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LoginWindow
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(LoginWindow))
        TableLayoutPanel1 = New TableLayoutPanel()
        TableLayoutPanel2 = New TableLayoutPanel()
        logo_container = New TableLayoutPanel()
        PictureBox3 = New PictureBox()
        PictureBox2 = New PictureBox()
        PictureBox1 = New PictureBox()
        TableLayoutPanel3 = New TableLayoutPanel()
        Label1 = New Label()
        enter_button_log = New Button()
        time_date_container = New TableLayoutPanel()
        time_date_container2 = New TableLayoutPanel()
        time_display = New Label()
        date_display = New Label()
        error_disp = New Label()
        log_id_box = New TextBox()
        register = New LinkLabel()
        TableLayoutPanel4 = New TableLayoutPanel()
        header = New PictureBox()
        systemTimer1 = New Timer(components)
        Timer1 = New Timer(components)
        time1 = New Timer(components)
        TableLayoutPanel1.SuspendLayout()
        TableLayoutPanel2.SuspendLayout()
        logo_container.SuspendLayout()
        CType(PictureBox3, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        TableLayoutPanel3.SuspendLayout()
        time_date_container.SuspendLayout()
        time_date_container2.SuspendLayout()
        TableLayoutPanel4.SuspendLayout()
        CType(header, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' TableLayoutPanel1
        ' 
        TableLayoutPanel1.ColumnCount = 1
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50F))
        TableLayoutPanel1.Controls.Add(TableLayoutPanel2, 0, 1)
        TableLayoutPanel1.Controls.Add(TableLayoutPanel4, 0, 0)
        TableLayoutPanel1.Dock = DockStyle.Fill
        TableLayoutPanel1.Location = New Point(0, 0)
        TableLayoutPanel1.Name = "TableLayoutPanel1"
        TableLayoutPanel1.RowCount = 2
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 13.5555553F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 86.44444F))
        TableLayoutPanel1.Size = New Size(800, 450)
        TableLayoutPanel1.TabIndex = 0
        ' 
        ' TableLayoutPanel2
        ' 
        TableLayoutPanel2.BackColor = Color.Maroon
        TableLayoutPanel2.ColumnCount = 1
        TableLayoutPanel2.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50F))
        TableLayoutPanel2.Controls.Add(logo_container, 0, 1)
        TableLayoutPanel2.Controls.Add(TableLayoutPanel3, 0, 0)
        TableLayoutPanel2.Dock = DockStyle.Fill
        TableLayoutPanel2.Location = New Point(0, 61)
        TableLayoutPanel2.Margin = New Padding(0)
        TableLayoutPanel2.Name = "TableLayoutPanel2"
        TableLayoutPanel2.RowCount = 2
        TableLayoutPanel2.RowStyles.Add(New RowStyle(SizeType.Percent, 87.1134F))
        TableLayoutPanel2.RowStyles.Add(New RowStyle(SizeType.Percent, 12.8865976F))
        TableLayoutPanel2.Size = New Size(800, 389)
        TableLayoutPanel2.TabIndex = 1
        ' 
        ' logo_container
        ' 
        logo_container.BackColor = Color.WhiteSmoke
        logo_container.ColumnCount = 3
        logo_container.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 33.3333321F))
        logo_container.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 33.3333321F))
        logo_container.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 33.3333321F))
        logo_container.Controls.Add(PictureBox3, 2, 0)
        logo_container.Controls.Add(PictureBox2, 1, 0)
        logo_container.Controls.Add(PictureBox1, 0, 0)
        logo_container.Dock = DockStyle.Fill
        logo_container.Location = New Point(0, 338)
        logo_container.Margin = New Padding(0)
        logo_container.Name = "logo_container"
        logo_container.RowCount = 1
        logo_container.RowStyles.Add(New RowStyle(SizeType.Percent, 100F))
        logo_container.Size = New Size(800, 51)
        logo_container.TabIndex = 0
        ' 
        ' PictureBox3
        ' 
        PictureBox3.Dock = DockStyle.Fill
        PictureBox3.Image = My.Resources.Resources.ucvlogo
        PictureBox3.Location = New Point(532, 0)
        PictureBox3.Margin = New Padding(0)
        PictureBox3.Name = "PictureBox3"
        PictureBox3.Size = New Size(268, 51)
        PictureBox3.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox3.TabIndex = 2
        PictureBox3.TabStop = False
        ' 
        ' PictureBox2
        ' 
        PictureBox2.Dock = DockStyle.Fill
        PictureBox2.Image = My.Resources.Resources.icpeplogo
        PictureBox2.Location = New Point(266, 0)
        PictureBox2.Margin = New Padding(0)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(266, 51)
        PictureBox2.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox2.TabIndex = 1
        PictureBox2.TabStop = False
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Dock = DockStyle.Fill
        PictureBox1.Image = My.Resources.Resources.coelogo
        PictureBox1.Location = New Point(0, 0)
        PictureBox1.Margin = New Padding(0)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(266, 51)
        PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox1.TabIndex = 0
        PictureBox1.TabStop = False
        ' 
        ' TableLayoutPanel3
        ' 
        TableLayoutPanel3.Anchor = AnchorStyles.None
        TableLayoutPanel3.ColumnCount = 1
        TableLayoutPanel3.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50F))
        TableLayoutPanel3.Controls.Add(Label1, 0, 0)
        TableLayoutPanel3.Controls.Add(enter_button_log, 0, 2)
        TableLayoutPanel3.Controls.Add(time_date_container, 0, 3)
        TableLayoutPanel3.Controls.Add(log_id_box, 0, 1)
        TableLayoutPanel3.Controls.Add(register, 0, 4)
        TableLayoutPanel3.Location = New Point(108, 21)
        TableLayoutPanel3.Margin = New Padding(0)
        TableLayoutPanel3.Name = "TableLayoutPanel3"
        TableLayoutPanel3.RowCount = 5
        TableLayoutPanel3.RowStyles.Add(New RowStyle(SizeType.Percent, 58.064518F))
        TableLayoutPanel3.RowStyles.Add(New RowStyle(SizeType.Percent, 41.935482F))
        TableLayoutPanel3.RowStyles.Add(New RowStyle(SizeType.Absolute, 43F))
        TableLayoutPanel3.RowStyles.Add(New RowStyle(SizeType.Absolute, 87F))
        TableLayoutPanel3.RowStyles.Add(New RowStyle(SizeType.Absolute, 41F))
        TableLayoutPanel3.Size = New Size(583, 296)
        TableLayoutPanel3.TabIndex = 1
        ' 
        ' Label1
        ' 
        Label1.Anchor = AnchorStyles.None
        Label1.AutoSize = True
        Label1.Font = New Font("Arial", 25.8000011F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.Gold
        Label1.Location = New Point(211, 10)
        Label1.Name = "Label1"
        Label1.Size = New Size(161, 51)
        Label1.TabIndex = 0
        Label1.Text = "LOGIN"
        ' 
        ' enter_button_log
        ' 
        enter_button_log.Anchor = AnchorStyles.None
        enter_button_log.BackColor = Color.White
        enter_button_log.Font = New Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        enter_button_log.Location = New Point(237, 127)
        enter_button_log.Name = "enter_button_log"
        enter_button_log.Size = New Size(108, 37)
        enter_button_log.TabIndex = 1
        enter_button_log.Text = "Enter"
        enter_button_log.UseVisualStyleBackColor = False
        ' 
        ' time_date_container
        ' 
        time_date_container.Anchor = AnchorStyles.None
        time_date_container.ColumnCount = 1
        time_date_container.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50F))
        time_date_container.Controls.Add(time_date_container2, 0, 1)
        time_date_container.Controls.Add(error_disp, 0, 0)
        time_date_container.Location = New Point(65, 167)
        time_date_container.Margin = New Padding(0)
        time_date_container.Name = "time_date_container"
        time_date_container.RowCount = 2
        time_date_container.RowStyles.Add(New RowStyle(SizeType.Percent, 50F))
        time_date_container.RowStyles.Add(New RowStyle(SizeType.Percent, 50F))
        time_date_container.Size = New Size(453, 87)
        time_date_container.TabIndex = 3
        ' 
        ' time_date_container2
        ' 
        time_date_container2.Anchor = AnchorStyles.None
        time_date_container2.ColumnCount = 2
        time_date_container2.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50F))
        time_date_container2.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50F))
        time_date_container2.Controls.Add(time_display, 1, 0)
        time_date_container2.Controls.Add(date_display, 0, 0)
        time_date_container2.Location = New Point(0, 43)
        time_date_container2.Margin = New Padding(0)
        time_date_container2.Name = "time_date_container2"
        time_date_container2.RowCount = 1
        time_date_container2.RowStyles.Add(New RowStyle(SizeType.Percent, 50F))
        time_date_container2.Size = New Size(453, 44)
        time_date_container2.TabIndex = 0
        ' 
        ' time_display
        ' 
        time_display.Anchor = AnchorStyles.Left
        time_display.AutoSize = True
        time_display.Font = New Font("Arial", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        time_display.ForeColor = Color.Gold
        time_display.Location = New Point(226, 8)
        time_display.Margin = New Padding(0)
        time_display.Name = "time_display"
        time_display.Size = New Size(164, 27)
        time_display.TabIndex = 1
        time_display.Text = "HH:MM:SS TT"
        ' 
        ' date_display
        ' 
        date_display.Anchor = AnchorStyles.Right
        date_display.AutoSize = True
        date_display.Font = New Font("Arial", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        date_display.ForeColor = Color.Gold
        date_display.Location = New Point(66, 8)
        date_display.Margin = New Padding(0)
        date_display.Name = "date_display"
        date_display.Size = New Size(160, 27)
        date_display.TabIndex = 0
        date_display.Text = "MM-DD-YYYY"
        ' 
        ' error_disp
        ' 
        error_disp.Anchor = AnchorStyles.None
        error_disp.AutoSize = True
        error_disp.Font = New Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        error_disp.ForeColor = Color.Gold
        error_disp.Location = New Point(101, 9)
        error_disp.Name = "error_disp"
        error_disp.Size = New Size(250, 25)
        error_disp.TabIndex = 1
        error_disp.Text = "Scan or Enter your ID Number"
        ' 
        ' log_id_box
        ' 
        log_id_box.Anchor = AnchorStyles.None
        log_id_box.Font = New Font("Arial Narrow", 13.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        log_id_box.Location = New Point(143, 81)
        log_id_box.Name = "log_id_box"
        log_id_box.PlaceholderText = "ID Number"
        log_id_box.Size = New Size(297, 34)
        log_id_box.TabIndex = 2
        log_id_box.TextAlign = HorizontalAlignment.Center
        ' 
        ' register
        ' 
        register.Anchor = AnchorStyles.None
        register.AutoSize = True
        register.Font = New Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        register.ForeColor = Color.Gold
        register.LinkColor = Color.Gold
        register.Location = New Point(257, 265)
        register.Name = "register"
        register.Size = New Size(69, 19)
        register.TabIndex = 4
        register.TabStop = True
        register.Text = "Register"
        ' 
        ' TableLayoutPanel4
        ' 
        TableLayoutPanel4.ColumnCount = 1
        TableLayoutPanel4.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50F))
        TableLayoutPanel4.Controls.Add(header, 0, 0)
        TableLayoutPanel4.Dock = DockStyle.Fill
        TableLayoutPanel4.Location = New Point(0, 0)
        TableLayoutPanel4.Margin = New Padding(0)
        TableLayoutPanel4.Name = "TableLayoutPanel4"
        TableLayoutPanel4.RowCount = 1
        TableLayoutPanel4.RowStyles.Add(New RowStyle(SizeType.Percent, 50F))
        TableLayoutPanel4.Size = New Size(800, 61)
        TableLayoutPanel4.TabIndex = 2
        ' 
        ' header
        ' 
        header.BackColor = Color.White
        header.Dock = DockStyle.Fill
        header.Image = My.Resources.Resources.header
        header.Location = New Point(0, 0)
        header.Margin = New Padding(0)
        header.Name = "header"
        header.Size = New Size(800, 61)
        header.SizeMode = PictureBoxSizeMode.Zoom
        header.TabIndex = 0
        header.TabStop = False
        ' 
        ' systemTimer1
        ' 
        systemTimer1.Enabled = True
        systemTimer1.Interval = 1000
        ' 
        ' time1
        ' 
        ' 
        ' LoginWindow
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.Maroon
        ClientSize = New Size(800, 450)
        Controls.Add(TableLayoutPanel1)
        FormBorderStyle = FormBorderStyle.None
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Name = "LoginWindow"
        SizeGripStyle = SizeGripStyle.Hide
        StartPosition = FormStartPosition.CenterScreen
        Text = "Payment System"
        WindowState = FormWindowState.Maximized
        TableLayoutPanel1.ResumeLayout(False)
        TableLayoutPanel2.ResumeLayout(False)
        logo_container.ResumeLayout(False)
        CType(PictureBox3, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        TableLayoutPanel3.ResumeLayout(False)
        TableLayoutPanel3.PerformLayout()
        time_date_container.ResumeLayout(False)
        time_date_container.PerformLayout()
        time_date_container2.ResumeLayout(False)
        time_date_container2.PerformLayout()
        TableLayoutPanel4.ResumeLayout(False)
        CType(header, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents header As PictureBox
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents logo_container As TableLayoutPanel
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents TableLayoutPanel3 As TableLayoutPanel
    Friend WithEvents Label1 As Label
    Friend WithEvents enter_button_log As Button
    Friend WithEvents log_id_box As TextBox
    Friend WithEvents time_date_container As TableLayoutPanel
    Friend WithEvents time_date_container2 As TableLayoutPanel
    Friend WithEvents date_display As Label
    Friend WithEvents systemTimer1 As Timer
    Friend WithEvents time_display As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents time1 As Timer
    Friend WithEvents error_disp As Label
    Friend WithEvents TableLayoutPanel4 As TableLayoutPanel
    Friend WithEvents register As LinkLabel
End Class
