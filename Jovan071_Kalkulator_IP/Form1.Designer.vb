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
		Label2 = New Label()
		btnTambah = New Button()
		Button2 = New Button()
		TextBox1 = New TextBox()
		TextBox2 = New TextBox()
		Label3 = New Label()
		Label4 = New Label()
		SuspendLayout()
		' 
		' Label1
		' 
		Label1.AutoSize = True
		Label1.Location = New Point(226, 132)
		Label1.Name = "Label1"
		Label1.Size = New Size(86, 20)
		Label1.TabIndex = 0
		Label1.Text = "IP Semester"
		' 
		' Label2
		' 
		Label2.AutoSize = True
		Label2.Location = New Point(223, 221)
		Label2.Name = "Label2"
		Label2.Size = New Size(89, 20)
		Label2.TabIndex = 1
		Label2.Text = "IP Kumulatif"
		' 
		' btnTambah
		' 
		btnTambah.BackColor = Color.YellowGreen
		btnTambah.Location = New Point(336, 169)
		btnTambah.Name = "btnTambah"
		btnTambah.Size = New Size(77, 29)
		btnTambah.TabIndex = 2
		btnTambah.Text = "Tambah"
		btnTambah.UseVisualStyleBackColor = False
		' 
		' Button2
		' 
		Button2.BackColor = Color.Brown
		Button2.ForeColor = SystemColors.ButtonHighlight
		Button2.Location = New Point(431, 169)
		Button2.Name = "Button2"
		Button2.Size = New Size(74, 29)
		Button2.TabIndex = 3
		Button2.Text = "Reset"
		Button2.UseVisualStyleBackColor = False
		' 
		' TextBox1
		' 
		TextBox1.Location = New Point(336, 129)
		TextBox1.Name = "TextBox1"
		TextBox1.Size = New Size(114, 27)
		TextBox1.TabIndex = 4
		' 
		' TextBox2
		' 
		TextBox2.Location = New Point(336, 218)
		TextBox2.Name = "TextBox2"
		TextBox2.ReadOnly = True
		TextBox2.Size = New Size(114, 27)
		TextBox2.TabIndex = 5
		' 
		' Label3
		' 
		Label3.AutoSize = True
		Label3.Location = New Point(336, 260)
		Label3.Name = "Label3"
		Label3.Size = New Size(63, 20)
		Label3.TabIndex = 6
		Label3.Text = "Predikat"
		' 
		' Label4
		' 
		Label4.AutoSize = True
		Label4.BackColor = SystemColors.ButtonFace
		Label4.BorderStyle = BorderStyle.Fixed3D
		Label4.Font = New Font("Constantia", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
		Label4.Location = New Point(238, 44)
		Label4.Name = "Label4"
		Label4.Size = New Size(320, 43)
		Label4.TabIndex = 7
		Label4.Text = "KALKULATOR IPK"
		' 
		' Form1
		' 
		AutoScaleDimensions = New SizeF(8F, 20F)
		AutoScaleMode = AutoScaleMode.Font
		BackColor = SystemColors.ControlLight
		ClientSize = New Size(800, 450)
		Controls.Add(Label4)
		Controls.Add(Label3)
		Controls.Add(TextBox2)
		Controls.Add(TextBox1)
		Controls.Add(Button2)
		Controls.Add(btnTambah)
		Controls.Add(Label2)
		Controls.Add(Label1)
		Name = "Form1"
		Text = "Kalkulator Cek IPK"
		ResumeLayout(False)
		PerformLayout()
	End Sub

	Friend WithEvents Label1 As Label
	Friend WithEvents Label2 As Label
	Friend WithEvents btnTambah As Button
	Friend WithEvents Button2 As Button
	Friend WithEvents TextBox1 As TextBox
	Friend WithEvents TextBox2 As TextBox
	Friend WithEvents Label3 As Label
	Friend WithEvents Label4 As Label

End Class
