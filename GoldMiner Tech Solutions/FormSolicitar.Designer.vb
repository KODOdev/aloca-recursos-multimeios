<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormSolicitar
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormSolicitar))
        Me.LabelDadosPessoais = New System.Windows.Forms.Label()
        Me.GroupBoxDadosPessoais = New System.Windows.Forms.GroupBox()
        Me.TelefoneBox = New System.Windows.Forms.TextBox()
        Me.Sala = New System.Windows.Forms.ComboBox()
        Me.TextBoxMatricula = New System.Windows.Forms.TextBox()
        Me.TextBoxNome = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.LabelNome = New System.Windows.Forms.Label()
        Me.LabelMatricula = New System.Windows.Forms.Label()
        Me.CheckBoxListaDeEspera = New System.Windows.Forms.CheckBox()
        Me.Label = New System.Windows.Forms.Label()
        Me.ButtonFinalizarSolicitacao = New System.Windows.Forms.Button()
        Me.RecursosImpressos = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Codigo = New System.Windows.Forms.NumericUpDown()
        Me.Cod = New System.Windows.Forms.Label()
        Me.GroupBoxDadosPessoais.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.Codigo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LabelDadosPessoais
        '
        Me.LabelDadosPessoais.AutoSize = True
        Me.LabelDadosPessoais.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelDadosPessoais.Location = New System.Drawing.Point(69, 16)
        Me.LabelDadosPessoais.Name = "LabelDadosPessoais"
        Me.LabelDadosPessoais.Size = New System.Drawing.Size(224, 22)
        Me.LabelDadosPessoais.TabIndex = 1
        Me.LabelDadosPessoais.Text = "Dados pessoais do professor"
        '
        'GroupBoxDadosPessoais
        '
        Me.GroupBoxDadosPessoais.BackColor = System.Drawing.Color.Silver
        Me.GroupBoxDadosPessoais.Controls.Add(Me.TelefoneBox)
        Me.GroupBoxDadosPessoais.Controls.Add(Me.Sala)
        Me.GroupBoxDadosPessoais.Controls.Add(Me.TextBoxMatricula)
        Me.GroupBoxDadosPessoais.Controls.Add(Me.TextBoxNome)
        Me.GroupBoxDadosPessoais.Controls.Add(Me.Label2)
        Me.GroupBoxDadosPessoais.Controls.Add(Me.LabelDadosPessoais)
        Me.GroupBoxDadosPessoais.Controls.Add(Me.Label1)
        Me.GroupBoxDadosPessoais.Controls.Add(Me.LabelNome)
        Me.GroupBoxDadosPessoais.Controls.Add(Me.LabelMatricula)
        Me.GroupBoxDadosPessoais.Location = New System.Drawing.Point(12, 97)
        Me.GroupBoxDadosPessoais.Name = "GroupBoxDadosPessoais"
        Me.GroupBoxDadosPessoais.Size = New System.Drawing.Size(357, 130)
        Me.GroupBoxDadosPessoais.TabIndex = 2
        Me.GroupBoxDadosPessoais.TabStop = False
        '
        'TelefoneBox
        '
        Me.TelefoneBox.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.TelefoneBox.Location = New System.Drawing.Point(205, 72)
        Me.TelefoneBox.MaxLength = 9
        Me.TelefoneBox.Name = "TelefoneBox"
        Me.TelefoneBox.Size = New System.Drawing.Size(140, 20)
        Me.TelefoneBox.TabIndex = 11
        '
        'Sala
        '
        Me.Sala.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Sala.FormattingEnabled = True
        Me.Sala.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15"})
        Me.Sala.Location = New System.Drawing.Point(162, 100)
        Me.Sala.Name = "Sala"
        Me.Sala.Size = New System.Drawing.Size(183, 21)
        Me.Sala.TabIndex = 10
        '
        'TextBoxMatricula
        '
        Me.TextBoxMatricula.Location = New System.Drawing.Point(63, 70)
        Me.TextBoxMatricula.MaxLength = 4
        Me.TextBoxMatricula.Name = "TextBoxMatricula"
        Me.TextBoxMatricula.Size = New System.Drawing.Size(73, 20)
        Me.TextBoxMatricula.TabIndex = 5
        '
        'TextBoxNome
        '
        Me.TextBoxNome.Location = New System.Drawing.Point(64, 46)
        Me.TextBoxNome.MaxLength = 120
        Me.TextBoxNome.Name = "TextBoxNome"
        Me.TextBoxNome.Size = New System.Drawing.Size(281, 20)
        Me.TextBoxNome.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 103)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(150, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Sala de instalação do recurso:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(147, 74)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(52, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Telefone:"
        '
        'LabelNome
        '
        Me.LabelNome.AutoSize = True
        Me.LabelNome.Location = New System.Drawing.Point(6, 49)
        Me.LabelNome.Name = "LabelNome"
        Me.LabelNome.Size = New System.Drawing.Size(38, 13)
        Me.LabelNome.TabIndex = 1
        Me.LabelNome.Text = "Nome:"
        '
        'LabelMatricula
        '
        Me.LabelMatricula.AutoSize = True
        Me.LabelMatricula.Location = New System.Drawing.Point(6, 73)
        Me.LabelMatricula.Name = "LabelMatricula"
        Me.LabelMatricula.Size = New System.Drawing.Size(53, 13)
        Me.LabelMatricula.TabIndex = 0
        Me.LabelMatricula.Text = "Matricula:"
        '
        'CheckBoxListaDeEspera
        '
        Me.CheckBoxListaDeEspera.AutoSize = True
        Me.CheckBoxListaDeEspera.Location = New System.Drawing.Point(13, 233)
        Me.CheckBoxListaDeEspera.Name = "CheckBoxListaDeEspera"
        Me.CheckBoxListaDeEspera.Size = New System.Drawing.Size(345, 17)
        Me.CheckBoxListaDeEspera.TabIndex = 3
        Me.CheckBoxListaDeEspera.Text = "Desejo entrar na lista de espera, caso o recurso esteja indisponível."
        Me.CheckBoxListaDeEspera.UseVisualStyleBackColor = True
        '
        'Label
        '
        Me.Label.AutoSize = True
        Me.Label.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label.Location = New System.Drawing.Point(68, 6)
        Me.Label.Name = "Label"
        Me.Label.Size = New System.Drawing.Size(255, 22)
        Me.Label.TabIndex = 4
        Me.Label.Text = "Ficha de solicitação de recursos"
        '
        'ButtonFinalizarSolicitacao
        '
        Me.ButtonFinalizarSolicitacao.Image = Global.GoldMiner_Tech_Solutions.My.Resources.Resources.check
        Me.ButtonFinalizarSolicitacao.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ButtonFinalizarSolicitacao.Location = New System.Drawing.Point(13, 256)
        Me.ButtonFinalizarSolicitacao.Name = "ButtonFinalizarSolicitacao"
        Me.ButtonFinalizarSolicitacao.Size = New System.Drawing.Size(357, 24)
        Me.ButtonFinalizarSolicitacao.TabIndex = 5
        Me.ButtonFinalizarSolicitacao.Text = "Finalizar Solicitação"
        Me.ButtonFinalizarSolicitacao.UseVisualStyleBackColor = True
        '
        'RecursosImpressos
        '
        Me.RecursosImpressos.Image = Global.GoldMiner_Tech_Solutions.My.Resources.Resources.magnifying_glass_4
        Me.RecursosImpressos.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.RecursosImpressos.Location = New System.Drawing.Point(85, 31)
        Me.RecursosImpressos.Name = "RecursosImpressos"
        Me.RecursosImpressos.Size = New System.Drawing.Size(220, 23)
        Me.RecursosImpressos.TabIndex = 10
        Me.RecursosImpressos.Text = "Visualizar recursos cadastrados"
        Me.RecursosImpressos.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Silver
        Me.GroupBox1.Controls.Add(Me.Codigo)
        Me.GroupBox1.Controls.Add(Me.Cod)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 59)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(357, 41)
        Me.GroupBox1.TabIndex = 11
        Me.GroupBox1.TabStop = False
        '
        'Codigo
        '
        Me.Codigo.Location = New System.Drawing.Point(191, 15)
        Me.Codigo.Maximum = New Decimal(New Integer() {9999, 0, 0, 0})
        Me.Codigo.Name = "Codigo"
        Me.Codigo.Size = New System.Drawing.Size(120, 20)
        Me.Codigo.TabIndex = 13
        '
        'Cod
        '
        Me.Cod.AutoSize = True
        Me.Cod.Location = New System.Drawing.Point(40, 17)
        Me.Cod.Name = "Cod"
        Me.Cod.Size = New System.Drawing.Size(145, 13)
        Me.Cod.TabIndex = 12
        Me.Cod.Text = "Informe o código do recurso: "
        '
        'FormSolicitar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Silver
        Me.ClientSize = New System.Drawing.Size(386, 288)
        Me.Controls.Add(Me.RecursosImpressos)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.ButtonFinalizarSolicitacao)
        Me.Controls.Add(Me.Label)
        Me.Controls.Add(Me.CheckBoxListaDeEspera)
        Me.Controls.Add(Me.GroupBoxDadosPessoais)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "FormSolicitar"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Solicitar Recurso"
        Me.GroupBoxDadosPessoais.ResumeLayout(False)
        Me.GroupBoxDadosPessoais.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.Codigo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LabelDadosPessoais As Label
    Friend WithEvents GroupBoxDadosPessoais As GroupBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents LabelNome As Label
    Friend WithEvents LabelMatricula As Label
    Friend WithEvents CheckBoxListaDeEspera As CheckBox
    Friend WithEvents Label As Label
    Friend WithEvents TextBoxNome As TextBox
    Friend WithEvents ButtonFinalizarSolicitacao As Button
    Friend WithEvents RecursosImpressos As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Codigo As NumericUpDown
    Friend WithEvents Cod As Label
    Friend WithEvents TextBoxMatricula As TextBox
    Friend WithEvents Sala As ComboBox
    Friend WithEvents TelefoneBox As TextBox
End Class
