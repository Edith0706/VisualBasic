﻿Public Class FormPrincipal
    Private Sub btnSeleccionarEquipo_Click(sender As Object, e As EventArgs) Handles btnSeleccionarEquipo.Click
        Dim formEquipos As New FormEquipos()
        formEquipos.ShowDialog()
    End Sub

    Private Sub btnAgregarEquipo_Click(sender As Object, e As EventArgs) Handles btnAgregarEquipo.Click
        Dim formAgregarEquipo As New FormAgregarEquipo()
        formAgregarEquipo.ShowDialog()
    End Sub

    Private Sub FormPrincipal_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
