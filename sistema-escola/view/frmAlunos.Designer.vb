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
        Me.grpBuscarPor = New System.Windows.Forms.GroupBox()
        Me.lblCodigo = New System.Windows.Forms.Label()
        Me.txtCodigo = New System.Windows.Forms.TextBox()
        Me.rdoCpf = New System.Windows.Forms.RadioButton()
        Me.rdoNome = New System.Windows.Forms.RadioButton()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.btnAdicionar = New System.Windows.Forms.Button()
        Me.lblTituloTotal = New System.Windows.Forms.Label()
        Me.lblNumeroTotal = New System.Windows.Forms.Label()
        Me.pnlTitulo.SuspendLayout()
        Me.pnlPainel.SuspendLayout()
        Me.grpBuscarPor.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pnlTitulo
        '
        Me.pnlTitulo.BackColor = System.Drawing.Color.FromArgb(CType(CType(49, Byte), Integer), CType(CType(91, Byte), Integer), CType(CType(157, Byte), Integer))
        Me.pnlTitulo.Controls.Add(Me.lblTitulo)
        Me.pnlTitulo.Location = New System.Drawing.Point(0, 0)
        Me.pnlTitulo.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.pnlTitulo.Name = "pnlTitulo"
        Me.pnlTitulo.Size = New System.Drawing.Size(978, 101)
        Me.pnlTitulo.TabIndex = 1
        '
        'lblTitulo
        '
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
        Me.pnlPainel.Size = New System.Drawing.Size(952, 546)
        Me.pnlPainel.TabIndex = 2
        '
        'grpBuscarPor
        '
        Me.grpBuscarPor.Controls.Add(Me.rdoNome)
        Me.grpBuscarPor.Controls.Add(Me.rdoCpf)
        Me.grpBuscarPor.Controls.Add(Me.txtCodigo)
        Me.grpBuscarPor.Controls.Add(Me.lblCodigo)
        Me.grpBuscarPor.Font = New System.Drawing.Font("Segoe UI", 12.2!)
        Me.grpBuscarPor.Location = New System.Drawing.Point(24, 20)
        Me.grpBuscarPor.Name = "grpBuscarPor"
        Me.grpBuscarPor.Size = New System.Drawing.Size(904, 136)
        Me.grpBuscarPor.TabIndex = 0
        Me.grpBuscarPor.TabStop = False
        Me.grpBuscarPor.Text = "Buscar Por:"
        '
        'lblCodigo
        '
        Me.lblCodigo.AutoSize = True
        Me.lblCodigo.Location = New System.Drawing.Point(6, 88)
        Me.lblCodigo.Name = "lblCodigo"
        Me.lblCodigo.Size = New System.Drawing.Size(84, 30)
        Me.lblCodigo.TabIndex = 0
        Me.lblCodigo.Text = "Código:"
        '
        'txtCodigo
        '
        Me.txtCodigo.Location = New System.Drawing.Point(96, 85)
        Me.txtCodigo.Name = "txtCodigo"
        Me.txtCodigo.Size = New System.Drawing.Size(220, 35)
        Me.txtCodigo.TabIndex = 1
        '
        'rdoCpf
        '
        Me.rdoCpf.AutoSize = True
        Me.rdoCpf.Location = New System.Drawing.Point(11, 42)
        Me.rdoCpf.Name = "rdoCpf"
        Me.rdoCpf.Size = New System.Drawing.Size(69, 34)
        Me.rdoCpf.TabIndex = 2
        Me.rdoCpf.TabStop = True
        Me.rdoCpf.Text = "CPF"
        Me.rdoCpf.UseVisualStyleBackColor = True
        '
        'rdoNome
        '
        Me.rdoNome.AutoSize = True
        Me.rdoNome.Location = New System.Drawing.Point(96, 42)
        Me.rdoNome.Name = "rdoNome"
        Me.rdoNome.Size = New System.Drawing.Size(91, 34)
        Me.rdoNome.TabIndex = 2
        Me.rdoNome.TabStop = True
        Me.rdoNome.Text = "Nome"
        Me.rdoNome.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(24, 175)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(904, 296)
        Me.DataGridView1.TabIndex = 1
        '
        'btnAdicionar
        '
        Me.btnAdicionar.BackColor = System.Drawing.Color.FromArgb(CType(CType(49, Byte), Integer), CType(CType(91, Byte), Integer), CType(CType(157, Byte), Integer))
        Me.btnAdicionar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(78, Byte), Integer), CType(CType(96, Byte), Integer), CType(CType(126, Byte), Integer))
        Me.btnAdicionar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAdicionar.Font = New System.Drawing.Font("Segoe UI", 12.2!)
        Me.btnAdicionar.ForeColor = System.Drawing.Color.White
        Me.btnAdicionar.Location = New System.Drawing.Point(24, 482)
        Me.btnAdicionar.Name = "btnAdicionar"
        Me.btnAdicionar.Size = New System.Drawing.Size(160, 52)
        Me.btnAdicionar.TabIndex = 2
        Me.btnAdicionar.Text = "Adicionar"
        Me.btnAdicionar.UseVisualStyleBackColor = False
        '
        'lblTituloTotal
        '
        Me.lblTituloTotal.AutoSize = True
        Me.lblTituloTotal.Font = New System.Drawing.Font("Segoe UI", 12.2!)
        Me.lblTituloTotal.Location = New System.Drawing.Point(810, 494)
        Me.lblTituloTotal.Name = "lblTituloTotal"
        Me.lblTituloTotal.Size = New System.Drawing.Size(77, 30)
        Me.lblTituloTotal.TabIndex = 3
        Me.lblTituloTotal.Text = "TOTAL:"
        '
        'lblNumeroTotal
        '
        Me.lblNumeroTotal.AutoSize = True
        Me.lblNumeroTotal.Enabled = False
        Me.lblNumeroTotal.Font = New System.Drawing.Font("Segoe UI", 12.2!)
        Me.lblNumeroTotal.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(84, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.lblNumeroTotal.Location = New System.Drawing.Point(881, 494)
        Me.lblNumeroTotal.Name = "lblNumeroTotal"
        Me.lblNumeroTotal.Size = New System.Drawing.Size(24, 30)
        Me.lblNumeroTotal.TabIndex = 4
        Me.lblNumeroTotal.Text = "0"
        '
        'frmAlunos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(976, 673)
        Me.Controls.Add(Me.pnlPainel)
        Me.Controls.Add(Me.pnlTitulo)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frmAlunos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Registro de Alunos"
        Me.pnlTitulo.ResumeLayout(False)
        Me.pnlTitulo.PerformLayout()
        Me.pnlPainel.ResumeLayout(False)
        Me.pnlPainel.PerformLayout()
        Me.grpBuscarPor.ResumeLayout(False)
        Me.grpBuscarPor.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
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
End Class
