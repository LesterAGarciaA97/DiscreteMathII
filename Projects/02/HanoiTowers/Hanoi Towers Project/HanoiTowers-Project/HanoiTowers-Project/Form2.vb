Public Class Form2
    Inherits System.Windows.Forms.Form
#Region "Contadores"
    Const miArriba As Integer = 52
    Const miAbajo As Integer = 228
    Public mshcontador As Integer
    Const miTorreA As Integer = 32
    Const miTorreb As Integer = 120
    Const miTorrec As Integer = 224
    Const papelera As Integer = 328
    Const mshAaltura_Disco As Int16 = 12
    Const mshAnchura_Disco_P As Int16 = 8
    Const msh_incremento_anchura_disco As Int16 = 4
    Private mshcreados As Int16 = False
    Private msdiscos_solicitados As String = 0
    Const mshNum_max_disco As Int16 = 10
    Private moLbl2(10) As System.Windows.Forms.Label
    Private mb_Ya_esta_movimiento As Boolean = False
    Public Structure StrTorre
        Public Discopos As Int16
        Public Torre As Int16
        Public tamaño As Int16
        Public semovio As Boolean
    End Structure
    Private creado As Boolean = False
    Private StrTorreA(10) As StrTorre
    Const velocidades As Integer = 100
    Private mshdisco_papelera As Int16 = 0
#End Region
#Region "Resolver torres"
    Overloads Function mover_hanoi(ByVal n As Integer, ByVal torreini As Integer, ByVal torrefin As Integer)
        If mb_Ya_esta_movimiento = True Then
            mshcontador = mshcontador + 1
            Txtdestinos.Text = Txtdestinos.Text & "Paso: " & mshcontador & " -> " & " Disco: " & n & " desde: " & CadenaTorre(torreini) & " va a: " & CadenaTorre(torrefin) & Chr(13) & Chr(10)
            StrTorreA(n).Torre = torreini

            mover_torres(n, torreini, torrefin)
            System.Windows.Forms.Application.DoEvents()
        End If
    End Function
    Overloads Function mover_hanoi(ByVal n As Integer,
    ByVal torreini As Integer, ByVal torrefin As Integer,
    ByVal auxiliar As Integer)
        If mb_Ya_esta_movimiento = True Then
            If n > 1 Then
                mover_hanoi(n - 1, torreini, auxiliar, torrefin)
                mover_hanoi(n, torreini, auxiliar)
                mover_hanoi(n - 1, torrefin, torreini, auxiliar)
            Else
                mover_hanoi(n, torreini, auxiliar)
            End If
        End If
    End Function
