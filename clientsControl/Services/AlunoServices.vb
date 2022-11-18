Public Class AlunoServices

    Private ReadOnly _alunoRepository As IAlunoRepository = New SQLAlunoImplementation()

    Public Sub New()
    End Sub

    Public Sub New(alunoRepository As IAlunoRepository)
        _alunoRepository = alunoRepository
    End Sub

    'Metodo que chama o repositorio para inserção de alunos no banco de dados
    Public Function AdicionarAlunos(aluno As Aluno) As Boolean
        Dim validarID = _alunoRepository.VerificarID(aluno)

        If validarID = True Then
            Return False
        Else
            Dim response = _alunoRepository.CriarAluno(aluno)
            Return response
        End If
    End Function

    'Metodo que chama o repositorio e verifica se o aluno existe no banco de dados com o ID ou nome, realiza a alteração no banco de dados.
    Public Function AtualizarAluno(aluno As Aluno) As Boolean
        Dim validarID = _alunoRepository.VerificarID(aluno)
        If validarID = True Then
            Dim atualizar = _alunoRepository.AtualizarAluno(aluno)
            Return atualizar
        End If
        Return False
    End Function

    'Metodo que chama o repositorio e remove o aluno do banco de dados.
    Public Sub DeletarAluno(id As Integer)
        _alunoRepository.DeletarAluno(id)
    End Sub

    'Metodo que chama o repositorio para buscar todos os alunos para preenchimento do grid
    Public Function BuscarAlunos() As DataTable
        Return _alunoRepository.TodosAlunos()
    End Function

    'Metodo que chama o repositorio e faz a busca do aluno pelo ID, nome ou cidade.
    Public Function PegarAlunoPorID(value As String) As DataTable
        Return _alunoRepository.PegarAluno(value)
    End Function

    'Metodo que verifica se o aluno existe no banco de dados.
    Private Function VerificarID(aluno As Aluno) As Boolean
        Dim id = _alunoRepository.VerificarID(aluno)
        Return id
    End Function

    'Metodo que verifica se existe um aluno com o nome informado.
    Public Function VerificarNome(aluno As Aluno) As Boolean
        Dim validar = _alunoRepository.VerificarNome(aluno)
        Return validar
    End Function
End Class
