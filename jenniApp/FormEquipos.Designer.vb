<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormEquipos
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
        Me.cmbEquipos = New System.Windows.Forms.ComboBox()
        Me.btnVerMantenimiento = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'cmbEquipos
        '
        Me.cmbEquipos.FormattingEnabled = True
        Me.cmbEquipos.Location = New System.Drawing.Point(124, 37)
        Me.cmbEquipos.Name = "cmbEquipos"
        Me.cmbEquipos.Size = New System.Drawing.Size(170, 21)
        Me.cmbEquipos.TabIndex = 0
        '
        'btnVerMantenimiento
        '
        Me.btnVerMantenimiento.Location = New System.Drawing.Point(157, 129)
        Me.btnVerMantenimiento.Name = "btnVerMantenimiento"
        Me.btnVerMantenimiento.Size = New System.Drawing.Size(107, 43)
        Me.btnVerMantenimiento.TabIndex = 1
        Me.btnVerMantenimiento.Text = "Ver Mantenimiento"
        Me.btnVerMantenimiento.UseVisualStyleBackColor = True
        '
        'FormEquipos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(431, 335)
        Me.Controls.Add(Me.btnVerMantenimiento)
        Me.Controls.Add(Me.cmbEquipos)
        Me.Name = "FormEquipos"
        Me.Text = "FormEquipos"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents cmbEquipos As ComboBox
    Friend WithEvents btnVerMantenimiento As Button
End Class
