Imports System.Data.SqlClient

Public Class Form_Usuarios

    Private Function ValidarCampos() As Boolean
        If txtNome.Text = "" Then
            MsgBox("Por favor, informe o nome do usuário!", MsgBoxStyle.Exclamation)
            Return False
        ElseIf txtSobrenome.Text = "" Then
            MsgBox("Por favor, informe o sobrenome do usuário!", MsgBoxStyle.Exclamation)
            Return False
        ElseIf txtUsuario.Text = "" Then
            MsgBox("Por favor, informe o usuario!", MsgBoxStyle.Exclamation)
            Return False
        ElseIf txtSenha.Text = "" Then
            MsgBox("Por favor, informe a senha do usuário!", MsgBoxStyle.Exclamation)
            Return False
        ElseIf txtConfirmaSenha.Text <> txtSenha.Text Then
            MsgBox("Senhas não compativeis!", MsgBoxStyle.Exclamation)
            Return False
        End If
        Return True
    End Function

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If ValidarCampos() = False Then Exit Sub
        Dim user As Usuario = New Usuario()
        Dim _userRepository As IUsuarioRepository = New SQLUsuarioImplementation()

        user.GetNome = txtNome.Text
        user.GetSobrenome = txtSobrenome.Text
        user.GetUsername = txtUsuario.Text
        user.GetSenha = txtSenha.Text
        user.GetCargo = txtCargo.Text

        Try
            Dim response = _userRepository.CriarUsuario(user)
            If response = True Then
                MsgBox("Usuario Criado com sucesso!", MsgBoxStyle.Information)
            End If
        Catch ex As Exception
            MsgBox("Erro ao criar um usuario!" & vbNewLine & vbNewLine & ex.Message, MsgBoxStyle.Exclamation)
        End Try

    End Sub
End Class