#End Region
#Region "funciones de auxiliares"
    Sub lento(ByVal retraso As Integer)

        Dim lshi, e As Integer
        For lshi = 0 To retraso
            For e = 0 To retraso
            Next
        Next
    End Sub
    Function puedo_empezar() As Boolean
        puedo_empezar = False
        Select Case CBorigen.Text
            Case CBDestino.Text
                puedo_empezar = True
            Case CbAuxiliar.Text
                puedo_empezar = True
            Case Else
                If CBDestino.Text = CbAuxiliar.Text Then puedo_empezar = True
        End Select

    End Function
    Function se_equivoco() As Boolean
        se_equivoco = True
        If (IsNumeric(msdiscos_solicitados) And msdiscos_solicitados <> "") Then
            If (msdiscos_solicitados > 0 And msdiscos_solicitados <= mshNum_max_disco) Then
                se_equivoco = False
            End If
        End If
    End Function
    Function Torre_letras(ByVal letra As Char) As Int16
        If letra = "A" Or letra = "a" Then Torre_letras = miTorreA
        If letra = "B" Or letra = "b" Then Torre_letras = miTorreb
        If letra = "C" Or letra = "c" Then Torre_letras = miTorrec

    End Function
    Sub colocarsubtitulos()
        Dim puntomedio As Int16
        Dim altura_palos As Int16
        puntomedio = (LblTorreA.Size.Width / 2) - msh_incremento_anchura_disco
        altura_palos = miAbajo - miArriba
        LblTorreA.Location = New System.Drawing.Point(miTorreA - puntomedio, miAbajo + mshAaltura_Disco)
        LblTorreb.Location = New System.Drawing.Point(miTorreb - puntomedio, miAbajo + mshAaltura_Disco)
        LblTorreC.Location = New System.Drawing.Point(miTorrec - puntomedio, miAbajo + mshAaltura_Disco)
        LblTorreAPalo.Location = New System.Drawing.Point(miTorreA, miArriba + mshAaltura_Disco)
        LblTorreAPalo.Size = New System.Drawing.Size(mshAnchura_Disco_P, altura_palos)
        LblTorreBPalo.Location = New System.Drawing.Point(miTorreb, miArriba + mshAaltura_Disco)
        LblTorreBPalo.Size = New System.Drawing.Size(mshAnchura_Disco_P, altura_palos)
        LblTorreCPalo.Location = New System.Drawing.Point(miTorrec, miArriba + mshAaltura_Disco)
        LblTorreCPalo.Size = New System.Drawing.Size(mshAnchura_Disco_P, altura_palos)

    End Sub
    Function CadenaTorre(ByVal valortorre As String) As String
        If valortorre = miTorreA Then
            CadenaTorre = " Torre A "
        End If
        If valortorre = miTorreb Then
            CadenaTorre = " Torre B "
        End If
        If valortorre = miTorrec Then
            CadenaTorre = " Torre C "
        End If
    End Function
    Function calcular_altura(ByVal numdisco As Int16, ByVal torrefinal As Int16) As Integer
        Dim lshi As Int16
        Dim cuantos_discos As Int16 = -1
        For lshi = 1 To mshNum_max_disco
            If StrTorreA(lshi).Torre = torrefinal Then
                cuantos_discos = cuantos_discos + 1
            End If

        Next

        StrTorreA(numdisco).Torre = torrefinal

        Return cuantos_discos
    End Function
    Sub desactico()
        btnEliminar.Enabled = False
        BtnInicio.Enabled = False
    End Sub
    Sub activo()
        BtnInicio.Enabled = True
        btnEliminar.Enabled = True
    End Sub
#End Region
#Region "creacion y eliminacion de los label"
    Sub eliminar_odjetos(ByVal lshi As Int16)
        For lshi = 1 To mshNum_max_disco
            StrTorreA(lshi).Torre = 0
            If msdiscos_solicitados >= lshi Then

                moLbl2(lshi).Dispose()
                moLbl2(lshi) = Nothing
            End If

        Next
    End Sub
    Sub crear_objetos(ByVal TorreOriguen As Int16)

        Dim disco, anchura, coordx, coordy As Int16
        Dim lshi As Int16

        Dim coorinicial As Int16

        If se_equivoco() = False Then

            disco = msdiscos_solicitados
            coorinicial = 228 - (disco * 12)
            Txttotales.Text = 2 ^ disco - 1
            For lshi = disco To 1 Step -1

                moLbl2(lshi) = New System.Windows.Forms.Label()
                moLbl2(lshi).BackColor = System.Drawing.Color.Red
                coordy = coorinicial + (lshi * mshAaltura_Disco)
                anchura = mshAnchura_Disco_P + (msh_incremento_anchura_disco * lshi)
                coordx = TorreOriguen - ((msh_incremento_anchura_disco * lshi) / 2)
                moLbl2(lshi).Location = New System.Drawing.Point(coordx, coordy)
                moLbl2(lshi).BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
                moLbl2(lshi).FlatStyle = System.Windows.Forms.FlatStyle.Flat
                moLbl2(lshi).TextAlign = System.Drawing.ContentAlignment.MiddleCenter
                moLbl2(lshi).AllowDrop = True
                moLbl2(lshi).Size = New System.Drawing.Size(anchura, mshAaltura_Disco)
                moLbl2(lshi).TabIndex = lshi + 1 + 6
                moLbl2(lshi).Text = lshi

                StrTorreA(lshi).Discopos = lshi
                StrTorreA(lshi).Torre = TorreOriguen
                StrTorreA(lshi).tamaño = anchura

                Controls.AddRange(New System.Windows.Forms.Control() {moLbl2(lshi)})
                moLbl2(lshi).BringToFront()
            Next

        End If
        mshcreados = True

    End Sub
