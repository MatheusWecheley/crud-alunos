Imports System.Data.SqlClient
Imports Microsoft.VisualBasic.ApplicationServices

Public Class SQLAlunoImplementation
    Implements IAlunoRepository

    Public Sub DeletarAluno(id As Integer) Implements IAlunoRepository.DeletarAluno
        Throw New NotImplementedException()
    End Sub

    Public Function CriarAluno(aluno As Aluno) As Boolean Implements IAlunoRepository.CriarAluno

        Try
            Dim conexao As SqlConnection
            Dim cmd As SqlCommand
            Dim str As String = "INSERT INTO ALUNOS (codigo, nome, idade, cidade, estado, escolaridade) VALUES (@codigo, @nome, @idade, @cidade, @estado, @escolaridade)"

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
            conexao.Close()
            Return True
        Catch ex As Exception
            MsgBox("Erro ao criar um novo usuario!", vbNewLine, ex.Message)
            Return False
        End Try

        Return True
    End Function

    Public Function AtualizarAluno(aluno As Aluno) As Boolean Implements IAlunoRepository.AtualizarAluno
        Try
            Dim conexao As SqlConnection
            Dim cmd As SqlCommand
            Dim str = "UPDATE ALUNOS SET nome = @nome, idade = @idade, cidade = @cidade, escolaridade = @escolaridade WHERE codigo = @codigo"

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

    Public Function TodosAlunos() Implements IAlunoRepository.TodosAlunos
        Dim dataAdapter As SqlDataAdapter
        Dim bsource As New BindingSource()

        Try
            Dim str = GetStrCon()
            Dim conexao = New SqlConnection(str)

            Dim sql = "SELECT codigo, nome, idade, cidade, escolaridade FROM Alunos"
            dataAdapter = New SqlDataAdapter(sql, conexao)
            conexao.Open()
            Dim ds As New DataSet()
            Dim commandBuilder As New SqlCommandBuilder(dataAdapter)
            dataAdapter.Fill(ds, "Orders")
            bsource.DataSource = ds.Tables("Orders")

            Return bsource
        Catch ex As Exception
            Return ex.Message
        End Try

        Return bsource
    End Function

    Public Function VerificarIDNome(aluno As Aluno) As Boolean Implements IAlunoRepository.VerificarIDNome
        Try
            Dim conexao As SqlConnection
            Dim cmd As SqlCommand
            Dim read As SqlDataReader
            Dim str As String = $"SELECT codigo, nome FROM Alunos Where codigo = @codigo or nome like '%" & aluno.GetNome & "%'"

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
            MsgBox("Erro ao consultar usuario!" & vbNewLine & vbNewLine & ex.Message)
        End Try
        Return False
    End Function

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
            Dim str As String = $"SELECT codigo, nome, idade, cidade, escolaridade FROM Alunos where id = @id or nome like '%" & value & "%'"

            conexao = New SqlConnection(GetStrCon())
            cmd = New SqlCommand(str, conexao)
            cmd.Parameters.AddWithValue("@id", num)

            conexao.Open()
            Dim da As New SqlDataAdapter(cmd)
            da.Fill(ds)
            dt = ds.Tables(0)
            conexao.Close()
            Return dt

        Catch ex As Exception
            MsgBox("Não foi possivel realizar a consulta do usuário! " & vbNewLine & vbNewLine & ex.Message, MsgBoxStyle.Critical, "Erro na consulta")
        End Try

        Return dt
    End Function
End Class
