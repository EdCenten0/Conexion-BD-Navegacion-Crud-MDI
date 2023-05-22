﻿Public Class FormPadre

    Private currentForm As Form = Nothing
    Private Sub archivoCerrar_Click(sender As Object, e As EventArgs) Handles archivoCerrar.Click
        Me.Close()
    End Sub

    Private Sub menuFormularios_Click(sender As Object, e As EventArgs) Handles menuFormularios.Click

    End Sub

    Private Sub opFormularioCRUD_Click(sender As Object, e As EventArgs) Handles opFormularioCRUD.Click
        FormHijo.Show()
    End Sub

    Private Sub FormPadre_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If currentForm IsNot Nothing Then
            currentForm.Close()
        End If
        currentForm = PantallaPresentacion1
        currentForm.MaximumSize = New Size(400, 400)
        currentForm.TopLevel = False
        currentForm.FormBorderStyle = FormBorderStyle.None
        currentForm.Dock = DockStyle.Fill
        Me.Controls.Add(currentForm)
        Me.Tag = currentForm
        currentForm.BringToFront()
        currentForm.Show()
    End Sub

    Private Sub opReportes1_Click(sender As Object, e As EventArgs) Handles opReportes1.Click
        Frm_Reporte.Show()
    End Sub
End Class