#End Region
#Region "movimientos"
    Function mover_torres(ByVal Numdisco As Int16, ByVal torrecomienzo As Int16, ByVal torrefin As Int16, Optional ByVal no_calcular_altura As Boolean = False) As Int16
        If mb_Ya_esta_movimiento = True Then
            Dim e As Int16
            Dim sign As Int16
            Dim anchura As Int16
            Dim velo As Int16 = 10 - TrackB.Value
            anchura = ((4 * Numdisco) / 2)
            Dim tope As Int16 = torrefin - anchura
            mover_arriba(Numdisco)

            If torrecomienzo > torrefin Then
                sign = -1
            Else
                sign = 1
            End If
            Do While tope <> moLbl2(Numdisco).Location.X And mb_Ya_esta_movimiento = True

                moLbl2(Numdisco).Location = New System.Drawing.Point(moLbl2(Numdisco).Location.X + sign, moLbl2(Numdisco).Location.Y)
                lento(velo * velocidades)
            Loop

            mover_abajo(Numdisco, torrefin, no_calcular_altura)
            mover_torres = torrefin
        End If
    End Function
    Sub mover_arriba(ByVal numdisco As Int16)

        Dim e As Int16
        Dim velo As Int16 = 10 - TrackB.Value

        Do While miArriba <> moLbl2(numdisco).Location.Y And mb_Ya_esta_movimiento = True

            moLbl2(numdisco).Location = New System.Drawing.Point(moLbl2(numdisco).Location.X, moLbl2(numdisco).Location.Y - 1)
            lento(velo * velocidades)
        Loop
    End Sub
    Sub mover_abajo(ByVal numdisco As Int16, ByVal torrefinal As Int16, ByVal no_calcular_altura As Boolean)
        calcular_altura(numdisco, torrefinal)
        Dim e As Int16
        Dim velo As Int16 = 10 - TrackB.Value
        Dim tope As Int16 = miAbajo - (calcular_altura(numdisco, torrefinal) * mshAaltura_Disco)
        Dim llegar As Int16 = moLbl2(numdisco).Location.Y + (calcular_altura(numdisco, torrefinal) * mshAaltura_Disco)

        If no_calcular_altura = True Then tope = miAbajo
        Do While tope <> moLbl2(numdisco).Location.Y And mb_Ya_esta_movimiento = True

            moLbl2(numdisco).Location = New System.Drawing.Point(moLbl2(numdisco).Location.X, moLbl2(numdisco).Location.Y + 1)

            lento(velo * velocidades)

        Loop

    End Sub
#End Region
#Region "Botones"
    Private Sub BtnInicio_Click(sender As Object, e As EventArgs) Handles BtnInicio.Click
        mb_Ya_esta_movimiento = True

        mshdisco_papelera = 0

        BtnInicio.Text = "Iniciar"
        colocarsubtitulos()
        mshcontador = 0
        Txtdestinos.Text = ""

        If se_equivoco() = False Then
            eliminar_odjetos(msdiscos_solicitados)
            msdiscos_solicitados = 0
        End If

        msdiscos_solicitados = cmbdisco.Text

        crear_objetos(Torre_letras(CBorigen.Text))

        If puedo_empezar() = False Then
            mover_hanoi(msdiscos_solicitados, Torre_letras(CBorigen.Text), Torre_letras(CbAuxiliar.Text), Torre_letras(CBDestino.Text))

        Else
            MsgBox("Destino,origen y auxiliar no pueden coincidir. Cambialos")
        End If

        mb_Ya_esta_movimiento = False
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        mb_Ya_esta_movimiento = True

        mshcontador = 0
        Txtdestinos.Text = ""
        eliminar_odjetos(msdiscos_solicitados)
        msdiscos_solicitados = 0
        mb_Ya_esta_movimiento = False
    End Sub
