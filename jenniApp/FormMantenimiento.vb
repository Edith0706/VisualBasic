﻿Imports System.Data.SqlClient

Public Class FormMantenimiento
    Private equipo As String

    Public Sub New(equipoSeleccionado As String)
        InitializeComponent()
        equipo = equipoSeleccionado
    End Sub

    Private Sub FormMantenimiento_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadMantenimiento()
    End Sub

    Private Sub LoadMantenimiento()
        Dim conn As SqlConnection = Conexion.GetConnection()
        If conn IsNot Nothing Then
            Dim sql As String = "SELECT proximoMtto FROM MantenimientosPreventivos WHERE id_Equipo = (SELECT id_Equipo FROM Equipo_Medico WHERE Nombre_Activo = @Nombre_Activo)"
            Dim cmd As New SqlCommand(sql, conn)
            cmd.Parameters.AddWithValue("@Nombre_Activo", equipo)

            Try
                Dim reader As SqlDataReader = cmd.ExecuteReader()
                If reader.Read() Then
                    lblProximoMantenimiento.Text = "El próximo mantenimiento es el: " & reader("proximoMtto").ToString()
                Else
                    lblProximoMantenimiento.Text = "No se encontró información de mantenimiento para el equipo seleccionado."
                End If
            Catch ex As Exception
                MessageBox.Show("Error: " & ex.Message)
            Finally
                conn.Close()
            End Try
        End If
    End Sub

    Private Sub btnVolver_Click(sender As Object, e As EventArgs) Handles btnVolver.Click
        Me.Close()
    End Sub
End Class
