﻿Imports System.Data.SqlClient

Module Conexion
    Public Function GetConnection() As SqlConnection
        Dim connectionString As String = "Server=LAPTOP-8632NMPI\SQLEXPRESS;Database=Equiposs_Medicoss;Integrated Security=True;"
        Dim conn As New SqlConnection(connectionString)
        Try
            conn.Open()
        Catch ex As Exception
            MessageBox.Show("Error al conectar: " & ex.Message)
            Return Nothing
        End Try
        Return conn
    End Function
End Module
