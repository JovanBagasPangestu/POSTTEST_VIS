Public Class Form1

    ' KOSONGKAN FORM
    Private Sub Kosong()
        txtCari.Clear()
        dgvData.ClearSelection()
    End Sub

    ' TAMPIL DATA (READ)
    Private Sub TampilData()
        dgvData.DataSource = GetAllBookmark()
    End Sub

    ' FORM LOAD
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Text = "Pengelolaan Data Bookmark Website"

        TampilData()
        Kosong()
    End Sub

    ' TOMBOL TAMBAH
    Private Sub btnTambah_Click(sender As Object, e As EventArgs) Handles btnTambah.Click
        Dim f2 As New Form2()
        f2.Mode = "TAMBAH"
        f2.ShowDialog()

        TampilData()
        Kosong()
    End Sub

    ' TOMBOL EDIT
    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click

        If dgvData.Rows.Count = 0 Then
            MessageBox.Show("Data masih kosong")
            Return
        End If

        If dgvData.CurrentRow Is Nothing Then
            MessageBox.Show("Pilih data terlebih dahulu")
            Return
        End If

        Dim id As Integer = dgvData.CurrentRow.Cells("id").Value

        Dim f2 As New Form2()
        f2.Mode = "EDIT"
        f2.EditId = id
        f2.ShowDialog()

        TampilData()
        Kosong()
    End Sub

    ' TOMBOL HAPUS
    Private Sub btnHapus_Click(sender As Object, e As EventArgs) Handles btnHapus.Click

        If dgvData.Rows.Count = 0 Then
            MessageBox.Show("Data masih kosong")
            Return
        End If

        If dgvData.CurrentRow Is Nothing Then
            MessageBox.Show("Pilih data terlebih dahulu")
            Return
        End If

        Dim hasil As DialogResult = MessageBox.Show(
            "Apakah data ingin dihapus?",
            "Konfirmasi",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Question
        )

        If hasil = DialogResult.Yes Then
            Dim id As Integer = dgvData.CurrentRow.Cells("id").Value

            If HapusBookmark(id) Then
                MessageBox.Show("Data berhasil dihapus")
                TampilData()
                Kosong()
            End If
        End If

    End Sub

    ' SEARCH
    Private Sub txtCari_TextChanged(sender As Object, e As EventArgs) Handles txtCari.TextChanged

        If txtCari.Text.Trim() = "" Then
            TampilData()
        Else
            dgvData.DataSource = SearchBookmark(txtCari.Text.Trim())
        End If

    End Sub

End Class