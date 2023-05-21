Imports System.Data.SqlClient

Public Class FormHijo
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles btGuardar.Click
        Dim cmd As New SqlCommand()
        If Me.Validate Then
            Try
                If (DsCiudades.HasChanges()) Then
                    Me.CiudadBindingSource.EndEdit()
                    Me.CiudadTableAdapter.Update(Me.DsCiudades.Ciudad)
                    MessageBox.Show("Base de datos actualizada")
                End If
            Catch ex As Exception
                MessageBox.Show("Error: " + ex.Message)
            End Try
        Else
            MessageBox.Show(Me, "Errores de validacion.", "Guardar", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If

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

    Private Sub btAñadir_Click(sender As Object, e As EventArgs) Handles btAñadir.Click
        Dim miTabla As DataTable = DsCiudades.Ciudad
        Dim cFilas As DataRowCollection = miTabla.Rows
        Dim nuevaFila As DataRow
        Try
            nuevaFila = miTabla.NewRow()
            nuevaFila(0) = CiudadBindingSource.Count + 1
            nuevaFila(1) = ctNombre.Text
            nuevaFila(2) = ctObservaciones.Text
            nuevaFila(3) = ctEstado.Text
            cFilas.Add(nuevaFila)
            btUltimo.PerformClick()
            MostrarPosicion()
            ctNombre.Focus()

        Catch ex As System.Data.ConstraintException
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub btBorrar_Click(sender As Object, e As EventArgs) Handles btBorrar.Click
        Dim vistaFilaActual As DataRowView
        Dim NL As String = Environment.NewLine

        If (MessageBox.Show("Desea borrar este registro?" & NL, "Buscar",
                            MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes) Then
            vistaFilaActual = CiudadBindingSource.Current
            vistaFilaActual.Row.Delete()
            MostrarPosicion()
        End If
    End Sub

    Private Sub btBuscar_Click(sender As Object, e As EventArgs) Handles btBuscar.Click
        Dim miTabla As DataTable = DsCiudades.Ciudad
        Dim cFilas As DataRowCollection = miTabla.Rows
        Dim filaBuscada() As DataRow
        Dim NL As String = Environment.NewLine
        Dim criterio As String = "Nombre Like '*" & ctBuscar.Text & "*'"

        filaBuscada = miTabla.Select(criterio)
        If (filaBuscada.GetUpperBound(0) = 1) Then
            MessageBox.Show("No se encontraron registros coincidentes", "Buscar")
            Exit Sub
        End If

        Dim i, j As Integer
        For i = 0 To filaBuscada.GetUpperBound(0)
            If (MessageBox.Show("Este es el nombre buscado?" & NL & filaBuscada(i)(0) & Name, "Buscar", MessageBoxButtons.YesNo) = DialogResult.Yes) Then
                CiudadBindingSource.Position = cFilas.IndexOf(filaBuscada(i))
                MostrarPosicion()
                Exit For
            End If
        Next i
    End Sub
End Class
