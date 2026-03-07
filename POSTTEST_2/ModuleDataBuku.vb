Module ModuleDataBuku
	Public daftarBuku(99, 1) As String
	Public jumlahBuku As Integer = 0

    Public Sub TambahBuku(ByVal judul As String, ByVal genre As String)
        daftarBuku(jumlahBuku, 0) = judul
        daftarBuku(jumlahBuku, 1) = genre
        jumlahBuku += 1
    End Sub

    Public Function CariBuku(ByVal judul As String) As Integer
        For i As Integer = 0 To jumlahBuku - 1
            If daftarBuku(i, 0) = judul Then
                Return i
            End If
        Next

        Return -1
    End Function
End Module
