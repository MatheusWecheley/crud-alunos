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

    Public Sub CriarTabelas()
        Try
            Dim str As String = GetStrCon()
            Dim conn As SqlConnection
            Dim cmd As SqlCommand
            Dim criarTabela = "if object_id('Usuarios') is null   
                 BEGIN
                 CREATE TABLE Usuarios (id int IDENTITY(1,1) PRIMARY KEY, nome varchar(255), sobrenome varchar(255), username varchar(255), senha varchar(255), cargo varchar(10))
                 END"

            conn = New SqlConnection(str)
            cmd = New SqlCommand(criarTabela, conn)
            cmd.Connection.Open()
            cmd.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox("Erro ao criar tabela! " & ex.Message)
        End Try
    End Sub

    'Private Function verificarTabelas()
    'Try
    'Dim str As String = GetStrCon()
    'Dim conn As SqlConnection
    'Dim cmd As SqlCommand
    'Dim comando As String = "SELECT "
    '
    'Catch ex As Exception

    'End Try
    'End Function
End Module
