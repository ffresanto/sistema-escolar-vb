<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTelaLogin
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmTelaLogin))
        Me.pnlBg = New System.Windows.Forms.Panel()
        Me.btnEntrar = New System.Windows.Forms.Button()
        Me.txtSenha = New System.Windows.Forms.TextBox()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.btnFechar = New System.Windows.Forms.Label()
        Me.pnlBg.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlBg
        '
        Me.pnlBg.BackgroundImage = CType(resources.GetObject("pnlBg.BackgroundImage"), System.Drawing.Image)
        Me.pnlBg.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pnlBg.Controls.Add(Me.btnFechar)
        Me.pnlBg.Controls.Add(Me.btnEntrar)
        Me.pnlBg.Controls.Add(Me.txtSenha)
        Me.pnlBg.Controls.Add(Me.txtEmail)
        Me.pnlBg.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlBg.Location = New System.Drawing.Point(0, 0)
        Me.pnlBg.Name = "pnlBg"
        Me.pnlBg.Size = New System.Drawing.Size(432, 683)
        Me.pnlBg.TabIndex = 0
        '
        'btnEntrar
        '
        Me.btnEntrar.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(84, Byte), Integer), CType(CType(56, Byte), Integer))
        Me.btnEntrar.FlatAppearance.BorderSize = 0
        Me.btnEntrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEntrar.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEntrar.ForeColor = System.Drawing.Color.White
        Me.btnEntrar.Location = New System.Drawing.Point(16, 462)
        Me.btnEntrar.Name = "btnEntrar"
        Me.btnEntrar.Size = New System.Drawing.Size(402, 60)
        Me.btnEntrar.TabIndex = 2
        Me.btnEntrar.Text = "ENTRAR"
        Me.btnEntrar.UseVisualStyleBackColor = False
        '
        'txtSenha
        '
        Me.txtSenha.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtSenha.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSenha.Location = New System.Drawing.Point(68, 399)
        Me.txtSenha.Name = "txtSenha"
        Me.txtSenha.Size = New System.Drawing.Size(332, 23)
        Me.txtSenha.TabIndex = 1
        Me.txtSenha.UseSystemPasswordChar = True
        '
        'txtEmail
        '
        Me.txtEmail.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtEmail.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEmail.Location = New System.Drawing.Point(68, 319)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(332, 23)
        Me.txtEmail.TabIndex = 0
        '
        'btnFechar
        '
        Me.btnFechar.AutoSize = True
        Me.btnFechar.BackColor = System.Drawing.Color.Transparent
        Me.btnFechar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnFechar.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.btnFechar.ForeColor = System.Drawing.Color.White
        Me.btnFechar.Location = New System.Drawing.Point(395, 9)
        Me.btnFechar.Name = "btnFechar"
        Me.btnFechar.Size = New System.Drawing.Size(25, 28)
        Me.btnFechar.TabIndex = 3
        Me.btnFechar.Text = "X"
        '
        'frmTelaLogin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(432, 683)
        Me.Controls.Add(Me.pnlBg)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmTelaLogin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Tela de Login"
        Me.pnlBg.ResumeLayout(False)
        Me.pnlBg.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pnlBg As Panel
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents txtSenha As TextBox
    Friend WithEvents btnEntrar As Button
    Friend WithEvents btnFechar As Label
End Class
