<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
	Inherits System.Windows.Forms.Form

	'Form overrides dispose to clean up the component list.
	<System.Diagnostics.DebuggerNonUserCode()>
	Protected Overrides Sub Dispose(disposing As Boolean)
		Try
			If disposing AndAlso components IsNot Nothing Then
				components.Dispose()
			End If
		Finally
			MyBase.Dispose(disposing)
		End Try
	End Sub

	'Required by the Windows Form Designer
	Private components As System.ComponentModel.IContainer

	'NOTE: The following procedure is required by the Windows Form Designer
	'It can be modified using the Windows Form Designer.
	'Do not modify it using the code editor.
	<System.Diagnostics.DebuggerStepThrough()>
	Private Sub InitializeComponent()
		PictureBox1 = New PictureBox()
		Button1 = New Button()
		TextBox1 = New TextBox()
		TextBox2 = New TextBox()
		TextBox3 = New TextBox()
		TextBox4 = New TextBox()
		DateTimePicker1 = New DateTimePicker()
		gbKelamin = New GroupBox()
		RadioButton2 = New RadioButton()
		RadioButton1 = New RadioButton()
		gbHobby = New GroupBox()
		CheckBox12 = New CheckBox()
		CheckBox11 = New CheckBox()
		CheckBox9 = New CheckBox()
		CheckBox8 = New CheckBox()
		CheckBox10 = New CheckBox()
		CheckBox7 = New CheckBox()
		CheckBox6 = New CheckBox()
		CheckBox5 = New CheckBox()
		CheckBox4 = New CheckBox()
		CheckBox3 = New CheckBox()
		CheckBox2 = New CheckBox()
		CheckBox1 = New CheckBox()
		Button2 = New Button()
		lblNama = New Label()
		lblUmur = New Label()
		lblLahir = New Label()
		lblTelpon = New Label()
		lblAlamat = New Label()
		CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
		gbKelamin.SuspendLayout()
		gbHobby.SuspendLayout()
		SuspendLayout()
		' 
		' PictureBox1
		' 
		PictureBox1.BackColor = Color.Transparent
		PictureBox1.BorderStyle = BorderStyle.Fixed3D
		PictureBox1.Location = New Point(12, 12)
		PictureBox1.Name = "PictureBox1"
		PictureBox1.Size = New Size(217, 389)
		PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
		PictureBox1.TabIndex = 0
		PictureBox1.TabStop = False
		' 
		' Button1
		' 
		Button1.BackColor = Color.Linen
		Button1.Location = New Point(79, 409)
		Button1.Name = "Button1"
		Button1.Size = New Size(94, 29)
		Button1.TabIndex = 1
		Button1.Text = "Browse"
		Button1.UseVisualStyleBackColor = False
		' 
		' TextBox1
		' 
		TextBox1.BackColor = Color.Linen
		TextBox1.Location = New Point(376, 12)
		TextBox1.Name = "TextBox1"
		TextBox1.Size = New Size(250, 27)
		TextBox1.TabIndex = 2
		' 
		' TextBox2
		' 
		TextBox2.BackColor = Color.Linen
		TextBox2.Location = New Point(376, 61)
		TextBox2.Name = "TextBox2"
		TextBox2.Size = New Size(250, 27)
		TextBox2.TabIndex = 3
		' 
		' TextBox3
		' 
		TextBox3.BackColor = Color.Linen
		TextBox3.Location = New Point(376, 159)
		TextBox3.Name = "TextBox3"
		TextBox3.Size = New Size(250, 27)
		TextBox3.TabIndex = 4
		' 
		' TextBox4
		' 
		TextBox4.BackColor = Color.Linen
		TextBox4.Location = New Point(376, 209)
		TextBox4.Name = "TextBox4"
		TextBox4.Size = New Size(250, 27)
		TextBox4.TabIndex = 5
		' 
		' DateTimePicker1
		' 
		DateTimePicker1.CalendarTrailingForeColor = SystemColors.ControlLight
		DateTimePicker1.Location = New Point(376, 108)
		DateTimePicker1.Name = "DateTimePicker1"
		DateTimePicker1.Size = New Size(250, 27)
		DateTimePicker1.TabIndex = 6
		' 
		' gbKelamin
		' 
		gbKelamin.BackColor = Color.Transparent
		gbKelamin.Controls.Add(RadioButton2)
		gbKelamin.Controls.Add(RadioButton1)
		gbKelamin.ForeColor = SystemColors.ActiveCaptionText
		gbKelamin.Location = New Point(235, 249)
		gbKelamin.Name = "gbKelamin"
		gbKelamin.Size = New Size(192, 152)
		gbKelamin.TabIndex = 7
		gbKelamin.TabStop = False
		gbKelamin.Text = "Jenis Kelamin"
		' 
		' RadioButton2
		' 
		RadioButton2.AutoSize = True
		RadioButton2.Location = New Point(6, 68)
		RadioButton2.Name = "RadioButton2"
		RadioButton2.Size = New Size(104, 24)
		RadioButton2.TabIndex = 0
		RadioButton2.TabStop = True
		RadioButton2.Text = "Perempuan"
		RadioButton2.UseVisualStyleBackColor = True
		' 
		' RadioButton1
		' 
		RadioButton1.AutoSize = True
		RadioButton1.Location = New Point(6, 38)
		RadioButton1.Name = "RadioButton1"
		RadioButton1.Size = New Size(88, 24)
		RadioButton1.TabIndex = 0
		RadioButton1.TabStop = True
		RadioButton1.Text = "Laki-Laki"
		RadioButton1.UseVisualStyleBackColor = True
		' 
		' gbHobby
		' 
		gbHobby.BackColor = Color.Transparent
		gbHobby.Controls.Add(CheckBox12)
		gbHobby.Controls.Add(CheckBox11)
		gbHobby.Controls.Add(CheckBox9)
		gbHobby.Controls.Add(CheckBox8)
		gbHobby.Controls.Add(CheckBox10)
		gbHobby.Controls.Add(CheckBox7)
		gbHobby.Controls.Add(CheckBox6)
		gbHobby.Controls.Add(CheckBox5)
		gbHobby.Controls.Add(CheckBox4)
		gbHobby.Controls.Add(CheckBox3)
		gbHobby.Controls.Add(CheckBox2)
		gbHobby.Controls.Add(CheckBox1)
		gbHobby.ForeColor = SystemColors.ControlText
		gbHobby.Location = New Point(443, 249)
		gbHobby.Name = "gbHobby"
		gbHobby.Size = New Size(345, 152)
		gbHobby.TabIndex = 8
		gbHobby.TabStop = False
		gbHobby.Text = "Hobby"
		' 
		' CheckBox12
		' 
		CheckBox12.AutoSize = True
		CheckBox12.Location = New Point(234, 116)
		CheckBox12.Name = "CheckBox12"
		CheckBox12.Size = New Size(82, 24)
		CheckBox12.TabIndex = 11
		CheckBox12.Text = "merajut"
		CheckBox12.UseVisualStyleBackColor = True
		' 
		' CheckBox11
		' 
		CheckBox11.AutoSize = True
		CheckBox11.Location = New Point(234, 85)
		CheckBox11.Name = "CheckBox11"
		CheckBox11.Size = New Size(90, 24)
		CheckBox11.TabIndex = 10
		CheckBox11.Text = "olahraga"
		CheckBox11.UseVisualStyleBackColor = True
		' 
		' CheckBox9
		' 
		CheckBox9.AutoSize = True
		CheckBox9.Location = New Point(234, 26)
		CheckBox9.Name = "CheckBox9"
		CheckBox9.Size = New Size(99, 24)
		CheckBox9.TabIndex = 8
		CheckBox9.Text = "menonton"
		CheckBox9.UseVisualStyleBackColor = True
		' 
		' CheckBox8
		' 
		CheckBox8.AutoSize = True
		CheckBox8.Location = New Point(119, 116)
		CheckBox8.Name = "CheckBox8"
		CheckBox8.Size = New Size(69, 24)
		CheckBox8.TabIndex = 7
		CheckBox8.Text = "musik"
		CheckBox8.UseVisualStyleBackColor = True
		' 
		' CheckBox10
		' 
		CheckBox10.AutoSize = True
		CheckBox10.Location = New Point(234, 56)
		CheckBox10.Name = "CheckBox10"
		CheckBox10.Size = New Size(93, 24)
		CheckBox10.TabIndex = 9
		CheckBox10.Text = "berkebun"
		CheckBox10.UseVisualStyleBackColor = True
		' 
		' CheckBox7
		' 
		CheckBox7.AutoSize = True
		CheckBox7.Location = New Point(119, 85)
		CheckBox7.Name = "CheckBox7"
		CheckBox7.Size = New Size(82, 24)
		CheckBox7.TabIndex = 6
		CheckBox7.Text = "menulis"
		CheckBox7.UseVisualStyleBackColor = True
		' 
		' CheckBox6
		' 
		CheckBox6.AutoSize = True
		CheckBox6.Location = New Point(119, 56)
		CheckBox6.Name = "CheckBox6"
		CheckBox6.Size = New Size(97, 24)
		CheckBox6.TabIndex = 5
		CheckBox6.Text = "membaca"
		CheckBox6.UseVisualStyleBackColor = True
		' 
		' CheckBox5
		' 
		CheckBox5.AutoSize = True
		CheckBox5.Location = New Point(119, 26)
		CheckBox5.Name = "CheckBox5"
		CheckBox5.Size = New Size(77, 24)
		CheckBox5.TabIndex = 4
		CheckBox5.Text = "coding"
		CheckBox5.UseVisualStyleBackColor = True
		' 
		' CheckBox4
		' 
		CheckBox4.AutoSize = True
		CheckBox4.Location = New Point(6, 116)
		CheckBox4.Name = "CheckBox4"
		CheckBox4.Size = New Size(82, 24)
		CheckBox4.TabIndex = 3
		CheckBox4.Text = "gaming"
		CheckBox4.UseVisualStyleBackColor = True
		' 
		' CheckBox3
		' 
		CheckBox3.AutoSize = True
		CheckBox3.Location = New Point(6, 86)
		CheckBox3.Name = "CheckBox3"
		CheckBox3.Size = New Size(94, 24)
		CheckBox3.TabIndex = 2
		CheckBox3.Text = "memasak"
		CheckBox3.UseVisualStyleBackColor = True
		' 
		' CheckBox2
		' 
		CheckBox2.AutoSize = True
		CheckBox2.Location = New Point(6, 56)
		CheckBox2.Name = "CheckBox2"
		CheckBox2.Size = New Size(94, 24)
		CheckBox2.TabIndex = 1
		CheckBox2.Text = "menyanyi"
		CheckBox2.UseVisualStyleBackColor = True
		' 
		' CheckBox1
		' 
		CheckBox1.AutoSize = True
		CheckBox1.Location = New Point(6, 26)
		CheckBox1.Name = "CheckBox1"
		CheckBox1.Size = New Size(77, 24)
		CheckBox1.TabIndex = 0
		CheckBox1.Text = "menari"
		CheckBox1.UseVisualStyleBackColor = True
		' 
		' Button2
		' 
		Button2.BackColor = Color.Linen
		Button2.Location = New Point(235, 409)
		Button2.Name = "Button2"
		Button2.Size = New Size(553, 29)
		Button2.TabIndex = 9
		Button2.Text = "Cetak Kartu"
		Button2.UseVisualStyleBackColor = False
		' 
		' lblNama
		' 
		lblNama.AutoSize = True
		lblNama.ForeColor = SystemColors.ActiveCaptionText
		lblNama.Location = New Point(241, 15)
		lblNama.Name = "lblNama"
		lblNama.Size = New Size(49, 20)
		lblNama.TabIndex = 10
		lblNama.Text = "Nama"
		' 
		' lblUmur
		' 
		lblUmur.AutoSize = True
		lblUmur.ForeColor = SystemColors.ActiveCaptionText
		lblUmur.Location = New Point(241, 64)
		lblUmur.Name = "lblUmur"
		lblUmur.Size = New Size(45, 20)
		lblUmur.TabIndex = 11
		lblUmur.Text = "Umur"
		' 
		' lblLahir
		' 
		lblLahir.AutoSize = True
		lblLahir.ForeColor = SystemColors.ActiveCaptionText
		lblLahir.Location = New Point(241, 113)
		lblLahir.Name = "lblLahir"
		lblLahir.Size = New Size(97, 20)
		lblLahir.TabIndex = 12
		lblLahir.Text = "Tanggal Lahir"
		' 
		' lblTelpon
		' 
		lblTelpon.AutoSize = True
		lblTelpon.ForeColor = SystemColors.ActiveCaptionText
		lblTelpon.Location = New Point(241, 162)
		lblTelpon.Name = "lblTelpon"
		lblTelpon.Size = New Size(78, 20)
		lblTelpon.TabIndex = 13
		lblTelpon.Text = "No Telpon"
		' 
		' lblAlamat
		' 
		lblAlamat.AutoSize = True
		lblAlamat.ForeColor = SystemColors.ActiveCaptionText
		lblAlamat.Location = New Point(241, 209)
		lblAlamat.Name = "lblAlamat"
		lblAlamat.Size = New Size(57, 20)
		lblAlamat.TabIndex = 14
		lblAlamat.Text = "Alamat"
		' 
		' Form1
		' 
		AutoScaleDimensions = New SizeF(8F, 20F)
		AutoScaleMode = AutoScaleMode.Font
		BackColor = Color.IndianRed
		BackgroundImage = My.Resources.Resources.South_Korea_PNG_Picture__South_Koreas_Gold_Line_Ink_Landscape_Scenery_Blue_Mountains_And_Rivers__Bird__Sunset__Blue_PNG_Image_For_Free_Download_removebg_preview
		BackgroundImageLayout = ImageLayout.Stretch
		ClientSize = New Size(795, 444)
		Controls.Add(lblAlamat)
		Controls.Add(lblTelpon)
		Controls.Add(lblLahir)
		Controls.Add(lblUmur)
		Controls.Add(lblNama)
		Controls.Add(Button2)
		Controls.Add(gbHobby)
		Controls.Add(gbKelamin)
		Controls.Add(DateTimePicker1)
		Controls.Add(TextBox4)
		Controls.Add(TextBox3)
		Controls.Add(TextBox2)
		Controls.Add(TextBox1)
		Controls.Add(Button1)
		Controls.Add(PictureBox1)
		DoubleBuffered = True
		Name = "Form1"
		Text = "Form1"
		CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
		gbKelamin.ResumeLayout(False)
		gbKelamin.PerformLayout()
		gbHobby.ResumeLayout(False)
		gbHobby.PerformLayout()
		ResumeLayout(False)
		PerformLayout()
	End Sub

	Friend WithEvents PictureBox1 As PictureBox
	Friend WithEvents Button1 As Button
	Friend WithEvents TextBox1 As TextBox
	Friend WithEvents TextBox2 As TextBox
	Friend WithEvents TextBox3 As TextBox
	Friend WithEvents TextBox4 As TextBox
	Friend WithEvents DateTimePicker1 As DateTimePicker
	Friend WithEvents gbKelamin As GroupBox
	Friend WithEvents RadioButton2 As RadioButton
	Friend WithEvents RadioButton1 As RadioButton
	Friend WithEvents gbHobby As GroupBox
	Friend WithEvents CheckBox10 As CheckBox
	Friend WithEvents CheckBox9 As CheckBox
	Friend WithEvents CheckBox8 As CheckBox
	Friend WithEvents CheckBox7 As CheckBox
	Friend WithEvents CheckBox6 As CheckBox
	Friend WithEvents CheckBox5 As CheckBox
	Friend WithEvents CheckBox4 As CheckBox
	Friend WithEvents CheckBox3 As CheckBox
	Friend WithEvents CheckBox2 As CheckBox
	Friend WithEvents CheckBox1 As CheckBox
	Friend WithEvents Button2 As Button
	Friend WithEvents CheckBox12 As CheckBox
	Friend WithEvents CheckBox11 As CheckBox
	Friend WithEvents lblNama As Label
	Friend WithEvents lblUmur As Label
	Friend WithEvents lblLahir As Label
	Friend WithEvents lblTelpon As Label
	Friend WithEvents lblAlamat As Label

End Class
