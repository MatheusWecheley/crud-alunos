Imports System.Data.SqlClient
Imports System.Drawing.Text
Imports System.Security.Cryptography.X509Certificates
Imports Microsoft.SqlServer
Module Database
    Private strCon As String

    Public Function GetStrCon()
        strCon = $"Data Source={My.Settings.YexConnectionServer}; Integrated Security=false; Initial Catalog={My.Settings.YexConnectionDb}; User ID={My.Settings.YexConnectionUser}; Password={My.Settings.YexConnectionPassword}"
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
