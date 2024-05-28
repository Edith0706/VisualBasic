<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormMantenimiento
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
        Me.lblProximoMantenimiento = New System.Windows.Forms.Label()
        Me.btnVolver = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblProximoMantenimiento
        '
        Me.lblProximoMantenimiento.AutoSize = True
        Me.lblProximoMantenimiento.Location = New System.Drawing.Point(184, 141)
        Me.lblProximoMantenimiento.Name = "lblProximoMantenimiento"
        Me.lblProximoMantenimiento.Size = New System.Drawing.Size(39, 13)
        Me.lblProximoMantenimiento.TabIndex = 0
        Me.lblProximoMantenimiento.Text = "Label1"
        '
        'btnVolver
        '
        Me.btnVolver.Location = New System.Drawing.Point(33, 12)
        Me.btnVolver.Name = "btnVolver"
        Me.btnVolver.Size = New System.Drawing.Size(75, 23)
        Me.btnVolver.TabIndex = 1
        Me.btnVolver.Text = "Regresar"
        Me.btnVolver.UseVisualStyleBackColor = True
        '
        'FormMantenimiento
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(431, 335)
        Me.Controls.Add(Me.btnVolver)
        Me.Controls.Add(Me.lblProximoMantenimiento)
        Me.Name = "FormMantenimiento"
        Me.Text = "FormMantenimiento"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblProximoMantenimiento As Label
    Friend WithEvents btnVolver As Button
End Class
