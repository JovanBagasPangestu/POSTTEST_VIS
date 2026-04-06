Public Class Form1

    Dim nomor As Integer = 1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Auto ID
        txtId.Text = "TRV-" & nomor.ToString("000")

        ' Default
        rbMember.Checked = True
    End Sub

    ' =====================
    ' VALIDASI NAMA (HURUF)
    ' =====================
    Private Sub txtNama_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNama.KeyPress
        If Not Char.IsLetter(e.KeyChar) And Not Char.IsControl(e.KeyChar) And Not Char.IsWhiteSpace(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    ' =====================
    ' VALIDASI NOMOR (ANGKA)
    ' =====================
    Private Sub mtbNomor_KeyPress(sender As Object, e As KeyPressEventArgs) Handles mtbNomor.KeyPress
        If Not Char.IsDigit(e.KeyChar) And Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    ' =====================
    ' BROWSE FOTO
    ' =====================
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim ofd As New OpenFileDialog
        ofd.Filter = "Image Files|*.jpg;*.png"

        If ofd.ShowDialog = DialogResult.OK Then
            PictureBox1.Image = Image.FromFile(ofd.FileName)
        End If
    End Sub

    ' =====================
    ' SIMPAN & CETAK
    ' =====================
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        ' KONFIRMASI
        If MessageBox.Show("Simpan dan tampilkan kartu?", "Konfirmasi",
                           MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.No Then
            Exit Sub
        End If

        Dim peran As String = ""
        Dim aktivitas As String = ""

        ' PERAN
        If rbKetua.Checked Then peran = "Ketua"
        If rbWakil.Checked Then peran = "Wakil Ketua"
        If rbAdmin.Checked Then peran = "Admin"
        If rbKoordinator.Checked Then peran = "Koordinator Trip"
        If rbDokumentasi.Checked Then peran = "Dokumentasi"
        If rbBendahara.Checked Then peran = "Bendahara"
        If rbSekretaris.Checked Then peran = "Sekretaris"
        If rbMember.Checked Then peran = "Member"

        ' AKTIVITAS
        If cbHiking.Checked Then aktivitas &= "Hiking, "
        If cbCamping.Checked Then aktivitas &= "Camping, "
        If cbTrekking.Checked Then aktivitas &= "Trekking, "
        If cbSnorkeling.Checked Then aktivitas &= "Snorkeling, "
        If cbKuliner.Checked Then aktivitas &= "Kuliner, "
        If cbCityTour.Checked Then aktivitas &= "City Tour, "
        If cbStaycation.Checked Then aktivitas &= "Staycation, "
        If cbFotografi.Checked Then aktivitas &= "Fotografi, "
        If cbVideografi.Checked Then aktivitas &= "Videografi, "
        If cbBackpacking.Checked Then aktivitas &= "Backpacking, "
        If cbVolunteer.Checked Then aktivitas &= "Volunteer Trip, "

        ' VALIDASI
        If txtNama.Text = "" Or txtId.Text = "" Or tbEmail.Text = "" Or tbAlamat.Text = "" Then
            MessageBox.Show("Inputan tidak boleh kosong")
            Exit Sub
        End If

        If aktivitas = "" Then
            MessageBox.Show("Pilih minimal 1 aktivitas")
            Exit Sub
        End If

        If PictureBox1.Image Is Nothing Then
            MessageBox.Show("Foto belum diupload")
            Exit Sub
        End If

        ' KIRIM DATA
        FormKartu.lblNama.Text = txtNama.Text
        FormKartu.lblID.Text = txtId.Text
        FormKartu.lblKomunitas.Text = ComboBox1.Text
        FormKartu.lblKontak.Text = mtbNomor.Text
        FormKartu.lblPeran.Text = peran
        FormKartu.lblAktivitas.Text = aktivitas
        FormKartu.PictureBox1.Image = PictureBox1.Image

        FormKartu.Show()

        ' AUTO ID NEXT
        nomor += 1
        txtId.Text = "TRV-" & nomor.ToString("000")
    End Sub

    ' =========================
    ' MENU INPUT DATA (RESET)
    ' =========================
    Private Sub InputDataToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles InputDataToolStripMenuItem.Click
        txtNama.Clear()
        txtId.Clear()
        ComboBox1.SelectedIndex = -1
        mtbNomor.Clear()
        tbEmail.Clear()
        tbAlamat.Clear()
        PictureBox1.Image = Nothing
    End Sub

    ' =========================
    ' MENU SIMPAN DATA
    ' =========================
    Private Sub SimpanDataToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SimpanDataToolStripMenuItem.Click
        If MessageBox.Show("Simpan data?", "Konfirmasi", MessageBoxButtons.YesNo) = DialogResult.No Then Exit Sub

        Dim sfd As New SaveFileDialog
        sfd.Filter = "Text File|*.txt"

        If sfd.ShowDialog() = DialogResult.OK Then
            Dim sw As New IO.StreamWriter(sfd.FileName)

            sw.WriteLine(txtNama.Text)
            sw.WriteLine(txtId.Text)
            sw.WriteLine(ComboBox1.Text)
            sw.WriteLine(mtbNomor.Text)
            sw.WriteLine(tbEmail.Text)
            sw.WriteLine(tbAlamat.Text)

            sw.Close()
            MessageBox.Show("Data berhasil disimpan")
        End If
    End Sub

    ' =========================
    ' MENU LIHAT DATA
    ' =========================
    Private Sub LihatDataToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LihatDataToolStripMenuItem.Click
        Dim ofd As New OpenFileDialog

        If ofd.ShowDialog() = DialogResult.OK Then
            Dim sr As New IO.StreamReader(ofd.FileName)

            txtNama.Text = sr.ReadLine()
            txtId.Text = sr.ReadLine()
            ComboBox1.Text = sr.ReadLine()
            mtbNomor.Text = sr.ReadLine()
            tbEmail.Text = sr.ReadLine()
            tbAlamat.Text = sr.ReadLine()

            sr.Close()
        End If
    End Sub

    ' =========================
    ' MENU LIHAT KARTU
    ' =========================
    Private Sub LihatKartuToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LihatKartuToolStripMenuItem.Click
        FormKartu.Show()
    End Sub

    ' =========================
    ' MENU KELUAR
    ' =========================
    Private Sub KeluarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles KeluarToolStripMenuItem.Click
        If MessageBox.Show("Yakin keluar?", "Keluar", MessageBoxButtons.YesNo) = DialogResult.Yes Then
            Application.Exit()
        End If
    End Sub

End Class