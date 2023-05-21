Public Class Form1
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles btGuardar.Click

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'DsCiudades.Ciudad' Puede moverla o quitarla según sea necesario.
        Me.CiudadTableAdapter.Fill(Me.DsCiudades.Ciudad)

    End Sub
End Class
