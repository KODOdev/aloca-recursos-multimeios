<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormMain
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormMain))
        Me.Sair = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Solicitar = New System.Windows.Forms.Button()
        Me.Cadastrar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Sair
        '
        Me.Sair.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Sair.Image = Global.GoldMiner_Tech_Solutions.My.Resources.Resources.msg_error
        Me.Sair.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Sair.Location = New System.Drawing.Point(79, 184)
        Me.Sair.Name = "Sair"
        Me.Sair.Size = New System.Drawing.Size(276, 31)
        Me.Sair.TabIndex = 2
        Me.Sair.Text = "Sair"
        Me.Sair.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Honeydew
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label1.Font = New System.Drawing.Font("Trebuchet MS", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.MenuText
        Me.Label1.Location = New System.Drawing.Point(60, 29)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(318, 29)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Alocação de Recursos Multimeios"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Solicitar
        '
        Me.Solicitar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Solicitar.Image = Global.GoldMiner_Tech_Solutions.My.Resources.Resources.overlay_share
        Me.Solicitar.ImageAlign = System.Drawing.ContentAlignment.BottomRight
        Me.Solicitar.Location = New System.Drawing.Point(79, 134)
        Me.Solicitar.Name = "Solicitar"
        Me.Solicitar.Size = New System.Drawing.Size(276, 33)
        Me.Solicitar.TabIndex = 1
        Me.Solicitar.Text = "Solicitar Recursos"
        Me.Solicitar.UseVisualStyleBackColor = True
        '
        'Cadastrar
        '
        Me.Cadastrar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cadastrar.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Cadastrar.Image = Global.GoldMiner_Tech_Solutions.My.Resources.Resources.registration
        Me.Cadastrar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Cadastrar.Location = New System.Drawing.Point(79, 85)
        Me.Cadastrar.Name = "Cadastrar"
        Me.Cadastrar.Size = New System.Drawing.Size(276, 34)
        Me.Cadastrar.TabIndex = 0
        Me.Cadastrar.Text = "Cadastrar Recursos"
        Me.Cadastrar.UseVisualStyleBackColor = True
        '
        'FormMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Silver
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.ClientSize = New System.Drawing.Size(431, 227)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Sair)
        Me.Controls.Add(Me.Solicitar)
        Me.Controls.Add(Me.Cadastrar)
        Me.ForeColor = System.Drawing.SystemColors.ControlText
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "FormMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ARM - Menu"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Cadastrar As Button
    Friend WithEvents Solicitar As Button
    Friend WithEvents Sair As Button
    Friend WithEvents Label1 As Label
End Class
