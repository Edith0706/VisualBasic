﻿Imports System.Data.SqlClient

Public Class FormAgregarEquipo
    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        Dim nombre As String = txtNombre.Text
        Dim fechaMtto As DateTime = dtpFechaMtto.Value
        Dim proximoMtto As DateTime = dtpProximoMtto.Value

        Dim conn As SqlConnection = Conexion.GetConnection()
        If conn IsNot Nothing Then
            Try
                ' Generar un nuevo id para el equipo
                Dim queryId As String = "SELECT MAX(id_Equipo) AS max_id FROM Equipo_Medico"
                Dim cmdId As New SqlCommand(queryId, conn)
                Dim resultId As SqlDataReader = cmdId.ExecuteReader()
                resultId.Read()
                Dim maxId As String = resultId("max_id").ToString()
                resultId.Close()
                Dim newId As String = "EQ" & (Integer.Parse(maxId.Substring(2)) + 1).ToString("D3")

                ' Insertar el nuevo equipo en la tabla Equipo_Medico
                Dim queryEquipo As String = "INSERT INTO Equipo_Medico (id_Equipo, Nombre_Activo, Folio, Marca, No_Serie, id_Ubi, id_SubUbi, idEstatus, idPertenencia, idMP) VALUES (@id_Equipo, @Nombre_Activo, 'FOL999', 'Generica', '999999', 'U001', 1, 1, 1, 1)"
                Dim cmdEquipo As New SqlCommand(queryEquipo, conn)
                cmdEquipo.Parameters.AddWithValue("@id_Equipo", newId)
                cmdEquipo.Parameters.AddWithValue("@Nombre_Activo", nombre)
                Dim resultEquipo As Integer = cmdEquipo.ExecuteNonQuery()

                ' Insertar la información del mantenimiento preventivo
                Dim queryMtto As String = "INSERT INTO MantenimientosPreventivos (id_Equipo, fechaMtto, proximoMtto) VALUES (@id_Equipo, @fechaMtto, @proximoMtto)"
                Dim cmdMtto As New SqlCommand(queryMtto, conn)
                cmdMtto.Parameters.AddWithValue("@id_Equipo", newId)
                cmdMtto.Parameters.AddWithValue("@fechaMtto", fechaMtto)
                cmdMtto.Parameters.AddWithValue("@proximoMtto", proximoMtto)
                Dim resultMtto As Integer = cmdMtto.ExecuteNonQuery()

                If resultEquipo > 0 And resultMtto > 0 Then
                    MessageBox.Show("Equipo agregado exitosamente")
                Else
                    MessageBox.Show("Error al agregar equipo")
                End If
            Catch ex As Exception
                MessageBox.Show("Error: " & ex.Message)
            Finally
                conn.Close()
            End Try
        End If
    End Sub

    Private Sub FormAgregarEquipo_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
