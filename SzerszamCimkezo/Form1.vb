Public Class Form1
    Private Sub Form1_Activated(sender As Object, e As EventArgs) Handles Me.Activated


    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles Me.Load
        Call LoadZPLSamples()
        Call LoadPrinters()
        Call LoadTools()
        ComboBoxPrinter.Items.Clear()
        For Each lsa In printernames
            ComboBoxPrinter.Items.Add(lsa)
        Next
        ComboBoxPrinter.SelectedIndex = 0
    End Sub

    Private Sub TextBoxKod_TextChanged(sender As Object, e As EventArgs) Handles TextBoxKod.TextChanged
        Dim strKat As String
        strKat = Trim(TextBoxKod.Text)
        If Len(strKat) = 10 Then
            LabelMegnevezes.Text = GetMegnev(TextBoxKod.Text)
            TextBoxDb.SelectAll()
            TextBoxDb.Focus()
            gintEnterCounter = 0

        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Call PrintZPL()
    End Sub

    Private Sub TextBoxDb_KeyDown(sender As Object, e As KeyEventArgs) Handles TextBoxDb.KeyDown
        If e.KeyCode = Keys.Enter Then
            gintEnterCounter = gintEnterCounter + 1
            If gintEnterCounter = 2 Then
                'MsgBox("Nyomtat")
                If LabelMegnevezes.Text <> "" Then
                    Call PrintZPL()
                End If
                LabelMegnevezes.Text = ""
                TextBoxKod.Focus()
                gintEnterCounter = 0
            End If
        End If
    End Sub
End Class
