Module SzerszamCimke
    Public gintEnterCounter As Integer

    Public Sub PrintZPL()
        Dim s As String
        Dim pd As New PrintDialog()
        Dim res As Boolean

        s = labelcodes(0)
        s = s.Replace("VONALKOD", Form1.TextBoxKod.Text)
        s = s.Replace("SZERSZAMMEGNEV", Form1.LabelMegnevezes.Text)
        s = s.Replace("SZERSZAMZPL", ZebraPrint.GetZPLutf8Code(Form1.LabelMegnevezes.Text))
        s = s.Replace("LABELQTY", Form1.TextBoxDb.Text)

        Console.WriteLine(s)
        ' Open the printer dialog box, and then allow the user to select a printer.
        'res = ZebraPrint.SendStringToPrinter(Trim(Form1.ComboBoxPrinter.Text), s)


    End Sub
    Public Function GetMegnev(kod As String) As String
        GetMegnev = vbNullString
        For i = 0 To szerszamcodes.Count - 1
            If szerszamcodes(i) = kod Then
                GetMegnev = szerszamdescs(i)
            End If
        Next
    End Function
End Module
