<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.components = New System.ComponentModel.Container()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.ctId = New System.Windows.Forms.TextBox()
        Me.ctNombre = New System.Windows.Forms.TextBox()
        Me.ctEstado = New System.Windows.Forms.TextBox()
        Me.ctObservaciones = New System.Windows.Forms.TextBox()
        Me.btAñadir = New System.Windows.Forms.Button()
        Me.btBorrar = New System.Windows.Forms.Button()
        Me.btGuardar = New System.Windows.Forms.Button()
        Me.btBuscar = New System.Windows.Forms.Button()
        Me.ctBuscar = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.btPrimero = New System.Windows.Forms.Button()
        Me.btAnterior = New System.Windows.Forms.Button()
        Me.btSiguiente = New System.Windows.Forms.Button()
        Me.btUltimo = New System.Windows.Forms.Button()
        Me.etPosicion = New System.Windows.Forms.Label()
        Me.DsCiudades = New MonitoresUCA1.dsCiudades()
        Me.CiudadBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CiudadTableAdapter = New MonitoresUCA1.dsCiudadesTableAdapters.CiudadTableAdapter()
        Me.Panel1.SuspendLayout()
        CType(Me.DsCiudades, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CiudadBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.etPosicion)
        Me.Panel1.Controls.Add(Me.btUltimo)
        Me.Panel1.Controls.Add(Me.btSiguiente)
        Me.Panel1.Controls.Add(Me.btAnterior)
        Me.Panel1.Controls.Add(Me.btPrimero)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.ctBuscar)
        Me.Panel1.Controls.Add(Me.btBuscar)
        Me.Panel1.Controls.Add(Me.btGuardar)
        Me.Panel1.Controls.Add(Me.btBorrar)
        Me.Panel1.Controls.Add(Me.btAñadir)
        Me.Panel1.Controls.Add(Me.ctObservaciones)
        Me.Panel1.Controls.Add(Me.ctEstado)
        Me.Panel1.Controls.Add(Me.ctNombre)
        Me.Panel1.Controls.Add(Me.ctId)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(960, 536)
        Me.Panel1.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(387, 41)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(191, 25)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Listado de Ciudades"
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(72, 143)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(27, 20)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Id:"
        '
        'Label3
        '
        Me.Label3.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(72, 200)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(73, 20)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Nombre:"
        '
        'Label4
        '
        Me.Label4.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(72, 257)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(66, 20)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Estado:"
        '
        'Label5
        '
        Me.Label5.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(72, 311)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(108, 20)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Observacion:"
        '
        'ctId
        '
        Me.ctId.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CiudadBindingSource, "id", True))
        Me.ctId.Location = New System.Drawing.Point(187, 143)
        Me.ctId.Name = "ctId"
        Me.ctId.Size = New System.Drawing.Size(179, 22)
        Me.ctId.TabIndex = 5
        '
        'ctNombre
        '
        Me.ctNombre.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CiudadBindingSource, "nombre", True))
        Me.ctNombre.Location = New System.Drawing.Point(187, 198)
        Me.ctNombre.Name = "ctNombre"
        Me.ctNombre.Size = New System.Drawing.Size(179, 22)
        Me.ctNombre.TabIndex = 6
        '
        'ctEstado
        '
        Me.ctEstado.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CiudadBindingSource, "estado", True))
        Me.ctEstado.Location = New System.Drawing.Point(187, 257)
        Me.ctEstado.Name = "ctEstado"
        Me.ctEstado.Size = New System.Drawing.Size(179, 22)
        Me.ctEstado.TabIndex = 7
        '
        'ctObservaciones
        '
        Me.ctObservaciones.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CiudadBindingSource, "observaciones", True))
        Me.ctObservaciones.Location = New System.Drawing.Point(186, 309)
        Me.ctObservaciones.Multiline = True
        Me.ctObservaciones.Name = "ctObservaciones"
        Me.ctObservaciones.Size = New System.Drawing.Size(179, 84)
        Me.ctObservaciones.TabIndex = 8
        '
        'btAñadir
        '
        Me.btAñadir.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btAñadir.Location = New System.Drawing.Point(772, 143)
        Me.btAñadir.Name = "btAñadir"
        Me.btAñadir.Size = New System.Drawing.Size(132, 33)
        Me.btAñadir.TabIndex = 9
        Me.btAñadir.Text = "Añadir"
        Me.btAñadir.UseVisualStyleBackColor = True
        '
        'btBorrar
        '
        Me.btBorrar.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btBorrar.Location = New System.Drawing.Point(772, 200)
        Me.btBorrar.Name = "btBorrar"
        Me.btBorrar.Size = New System.Drawing.Size(132, 35)
        Me.btBorrar.TabIndex = 10
        Me.btBorrar.Text = "Borrar"
        Me.btBorrar.UseVisualStyleBackColor = True
        '
        'btGuardar
        '
        Me.btGuardar.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btGuardar.Location = New System.Drawing.Point(772, 257)
        Me.btGuardar.Name = "btGuardar"
        Me.btGuardar.Size = New System.Drawing.Size(132, 36)
        Me.btGuardar.TabIndex = 11
        Me.btGuardar.Text = "Guardar"
        Me.btGuardar.UseVisualStyleBackColor = True
        '
        'btBuscar
        '
        Me.btBuscar.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btBuscar.Location = New System.Drawing.Point(772, 311)
        Me.btBuscar.Name = "btBuscar"
        Me.btBuscar.Size = New System.Drawing.Size(132, 33)
        Me.btBuscar.TabIndex = 12
        Me.btBuscar.Text = "Buscar"
        Me.btBuscar.UseVisualStyleBackColor = True
        '
        'ctBuscar
        '
        Me.ctBuscar.Location = New System.Drawing.Point(772, 371)
        Me.ctBuscar.Name = "ctBuscar"
        Me.ctBuscar.Size = New System.Drawing.Size(132, 22)
        Me.ctBuscar.TabIndex = 13
        '
        'Label6
        '
        Me.Label6.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(698, 373)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(68, 20)
        Me.Label6.TabIndex = 14
        Me.Label6.Text = "Buscar:"
        '
        'btPrimero
        '
        Me.btPrimero.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btPrimero.Location = New System.Drawing.Point(101, 465)
        Me.btPrimero.Name = "btPrimero"
        Me.btPrimero.Size = New System.Drawing.Size(132, 33)
        Me.btPrimero.TabIndex = 15
        Me.btPrimero.Text = "Primero"
        Me.btPrimero.UseVisualStyleBackColor = True
        '
        'btAnterior
        '
        Me.btAnterior.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btAnterior.Location = New System.Drawing.Point(284, 465)
        Me.btAnterior.Name = "btAnterior"
        Me.btAnterior.Size = New System.Drawing.Size(132, 33)
        Me.btAnterior.TabIndex = 16
        Me.btAnterior.Text = "Anterior"
        Me.btAnterior.UseVisualStyleBackColor = True
        '
        'btSiguiente
        '
        Me.btSiguiente.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btSiguiente.Location = New System.Drawing.Point(608, 465)
        Me.btSiguiente.Name = "btSiguiente"
        Me.btSiguiente.Size = New System.Drawing.Size(132, 33)
        Me.btSiguiente.TabIndex = 17
        Me.btSiguiente.Text = "Siguiente"
        Me.btSiguiente.UseVisualStyleBackColor = True
        '
        'btUltimo
        '
        Me.btUltimo.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btUltimo.Location = New System.Drawing.Point(782, 465)
        Me.btUltimo.Name = "btUltimo"
        Me.btUltimo.Size = New System.Drawing.Size(132, 33)
        Me.btUltimo.TabIndex = 18
        Me.btUltimo.Text = "Ultimo"
        Me.btUltimo.UseVisualStyleBackColor = True
        '
        'etPosicion
        '
        Me.etPosicion.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.etPosicion.AutoSize = True
        Me.etPosicion.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etPosicion.Location = New System.Drawing.Point(448, 471)
        Me.etPosicion.Name = "etPosicion"
        Me.etPosicion.Size = New System.Drawing.Size(130, 20)
        Me.etPosicion.TabIndex = 19
        Me.etPosicion.Text = "No de Registros"
        '
        'DsCiudades
        '
        Me.DsCiudades.DataSetName = "dsCiudades"
        Me.DsCiudades.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'CiudadBindingSource
        '
        Me.CiudadBindingSource.DataMember = "Ciudad"
        Me.CiudadBindingSource.DataSource = Me.DsCiudades
        '
        'CiudadTableAdapter
        '
        Me.CiudadTableAdapter.ClearBeforeFill = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(960, 536)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "Form1"
        Me.Text = "Tabla de ciudades"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.DsCiudades, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CiudadBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents btBuscar As Button
    Friend WithEvents btGuardar As Button
    Friend WithEvents btBorrar As Button
    Friend WithEvents btAñadir As Button
    Friend WithEvents ctObservaciones As TextBox
    Friend WithEvents ctEstado As TextBox
    Friend WithEvents ctNombre As TextBox
    Friend WithEvents ctId As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents ctBuscar As TextBox
    Friend WithEvents etPosicion As Label
    Friend WithEvents btUltimo As Button
    Friend WithEvents btSiguiente As Button
    Friend WithEvents btAnterior As Button
    Friend WithEvents btPrimero As Button
    Friend WithEvents DsCiudades As dsCiudades
    Friend WithEvents CiudadBindingSource As BindingSource
    Friend WithEvents CiudadTableAdapter As dsCiudadesTableAdapters.CiudadTableAdapter
End Class
