Public Class Aluno
    Private id As Integer
    Private nome As String
    Private idade As Integer
    Private cidade As String
    Private estado As String
    Private escolaridade As String

    Public Property GetID() As Integer
        Get
            Return id
        End Get
        Set(value As Integer)
            id = value
        End Set
    End Property

    Public Property GetNome() As String
        Get
            Return nome
        End Get
        Set(value As String)
            nome = value
        End Set
    End Property

    Public Property GetIdade() As Integer
        Get
            Return idade
        End Get
        Set(value As Integer)
            idade = value
        End Set
    End Property

    Public Property GetCidade() As String
        Get
            Return cidade
        End Get
        Set(value As String)
            cidade = value
        End Set
    End Property

    Public Property GetEstado() As String
        Get
            Return estado
        End Get
        Set(value As String)
            estado = value
        End Set
    End Property

    Public Property GetEscolaridade() As String
        Get
            Return escolaridade
        End Get
        Set(value As String)
            escolaridade = value
        End Set
    End Property

End Class
