<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Tdesc = New System.Windows.Forms.TextBox()
        Me.Tmarc = New System.Windows.Forms.TextBox()
        Me.Tano = New System.Windows.Forms.TextBox()
        Me.Tmodelo = New System.Windows.Forms.TextBox()
        Me.Tcor = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Tcategoria = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TextBox7 = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.dispbox = New System.Windows.Forms.ComboBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(32, 51)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(55, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Descricao"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(47, 77)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(37, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Marca"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(61, 102)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(26, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Ano"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(61, 128)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(23, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Cor"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(35, 150)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(52, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Categoria"
        '
        'Tdesc
        '
        Me.Tdesc.Location = New System.Drawing.Point(93, 44)
        Me.Tdesc.Name = "Tdesc"
        Me.Tdesc.Size = New System.Drawing.Size(353, 20)
        Me.Tdesc.TabIndex = 5
        '
        'Tmarc
        '
        Me.Tmarc.Location = New System.Drawing.Point(93, 70)
        Me.Tmarc.Name = "Tmarc"
        Me.Tmarc.Size = New System.Drawing.Size(158, 20)
        Me.Tmarc.TabIndex = 6
        '
        'Tano
        '
        Me.Tano.Location = New System.Drawing.Point(93, 95)
        Me.Tano.MaxLength = 4
        Me.Tano.Name = "Tano"
        Me.Tano.Size = New System.Drawing.Size(71, 20)
        Me.Tano.TabIndex = 7
        '
        'Tmodelo
        '
        Me.Tmodelo.Location = New System.Drawing.Point(257, 96)
        Me.Tmodelo.MaxLength = 4
        Me.Tmodelo.Name = "Tmodelo"
        Me.Tmodelo.Size = New System.Drawing.Size(80, 20)
        Me.Tmodelo.TabIndex = 8
        '
        'Tcor
        '
        Me.Tcor.Location = New System.Drawing.Point(93, 121)
        Me.Tcor.Name = "Tcor"
        Me.Tcor.Size = New System.Drawing.Size(100, 20)
        Me.Tcor.TabIndex = 9
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(209, 103)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(42, 13)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "Modelo"
        '
        'Tcategoria
        '
        Me.Tcategoria.Location = New System.Drawing.Point(93, 147)
        Me.Tcategoria.Name = "Tcategoria"
        Me.Tcategoria.Size = New System.Drawing.Size(158, 20)
        Me.Tcategoria.TabIndex = 10
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(44, 27)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(40, 13)
        Me.Label7.TabIndex = 12
        Me.Label7.Text = "Código"
        '
        'TextBox7
        '
        Me.TextBox7.Enabled = False
        Me.TextBox7.Location = New System.Drawing.Point(93, 20)
        Me.TextBox7.Name = "TextBox7"
        Me.TextBox7.Size = New System.Drawing.Size(100, 20)
        Me.TextBox7.TabIndex = 13
        Me.TextBox7.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(137, 206)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(100, 33)
        Me.Button1.TabIndex = 12
        Me.Button1.Text = "Salvar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(257, 206)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(100, 33)
        Me.Button2.TabIndex = 13
        Me.Button2.Text = "Cancelar"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(35, 176)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(58, 13)
        Me.Label8.TabIndex = 16
        Me.Label8.Text = "Disponível"
        '
        'dispbox
        '
        Me.dispbox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.dispbox.FormattingEnabled = True
        Me.dispbox.Items.AddRange(New Object() {"SIM", "NAO"})
        Me.dispbox.Location = New System.Drawing.Point(93, 173)
        Me.dispbox.Name = "dispbox"
        Me.dispbox.Size = New System.Drawing.Size(121, 21)
        Me.dispbox.TabIndex = 11
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(498, 251)
        Me.Controls.Add(Me.dispbox)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.TextBox7)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Tcategoria)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Tcor)
        Me.Controls.Add(Me.Tmodelo)
        Me.Controls.Add(Me.Tano)
        Me.Controls.Add(Me.Tmarc)
        Me.Controls.Add(Me.Tdesc)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form2"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cadastro de Carro"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Tdesc As System.Windows.Forms.TextBox
    Friend WithEvents Tmarc As System.Windows.Forms.TextBox
    Friend WithEvents Tano As System.Windows.Forms.TextBox
    Friend WithEvents Tmodelo As System.Windows.Forms.TextBox
    Friend WithEvents Tcor As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Tcategoria As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents TextBox7 As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents dispbox As System.Windows.Forms.ComboBox
End Class
