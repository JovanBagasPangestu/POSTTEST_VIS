Public Class Form1
	Sub TampilBuku()
		lstBuku.Items.Clear()

		For i As Integer = 0 To jumlahBuku - 1
			lstBuku.Items.Add(daftarBuku(i, 0) & " (" & daftarBuku(i, 1) & ")")
		Next
	End Sub

	Private Sub btnTambah_Click(sender As Object, e As EventArgs) Handles btnTambah.Click
		Dim judul As String = txtJudul.Text
		Dim genre As String = txtGenre.Text

		TambahBuku(judul, genre)

		TampilBuku()

		txtJudul.Clear()
		txtGenre.Clear()
	End Sub

	Private Sub btnHapus_Click(sender As Object, e As EventArgs) Handles btnHapus.Click
		Dim posisi As Integer

		posisi = CariBuku(txtHapus.Text)
		If posisi <> -1 Then
			For i As Integer = posisi To jumlahBuku - 2
				daftarBuku(i, 0) = daftarBuku(i + 1, 0)
				daftarBuku(i, 1) = daftarBuku(i + 1, 1)
			Next
			jumlahBuku -= 1
			TampilBuku()
		Else
			MessageBox.Show("Buku tidak ditemukan")
		End If
	End Sub

	Private Sub lstBuku_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstBuku.SelectedIndexChanged

	End Sub
End Class
