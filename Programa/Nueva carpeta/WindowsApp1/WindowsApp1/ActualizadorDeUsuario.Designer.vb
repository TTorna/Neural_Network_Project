<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ActualizadorDeUsuario
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
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TBNum = New System.Windows.Forms.TextBox()
        Me.BttRecuperar = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TxtApelRperar = New System.Windows.Forms.TextBox()
        Me.TxtNomRperar = New System.Windows.Forms.TextBox()
        Me.TxtMailRperar = New System.Windows.Forms.TextBox()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox2.BackgroundImage = Global.WindowsApp1.My.Resources.Resources.anterior__1_
        Me.PictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PictureBox2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox2.Location = New System.Drawing.Point(12, 2)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(41, 49)
        Me.PictureBox2.TabIndex = 37
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.BackgroundImage = Global.WindowsApp1.My.Resources.Resources.cerrar
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PictureBox1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox1.Location = New System.Drawing.Point(437, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(28, 27)
        Me.PictureBox1.TabIndex = 36
        Me.PictureBox1.TabStop = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Unispace", 26.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.SpringGreen
        Me.Label7.Location = New System.Drawing.Point(107, 24)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(270, 42)
        Me.Label7.TabIndex = 35
        Me.Label7.Text = "Recuperacion"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Unispace", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(23, 198)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(215, 15)
        Me.Label6.TabIndex = 34
        Me.Label6.Text = "Ingrese su numero celular:"
        '
        'TBNum
        '
        Me.TBNum.Location = New System.Drawing.Point(259, 198)
        Me.TBNum.Name = "TBNum"
        Me.TBNum.Size = New System.Drawing.Size(149, 20)
        Me.TBNum.TabIndex = 32
        Me.TBNum.Tag = ""
        '
        'BttRecuperar
        '
        Me.BttRecuperar.BackColor = System.Drawing.Color.White
        Me.BttRecuperar.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.25!)
        Me.BttRecuperar.Location = New System.Drawing.Point(130, 269)
        Me.BttRecuperar.Name = "BttRecuperar"
        Me.BttRecuperar.Size = New System.Drawing.Size(221, 37)
        Me.BttRecuperar.TabIndex = 33
        Me.BttRecuperar.Text = "Recuperar"
        Me.BttRecuperar.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Unispace", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(111, 124)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(127, 15)
        Me.Label3.TabIndex = 30
        Me.Label3.Text = "Ingrese nombre:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Unispace", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(127, 89)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(111, 15)
        Me.Label2.TabIndex = 29
        Me.Label2.Text = "Ingrese mail:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Unispace", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(95, 162)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(143, 15)
        Me.Label1.TabIndex = 28
        Me.Label1.Text = "Ingrese apellido:"
        '
        'TxtApelRperar
        '
        Me.TxtApelRperar.Location = New System.Drawing.Point(259, 162)
        Me.TxtApelRperar.Name = "TxtApelRperar"
        Me.TxtApelRperar.Size = New System.Drawing.Size(149, 20)
        Me.TxtApelRperar.TabIndex = 27
        Me.TxtApelRperar.Tag = ""
        '
        'TxtNomRperar
        '
        Me.TxtNomRperar.Location = New System.Drawing.Point(259, 124)
        Me.TxtNomRperar.Name = "TxtNomRperar"
        Me.TxtNomRperar.Size = New System.Drawing.Size(149, 20)
        Me.TxtNomRperar.TabIndex = 25
        Me.TxtNomRperar.Tag = ""
        '
        'TxtMailRperar
        '
        Me.TxtMailRperar.Location = New System.Drawing.Point(259, 89)
        Me.TxtMailRperar.Name = "TxtMailRperar"
        Me.TxtMailRperar.Size = New System.Drawing.Size(149, 20)
        Me.TxtMailRperar.TabIndex = 24
        Me.TxtMailRperar.Tag = ""
        '
        'ActualizadorDeUsuario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(477, 318)
        Me.ControlBox = False
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.TBNum)
        Me.Controls.Add(Me.BttRecuperar)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TxtApelRperar)
        Me.Controls.Add(Me.TxtNomRperar)
        Me.Controls.Add(Me.TxtMailRperar)
        Me.Name = "ActualizadorDeUsuario"
        Me.Text = "ActualizadorDeUsuario"
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents TBNum As TextBox
    Friend WithEvents BttRecuperar As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents TxtApelRperar As TextBox
    Friend WithEvents TxtNomRperar As TextBox
    Friend WithEvents TxtMailRperar As TextBox
End Class
