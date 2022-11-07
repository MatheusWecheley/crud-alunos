Imports System.Data.SqlClient
Imports System.Drawing.Text
Imports System.Security.Cryptography.X509Certificates
Imports Microsoft.SqlServer
Module Database
    Private strCon As String
    Private ReadOnly server = My.Settings.YexConnectionServer.ToString
    Private ReadOnly db = My.Settings.YexConnectionDb.ToString
    Private ReadOnly user = My.Settings.YexConnectionUser.ToString
    Private ReadOnly password = My.Settings.YexConnectionPassword.ToString

    Public Function GetStrCon()
        strCon = $"Data Source={server}; Integrated Security=false; Initial Catalog={db}; User ID={user}; Password={password}"
        Return strCon
    End Function

    Public Function TestarConexao(strCon As String)
        Try
            Dim conn = New SqlConnection(strCon)
            conn.Open()
            Return True
        Catch ex As Exception
            Return MsgBox("Erro ao se conectar com o banco de dados!" & vbNewLine & vbNewLine & ex.Message, vbCritical)
            Return False
        End Try
    End Function
End Module
