Public Class AlunoServices

    Private ReadOnly _alunoRepository As IAlunoRepository = New SQLAlunoImplementation()

    Public Sub New()
    End Sub

    Public Sub New(alunoRepository As IAlunoRepository)
        _alunoRepository = alunoRepository
    End Sub

    Public Function AdicionarAlunos(aluno As Aluno) As Boolean
        Dim validate = _alunoRepository.VerificarIDNome(aluno)

        If validate = True Then
            Return False
        Else
            Dim response = _alunoRepository.CriarAluno(aluno)
            Return response
        End If
    End Function

    Public Function AtualizarAluno(aluno As Aluno) As Boolean
        Dim validate = _alunoRepository.VerificarIDNome(aluno)
        If validate = True Then
            Dim atualizar = _alunoRepository.AtualizarAluno(aluno)
            Return atualizar
        End If
        Return False
    End Function

    Public Sub DeletarAluno(id As Integer)
        _alunoRepository.DeletarAluno(id)
    End Sub

    Public Function BuscarAlunos() As BindingSource
        Return _alunoRepository.TodosAlunos()
    End Function

    Public Function PegarAlunoPorID(value As String) As DataTable
        Return _alunoRepository.PegarAluno(value)
    End Function

    Public Function VerificarIDNome(aluno As Aluno) As Boolean
        Dim atualizar = _alunoRepository.VerificarIDNome(aluno)
        Return atualizar
    End Function
End Class
