<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form_Alunos
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form_Alunos))
        Me.btnSalvar = New System.Windows.Forms.Button()
        Me.txtNome = New System.Windows.Forms.TextBox()
        Me.txtIdade = New System.Windows.Forms.TextBox()
        Me.txtCidade = New System.Windows.Forms.TextBox()
        Me.Nome = New System.Windows.Forms.Label()
        Me.Idade = New System.Windows.Forms.Label()
        Me.Cidade = New System.Windows.Forms.Label()
        Me.Estado = New System.Windows.Forms.Label()
        Me.ConfirmaSenha = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.btnLimpar = New System.Windows.Forms.Button()
        Me.btnTrocarBd = New System.Windows.Forms.Button()
        Me.dtGridAlunos = New System.Windows.Forms.DataGridView()
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.txtID = New System.Windows.Forms.TextBox()
        Me.Codigo = New System.Windows.Forms.Label()
        Me.txtPesquisar = New System.Windows.Forms.TextBox()
        Me.cmbEscolaridade = New System.Windows.Forms.ComboBox()
        Me.cmbEstado = New System.Windows.Forms.ComboBox()
        Me.btnAtualizar = New System.Windows.Forms.Button()
        Me.btnPesquisar = New System.Windows.Forms.Button()
        Me.btnRemover = New System.Windows.Forms.Button()
        Me.btnEditar = New System.Windows.Forms.Button()
        Me.btnListar = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtGridAlunos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnSalvar
        '
        Me.btnSalvar.Location = New System.Drawing.Point(221, 476)
        Me.btnSalvar.Name = "btnSalvar"
        Me.btnSalvar.Size = New System.Drawing.Size(77, 36)
        Me.btnSalvar.TabIndex = 7
        Me.btnSalvar.Text = "Salvar"
        Me.btnSalvar.UseVisualStyleBackColor = True
        '
        'txtNome
        '
        Me.txtNome.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNome.Location = New System.Drawing.Point(33, 162)
        Me.txtNome.Name = "txtNome"
        Me.txtNome.Size = New System.Drawing.Size(277, 26)
        Me.txtNome.TabIndex = 1
        '
        'txtIdade
        '
        Me.txtIdade.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtIdade.Location = New System.Drawing.Point(33, 229)
        Me.txtIdade.Name = "txtIdade"
        Me.txtIdade.Size = New System.Drawing.Size(277, 26)
        Me.txtIdade.TabIndex = 3
        '
        'txtCidade
        '
        Me.txtCidade.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCidade.Location = New System.Drawing.Point(33, 290)
        Me.txtCidade.Name = "txtCidade"
        Me.txtCidade.Size = New System.Drawing.Size(277, 26)
        Me.txtCidade.TabIndex = 4
        '
        'Nome
        '
        Me.Nome.AutoSize = True
        Me.Nome.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Nome.ForeColor = System.Drawing.SystemColors.Control
        Me.Nome.Location = New System.Drawing.Point(30, 139)
        Me.Nome.Name = "Nome"
        Me.Nome.Size = New System.Drawing.Size(55, 20)
        Me.Nome.TabIndex = 5
        Me.Nome.Text = "Nome:"
        '
        'Idade
        '
        Me.Idade.AutoSize = True
        Me.Idade.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Idade.ForeColor = System.Drawing.Color.White
        Me.Idade.Location = New System.Drawing.Point(30, 201)
        Me.Idade.Name = "Idade"
        Me.Idade.Size = New System.Drawing.Size(54, 20)
        Me.Idade.TabIndex = 6
        Me.Idade.Text = "Idade:"
        '
        'Cidade
        '
        Me.Cidade.AutoSize = True
        Me.Cidade.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cidade.ForeColor = System.Drawing.Color.White
        Me.Cidade.Location = New System.Drawing.Point(30, 267)
        Me.Cidade.Name = "Cidade"
        Me.Cidade.Size = New System.Drawing.Size(63, 20)
        Me.Cidade.TabIndex = 7
        Me.Cidade.Text = "Cidade:"
        '
        'Estado
        '
        Me.Estado.AutoSize = True
        Me.Estado.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Estado.ForeColor = System.Drawing.Color.White
        Me.Estado.Location = New System.Drawing.Point(30, 328)
        Me.Estado.Name = "Estado"
        Me.Estado.Size = New System.Drawing.Size(64, 20)
        Me.Estado.TabIndex = 8
        Me.Estado.Text = "Estado:"
        '
        'ConfirmaSenha
        '
        Me.ConfirmaSenha.AutoSize = True
        Me.ConfirmaSenha.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ConfirmaSenha.ForeColor = System.Drawing.Color.White
        Me.ConfirmaSenha.Location = New System.Drawing.Point(30, 392)
        Me.ConfirmaSenha.Name = "ConfirmaSenha"
        Me.ConfirmaSenha.Size = New System.Drawing.Size(105, 20)
        Me.ConfirmaSenha.TabIndex = 9
        Me.ConfirmaSenha.Text = "Escolaridade:"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Purple
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(868, 60)
        Me.Panel1.TabIndex = 11
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(257, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(62, 60)
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 25.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(314, 9)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(316, 39)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "Cadastro de Alunos"
        '
        'btnLimpar
        '
        Me.btnLimpar.Location = New System.Drawing.Point(34, 476)
        Me.btnLimpar.Name = "btnLimpar"
        Me.btnLimpar.Size = New System.Drawing.Size(77, 36)
        Me.btnLimpar.TabIndex = 9
        Me.btnLimpar.Text = "Limpar"
        Me.btnLimpar.UseVisualStyleBackColor = True
        '
        'btnTrocarBd
        '
        Me.btnTrocarBd.Location = New System.Drawing.Point(760, 520)
        Me.btnTrocarBd.Name = "btnTrocarBd"
        Me.btnTrocarBd.Size = New System.Drawing.Size(96, 24)
        Me.btnTrocarBd.TabIndex = 15
        Me.btnTrocarBd.Text = "Trocar conexão"
        Me.btnTrocarBd.UseVisualStyleBackColor = True
        '
        'dtGridAlunos
        '
        Me.dtGridAlunos.AllowUserToAddRows = False
        Me.dtGridAlunos.AllowUserToDeleteRows = False
        Me.dtGridAlunos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtGridAlunos.Location = New System.Drawing.Point(321, 135)
        Me.dtGridAlunos.Name = "dtGridAlunos"
        Me.dtGridAlunos.ReadOnly = True
        Me.dtGridAlunos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dtGridAlunos.Size = New System.Drawing.Size(534, 262)
        Me.dtGridAlunos.TabIndex = 10
        '
        'ImageList1
        '
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList1.Images.SetKeyName(0, "editar.png")
        Me.ImageList1.Images.SetKeyName(1, "delete.png")
        Me.ImageList1.Images.SetKeyName(2, "update.png")
        Me.ImageList1.Images.SetKeyName(3, "lupa.png")
        '
        'txtID
        '
        Me.txtID.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtID.Location = New System.Drawing.Point(33, 100)
        Me.txtID.Name = "txtID"
        Me.txtID.Size = New System.Drawing.Size(61, 26)
        Me.txtID.TabIndex = 16
        '
        'Codigo
        '
        Me.Codigo.AutoSize = True
        Me.Codigo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Codigo.ForeColor = System.Drawing.SystemColors.Control
        Me.Codigo.Location = New System.Drawing.Point(29, 77)
        Me.Codigo.Name = "Codigo"
        Me.Codigo.Size = New System.Drawing.Size(63, 20)
        Me.Codigo.TabIndex = 15
        Me.Codigo.Text = "Código:"
        '
        'txtPesquisar
        '
        Me.txtPesquisar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPesquisar.Location = New System.Drawing.Point(321, 106)
        Me.txtPesquisar.Name = "txtPesquisar"
        Me.txtPesquisar.Size = New System.Drawing.Size(493, 26)
        Me.txtPesquisar.TabIndex = 10
        '
        'cmbEscolaridade
        '
        Me.cmbEscolaridade.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbEscolaridade.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbEscolaridade.FormattingEnabled = True
        Me.cmbEscolaridade.Items.AddRange(New Object() {"---Selecione", "Ensino Fundamental", "Ensino Médio", "Ensino Superior", "Pós-Graduado"})
        Me.cmbEscolaridade.Location = New System.Drawing.Point(34, 415)
        Me.cmbEscolaridade.Name = "cmbEscolaridade"
        Me.cmbEscolaridade.Size = New System.Drawing.Size(168, 26)
        Me.cmbEscolaridade.TabIndex = 6
        '
        'cmbEstado
        '
        Me.cmbEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbEstado.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbEstado.FormattingEnabled = True
        Me.cmbEstado.Items.AddRange(New Object() {"---Selecione", "Acre (AC)", "Alagoas (AL)", "Amapá (AP)", "Amazonas (AM)", "Bahia (BA)", "Ceará (CE)", "Distrito Federal (DF)", "Espírito Santo (ES)", "Goiás (GO)", "Maranhão (MA)", "Mato Grosso (MT)", "Mato Grosso do Sul (MS)", "Minas Gerais (MG)", "Pará (PA)", "Paraíba (PB)", "Paraná (PR)", "Pernambuco (PE)", "Piauí (PI)", "Rio de Janeiro (RJ)", "Rio Grande do Norte (RN)", "Rio Grande do Sul (RS)", "Rondônia (RO)", "Roraima (RR)", "Santa Catarina (SC)", "São Paulo (SP)", "Sergipe (SE)", "Tocantins (TO)"})
        Me.cmbEstado.Location = New System.Drawing.Point(33, 351)
        Me.cmbEstado.Name = "cmbEstado"
        Me.cmbEstado.Size = New System.Drawing.Size(168, 26)
        Me.cmbEstado.TabIndex = 5
        '
        'btnAtualizar
        '
        Me.btnAtualizar.Location = New System.Drawing.Point(125, 476)
        Me.btnAtualizar.Name = "btnAtualizar"
        Me.btnAtualizar.Size = New System.Drawing.Size(77, 36)
        Me.btnAtualizar.TabIndex = 8
        Me.btnAtualizar.Text = "Atualizar"
        Me.btnAtualizar.UseVisualStyleBackColor = True
        '
        'btnPesquisar
        '
        Me.btnPesquisar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnPesquisar.ImageIndex = 3
        Me.btnPesquisar.ImageList = Me.ImageList1
        Me.btnPesquisar.Location = New System.Drawing.Point(820, 100)
        Me.btnPesquisar.Name = "btnPesquisar"
        Me.btnPesquisar.Size = New System.Drawing.Size(35, 32)
        Me.btnPesquisar.TabIndex = 11
        Me.btnPesquisar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnPesquisar.UseVisualStyleBackColor = True
        '
        'btnRemover
        '
        Me.btnRemover.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnRemover.ImageIndex = 1
        Me.btnRemover.ImageList = Me.ImageList1
        Me.btnRemover.Location = New System.Drawing.Point(399, 403)
        Me.btnRemover.Name = "btnRemover"
        Me.btnRemover.Size = New System.Drawing.Size(83, 39)
        Me.btnRemover.TabIndex = 13
        Me.btnRemover.Text = "Remover"
        Me.btnRemover.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnRemover.UseVisualStyleBackColor = True
        '
        'btnEditar
        '
        Me.btnEditar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnEditar.ImageIndex = 0
        Me.btnEditar.ImageList = Me.ImageList1
        Me.btnEditar.Location = New System.Drawing.Point(321, 401)
        Me.btnEditar.Name = "btnEditar"
        Me.btnEditar.Size = New System.Drawing.Size(72, 40)
        Me.btnEditar.TabIndex = 12
        Me.btnEditar.Text = "Editar"
        Me.btnEditar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnEditar.UseVisualStyleBackColor = True
        '
        'btnListar
        '
        Me.btnListar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnListar.ImageIndex = 2
        Me.btnListar.ImageList = Me.ImageList1
        Me.btnListar.Location = New System.Drawing.Point(488, 401)
        Me.btnListar.Name = "btnListar"
        Me.btnListar.Size = New System.Drawing.Size(70, 40)
        Me.btnListar.TabIndex = 14
        Me.btnListar.Text = "Listar"
        Me.btnListar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnListar.UseVisualStyleBackColor = True
        '
        'Form_Alunos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkViolet
        Me.ClientSize = New System.Drawing.Size(868, 556)
        Me.Controls.Add(Me.btnAtualizar)
        Me.Controls.Add(Me.cmbEstado)
        Me.Controls.Add(Me.cmbEscolaridade)
        Me.Controls.Add(Me.btnPesquisar)
        Me.Controls.Add(Me.txtPesquisar)
        Me.Controls.Add(Me.Codigo)
        Me.Controls.Add(Me.txtID)
        Me.Controls.Add(Me.btnRemover)
        Me.Controls.Add(Me.btnEditar)
        Me.Controls.Add(Me.btnListar)
        Me.Controls.Add(Me.dtGridAlunos)
        Me.Controls.Add(Me.btnTrocarBd)
        Me.Controls.Add(Me.btnLimpar)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.ConfirmaSenha)
        Me.Controls.Add(Me.Estado)
        Me.Controls.Add(Me.Cidade)
        Me.Controls.Add(Me.Idade)
        Me.Controls.Add(Me.Nome)
        Me.Controls.Add(Me.txtCidade)
        Me.Controls.Add(Me.txtIdade)
        Me.Controls.Add(Me.txtNome)
        Me.Controls.Add(Me.btnSalvar)
        Me.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "Form_Alunos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cadastro de Alunos"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtGridAlunos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnSalvar As Button
    Friend WithEvents txtNome As TextBox
    Friend WithEvents txtIdade As TextBox
    Friend WithEvents txtCidade As TextBox
    Friend WithEvents Nome As Label
    Friend WithEvents Idade As Label
    Friend WithEvents Cidade As Label
    Friend WithEvents Estado As Label
    Friend WithEvents ConfirmaSenha As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label6 As Label
    Friend WithEvents btnLimpar As Button
    Friend WithEvents btnTrocarBd As Button
    Friend WithEvents dtGridAlunos As DataGridView
    Friend WithEvents btnListar As Button
    Friend WithEvents btnEditar As Button
    Friend WithEvents ImageList1 As ImageList
    Friend WithEvents btnRemover As Button
    Friend WithEvents Codigo As Label
    Friend WithEvents txtPesquisar As TextBox
    Friend WithEvents btnPesquisar As Button
    Friend WithEvents cmbEscolaridade As ComboBox
    Friend WithEvents cmbEstado As ComboBox
    Friend WithEvents btnAtualizar As Button
    Friend WithEvents PictureBox1 As PictureBox
    Protected WithEvents txtID As TextBox
End Class
