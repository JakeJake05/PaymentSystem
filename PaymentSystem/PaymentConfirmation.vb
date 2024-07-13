Imports System.Drawing.Printing

Public Class PaymentConfirmation

    Dim WithEvents printR As New PrintDocument
    Dim printPrv As New PrintPreviewDialog
    Dim longPaper As Integer

    Private Sub PaymentConfirmation_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        systemTime.Interval = 1000
        systemTime.Start()

    End Sub

    Private Sub PR_BeginPrint(sender As Object, e As PrintEventArgs) Handles printR.BeginPrint

        Dim pageSetup As New PageSettings
        pageSetup.PaperSize = New PaperSize("Custom", 500, 700)

        printR.DefaultPageSettings = pageSetup

    End Sub

    Private Sub PR_PrintPage(sender As Object, e As PrintPageEventArgs) Handles printR.PrintPage

        'Font-Sizes
        Dim fnt8 As New Font("Arial", 8, FontStyle.Regular)
        Dim fnt9 As New Font("Arial", 9, FontStyle.Regular)
        Dim fnt10 As New Font("Arial", 10, FontStyle.Regular)
        Dim fntR11 As New Font("Arial", 11, FontStyle.Regular)
        Dim fntR12 As New Font("Arial", 12, FontStyle.Regular)
        Dim fntR14 As New Font("Arial", 14, FontStyle.Regular)
        Dim fntR20 As New Font("Arial", 20, FontStyle.Regular)
        Dim fntB7 As New Font("Arial", 7, FontStyle.Bold)
        Dim fntB8 As New Font("Arial", 8, FontStyle.Bold)
        Dim fntB10 As New Font("Arial", 10, FontStyle.Bold)
        Dim fntB11 As New Font("Arial", 11, FontStyle.Bold)
        Dim fntB12 As New Font("Arial", 12, FontStyle.Bold)
        Dim fntB14 As New Font("Arial", 14, FontStyle.Bold)
        Dim fnt20 As New Font("Arial", 20, FontStyle.Bold)

        Dim leftMargin As Integer = printR.DefaultPageSettings.Margins.Left
        Dim centertMargin As Integer = printR.DefaultPageSettings.PaperSize.Width / 2
        Dim rightMargin As Integer = printR.DefaultPageSettings.Margins.Right

        'font alighment
        Dim right As New StringFormat
        Dim center As New StringFormat
        right.Alignment = StringAlignment.Far
        center.Alignment = StringAlignment.Center


        'Borders
        Dim fsrtLayer1 As New Pen(Brushes.Black, 1)
        Dim scndLayer1 As New Pen(Brushes.Black, 1)

        'top border in Payer Name
        e.Graphics.DrawLine(fsrtLayer1, 40, 193, 450, 193)
        'top border in Stundent ID, Course, Year
        e.Graphics.DrawLine(scndLayer1, 40, 238, 450, 238)
        'between Student ID & Department
        e.Graphics.DrawLine(scndLayer1, leftMargin + 60, 238, leftMargin + 60, 285)
        'between Course & Year
        e.Graphics.DrawLine(scndLayer1, 340, 238, 340, 285)
        'bottom border in Stundent ID, Course, Year
        e.Graphics.DrawLine(scndLayer1, 40, 285, 450, 285)
        'bottom border in amount
        e.Graphics.DrawLine(scndLayer1, 40, 330, 450, 330)
        'border bottom description
        e.Graphics.DrawLine(scndLayer1, 40, 470, 450, 470)


        'Header
        e.Graphics.DrawString("University of Cagayan Valley", fnt20, Brushes.Black, centertMargin, 10, center)
        e.Graphics.DrawString("(Formerly Cagayan Colleges Tuguegarao)", fntR11, Brushes.Black, centertMargin, 43, center)
        e.Graphics.DrawString("NonVAT Reg. TIN: 000-551-197-001", fntR11, Brushes.Black, centertMargin, 61, center)
        e.Graphics.DrawString("Balzain East, Tuguegarao City, Cagayan Valley", fntR11, Brushes.Black, centertMargin, 80, center)

        'UCV Logo Header
        Dim logoImg As Image = Image.FromFile("D:\Projects\PaymentSystem\PaymentSystem\PaymentSystem\images\ucvlogo.png") 'path_to_your_image.jpg
        'Dim iWidth As Integer = logoImg.Width
        'Dim iHeight As Integer = logoImg.Height
        Dim customWidth As Integer = 70
        Dim customHeight As Integer = CInt(logoImg.Height / (logoImg.Width / customWidth))
        Dim imgX As Integer = centertMargin - customWidth / 2
        Dim imgY As Integer = 35
        e.Graphics.DrawImage(logoImg, 20, imgY, customWidth, customHeight)

        'Title
        e.Graphics.DrawString("OFICIACL RECEIPT", fntB14, Brushes.Black, centertMargin, 130, center)

        'Receipt Date
        Dim dateToday As String
        dateToday = DateTime.Now.ToString("MMMM dd, yyyy")
        Dim rightAlignment As New StringFormat() With {.Alignment = StringAlignment.Far}
        e.Graphics.DrawString("Date :", fntB10, Brushes.Black, 320, 170, center)
        e.Graphics.DrawString(dateToday, fntB10, Brushes.Black, 405, 170, center)


        'Name of Payer
        'Change as need, sample lang to
        e.Graphics.DrawString("Received from", fntB10, Brushes.Black, leftMargin - 5, 200, center)
        Dim accFirstName As String
        Dim accMiddleName As String
        Dim accLastName As String
        accFirstName = "Mary Joy"
        accMiddleName = "Abdurahim"
        accLastName = "Abubacar"
        e.Graphics.DrawString(accLastName + ", " + accFirstName + " " + accMiddleName, fnt10, Brushes.Black, centertMargin, 220, center)

        'ID number of Payer
        e.Graphics.DrawString("Student Number", fntB10, Brushes.Black, leftMargin, 245, center)
        Dim accIDNum As String
        accIDNum = "202011586"
        e.Graphics.DrawString(accIDNum, fnt10, Brushes.Black, leftMargin - 20, 265, center)

        'Course
        e.Graphics.DrawString("Course", fntB10, Brushes.Black, centertMargin - 55, 245, center)
        Dim course As String
        course = "BS Computer Engineering"
        e.Graphics.DrawString(course, fnt10, Brushes.Black, centertMargin, 265, center)

        'Year
        e.Graphics.DrawString("Year", fnt10, Brushes.Black, leftMargin + 260, 245, center)
        Dim year As Integer
        year = 4
        e.Graphics.DrawString(4, fntB11, Brushes.Black, leftMargin + 260, 265, center)

        'Amount
        e.Graphics.DrawString("the amount of", fntB10, Brushes.Black, leftMargin - 7, 290, center)
        Dim amountNum As Decimal
        amountNum = 21345.0 'Set amount or retrieve from database
        Dim words As String = MoneyConverter.ConvertMoneyToWords(amountNum)
        e.Graphics.DrawString("****" + amountNum.ToString() + "****", fnt10, Brushes.Black, centertMargin, 290, center)
        e.Graphics.DrawString("****" + words.ToString() + "****", fnt10, Brushes.Black, centertMargin, 310, center)

        'Descrition
        e.Graphics.DrawString("as payment of:", fntB10, Brushes.Black, leftMargin - 5, 335, center)
        e.Graphics.DrawString("Tuition Fee", fnt10, Brushes.Black, leftMargin, 370, center)
        e.Graphics.DrawString(amountNum, fnt10, Brushes.Black, leftMargin + 300, 370, center)
        e.Graphics.DrawString("-----nothing follows-----", fnt10, Brushes.Black, centertMargin, 400, center)
        e.Graphics.DrawString("Total: " + amountNum.ToString(), fnt10, Brushes.Black, leftMargin + 282, 450, center)

        'Footer
        Dim _change, r_balance, received As Decimal
        Dim or_number As Integer
        or_number = 20221212
        _change = 1345.0
        r_balance = -1345.0
        received = 21345.0
        e.Graphics.DrawString("Received: " + received.ToString(), fnt8, Brushes.Black, centertMargin - 110, 480, center)
        e.Graphics.DrawString("Change: " + _change.ToString(), fnt8, Brushes.Black, centertMargin, 480, center)
        e.Graphics.DrawString("Balance: " + r_balance.ToString(), fnt8, Brushes.Black, centertMargin + 110, 480, center)
        e.Graphics.DrawString("OR NO: " + or_number.ToString(), fntB12, Brushes.Black, leftMargin + 10, 510, center)
        'Underline Payment method
        e.Graphics.DrawLine(scndLayer1, centertMargin + 60, 520, 450, 520)
        e.Graphics.DrawString("**Cash - TPS**", fnt9, Brushes.Black, leftMargin + 282, 505, center)
        e.Graphics.DrawString("Payment Method", fnt9, Brushes.Black, leftMargin + 282, 524, center)
        e.Graphics.DrawString("""Please present this receipt When you claim your change at the cashier.""", fnt8, Brushes.Black, centertMargin, 575, center)
        e.Graphics.DrawString("""Unclaimed change or excess payment will be accumulated for the next transaction.""", fnt8, Brushes.Black, centertMargin, 585, center)
        e.Graphics.DrawString("""THIS DOCUMENT IS NOT VALID FOR CLAIM OF INPUT TAXES."".", fnt8, Brushes.Black, centertMargin, 595, center)
        e.Graphics.DrawString("This Official Receipt shall be valid for five(5)years from the date of ATP", fnt8, Brushes.Black, centertMargin, 605, center)
        e.Graphics.DrawString("""A taxpayer with expiring receipt/invoice shall apply for a new ATP 60 days prior to expriry date""", fntB7, Brushes.Black, centertMargin, 615, center)

    End Sub

    Private Sub print_button_Click(sender As Object, e As EventArgs) Handles print_button.Click

        printPrv.Document = printR
        printPrv.PrintPreviewControl.Zoom = 1.0
        printPrv.Height = 605
        'printPrv.StartPosition = FormStartPosition.CenterParent
        printPrv.ControlBox = False
        printPrv.FormBorderStyle = FormBorderStyle.None
        printPrv.StartPosition = FormStartPosition.Manual
        printPrv.Location = New Point(550, 108)
        printPrv.ShowDialog()

    End Sub

    Private Sub exit_button_succ_Click(sender As Object, e As EventArgs) Handles exit_button_succ.Click

        Dim logged As New LoggedUserWindow()
        logged.Show()
        Me.Close()

    End Sub

    Private Sub PrintReceipt_EndPrint(sender As Object, e As PrintEventArgs) Handles PrintReceipt.EndPrint
        printPrv.Close()
    End Sub
End Class