#End Region
    Private Sub pictureBox6_Click(sender As Object, e As EventArgs) Handles pictureBox6.Click
        Dim Form1 As New Form1
        Form1.Show()
        Me.Dispose()
    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim toolTip1 As New ToolTip()

        toolTip1.AutoPopDelay = 5000
        toolTip1.InitialDelay = 1000
        toolTip1.ReshowDelay = 500

        toolTip1.ShowAlways = True

        toolTip1.SetToolTip(Me.pictureBox2, "Información")
        toolTip1.SetToolTip(Me.pictureBox4, "Minimizar")
        toolTip1.SetToolTip(Me.pictureBox3, "Maximizar")
        toolTip1.SetToolTip(Me.pictureBox1, "Salir")
        toolTip1.SetToolTip(Me.pictureBox6, "Regresar")
        toolTip1.SetToolTip(Me.Label1, "Torres de Hanoi - Proyecto #1 - Matemática Discreta II")
        toolTip1.SetToolTip(Me.LblTorreA, "Torre A")
        toolTip1.SetToolTip(Me.LblTorreb, "Torre B")
        toolTip1.SetToolTip(Me.LblTorreC, "Torre C")
        toolTip1.SetToolTip(Me.LblTorreAPalo, "Paral A")
        toolTip1.SetToolTip(Me.LblTorreBPalo, "Paral B")
        toolTip1.SetToolTip(Me.LblTorreCPalo, "Paral C")
        toolTip1.SetToolTip(Me.BtnInicio, "Iniciar")
        toolTip1.SetToolTip(Me.btnEliminar, "Eliminar")
        toolTip1.SetToolTip(Me.Txtdestinos, "Pasos a seguir")
        toolTip1.SetToolTip(Me.Txttotales, "Total se movimientos")
        toolTip1.SetToolTip(Me.TrackB, "Velocidad")
        toolTip1.SetToolTip(Me.CBorigen, "Origen")
        toolTip1.SetToolTip(Me.CBDestino, "Destino")
        toolTip1.SetToolTip(Me.CbAuxiliar, "Auxiliar")
        toolTip1.SetToolTip(Me.cmbdisco, "Discos")

        CBorigen.SelectedIndex = 0
        CBDestino.SelectedIndex = 1
        CbAuxiliar.SelectedIndex = 2
        cmbdisco.SelectedIndex = 1
    End Sub

    Private Sub TrackB_Scroll(sender As Object, e As EventArgs) Handles TrackB.Scroll
        lblvelocidad.Text = "Velocidad: " & (TrackB.Value + 1)
    End Sub

    Private Sub pictureBox1_Click(sender As Object, e As EventArgs) Handles pictureBox1.Click
        mb_Ya_esta_movimiento = False
        mshcontador = 0
        Txtdestinos.Text = ""
        eliminar_odjetos(msdiscos_solicitados)
        msdiscos_solicitados = 0
        Application.Exit()
    End Sub

    Private Sub pictureBox2_Click(sender As Object, e As EventArgs) Handles pictureBox2.Click
        MessageBox.Show("Para iniciar la simualación presione en el botón 'Iniciar'" & vbNewLine & vbNewLine & "Para iniciar una nueva simulacíón con otras configuraciones, presione en 'Eliminar' y luego en 'Iniciar'", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub pictureBox4_Click(sender As Object, e As EventArgs) Handles pictureBox4.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub pictureBox3_Click(sender As Object, e As EventArgs) Handles pictureBox3.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub
End Class