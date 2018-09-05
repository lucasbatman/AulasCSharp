Public Class frmCalculadora

    ' DECLARANDO MINHAS VARIÁVEIS
    Private dblResultado As Double = 0
    Private dblNumero As Double = 0
    Private strOperador As String = String.Empty
    Private strNumero As String = "1"
    Private blnLimpa As Boolean = True
    Private blnDecimal As Boolean = False
    Private blnOperador As Boolean = False

    Private Sub btnLimpar_Click(sender As Object, e As EventArgs) Handles btnLimpar.Click
        dblNumero = 0
        dblResultado = 0
        txtResultado.Text = "0,00"
        strOperador = String.Empty
        blnDecimal = False
        blnLimpa = True
        strNumero = "1"
    End Sub

    Private Sub btnZero_Click(sender As Object, e As EventArgs) Handles btnZero.Click
        If blnLimpa = True Then
            txtResultado.Text = "0"
            blnLimpa = False
        Else
            txtResultado.Text = txtResultado.Text & "0"
        End If
    End Sub

    Private Sub btnUm_Click(sender As Object, e As EventArgs) Handles btnUm.Click
        If blnLimpa = True Then
            txtResultado.Text = "1"
            blnLimpa = False
        Else
            txtResultado.Text = txtResultado.Text & "1"
        End If

    End Sub

    Private Sub btnDois_Click(sender As Object, e As EventArgs) Handles BtnDois.Click
        If blnLimpa = True Then
            txtResultado.Text = "2"
            blnLimpa = False
        Else
            txtResultado.Text = txtResultado.Text & "2"
        End If

    End Sub

    Private Sub btnTres_Click(sender As Object, e As EventArgs) Handles btnTres.Click
        If blnLimpa = True Then
            txtResultado.Text = "3"
            blnLimpa = False
        Else
            txtResultado.Text = txtResultado.Text & "3"
        End If
    End Sub
    Private Sub btnQuatro_Click(sender As Object, e As EventArgs) Handles btnQuatro.Click
        If blnLimpa = True Then
            txtResultado.Text = "4"
            blnLimpa = False
        Else
            txtResultado.Text = txtResultado.Text & "4"
        End If
    End Sub

    Private Sub btnCinco_Click(sender As Object, e As EventArgs) Handles btnCinco.Click
        If blnLimpa = True Then
            txtResultado.Text = "5"
            blnLimpa = False
        Else
            txtResultado.Text = txtResultado.Text & "5"
        End If
    End Sub
    Private Sub btnSeis_Click(sender As Object, e As EventArgs) Handles btnSeis.Click
        If blnLimpa = True Then
            txtResultado.Text = "6"
            blnLimpa = False
        Else
            txtResultado.Text = txtResultado.Text & "6"
        End If
    End Sub
    Private Sub btnSete_Click(sender As Object, e As EventArgs) Handles btnSete.Click
        If blnLimpa = True Then
            txtResultado.Text = "7"
            blnLimpa = False
        Else
            txtResultado.Text = txtResultado.Text & "7"
        End If
    End Sub
    Private Sub btnOito_Click(sender As Object, e As EventArgs) Handles btnOito.Click
        If blnLimpa = True Then
            txtResultado.Text = "8"
            blnLimpa = False
        Else
            txtResultado.Text = txtResultado.Text & "8"
        End If
    End Sub
    Private Sub btnNove_Click(sender As Object, e As EventArgs) Handles btnNove.Click
        If blnLimpa = True Then
            txtResultado.Text = "9"
            blnLimpa = False
        Else
            txtResultado.Text = txtResultado.Text & "9"
        End If
    End Sub

    Private Sub btnSomar_Click(sender As Object, e As EventArgs) Handles btnSomar.Click
        If strNumero = "1" And blnOperador = True Then
            dblResultado = Convert.ToDouble(txtResultado.Text)
            strNumero = "2"
        ElseIf strNumero = "2" And blnOperador = True Then
            dblResultado = Convert.ToDouble(txtResultado.Text)
            dblResultado = dblResultado + dblNumero
            txtResultado.Text = dblResultado
            dblResultado = 0
        End If
        blnLimpa = True
        blnDecimal = False
        strOperador = "+"
        blnOperador = False
    End Sub

    Private Sub btnMultiplicar_Click(sender As Object, e As EventArgs) Handles btnMultiplicar.Click
        If strNumero = "1" And blnOperador = True Then
            dblResultado = Convert.ToDouble(txtResultado.Text)
            strNumero = "2"
        ElseIf strNumero = "2" And blnOperador = True Then
            dblResultado = Convert.ToDouble(txtResultado.Text)
            dblResultado = dblResultado * dblNumero
            txtResultado.Text = dblResultado
            dblResultado = 0
        End If
        blnLimpa = True
        blnDecimal = False
        strOperador = "*"
        blnOperador = False
    End Sub

    Private Sub btnSubtrair_Click(sender As Object, e As EventArgs) Handles btnSubtrair.Click
        If strNumero = "1" And blnOperador = True Then
            dblResultado = Convert.ToDouble(txtResultado.Text)
            strNumero = "2"
        ElseIf strNumero = "2" And blnOperador = True Then
            dblResultado = Convert.ToDouble(txtResultado.Text)
            dblResultado = dblResultado - dblNumero
            txtResultado.Text = dblResultado
            dblResultado = 0
        End If
        blnLimpa = True
        blnDecimal = False
        strOperador = "-"
        blnOperador = False
    End Sub
    Private Sub btnDividir_Click(sender As Object, e As EventArgs) Handles btnDividir.Click
        If strNumero = "1" And blnOperador = True Then
            dblResultado = Convert.ToDouble(txtResultado.Text)
            strNumero = "2"
        ElseIf strNumero = "2" And blnOperador = True Then
            dblResultado = Convert.ToDouble(txtResultado.Text)
            dblResultado = dblResultado / dblNumero
            txtResultado.Text = dblResultado
            dblResultado = 0
        End If
        blnLimpa = True
        blnDecimal = False
        strOperador = "/"
        blnOperador = False
    End Sub

    Private Sub btnPonto_Click(sender As Object, e As EventArgs) Handles btnPonto.Click
        If blnDecimal = False Then
            txtResultado.Text = txtResultado.Text & ","
            blnDecimal = True

        End If
    End Sub
    Private Sub btnResultado_Click(sender As Object, e As EventArgs) Handles btnResultado.Click
        If 

    End Sub
End Class
