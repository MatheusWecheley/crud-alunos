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
    End Sub
End Class