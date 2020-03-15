<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPrincipal
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPrincipal))
        Me.pnlTitulo = New System.Windows.Forms.Panel()
        Me.lblTitulo = New System.Windows.Forms.Label()
        Me.pnlPainel = New System.Windows.Forms.Panel()
        Me.btnAlunos = New System.Windows.Forms.Button()
        Me.btnProfessores = New System.Windows.Forms.Button()
        Me.pnlTitulo.SuspendLayout()
        Me.pnlPainel.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlTitulo
        '
        Me.pnlTitulo.BackColor = System.Drawing.Color.FromArgb(CType(CType(49, Byte), Integer), CType(CType(91, Byte), Integer), CType(CType(157, Byte), Integer))
        Me.pnlTitulo.Controls.Add(Me.lblTitulo)
        Me.pnlTitulo.Location = New System.Drawing.Point(-1, 0)
        Me.pnlTitulo.Name = "pnlTitulo"
        Me.pnlTitulo.Size = New System.Drawing.Size(1239, 101)
        Me.pnlTitulo.TabIndex = 0
        '
        'lblTitulo
        '
        Me.lblTitulo.AutoSize = True
        Me.lblTitulo.Font = New System.Drawing.Font("Segoe UI", 22.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitulo.ForeColor = System.Drawing.Color.White
        Me.lblTitulo.Location = New System.Drawing.Point(462, 24)
        Me.lblTitulo.Name = "lblTitulo"
        Me.lblTitulo.Size = New System.Drawing.Size(338, 51)
        Me.lblTitulo.TabIndex = 0
        Me.lblTitulo.Text = "SISTEMA ESCOLAR"
        Me.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'pnlPainel
        '
        Me.pnlPainel.BackColor = System.Drawing.Color.White
        Me.pnlPainel.Controls.Add(Me.btnProfessores)
        Me.pnlPainel.Controls.Add(Me.btnAlunos)
        Me.pnlPainel.Location = New System.Drawing.Point(22, 129)
        Me.pnlPainel.Name = "pnlPainel"
        Me.pnlPainel.Size = New System.Drawing.Size(1190, 550)
        Me.pnlPainel.TabIndex = 1
        '
        'btnAlunos
        '
        Me.btnAlunos.BackColor = System.Drawing.Color.FromArgb(CType(CType(49, Byte), Integer), CType(CType(91, Byte), Integer), CType(CType(157, Byte), Integer))
        Me.btnAlunos.FlatAppearance.BorderSize = 0
        Me.btnAlunos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(78, Byte), Integer), CType(CType(96, Byte), Integer), CType(CType(126, Byte), Integer))
        Me.btnAlunos.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAlunos.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAlunos.ForeColor = System.Drawing.Color.White
        Me.btnAlunos.Image = CType(resources.GetObject("btnAlunos.Image"), System.Drawing.Image)
        Me.btnAlunos.Location = New System.Drawing.Point(14, 18)
        Me.btnAlunos.Name = "btnAlunos"
        Me.btnAlunos.Size = New System.Drawing.Size(150, 150)
        Me.btnAlunos.TabIndex = 0
        Me.btnAlunos.Text = "Alunos"
        Me.btnAlunos.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnAlunos.UseVisualStyleBackColor = False
        '
        'btnProfessores
        '
        Me.btnProfessores.BackColor = System.Drawing.Color.FromArgb(CType(CType(49, Byte), Integer), CType(CType(91, Byte), Integer), CType(CType(157, Byte), Integer))
        Me.btnProfessores.FlatAppearance.BorderSize = 0
        Me.btnProfessores.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(78, Byte), Integer), CType(CType(96, Byte), Integer), CType(CType(126, Byte), Integer))
        Me.btnProfessores.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnProfessores.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnProfessores.ForeColor = System.Drawing.Color.White
        Me.btnProfessores.Image = CType(resources.GetObject("btnProfessores.Image"), System.Drawing.Image)
        Me.btnProfessores.Location = New System.Drawing.Point(198, 18)
        Me.btnProfessores.Name = "btnProfessores"
        Me.btnProfessores.Size = New System.Drawing.Size(150, 150)
        Me.btnProfessores.TabIndex = 0
        Me.btnProfessores.Text = "Professores"
        Me.btnProfessores.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnProfessores.UseVisualStyleBackColor = False
        '
        'frmPrincipal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1237, 706)
        Me.Controls.Add(Me.pnlPainel)
        Me.Controls.Add(Me.pnlTitulo)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frmPrincipal"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Menu Principal"
        Me.pnlTitulo.ResumeLayout(False)
        Me.pnlTitulo.PerformLayout()
        Me.pnlPainel.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pnlTitulo As Panel
    Friend WithEvents lblTitulo As Label
    Friend WithEvents pnlPainel As Panel
    Friend WithEvents btnAlunos As Button
    Friend WithEvents btnProfessores As Button
End Class
