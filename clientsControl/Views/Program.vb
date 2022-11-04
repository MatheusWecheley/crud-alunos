Imports System.Data.SqlClient

Public Class Program
    Private Sub btnPesquisar_Click(sender As Object, e As EventArgs) Handles btnPesquisar.Click

        Dim sql As ISQLRepository = New SQLImplementation()
        Dim str = GetStrCon()

        Dim requisao = sql.consultarDados()
        DataGridView1.DataSource = requisao

    End Sub
End Class