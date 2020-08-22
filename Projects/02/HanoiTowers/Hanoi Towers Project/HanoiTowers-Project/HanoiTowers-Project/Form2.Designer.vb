<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form2))
        Me.lblvelocidad = New System.Windows.Forms.Label()
        Me.btnEliminar = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.CbAuxiliar = New System.Windows.Forms.ComboBox()
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.pictureBox4 = New System.Windows.Forms.PictureBox()
        Me.pictureBox3 = New System.Windows.Forms.PictureBox()
        Me.pictureBox2 = New System.Windows.Forms.PictureBox()
        Me.pictureBox1 = New System.Windows.Forms.PictureBox()
        Me.pictureBox6 = New System.Windows.Forms.PictureBox()
        Me.GroupBox1.SuspendLayout()
        CType(Me.TrackB, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pictureBox6, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblvelocidad
        '
        Me.lblvelocidad.Location = New System.Drawing.Point(473, 290)
        Me.lblvelocidad.Name = "lblvelocidad"
        Me.lblvelocidad.Size = New System.Drawing.Size(76, 23)
        Me.lblvelocidad.TabIndex = 71
        Me.lblvelocidad.Text = "Velocidad: 10"
        '
        'btnEliminar
        '
        Me.btnEliminar.BackColor = System.Drawing.Color.Black
        Me.btnEliminar.Font = New System.Drawing.Font("Cooper Black", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEliminar.ForeColor = System.Drawing.Color.White
        Me.btnEliminar.Location = New System.Drawing.Point(308, 336)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(136, 42)
        Me.btnEliminar.TabIndex = 69
        Me.btnEliminar.Text = "Eliminar"
        Me.btnEliminar.UseVisualStyleBackColor = False
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.GroupBox1.Controls.Add(Me.CbAuxiliar)
        Me.GroupBox1.Controls.Add(Me.CBorigen)
        Me.GroupBox1.Controls.Add(Me.CBDestino)
        Me.GroupBox1.Controls.Add(Me.cmbdisco)
        Me.GroupBox1.Location = New System.Drawing.Point(624, 330)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(214, 48)
        Me.GroupBox1.TabIndex = 68
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Origen - Destino - Auxiliar - Discos"
        '
        'CbAuxiliar
        '
        Me.CbAuxiliar.BackColor = System.Drawing.Color.RosyBrown
        Me.CbAuxiliar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CbAuxiliar.ForeColor = System.Drawing.SystemColors.WindowText
        Me.CbAuxiliar.Items.AddRange(New Object() {"A", "B", "C"})
        Me.CbAuxiliar.Location = New System.Drawing.Point(85, 16)
        Me.CbAuxiliar.Name = "CbAuxiliar"
        Me.CbAuxiliar.Size = New System.Drawing.Size(38, 21)
        Me.CbAuxiliar.TabIndex = 22
        '
        'CBorigen
        '
        Me.CBorigen.BackColor = System.Drawing.Color.RosyBrown
        Me.CBorigen.DisplayMember = "A"
        Me.CBorigen.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CBorigen.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.CBorigen.Items.AddRange(New Object() {"A", "B", "C"})
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
        Me.CBDestino.Items.AddRange(New Object() {"A", "B", "C"})
        Me.CBDestino.Location = New System.Drawing.Point(46, 16)
        Me.CBDestino.Name = "CBDestino"
        Me.CBDestino.Size = New System.Drawing.Size(38, 21)
        Me.CBDestino.TabIndex = 21
        '
        'cmbdisco
        '
        Me.cmbdisco.BackColor = System.Drawing.Color.RosyBrown
        Me.cmbdisco.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbdisco.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6", "7", "8", "9", "10"})
        Me.cmbdisco.Location = New System.Drawing.Point(136, 16)
        Me.cmbdisco.Name = "cmbdisco"
        Me.cmbdisco.Size = New System.Drawing.Size(40, 21)
        Me.cmbdisco.TabIndex = 24
        '
        'LblTorreCPalo
        '
        Me.LblTorreCPalo.BackColor = System.Drawing.Color.SaddleBrown
        Me.LblTorreCPalo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LblTorreCPalo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.LblTorreCPalo.Location = New System.Drawing.Point(379, 133)
        Me.LblTorreCPalo.Name = "LblTorreCPalo"
        Me.LblTorreCPalo.Size = New System.Drawing.Size(8, 144)
        Me.LblTorreCPalo.TabIndex = 67
        '
        'LblTorreBPalo
        '
        Me.LblTorreBPalo.BackColor = System.Drawing.Color.SaddleBrown
        Me.LblTorreBPalo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LblTorreBPalo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.LblTorreBPalo.Location = New System.Drawing.Point(236, 133)
        Me.LblTorreBPalo.Name = "LblTorreBPalo"
        Me.LblTorreBPalo.Size = New System.Drawing.Size(8, 144)
        Me.LblTorreBPalo.TabIndex = 66
        '
        'LblTorreAPalo
        '
        Me.LblTorreAPalo.BackColor = System.Drawing.Color.SaddleBrown
        Me.LblTorreAPalo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LblTorreAPalo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.LblTorreAPalo.Location = New System.Drawing.Point(90, 133)
        Me.LblTorreAPalo.Name = "LblTorreAPalo"
        Me.LblTorreAPalo.Size = New System.Drawing.Size(8, 144)
        Me.LblTorreAPalo.TabIndex = 65
        '
        'TrackB
        '
        Me.TrackB.AccessibleRole = System.Windows.Forms.AccessibleRole.None
        Me.TrackB.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TrackB.Cursor = System.Windows.Forms.Cursors.NoMoveVert
        Me.TrackB.LargeChange = 1
        Me.TrackB.Location = New System.Drawing.Point(486, 84)
        Me.TrackB.Maximum = 9
        Me.TrackB.Name = "TrackB"
        Me.TrackB.Orientation = System.Windows.Forms.Orientation.Vertical
        Me.TrackB.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.TrackB.Size = New System.Drawing.Size(45, 193)
        Me.TrackB.TabIndex = 64
        Me.TrackB.TickStyle = System.Windows.Forms.TickStyle.Both
        Me.TrackB.Value = 9
        '
        'label22
        '
        Me.label22.BackColor = System.Drawing.Color.Cyan
        Me.label22.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.label22.Location = New System.Drawing.Point(652, 283)
        Me.label22.Name = "label22"
        Me.label22.Size = New System.Drawing.Size(88, 20)
        Me.label22.TabIndex = 63
        Me.label22.Text = "Pasos Totales:"
        '
        'Txttotales
        '
        Me.Txttotales.BackColor = System.Drawing.Color.Cyan
        Me.Txttotales.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Txttotales.Location = New System.Drawing.Point(740, 283)
        Me.Txttotales.Name = "Txttotales"
        Me.Txttotales.Size = New System.Drawing.Size(80, 20)
        Me.Txttotales.TabIndex = 62
        Me.Txttotales.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'LblTorreC
        '
        Me.LblTorreC.BackColor = System.Drawing.Color.OrangeRed
        Me.LblTorreC.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LblTorreC.Location = New System.Drawing.Point(358, 84)
        Me.LblTorreC.Name = "LblTorreC"
        Me.LblTorreC.Size = New System.Drawing.Size(50, 16)
        Me.LblTorreC.TabIndex = 61
        Me.LblTorreC.Text = "Torre C"
        Me.LblTorreC.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LblTorreA
        '
        Me.LblTorreA.BackColor = System.Drawing.Color.OrangeRed
        Me.LblTorreA.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LblTorreA.Location = New System.Drawing.Point(68, 84)
        Me.LblTorreA.Name = "LblTorreA"
        Me.LblTorreA.Size = New System.Drawing.Size(50, 16)
        Me.LblTorreA.TabIndex = 60
        Me.LblTorreA.Text = "Torre A"
        Me.LblTorreA.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LblTorreb
        '
        Me.LblTorreb.BackColor = System.Drawing.Color.OrangeRed
        Me.LblTorreb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LblTorreb.ForeColor = System.Drawing.SystemColors.ControlText
        Me.LblTorreb.Location = New System.Drawing.Point(213, 84)
        Me.LblTorreb.Name = "LblTorreb"
        Me.LblTorreb.Size = New System.Drawing.Size(50, 16)
        Me.LblTorreb.TabIndex = 59
        Me.LblTorreb.Text = "Torre B"
        Me.LblTorreb.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(575, 55)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(200, 16)
        Me.Label2.TabIndex = 58
        Me.Label2.Text = "Pasos a seguir:"
        '
        'Txtdestinos
        '
        Me.Txtdestinos.BackColor = System.Drawing.Color.CornflowerBlue
        Me.Txtdestinos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Txtdestinos.Cursor = System.Windows.Forms.Cursors.Default
        Me.Txtdestinos.ForeColor = System.Drawing.SystemColors.InfoText
        Me.Txtdestinos.Location = New System.Drawing.Point(578, 84)
        Me.Txtdestinos.Multiline = True
        Me.Txtdestinos.Name = "Txtdestinos"
        Me.Txtdestinos.ReadOnly = True
        Me.Txtdestinos.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.Txtdestinos.Size = New System.Drawing.Size(288, 193)
        Me.Txtdestinos.TabIndex = 57
        Me.Txtdestinos.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'BtnInicio
        '
        Me.BtnInicio.BackColor = System.Drawing.Color.Black
        Me.BtnInicio.Font = New System.Drawing.Font("Cooper Black", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnInicio.ForeColor = System.Drawing.Color.White
        Me.BtnInicio.Location = New System.Drawing.Point(130, 336)
        Me.BtnInicio.Name = "BtnInicio"
        Me.BtnInicio.Size = New System.Drawing.Size(136, 42)
        Me.BtnInicio.TabIndex = 56
        Me.BtnInicio.Text = "Iniciar"
        Me.BtnInicio.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Lucida Handwriting", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(86, 3)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(646, 24)
        Me.Label1.TabIndex = 55
        Me.Label1.Text = "Torres de Hanoi - Proyecto #1 - Matemática Discreta II"
        '
        'pictureBox4
        '
        Me.pictureBox4.Image = CType(resources.GetObject("pictureBox4.Image"), System.Drawing.Image)
        Me.pictureBox4.Location = New System.Drawing.Point(794, -2)
        Me.pictureBox4.Name = "pictureBox4"
        Me.pictureBox4.Size = New System.Drawing.Size(30, 29)
        Me.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pictureBox4.TabIndex = 54
        Me.pictureBox4.TabStop = False
        '
        'pictureBox3
        '
        Me.pictureBox3.Image = CType(resources.GetObject("pictureBox3.Image"), System.Drawing.Image)
        Me.pictureBox3.Location = New System.Drawing.Point(821, -3)
        Me.pictureBox3.Name = "pictureBox3"
        Me.pictureBox3.Size = New System.Drawing.Size(30, 30)
        Me.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pictureBox3.TabIndex = 53
        Me.pictureBox3.TabStop = False
        '
        'pictureBox2
        '
        Me.pictureBox2.Image = CType(resources.GetObject("pictureBox2.Image"), System.Drawing.Image)
        Me.pictureBox2.Location = New System.Drawing.Point(-1, -3)
        Me.pictureBox2.Name = "pictureBox2"
        Me.pictureBox2.Size = New System.Drawing.Size(30, 30)
        Me.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pictureBox2.TabIndex = 52
        Me.pictureBox2.TabStop = False
        '
        'pictureBox1
        '
        Me.pictureBox1.Image = CType(resources.GetObject("pictureBox1.Image"), System.Drawing.Image)
        Me.pictureBox1.Location = New System.Drawing.Point(847, -3)
        Me.pictureBox1.Name = "pictureBox1"
        Me.pictureBox1.Size = New System.Drawing.Size(34, 30)
        Me.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pictureBox1.TabIndex = 51
        Me.pictureBox1.TabStop = False
        '
        'pictureBox6
        '
        Me.pictureBox6.Image = CType(resources.GetObject("pictureBox6.Image"), System.Drawing.Image)
        Me.pictureBox6.Location = New System.Drawing.Point(-1, 360)
        Me.pictureBox6.Name = "pictureBox6"
        Me.pictureBox6.Size = New System.Drawing.Size(34, 30)
        Me.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pictureBox6.TabIndex = 73
        Me.pictureBox6.TabStop = False
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(879, 390)
        Me.Controls.Add(Me.pictureBox6)
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
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.pictureBox4)
        Me.Controls.Add(Me.pictureBox3)
        Me.Controls.Add(Me.pictureBox2)
        Me.Controls.Add(Me.pictureBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Form2"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form2"
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.TrackB, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pictureBox6, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblvelocidad As Label
    Friend WithEvents btnEliminar As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents CbAuxiliar As ComboBox
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
    Friend WithEvents Label1 As Label
    Private WithEvents pictureBox4 As PictureBox
    Private WithEvents pictureBox3 As PictureBox
    Private WithEvents pictureBox2 As PictureBox
    Private WithEvents pictureBox1 As PictureBox
    Private WithEvents pictureBox6 As PictureBox
End Class
