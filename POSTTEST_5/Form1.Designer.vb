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
		Label1 = New Label()
		txtCari = New TextBox()
		dgvData = New DataGridView()
		btnTambah = New Button()
		btnEdit = New Button()
		btnHapus = New Button()
		CType(dgvData, ComponentModel.ISupportInitialize).BeginInit()
		SuspendLayout()
		' 
		' Label1
		' 
		Label1.AutoSize = True
		Label1.BackColor = Color.MistyRose
		Label1.Location = New Point(28, 9)
		Label1.Name = "Label1"
		Label1.Size = New Size(52, 20)
		Label1.TabIndex = 0
		Label1.Text = "CARI  :"
		' 
		' txtCari
		' 
		txtCari.BackColor = Color.MistyRose
		txtCari.BorderStyle = BorderStyle.FixedSingle
		txtCari.Location = New Point(95, 6)
		txtCari.Name = "txtCari"
		txtCari.Size = New Size(676, 27)
		txtCari.TabIndex = 1
		' 
		' dgvData
		' 
		dgvData.BackgroundColor = Color.Thistle
		dgvData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
		dgvData.Location = New Point(28, 51)
		dgvData.Name = "dgvData"
		dgvData.RowHeadersWidth = 51
		dgvData.Size = New Size(743, 320)
		dgvData.TabIndex = 2
		' 
		' btnTambah
		' 
		btnTambah.BackColor = Color.YellowGreen
		btnTambah.Location = New Point(660, 399)
		btnTambah.Name = "btnTambah"
		btnTambah.Size = New Size(94, 29)
		btnTambah.TabIndex = 3
		btnTambah.Text = "Tambah"
		btnTambah.UseVisualStyleBackColor = False
		' 
		' btnEdit
		' 
		btnEdit.BackColor = Color.LightSkyBlue
		btnEdit.Location = New Point(341, 399)
		btnEdit.Name = "btnEdit"
		btnEdit.Size = New Size(94, 29)
		btnEdit.TabIndex = 4
		btnEdit.Text = "Edit"
		btnEdit.UseVisualStyleBackColor = False
		' 
		' btnHapus
		' 
		btnHapus.BackColor = Color.LightCoral
		btnHapus.Location = New Point(47, 399)
		btnHapus.Name = "btnHapus"
		btnHapus.Size = New Size(94, 29)
		btnHapus.TabIndex = 5
		btnHapus.Text = "Hapus"
		btnHapus.UseVisualStyleBackColor = False
		' 
		' Form1
		' 
		AutoScaleDimensions = New SizeF(8F, 20F)
		AutoScaleMode = AutoScaleMode.Font
		BackgroundImage = My.Resources.Resources.ghvghvgv
		BackgroundImageLayout = ImageLayout.Stretch
		ClientSize = New Size(800, 450)
		Controls.Add(btnHapus)
		Controls.Add(btnEdit)
		Controls.Add(btnTambah)
		Controls.Add(dgvData)
		Controls.Add(txtCari)
		Controls.Add(Label1)
		Name = "Form1"
		Text = "Form1"
		CType(dgvData, ComponentModel.ISupportInitialize).EndInit()
		ResumeLayout(False)
		PerformLayout()
	End Sub

	Friend WithEvents Label1 As Label
	Friend WithEvents txtCari As TextBox
	Friend WithEvents dgvData As DataGridView
	Friend WithEvents btnTambah As Button
	Friend WithEvents btnEdit As Button
	Friend WithEvents btnHapus As Button

End Class
