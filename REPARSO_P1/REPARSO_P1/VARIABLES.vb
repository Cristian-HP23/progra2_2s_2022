Module VARIABLES
    Public nombre, nit As String
    Public Const barreno = 250
    Public Const pulidora = 275
    Public Const llaves = 175
    Public Const cangrejo = 200

    Public parcial, total, calculo1, calculo2 As Double

    Sub ELECTICAS()
        If (Form1.RBTN_ELECTRICAS.Checked) Then
            Form1.CB_LLAVES.Enabled = False
            Form1.CB_CANGREJO.Enabled = False
            Form1.CB_LLAVES.Checked = False
            Form1.CB_CANGREJO.Checked = False
            Form1.CB_BARRENOP.Enabled = True
            Form1.CB_PULIDORA.Enabled = True
        End If
    End Sub
    Sub MANUALES()
        If (Form1.RBTN_MANUALES.Checked) Then
            Form1.CB_LLAVES.Enabled = True
            Form1.CB_CANGREJO.Enabled = True
            Form1.CB_BARRENOP.Enabled = False
            Form1.CB_PULIDORA.Enabled = False
            Form1.CB_BARRENOP.Checked = False
            Form1.CB_PULIDORA.Checked = False
        End If
    End Sub

    Function VERIFICAR_TIPO() As Boolean
        If (Form1.RBTN_ELECTRICAS.Checked Or Form1.RBTN_MANUALES.Checked) Then
            Return True
        End If
        Return False
    End Function

    Function CALCULO_PARCIAL() As Double
        Dim calculo2 As Double = 0
        If (Form1.CB_BARRENOP.Checked) Then
            calculo2 += barreno
        End If
        If (Form1.CB_PULIDORA.Checked) Then
            calculo2 += pulidora
        End If
        If (Form1.CB_LLAVES.Checked) Then
            calculo2 += llaves
        End If
        If (Form1.CB_CANGREJO.Checked) Then
            calculo2 += cangrejo
        End If
        parcial = calculo2
        Return calculo2
    End Function


End Module
