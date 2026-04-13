<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
		Label1 = New Label()
		Label2 = New Label()
		Label3 = New Label()
		Label4 = New Label()
		txtNamaWebsite = New TextBox()
		txtUrl = New TextBox()
		txtCatatan = New TextBox()
		cboKategori = New ComboBox()
		btnBatal = New Button()
		btnSimpan = New Button()
		Label5 = New Label()
		SuspendLayout()
		' 
		' Label1
		' 
		Label1.AutoSize = True
		Label1.BackColor = Color.RosyBrown
		Label1.Font = New Font("Sylfaen", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
		Label1.Location = New Point(121, 87)
		Label1.Name = "Label1"
		Label1.Size = New Size(140, 26)
		Label1.TabIndex = 0
		Label1.Text = "Nama Website"
		' 
		' Label2
		' 
		Label2.AutoSize = True
		Label2.BackColor = Color.DarkSalmon
		Label2.Font = New Font("Sylfaen", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
		Label2.Location = New Point(211, 152)
		Label2.Name = "Label2"
		Label2.Size = New Size(50, 26)
		Label2.TabIndex = 1
		Label2.Text = "URL"
		' 
		' Label3
		' 
		Label3.AutoSize = True
		Label3.BackColor = Color.DarkSeaGreen
		Label3.Font = New Font("Sylfaen", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
		Label3.Location = New Point(176, 207)
		Label3.Name = "Label3"
		Label3.Size = New Size(85, 26)
		Label3.TabIndex = 2
		Label3.Text = "Kategori"
		' 
		' Label4
		' 
		Label4.AutoSize = True
		Label4.BackColor = SystemColors.GradientActiveCaption
		Label4.Font = New Font("Sylfaen", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
		Label4.Location = New Point(180, 276)
		Label4.Name = "Label4"
		Label4.Size = New Size(81, 26)
		Label4.TabIndex = 3
		Label4.Text = "Catatan"
		' 
		' txtNamaWebsite
		' 
		txtNamaWebsite.BackColor = Color.Beige
		txtNamaWebsite.Font = New Font("Verdana", 10.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
		txtNamaWebsite.Location = New Point(267, 88)
		txtNamaWebsite.Name = "txtNamaWebsite"
		txtNamaWebsite.Size = New Size(388, 29)
		txtNamaWebsite.TabIndex = 5
		' 
		' txtUrl
		' 
		txtUrl.BackColor = Color.Gainsboro
		txtUrl.Font = New Font("Verdana", 10.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
		txtUrl.Location = New Point(267, 153)
		txtUrl.Name = "txtUrl"
		txtUrl.Size = New Size(388, 29)
		txtUrl.TabIndex = 6
		' 
		' txtCatatan
		' 
		txtCatatan.BackColor = Color.LightCyan
		txtCatatan.Font = New Font("Verdana", 10.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
		txtCatatan.Location = New Point(267, 277)
		txtCatatan.Multiline = True
		txtCatatan.Name = "txtCatatan"
		txtCatatan.Size = New Size(388, 81)
		txtCatatan.TabIndex = 7
		' 
		' cboKategori
		' 
		cboKategori.BackColor = Color.MintCream
		cboKategori.Font = New Font("Verdana", 10.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
		cboKategori.FormattingEnabled = True
		cboKategori.Location = New Point(267, 208)
		cboKategori.Name = "cboKategori"
		cboKategori.Size = New Size(388, 30)
		cboKategori.TabIndex = 8
		' 
		' btnBatal
		' 
		btnBatal.BackColor = Color.LightSalmon
		btnBatal.Location = New Point(472, 393)
		btnBatal.Name = "btnBatal"
		btnBatal.Size = New Size(128, 29)
		btnBatal.TabIndex = 9
		btnBatal.Text = "Batal"
		btnBatal.UseVisualStyleBackColor = False
		' 
		' btnSimpan
		' 
		btnSimpan.BackColor = Color.PaleGreen
		btnSimpan.Location = New Point(606, 393)
		btnSimpan.Name = "btnSimpan"
		btnSimpan.Size = New Size(120, 29)
		btnSimpan.TabIndex = 10
		btnSimpan.Text = "Simpan"
		btnSimpan.UseVisualStyleBackColor = False
		' 
		' Label5
		' 
		Label5.AutoSize = True
		Label5.BackColor = Color.Snow
		Label5.Font = New Font("Sylfaen", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
		Label5.Location = New Point(249, 19)
		Label5.Name = "Label5"
		Label5.Size = New Size(351, 44)
		Label5.TabIndex = 11
		Label5.Text = "Catat Website Favorit"
		' 
		' Form2
		' 
		AutoScaleDimensions = New SizeF(8F, 20F)
		AutoScaleMode = AutoScaleMode.Font
		BackColor = SystemColors.ActiveCaption
		BackgroundImage = My.Resources.Resources.ghvghvgv
		BackgroundImageLayout = ImageLayout.Stretch
		ClientSize = New Size(800, 450)
		Controls.Add(Label5)
		Controls.Add(btnSimpan)
		Controls.Add(btnBatal)
		Controls.Add(cboKategori)
		Controls.Add(txtCatatan)
		Controls.Add(txtUrl)
		Controls.Add(txtNamaWebsite)
		Controls.Add(Label4)
		Controls.Add(Label3)
		Controls.Add(Label2)
		Controls.Add(Label1)
		Name = "Form2"
		Text = "Form2"
		ResumeLayout(False)
		PerformLayout()
	End Sub

	Friend WithEvents Label1 As Label
	Friend WithEvents Label2 As Label
	Friend WithEvents Label3 As Label
	Friend WithEvents Label4 As Label
	Friend WithEvents txtNamaWebsite As TextBox
	Friend WithEvents txtUrl As TextBox
	Friend WithEvents txtCatatan As TextBox
	Friend WithEvents cboKategori As ComboBox
	Friend WithEvents btnBatal As Button
	Friend WithEvents btnSimpan As Button
	Friend WithEvents Label5 As Label
End Class
