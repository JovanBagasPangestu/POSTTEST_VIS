Public Class Form2

    Public Mode As String = "TAMBAH"
    Public EditId As Integer = 0

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ' Ambil kategori dari database
        Dim dt As DataTable = GetAllKategori()

        cboKategori.DataSource = dt
        cboKategori.DisplayMember = "nama_kategori"
        cboKategori.ValueMember = "id"

        If Mode = "EDIT" Then
            Me.Text = "Edit Bookmark"
            IsiData()
        Else
            Me.Text = "Tambah Bookmark"
        End If

    End Sub

    ' AMBIL DATA UNTUK EDIT
    Private Sub IsiData()

        Dim dt As DataTable = GetBookmarkById(EditId)

        If dt.Rows.Count > 0 Then
            txtNamaWebsite.Text = dt.Rows(0)("nama_website")
            txtUrl.Text = dt.Rows(0)("url")
            txtCatatan.Text = dt.Rows(0)("catatan")

            cboKategori.SelectedValue = dt.Rows(0)("kategori_id")
        End If

    End Sub

    ' SIMPAN DATA
    Private Sub btnSimpan_Click(sender As Object, e As EventArgs) Handles btnSimpan.Click

        If txtNamaWebsite.Text = "" Then
            MessageBox.Show("Nama website tidak boleh kosong")
            txtNamaWebsite.Focus()
            Exit Sub
        End If

        If txtUrl.Text = "" Then
            MessageBox.Show("URL tidak boleh kosong")
            txtUrl.Focus()
            Exit Sub
        End If

        If Not txtUrl.Text.StartsWith("http://") AndAlso Not txtUrl.Text.StartsWith("https://") Then
            MessageBox.Show("URL harus diawali http:// atau https://")
            txtUrl.Focus()
            Exit Sub
        End If

        If cboKategori.Text = "" Then
            MessageBox.Show("Kategori belum dipilih")
            cboKategori.Focus()
            Exit Sub
        End If

        If Mode = "TAMBAH" Then

            SimpanBookmark(
                txtNamaWebsite.Text,
                txtUrl.Text,
                cboKategori.SelectedValue,
                txtCatatan.Text
            )

            MessageBox.Show("Data berhasil ditambahkan")

        Else

            UbahBookmark(
                EditId,
                txtNamaWebsite.Text,
                txtUrl.Text,
                cboKategori.SelectedValue,
                txtCatatan.Text
            )

            MessageBox.Show("Data berhasil diubah")

        End If

        Me.Close()

    End Sub

    ' BATAL
    Private Sub btnBatal_Click(sender As Object, e As EventArgs) Handles btnBatal.Click
        Me.Close()
    End Sub

End Class