<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAlunos
    Inherits System.Windows.Forms.Form

    'Descartar substituições de formulário para limpar a lista de componentes.
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

    'Exigido pelo Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'OBSERVAÇÃO: o procedimento a seguir é exigido pelo Windows Form Designer
    'Pode ser modificado usando o Windows Form Designer.  
    'Não o modifique usando o editor de códigos.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAlunos))
        Me.pnlTitulo = New System.Windows.Forms.Panel()
        Me.lblTitulo = New System.Windows.Forms.Label()
        Me.pnlPainel = New System.Windows.Forms.Panel()
        Me.lblNumeroTotal = New System.Windows.Forms.Label()
        Me.lblTituloTotal = New System.Windows.Forms.Label()
        Me.btnAdicionar = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.grpBuscarPor = New System.Windows.Forms.GroupBox()
        Me.rdoNome = New System.Windows.Forms.RadioButton()
        Me.rdoCpf = New System.Windows.Forms.RadioButton()
        Me.txtCodigo = New System.Windows.Forms.TextBox()
        Me.lblCodigo = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnFecharDados = New System.Windows.Forms.Button()
        Me.btnEditar = New System.Windows.Forms.Button()
        Me.btnSalvar = New System.Windows.Forms.Button()
        Me.txtEndereco = New System.Windows.Forms.TextBox()
        Me.lblEndereco = New System.Windows.Forms.Label()
        Me.lblDataNascimento = New System.Windows.Forms.Label()
        Me.dtpDataNascimento = New System.Windows.Forms.DateTimePicker()
        Me.lblSexo = New System.Windows.Forms.Label()
        Me.rdoFeminino = New System.Windows.Forms.RadioButton()
        Me.rdoMasculino = New System.Windows.Forms.RadioButton()
        Me.txtIdade = New System.Windows.Forms.TextBox()
        Me.lblIdade = New System.Windows.Forms.Label()
        Me.txtSobrenome = New System.Windows.Forms.TextBox()
        Me.lblSobrenome = New System.Windows.Forms.Label()
        Me.txtNome = New System.Windows.Forms.TextBox()
        Me.lblNome = New System.Windows.Forms.Label()
        Me.txtCpf = New System.Windows.Forms.TextBox()
        Me.lblCpf = New System.Windows.Forms.Label()
        Me.pnlTitulo.SuspendLayout()
        Me.pnlPainel.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpBuscarPor.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlTitulo
        '
        Me.pnlTitulo.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnlTitulo.BackColor = System.Drawing.Color.FromArgb(CType(CType(49, Byte), Integer), CType(CType(91, Byte), Integer), CType(CType(157, Byte), Integer))
        Me.pnlTitulo.Controls.Add(Me.lblTitulo)
        Me.pnlTitulo.Location = New System.Drawing.Point(0, 0)
        Me.pnlTitulo.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.pnlTitulo.Name = "pnlTitulo"
        Me.pnlTitulo.Size = New System.Drawing.Size(1315, 101)
        Me.pnlTitulo.TabIndex = 1
        '
        'lblTitulo
        '
        Me.lblTitulo.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblTitulo.AutoSize = True
        Me.lblTitulo.Font = New System.Drawing.Font("Segoe UI", 22.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitulo.ForeColor = System.Drawing.Color.White
        Me.lblTitulo.Location = New System.Drawing.Point(341, 23)
        Me.lblTitulo.Name = "lblTitulo"
        Me.lblTitulo.Size = New System.Drawing.Size(337, 51)
        Me.lblTitulo.TabIndex = 0
        Me.lblTitulo.Text = "Registro de Alunos"
        Me.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'pnlPainel
        '
        Me.pnlPainel.BackColor = System.Drawing.Color.White
        Me.pnlPainel.Controls.Add(Me.lblNumeroTotal)
        Me.pnlPainel.Controls.Add(Me.lblTituloTotal)
        Me.pnlPainel.Controls.Add(Me.btnAdicionar)
        Me.pnlPainel.Controls.Add(Me.DataGridView1)
        Me.pnlPainel.Controls.Add(Me.grpBuscarPor)
        Me.pnlPainel.Location = New System.Drawing.Point(12, 116)
        Me.pnlPainel.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.pnlPainel.Name = "pnlPainel"
        Me.pnlPainel.Size = New System.Drawing.Size(952, 598)
        Me.pnlPainel.TabIndex = 2
        '
        'lblNumeroTotal
        '
        Me.lblNumeroTotal.AutoSize = True
        Me.lblNumeroTotal.Enabled = False
        Me.lblNumeroTotal.Font = New System.Drawing.Font("Segoe UI", 12.2!)
        Me.lblNumeroTotal.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(84, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.lblNumeroTotal.Location = New System.Drawing.Point(881, 546)
        Me.lblNumeroTotal.Name = "lblNumeroTotal"
        Me.lblNumeroTotal.Size = New System.Drawing.Size(24, 30)
        Me.lblNumeroTotal.TabIndex = 4
        Me.lblNumeroTotal.Text = "0"
        '
        'lblTituloTotal
        '
        Me.lblTituloTotal.AutoSize = True
        Me.lblTituloTotal.Font = New System.Drawing.Font("Segoe UI", 12.2!)
        Me.lblTituloTotal.Location = New System.Drawing.Point(811, 546)
        Me.lblTituloTotal.Name = "lblTituloTotal"
        Me.lblTituloTotal.Size = New System.Drawing.Size(77, 30)
        Me.lblTituloTotal.TabIndex = 3
        Me.lblTituloTotal.Text = "TOTAL:"
        '
        'btnAdicionar
        '
        Me.btnAdicionar.BackColor = System.Drawing.Color.FromArgb(CType(CType(49, Byte), Integer), CType(CType(91, Byte), Integer), CType(CType(157, Byte), Integer))
        Me.btnAdicionar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAdicionar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(78, Byte), Integer), CType(CType(96, Byte), Integer), CType(CType(126, Byte), Integer))
        Me.btnAdicionar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAdicionar.Font = New System.Drawing.Font("Segoe UI", 12.2!)
        Me.btnAdicionar.ForeColor = System.Drawing.Color.White
        Me.btnAdicionar.Location = New System.Drawing.Point(24, 534)
        Me.btnAdicionar.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnAdicionar.Name = "btnAdicionar"
        Me.btnAdicionar.Size = New System.Drawing.Size(160, 52)
        Me.btnAdicionar.TabIndex = 2
        Me.btnAdicionar.Text = "Adicionar"
        Me.btnAdicionar.UseVisualStyleBackColor = False
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(24, 175)
        Me.DataGridView1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(904, 348)
        Me.DataGridView1.TabIndex = 1
        '
        'grpBuscarPor
        '
        Me.grpBuscarPor.Controls.Add(Me.rdoNome)
        Me.grpBuscarPor.Controls.Add(Me.rdoCpf)
        Me.grpBuscarPor.Controls.Add(Me.txtCodigo)
        Me.grpBuscarPor.Controls.Add(Me.lblCodigo)
        Me.grpBuscarPor.Font = New System.Drawing.Font("Segoe UI", 12.2!)
        Me.grpBuscarPor.Location = New System.Drawing.Point(24, 20)
        Me.grpBuscarPor.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.grpBuscarPor.Name = "grpBuscarPor"
        Me.grpBuscarPor.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.grpBuscarPor.Size = New System.Drawing.Size(904, 135)
        Me.grpBuscarPor.TabIndex = 0
        Me.grpBuscarPor.TabStop = False
        Me.grpBuscarPor.Text = "Buscar Por:"
        '
        'rdoNome
        '
        Me.rdoNome.AutoSize = True
        Me.rdoNome.Location = New System.Drawing.Point(96, 42)
        Me.rdoNome.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.rdoNome.Name = "rdoNome"
        Me.rdoNome.Size = New System.Drawing.Size(91, 34)
        Me.rdoNome.TabIndex = 2
        Me.rdoNome.TabStop = True
        Me.rdoNome.Text = "Nome"
        Me.rdoNome.UseVisualStyleBackColor = True
        '
        'rdoCpf
        '
        Me.rdoCpf.AutoSize = True
        Me.rdoCpf.Location = New System.Drawing.Point(11, 42)
        Me.rdoCpf.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.rdoCpf.Name = "rdoCpf"
        Me.rdoCpf.Size = New System.Drawing.Size(69, 34)
        Me.rdoCpf.TabIndex = 2
        Me.rdoCpf.TabStop = True
        Me.rdoCpf.Text = "CPF"
        Me.rdoCpf.UseVisualStyleBackColor = True
        '
        'txtCodigo
        '
        Me.txtCodigo.Location = New System.Drawing.Point(96, 85)
        Me.txtCodigo.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtCodigo.Name = "txtCodigo"
        Me.txtCodigo.Size = New System.Drawing.Size(220, 35)
        Me.txtCodigo.TabIndex = 1
        '
        'lblCodigo
        '
        Me.lblCodigo.AutoSize = True
        Me.lblCodigo.Location = New System.Drawing.Point(5, 89)
        Me.lblCodigo.Name = "lblCodigo"
        Me.lblCodigo.Size = New System.Drawing.Size(84, 30)
        Me.lblCodigo.TabIndex = 0
        Me.lblCodigo.Text = "Código:"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.White
        Me.GroupBox1.Controls.Add(Me.btnFecharDados)
        Me.GroupBox1.Controls.Add(Me.btnEditar)
        Me.GroupBox1.Controls.Add(Me.btnSalvar)
        Me.GroupBox1.Controls.Add(Me.txtEndereco)
        Me.GroupBox1.Controls.Add(Me.lblEndereco)
        Me.GroupBox1.Controls.Add(Me.lblDataNascimento)
        Me.GroupBox1.Controls.Add(Me.dtpDataNascimento)
        Me.GroupBox1.Controls.Add(Me.lblSexo)
        Me.GroupBox1.Controls.Add(Me.rdoFeminino)
        Me.GroupBox1.Controls.Add(Me.rdoMasculino)
        Me.GroupBox1.Controls.Add(Me.txtIdade)
        Me.GroupBox1.Controls.Add(Me.lblIdade)
        Me.GroupBox1.Controls.Add(Me.txtSobrenome)
        Me.GroupBox1.Controls.Add(Me.lblSobrenome)
        Me.GroupBox1.Controls.Add(Me.txtNome)
        Me.GroupBox1.Controls.Add(Me.lblNome)
        Me.GroupBox1.Controls.Add(Me.txtCpf)
        Me.GroupBox1.Controls.Add(Me.lblCpf)
        Me.GroupBox1.Font = New System.Drawing.Font("Segoe UI", 12.2!)
        Me.GroupBox1.Location = New System.Drawing.Point(978, 116)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox1.Size = New System.Drawing.Size(322, 598)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Dados Pessoais:"
        '
        'btnFecharDados
        '
        Me.btnFecharDados.BackColor = System.Drawing.Color.Red
        Me.btnFecharDados.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnFecharDados.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(78, Byte), Integer), CType(CType(96, Byte), Integer), CType(CType(126, Byte), Integer))
        Me.btnFecharDados.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnFecharDados.Font = New System.Drawing.Font("Segoe UI", 12.2!)
        Me.btnFecharDados.ForeColor = System.Drawing.Color.White
        Me.btnFecharDados.Location = New System.Drawing.Point(279, 0)
        Me.btnFecharDados.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnFecharDados.Name = "btnFecharDados"
        Me.btnFecharDados.Size = New System.Drawing.Size(40, 40)
        Me.btnFecharDados.TabIndex = 11
        Me.btnFecharDados.Text = "x"
        Me.btnFecharDados.UseVisualStyleBackColor = False
        '
        'btnEditar
        '
        Me.btnEditar.BackColor = System.Drawing.Color.FromArgb(CType(CType(49, Byte), Integer), CType(CType(91, Byte), Integer), CType(CType(157, Byte), Integer))
        Me.btnEditar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnEditar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(78, Byte), Integer), CType(CType(96, Byte), Integer), CType(CType(126, Byte), Integer))
        Me.btnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEditar.Font = New System.Drawing.Font("Segoe UI", 12.2!)
        Me.btnEditar.ForeColor = System.Drawing.Color.White
        Me.btnEditar.Location = New System.Drawing.Point(160, 524)
        Me.btnEditar.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnEditar.Name = "btnEditar"
        Me.btnEditar.Size = New System.Drawing.Size(140, 52)
        Me.btnEditar.TabIndex = 5
        Me.btnEditar.Text = "Editar"
        Me.btnEditar.UseVisualStyleBackColor = False
        '
        'btnSalvar
        '
        Me.btnSalvar.BackColor = System.Drawing.Color.FromArgb(CType(CType(49, Byte), Integer), CType(CType(91, Byte), Integer), CType(CType(157, Byte), Integer))
        Me.btnSalvar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSalvar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(78, Byte), Integer), CType(CType(96, Byte), Integer), CType(CType(126, Byte), Integer))
        Me.btnSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSalvar.Font = New System.Drawing.Font("Segoe UI", 12.2!)
        Me.btnSalvar.ForeColor = System.Drawing.Color.White
        Me.btnSalvar.Location = New System.Drawing.Point(11, 524)
        Me.btnSalvar.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnSalvar.Name = "btnSalvar"
        Me.btnSalvar.Size = New System.Drawing.Size(140, 52)
        Me.btnSalvar.TabIndex = 5
        Me.btnSalvar.Text = "Salvar"
        Me.btnSalvar.UseVisualStyleBackColor = False
        '
        'txtEndereco
        '
        Me.txtEndereco.Location = New System.Drawing.Point(11, 464)
        Me.txtEndereco.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtEndereco.Name = "txtEndereco"
        Me.txtEndereco.Size = New System.Drawing.Size(289, 35)
        Me.txtEndereco.TabIndex = 10
        '
        'lblEndereco
        '
        Me.lblEndereco.AutoSize = True
        Me.lblEndereco.Location = New System.Drawing.Point(6, 432)
        Me.lblEndereco.Name = "lblEndereco"
        Me.lblEndereco.Size = New System.Drawing.Size(104, 30)
        Me.lblEndereco.TabIndex = 9
        Me.lblEndereco.Text = "Endereço:"
        '
        'lblDataNascimento
        '
        Me.lblDataNascimento.AutoSize = True
        Me.lblDataNascimento.Location = New System.Drawing.Point(6, 361)
        Me.lblDataNascimento.Name = "lblDataNascimento"
        Me.lblDataNascimento.Size = New System.Drawing.Size(208, 30)
        Me.lblDataNascimento.TabIndex = 8
        Me.lblDataNascimento.Text = "Data de Nascimento:"
        '
        'dtpDataNascimento
        '
        Me.dtpDataNascimento.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpDataNascimento.Location = New System.Drawing.Point(11, 394)
        Me.dtpDataNascimento.Name = "dtpDataNascimento"
        Me.dtpDataNascimento.Size = New System.Drawing.Size(289, 35)
        Me.dtpDataNascimento.TabIndex = 7
        Me.dtpDataNascimento.Value = New Date(2000, 1, 1, 22, 0, 0, 0)
        '
        'lblSexo
        '
        Me.lblSexo.AutoSize = True
        Me.lblSexo.Location = New System.Drawing.Point(6, 255)
        Me.lblSexo.Name = "lblSexo"
        Me.lblSexo.Size = New System.Drawing.Size(62, 30)
        Me.lblSexo.TabIndex = 6
        Me.lblSexo.Text = "Sexo:"
        '
        'rdoFeminino
        '
        Me.rdoFeminino.AutoSize = True
        Me.rdoFeminino.BackColor = System.Drawing.Color.Transparent
        Me.rdoFeminino.Location = New System.Drawing.Point(9, 325)
        Me.rdoFeminino.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.rdoFeminino.Name = "rdoFeminino"
        Me.rdoFeminino.Size = New System.Drawing.Size(119, 34)
        Me.rdoFeminino.TabIndex = 3
        Me.rdoFeminino.TabStop = True
        Me.rdoFeminino.Text = "Feminino"
        Me.rdoFeminino.UseVisualStyleBackColor = False
        '
        'rdoMasculino
        '
        Me.rdoMasculino.AutoSize = True
        Me.rdoMasculino.Location = New System.Drawing.Point(9, 287)
        Me.rdoMasculino.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.rdoMasculino.Name = "rdoMasculino"
        Me.rdoMasculino.Size = New System.Drawing.Size(129, 34)
        Me.rdoMasculino.TabIndex = 4
        Me.rdoMasculino.TabStop = True
        Me.rdoMasculino.Text = "Masculino"
        Me.rdoMasculino.UseVisualStyleBackColor = True
        '
        'txtIdade
        '
        Me.txtIdade.Location = New System.Drawing.Point(241, 218)
        Me.txtIdade.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtIdade.Name = "txtIdade"
        Me.txtIdade.Size = New System.Drawing.Size(59, 35)
        Me.txtIdade.TabIndex = 5
        '
        'lblIdade
        '
        Me.lblIdade.AutoSize = True
        Me.lblIdade.Location = New System.Drawing.Point(236, 186)
        Me.lblIdade.Name = "lblIdade"
        Me.lblIdade.Size = New System.Drawing.Size(70, 30)
        Me.lblIdade.TabIndex = 4
        Me.lblIdade.Text = "Idade:"
        '
        'txtSobrenome
        '
        Me.txtSobrenome.Location = New System.Drawing.Point(11, 218)
        Me.txtSobrenome.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtSobrenome.Name = "txtSobrenome"
        Me.txtSobrenome.Size = New System.Drawing.Size(224, 35)
        Me.txtSobrenome.TabIndex = 3
        '
        'lblSobrenome
        '
        Me.lblSobrenome.AutoSize = True
        Me.lblSobrenome.Location = New System.Drawing.Point(6, 186)
        Me.lblSobrenome.Name = "lblSobrenome"
        Me.lblSobrenome.Size = New System.Drawing.Size(124, 30)
        Me.lblSobrenome.TabIndex = 2
        Me.lblSobrenome.Text = "Sobrenome:"
        '
        'txtNome
        '
        Me.txtNome.Location = New System.Drawing.Point(11, 148)
        Me.txtNome.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtNome.Name = "txtNome"
        Me.txtNome.Size = New System.Drawing.Size(289, 35)
        Me.txtNome.TabIndex = 1
        '
        'lblNome
        '
        Me.lblNome.AutoSize = True
        Me.lblNome.Location = New System.Drawing.Point(6, 116)
        Me.lblNome.Name = "lblNome"
        Me.lblNome.Size = New System.Drawing.Size(75, 30)
        Me.lblNome.TabIndex = 0
        Me.lblNome.Text = "Nome:"
        '
        'txtCpf
        '
        Me.txtCpf.Location = New System.Drawing.Point(11, 78)
        Me.txtCpf.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtCpf.Name = "txtCpf"
        Me.txtCpf.Size = New System.Drawing.Size(289, 35)
        Me.txtCpf.TabIndex = 1
        '
        'lblCpf
        '
        Me.lblCpf.AutoSize = True
        Me.lblCpf.Location = New System.Drawing.Point(6, 46)
        Me.lblCpf.Name = "lblCpf"
        Me.lblCpf.Size = New System.Drawing.Size(53, 30)
        Me.lblCpf.TabIndex = 0
        Me.lblCpf.Text = "CPF:"
        '
        'frmAlunos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1312, 725)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.pnlPainel)
        Me.Controls.Add(Me.pnlTitulo)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.MaximizeBox = False
        Me.Name = "frmAlunos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Registro de Alunos"
        Me.pnlTitulo.ResumeLayout(False)
        Me.pnlTitulo.PerformLayout()
        Me.pnlPainel.ResumeLayout(False)
        Me.pnlPainel.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpBuscarPor.ResumeLayout(False)
        Me.grpBuscarPor.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pnlTitulo As Panel
    Friend WithEvents lblTitulo As Label
    Friend WithEvents pnlPainel As Panel
    Friend WithEvents grpBuscarPor As GroupBox
    Friend WithEvents lblCodigo As Label
    Friend WithEvents rdoNome As RadioButton
    Friend WithEvents rdoCpf As RadioButton
    Friend WithEvents txtCodigo As TextBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents btnAdicionar As Button
    Friend WithEvents lblNumeroTotal As Label
    Friend WithEvents lblTituloTotal As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txtCpf As TextBox
    Friend WithEvents lblCpf As Label
    Friend WithEvents txtSobrenome As TextBox
    Friend WithEvents lblSobrenome As Label
    Friend WithEvents txtNome As TextBox
    Friend WithEvents lblNome As Label
    Friend WithEvents txtIdade As TextBox
    Friend WithEvents lblIdade As Label
    Friend WithEvents lblSexo As Label
    Friend WithEvents rdoFeminino As RadioButton
    Friend WithEvents rdoMasculino As RadioButton
    Friend WithEvents lblDataNascimento As Label
    Friend WithEvents dtpDataNascimento As DateTimePicker
    Friend WithEvents txtEndereco As TextBox
    Friend WithEvents lblEndereco As Label
    Friend WithEvents btnEditar As Button
    Friend WithEvents btnSalvar As Button
    Friend WithEvents btnFecharDados As Button
End Class
