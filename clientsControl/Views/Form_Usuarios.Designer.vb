<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_Usuarios
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form_Usuarios))
        Me.Button1 = New System.Windows.Forms.Button()
        Me.txtNome = New System.Windows.Forms.TextBox()
        Me.txtSobrenome = New System.Windows.Forms.TextBox()
        Me.txtUsuario = New System.Windows.Forms.TextBox()
        Me.txtSenha = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtConfirmaSenha = New System.Windows.Forms.TextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtCargo = New System.Windows.Forms.TextBox()
        Me.btnTrocarBd = New System.Windows.Forms.Button()
        Me.dtGridUsuarios = New System.Windows.Forms.DataGridView()
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.btnAtualizar = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        CType(Me.dtGridUsuarios, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(252, 402)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(77, 36)
        Me.Button1.TabIndex = 7
        Me.Button1.Text = "Salvar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'txtNome
        '
        Me.txtNome.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNome.Location = New System.Drawing.Point(161, 82)
        Me.txtNome.Name = "txtNome"
        Me.txtNome.Size = New System.Drawing.Size(168, 26)
        Me.txtNome.TabIndex = 1
        '
        'txtSobrenome
        '
        Me.txtSobrenome.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSobrenome.Location = New System.Drawing.Point(161, 132)
        Me.txtSobrenome.Name = "txtSobrenome"
        Me.txtSobrenome.Size = New System.Drawing.Size(168, 26)
        Me.txtSobrenome.TabIndex = 2
        '
        'txtUsuario
        '
        Me.txtUsuario.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUsuario.Location = New System.Drawing.Point(161, 185)
        Me.txtUsuario.Name = "txtUsuario"
        Me.txtUsuario.Size = New System.Drawing.Size(168, 26)
        Me.txtUsuario.TabIndex = 3
        '
        'txtSenha
        '
        Me.txtSenha.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSenha.Location = New System.Drawing.Point(161, 235)
        Me.txtSenha.Name = "txtSenha"
        Me.txtSenha.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtSenha.Size = New System.Drawing.Size(168, 26)
        Me.txtSenha.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.Control
        Me.Label1.Location = New System.Drawing.Point(94, 85)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(55, 20)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Nome:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(53, 138)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(96, 20)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Sobrenome:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(81, 191)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(68, 20)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Usuario:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(89, 238)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(60, 20)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Senha:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(16, 294)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(133, 20)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Confirmar Senha:"
        '
        'txtConfirmaSenha
        '
        Me.txtConfirmaSenha.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtConfirmaSenha.Location = New System.Drawing.Point(161, 288)
        Me.txtConfirmaSenha.Name = "txtConfirmaSenha"
        Me.txtConfirmaSenha.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtConfirmaSenha.Size = New System.Drawing.Size(168, 26)
        Me.txtConfirmaSenha.TabIndex = 5
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Purple
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(914, 60)
        Me.Panel1.TabIndex = 11
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 25.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(286, 9)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(346, 39)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "Cadastro de Usuários"
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(169, 402)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(77, 36)
        Me.Button2.TabIndex = 8
        Me.Button2.Text = "Limpar"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(94, 343)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(56, 20)
        Me.Label7.TabIndex = 13
        Me.Label7.Text = "Cargo:"
        '
        'txtCargo
        '
        Me.txtCargo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCargo.Location = New System.Drawing.Point(161, 340)
        Me.txtCargo.Name = "txtCargo"
        Me.txtCargo.Size = New System.Drawing.Size(168, 26)
        Me.txtCargo.TabIndex = 6
        '
        'btnTrocarBd
        '
        Me.btnTrocarBd.Location = New System.Drawing.Point(12, 414)
        Me.btnTrocarBd.Name = "btnTrocarBd"
        Me.btnTrocarBd.Size = New System.Drawing.Size(96, 24)
        Me.btnTrocarBd.TabIndex = 9
        Me.btnTrocarBd.Text = "Trocar conexão"
        Me.btnTrocarBd.UseVisualStyleBackColor = True
        '
        'dtGridUsuarios
        '
        Me.dtGridUsuarios.AllowUserToAddRows = False
        Me.dtGridUsuarios.AllowUserToDeleteRows = False
        Me.dtGridUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtGridUsuarios.Location = New System.Drawing.Point(368, 82)
        Me.dtGridUsuarios.Name = "dtGridUsuarios"
        Me.dtGridUsuarios.ReadOnly = True
        Me.dtGridUsuarios.Size = New System.Drawing.Size(534, 284)
        Me.dtGridUsuarios.TabIndex = 13
        '
        'ImageList1
        '
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList1.Images.SetKeyName(0, "editar.png")
        Me.ImageList1.Images.SetKeyName(1, "delete.png")
        Me.ImageList1.Images.SetKeyName(2, "update.png")
        '
        'Button4
        '
        Me.Button4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button4.ImageIndex = 1
        Me.Button4.ImageList = Me.ImageList1
        Me.Button4.Location = New System.Drawing.Point(646, 372)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(83, 39)
        Me.Button4.TabIndex = 12
        Me.Button4.Text = "Remover"
        Me.Button4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button3.ImageIndex = 0
        Me.Button3.ImageList = Me.ImageList1
        Me.Button3.Location = New System.Drawing.Point(735, 371)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(72, 40)
        Me.Button3.TabIndex = 11
        Me.Button3.Text = "Editar"
        Me.Button3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button3.UseVisualStyleBackColor = True
        '
        'btnAtualizar
        '
        Me.btnAtualizar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAtualizar.ImageIndex = 2
        Me.btnAtualizar.ImageList = Me.ImageList1
        Me.btnAtualizar.Location = New System.Drawing.Point(813, 371)
        Me.btnAtualizar.Name = "btnAtualizar"
        Me.btnAtualizar.Size = New System.Drawing.Size(89, 40)
        Me.btnAtualizar.TabIndex = 10
        Me.btnAtualizar.Text = "Atualizar"
        Me.btnAtualizar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnAtualizar.UseVisualStyleBackColor = True
        '
        'Form_Usuarios
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkViolet
        Me.ClientSize = New System.Drawing.Size(914, 450)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.btnAtualizar)
        Me.Controls.Add(Me.dtGridUsuarios)
        Me.Controls.Add(Me.btnTrocarBd)
        Me.Controls.Add(Me.txtCargo)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.txtConfirmaSenha)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtSenha)
        Me.Controls.Add(Me.txtUsuario)
        Me.Controls.Add(Me.txtSobrenome)
        Me.Controls.Add(Me.txtNome)
        Me.Controls.Add(Me.Button1)
        Me.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "Form_Usuarios"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cadastro de Usuarios"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.dtGridUsuarios, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents txtNome As TextBox
    Friend WithEvents txtSobrenome As TextBox
    Friend WithEvents txtUsuario As TextBox
    Friend WithEvents txtSenha As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txtConfirmaSenha As TextBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label6 As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents Label7 As Label
    Friend WithEvents txtCargo As TextBox
    Friend WithEvents btnTrocarBd As Button
    Friend WithEvents dtGridUsuarios As DataGridView
    Friend WithEvents btnAtualizar As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents ImageList1 As ImageList
    Friend WithEvents Button4 As Button
End Class
