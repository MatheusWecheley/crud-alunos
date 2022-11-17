Public Interface IAlunoRepository

    Function VerificarID(aluno As Aluno) As Boolean
    Function VerificarNome(aluno As Aluno) As Boolean
    Function CriarAluno(aluno As Aluno) As Boolean
    Function AtualizarAluno(aluno As Aluno) As Boolean
    Sub DeletarAluno(id As Integer)
    Function TodosAlunos()
    Function PegarAluno(value As String) As DataTable

End Interface
