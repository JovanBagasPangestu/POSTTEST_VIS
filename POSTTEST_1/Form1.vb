Public Class Form1
	Dim totalIP As Double
	Dim jumlahSemester As Integer
	Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

	End Sub

	Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        totalIP = 0
        jumlahSemester = 0

        TextBox1.Text = ""
        TextBox2.Text = ""
        Label3.Text = ""
    End Sub

	Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

	End Sub

	Private Sub btnTambah_Click(sender As Object, e As EventArgs) Handles btnTambah.Click
        Dim ips As Double
        TextBox1.Text = TextBox1.Text.Replace(".", ",")

        If Double.TryParse(TextBox1.Text, ips) Then
            totalIP = totalIP + ips
            jumlahSemester = jumlahSemester + 1

            Dim ipk As Double = totalIP / jumlahSemester
            TextBox2.Text = ipk.ToString("0.00")

            If ipk >= 2.0 And ipk <= 2.75 Then
                Label3.Text = "Cukup"
            ElseIf ipk >= 2.76 And ipk <= 3.0 Then
                Label3.Text = "Memuaskan"
            ElseIf ipk >= 3.01 Then
                Label3.Text = "Sangat Memuaskan"
            Else
                Label3.Text = "-"
            End If

        Else
            MessageBox.Show("Input harus angka!")
        End If
    End Sub
End Class
