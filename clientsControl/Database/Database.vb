Imports System.Data.SqlClient
Imports System.Drawing.Text
Imports System.Security.Cryptography.X509Certificates
Imports Microsoft.SqlServer
Module Database
    Private strCon As String
    Public server As String
    Public db As String
    Public user As String
    Public password As String

    Public Function GetStrCon()
        strCon = $"Data Source={server}; Integrated Security=false; Initial Catalog={db}; User ID={user}; Password={password}"
        Return strCon
    End Function




End Module
