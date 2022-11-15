Imports System.IO.Ports
Imports System.Runtime.CompilerServices

Public Class Form_Alunos
    Private Sub Form_Alunos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cmbEscolaridade.SelectedIndex = 0
        cmbEstado.SelectedIndex = 0

        Dim _alunoService As AlunoServices = New AlunoServices()

        Try
            Dim tabelas = CriarTabelas()
            If tabelas = True Then
                MsgBox("Criado tabelas para uso!", MsgBoxStyle.Information, "Criando tabelas")
                Dim response = _alunoService.BuscarAlunos()

                dtGridAlunos.DataSource = response
            End If
        Catch ex As Exception
            MsgBox("Erro ao criar tabelas!" & ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub LimparCampos()
        txtID.Text = ""
        txtNome.Text = ""
        txtIdade.Text = ""
        txtCidade.Text = ""
        cmbEstado.SelectedIndex = 0
        cmbEscolaridade.SelectedIndex = 0
    End Sub

    Private Function ValidarCampos() As Boolean
        If txtID.Text = "" Then
            MsgBox("Por favor, informe o código do aluno!", MsgBoxStyle.Exclamation)
            Return False
        ElseIf txtNome.Text = "" Then
            MsgBox("Por favor, informe o Nome do aluno!", MsgBoxStyle.Exclamation)
            Return False
        ElseIf txtIdade.Text = "" Then
            MsgBox("Por favor, informe a Idade do aluno!", MsgBoxStyle.Exclamation)
            Return False
        ElseIf txtCidade.Text = "" Then
            MsgBox("Por favor, informe a Cidade do aluno!", MsgBoxStyle.Exclamation)
            Return False
        ElseIf cmbEstado.SelectedIndex = 0 Then
            MsgBox("Por favor, informe o Estado do aluno!", MsgBoxStyle.Exclamation)
            Return False
        ElseIf cmbEscolaridade.SelectedIndex = 0 Then
            MsgBox("Por favor, informe a Escolaridade do aluno!!", MsgBoxStyle.Exclamation)
            Return False
        End If
        Return True
    End Function

    Private Sub bntSalvar_Click(sender As Object, e As EventArgs) Handles btnSalvar.Click
        If ValidarCampos() = False Then Exit Sub
        Dim aluno As Aluno = New Aluno()
        Dim _alunoService As AlunoServices = New AlunoServices()
        aluno.GetID = txtID.Text
        aluno.GetNome = txtNome.Text
        aluno.GetIdade = txtIdade.Text
        aluno.GetCidade = txtCidade.Text
        aluno.GetEstado = cmbEstado.SelectedItem
        aluno.GetEscolaridade = cmbEscolaridade.SelectedItem

        Try
            Dim response = _alunoService.AdicionarAlunos(aluno)
            If response = True Then
                MsgBox("Aluno Criado com sucesso!", MsgBoxStyle.Information, "Sucesso!")
                LimparCampos()
            Else
                MsgBox("Aluno já existente com este nome/id, tente outro!", MsgBoxStyle.Exclamation, "Aluno Existente")
            End If
        Catch ex As Exception
            MsgBox("Erro ao criar um Aluno!" & vbNewLine & vbNewLine & ex.Message, MsgBoxStyle.Critical)
        End Try

    End Sub

    Private Sub btnAtualizar_Click(sender As Object, e As EventArgs) Handles btnAtualizar.Click
        If ValidarCampos() = False Then Exit Sub
        Dim aluno As Aluno = New Aluno()
        Dim _alunoService As AlunoServices = New AlunoServices()

        aluno.GetID = txtID.Text
        aluno.GetNome = txtNome.Text
        aluno.GetIdade = txtIdade.Text
        aluno.GetCidade = txtCidade.Text
        aluno.GetEstado = cmbEstado.SelectedItem
        aluno.GetEscolaridade = cmbEscolaridade.SelectedItem

        Try
            Dim response = _alunoService.AtualizarAluno(aluno)
            If response = True Then
                MsgBox("Aluno atualizado com sucesso!", MsgBoxStyle.Information, "Sucesso!")
                LimparCampos()
                btnSalvar.Enabled = True
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Atenção")
        End Try

    End Sub

    Private Sub btnListar_Click(sender As Object, e As EventArgs) Handles btnListar.Click
        Dim _alunoService As AlunoServices = New AlunoServices()
        Dim response = _alunoService.BuscarAlunos()
        dtGridAlunos.DataSource = response
    End Sub

    Private Sub btnLimpar_Click(sender As Object, e As EventArgs) Handles btnLimpar.Click
        LimparCampos()
    End Sub

    Private Sub btnPesquisar_Click(sender As Object, e As EventArgs) Handles btnPesquisar.Click
        Dim _alunoService As AlunoServices = New AlunoServices()
        Dim result = _alunoService.PegarAlunoPorID(txtPesquisar.Text)
        dtGridAlunos.DataSource = result
    End Sub

    Private Sub txtPesquisar_KeyDown(sender As Object, e As KeyEventArgs) Handles txtPesquisar.KeyDown
        If e.KeyCode = Keys.Enter Then
            btnPesquisar_Click(sender, e)
        End If
    End Sub

    Private Sub btnEditar_Click(sender As Object, e As EventArgs) Handles btnEditar.Click
        GetLinhasSelecionadas()
        btnSalvar.Enabled = False
    End Sub

    Private Sub btnRemover_Click(sender As Object, e As EventArgs) Handles btnRemover.Click

        Dim resposta = MsgBox("Deseja mesmo excluir este aluno?", MsgBoxStyle.YesNo, "Atenção!")

        If resposta <> MsgBoxResult.No Then
            MsgBox("Trollei!")
        End If

    End Sub

    Private Sub btnTrocarBd_Click(sender As Object, e As EventArgs) Handles btnTrocarBd.Click
        My.Settings.YexConnectionServer = ""
        Me.Hide()
        Form_Db.Show()
    End Sub

    Private Sub GetLinhasSelecionadas()
        If dtGridAlunos.SelectedRows.Count > 0 Then
            Dim dtColecaoLinhas As DataGridViewSelectedRowCollection = dtGridAlunos.SelectedRows
            Dim ids As New List(Of String)
            For i As Integer = 0 To dtColecaoLinhas.Count - 1
                Dim codigo As Integer = dtColecaoLinhas(i).Cells(0).Value
                Dim nome As String = dtColecaoLinhas(i).Cells(1).Value
                Dim idade As String = dtColecaoLinhas(i).Cells(2).Value
                Dim cidade As String = dtColecaoLinhas(i).Cells(3).Value
                Dim escolaridade As String = dtColecaoLinhas(i).Cells(4).Value
                txtID.Text = codigo
                txtNome.Text = nome
                txtIdade.Text = idade
                txtCidade.Text = cidade
                cmbEscolaridade.SelectedText = escolaridade
            Next
        Else
            Throw New Exception("Não existem linhas selecionadas!")
        End If
    End Sub

End Class