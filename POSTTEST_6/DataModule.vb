Imports MySqlConnector

Module DataModule

    ' READ + JOIN 
    Public Function GetAllBookmark() As DataTable
        Dim dt As New DataTable()

        Try
            Dim query As String = "
                SELECT b.id, b.nama_website, b.url, 
                       k.nama_kategori, b.catatan
                FROM bookmarks b
                LEFT JOIN kategori k ON b.kategori_id = k.id
                ORDER BY b.id DESC"

            Using conn As MySqlConnection = GetConnection()
                Using da As New MySqlDataAdapter(query, conn)
                    da.Fill(dt)
                End Using
            End Using

        Catch ex As Exception
            MessageBox.Show("Gagal tampil: " & ex.Message)
        End Try

        Return dt
    End Function

    ' SEARCH + JOIN
    Public Function SearchBookmark(keyword As String) As DataTable
        Dim dt As New DataTable()

        Try
            Dim query As String = "
                SELECT b.id, b.nama_website, b.url, 
                       k.nama_kategori, b.catatan
                FROM bookmarks b
                LEFT JOIN kategori k ON b.kategori_id = k.id
                WHERE b.nama_website LIKE @kw OR k.nama_kategori LIKE @kw
                ORDER BY b.id DESC"

            Using conn As MySqlConnection = GetConnection()
                Using da As New MySqlDataAdapter(query, conn)
                    da.SelectCommand.Parameters.AddWithValue("@kw", "%" & keyword & "%")
                    da.Fill(dt)
                End Using
            End Using

        Catch ex As Exception
            MessageBox.Show("Gagal search: " & ex.Message)
        End Try

        Return dt
    End Function

    ' GET BY ID (UNTUK EDIT)
    Public Function GetBookmarkById(id As Integer) As DataTable
        Dim dt As New DataTable()

        Try
            Dim query As String = "SELECT * FROM bookmarks WHERE id=@id"

            Using conn As MySqlConnection = GetConnection()
                Using da As New MySqlDataAdapter(query, conn)
                    da.SelectCommand.Parameters.AddWithValue("@id", id)
                    da.Fill(dt)
                End Using
            End Using

        Catch ex As Exception
            MessageBox.Show("Gagal ambil data: " & ex.Message)
        End Try

        Return dt
    End Function

    ' INSERT
    Public Function SimpanBookmark(nama As String, url As String, kategori_id As Integer, catatan As String) As Boolean
        Try
            Dim query As String = "
                INSERT INTO bookmarks (nama_website, url, kategori_id, catatan)
                VALUES (@nama, @url, @kat, @cat)"

            Using conn As MySqlConnection = GetConnection()
                conn.Open()
                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@nama", nama)
                    cmd.Parameters.AddWithValue("@url", url)
                    cmd.Parameters.AddWithValue("@kat", kategori_id)
                    cmd.Parameters.AddWithValue("@cat", catatan)
                    cmd.ExecuteNonQuery()
                End Using
            End Using

            Return True

        Catch ex As Exception
            MessageBox.Show("Gagal simpan: " & ex.Message)
            Return False
        End Try
    End Function


    ' UPDATE
    Public Function UbahBookmark(id As Integer, nama As String, url As String, kategori_id As Integer, catatan As String) As Boolean
        Try
            Dim query As String = "
                UPDATE bookmarks SET 
                nama_website=@nama, 
                url=@url, 
                kategori_id=@kat, 
                catatan=@cat
                WHERE id=@id"

            Using conn As MySqlConnection = GetConnection()
                conn.Open()
                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@id", id)
                    cmd.Parameters.AddWithValue("@nama", nama)
                    cmd.Parameters.AddWithValue("@url", url)
                    cmd.Parameters.AddWithValue("@kat", kategori_id)
                    cmd.Parameters.AddWithValue("@cat", catatan)
                    cmd.ExecuteNonQuery()
                End Using
            End Using

            Return True

        Catch ex As Exception
            MessageBox.Show("Gagal update: " & ex.Message)
            Return False
        End Try
    End Function


    ' DELETE
    Public Function HapusBookmark(id As Integer) As Boolean
        Try
            Dim query As String = "DELETE FROM bookmarks WHERE id=@id"

            Using conn As MySqlConnection = GetConnection()
                conn.Open()
                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@id", id)
                    cmd.ExecuteNonQuery()
                End Using
            End Using

            Return True

        Catch ex As Exception
            MessageBox.Show("Gagal hapus: " & ex.Message)
            Return False
        End Try
    End Function

    ' GET KATEGORI 
    Public Function GetAllKategori() As DataTable
        Dim dt As New DataTable()

        Try
            Dim query As String = "SELECT * FROM kategori"

            Using conn As MySqlConnection = GetConnection()
                Using da As New MySqlDataAdapter(query, conn)
                    da.Fill(dt)
                End Using
            End Using

        Catch ex As Exception
            MessageBox.Show("Gagal ambil kategori: " & ex.Message)
        End Try

        Return dt
    End Function

End Module