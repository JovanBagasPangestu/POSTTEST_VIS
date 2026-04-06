<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormKartu
	Inherits System.Windows.Forms.Form

	'Form overrides dispose to clean up the component list.
	<System.Diagnostics.DebuggerNonUserCode()> _
	Protected Overrides Sub Dispose(ByVal disposing As Boolean)
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
	<System.Diagnostics.DebuggerStepThrough()> _
	Private Sub InitializeComponent()
		PictureBox1 = New PictureBox()
		Label1 = New Label()
		Label2 = New Label()
		Label3 = New Label()
		Label4 = New Label()
		Label5 = New Label()
		lblKomunitas = New Label()
		lblKontak = New Label()
		lblAktivitas = New Label()
		lblNama = New Label()
		lblID = New Label()
		Label8 = New Label()
		Label9 = New Label()
		Label10 = New Label()
		Label11 = New Label()
		Label12 = New Label()
		Label13 = New Label()
		Label14 = New Label()
		lblPeran = New Label()
		Label15 = New Label()
		Panel1 = New Panel()
		CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
		SuspendLayout()
		' 
		' PictureBox1
		' 
		PictureBox1.BackColor = Color.Transparent
		PictureBox1.BorderStyle = BorderStyle.Fixed3D
		PictureBox1.Location = New Point(45, 116)
		PictureBox1.Name = "PictureBox1"
		PictureBox1.Size = New Size(189, 249)
		PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
		PictureBox1.TabIndex = 0
		PictureBox1.TabStop = False
		' 
		' Label1
		' 
		Label1.AutoSize = True
		Label1.BackColor = Color.RosyBrown
		Label1.Font = New Font("Segoe Script", 12.0F, FontStyle.Bold)
		Label1.Location = New Point(274, 98)
		Label1.Name = "Label1"
		Label1.Size = New Size(76, 33)
		Label1.TabIndex = 1
		Label1.Text = "Nama"
		' 
		' Label2
		' 
		Label2.AutoSize = True
		Label2.BackColor = Color.FromArgb(CByte(128), CByte(255), CByte(128))
		Label2.Font = New Font("Segoe Script", 12.0F, FontStyle.Bold)
		Label2.Location = New Point(274, 148)
		Label2.Name = "Label2"
		Label2.Size = New Size(38, 33)
		Label2.TabIndex = 2
		Label2.Text = "ID"
		' 
		' Label3
		' 
		Label3.AutoSize = True
		Label3.BackColor = Color.FromArgb(CByte(128), CByte(128), CByte(255))
		Label3.Font = New Font("Segoe Script", 12.0F, FontStyle.Bold)
		Label3.Location = New Point(274, 203)
		Label3.Name = "Label3"
		Label3.Size = New Size(131, 33)
		Label3.TabIndex = 3
		Label3.Text = "Komunitas"
		' 
		' Label4
		' 
		Label4.AutoSize = True
		Label4.BackColor = Color.FromArgb(CByte(255), CByte(192), CByte(128))
		Label4.Font = New Font("Segoe Script", 12.0F, FontStyle.Bold)
		Label4.Location = New Point(274, 256)
		Label4.Name = "Label4"
		Label4.Size = New Size(90, 33)
		Label4.TabIndex = 4
		Label4.Text = "Kontak"
		' 
		' Label5
		' 
		Label5.AutoSize = True
		Label5.BackColor = Color.FromArgb(CByte(255), CByte(128), CByte(255))
		Label5.Font = New Font("Segoe Script", 12.0F, FontStyle.Bold)
		Label5.Location = New Point(274, 305)
		Label5.Name = "Label5"
		Label5.Size = New Size(114, 33)
		Label5.TabIndex = 5
		Label5.Text = "Aktivitas"
		' 
		' lblKomunitas
		' 
		lblKomunitas.AutoSize = True
		lblKomunitas.BackColor = Color.MistyRose
		lblKomunitas.Font = New Font("Segoe Script", 12.0F, FontStyle.Bold)
		lblKomunitas.Location = New Point(414, 203)
		lblKomunitas.Name = "lblKomunitas"
		lblKomunitas.Size = New Size(87, 33)
		lblKomunitas.TabIndex = 8
		lblKomunitas.Text = "Label8"
		' 
		' lblKontak
		' 
		lblKontak.AutoSize = True
		lblKontak.BackColor = Color.LightSteelBlue
		lblKontak.Font = New Font("Segoe Script", 12.0F, FontStyle.Bold)
		lblKontak.Location = New Point(414, 256)
		lblKontak.Name = "lblKontak"
		lblKontak.Size = New Size(87, 33)
		lblKontak.TabIndex = 9
		lblKontak.Text = "Label9"
		' 
		' lblAktivitas
		' 
		lblAktivitas.BackColor = Color.Khaki
		lblAktivitas.Font = New Font("Segoe Script", 12.0F, FontStyle.Bold)
		lblAktivitas.Location = New Point(414, 305)
		lblAktivitas.Name = "lblAktivitas"
		lblAktivitas.Size = New Size(374, 136)
		lblAktivitas.TabIndex = 10
		lblAktivitas.Text = "Label10"
		' 
		' lblNama
		' 
		lblNama.AutoSize = True
		lblNama.BackColor = Color.LavenderBlush
		lblNama.Font = New Font("Segoe Script", 12.0F, FontStyle.Bold)
		lblNama.Location = New Point(414, 98)
		lblNama.Name = "lblNama"
		lblNama.Size = New Size(87, 33)
		lblNama.TabIndex = 11
		lblNama.Text = "Label8"
		' 
		' lblID
		' 
		lblID.AutoSize = True
		lblID.BackColor = Color.Moccasin
		lblID.Font = New Font("Segoe Script", 12.0F, FontStyle.Bold)
		lblID.Location = New Point(414, 148)
		lblID.Name = "lblID"
		lblID.Size = New Size(102, 33)
		lblID.TabIndex = 12
		lblID.Text = "Label11"
		' 
		' Label8
		' 
		Label8.AutoSize = True
		Label8.BackColor = Color.Transparent
		Label8.Font = New Font("Segoe Script", 12.0F, FontStyle.Bold)
		Label8.Location = New Point(396, 98)
		Label8.Name = "Label8"
		Label8.Size = New Size(21, 33)
		Label8.TabIndex = 13
		Label8.Text = ":"
		' 
		' Label9
		' 
		Label9.AutoSize = True
		Label9.BackColor = Color.Transparent
		Label9.Font = New Font("Segoe Script", 12.0F, FontStyle.Bold)
		Label9.Location = New Point(396, 148)
		Label9.Name = "Label9"
		Label9.Size = New Size(21, 33)
		Label9.TabIndex = 14
		Label9.Text = ":"
		' 
		' Label10
		' 
		Label10.AutoSize = True
		Label10.BackColor = Color.Transparent
		Label10.Font = New Font("Segoe Script", 12.0F, FontStyle.Bold)
		Label10.Location = New Point(396, 203)
		Label10.Name = "Label10"
		Label10.Size = New Size(21, 33)
		Label10.TabIndex = 15
		Label10.Text = ":"
		' 
		' Label11
		' 
		Label11.AutoSize = True
		Label11.BackColor = Color.Transparent
		Label11.Font = New Font("Segoe Script", 12.0F, FontStyle.Bold)
		Label11.Location = New Point(396, 256)
		Label11.Name = "Label11"
		Label11.Size = New Size(21, 33)
		Label11.TabIndex = 16
		Label11.Text = ":"
		' 
		' Label12
		' 
		Label12.AutoSize = True
		Label12.BackColor = Color.Transparent
		Label12.Font = New Font("Segoe Script", 12.0F, FontStyle.Bold)
		Label12.Location = New Point(396, 305)
		Label12.Name = "Label12"
		Label12.Size = New Size(21, 33)
		Label12.TabIndex = 17
		Label12.Text = ":"
		' 
		' Label13
		' 
		Label13.AutoSize = True
		Label13.BackColor = Color.FromArgb(CByte(128), CByte(255), CByte(255))
		Label13.Font = New Font("Segoe Script", 12.0F, FontStyle.Bold)
		Label13.Location = New Point(30, 388)
		Label13.Name = "Label13"
		Label13.Size = New Size(78, 33)
		Label13.TabIndex = 18
		Label13.Text = "Peran"
		' 
		' Label14
		' 
		Label14.AutoSize = True
		Label14.BackColor = Color.Transparent
		Label14.Font = New Font("Segoe Script", 12.0F, FontStyle.Bold)
		Label14.Location = New Point(114, 388)
		Label14.Name = "Label14"
		Label14.Size = New Size(21, 33)
		Label14.TabIndex = 19
		Label14.Text = ":"
		' 
		' lblPeran
		' 
		lblPeran.AutoSize = True
		lblPeran.BackColor = Color.DarkSalmon
		lblPeran.Font = New Font("Segoe Script", 12.0F, FontStyle.Bold)
		lblPeran.Location = New Point(151, 388)
		lblPeran.Name = "lblPeran"
		lblPeran.Size = New Size(102, 33)
		lblPeran.TabIndex = 20
		lblPeran.Text = "Label15"
		' 
		' Label15
		' 
		Label15.AutoSize = True
		Label15.BackColor = Color.MediumAquamarine
		Label15.Font = New Font("Viner Hand ITC", 16.2F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
		Label15.Location = New Point(93, 18)
		Label15.Name = "Label15"
		Label15.Size = New Size(589, 45)
		Label15.TabIndex = 21
		Label15.Text = "Jejak Nusantara – Explore Your Journey"
		' 
		' Panel1
		' 
		Panel1.BackgroundImage = My.Resources.Resources.ChatGPT_Image_Apr_6__2026__07_38_45_PM
		Panel1.BackgroundImageLayout = ImageLayout.Stretch
		Panel1.Location = New Point(709, 3)
		Panel1.Name = "Panel1"
		Panel1.Size = New Size(89, 77)
		Panel1.TabIndex = 22
		' 
		' FormKartu
		' 
		AutoScaleDimensions = New SizeF(8.0F, 20.0F)
		AutoScaleMode = AutoScaleMode.Font
		BackgroundImage = My.Resources.Resources.ChatGPT_Image_Apr_6__2026__07_43_28_PM
		BackgroundImageLayout = ImageLayout.Center
		ClientSize = New Size(800, 450)
		Controls.Add(Label15)
		Controls.Add(lblPeran)
		Controls.Add(Label14)
		Controls.Add(Label13)
		Controls.Add(Label12)
		Controls.Add(Label11)
		Controls.Add(Label10)
		Controls.Add(Label9)
		Controls.Add(Label8)
		Controls.Add(lblID)
		Controls.Add(lblNama)
		Controls.Add(lblAktivitas)
		Controls.Add(lblKontak)
		Controls.Add(lblKomunitas)
		Controls.Add(Label5)
		Controls.Add(Label4)
		Controls.Add(Label3)
		Controls.Add(Label2)
		Controls.Add(Label1)
		Controls.Add(PictureBox1)
		Controls.Add(Panel1)
		Name = "FormKartu"
		Text = "FormKartu"
		CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
		ResumeLayout(False)
		PerformLayout()
	End Sub

	Friend WithEvents PictureBox1 As PictureBox
	Friend WithEvents Label1 As Label
	Friend WithEvents Label2 As Label
	Friend WithEvents Label3 As Label
	Friend WithEvents Label4 As Label
	Friend WithEvents Label5 As Label
	Friend WithEvents Label6 As Label
	Friend WithEvents Label7 As Label
	Friend WithEvents lblKomunitas As Label
	Friend WithEvents lblKontak As Label
	Friend WithEvents lblAktivitas As Label
	Friend WithEvents lblNama As Label
	Friend WithEvents lblID As Label
	Friend WithEvents Label8 As Label
	Friend WithEvents Label9 As Label
	Friend WithEvents Label10 As Label
	Friend WithEvents Label11 As Label
	Friend WithEvents Label12 As Label
	Friend WithEvents Label13 As Label
	Friend WithEvents Label14 As Label
	Friend WithEvents lblPeran As Label
	Friend WithEvents Label15 As Label
	Friend WithEvents Panel1 As Panel
End Class
