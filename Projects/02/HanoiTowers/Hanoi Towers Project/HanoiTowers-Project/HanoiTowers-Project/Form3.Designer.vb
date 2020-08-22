<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form3
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form3))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.pictureBox4 = New System.Windows.Forms.PictureBox()
        Me.pictureBox3 = New System.Windows.Forms.PictureBox()
        Me.pictureBox2 = New System.Windows.Forms.PictureBox()
        Me.pictureBox1 = New System.Windows.Forms.PictureBox()
        Me.pictureBox6 = New System.Windows.Forms.PictureBox()
        Me.lblvelocidad = New System.Windows.Forms.Label()
        Me.btnEliminar = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.CBorigen = New System.Windows.Forms.ComboBox()
        Me.CBDestino = New System.Windows.Forms.ComboBox()
        Me.cmbdisco = New System.Windows.Forms.ComboBox()
        Me.LblTorreCPalo = New System.Windows.Forms.Label()
        Me.LblTorreBPalo = New System.Windows.Forms.Label()
        Me.LblTorreAPalo = New System.Windows.Forms.Label()
        Me.TrackB = New System.Windows.Forms.TrackBar()
        Me.label22 = New System.Windows.Forms.Label()
        Me.Txttotales = New System.Windows.Forms.TextBox()
        Me.LblTorreC = New System.Windows.Forms.Label()
        Me.LblTorreA = New System.Windows.Forms.Label()
        Me.LblTorreb = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Txtdestinos = New System.Windows.Forms.TextBox()
        Me.BtnInicio = New System.Windows.Forms.Button()
        Me.LblTorreDPalo = New System.Windows.Forms.Label()
        Me.LblTorreD = New System.Windows.Forms.Label()
        Me.lblDisco5 = New System.Windows.Forms.Label()
        Me.lblDisco4 = New System.Windows.Forms.Label()
        Me.lblDisco3 = New System.Windows.Forms.Label()
        Me.lblDisco2 = New System.Windows.Forms.Label()
        Me.lblDisco1 = New System.Windows.Forms.Label()
        CType(Me.pictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pictureBox6, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.TrackB, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Lucida Handwriting", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(92, 6)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(646, 24)
        Me.Label1.TabIndex = 20
        Me.Label1.Text = "Torres de Hanoi - Proyecto #1 - Matemática Discreta II"
        '
        'pictureBox4
        '
        Me.pictureBox4.Image = CType(resources.GetObject("pictureBox4.Image"), System.Drawing.Image)
        Me.pictureBox4.Location = New System.Drawing.Point(794, 1)
        Me.pictureBox4.Name = "pictureBox4"
        Me.pictureBox4.Size = New System.Drawing.Size(30, 29)
        Me.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pictureBox4.TabIndex = 19
        Me.pictureBox4.TabStop = False
        '
        'pictureBox3
        '
        Me.pictureBox3.Image = CType(resources.GetObject("pictureBox3.Image"), System.Drawing.Image)
        Me.pictureBox3.Location = New System.Drawing.Point(821, 0)
        Me.pictureBox3.Name = "pictureBox3"
        Me.pictureBox3.Size = New System.Drawing.Size(30, 30)
        Me.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pictureBox3.TabIndex = 18
        Me.pictureBox3.TabStop = False
        '
        'pictureBox2
        '
        Me.pictureBox2.Image = CType(resources.GetObject("pictureBox2.Image"), System.Drawing.Image)
        Me.pictureBox2.Location = New System.Drawing.Point(1, 0)
        Me.pictureBox2.Name = "pictureBox2"
        Me.pictureBox2.Size = New System.Drawing.Size(30, 30)
        Me.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pictureBox2.TabIndex = 17
        Me.pictureBox2.TabStop = False
        '
        'pictureBox1
        '
        Me.pictureBox1.Image = CType(resources.GetObject("pictureBox1.Image"), System.Drawing.Image)
        Me.pictureBox1.Location = New System.Drawing.Point(847, 0)
        Me.pictureBox1.Name = "pictureBox1"
        Me.pictureBox1.Size = New System.Drawing.Size(34, 30)
        Me.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pictureBox1.TabIndex = 16
        Me.pictureBox1.TabStop = False
        '
        'pictureBox6
        '
        Me.pictureBox6.Image = CType(resources.GetObject("pictureBox6.Image"), System.Drawing.Image)
        Me.pictureBox6.Location = New System.Drawing.Point(1, 360)
        Me.pictureBox6.Name = "pictureBox6"
        Me.pictureBox6.Size = New System.Drawing.Size(34, 30)
        Me.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pictureBox6.TabIndex = 74
        Me.pictureBox6.TabStop = False
        '
        'lblvelocidad
        '
        Me.lblvelocidad.Location = New System.Drawing.Point(458, 287)
        Me.lblvelocidad.Name = "lblvelocidad"
        Me.lblvelocidad.Size = New System.Drawing.Size(76, 23)
        Me.lblvelocidad.TabIndex = 89
        Me.lblvelocidad.Text = "Velocidad: 10"
        '
        'btnEliminar
        '
        Me.btnEliminar.BackColor = System.Drawing.Color.Black
        Me.btnEliminar.Font = New System.Drawing.Font("Cooper Black", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEliminar.ForeColor = System.Drawing.Color.White
        Me.btnEliminar.Location = New System.Drawing.Point(293, 333)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(136, 42)
        Me.btnEliminar.TabIndex = 88
        Me.btnEliminar.Text = "Eliminar"
        Me.btnEliminar.UseVisualStyleBackColor = False
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.GroupBox1.Controls.Add(Me.CBorigen)
        Me.GroupBox1.Controls.Add(Me.CBDestino)
        Me.GroupBox1.Controls.Add(Me.cmbdisco)
        Me.GroupBox1.Location = New System.Drawing.Point(637, 327)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(168, 48)
        Me.GroupBox1.TabIndex = 87
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Origen   -   Destino   -  Discos"
        '
        'CBorigen
        '
        Me.CBorigen.BackColor = System.Drawing.Color.RosyBrown
        Me.CBorigen.DisplayMember = "A"
        Me.CBorigen.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CBorigen.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.CBorigen.Items.AddRange(New Object() {"A"})
        Me.CBorigen.Location = New System.Drawing.Point(8, 16)
        Me.CBorigen.Name = "CBorigen"
        Me.CBorigen.Size = New System.Drawing.Size(38, 21)
        Me.CBorigen.TabIndex = 20
        Me.CBorigen.Tag = ""
        '
        'CBDestino
        '
        Me.CBDestino.BackColor = System.Drawing.Color.RosyBrown
        Me.CBDestino.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CBDestino.Items.AddRange(New Object() {"B", "C", "D"})
        Me.CBDestino.Location = New System.Drawing.Point(61, 18)
        Me.CBDestino.Name = "CBDestino"
        Me.CBDestino.Size = New System.Drawing.Size(38, 21)
        Me.CBDestino.TabIndex = 21
        '
        'cmbdisco
        '
        Me.cmbdisco.BackColor = System.Drawing.Color.RosyBrown
        Me.cmbdisco.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbdisco.Items.AddRange(New Object() {"1", "2", "3", "4", "5"})
        Me.cmbdisco.Location = New System.Drawing.Point(114, 19)
        Me.cmbdisco.Name = "cmbdisco"
        Me.cmbdisco.Size = New System.Drawing.Size(40, 21)
        Me.cmbdisco.TabIndex = 24
        '
        'LblTorreCPalo
        '
        Me.LblTorreCPalo.BackColor = System.Drawing.Color.SaddleBrown
        Me.LblTorreCPalo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LblTorreCPalo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.LblTorreCPalo.Location = New System.Drawing.Point(269, 130)
        Me.LblTorreCPalo.Name = "LblTorreCPalo"
        Me.LblTorreCPalo.Size = New System.Drawing.Size(8, 144)
        Me.LblTorreCPalo.TabIndex = 86
        '
        'LblTorreBPalo
        '
        Me.LblTorreBPalo.BackColor = System.Drawing.Color.SaddleBrown
        Me.LblTorreBPalo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LblTorreBPalo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.LblTorreBPalo.Location = New System.Drawing.Point(160, 130)
        Me.LblTorreBPalo.Name = "LblTorreBPalo"
        Me.LblTorreBPalo.Size = New System.Drawing.Size(8, 144)
        Me.LblTorreBPalo.TabIndex = 85
        '
        'LblTorreAPalo
        '
        Me.LblTorreAPalo.BackColor = System.Drawing.Color.SaddleBrown
        Me.LblTorreAPalo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LblTorreAPalo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.LblTorreAPalo.Location = New System.Drawing.Point(53, 130)
        Me.LblTorreAPalo.Name = "LblTorreAPalo"
        Me.LblTorreAPalo.Size = New System.Drawing.Size(8, 144)
        Me.LblTorreAPalo.TabIndex = 84
        '
        'TrackB
        '
        Me.TrackB.AccessibleRole = System.Windows.Forms.AccessibleRole.None
        Me.TrackB.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TrackB.Cursor = System.Windows.Forms.Cursors.NoMoveVert
        Me.TrackB.Enabled = False
        Me.TrackB.LargeChange = 1
        Me.TrackB.Location = New System.Drawing.Point(471, 81)
        Me.TrackB.Maximum = 9
        Me.TrackB.Name = "TrackB"
        Me.TrackB.Orientation = System.Windows.Forms.Orientation.Vertical
        Me.TrackB.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.TrackB.Size = New System.Drawing.Size(45, 193)
        Me.TrackB.TabIndex = 83
        Me.TrackB.TickStyle = System.Windows.Forms.TickStyle.Both
        Me.TrackB.Value = 9
        '
        'label22
        '
        Me.label22.BackColor = System.Drawing.Color.Cyan
        Me.label22.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.label22.Location = New System.Drawing.Point(637, 280)
        Me.label22.Name = "label22"
        Me.label22.Size = New System.Drawing.Size(88, 20)
        Me.label22.TabIndex = 82
        Me.label22.Text = "Pasos Totales:"
        '
        'Txttotales
        '
        Me.Txttotales.BackColor = System.Drawing.Color.Cyan
        Me.Txttotales.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Txttotales.Location = New System.Drawing.Point(725, 280)
        Me.Txttotales.Name = "Txttotales"
        Me.Txttotales.Size = New System.Drawing.Size(80, 20)
        Me.Txttotales.TabIndex = 81
        Me.Txttotales.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'LblTorreC
        '
        Me.LblTorreC.BackColor = System.Drawing.Color.OrangeRed
        Me.LblTorreC.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LblTorreC.Location = New System.Drawing.Point(248, 81)
        Me.LblTorreC.Name = "LblTorreC"
        Me.LblTorreC.Size = New System.Drawing.Size(50, 16)
        Me.LblTorreC.TabIndex = 80
        Me.LblTorreC.Text = "Torre C"
        Me.LblTorreC.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LblTorreA
        '
        Me.LblTorreA.BackColor = System.Drawing.Color.OrangeRed
        Me.LblTorreA.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LblTorreA.Location = New System.Drawing.Point(35, 81)
        Me.LblTorreA.Name = "LblTorreA"
        Me.LblTorreA.Size = New System.Drawing.Size(50, 16)
        Me.LblTorreA.TabIndex = 79
        Me.LblTorreA.Text = "Torre A"
        Me.LblTorreA.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LblTorreb
        '
        Me.LblTorreb.BackColor = System.Drawing.Color.OrangeRed
        Me.LblTorreb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LblTorreb.ForeColor = System.Drawing.SystemColors.ControlText
        Me.LblTorreb.Location = New System.Drawing.Point(139, 81)
        Me.LblTorreb.Name = "LblTorreb"
        Me.LblTorreb.Size = New System.Drawing.Size(50, 16)
        Me.LblTorreb.TabIndex = 78
        Me.LblTorreb.Text = "Torre B"
        Me.LblTorreb.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(560, 52)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(200, 16)
        Me.Label2.TabIndex = 77
        Me.Label2.Text = "Pasos a seguir:"
        '
        'Txtdestinos
        '
        Me.Txtdestinos.BackColor = System.Drawing.Color.CornflowerBlue
        Me.Txtdestinos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Txtdestinos.Cursor = System.Windows.Forms.Cursors.Default
        Me.Txtdestinos.Enabled = False
        Me.Txtdestinos.ForeColor = System.Drawing.SystemColors.InfoText
        Me.Txtdestinos.Location = New System.Drawing.Point(563, 81)
        Me.Txtdestinos.Multiline = True
        Me.Txtdestinos.Name = "Txtdestinos"
        Me.Txtdestinos.ReadOnly = True
        Me.Txtdestinos.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.Txtdestinos.Size = New System.Drawing.Size(288, 193)
        Me.Txtdestinos.TabIndex = 76
        Me.Txtdestinos.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'BtnInicio
        '
        Me.BtnInicio.BackColor = System.Drawing.Color.Black
        Me.BtnInicio.Font = New System.Drawing.Font("Cooper Black", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnInicio.ForeColor = System.Drawing.Color.White
        Me.BtnInicio.Location = New System.Drawing.Point(115, 333)
        Me.BtnInicio.Name = "BtnInicio"
        Me.BtnInicio.Size = New System.Drawing.Size(136, 42)
        Me.BtnInicio.TabIndex = 75
        Me.BtnInicio.Text = "Iniciar"
        Me.BtnInicio.UseVisualStyleBackColor = False
        '
        'LblTorreDPalo
        '
        Me.LblTorreDPalo.BackColor = System.Drawing.Color.SaddleBrown
        Me.LblTorreDPalo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LblTorreDPalo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.LblTorreDPalo.Location = New System.Drawing.Point(374, 130)
        Me.LblTorreDPalo.Name = "LblTorreDPalo"
        Me.LblTorreDPalo.Size = New System.Drawing.Size(8, 144)
        Me.LblTorreDPalo.TabIndex = 91
        '
        'LblTorreD
        '
        Me.LblTorreD.BackColor = System.Drawing.Color.OrangeRed
        Me.LblTorreD.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LblTorreD.Location = New System.Drawing.Point(354, 81)
        Me.LblTorreD.Name = "LblTorreD"
        Me.LblTorreD.Size = New System.Drawing.Size(50, 16)
        Me.LblTorreD.TabIndex = 90
        Me.LblTorreD.Text = "Torre D"
        Me.LblTorreD.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblDisco5
        '
        Me.lblDisco5.BackColor = System.Drawing.Color.LightCoral
        Me.lblDisco5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblDisco5.Location = New System.Drawing.Point(12, 258)
        Me.lblDisco5.Name = "lblDisco5"
        Me.lblDisco5.Size = New System.Drawing.Size(95, 16)
        Me.lblDisco5.TabIndex = 92
        Me.lblDisco5.Text = "5"
        Me.lblDisco5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblDisco4
        '
        Me.lblDisco4.BackColor = System.Drawing.Color.Tomato
        Me.lblDisco4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblDisco4.Location = New System.Drawing.Point(21, 242)
        Me.lblDisco4.Name = "lblDisco4"
        Me.lblDisco4.Size = New System.Drawing.Size(77, 16)
        Me.lblDisco4.TabIndex = 93
        Me.lblDisco4.Text = "4"
        Me.lblDisco4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblDisco3
        '
        Me.lblDisco3.BackColor = System.Drawing.Color.LightSalmon
        Me.lblDisco3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblDisco3.Location = New System.Drawing.Point(35, 226)
        Me.lblDisco3.Name = "lblDisco3"
        Me.lblDisco3.Size = New System.Drawing.Size(50, 16)
        Me.lblDisco3.TabIndex = 94
        Me.lblDisco3.Text = "3"
        Me.lblDisco3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblDisco2
        '
        Me.lblDisco2.BackColor = System.Drawing.Color.Chocolate
        Me.lblDisco2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblDisco2.Location = New System.Drawing.Point(44, 208)
        Me.lblDisco2.Name = "lblDisco2"
        Me.lblDisco2.Size = New System.Drawing.Size(32, 18)
        Me.lblDisco2.TabIndex = 95
        Me.lblDisco2.Text = "2"
        Me.lblDisco2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblDisco1
        '
        Me.lblDisco1.BackColor = System.Drawing.Color.Tan
        Me.lblDisco1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblDisco1.Location = New System.Drawing.Point(53, 189)
        Me.lblDisco1.Name = "lblDisco1"
        Me.lblDisco1.Size = New System.Drawing.Size(10, 19)
        Me.lblDisco1.TabIndex = 96
        Me.lblDisco1.Text = "1"
        Me.lblDisco1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Form3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(879, 390)
        Me.Controls.Add(Me.lblDisco1)
        Me.Controls.Add(Me.lblDisco2)
        Me.Controls.Add(Me.lblDisco3)
        Me.Controls.Add(Me.lblDisco4)
        Me.Controls.Add(Me.lblDisco5)
        Me.Controls.Add(Me.LblTorreDPalo)
        Me.Controls.Add(Me.LblTorreD)
        Me.Controls.Add(Me.lblvelocidad)
        Me.Controls.Add(Me.btnEliminar)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.LblTorreCPalo)
        Me.Controls.Add(Me.LblTorreBPalo)
        Me.Controls.Add(Me.LblTorreAPalo)
        Me.Controls.Add(Me.TrackB)
        Me.Controls.Add(Me.label22)
        Me.Controls.Add(Me.Txttotales)
        Me.Controls.Add(Me.LblTorreC)
        Me.Controls.Add(Me.LblTorreA)
        Me.Controls.Add(Me.LblTorreb)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Txtdestinos)
        Me.Controls.Add(Me.BtnInicio)
        Me.Controls.Add(Me.pictureBox6)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.pictureBox4)
        Me.Controls.Add(Me.pictureBox3)
        Me.Controls.Add(Me.pictureBox2)
        Me.Controls.Add(Me.pictureBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Form3"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form3"
        CType(Me.pictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pictureBox6, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.TrackB, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Private WithEvents pictureBox4 As PictureBox
    Private WithEvents pictureBox3 As PictureBox
    Private WithEvents pictureBox2 As PictureBox
    Private WithEvents pictureBox1 As PictureBox
    Private WithEvents pictureBox6 As PictureBox
    Friend WithEvents lblvelocidad As Label
    Friend WithEvents btnEliminar As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents CBorigen As ComboBox
    Friend WithEvents CBDestino As ComboBox
    Friend WithEvents cmbdisco As ComboBox
    Friend WithEvents LblTorreCPalo As Label
    Friend WithEvents LblTorreBPalo As Label
    Friend WithEvents LblTorreAPalo As Label
    Friend WithEvents TrackB As TrackBar
    Friend WithEvents label22 As Label
    Friend WithEvents Txttotales As TextBox
    Friend WithEvents LblTorreC As Label
    Friend WithEvents LblTorreA As Label
    Friend WithEvents LblTorreb As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Txtdestinos As TextBox
    Friend WithEvents BtnInicio As Button
    Friend WithEvents LblTorreDPalo As Label
    Friend WithEvents LblTorreD As Label
    Friend WithEvents lblDisco5 As Label
    Friend WithEvents lblDisco4 As Label
    Friend WithEvents lblDisco3 As Label
    Friend WithEvents lblDisco2 As Label
    Friend WithEvents lblDisco1 As Label
End Class
