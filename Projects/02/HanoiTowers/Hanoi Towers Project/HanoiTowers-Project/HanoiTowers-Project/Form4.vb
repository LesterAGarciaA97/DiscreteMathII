Public Class Form4
    Private Sub pictureBox6_Click(sender As Object, e As EventArgs) Handles pictureBox6.Click
        Dim Form1 As New Form1
        Form1.Show()
        Me.Dispose()
    End Sub

    Private Sub Form4_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
        toolTip1.SetToolTip(Me.ListBox1, "Fórmula decursiva para tres parales")
        toolTip1.SetToolTip(Me.ListBox2, "Fórmula decursiva para cuatro parales")
    End Sub

    Private Sub pictureBox2_Click(sender As Object, e As EventArgs) Handles pictureBox2.Click
        MessageBox.Show("Aquí puede observar las dos fórmulas recursivas, tanto para tres parales como para 4", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
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
End Class
