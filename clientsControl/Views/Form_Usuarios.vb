Imports System.IO.Ports
Imports System.Runtime.CompilerServices

Public Class Form_Usuarios

    Private Sub LimparCampos()
        txtNome.Text = ""
        txtSobrenome.Text = ""
        txtUsuario.Text = ""
        txtSenha.Text = ""
        txtConfirmaSenha.Text = ""
        txtCargo.Text = ""
    End Sub

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

    Private Sub bntSalvar_Click(sender As Object, e As EventArgs) Handles btnSalvar.Click
        If ValidarCampos() = False Then Exit Sub
        Dim user As Usuario = New Usuario()
        Dim _userService As UsuarioServices = New UsuarioServices()

        If txtID.Text = "" Then
            user.GetNome = txtNome.Text
            user.GetSobrenome = txtSobrenome.Text
            user.GetUsername = txtUsuario.Text
            user.GetSenha = txtSenha.Text
            user.GetCargo = txtCargo.Text

            Try
                Dim response = _userService.AdicionarUsuario(user)
                If response = True Then
                    MsgBox("Usuario Criado com sucesso!", MsgBoxStyle.Information, "Sucesso!")
                    LimparCampos()
                Else
                    MsgBox("Usuario já existente, tente outro usuário!", MsgBoxStyle.Exclamation, "Usuario Existente")
                End If
            Catch ex As Exception
                MsgBox("Erro ao criar um usuario!" & vbNewLine & vbNewLine & ex.Message, MsgBoxStyle.Critical)
            End Try
        Else
            MsgBox("Usuario com o ID: " & txtID.Text & " não pode ser alterado")
        End If



    End Sub

    Private Sub Form_Usuarios_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim _userService As UsuarioServices = New UsuarioServices()
        Try
            Dim tabelas = CriarTabelas()
            If tabelas = True Then
                MsgBox("Criado tabelas para uso!", MsgBoxStyle.Information, "Criando tabelas")
                Dim response = _userService.BuscarUsuarios()
                dtGridUsuarios.DataSource = response
            End If
        Catch ex As Exception
            MsgBox("Erro ao criar tabelas!" & ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub btnTrocarBd_Click(sender As Object, e As EventArgs) Handles btnTrocarBd.Click
        My.Settings.YexConnectionServer = ""
        Me.Hide()
        Form_Db.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        LimparCampos()
    End Sub

    Private Sub btnAtualizar_Click(sender As Object, e As EventArgs) Handles btnAtualizar.Click
        Dim _userService As UsuarioServices = New UsuarioServices()
        Dim response = _userService.BuscarUsuarios()
        dtGridUsuarios.DataSource = response
    End Sub

    Private Sub btnPesquisar_Click(sender As Object, e As EventArgs) Handles btnPesquisar.Click
        Dim _userServices As UsuarioServices = New UsuarioServices()
        Dim result = _userServices.PegarUsuarioPorID(txtPesquisar.Text)
        dtGridUsuarios.DataSource = result
    End Sub

    Private Sub txtPesquisar_KeyDown(sender As Object, e As KeyEventArgs) Handles txtPesquisar.KeyDown
        If e.KeyCode = Keys.Enter Then
            btnPesquisar_Click(sender, e)
        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click

        Dim resposta = MsgBox("Deseja mesmo excluir este usuario?", MsgBoxStyle.YesNo, "Atenção!")

        If resposta <> MsgBoxResult.No Then
            MsgBox("Trollei!")
        End If

    End Sub


    Private Sub GetLinhasSelecionadas()
        If dtGridUsuarios.SelectedRows.Count > 0 Then
            Dim dtColecaoLinhas As DataGridViewSelectedRowCollection = dtGridUsuarios.SelectedRows
            Dim ids As New List(Of String)
            For i As Integer = 0 To dtColecaoLinhas.Count - 1
                Dim id As Integer = dtColecaoLinhas(i).Cells(0).Value
                Dim nome As String = dtColecaoLinhas(i).Cells(1).Value
                Dim sobrenome As String = dtColecaoLinhas(i).Cells(2).Value
                Dim username As String = dtColecaoLinhas(i).Cells(3).Value
                Dim cargo As String = dtColecaoLinhas(i).Cells(4).Value
                txtID.Text = id
                txtNome.Text = nome
                txtSobrenome.Text = sobrenome
                txtUsuario.Text = username
                txtCargo.Text = cargo
            Next
        Else
            Throw New Exception("Não existem linhas selecionadas!")
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        GetLinhasSelecionadas()
    End Sub


End Class