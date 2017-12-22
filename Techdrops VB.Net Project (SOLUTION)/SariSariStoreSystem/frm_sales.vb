Public Class frm_sales
    Dim connection As New DatabaseConnection
    Dim msg As New Techdrops


    Private Sub frm_sales_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Screen Center Alignment
        'Get the working area of the screen and assign it to a rectangle object
        Dim rect As Rectangle = Screen.PrimaryScreen.WorkingArea
        'Divide the screen in half, and find the center of the form to center it
        Me.Top = (rect.Height / 2) - (Me.Height / 2)
        Me.Left = (rect.Width / 2) - (Me.Width / 2)

        'Connection to Database using DC (DAtabase Connection class)
        Try
            connection.conString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=marichu.accdb"
            connection.myTable = "SalesReport"
            connection.connect()
        Catch
            msg.displayError("Cannot Establish Connection With The Database")
            frm_main.Show()
            Me.Close()
        End Try

        'Gets Date from DateTimePicker
        Dim myDate As String
        myDate = DateTimePicker1.Value.ToString("MMMM dd yyyy")
        lbl_sales.Text = "P" & Format(getSales(myDate), "0.00")

        'Tool Tips
        tip_sales.ShowAlways = True
        tip_sales.SetToolTip(cmd_home, "Back To Main Menu: HotKey(Alt + M)")
        tip_sales.SetToolTip(DateTimePicker1, "Select Date To See Your Sales")
        tip_sales.SetToolTip(lbl_sales, "Your Sales In The Selected Day")
    End Sub



    Private Sub DateTimePicker1_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DateTimePicker1.ValueChanged
        'Gets Total Sales from database
        Dim myDate As String
        myDate = DateTimePicker1.Value.ToString("MMMM dd yyyy")
        lbl_sales.Text = "P" & Format(getSales(myDate), "0.00")
    End Sub

    'Complex Computing Function
    Private Function getSales(ByVal xDate As String)
        Dim tSales As Double
        Dim findDate As String
        Dim total As Double

        For counter As Integer = 0 To (connection.rowCount - 1)

            findDate = connection.ds.Tables("pnTemp").Rows(counter).Item(5)
            If (findDate = xDate) Then

                total = connection.ds.Tables("pnTemp").Rows(counter).Item(3)
                tSales = total + tSales
            End If

        Next


        Return tSales
    End Function

    'home button
    Private Sub cmd_home_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_home.Click
        connection.disconnect()
        frm_main.Show()
        Me.Close()
    End Sub
End Class