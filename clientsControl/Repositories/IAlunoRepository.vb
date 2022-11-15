Public Interface IAlunoRepository

    Function VerificarIDNome(usuario As Aluno) As Boolean
    Function CriarAluno(usuario As Aluno) As Boolean
    Function AtualizarAluno(aluno As Aluno) As Boolean
    Sub DeletarAluno(id As Integer)
    Function TodosAlunos()
    Function PegarAluno(value As String) As DataTable

End Interface
