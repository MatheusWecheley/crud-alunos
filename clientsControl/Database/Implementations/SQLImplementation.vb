Imports System.Data.SqlClient


Public Class SQLImplementation
    Implements ISQLRepository

    Public Function consultarDados(dataGrid As DataGrid) As Object Implements ISQLRepository.consultarDados

        Try
            Dim str = GetStrCon()

            Using conexao = New SqlConnection(str)
                conexao.Open()
                Dim sql = "SELECT * FROM Pet"
                Using dataAdapter = New SqlDataAdapter(sql, conexao)
                    Using dt = New DataTable()
                        dataAdapter.Fill(dt)
                        dataGrid.DataSource = dt
                    End Using
                End Using
            End Using
        Catch ex As Exception

        End Try

        Return vbNull
    End Function
End Class
