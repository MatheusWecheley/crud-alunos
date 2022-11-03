Imports System.Data.SqlClient
Imports System.Drawing.Text
Imports System.Security.Cryptography.X509Certificates

Public Class Database

    Public Sub connectDatabase(server As String, db As String, user As String, password As String)
        Dim strCon As String = $"Data Source={server}; Integrated Security=true; Initial Catalog={db}; User ID={user}, Password={password}"
        Dim program As Program = New Program()

        Try
            Using connection = New SqlConnection(strCon)
                connection.Open()
                MsgBox("Conectado com sucesso!")
                program.Show()
                Form1.Hide()
            End Using
        Catch ex As Exception
            MsgBox("Erro ao se conectar ao banco de dados!" & vbNewLine & vbNewLine & ex.Message, vbCritical)
        End Try
    End Sub

End Class
