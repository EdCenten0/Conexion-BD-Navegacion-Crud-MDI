<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_Reporte
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim ReportDataSource1 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.DBMonitoresUCADataSet = New MonitoresUCA1.DBMonitoresUCADataSet()
        Me.CiudadBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CiudadTableAdapter = New MonitoresUCA1.DBMonitoresUCADataSetTableAdapters.CiudadTableAdapter()
        CType(Me.DBMonitoresUCADataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CiudadBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ReportViewer1
        '
        ReportDataSource1.Name = "reporte_ciudades"
        ReportDataSource1.Value = Me.CiudadBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "MonitoresUCA1.Report1.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(13, 13)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.ServerReport.BearerToken = Nothing
        Me.ReportViewer1.Size = New System.Drawing.Size(785, 331)
        Me.ReportViewer1.TabIndex = 0
        '
        'DBMonitoresUCADataSet
        '
        Me.DBMonitoresUCADataSet.DataSetName = "DBMonitoresUCADataSet"
        Me.DBMonitoresUCADataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'CiudadBindingSource
        '
        Me.CiudadBindingSource.DataMember = "Ciudad"
        Me.CiudadBindingSource.DataSource = Me.DBMonitoresUCADataSet
        '
        'CiudadTableAdapter
        '
        Me.CiudadTableAdapter.ClearBeforeFill = True
        '
        'Frm_Reporte
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Name = "Frm_Reporte"
        Me.Text = "Frm_Reporte"
        CType(Me.DBMonitoresUCADataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CiudadBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents CiudadBindingSource As BindingSource
    Friend WithEvents DBMonitoresUCADataSet As DBMonitoresUCADataSet
    Friend WithEvents CiudadTableAdapter As DBMonitoresUCADataSetTableAdapters.CiudadTableAdapter
End Class
