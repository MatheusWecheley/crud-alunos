Imports System.Data.SqlClient


Public Class SQLImplementation
    Implements ISQLRepository

    Public Function consultarDados() As Object Implements ISQLRepository.consultarDados

        Dim dataAdapter As SqlDataAdapter
        Dim bsource As New BindingSource()

        Try
            Dim str = GetStrCon()
            Dim conexao = New SqlConnection(str)

            Dim sql = "SELECT * FROM Pet"
            dataAdapter = New SqlDataAdapter(sql, conexao)
            conexao.Open()
            Dim ds As New DataSet()
            Dim commandBuilder As New SqlCommandBuilder(dataAdapter)
            dataAdapter.Fill(ds, "Orders")
            bsource.DataSource = ds.Tables("Orders")

            Return bsource
        Catch ex As Exception
            Return ex.Message
        End Try

        Return bsource
    End Function
End Class
