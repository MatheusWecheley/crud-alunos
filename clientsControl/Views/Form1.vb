Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Database.server = serverText.Text
        Database.db = dbText.Text
        Database.user = userText.Text
        Database.password = passwordText.Text


        Dim program As New Program()

        ToolStripStatusLabel1.Text = "Conectando, aguarde..."
        Try
            GetStrCon()
            MsgBox("Conectado com sucesso!")
            ToolStripStatusLabel1.Text = "Conectado!"
            StatusStrip1.Refresh()
            program.Show()
            Me.Hide()
        Catch ex As Exception
            ToolStripStatusLabel1.Text = "Erro!"
            StatusStrip1.Refresh()
        End Try



    End Sub
End Class
