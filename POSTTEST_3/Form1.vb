Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    End Sub

    'TOMBOL BROWSE FOTO
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim openFile As New OpenFileDialog
        openFile.Filter = "Image Files|*.jpg;*.jpeg;*.png"

        If openFile.ShowDialog = DialogResult.OK Then
            PictureBox1.Image = Image.FromFile(openFile.FileName)
        End If

    End Sub

    'NAMA
    Private Sub TextBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox1.KeyPress

        If Not Char.IsLetter(e.KeyChar) And
           Not Char.IsWhiteSpace(e.KeyChar) And
           Not Char.IsControl(e.KeyChar) Then

            e.Handled = True
        End If

    End Sub

    'UMUR
    Private Sub TextBox2_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox2.KeyPress

        If Not Char.IsDigit(e.KeyChar) And Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If

    End Sub

    'TELEPON 
    Private Sub TextBox3_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox3.KeyPress

        If Not Char.IsDigit(e.KeyChar) And Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If

    End Sub

    'TOMBOL CETAK KARTU
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        'TEXTBOX
        If TextBox1.Text = "" Or
           TextBox2.Text = "" Or
           TextBox3.Text = "" Or
           TextBox4.Text = "" Then

            MessageBox.Show("Inputan tidak boleh kosong")
            Exit Sub
        End If


        'RADIO BUTTON
        If Not RadioButton1.Checked And Not RadioButton2.Checked Then
            MessageBox.Show("Inputan tidak boleh kosong")
            Exit Sub
        End If


        'CHECKBOX
        If Not (CheckBox1.Checked Or CheckBox2.Checked Or CheckBox3.Checked Or
                CheckBox4.Checked Or CheckBox5.Checked Or CheckBox6.Checked Or
                CheckBox7.Checked Or CheckBox8.Checked Or CheckBox9.Checked Or
                CheckBox10.Checked Or CheckBox11.Checked Or CheckBox12.Checked) Then

            MessageBox.Show("Inputan tidak boleh kosong")
            Exit Sub
        End If


        Dim f As New Form2


        'FOTO
        f.PictureBox1.Image = PictureBox1.Image


        'DATA
        f.lblNama.Text = TextBox1.Text
        f.lblUmur.Text = TextBox2.Text
        f.lblLahir.Text = DateTimePicker1.Text
        f.lblTelpon.Text = TextBox3.Text
        f.lblAlamat.Text = TextBox4.Text


        'JENIS KELAMIN
        If RadioButton1.Checked Then
            f.lblKelamin.Text = "Laki-Laki"
        ElseIf RadioButton2.Checked Then
            f.lblKelamin.Text = "Perempuan"
        End If


        'HOBBY
        Dim hobby As String = ""

        If CheckBox1.Checked Then hobby &= "Menari, "
        If CheckBox2.Checked Then hobby &= "Menyanyi, "
        If CheckBox3.Checked Then hobby &= "Memasak, "
        If CheckBox4.Checked Then hobby &= "Gaming, "
        If CheckBox5.Checked Then hobby &= "Coding, "
        If CheckBox6.Checked Then hobby &= "Membaca, "
        If CheckBox7.Checked Then hobby &= "Menulis, "
        If CheckBox8.Checked Then hobby &= "Musik, "
        If CheckBox9.Checked Then hobby &= "Menonton, "
        If CheckBox10.Checked Then hobby &= "Berkebun, "
        If CheckBox11.Checked Then hobby &= "Olahraga, "
        If CheckBox12.Checked Then hobby &= "Merajut, "

        f.lblHobby.Text = hobby

        'TAMPILKAN FORM2
        f.Show()

        MessageBox.Show("Kartu berhasil dibuat")
    End Sub

End Class
