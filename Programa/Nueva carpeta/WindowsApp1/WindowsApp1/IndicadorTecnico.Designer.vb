<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class IndicadorTecnico
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.CBBanderines = New System.Windows.Forms.CheckBox()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.CheckBox2 = New System.Windows.Forms.CheckBox()
        Me.CheckBox3 = New System.Windows.Forms.CheckBox()
        Me.CBBanderin = New System.Windows.Forms.ComboBox()
        Me.CBCanales = New System.Windows.Forms.ComboBox()
        Me.CBMACD = New System.Windows.Forms.ComboBox()
        Me.CBFibo = New System.Windows.Forms.ComboBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Unispace", 21.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.SpringGreen
        Me.Label1.Location = New System.Drawing.Point(197, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(213, 35)
        Me.Label1.TabIndex = 27
        Me.Label1.Text = "Indicadores"
        '
        'CBBanderines
        '
        Me.CBBanderines.AutoSize = True
        Me.CBBanderines.BackColor = System.Drawing.Color.Transparent
        Me.CBBanderines.Font = New System.Drawing.Font("Unispace", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CBBanderines.ForeColor = System.Drawing.Color.White
        Me.CBBanderines.Location = New System.Drawing.Point(61, 114)
        Me.CBBanderines.Name = "CBBanderines"
        Me.CBBanderines.Size = New System.Drawing.Size(106, 19)
        Me.CBBanderines.TabIndex = 28
        Me.CBBanderines.Text = "Banderines"
        Me.CBBanderines.UseVisualStyleBackColor = False
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.BackColor = System.Drawing.Color.Transparent
        Me.CheckBox1.Font = New System.Drawing.Font("Unispace", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBox1.ForeColor = System.Drawing.Color.White
        Me.CheckBox1.Location = New System.Drawing.Point(190, 114)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(82, 19)
        Me.CheckBox1.TabIndex = 29
        Me.CheckBox1.Text = "Canales"
        Me.CheckBox1.UseVisualStyleBackColor = False
        '
        'CheckBox2
        '
        Me.CheckBox2.AutoSize = True
        Me.CheckBox2.BackColor = System.Drawing.Color.Transparent
        Me.CheckBox2.Font = New System.Drawing.Font("Unispace", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBox2.ForeColor = System.Drawing.Color.White
        Me.CheckBox2.Location = New System.Drawing.Point(321, 114)
        Me.CheckBox2.Name = "CheckBox2"
        Me.CheckBox2.Size = New System.Drawing.Size(58, 19)
        Me.CheckBox2.TabIndex = 30
        Me.CheckBox2.Text = "MACD"
        Me.CheckBox2.UseVisualStyleBackColor = False
        '
        'CheckBox3
        '
        Me.CheckBox3.AutoSize = True
        Me.CheckBox3.BackColor = System.Drawing.Color.Transparent
        Me.CheckBox3.Font = New System.Drawing.Font("Unispace", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBox3.ForeColor = System.Drawing.Color.White
        Me.CheckBox3.Location = New System.Drawing.Point(447, 114)
        Me.CheckBox3.Name = "CheckBox3"
        Me.CheckBox3.Size = New System.Drawing.Size(106, 19)
        Me.CheckBox3.TabIndex = 31
        Me.CheckBox3.Text = "Fibbonacci"
        Me.CheckBox3.UseVisualStyleBackColor = False
        '
        'CBBanderin
        '
        Me.CBBanderin.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CBBanderin.Enabled = False
        Me.CBBanderin.FormattingEnabled = True
        Me.CBBanderin.Items.AddRange(New Object() {"Alcista", "No hay", "Bajista"})
        Me.CBBanderin.Location = New System.Drawing.Point(61, 139)
        Me.CBBanderin.Name = "CBBanderin"
        Me.CBBanderin.Size = New System.Drawing.Size(104, 21)
        Me.CBBanderin.TabIndex = 36
        '
        'CBCanales
        '
        Me.CBCanales.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CBCanales.Enabled = False
        Me.CBCanales.FormattingEnabled = True
        Me.CBCanales.Items.AddRange(New Object() {"Alcista", "Lateral", "No hay", "Bajista"})
        Me.CBCanales.Location = New System.Drawing.Point(190, 139)
        Me.CBCanales.Name = "CBCanales"
        Me.CBCanales.Size = New System.Drawing.Size(104, 21)
        Me.CBCanales.TabIndex = 37
        '
        'CBMACD
        '
        Me.CBMACD.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CBMACD.Enabled = False
        Me.CBMACD.FormattingEnabled = True
        Me.CBMACD.Items.AddRange(New Object() {"Alcista", "No hay", "Bajista"})
        Me.CBMACD.Location = New System.Drawing.Point(321, 139)
        Me.CBMACD.Name = "CBMACD"
        Me.CBMACD.Size = New System.Drawing.Size(104, 21)
        Me.CBMACD.TabIndex = 38
        '
        'CBFibo
        '
        Me.CBFibo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CBFibo.Enabled = False
        Me.CBFibo.FormattingEnabled = True
        Me.CBFibo.Items.AddRange(New Object() {"Alcista", "No hay", "bajista"})
        Me.CBFibo.Location = New System.Drawing.Point(447, 139)
        Me.CBFibo.Name = "CBFibo"
        Me.CBFibo.Size = New System.Drawing.Size(104, 21)
        Me.CBFibo.TabIndex = 39
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Unispace", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(103, 187)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(414, 35)
        Me.Button1.TabIndex = 40
        Me.Button1.Text = "Calcular"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.BackgroundImage = Global.WindowsApp1.My.Resources.Resources.cerrar
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PictureBox1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox1.Location = New System.Drawing.Point(548, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(28, 27)
        Me.PictureBox1.TabIndex = 41
        Me.PictureBox1.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox2.BackgroundImage = Global.WindowsApp1.My.Resources.Resources.anterior__1_
        Me.PictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PictureBox2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox2.Location = New System.Drawing.Point(12, 1)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(41, 49)
        Me.PictureBox2.TabIndex = 42
        Me.PictureBox2.TabStop = False
        '
        'IndicadorTecnico
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(588, 234)
        Me.ControlBox = False
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.CBFibo)
        Me.Controls.Add(Me.CBMACD)
        Me.Controls.Add(Me.CBCanales)
        Me.Controls.Add(Me.CBBanderin)
        Me.Controls.Add(Me.CheckBox3)
        Me.Controls.Add(Me.CheckBox2)
        Me.Controls.Add(Me.CheckBox1)
        Me.Controls.Add(Me.CBBanderines)
        Me.Controls.Add(Me.Label1)
        Me.Name = "IndicadorTecnico"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "IndicadorTecnico"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents CBBanderines As CheckBox
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents CheckBox2 As CheckBox
    Friend WithEvents CheckBox3 As CheckBox
    Friend WithEvents CBBanderin As ComboBox
    Friend WithEvents CBCanales As ComboBox
    Friend WithEvents CBMACD As ComboBox
    Friend WithEvents CBFibo As ComboBox
    Friend WithEvents Button1 As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
End Class
