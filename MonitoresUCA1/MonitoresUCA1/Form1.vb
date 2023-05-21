Public Class Form1
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles btGuardar.Click

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'DsCiudades.Ciudad' Puede moverla o quitarla según sea necesario.
        Me.CiudadTableAdapter.Fill(Me.DsCiudades.Ciudad)

    End Sub

    Public Sub MostrarPosicion()
        Dim iTotal As Integer = CiudadBindingSource.Count
        Dim iPos As Integer
        If iTotal = 0 Then
            etPosicion.Text = "No. de Registros"
        Else
            iPos = CiudadBindingSource.Position + 1
            etPosicion.Text = iPos.ToString & " de " & iTotal.ToString
        End If

    End Sub

    Private Sub btPrimero_Click(sender As Object, e As EventArgs) Handles btPrimero.Click
        CiudadBindingSource.Position = 0
        MostrarPosicion()
    End Sub

    Private Sub btAnterior_Click(sender As Object, e As EventArgs) Handles btAnterior.Click
        CiudadBindingSource.Position -= 1
        MostrarPosicion()
    End Sub

    Private Sub btSiguiente_Click(sender As Object, e As EventArgs) Handles btSiguiente.Click
        CiudadBindingSource.Position += 1
        MostrarPosicion()
    End Sub

    Private Sub btUltimo_Click(sender As Object, e As EventArgs) Handles btUltimo.Click
        CiudadBindingSource.Position = CiudadBindingSource.Count - 1
        MostrarPosicion()
    End Sub
End Class
