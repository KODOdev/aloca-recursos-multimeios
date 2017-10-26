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
        Me.Cadastrar = New System.Windows.Forms.Button()
        Me.Solicitar = New System.Windows.Forms.Button()
        Me.Sair = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Cadastrar
        '
        Me.Cadastrar.Location = New System.Drawing.Point(12, 60)
        Me.Cadastrar.Name = "Cadastrar"
        Me.Cadastrar.Size = New System.Drawing.Size(276, 23)
        Me.Cadastrar.TabIndex = 0
        Me.Cadastrar.Text = "Cadastrar Recursos"
        Me.Cadastrar.UseVisualStyleBackColor = True
        '
        'Solicitar
        '
        Me.Solicitar.Location = New System.Drawing.Point(12, 98)
        Me.Solicitar.Name = "Solicitar"
        Me.Solicitar.Size = New System.Drawing.Size(276, 23)
        Me.Solicitar.TabIndex = 1
        Me.Solicitar.Text = "Solicitar Recursos"
        Me.Solicitar.UseVisualStyleBackColor = True
        '
        'Sair
        '
        Me.Sair.Location = New System.Drawing.Point(12, 139)
        Me.Sair.Name = "Sair"
        Me.Sair.Size = New System.Drawing.Size(276, 23)
        Me.Sair.TabIndex = 2
        Me.Sair.Text = "Sair"
        Me.Sair.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(65, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(167, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Alocação de Recursos Multimeios"
        '
        'FormMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(310, 180)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Sair)
        Me.Controls.Add(Me.Solicitar)
        Me.Controls.Add(Me.Cadastrar)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "FormMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ARM"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Cadastrar As Button
    Friend WithEvents Solicitar As Button
    Friend WithEvents Sair As Button
    Friend WithEvents Label1 As Label
End Class
