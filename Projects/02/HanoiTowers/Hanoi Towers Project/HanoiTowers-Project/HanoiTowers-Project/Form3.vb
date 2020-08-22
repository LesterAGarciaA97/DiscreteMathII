Public Class Form3
    Private Sub pictureBox6_Click(sender As Object, e As EventArgs) Handles pictureBox6.Click
        Dim Form1 As New Form1
        Form1.Show()
        Me.Dispose()
    End Sub

    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
        toolTip1.SetToolTip(Me.LblTorreD, "Torre D")
        toolTip1.SetToolTip(Me.LblTorreAPalo, "Paral A")
        toolTip1.SetToolTip(Me.LblTorreBPalo, "Paral B")
        toolTip1.SetToolTip(Me.LblTorreCPalo, "Paral C")
        toolTip1.SetToolTip(Me.LblTorreDPalo, "Paral D")
        toolTip1.SetToolTip(Me.BtnInicio, "Iniciar")
        toolTip1.SetToolTip(Me.btnEliminar, "Eliminar")
        toolTip1.SetToolTip(Me.Txtdestinos, "Pasos a seguir")
        toolTip1.SetToolTip(Me.Txttotales, "Total se movimientos")
        toolTip1.SetToolTip(Me.TrackB, "Velocidad")
        toolTip1.SetToolTip(Me.CBorigen, "Origen")
        toolTip1.SetToolTip(Me.CBDestino, "Destino")
        toolTip1.SetToolTip(Me.cmbdisco, "Discos")
    End Sub

    Private Sub BtnInicio_Click(sender As Object, e As EventArgs) Handles BtnInicio.Click
        If CBorigen.SelectedIndex = 0 And CBDestino.SelectedIndex = 0 And cmbdisco.SelectedIndex = 0 Then
            lblDisco1.Location = New Point(160, 258)
            lblDisco2.Hide()
            lblDisco3.Hide()
            lblDisco4.Hide()
            lblDisco5.Hide()
            Txttotales.Text = 1
            If CBorigen.SelectedIndex = 0 And CBDestino.SelectedIndex = 1 And cmbdisco.SelectedIndex = 0 Then
                lblDisco1.Location = New Point(269, 258)
                lblDisco2.Hide()
                lblDisco3.Hide()
                lblDisco4.Hide()
                lblDisco5.Hide()
                Txttotales.Text = 1
                If CBorigen.SelectedIndex = 0 And CBDestino.SelectedIndex = 2 And cmbdisco.SelectedIndex = 0 Then
                    lblDisco1.Location = New Point(374, 258)
                    lblDisco2.Hide()
                    lblDisco3.Hide()
                    lblDisco4.Hide()
                    lblDisco5.Hide()
                    Txttotales.Text = 1
                End If
            End If
        End If
        If CBorigen.SelectedIndex = 0 And CBDestino.SelectedIndex = 0 And cmbdisco.SelectedIndex = 1 Then
            lblDisco1.Location = New Point(160, 237)
            lblDisco2.Location = New Point(148, 258)
            lblDisco3.Hide()
            lblDisco4.Hide()
            lblDisco5.Hide()
            Txttotales.Text = 3
            If CBorigen.SelectedIndex = 0 And CBDestino.SelectedIndex = 1 And cmbdisco.SelectedIndex = 1 Then
                lblDisco1.Location = New Point(269, 237)
                lblDisco2.Location = New Point(257, 258)
                lblDisco3.Hide()
                lblDisco4.Hide()
                lblDisco5.Hide()
                Txttotales.Text = 3
                If CBorigen.SelectedIndex = 0 And CBDestino.SelectedIndex = 2 And cmbdisco.SelectedIndex = 1 Then
                    lblDisco1.Location = New Point(374, 237)
                    lblDisco2.Location = New Point(363, 258)
                    lblDisco3.Hide()
                    lblDisco4.Hide()
                    lblDisco5.Hide()
                    Txttotales.Text = 3
                End If
            End If
        End If
        If CBorigen.SelectedIndex = 0 And CBDestino.SelectedIndex = 0 And cmbdisco.SelectedIndex = 2 Then
            lblDisco1.Location = New Point(160, 223)
            lblDisco2.Location = New Point(148, 242)
            lblDisco3.Location = New Point(139, 258)
            lblDisco4.Hide()
            lblDisco5.Hide()
            Txttotales.Text = 5
            If CBorigen.SelectedIndex = 0 And CBDestino.SelectedIndex = 1 And cmbdisco.SelectedIndex = 2 Then
                lblDisco1.Location = New Point(269, 223)
                lblDisco2.Location = New Point(257, 242)
                lblDisco3.Location = New Point(248, 258)
                lblDisco4.Hide()
                lblDisco5.Hide()
                Txttotales.Text = 5
                If CBorigen.SelectedIndex = 0 And CBDestino.SelectedIndex = 2 And cmbdisco.SelectedIndex = 2 Then
                    lblDisco1.Location = New Point(372, 223)
                    lblDisco2.Location = New Point(363, 242)
                    lblDisco3.Location = New Point(354, 258)
                    lblDisco4.Hide()
                    lblDisco5.Hide()
                    Txttotales.Text = 5
                End If
            End If
        End If
        If CBorigen.SelectedIndex = 0 And CBDestino.SelectedIndex = 0 And cmbdisco.SelectedIndex = 3 Then
            lblDisco1.Location = New Point(160, 206)
            lblDisco2.Location = New Point(148, 225)
            lblDisco3.Location = New Point(139, 243)
            lblDisco4.Location = New Point(125, 258)
            lblDisco5.Hide()
            Txttotales.Text = 9
            If CBorigen.SelectedIndex = 0 And CBDestino.SelectedIndex = 1 And cmbdisco.SelectedIndex = 3 Then
                lblDisco1.Location = New Point(269, 206)
                lblDisco2.Location = New Point(257, 225)
                lblDisco3.Location = New Point(248, 243)
                lblDisco4.Location = New Point(232, 258)
                lblDisco5.Hide()
                Txttotales.Text = 9
                If CBorigen.SelectedIndex = 0 And CBDestino.SelectedIndex = 2 And cmbdisco.SelectedIndex = 3 Then
                    lblDisco1.Location = New Point(374, 205)
                    lblDisco2.Location = New Point(363, 224)
                    lblDisco3.Location = New Point(354, 242)
                    lblDisco4.Location = New Point(340, 258)
                    lblDisco5.Hide()
                    Txttotales.Text = 9
                End If
            End If
        End If
        If CBorigen.SelectedIndex = 0 And CBDestino.SelectedIndex = 0 And cmbdisco.SelectedIndex = 4 Then
            lblDisco1.Location = New Point(158, 189)
            lblDisco2.Location = New Point(148, 208)
            lblDisco3.Location = New Point(139, 226)
            lblDisco4.Location = New Point(124, 242)
            lblDisco5.Location = New Point(115, 258)
            Txttotales.Text = 17
            If CBorigen.SelectedIndex = 0 And CBDestino.SelectedIndex = 1 And cmbdisco.SelectedIndex = 4 Then
                lblDisco1.Location = New Point(267, 189)
                lblDisco2.Location = New Point(257, 208)
                lblDisco3.Location = New Point(248, 226)
                lblDisco4.Location = New Point(236, 242)
                lblDisco5.Location = New Point(227, 258)
                Txttotales.Text = 17
                If CBorigen.SelectedIndex = 0 And CBDestino.SelectedIndex = 2 And cmbdisco.SelectedIndex = 4 Then
                    lblDisco1.Location = New Point(374, 189)
                    lblDisco2.Location = New Point(363, 208)
                    lblDisco3.Location = New Point(354, 226)
                    lblDisco4.Location = New Point(343, 242)
                    lblDisco5.Location = New Point(334, 258)
                    Txttotales.Text = 17
                End If
            End If
        End If
    End Sub

    Private Sub pictureBox2_Click(sender As Object, e As EventArgs) Handles pictureBox2.Click
        MessageBox.Show("Para iniciar la simualación presione en el botón 'Iniciar'" & vbNewLine & vbNewLine & "Para iniciar una nueva simulacíón con otras configuraciones, presione en 'Eliminar' y luego en 'Iniciar'", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub pictureBox4_Click(sender As Object, e As EventArgs) Handles pictureBox4.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub pictureBox3_Click(sender As Object, e As EventArgs) Handles pictureBox3.Click
        Me.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub pictureBox1_Click(sender As Object, e As EventArgs) Handles pictureBox1.Click
        Application.Exit()
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        CBorigen.SelectedIndex = -1
        CBDestino.SelectedIndex = -1
        cmbdisco.SelectedIndex = -1
        Txttotales.Clear()
        lblDisco1.Location = New Point(53, 189)
        lblDisco2.Location = New Point(44, 208)
        lblDisco3.Location = New Point(35, 226)
        lblDisco4.Location = New Point(21, 242)
        lblDisco5.Location = New Point(12, 258)
    End Sub
End Class