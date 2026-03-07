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
		GroupBox1 = New GroupBox()
		btnTambah = New Button()
		txtGenre = New TextBox()
		txtJudul = New TextBox()
		Label2 = New Label()
		Label1 = New Label()
		GroupBox2 = New GroupBox()
		btnHapus = New Button()
		txtHapus = New TextBox()
		Label3 = New Label()
		lstBuku = New ListBox()
		GroupBox1.SuspendLayout()
		GroupBox2.SuspendLayout()
		SuspendLayout()
		' 
		' GroupBox1
		' 
		GroupBox1.BackColor = Color.Honeydew
		GroupBox1.Controls.Add(btnTambah)
		GroupBox1.Controls.Add(txtGenre)
		GroupBox1.Controls.Add(txtJudul)
		GroupBox1.Controls.Add(Label2)
		GroupBox1.Controls.Add(Label1)
		GroupBox1.Font = New Font("Yu Gothic Medium", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
		GroupBox1.Location = New Point(48, 31)
		GroupBox1.Name = "GroupBox1"
		GroupBox1.Size = New Size(317, 173)
		GroupBox1.TabIndex = 0
		GroupBox1.TabStop = False
		GroupBox1.Text = "Tambah Buku"
		' 
		' btnTambah
		' 
		btnTambah.BackColor = SystemColors.Control
		btnTambah.Location = New Point(217, 138)
		btnTambah.Name = "btnTambah"
		btnTambah.Size = New Size(94, 29)
		btnTambah.TabIndex = 4
		btnTambah.Text = "Tambah"
		btnTambah.UseVisualStyleBackColor = False
		' 
		' txtGenre
		' 
		txtGenre.Location = New Point(144, 86)
		txtGenre.Name = "txtGenre"
		txtGenre.Size = New Size(125, 32)
		txtGenre.TabIndex = 3
		' 
		' txtJudul
		' 
		txtJudul.Location = New Point(144, 38)
		txtJudul.Name = "txtJudul"
		txtJudul.Size = New Size(125, 32)
		txtJudul.TabIndex = 2
		' 
		' Label2
		' 
		Label2.AutoSize = True
		Label2.Location = New Point(40, 93)
		Label2.Name = "Label2"
		Label2.Size = New Size(56, 19)
		Label2.TabIndex = 1
		Label2.Text = "Genre"
		' 
		' Label1
		' 
		Label1.AutoSize = True
		Label1.Location = New Point(40, 41)
		Label1.Name = "Label1"
		Label1.Size = New Size(96, 19)
		Label1.TabIndex = 0
		Label1.Text = "Judul Buku"
		' 
		' GroupBox2
		' 
		GroupBox2.BackColor = Color.Honeydew
		GroupBox2.Controls.Add(btnHapus)
		GroupBox2.Controls.Add(txtHapus)
		GroupBox2.Controls.Add(Label3)
		GroupBox2.Font = New Font("Yu Gothic Medium", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
		GroupBox2.Location = New Point(434, 31)
		GroupBox2.Name = "GroupBox2"
		GroupBox2.Size = New Size(324, 173)
		GroupBox2.TabIndex = 1
		GroupBox2.TabStop = False
		GroupBox2.Text = "Hapus Buku"
		' 
		' btnHapus
		' 
		btnHapus.BackColor = SystemColors.Control
		btnHapus.Location = New Point(224, 138)
		btnHapus.Name = "btnHapus"
		btnHapus.Size = New Size(94, 29)
		btnHapus.TabIndex = 2
		btnHapus.Text = "Hapus"
		btnHapus.UseVisualStyleBackColor = False
		' 
		' txtHapus
		' 
		txtHapus.Location = New Point(132, 63)
		txtHapus.Name = "txtHapus"
		txtHapus.Size = New Size(125, 32)
		txtHapus.TabIndex = 1
		' 
		' Label3
		' 
		Label3.AutoSize = True
		Label3.Location = New Point(27, 66)
		Label3.Name = "Label3"
		Label3.Size = New Size(96, 19)
		Label3.TabIndex = 0
		Label3.Text = "Judul Buku"
		' 
		' lstBuku
		' 
		lstBuku.BackColor = Color.MintCream
		lstBuku.Font = New Font("Yu Gothic Medium", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
		lstBuku.FormattingEnabled = True
		lstBuku.Location = New Point(235, 214)
		lstBuku.Name = "lstBuku"
		lstBuku.Size = New Size(332, 224)
		lstBuku.TabIndex = 2
		' 
		' Form1
		' 
		AutoScaleDimensions = New SizeF(8F, 20F)
		AutoScaleMode = AutoScaleMode.Font
		BackColor = Color.DarkSeaGreen
		BackgroundImage = My.Resources.Resources.pngimg_com___jungle_PNG32
		BackgroundImageLayout = ImageLayout.Stretch
		ClientSize = New Size(800, 450)
		Controls.Add(lstBuku)
		Controls.Add(GroupBox2)
		Controls.Add(GroupBox1)
		DoubleBuffered = True
		Name = "Form1"
		Text = "POSTTEST2_071"
		GroupBox1.ResumeLayout(False)
		GroupBox1.PerformLayout()
		GroupBox2.ResumeLayout(False)
		GroupBox2.PerformLayout()
		ResumeLayout(False)
	End Sub

	Friend WithEvents GroupBox1 As GroupBox
	Friend WithEvents GroupBox2 As GroupBox
	Friend WithEvents Label2 As Label
	Friend WithEvents Label1 As Label
	Friend WithEvents Label3 As Label
	Friend WithEvents txtGenre As TextBox
	Friend WithEvents txtJudul As TextBox
	Friend WithEvents txtHapus As TextBox
	Friend WithEvents btnTambah As Button
	Friend WithEvents btnHapus As Button
	Friend WithEvents lstBuku As ListBox

End Class
