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
		MenuStrip1 = New MenuStrip()
		SimpanDataToolStripMenuItem = New ToolStripMenuItem()
		InputDataToolStripMenuItem = New ToolStripMenuItem()
		LihatDataToolStripMenuItem = New ToolStripMenuItem()
		LihatKartuToolStripMenuItem = New ToolStripMenuItem()
		KeluarToolStripMenuItem = New ToolStripMenuItem()
		TabControl1 = New TabControl()
		TabPage1 = New TabPage()
		txtId = New TextBox()
		Label5 = New Label()
		ComboBox1 = New ComboBox()
		Label4 = New Label()
		RadioButton2 = New RadioButton()
		RadioButton1 = New RadioButton()
		Label3 = New Label()
		DateTimePicker1 = New DateTimePicker()
		Label2 = New Label()
		Label1 = New Label()
		txtNama = New TextBox()
		TabPage2 = New TabPage()
		tbEmail = New TextBox()
		tbAlamat = New TextBox()
		mtbNomor = New MaskedTextBox()
		Label8 = New Label()
		Label7 = New Label()
		Label6 = New Label()
		TabPage3 = New TabPage()
		GroupBox2 = New GroupBox()
		cbVolunteer = New CheckBox()
		cbVideografi = New CheckBox()
		cbFotografi = New CheckBox()
		cbCityTour = New CheckBox()
		cbKuliner = New CheckBox()
		cbTrekking = New CheckBox()
		cbStaycation = New CheckBox()
		cbCamping = New CheckBox()
		cbHiking = New CheckBox()
		cbBackpacking = New CheckBox()
		cbSnorkeling = New CheckBox()
		Button2 = New Button()
		GroupBox1 = New GroupBox()
		rbSekretaris = New RadioButton()
		rbBendahara = New RadioButton()
		rbMember = New RadioButton()
		rbDokumentasi = New RadioButton()
		rbKoordinator = New RadioButton()
		rbAdmin = New RadioButton()
		rbWakil = New RadioButton()
		rbKetua = New RadioButton()
		Button1 = New Button()
		PictureBox1 = New PictureBox()
		MenuStrip1.SuspendLayout()
		TabControl1.SuspendLayout()
		TabPage1.SuspendLayout()
		TabPage2.SuspendLayout()
		TabPage3.SuspendLayout()
		GroupBox2.SuspendLayout()
		GroupBox1.SuspendLayout()
		CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
		SuspendLayout()
		' 
		' MenuStrip1
		' 
		MenuStrip1.ImageScalingSize = New Size(20, 20)
		MenuStrip1.Items.AddRange(New ToolStripItem() {SimpanDataToolStripMenuItem, InputDataToolStripMenuItem, LihatDataToolStripMenuItem, LihatKartuToolStripMenuItem, KeluarToolStripMenuItem})
		MenuStrip1.Location = New Point(0, 0)
		MenuStrip1.Name = "MenuStrip1"
		MenuStrip1.Size = New Size(800, 28)
		MenuStrip1.TabIndex = 0
		MenuStrip1.Text = "MenuStrip1"
		' 
		' SimpanDataToolStripMenuItem
		' 
		SimpanDataToolStripMenuItem.Name = "SimpanDataToolStripMenuItem"
		SimpanDataToolStripMenuItem.Size = New Size(109, 24)
		SimpanDataToolStripMenuItem.Text = "Simpan Data"
		' 
		' InputDataToolStripMenuItem
		' 
		InputDataToolStripMenuItem.Name = "InputDataToolStripMenuItem"
		InputDataToolStripMenuItem.Size = New Size(93, 24)
		InputDataToolStripMenuItem.Text = "Input Data"
		' 
		' LihatDataToolStripMenuItem
		' 
		LihatDataToolStripMenuItem.Name = "LihatDataToolStripMenuItem"
		LihatDataToolStripMenuItem.Size = New Size(91, 24)
		LihatDataToolStripMenuItem.Text = "Lihat Data"
		' 
		' LihatKartuToolStripMenuItem
		' 
		LihatKartuToolStripMenuItem.Name = "LihatKartuToolStripMenuItem"
		LihatKartuToolStripMenuItem.Size = New Size(94, 24)
		LihatKartuToolStripMenuItem.Text = "Lihat Kartu"
		' 
		' KeluarToolStripMenuItem
		' 
		KeluarToolStripMenuItem.Name = "KeluarToolStripMenuItem"
		KeluarToolStripMenuItem.Size = New Size(65, 24)
		KeluarToolStripMenuItem.Text = "Keluar"
		' 
		' TabControl1
		' 
		TabControl1.Controls.Add(TabPage1)
		TabControl1.Controls.Add(TabPage2)
		TabControl1.Controls.Add(TabPage3)
		TabControl1.Location = New Point(52, 69)
		TabControl1.Name = "TabControl1"
		TabControl1.SelectedIndex = 0
		TabControl1.Size = New Size(673, 329)
		TabControl1.TabIndex = 1
		' 
		' TabPage1
		' 
		TabPage1.BackgroundImage = My.Resources.Resources.ChatGPT_Image_Apr_6__2026__08_13_50_PM
		TabPage1.BackgroundImageLayout = ImageLayout.Stretch
		TabPage1.Controls.Add(txtId)
		TabPage1.Controls.Add(Label5)
		TabPage1.Controls.Add(ComboBox1)
		TabPage1.Controls.Add(Label4)
		TabPage1.Controls.Add(RadioButton2)
		TabPage1.Controls.Add(RadioButton1)
		TabPage1.Controls.Add(Label3)
		TabPage1.Controls.Add(DateTimePicker1)
		TabPage1.Controls.Add(Label2)
		TabPage1.Controls.Add(Label1)
		TabPage1.Controls.Add(txtNama)
		TabPage1.Location = New Point(4, 29)
		TabPage1.Name = "TabPage1"
		TabPage1.Padding = New Padding(3)
		TabPage1.Size = New Size(665, 296)
		TabPage1.TabIndex = 0
		TabPage1.Text = "Data Utama"
		TabPage1.UseVisualStyleBackColor = True
		' 
		' txtId
		' 
		txtId.BackColor = Color.FromArgb(255, 224, 192)
		txtId.Location = New Point(295, 79)
		txtId.Name = "txtId"
		txtId.Size = New Size(250, 27)
		txtId.TabIndex = 11
		' 
		' Label5
		' 
		Label5.AutoSize = True
		Label5.BackColor = Color.FromArgb(255, 128, 255)
		Label5.Location = New Point(123, 226)
		Label5.Name = "Label5"
		Label5.Size = New Size(154, 20)
		Label5.TabIndex = 10
		Label5.Text = "Jenis Komunitas/divisi"
		' 
		' ComboBox1
		' 
		ComboBox1.BackColor = Color.FromArgb(255, 255, 128)
		ComboBox1.FormattingEnabled = True
		ComboBox1.Items.AddRange(New Object() {"Adventure/Outdoor", "Backpacker", "City Explorer", "Culinary Traveler", "Nature & Camping", "Travel Konten Kreator"})
		ComboBox1.Location = New Point(295, 223)
		ComboBox1.Name = "ComboBox1"
		ComboBox1.Size = New Size(250, 28)
		ComboBox1.TabIndex = 9
		' 
		' Label4
		' 
		Label4.AutoSize = True
		Label4.BackColor = Color.FromArgb(128, 255, 255)
		Label4.Location = New Point(123, 178)
		Label4.Name = "Label4"
		Label4.Size = New Size(98, 20)
		Label4.TabIndex = 8
		Label4.Text = "Jenis Kelamin"
		' 
		' RadioButton2
		' 
		RadioButton2.AutoSize = True
		RadioButton2.Location = New Point(429, 176)
		RadioButton2.Name = "RadioButton2"
		RadioButton2.Size = New Size(104, 24)
		RadioButton2.TabIndex = 7
		RadioButton2.TabStop = True
		RadioButton2.Text = "Perempuan"
		RadioButton2.UseVisualStyleBackColor = True
		' 
		' RadioButton1
		' 
		RadioButton1.AutoSize = True
		RadioButton1.Location = New Point(318, 174)
		RadioButton1.Name = "RadioButton1"
		RadioButton1.Size = New Size(88, 24)
		RadioButton1.TabIndex = 6
		RadioButton1.TabStop = True
		RadioButton1.Text = "Laki-Laki"
		RadioButton1.UseVisualStyleBackColor = True
		' 
		' Label3
		' 
		Label3.AutoSize = True
		Label3.BackColor = Color.MistyRose
		Label3.Location = New Point(123, 132)
		Label3.Name = "Label3"
		Label3.Size = New Size(97, 20)
		Label3.TabIndex = 5
		Label3.Text = "Tanggal Lahir"
		' 
		' DateTimePicker1
		' 
		DateTimePicker1.Location = New Point(295, 127)
		DateTimePicker1.Name = "DateTimePicker1"
		DateTimePicker1.Size = New Size(250, 27)
		DateTimePicker1.TabIndex = 4
		' 
		' Label2
		' 
		Label2.AutoSize = True
		Label2.BackColor = Color.LightSalmon
		Label2.Location = New Point(123, 82)
		Label2.Name = "Label2"
		Label2.Size = New Size(24, 20)
		Label2.TabIndex = 3
		Label2.Text = "ID"
		' 
		' Label1
		' 
		Label1.AutoSize = True
		Label1.BackColor = Color.FromArgb(128, 255, 128)
		Label1.Location = New Point(123, 37)
		Label1.Name = "Label1"
		Label1.Size = New Size(49, 20)
		Label1.TabIndex = 2
		Label1.Text = "Nama"
		' 
		' txtNama
		' 
		txtNama.BackColor = Color.FromArgb(192, 192, 255)
		txtNama.Location = New Point(295, 37)
		txtNama.Name = "txtNama"
		txtNama.Size = New Size(250, 27)
		txtNama.TabIndex = 0
		' 
		' TabPage2
		' 
		TabPage2.BackgroundImage = My.Resources.Resources.ChatGPT_Image_Apr_6__2026__08_13_50_PM
		TabPage2.BackgroundImageLayout = ImageLayout.Stretch
		TabPage2.Controls.Add(tbEmail)
		TabPage2.Controls.Add(tbAlamat)
		TabPage2.Controls.Add(mtbNomor)
		TabPage2.Controls.Add(Label8)
		TabPage2.Controls.Add(Label7)
		TabPage2.Controls.Add(Label6)
		TabPage2.Location = New Point(4, 29)
		TabPage2.Name = "TabPage2"
		TabPage2.Padding = New Padding(3)
		TabPage2.Size = New Size(665, 296)
		TabPage2.TabIndex = 1
		TabPage2.Text = "Kontak & Info"
		TabPage2.UseVisualStyleBackColor = True
		' 
		' tbEmail
		' 
		tbEmail.BackColor = SystemColors.Info
		tbEmail.Location = New Point(332, 120)
		tbEmail.Name = "tbEmail"
		tbEmail.Size = New Size(187, 27)
		tbEmail.TabIndex = 6
		' 
		' tbAlamat
		' 
		tbAlamat.BackColor = SystemColors.ScrollBar
		tbAlamat.Location = New Point(332, 174)
		tbAlamat.Name = "tbAlamat"
		tbAlamat.Size = New Size(187, 27)
		tbAlamat.TabIndex = 5
		' 
		' mtbNomor
		' 
		mtbNomor.BackColor = SystemColors.InactiveCaption
		mtbNomor.Location = New Point(332, 71)
		mtbNomor.Mask = "0000-0000-0000"
		mtbNomor.Name = "mtbNomor"
		mtbNomor.Size = New Size(187, 27)
		mtbNomor.TabIndex = 3
		' 
		' Label8
		' 
		Label8.AutoSize = True
		Label8.BackColor = Color.LemonChiffon
		Label8.Location = New Point(163, 177)
		Label8.Name = "Label8"
		Label8.Size = New Size(57, 20)
		Label8.TabIndex = 2
		Label8.Text = "Alamat"
		' 
		' Label7
		' 
		Label7.AutoSize = True
		Label7.BackColor = Color.AliceBlue
		Label7.Location = New Point(163, 123)
		Label7.Name = "Label7"
		Label7.Size = New Size(46, 20)
		Label7.TabIndex = 1
		Label7.Text = "Email"
		' 
		' Label6
		' 
		Label6.AutoSize = True
		Label6.BackColor = Color.Pink
		Label6.Location = New Point(163, 74)
		Label6.Name = "Label6"
		Label6.Size = New Size(113, 20)
		Label6.TabIndex = 0
		Label6.Text = "Nomor Telepon"
		' 
		' TabPage3
		' 
		TabPage3.BackColor = Color.SteelBlue
		TabPage3.BackgroundImageLayout = ImageLayout.Stretch
		TabPage3.Controls.Add(GroupBox2)
		TabPage3.Controls.Add(Button2)
		TabPage3.Controls.Add(GroupBox1)
		TabPage3.Controls.Add(Button1)
		TabPage3.Controls.Add(PictureBox1)
		TabPage3.Location = New Point(4, 29)
		TabPage3.Name = "TabPage3"
		TabPage3.Padding = New Padding(3)
		TabPage3.Size = New Size(665, 296)
		TabPage3.TabIndex = 2
		TabPage3.Text = "Profil & Aktivitas"
		' 
		' GroupBox2
		' 
		GroupBox2.BackColor = Color.BurlyWood
		GroupBox2.Controls.Add(cbVolunteer)
		GroupBox2.Controls.Add(cbVideografi)
		GroupBox2.Controls.Add(cbFotografi)
		GroupBox2.Controls.Add(cbCityTour)
		GroupBox2.Controls.Add(cbKuliner)
		GroupBox2.Controls.Add(cbTrekking)
		GroupBox2.Controls.Add(cbStaycation)
		GroupBox2.Controls.Add(cbCamping)
		GroupBox2.Controls.Add(cbHiking)
		GroupBox2.Controls.Add(cbBackpacking)
		GroupBox2.Controls.Add(cbSnorkeling)
		GroupBox2.Location = New Point(140, 135)
		GroupBox2.Name = "GroupBox2"
		GroupBox2.Size = New Size(503, 140)
		GroupBox2.TabIndex = 4
		GroupBox2.TabStop = False
		GroupBox2.Text = "Minat"
		' 
		' cbVolunteer
		' 
		cbVolunteer.AutoSize = True
		cbVolunteer.Location = New Point(371, 50)
		cbVolunteer.Name = "cbVolunteer"
		cbVolunteer.Size = New Size(94, 24)
		cbVolunteer.TabIndex = 24
		cbVolunteer.Text = "Volunteer"
		cbVolunteer.UseVisualStyleBackColor = True
		' 
		' cbVideografi
		' 
		cbVideografi.AutoSize = True
		cbVideografi.Location = New Point(237, 50)
		cbVideografi.Name = "cbVideografi"
		cbVideografi.Size = New Size(101, 24)
		cbVideografi.TabIndex = 23
		cbVideografi.Text = "Videografi"
		cbVideografi.UseVisualStyleBackColor = True
		' 
		' cbFotografi
		' 
		cbFotografi.AutoSize = True
		cbFotografi.Location = New Point(237, 20)
		cbFotografi.Name = "cbFotografi"
		cbFotografi.Size = New Size(92, 24)
		cbFotografi.TabIndex = 22
		cbFotografi.Text = "Fotografi"
		cbFotografi.UseVisualStyleBackColor = True
		' 
		' cbCityTour
		' 
		cbCityTour.AutoSize = True
		cbCityTour.Location = New Point(121, 50)
		cbCityTour.Name = "cbCityTour"
		cbCityTour.Size = New Size(89, 24)
		cbCityTour.TabIndex = 21
		cbCityTour.Text = "City Tour"
		cbCityTour.UseVisualStyleBackColor = True
		' 
		' cbKuliner
		' 
		cbKuliner.AutoSize = True
		cbKuliner.Location = New Point(121, 20)
		cbKuliner.Name = "cbKuliner"
		cbKuliner.Size = New Size(77, 24)
		cbKuliner.TabIndex = 20
		cbKuliner.Text = "Kuliner"
		cbKuliner.UseVisualStyleBackColor = True
		' 
		' cbTrekking
		' 
		cbTrekking.AutoSize = True
		cbTrekking.Location = New Point(6, 80)
		cbTrekking.Name = "cbTrekking"
		cbTrekking.Size = New Size(86, 24)
		cbTrekking.TabIndex = 5
		cbTrekking.Text = "Trekking"
		cbTrekking.UseVisualStyleBackColor = True
		' 
		' cbStaycation
		' 
		cbStaycation.AutoSize = True
		cbStaycation.Location = New Point(121, 80)
		cbStaycation.Name = "cbStaycation"
		cbStaycation.Size = New Size(100, 24)
		cbStaycation.TabIndex = 19
		cbStaycation.Text = "Staycation"
		cbStaycation.UseVisualStyleBackColor = True
		' 
		' cbCamping
		' 
		cbCamping.AutoSize = True
		cbCamping.Location = New Point(6, 50)
		cbCamping.Name = "cbCamping"
		cbCamping.Size = New Size(91, 24)
		cbCamping.TabIndex = 16
		cbCamping.Text = "Camping"
		cbCamping.UseVisualStyleBackColor = True
		' 
		' cbHiking
		' 
		cbHiking.AutoSize = True
		cbHiking.Location = New Point(6, 20)
		cbHiking.Name = "cbHiking"
		cbHiking.Size = New Size(74, 24)
		cbHiking.TabIndex = 15
		cbHiking.Text = "Hiking"
		cbHiking.UseVisualStyleBackColor = True
		' 
		' cbBackpacking
		' 
		cbBackpacking.AutoSize = True
		cbBackpacking.Location = New Point(371, 20)
		cbBackpacking.Name = "cbBackpacking"
		cbBackpacking.Size = New Size(114, 24)
		cbBackpacking.TabIndex = 13
		cbBackpacking.Text = "Backpacking"
		cbBackpacking.UseVisualStyleBackColor = True
		' 
		' cbSnorkeling
		' 
		cbSnorkeling.AutoSize = True
		cbSnorkeling.Location = New Point(6, 110)
		cbSnorkeling.Name = "cbSnorkeling"
		cbSnorkeling.Size = New Size(101, 24)
		cbSnorkeling.TabIndex = 7
		cbSnorkeling.Text = "Snorkeling"
		cbSnorkeling.UseVisualStyleBackColor = True
		' 
		' Button2
		' 
		Button2.BackColor = Color.FromArgb(255, 255, 192)
		Button2.Location = New Point(35, 202)
		Button2.Name = "Button2"
		Button2.Size = New Size(86, 73)
		Button2.TabIndex = 3
		Button2.Text = "SIMPAN DAN CETAK KARTU"
		Button2.UseVisualStyleBackColor = False
		' 
		' GroupBox1
		' 
		GroupBox1.BackColor = Color.PaleGreen
		GroupBox1.Controls.Add(rbSekretaris)
		GroupBox1.Controls.Add(rbBendahara)
		GroupBox1.Controls.Add(rbMember)
		GroupBox1.Controls.Add(rbDokumentasi)
		GroupBox1.Controls.Add(rbKoordinator)
		GroupBox1.Controls.Add(rbAdmin)
		GroupBox1.Controls.Add(rbWakil)
		GroupBox1.Controls.Add(rbKetua)
		GroupBox1.Location = New Point(140, 34)
		GroupBox1.Name = "GroupBox1"
		GroupBox1.Size = New Size(497, 95)
		GroupBox1.TabIndex = 2
		GroupBox1.TabStop = False
		GroupBox1.Text = "Peran"
		' 
		' rbSekretaris
		' 
		rbSekretaris.AutoSize = True
		rbSekretaris.Location = New Point(391, 55)
		rbSekretaris.Name = "rbSekretaris"
		rbSekretaris.Size = New Size(94, 24)
		rbSekretaris.TabIndex = 15
		rbSekretaris.TabStop = True
		rbSekretaris.Text = "Sekretaris"
		rbSekretaris.UseVisualStyleBackColor = True
		' 
		' rbBendahara
		' 
		rbBendahara.AutoSize = True
		rbBendahara.Location = New Point(391, 26)
		rbBendahara.Name = "rbBendahara"
		rbBendahara.Size = New Size(101, 24)
		rbBendahara.TabIndex = 14
		rbBendahara.TabStop = True
		rbBendahara.Text = "Bendahara"
		rbBendahara.UseVisualStyleBackColor = True
		' 
		' rbMember
		' 
		rbMember.AutoSize = True
		rbMember.Location = New Point(268, 55)
		rbMember.Name = "rbMember"
		rbMember.Size = New Size(86, 24)
		rbMember.TabIndex = 13
		rbMember.TabStop = True
		rbMember.Text = "Member"
		rbMember.UseVisualStyleBackColor = True
		' 
		' rbDokumentasi
		' 
		rbDokumentasi.AutoSize = True
		rbDokumentasi.Location = New Point(268, 25)
		rbDokumentasi.Name = "rbDokumentasi"
		rbDokumentasi.Size = New Size(117, 24)
		rbDokumentasi.TabIndex = 12
		rbDokumentasi.TabStop = True
		rbDokumentasi.Text = "Dokumentasi"
		rbDokumentasi.UseVisualStyleBackColor = True
		' 
		' rbKoordinator
		' 
		rbKoordinator.AutoSize = True
		rbKoordinator.Location = New Point(121, 55)
		rbKoordinator.Name = "rbKoordinator"
		rbKoordinator.Size = New Size(139, 24)
		rbKoordinator.TabIndex = 11
		rbKoordinator.TabStop = True
		rbKoordinator.Text = "Koordinator Trip"
		rbKoordinator.UseVisualStyleBackColor = True
		' 
		' rbAdmin
		' 
		rbAdmin.AutoSize = True
		rbAdmin.Location = New Point(121, 25)
		rbAdmin.Name = "rbAdmin"
		rbAdmin.Size = New Size(74, 24)
		rbAdmin.TabIndex = 10
		rbAdmin.TabStop = True
		rbAdmin.Text = "Admin"
		rbAdmin.UseVisualStyleBackColor = True
		' 
		' rbWakil
		' 
		rbWakil.AutoSize = True
		rbWakil.Location = New Point(6, 55)
		rbWakil.Name = "rbWakil"
		rbWakil.Size = New Size(108, 24)
		rbWakil.TabIndex = 9
		rbWakil.TabStop = True
		rbWakil.Text = "Wakil Ketua"
		rbWakil.UseVisualStyleBackColor = True
		' 
		' rbKetua
		' 
		rbKetua.AutoSize = True
		rbKetua.Location = New Point(6, 26)
		rbKetua.Name = "rbKetua"
		rbKetua.Size = New Size(68, 24)
		rbKetua.TabIndex = 8
		rbKetua.TabStop = True
		rbKetua.Text = "Ketua"
		rbKetua.UseVisualStyleBackColor = True
		' 
		' Button1
		' 
		Button1.BackColor = Color.FromArgb(128, 128, 255)
		Button1.Location = New Point(35, 167)
		Button1.Name = "Button1"
		Button1.Size = New Size(86, 29)
		Button1.TabIndex = 1
		Button1.Text = "BROWSE"
		Button1.UseVisualStyleBackColor = False
		' 
		' PictureBox1
		' 
		PictureBox1.BackColor = Color.RosyBrown
		PictureBox1.BorderStyle = BorderStyle.FixedSingle
		PictureBox1.Location = New Point(35, 34)
		PictureBox1.Name = "PictureBox1"
		PictureBox1.Size = New Size(86, 121)
		PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
		PictureBox1.TabIndex = 0
		PictureBox1.TabStop = False
		' 
		' Form1
		' 
		AutoScaleDimensions = New SizeF(8.0F, 20.0F)
		AutoScaleMode = AutoScaleMode.Font
		BackgroundImage = My.Resources.Resources.ChatGPT_Image_Apr_6__2026__07_43_28_PM
		BackgroundImageLayout = ImageLayout.Stretch
		ClientSize = New Size(800, 450)
		Controls.Add(TabControl1)
		Controls.Add(MenuStrip1)
		MainMenuStrip = MenuStrip1
		Name = "Form1"
		Text = "Form1"
		MenuStrip1.ResumeLayout(False)
		MenuStrip1.PerformLayout()
		TabControl1.ResumeLayout(False)
		TabPage1.ResumeLayout(False)
		TabPage1.PerformLayout()
		TabPage2.ResumeLayout(False)
		TabPage2.PerformLayout()
		TabPage3.ResumeLayout(False)
		GroupBox2.ResumeLayout(False)
		GroupBox2.PerformLayout()
		GroupBox1.ResumeLayout(False)
		GroupBox1.PerformLayout()
		CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
		ResumeLayout(False)
		PerformLayout()
	End Sub

	Friend WithEvents MenuStrip1 As MenuStrip
	Friend WithEvents SimpanDataToolStripMenuItem As ToolStripMenuItem
	Friend WithEvents InputDataToolStripMenuItem As ToolStripMenuItem
	Friend WithEvents LihatDataToolStripMenuItem As ToolStripMenuItem
	Friend WithEvents LihatKartuToolStripMenuItem As ToolStripMenuItem
	Friend WithEvents KeluarToolStripMenuItem As ToolStripMenuItem
	Friend WithEvents TabControl1 As TabControl
	Friend WithEvents TabPage1 As TabPage
	Friend WithEvents TabPage2 As TabPage
	Friend WithEvents TabPage3 As TabPage
	Friend WithEvents txtNama As TextBox
	Friend WithEvents RadioButton2 As RadioButton
	Friend WithEvents RadioButton1 As RadioButton
	Friend WithEvents Label3 As Label
	Friend WithEvents DateTimePicker1 As DateTimePicker
	Friend WithEvents Label2 As Label
	Friend WithEvents Label1 As Label
	Friend WithEvents TextBox2 As TextBox
	Friend WithEvents Label5 As Label
	Friend WithEvents ComboBox1 As ComboBox
	Friend WithEvents Label4 As Label
	Friend WithEvents tbAlamat As TextBox
	Friend WithEvents TextBox3 As TextBox
	Friend WithEvents mtbNomor As MaskedTextBox
	Friend WithEvents Label8 As Label
	Friend WithEvents Label7 As Label
	Friend WithEvents Label6 As Label
	Friend WithEvents GroupBox1 As GroupBox
	Friend WithEvents Button1 As Button
	Friend WithEvents PictureBox1 As PictureBox
	Friend WithEvents Button2 As Button
	Friend WithEvents GroupBox2 As GroupBox
	Friend WithEvents CheckBox9 As CheckBox
	Friend WithEvents CheckBox8 As CheckBox
	Friend WithEvents rbHiking As CheckBox
	Friend WithEvents CheckBox17 As CheckBox
	Friend WithEvents cbBackpacking As CheckBox
	Friend WithEvents CheckBox15 As CheckBox
	Friend WithEvents CheckBox14 As CheckBox
	Friend WithEvents CheckBox13 As CheckBox
	Friend WithEvents CheckBox12 As CheckBox
	Friend WithEvents CheckBox11 As CheckBox
	Friend WithEvents cbSnorkeling As CheckBox
	Friend WithEvents txtId As TextBox
	Friend WithEvents tbEmail As TextBox
	Friend WithEvents rbMember As RadioButton
	Friend WithEvents rbDokumentasi As RadioButton
	Friend WithEvents rbKoordinator As RadioButton
	Friend WithEvents rbAdmin As RadioButton
	Friend WithEvents rbWakil As RadioButton
	Friend WithEvents rbKetua As RadioButton
	Friend WithEvents rbSekretaris As RadioButton
	Friend WithEvents rbBendahara As RadioButton
	Friend WithEvents CheckBox5 As CheckBox
	Friend WithEvents CheckBox4 As CheckBox
	Friend WithEvents CheckBox3 As CheckBox
	Friend WithEvents cbCamping As CheckBox
	Friend WithEvents cbHiking As CheckBox
	Friend WithEvents cbStaycation As CheckBox
	Friend WithEvents cbKuliner As CheckBox
	Friend WithEvents cbTrekking As CheckBox
	Friend WithEvents cbCityTour As CheckBox
	Friend WithEvents cbFotografi As CheckBox
	Friend WithEvents cbVideografi As CheckBox
	Friend WithEvents cbVolunteer As CheckBox

End Class
