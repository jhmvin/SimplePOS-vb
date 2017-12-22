Public Class ComputeClass


    '----------------------------------------------------------
    '                   COMPUTE CLASS
    '----------------------------------------------------------
    'THIS IS OUR THIRD CLASS following the guidelines of the project
    'all necessary computations are done here
    'This Class Contains
    '10 Properties in Accordance with the guidelines
    '5 Subs
    'getter and setter
    'TECHDROPS 2015


    '---------------------------------
    '            PROPERTY
    '---------------------------------

    Property itemPriceTotal As Double 'PROPERTY # 1
    Property pcs As Integer 'PROPERTY # 2
    Property netItemPrice As Double 'PROPERTY # 3
    Property cartTotal As Double 'PROPERTY # 4
    Property cashTendered As Double 'PROPERTY # 5
    Property change As Double 'PROPERTY # 6
    Property vat As Double 'PROPERTY # 7
    Property vatRate As Double 'PROPERTY # 8
    Property vatExemptSale As Double 'PROPERTY # 9
    Property itemPrice As Double 'PROPERTY # 10

    '----------------------------------

    Sub getPerItemTotal()
        itemPriceTotal = pcs * itemPrice
    End Sub

    Sub getVat()
        vat = cartTotal * vatRate
    End Sub

    Sub getVatExemptSale()
        vatExemptSale = cartTotal - vat
    End Sub

    Sub getChange()
        change = cashTendered - cartTotal
    End Sub


    Sub getCartTotal()
        cartTotal += itemPriceTotal

    End Sub






End Class
