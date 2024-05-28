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
        Me.btnSeleccionarEquipo = New System.Windows.Forms.Button()
        Me.btnAgregarEquipo = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnSeleccionarEquipo
        '
        Me.btnSeleccionarEquipo.Location = New System.Drawing.Point(47, 30)
        Me.btnSeleccionarEquipo.Name = "btnSeleccionarEquipo"
        Me.btnSeleccionarEquipo.Size = New System.Drawing.Size(75, 23)
        Me.btnSeleccionarEquipo.TabIndex = 0
        Me.btnSeleccionarEquipo.Text = "Button1"
        Me.btnSeleccionarEquipo.UseVisualStyleBackColor = True
        '
        'btnAgregarEquipo
        '
        Me.btnAgregarEquipo.Location = New System.Drawing.Point(47, 88)
        Me.btnAgregarEquipo.Name = "btnAgregarEquipo"
        Me.btnAgregarEquipo.Size = New System.Drawing.Size(75, 23)
        Me.btnAgregarEquipo.TabIndex = 1
        Me.btnAgregarEquipo.Text = "Button2"
        Me.btnAgregarEquipo.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnAgregarEquipo)
        Me.Controls.Add(Me.btnSeleccionarEquipo)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnSeleccionarEquipo As Button
    Friend WithEvents btnAgregarEquipo As Button
End Class
