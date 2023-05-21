<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormPadre
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.menuArchivo = New System.Windows.Forms.ToolStripMenuItem()
        Me.archivoCerrar = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuFormularios = New System.Windows.Forms.ToolStripMenuItem()
        Me.opFormularioCRUD = New System.Windows.Forms.ToolStripMenuItem()
        Me.opFormularioA = New System.Windows.Forms.ToolStripMenuItem()
        Me.opFormularioB = New System.Windows.Forms.ToolStripMenuItem()
        Me.opFormularioC = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuReportes = New System.Windows.Forms.ToolStripMenuItem()
        Me.opReportes1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.opReportes2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.opReportes3 = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.menuArchivo, Me.menuFormularios, Me.menuReportes})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(800, 28)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'menuArchivo
        '
        Me.menuArchivo.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.archivoCerrar})
        Me.menuArchivo.Name = "menuArchivo"
        Me.menuArchivo.Size = New System.Drawing.Size(73, 24)
        Me.menuArchivo.Text = "Archivo"
        '
        'archivoCerrar
        '
        Me.archivoCerrar.Name = "archivoCerrar"
        Me.archivoCerrar.Size = New System.Drawing.Size(224, 26)
        Me.archivoCerrar.Text = "Cerrar"
        '
        'menuFormularios
        '
        Me.menuFormularios.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.opFormularioCRUD, Me.opFormularioA, Me.opFormularioB, Me.opFormularioC})
        Me.menuFormularios.Name = "menuFormularios"
        Me.menuFormularios.Size = New System.Drawing.Size(101, 24)
        Me.menuFormularios.Text = "Formularios"
        '
        'opFormularioCRUD
        '
        Me.opFormularioCRUD.Name = "opFormularioCRUD"
        Me.opFormularioCRUD.Size = New System.Drawing.Size(224, 26)
        Me.opFormularioCRUD.Text = "Formulario CRUD"
        '
        'opFormularioA
        '
        Me.opFormularioA.Name = "opFormularioA"
        Me.opFormularioA.Size = New System.Drawing.Size(224, 26)
        Me.opFormularioA.Text = "Formulario A"
        '
        'opFormularioB
        '
        Me.opFormularioB.Name = "opFormularioB"
        Me.opFormularioB.Size = New System.Drawing.Size(224, 26)
        Me.opFormularioB.Text = "Formulario B"
        '
        'opFormularioC
        '
        Me.opFormularioC.Name = "opFormularioC"
        Me.opFormularioC.Size = New System.Drawing.Size(224, 26)
        Me.opFormularioC.Text = "Formulario C"
        '
        'menuReportes
        '
        Me.menuReportes.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.opReportes1, Me.opReportes2, Me.opReportes3})
        Me.menuReportes.Name = "menuReportes"
        Me.menuReportes.Size = New System.Drawing.Size(82, 24)
        Me.menuReportes.Text = "Reportes"
        '
        'opReportes1
        '
        Me.opReportes1.Name = "opReportes1"
        Me.opReportes1.Size = New System.Drawing.Size(224, 26)
        Me.opReportes1.Text = "Reporte 1"
        '
        'opReportes2
        '
        Me.opReportes2.Name = "opReportes2"
        Me.opReportes2.Size = New System.Drawing.Size(224, 26)
        Me.opReportes2.Text = "Reporte 2"
        '
        'opReportes3
        '
        Me.opReportes3.Name = "opReportes3"
        Me.opReportes3.Size = New System.Drawing.Size(224, 26)
        Me.opReportes3.Text = "Reporte 3"
        '
        'FormPadre
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.MenuStrip1)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "FormPadre"
        Me.Text = "FormPadre"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents menuArchivo As ToolStripMenuItem
    Friend WithEvents archivoCerrar As ToolStripMenuItem
    Friend WithEvents menuFormularios As ToolStripMenuItem
    Friend WithEvents opFormularioCRUD As ToolStripMenuItem
    Friend WithEvents opFormularioA As ToolStripMenuItem
    Friend WithEvents opFormularioB As ToolStripMenuItem
    Friend WithEvents opFormularioC As ToolStripMenuItem
    Friend WithEvents menuReportes As ToolStripMenuItem
    Friend WithEvents opReportes1 As ToolStripMenuItem
    Friend WithEvents opReportes2 As ToolStripMenuItem
    Friend WithEvents opReportes3 As ToolStripMenuItem
End Class
