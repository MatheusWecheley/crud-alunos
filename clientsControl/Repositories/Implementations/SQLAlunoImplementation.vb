Imports System.Data.SqlClient
Imports Microsoft.VisualBasic.ApplicationServices

Public Class SQLAlunoImplementation
    Implements IAlunoRepository

    'Metodo que deleta o aluno no banco de dados.
    Public Sub DeletarAluno(id As Integer) Implements IAlunoRepository.DeletarAluno
        Try
            Dim conexao As SqlConnection
            Dim cmd As SqlCommand
            Dim str As String = "DELETE FROM ALUNOS WHERE codigo = @codigo"

            conexao = New SqlConnection(GetStrCon)
            cmd = New SqlCommand(str, conexao)
            cmd.Parameters.AddWithValue("@codigo", id)
            conexao.Open()
            cmd.ExecuteNonQuery()
            conexao.Close()
        Catch ex As Exception
            MsgBox("Erro ao deletar o aluno!", vbNewLine, ex.Message)
        End Try
    End Sub

    'Metodo que cria o aluno no banco de dados
    Public Function CriarAluno(aluno As Aluno) As Boolean Implements IAlunoRepository.CriarAluno

        Try
            Dim conexao As SqlConnection
            Dim cmd As SqlCommand
            Dim str As String = "INSERT INTO ALUNOS (nome, idade, cidade, estado, escolaridade) VALUES (@nome, @idade, @cidade, @estado, @escolaridade)"

            conexao = New SqlConnection(GetStrCon)
            cmd = New SqlCommand(str, conexao)
            cmd.Parameters.AddWithValue("@nome", aluno.GetNome)
            cmd.Parameters.AddWithValue("@idade", aluno.GetIdade)
            cmd.Parameters.AddWithValue("@cidade", aluno.GetCidade)
            cmd.Parameters.AddWithValue("@estado", aluno.GetEstado)
            cmd.Parameters.AddWithValue("@escolaridade", aluno.GetEscolaridade)
            conexao.Open()
            cmd.ExecuteNonQuery()
            conexao.Close()
            Return True
        Catch ex As Exception
            MsgBox("Erro ao criar um novo aluno!", vbNewLine, ex.Message)
            Return False
        End Try

        Return True
    End Function

    'Metodo que atualiza o aluno no banco de dados
    Public Function AtualizarAluno(aluno As Aluno) As Boolean Implements IAlunoRepository.AtualizarAluno
        Try
            Dim conexao As SqlConnection
            Dim cmd As SqlCommand
            Dim str = "UPDATE ALUNOS SET nome = @nome, idade = @idade, cidade = @cidade, estado = @estado, escolaridade = @escolaridade WHERE codigo = @codigo"

            conexao = New SqlConnection(GetStrCon)
            cmd = New SqlCommand(str, conexao)
            cmd.Parameters.AddWithValue("@codigo", aluno.GetID)
            cmd.Parameters.AddWithValue("@nome", aluno.GetNome)
            cmd.Parameters.AddWithValue("@idade", aluno.GetIdade)
            cmd.Parameters.AddWithValue("@cidade", aluno.GetCidade)
            cmd.Parameters.AddWithValue("@estado", aluno.GetEstado)
            cmd.Parameters.AddWithValue("@escolaridade", aluno.GetEscolaridade)

            conexao.Open()
            cmd.ExecuteNonQuery()
            Return True
        Catch ex As Exception
            MsgBox("Erro ao atualizar aluno!" & vbNewLine & vbNewLine & ex.Message)
            Return False
        End Try
    End Function

    'Metodos que busca todos os alunos para preenchimento no grid
    Public Function TodosAlunos() Implements IAlunoRepository.TodosAlunos
        Dim dataAdapter As SqlDataAdapter
        Dim dt As New DataTable

        Try
            Dim str = GetStrCon()
            Dim conexao = New SqlConnection(str)

            Dim sql = "SELECT codigo, nome, idade, cidade, estado, escolaridade FROM Alunos"
            dataAdapter = New SqlDataAdapter(sql, conexao)
            conexao.Open()
            Dim ds As New DataSet()
            dataAdapter.Fill(ds, "Alunos")
            dt = ds.Tables(0)

            Return dt
        Catch ex As Exception
            Return ex.Message
        End Try

        Return dt
    End Function

    'Metodo que consulta se o aluno existe no banco de dados pelo nome ou id
    Public Function VerificarID(aluno As Aluno) As Boolean Implements IAlunoRepository.VerificarID
        Try
            Dim conexao As SqlConnection
            Dim cmd As SqlCommand
            Dim read As SqlDataReader
            Dim str As String = $"SELECT codigo, nome FROM Alunos Where codigo = @codigo"

            conexao = New SqlConnection(GetStrCon())
            cmd = New SqlCommand(str, conexao)
            cmd.Parameters.AddWithValue("@codigo", aluno.GetID)
            conexao.Open()
            read = cmd.ExecuteReader()
            If read.Read() = True Then
                Return True
            End If
            Return False
            conexao.Close()
        Catch ex As Exception
            MsgBox("Erro ao consultar o aluno!" & vbNewLine & vbNewLine & ex.Message)
        End Try
        Return False
    End Function

    Public Function VerificarNome(aluno As Aluno) As Boolean Implements IAlunoRepository.VerificarNome
        Try
            Dim conexao As SqlConnection
            Dim cmd As SqlCommand
            Dim read As SqlDataReader
            Dim str As String = $"SELECT nome FROM Alunos Where nome Like '" & aluno.GetNome & "%'"

            conexao = New SqlConnection(GetStrCon())
            cmd = New SqlCommand(str, conexao)
            conexao.Open()
            read = cmd.ExecuteReader()
            If read.Read() = True Then
                Return True
            End If
            Return False
            conexao.Close()
        Catch ex As Exception
            MsgBox("Erro ao consultar o aluno!" & vbNewLine & vbNewLine & ex.Message)
        End Try
        Return False
    End Function

    'Metodo que faz a busca de um aluno pelo nome, codigo e cidade.
    Public Function PegarAluno(value As String) As DataTable Implements IAlunoRepository.PegarAluno

        Dim num As Integer
        If Integer.TryParse(value, num) Then
            num = value
        End If

        Dim dt As New DataTable
        Dim ds As New DataSet()


        Try
            Dim conexao As SqlConnection
            Dim cmd As SqlCommand
            Dim str As String = $"SELECT codigo, nome, idade, cidade, estado, escolaridade FROM Alunos where codigo = @codigo or nome like '%" & value & "%' or cidade like '%" & value & "%' or estado like '%" & value & "%'"

            conexao = New SqlConnection(GetStrCon())
            cmd = New SqlCommand(str, conexao)
            cmd.Parameters.AddWithValue("@codigo", num)

            conexao.Open()
            Dim da As New SqlDataAdapter(cmd)
            da.Fill(ds)
            dt = ds.Tables(0)
            conexao.Close()
            Return dt

        Catch ex As Exception
            MsgBox("Não foi possivel realizar a consulta do aluno! " & vbNewLine & vbNewLine & ex.Message, MsgBoxStyle.Critical, "Erro na consulta")
        End Try

        Return dt
    End Function
End Class
