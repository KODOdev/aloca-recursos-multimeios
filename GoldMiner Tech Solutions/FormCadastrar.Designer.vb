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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormCadastrar))
        Me.TBDescricao = New System.Windows.Forms.TextBox()
        Me.Descricao = New System.Windows.Forms.Label()
        Me.Quantidade = New System.Windows.Forms.NumericUpDown()
        Me.QT = New System.Windows.Forms.Label()
        Me.DirectoryEntry1 = New System.DirectoryServices.DirectoryEntry()
        Me.Cod = New System.Windows.Forms.Label()
        Me.Codigo = New System.Windows.Forms.NumericUpDown()
        Me.CadastrarRec = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        CType(Me.Quantidade, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Codigo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'TBDescricao
        '
        Me.TBDescricao.Location = New System.Drawing.Point(6, 41)
        Me.TBDescricao.Name = "TBDescricao"
        Me.TBDescricao.Size = New System.Drawing.Size(349, 20)
        Me.TBDescricao.TabIndex = 0
        '
        'Descricao
        '
        Me.Descricao.AutoSize = True
        Me.Descricao.Location = New System.Drawing.Point(6, 16)
        Me.Descricao.Name = "Descricao"
        Me.Descricao.Size = New System.Drawing.Size(111, 13)
        Me.Descricao.TabIndex = 1
        Me.Descricao.Text = "Descrição do recurso:"
        '
        'Quantidade
        '
        Me.Quantidade.Location = New System.Drawing.Point(77, 14)
        Me.Quantidade.Name = "Quantidade"
        Me.Quantidade.Size = New System.Drawing.Size(59, 20)
        Me.Quantidade.TabIndex = 2
        '
        'QT
        '
        Me.QT.AutoSize = True
        Me.QT.Location = New System.Drawing.Point(6, 16)
        Me.QT.Name = "QT"
        Me.QT.Size = New System.Drawing.Size(65, 13)
        Me.QT.TabIndex = 3
        Me.QT.Text = "Quantidade:"
        '
        'Cod
        '
        Me.Cod.AutoSize = True
        Me.Cod.Location = New System.Drawing.Point(6, 16)
        Me.Cod.Name = "Cod"
        Me.Cod.Size = New System.Drawing.Size(46, 13)
        Me.Cod.TabIndex = 5
        Me.Cod.Text = "Código: "
        '
        'Codigo
        '
        Me.Codigo.Location = New System.Drawing.Point(58, 14)
        Me.Codigo.Maximum = New Decimal(New Integer() {9999, 0, 0, 0})
        Me.Codigo.Name = "Codigo"
        Me.Codigo.Size = New System.Drawing.Size(120, 20)
        Me.Codigo.TabIndex = 6
        '
        'CadastrarRec
        '
        Me.CadastrarRec.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CadastrarRec.Image = Global.GoldMiner_Tech_Solutions.My.Resources.Resources.check
        Me.CadastrarRec.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.CadastrarRec.Location = New System.Drawing.Point(12, 142)
        Me.CadastrarRec.Name = "CadastrarRec"
        Me.CadastrarRec.Size = New System.Drawing.Size(361, 23)
        Me.CadastrarRec.TabIndex = 7
        Me.CadastrarRec.Text = "Finalizar Cadastro"
        Me.CadastrarRec.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Silver
        Me.GroupBox1.Controls.Add(Me.Quantidade)
        Me.GroupBox1.Controls.Add(Me.QT)
        Me.GroupBox1.Location = New System.Drawing.Point(15, 93)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(151, 43)
        Me.GroupBox1.TabIndex = 8
        Me.GroupBox1.TabStop = False
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Silver
        Me.GroupBox2.Controls.Add(Me.Cod)
        Me.GroupBox2.Controls.Add(Me.Codigo)
        Me.GroupBox2.Location = New System.Drawing.Point(184, 93)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(192, 43)
        Me.GroupBox2.TabIndex = 9
        Me.GroupBox2.TabStop = False
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.Silver
        Me.GroupBox3.Controls.Add(Me.Descricao)
        Me.GroupBox3.Controls.Add(Me.TBDescricao)
        Me.GroupBox3.Location = New System.Drawing.Point(15, 12)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(361, 72)
        Me.GroupBox3.TabIndex = 10
        Me.GroupBox3.TabStop = False
        '
        'FormCadastrar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Silver
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ClientSize = New System.Drawing.Size(398, 175)
        Me.Controls.Add(Me.CadastrarRec)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox3)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "FormCadastrar"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cadastrar Recursos"
        CType(Me.Quantidade, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Codigo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TBDescricao As TextBox
    Friend WithEvents Descricao As Label
    Friend WithEvents Quantidade As NumericUpDown
    Friend WithEvents QT As Label
    Friend WithEvents DirectoryEntry1 As DirectoryServices.DirectoryEntry
    Friend WithEvents Cod As Label
    Friend WithEvents Codigo As NumericUpDown
    Friend WithEvents CadastrarRec As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents GroupBox3 As GroupBox
End Class
