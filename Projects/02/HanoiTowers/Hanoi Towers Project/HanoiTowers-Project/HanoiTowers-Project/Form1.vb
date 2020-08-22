Public Class Form1
    Private Sub pictureBox4_Click(sender As Object, e As EventArgs) Handles pictureBox4.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub pictureBox3_Click(sender As Object, e As EventArgs) Handles pictureBox3.Click
        Me.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub pictureBox1_Click(sender As Object, e As EventArgs) Handles pictureBox1.Click
        Application.Exit()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim Form2 As New Form2
        Form2.Show()
        Me.Hide()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim Form3 As New Form3
        Form3.Show()
        Me.Hide()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim Form4 As New Form4
        Form4.Show()
        Me.Hide()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim toolTip1 As New ToolTip()

        toolTip1.AutoPopDelay = 5000
        toolTip1.InitialDelay = 1000
        toolTip1.ReshowDelay = 500

        toolTip1.ShowAlways = True

        toolTip1.SetToolTip(Me.pictureBox2, "Información")
        toolTip1.SetToolTip(Me.pictureBox4, "Minimizar")
        toolTip1.SetToolTip(Me.pictureBox3, "Maximizar")
        toolTip1.SetToolTip(Me.pictureBox1, "Salir")
        toolTip1.SetToolTip(Me.Label1, "Torres de Hanoi - Proyecto #1 - Matemática Discreta II")
        toolTip1.SetToolTip(Me.PictureBox5, "Imagen")
        toolTip1.SetToolTip(Me.Button1, "Solución con 3 parales")
        toolTip1.SetToolTip(Me.Button2, "Solución con 4 parales")
        toolTip1.SetToolTip(Me.Button3, "Fórmulas recursivas")
    End Sub

    Private Sub pictureBox2_Click(sender As Object, e As EventArgs) Handles pictureBox2.Click
        MessageBox.Show("Presione el botón de la opción que desee" & vbNewLine & vbNewLine & "Opción 1: Simulación de las Torres de Hanoi con 3 parales" & vbNewLine & vbNewLine & "Opción 2: Solucíón simple de las Torres de Hanoi con 4 parales" & vbNewLine & vbNewLine & "Opción 3: Estudiar fórmulas recursivas para cada problema", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub
End Class
