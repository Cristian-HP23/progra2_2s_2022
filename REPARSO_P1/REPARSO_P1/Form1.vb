Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CB_BARRENOP.Enabled = False
        CB_PULIDORA.Enabled = False
        CB_LLAVES.Enabled = False
        CB_CANGREJO.Enabled = False
    End Sub

    Private Sub RBTN_ELECTRICAS_CheckedChanged(sender As Object, e As EventArgs) Handles RBTN_ELECTRICAS.CheckedChanged
        ELECTICAS()
    End Sub

    Private Sub RBTN_MANUALES_CheckedChanged(sender As Object, e As EventArgs) Handles RBTN_MANUALES.CheckedChanged
        MANUALES()
    End Sub

    Private Sub CALCULARToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CALCULARToolStripMenuItem.Click
        If (VERIFICAR_TIPO()) Then
            TXT_PARCIAL.Text = " " & CALCULO_PARCIAL()
        Else
            MsgBox("error ES NECESARIO SELECCIONAR UN TIPO DE HERRAMIENTAS")
        End If
    End Sub
End Class
