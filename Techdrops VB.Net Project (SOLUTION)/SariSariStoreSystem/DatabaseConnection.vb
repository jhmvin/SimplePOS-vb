Public Class DatabaseConnection
    Dim msg As New Techdrops

    '----------------------------------------------------------
    '                 DATABASE CONNECTION CLASS
    '----------------------------------------------------------
    'This Class manages most of the connections done with the database
    'This is our SECOND CLASS following the guidelines of the project
    'This Class Contains
    '10 Properties in Accordance with the guidelines
    '9 SUBS/FUNCTION
    'TECHDROPS 2015


    '---------------------------------------
    '       Connection Properties
    '---------------------------------------
    Property con As New OleDb.OleDbConnection 'PROPERTY # 1
    Property da As New OleDb.OleDbDataAdapter 'PROPERTY # 2
    Property query As String 'PROPERTY # 3
    Property rowCount As Integer 'PROPERTY # 4
    Property rowNumber As Integer 'PROPERTY # 5
    Property ds As New DataSet 'PROPERTY # 6





    '---------------------------------------
    '       Process Properties
    '---------------------------------------
    'Accepts the table
    Property myTable As String
        Set(ByVal value As String)
            table = value
        End Set
        Get
            Return table
        End Get
    End Property

    Property updateStock As Integer
        Set(ByVal value As Integer)
            Stock = value
        End Set
        Get
            Return Stock
        End Get
    End Property

    Property stockNames As String
        Set(ByVal value As String)
            sName = value
        End Set
        Get
            Return sName
        End Get
    End Property



    '---------------------------------------
    '        Property Return Values
    '---------------------------------------


    Dim prodName As String
    Dim prodPrice As Double
    Dim prodQuantity As Integer
    Dim prodCat As String
    Dim sName As String

    Dim connectionString As String
    Dim table As String
    Dim Stock As Integer

    '---------------------------------------
    '        Property Return Values --END
    '---------------------------------------
    'PROPERTY # 7
    'Accepts the Connection String
    Property conString As String
        Set(value As String)
            connectionString = value
        End Set
        Get
            Return connectionString
        End Get
    End Property

    Property location As Integer 'PROPERTY # 8
    Property foundItem As Boolean 'PROPERTY # 9
    Property operationSuccess As Boolean 'PROPERTY # 10

    



    '--------------------------------------------------
    '       Updates the stock during selling
    '--------------------------------------------------
    'SUB/FUNCTION # 1
    'Decreases stock as to when the user is selling
    'Verfies if it has sufficient stock to supply

    Sub retrieveStock()
        Dim cb As New OleDb.OleDbCommandBuilder(da)
        For rowNumber As Integer = 0 To (rowCount - 1)
            prodName = ds.Tables("pnTemp").Rows(rowNumber).Item(1)

            If prodName.ToUpper = sName.ToUpper Then
                prodQuantity = ds.Tables("pnTemp").Rows(rowNumber).Item(2)

                prodQuantity -= Stock

                If (prodQuantity < 0) Then
                    msg.displayWarning("Operation Failed: Insufficient Stock")
                    operationSuccess = False
                Else
                    ds.Tables("pnTemp").Rows(rowNumber).Item(2) = prodQuantity
                    da.Update(ds, "pnTemp")
                    operationSuccess = True
                End If


            End If
        Next


    End Sub

    'SUB/FUNCTION # 2
    'Returns the retrieved stock during removed item phase
    Sub returnStock()
        Dim cb As New OleDb.OleDbCommandBuilder(da)
        For rowNumber As Integer = 0 To (rowCount - 1)
            prodName = ds.Tables("pnTemp").Rows(rowNumber).Item(1)

            If prodName.ToUpper = sName.ToUpper Then
                prodQuantity = ds.Tables("pnTemp").Rows(rowNumber).Item(2)
                prodQuantity += Stock
                ds.Tables("pnTemp").Rows(rowNumber).Item(2) = prodQuantity
                da.Update(ds, "pnTemp")
            End If
        Next


    End Sub

    '---------------------------------------
    '       Connects to the database
    '---------------------------------------
    'SUB/FUNCTION # 3
    Sub connect()
        con.ConnectionString = conString
        con.Open()
        query = "SELECT * FROM " & myTable
        da = New OleDb.OleDbDataAdapter(query, con)
        da.Fill(ds, "pnTemp")
        rowCount = ds.Tables("pnTemp").Rows.Count

 


    End Sub

    'disconnects the database
    'SUB/FUNCTION # 4
    Sub disconnect()
        con.Close()
    End Sub

    '---------------------------------------
    '       Fetch Data
    '---------------------------------------
    'SUB/FUNCTION # 5
    'fetch all items in the the database and store in a list object
    'list object sorts the data in alphabetical order and returns the list

        Function getList()
        Dim list As New List(Of String)
        list.Clear()

            For rowNumber As Integer = 0 To (rowCount - 1)
                prodName = ds.Tables("pnTemp").Rows(rowNumber).Item(1)


            list.Add(prodName)

            Next
        list.Sort()
            Return list
    End Function

    'SUB/FUNCTION # 6
    'Finds the item if its already exisitng in the database
    'it is used during update delete and retrieve
    Sub findItem(ByVal search As String)
        foundItem = False

        For rowNumber As Integer = 0 To (rowCount - 1)
            prodName = ds.Tables("pnTemp").Rows(rowNumber).Item(1)

            If (prodName.ToUpper = search.ToUpper) Then
                foundItem = True
                location = rowNumber
                Exit Sub
            End If
        Next


    End Sub

    '---------------------------------------
    '       Fetch Data
    '---------------------------------------
    'SUB/FUNCTION # 7
    'Fetch data in categorical order


    Function getCategory(cat As String)
        Dim list As New List(Of String)
        list.Clear()

        For rowNumber As Integer = 0 To (rowCount - 1)

            prodCat = ds.Tables("pnTemp").Rows(rowNumber).Item(4)
            If (prodCat.ToUpper = cat.ToUpper) Then
                prodName = ds.Tables("pnTemp").Rows(rowNumber).Item(1)
                list.Add(prodName)
            End If
        Next

        list.Sort()
        Return list
    End Function

    'SUB/FUNCTION # 8
    'using the name of the item it wil find the remaining stocks in the database
    Function getQuantity(name As String)
        Dim quantity As Integer

        For rowNumber As Integer = 0 To (rowCount - 1)

            prodName = ds.Tables("pnTemp").Rows(rowNumber).Item(1)
            prodQuantity = ds.Tables("pnTemp").Rows(rowNumber).Item(2)

            If name.ToUpper = prodName.ToUpper Then
                quantity = prodQuantity
                Exit For
            End If

        Next
        Return quantity

    End Function

    'SUB/FUNCTION # 9
    'using the name of the item it will get the price from the database
    Function getPrice(name As String)
        Dim price As Double

        For rowNumber As Integer = 0 To (rowCount - 1)

            prodName = ds.Tables("pnTemp").Rows(rowNumber).Item(1)
            prodPrice = ds.Tables("pnTemp").Rows(rowNumber).Item(3)

            If name.ToUpper = prodName.ToUpper Then
                price = prodPrice
                Exit For
            End If

        Next
        Return price

    End Function








End Class