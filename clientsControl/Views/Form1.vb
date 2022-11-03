Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim server As String = serverText.Text
        Dim db As String = dbText.Text
        Dim user As String = userText.Text
        Dim password As String = passwordText.Text

        Dim connDb As Database = New Database()

        ToolStripStatusLabel1.Text = "Conectando, aguarde..."
        Try
            connDb.connectDatabase(server, db, user, password)
            ToolStripStatusLabel1.Text = "Conectado!"
            StatusStrip1.Refresh()

        Catch ex As Exception
            ToolStripStatusLabel1.Text = "Erro!"
            StatusStrip1.Refresh()
        End Try



    End Sub
End Class
