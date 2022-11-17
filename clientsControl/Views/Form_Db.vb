Public Class Form_Db

    'Realiza a validação dos campos se estão preenchidos.
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

    'Seta os valores das texts boxs nas strings de conexões do projeto, para que fique salvo e não precise preencher toda vez que inicia a aplicação
    Private Sub btnConectar_Click(sender As Object, e As EventArgs) Handles btnConectar.Click

        ToolStripStatusLabel1.Text = "Conectando, aguarde..."


        If ValidaCamposBD() = False Then Exit Sub

        Try
            My.Settings.YexConnectionServer = serverText.Text
            My.Settings.YexConnectionDb = dbText.Text
            My.Settings.YexConnectionUser = userText.Text
            My.Settings.YexConnectionPassword = passwordText.Text
            My.Settings.Save()
            My.Settings.Reload()
            SetStrCon(My.Settings.YexConnectionServer, My.Settings.YexConnectionDb, My.Settings.YexConnectionUser, My.Settings.YexConnectionPassword)
            Dim str = GetStrCon()

            Dim conexao = TestarConexao(str)

            If conexao = True Then
                ToolStripStatusLabel1.Text = "Conectado!"
                StatusStrip1.Refresh()
                Me.Refresh()
                MsgBox("Conectado com sucesso!", MsgBoxStyle.Information, "Sucesso")
                MsgBox("Necessário reiniciar a aplicação!", MsgBoxStyle.Information, "Atenção")
                Me.Dispose()
            End If

        Catch ex As Exception
            ToolStripStatusLabel1.Text = "Erro!"
            StatusStrip1.Refresh()
        Finally

            My.Settings.Save()
            My.Settings.Reload()
        End Try

    End Sub

    'Sai da aplicação
    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Dim pergunta = MsgBox("Tem certeza que deseja sair da aplicação?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Atenção")
        If pergunta = vbYes Then
            Me.Dispose()
        End If
    End Sub


    'Testa conexão assim que inicia aplicação, caso retorne true, inicia automaticamente o Form_Alunos
    Private Sub Form_Db_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        If My.Settings.YexConnectionServer = "" Then
            Me.Show()
        Else
            SetStrCon(My.Settings.YexConnectionServer, My.Settings.YexConnectionDb, My.Settings.YexConnectionUser, My.Settings.YexConnectionPassword)
            Dim str = GetStrCon()
            Dim conexao = TestarConexao(str)

            If conexao = True Then
                Me.Dispose()
                Form_Alunos.Show()
            Else
                Me.Refresh()
            End If
        End If

    End Sub
End Class
