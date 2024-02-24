Public Class frmHesapMakinesi

    Dim secim As Integer = 0
    Dim sayi1, sayi2, sonuc As Double

    Private Sub Button_Click(sender As Object, e As EventArgs) Handles btn0.Click, btn1.Click, btn2.Click, btn3.Click, btn4.Click, btn5.Click, btn6.Click, btn7.Click, btn8.Click, btn9.Click

        If txtDisplay.Text = "0" Then
            txtDisplay.Text = ""
        End If

        Dim tiklananButon = CType(sender, Button)
        txtDisplay.Text = txtDisplay.Text & tiklananButon.Text

    End Sub


    Private Sub btnBackSpace_Click(sender As Object, e As EventArgs) Handles btnBackSpace.Click
        txtDisplay.Text = txtDisplay.Text.Substring(0, txtDisplay.Text.Length - 1)
        If txtDisplay.Text = "" Then
            txtDisplay.Text = "0"
        End If
    End Sub


    Private Sub btnC_Click(sender As Object, e As EventArgs) Handles btnC.Click

        txtDisplay.Text = "0"

    End Sub

    Private Sub btnArti_Click(sender As Object, e As EventArgs) Handles btnArti.Click
        sayi1 = Double.Parse(txtDisplay.Text)
        secim = 1
        txtDisplay.Text = "0"


    End Sub

    Private Sub BtnEksi_Click(sender As Object, e As EventArgs) Handles BtnEksi.Click
        sayi1 = Double.Parse(txtDisplay.Text)
        secim = 2
        txtDisplay.Text = "0"


    End Sub

    Private Sub btnCarpi_Click(sender As Object, e As EventArgs) Handles btnCarpi.Click
        sayi1 = Double.Parse(txtDisplay.Text)
        secim = 3
        txtDisplay.Text = "0"

    End Sub

    Private Sub btnBolu_Click(sender As Object, e As EventArgs) Handles btnBolu.Click
        sayi1 = Double.Parse(txtDisplay.Text)
        secim = 4
        txtDisplay.Text = "0"

    End Sub

    Private Sub btnEsittir_Click(sender As Object, e As EventArgs) Handles btnEsittir.Click
        sayi2 = Double.Parse(txtDisplay.Text)
        If secim = 1 Then
            sonuc = sayi1 + sayi2
        End If
        txtDisplay.Text = sonuc.ToString()

        If secim = 2 Then
            sonuc = sayi1 - sayi2
        End If
        txtDisplay.Text = sonuc.ToString()

        If secim = 3 Then
            sonuc = sayi1 * sayi2
        End If
        txtDisplay.Text = sonuc.ToString()

        If secim = 4 Then
            sonuc = sayi1 / sayi2
        End If
        txtDisplay.Text = sonuc.ToString()

    End Sub

    Private Sub btnVirgul_Click(sender As Object, e As EventArgs) Handles btnVirgul.Click
        If txtDisplay.Text.IndexOf(",") < 1 Then
            txtDisplay.Text += ","
        End If

    End Sub

    Private Sub btnNegatif_Click(sender As Object, e As EventArgs) Handles btnNegatif.Click
        If txtDisplay.Text <> "0" Then
            If txtDisplay.Text.StartsWith("-") Then
                txtDisplay.Text = txtDisplay.Text.Replace("-", "")
            ElseIf txtDisplay.Text.StartsWith("") Then
                txtDisplay.Text = "-" & txtDisplay.Text
            End If
        End If

    End Sub

End Class
