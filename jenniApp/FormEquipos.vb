﻿Imports System.Data.SqlClient

Public Class FormEquipos
    Private Sub FormEquipos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadEquipos()
    End Sub

    Private Sub LoadEquipos()
        Dim conn As SqlConnection = Conexion.GetConnection()
        If conn IsNot Nothing Then
            Dim sql As String = "SELECT Nombre_Activo FROM Equipo_Medico"
            Dim cmd As New SqlCommand(sql, conn)

            Try
                Dim reader As SqlDataReader = cmd.ExecuteReader()
                While reader.Read()
                    cmbEquipos.Items.Add(reader("Nombre_Activo").ToString())
                End While
            Catch ex As Exception
                MessageBox.Show("Error: " & ex.Message)
            Finally
                conn.Close()
            End Try
        End If
    End Sub

    Private Sub btnVerMantenimiento_Click(sender As Object, e As EventArgs) Handles btnVerMantenimiento.Click
        If cmbEquipos.SelectedIndex <> -1 Then
            Dim mantenimientoForm As New FormMantenimiento(cmbEquipos.SelectedItem.ToString())
            mantenimientoForm.ShowDialog()
        Else
            MessageBox.Show("Seleccione un equipo médico.")
        End If
    End Sub
End Class
