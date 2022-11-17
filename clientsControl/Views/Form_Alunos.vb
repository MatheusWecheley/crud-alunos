Imports System.IO.Ports
Imports System.Runtime.CompilerServices

Public Class Form_Alunos

    'Ao carregar o Form, chama a função de criar as tabelas(se já existir, não realiza nenhum processo) e preenche o grid com os alunos já cadastrados no banco de dados
    Private Sub Form_Alunos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        btnAtualizar.Enabled = False
        txtID.Enabled = False
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

    'Preenche os campos como vazio
    Private Sub LimparCampos()
        txtID.Text = ""
        txtNome.Text = ""
        txtIdade.Text = ""
        txtCidade.Text = ""
        cmbEstado.SelectedIndex = 0
        cmbEscolaridade.SelectedIndex = 0
    End Sub

    'Realiza a validação se todos os campos estão preenchidos
    Private Function ValidarCampos() As Boolean
        If txtNome.Text = "" Then
            MsgBox("Por favor, informe o Nome do aluno!", MsgBoxStyle.Exclamation, "Atenção")
            Return False
        ElseIf txtIdade.Text = "" Then
            MsgBox("Por favor, informe a Idade do aluno!", MsgBoxStyle.Exclamation, "Atenção")
            Return False
        ElseIf IsNumeric(txtIdade.Text) = False Then
            MsgBox("Por favor informe um número na idade!", MsgBoxStyle.Exclamation, "Atenção")
            Return False
        ElseIf txtIdade.Text > 100 Then
            Dim response = MsgBox("Tem certeza que o aluno tem " & txtIdade.Text & " anos?", MsgBoxStyle.YesNo, "Atenção")
            If response <> MsgBoxResult.Yes Then
                MsgBox("Operação cancelada!", MsgBoxStyle.Information, "Cancelado")
                Return False
            Else
                Return True
            End If
        ElseIf txtCidade.Text = "" Then
            MsgBox("Por favor, informe a Cidade do aluno!", MsgBoxStyle.Exclamation, "Atenção")
            Return False
        ElseIf cmbEstado.SelectedIndex = 0 Then
            MsgBox("Por favor, informe o Estado do aluno!", MsgBoxStyle.Exclamation, "Atenção")
            Return False
        ElseIf cmbEscolaridade.SelectedIndex = 0 Then
            MsgBox("Por favor, informe a Escolaridade do aluno!!", MsgBoxStyle.Exclamation, "Atenção")
            Return False
        End If
        Return True
    End Function

    Private Sub CriarAluno(aluno As Aluno)
        Dim _alunoService As AlunoServices = New AlunoServices()
        Dim responseID = _alunoService.AdicionarAlunos(aluno)
        If responseID = True Then
            MsgBox("Aluno criado com sucesso!", MsgBoxStyle.Information, "Sucesso!")
            LimparCampos()
            Dim refresh = _alunoService.BuscarAlunos()

            dtGridAlunos.DataSource = refresh
        Else
            MsgBox("Aluno já existente com este id, tente outro!", MsgBoxStyle.Exclamation, "Aluno Existente")
        End If
    End Sub


    'Seleciona todas as colunas e linhas do grid
    Private Sub GetLinhasSelecionadas()
        If dtGridAlunos.SelectedRows.Count > 0 Then
            Dim dtColecaoLinhas As DataGridViewSelectedRowCollection = dtGridAlunos.SelectedRows
            Dim ids As New List(Of String)
            For i As Integer = 0 To dtColecaoLinhas.Count - 1
                Dim id As Integer = dtColecaoLinhas(i).Cells(0).Value
                Dim nome As String = dtColecaoLinhas(i).Cells(1).Value
                Dim idade As String = dtColecaoLinhas(i).Cells(2).Value
                Dim cidade As String = dtColecaoLinhas(i).Cells(3).Value
                Dim escolaridade As String = dtColecaoLinhas(i).Cells(4).Value
                txtID.Text = id
                txtNome.Text = nome
                txtIdade.Text = idade
                txtCidade.Text = cidade
                cmbEscolaridade.SelectedItem = escolaridade
            Next
        Else
            Throw New Exception("Não existem linhas selecionadas!")
        End If
    End Sub

    'Cria uma nova Entidade Aluno e chama o metodo do Aluno Service para adiciona-lo no banco de dados
    Private Sub bntSalvar_Click(sender As Object, e As EventArgs) Handles btnSalvar.Click
        If ValidarCampos() = False Then Exit Sub
        Dim aluno As Aluno = New Aluno()
        Dim _alunoService As AlunoServices = New AlunoServices()
        aluno.GetNome = txtNome.Text
        aluno.GetIdade = txtIdade.Text
        aluno.GetCidade = txtCidade.Text
        aluno.GetEstado = cmbEstado.SelectedItem
        aluno.GetEscolaridade = cmbEscolaridade.SelectedItem

        Try
            Dim responseNome = _alunoService.VerificarNome(aluno)

            If responseNome = True Then
                Dim resposta = MsgBox("Já existe um aluno com esse nome, deseja cadastrar mesmo assim?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Atenção")
                If resposta = MsgBoxResult.Yes Then
                    CriarAluno(aluno)
                Else
                    MsgBox("Operação cancelada", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Atenção")
                End If
            Else
                CriarAluno(aluno)
            End If
        Catch ex As Exception
            MsgBox("Erro ao criar um Aluno!" & vbNewLine & vbNewLine & ex.Message, MsgBoxStyle.Critical)
        End Try

    End Sub

    'Realiza a atualização dos dados do Aluno(atualizando automaticamente o grid). O campo código e o botão salvar voltam a ficar disponiveis.
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
                Dim refresh = _alunoService.BuscarAlunos()
                dtGridAlunos.DataSource = refresh
                btnAtualizar.Enabled = False
            Else
                MsgBox("Aluno ainda não cadastrado!", MsgBoxStyle.Exclamation, "Atenção")
            End If

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Atenção")
        End Try

    End Sub

    'Busca todos os alunos no banco de dados e preenche o grid
    Private Sub btnListar_Click(sender As Object, e As EventArgs) Handles btnListar.Click
        Dim _alunoService As AlunoServices = New AlunoServices()
        Dim response = _alunoService.BuscarAlunos()
        dtGridAlunos.DataSource = response
    End Sub

    'Realiza a limpa dos campos para vazio.
    Private Sub btnLimpar_Click(sender As Object, e As EventArgs) Handles btnLimpar.Click
        LimparCampos()
        btnSalvar.Enabled = True
    End Sub

    'Chama o metodo do Aluno Service que realiza a busca do aluno com base no nome, código ou cidade.
    Private Sub btnPesquisar_Click(sender As Object, e As EventArgs) Handles btnPesquisar.Click
        Dim _alunoService As AlunoServices = New AlunoServices()
        Dim result = _alunoService.PegarAlunoPorID(txtPesquisar.Text)
        dtGridAlunos.DataSource = result
    End Sub

    'Evento da tecla enter no text box Pesquisar, chamando o evento do click
    Private Sub txtPesquisar_KeyDown(sender As Object, e As KeyEventArgs) Handles txtPesquisar.KeyDown
        If e.KeyCode = Keys.Enter Then
            btnPesquisar_Click(sender, e)
        End If
    End Sub

    'Preenche os campos com os dados do Aluno no qual a linha está selecionada.
    Private Sub btnEditar_Click(sender As Object, e As EventArgs) Handles btnEditar.Click
        Try
            GetLinhasSelecionadas()
            btnAtualizar.Enabled = True
            btnSalvar.Enabled = False
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Atenção")
        End Try


    End Sub

    'Ao selecionar a linha do aluno no grid, pergunta ao usuario se deseja excluir o aluno, caso positivo, chama o metodo do Aluno Service que faz a remoção do aluno no banco de dados
    Private Sub btnRemover_Click(sender As Object, e As EventArgs) Handles btnRemover.Click
        GetLinhasSelecionadas()
        Dim resposta = MsgBox("Deseja mesmo excluir o aluno: " & txtNome.Text & ", Código: " & txtID.Text & "?", MsgBoxStyle.YesNo, "Atenção!")

        If resposta = MsgBoxResult.Yes Then
            Dim _alunoService As AlunoServices = New AlunoServices()
            _alunoService.DeletarAluno(txtID.Text)
            MsgBox("Aluno Deletado!", MsgBoxStyle.Information, "Sucesso")

            LimparCampos()
            btnSalvar.Enabled = True
            Dim refresh = _alunoService.BuscarAlunos()
            dtGridAlunos.DataSource = refresh
        Else
            MsgBox("Operação cancelada!", MsgBoxStyle.Information, "Cancelado")
            LimparCampos()
        End If

    End Sub

    'Chama o Form_Bd para realizar a troca de conexão.
    Private Sub btnTrocarBd_Click(sender As Object, e As EventArgs) Handles btnTrocarBd.Click
        My.Settings.YexConnectionServer = ""
        Me.Hide()
        Form_Db.Show()
    End Sub

End Class