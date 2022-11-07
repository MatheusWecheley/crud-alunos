Public Class Form_Db

    Private Function ValidaCamposBD()
        If serverText.Text = "" Then
            MsgBox("O campo servidor precisa ser preenchido!" & vbNewLine & vbNewLine & vbCritical)
            Return False
        ElseIf dbText.Text = "" Then
            MsgBox("O campo do banco de dados precisa ser preenchido!" & vbNewLine & vbNewLine & vbCritical)
            Return False
        ElseIf userText.Text = "" Then
            MsgBox("O campo do banco de dados precisa ser preenchido!" & vbNewLine & vbNewLine & vbCritical)
            Return False
        ElseIf passwordText.Text = "" Then
            MsgBox("O campo do banco de dados precisa ser preenchido!" & vbNewLine & vbNewLine & vbCritical)
            Return False
        End If
        Return True
    End Function

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        If ValidaCamposBD() = False Then Exit Sub

        My.Settings.YexConnectionServer = serverText.Text
        My.Settings.YexConnectionDb = dbText.Text
        My.Settings.YexConnectionUser = userText.Text
        My.Settings.YexConnectionPassword = passwordText.Text
        My.Settings.Save()
        My.Settings.Reload()
        Dim str = GetStrCon()

        ToolStripStatusLabel1.Text = "Conectando, aguarde..."

        Try
            Dim conexao = TestarConexao(str)
            If (conexao) = True Then
                MsgBox("Conectado com sucesso!", MsgBoxStyle.Information, "Sucesso")
                ToolStripStatusLabel1.Text = "Conectado!"
                StatusStrip1.Refresh()
                Me.Hide()
                Form_Usuarios.Show()
            End If
        Catch ex As Exception
            ToolStripStatusLabel1.Text = "Erro!"
            StatusStrip1.Refresh()
        End Try
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Dim pergunta = MsgBox("Tem certeza que deseja sair da aplicação?", MsgBoxStyle.Question + MsgBoxStyle.YesNo)
        If pergunta <> vbYes Then Exit Sub
        End
    End Sub


    Private Sub Form_Db_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim str = GetStrCon()
        Dim conexao = TestarConexao(str)

        If conexao = True Then
            Me.Dispose()
            Form_Usuarios.Show()
        End If
    End Sub
End Class
