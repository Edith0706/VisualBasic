<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormAgregarEquipo
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
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.dtpFechaMtto = New System.Windows.Forms.DateTimePicker()
        Me.btnAgregar = New System.Windows.Forms.Button()
        Me.dtpProximoMtto = New System.Windows.Forms.DateTimePicker()
        Me.SuspendLayout()
        '
        'txtNombre
        '
        Me.txtNombre.Location = New System.Drawing.Point(169, 57)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(100, 20)
        Me.txtNombre.TabIndex = 0
        '
        'dtpFechaMtto
        '
        Me.dtpFechaMtto.Location = New System.Drawing.Point(115, 101)
        Me.dtpFechaMtto.Name = "dtpFechaMtto"
        Me.dtpFechaMtto.Size = New System.Drawing.Size(200, 20)
        Me.dtpFechaMtto.TabIndex = 1
        '
        'btnAgregar
        '
        Me.btnAgregar.Location = New System.Drawing.Point(169, 187)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(100, 40)
        Me.btnAgregar.TabIndex = 2
        Me.btnAgregar.Text = "Agregar"
        Me.btnAgregar.UseVisualStyleBackColor = True
        '
        'dtpProximoMtto
        '
        Me.dtpProximoMtto.Location = New System.Drawing.Point(115, 150)
        Me.dtpProximoMtto.Name = "dtpProximoMtto"
        Me.dtpProximoMtto.Size = New System.Drawing.Size(200, 20)
        Me.dtpProximoMtto.TabIndex = 3
        '
        'FormAgregarEquipo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(431, 335)
        Me.Controls.Add(Me.dtpProximoMtto)
        Me.Controls.Add(Me.btnAgregar)
        Me.Controls.Add(Me.dtpFechaMtto)
        Me.Controls.Add(Me.txtNombre)
        Me.Name = "FormAgregarEquipo"
        Me.Text = "FormAgregarEquipo"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtNombre As TextBox
    Friend WithEvents dtpFechaMtto As DateTimePicker
    Friend WithEvents btnAgregar As Button
    Friend WithEvents dtpProximoMtto As DateTimePicker
End Class
