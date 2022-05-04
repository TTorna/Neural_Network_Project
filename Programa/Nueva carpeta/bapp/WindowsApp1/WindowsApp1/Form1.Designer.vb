<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.TxtMail = New System.Windows.Forms.TextBox()
        Me.TxtNom = New System.Windows.Forms.TextBox()
        Me.TxtCtñ = New System.Windows.Forms.TextBox()
        Me.TxtApel = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.BttSesion = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'TxtMail
        '
        Me.TxtMail.Location = New System.Drawing.Point(222, 89)
        Me.TxtMail.Name = "TxtMail"
        Me.TxtMail.Size = New System.Drawing.Size(149, 20)
        Me.TxtMail.TabIndex = 0
        '
        'TxtNom
        '
        Me.TxtNom.Location = New System.Drawing.Point(222, 127)
        Me.TxtNom.Name = "TxtNom"
        Me.TxtNom.Size = New System.Drawing.Size(149, 20)
        Me.TxtNom.TabIndex = 1
        '
        'TxtCtñ
        '
        Me.TxtCtñ.Location = New System.Drawing.Point(222, 204)
        Me.TxtCtñ.Name = "TxtCtñ"
        Me.TxtCtñ.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TxtCtñ.Size = New System.Drawing.Size(149, 20)
        Me.TxtCtñ.TabIndex = 2
        '
        'TxtApel
        '
        Me.TxtApel.Location = New System.Drawing.Point(222, 165)
        Me.TxtApel.Name = "TxtApel"
        Me.TxtApel.Size = New System.Drawing.Size(149, 20)
        Me.TxtApel.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("OCR A Extended", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.MediumSpringGreen
        Me.Label1.Location = New System.Drawing.Point(56, 168)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(161, 17)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Ingrese apellido:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("OCR A Extended", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.MediumSpringGreen
        Me.Label2.Location = New System.Drawing.Point(92, 92)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(125, 17)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Ingrese mail:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("OCR A Extended", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Red
        Me.Label3.Location = New System.Drawing.Point(74, 130)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(143, 17)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Ingrese nombre:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("OCR A Extended", 11.25!)
        Me.Label4.ForeColor = System.Drawing.Color.Red
        Me.Label4.Location = New System.Drawing.Point(38, 207)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(179, 17)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Ingrese contraseña:"
        '
        'LinkLabel1
        '
        Me.LinkLabel1.ActiveLinkColor = System.Drawing.Color.Red
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.BackColor = System.Drawing.Color.Transparent
        Me.LinkLabel1.Font = New System.Drawing.Font("OCR A Extended", 11.25!)
        Me.LinkLabel1.LinkColor = System.Drawing.Color.MediumSpringGreen
        Me.LinkLabel1.Location = New System.Drawing.Point(343, 248)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(44, 17)
        Me.LinkLabel1.TabIndex = 9
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "aquí"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("OCR A Extended", 9.25!)
        Me.Label6.ForeColor = System.Drawing.Color.MediumSpringGreen
        Me.Label6.Location = New System.Drawing.Point(53, 251)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(295, 13)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "En caso de no tener cuenta haz click"
        '
        'BttSesion
        '
        Me.BttSesion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BttSesion.Font = New System.Drawing.Font("OCR A Extended", 13.25!)
        Me.BttSesion.Location = New System.Drawing.Point(109, 305)
        Me.BttSesion.Name = "BttSesion"
        Me.BttSesion.Size = New System.Drawing.Size(221, 37)
        Me.BttSesion.TabIndex = 11
        Me.BttSesion.Text = "Iniciar sesion"
        Me.BttSesion.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("OCR A Extended", 25.25!)
        Me.Label7.ForeColor = System.Drawing.Color.Lime
        Me.Label7.Location = New System.Drawing.Point(152, 29)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(120, 35)
        Me.Label7.TabIndex = 19
        Me.Label7.Text = "Login"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackgroundImage = Global.WindowsApp1.My.Resources.Resources.grafico_bursatil_o_forex_concepto_grafico_73426_204
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(437, 379)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.BttSesion)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.LinkLabel1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TxtApel)
        Me.Controls.Add(Me.TxtCtñ)
        Me.Controls.Add(Me.TxtNom)
        Me.Controls.Add(Me.TxtMail)
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TxtMail As TextBox
    Friend WithEvents TxtNom As TextBox
    Friend WithEvents TxtCtñ As TextBox
    Friend WithEvents TxtApel As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents LinkLabel1 As LinkLabel
    Friend WithEvents Label6 As Label
    Friend WithEvents BttSesion As Button
    Friend WithEvents Label7 As Label
End Class
