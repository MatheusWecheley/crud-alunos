Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        If (serverText.Text) = "" Then
            MsgBox("O campo servidor precisa ser preenchido!" & vbNewLine & vbNewLine & vbCritical)
        ElseIf (dbText.Text) = "" Then
            MsgBox("O campo do banco de dados precisa ser preenchido!" & vbNewLine & vbNewLine & vbCritical)
        ElseIf (userText.Text) = "" Then
            MsgBox("O campo do banco de dados precisa ser preenchido!" & vbNewLine & vbNewLine & vbCritical)
        ElseIf (passwordText.Text) = "" Then
            MsgBox("O campo do banco de dados precisa ser preenchido!" & vbNewLine & vbNewLine & vbCritical)
        End If


        Database.server = serverText.Text
            Database.db = dbText.Text
            Database.user = userText.Text
            Database.password = passwordText.Text


            Dim program As New Program()

            ToolStripStatusLabel1.Text = "Conectando, aguarde..."
        Try
            Dim str = GetStrCon()
            Dim conexao = TestarConexao(str)
            If (conexao) = True Then
                MsgBox("Conectado com sucesso!")
                ToolStripStatusLabel1.Text = "Conectado!"
                StatusStrip1.Refresh()
                program.Show()
                Me.Hide()
            End If
        Catch ex As Exception
            ToolStripStatusLabel1.Text = "Erro!"
                StatusStrip1.Refresh()
            End Try



    End Sub
End Class
