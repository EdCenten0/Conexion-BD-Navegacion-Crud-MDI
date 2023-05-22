Public Class Frm_Reporte
    Private Sub Frm_Reporte_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DBMonitoresUCADataSet.Ciudad' table. You can move, or remove it, as needed.
        Me.CiudadTableAdapter.Fill(Me.DBMonitoresUCADataSet.Ciudad)

        Me.ReportViewer1.RefreshReport()
    End Sub

    Private Sub ReportViewer1_Load(sender As Object, e As EventArgs) Handles ReportViewer1.Load

    End Sub
End Class