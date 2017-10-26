<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormCadastrar
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
        Me.TBDescricao = New System.Windows.Forms.TextBox()
        Me.Descricao = New System.Windows.Forms.Label()
        Me.Quantidade = New System.Windows.Forms.NumericUpDown()
        Me.QT = New System.Windows.Forms.Label()
        Me.DirectoryEntry1 = New System.DirectoryServices.DirectoryEntry()
        Me.Cod = New System.Windows.Forms.Label()
        Me.Codigo = New System.Windows.Forms.NumericUpDown()
        Me.CadastrarRec = New System.Windows.Forms.Button()
        CType(Me.Quantidade, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Codigo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TBDescricao
        '
        Me.TBDescricao.Location = New System.Drawing.Point(15, 25)
        Me.TBDescricao.Name = "TBDescricao"
        Me.TBDescricao.Size = New System.Drawing.Size(361, 20)
        Me.TBDescricao.TabIndex = 0
        '
        'Descricao
        '
        Me.Descricao.AutoSize = True
        Me.Descricao.Location = New System.Drawing.Point(12, 9)
        Me.Descricao.Name = "Descricao"
        Me.Descricao.Size = New System.Drawing.Size(111, 13)
        Me.Descricao.TabIndex = 1
        Me.Descricao.Text = "Descrição do recurso:"
        '
        'Quantidade
        '
        Me.Quantidade.Location = New System.Drawing.Point(85, 51)
        Me.Quantidade.Name = "Quantidade"
        Me.Quantidade.Size = New System.Drawing.Size(59, 20)
        Me.Quantidade.TabIndex = 2
        '
        'QT
        '
        Me.QT.AutoSize = True
        Me.QT.Location = New System.Drawing.Point(14, 53)
        Me.QT.Name = "QT"
        Me.QT.Size = New System.Drawing.Size(65, 13)
        Me.QT.TabIndex = 3
        Me.QT.Text = "Quantidade:"
        '
        'Cod
        '
        Me.Cod.AutoSize = True
        Me.Cod.Location = New System.Drawing.Point(166, 53)
        Me.Cod.Name = "Cod"
        Me.Cod.Size = New System.Drawing.Size(46, 13)
        Me.Cod.TabIndex = 5
        Me.Cod.Text = "Código: "
        '
        'Codigo
        '
        Me.Codigo.Location = New System.Drawing.Point(218, 51)
        Me.Codigo.Maximum = New Decimal(New Integer() {9999, 0, 0, 0})
        Me.Codigo.Name = "Codigo"
        Me.Codigo.Size = New System.Drawing.Size(120, 20)
        Me.Codigo.TabIndex = 6
        '
        'CadastrarRec
        '
        Me.CadastrarRec.Location = New System.Drawing.Point(15, 85)
        Me.CadastrarRec.Name = "CadastrarRec"
        Me.CadastrarRec.Size = New System.Drawing.Size(361, 23)
        Me.CadastrarRec.TabIndex = 7
        Me.CadastrarRec.Text = "Finalizar Cadastro"
        Me.CadastrarRec.UseVisualStyleBackColor = True
        '
        'FormCadastrar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(413, 120)
        Me.Controls.Add(Me.CadastrarRec)
        Me.Controls.Add(Me.Codigo)
        Me.Controls.Add(Me.Cod)
        Me.Controls.Add(Me.QT)
        Me.Controls.Add(Me.Quantidade)
        Me.Controls.Add(Me.Descricao)
        Me.Controls.Add(Me.TBDescricao)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "FormCadastrar"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cadastrar Recursos"
        CType(Me.Quantidade, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Codigo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TBDescricao As TextBox
    Friend WithEvents Descricao As Label
    Friend WithEvents Quantidade As NumericUpDown
    Friend WithEvents QT As Label
    Friend WithEvents DirectoryEntry1 As DirectoryServices.DirectoryEntry
    Friend WithEvents Cod As Label
    Friend WithEvents Codigo As NumericUpDown
    Friend WithEvents CadastrarRec As Button
End Class
