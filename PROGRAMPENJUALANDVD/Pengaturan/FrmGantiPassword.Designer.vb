<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmGantiPassword
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
        Me.Label4 = New System.Windows.Forms.Label
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.txtkonfirmasipassword = New System.Windows.Forms.TextBox
        Me.btnkeluar = New System.Windows.Forms.Button
        Me.btnsimpan = New System.Windows.Forms.Button
        Me.txtpasswordlama = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.txtpasswordbaru = New System.Windows.Forms.TextBox
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.Cyan
        Me.Label4.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label4.Font = New System.Drawing.Font("Algerian", 25.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte), True)
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(0, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(417, 47)
        Me.Label4.TabIndex = 177
        Me.Label4.Text = "GANTI PASSWORD"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Cyan
        Me.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.txtkonfirmasipassword)
        Me.Panel1.Controls.Add(Me.btnkeluar)
        Me.Panel1.Controls.Add(Me.btnsimpan)
        Me.Panel1.Controls.Add(Me.txtpasswordlama)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.txtpasswordbaru)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 47)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(417, 135)
        Me.Panel1.TabIndex = 178
        Me.Panel1.TabStop = True
        '
        'txtkonfirmasipassword
        '
        Me.txtkonfirmasipassword.BackColor = System.Drawing.Color.White
        Me.txtkonfirmasipassword.Location = New System.Drawing.Point(193, 73)
        Me.txtkonfirmasipassword.Name = "txtkonfirmasipassword"
        Me.txtkonfirmasipassword.Size = New System.Drawing.Size(203, 20)
        Me.txtkonfirmasipassword.TabIndex = 191
        '
        'btnkeluar
        '
        Me.btnkeluar.BackColor = System.Drawing.Color.Cyan
        Me.btnkeluar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnkeluar.ForeColor = System.Drawing.Color.Black
        Me.btnkeluar.Location = New System.Drawing.Point(273, 102)
        Me.btnkeluar.Name = "btnkeluar"
        Me.btnkeluar.Size = New System.Drawing.Size(75, 23)
        Me.btnkeluar.TabIndex = 190
        Me.btnkeluar.Text = "KELUAR"
        Me.btnkeluar.UseVisualStyleBackColor = False
        '
        'btnsimpan
        '
        Me.btnsimpan.BackColor = System.Drawing.Color.Cyan
        Me.btnsimpan.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnsimpan.ForeColor = System.Drawing.Color.Black
        Me.btnsimpan.Location = New System.Drawing.Point(192, 102)
        Me.btnsimpan.Name = "btnsimpan"
        Me.btnsimpan.Size = New System.Drawing.Size(75, 23)
        Me.btnsimpan.TabIndex = 187
        Me.btnsimpan.Text = "SIMPAN"
        Me.btnsimpan.UseVisualStyleBackColor = False
        '
        'txtpasswordlama
        '
        Me.txtpasswordlama.BackColor = System.Drawing.Color.White
        Me.txtpasswordlama.ForeColor = System.Drawing.Color.Black
        Me.txtpasswordlama.Location = New System.Drawing.Point(192, 14)
        Me.txtpasswordlama.Name = "txtpasswordlama"
        Me.txtpasswordlama.Size = New System.Drawing.Size(203, 20)
        Me.txtpasswordlama.TabIndex = 179
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(17, 76)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(158, 13)
        Me.Label1.TabIndex = 186
        Me.Label1.Text = "KONFIRMASI PASSWORD"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(17, 17)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(115, 13)
        Me.Label2.TabIndex = 178
        Me.Label2.Text = "PASSWORD LAMA"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(17, 43)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(116, 13)
        Me.Label3.TabIndex = 180
        Me.Label3.Text = "PASSWORD BARU"
        '
        'txtpasswordbaru
        '
        Me.txtpasswordbaru.BackColor = System.Drawing.Color.White
        Me.txtpasswordbaru.Location = New System.Drawing.Point(191, 41)
        Me.txtpasswordbaru.Name = "txtpasswordbaru"
        Me.txtpasswordbaru.Size = New System.Drawing.Size(203, 20)
        Me.txtpasswordbaru.TabIndex = 181
        '
        'FrmGantiPassword
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(417, 181)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label4)
        Me.Name = "FrmGantiPassword"
        Me.Text = "FrmGantiPassword"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents txtkonfirmasipassword As System.Windows.Forms.TextBox
    Friend WithEvents btnkeluar As System.Windows.Forms.Button
    Friend WithEvents btnsimpan As System.Windows.Forms.Button
    Friend WithEvents txtpasswordlama As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtpasswordbaru As System.Windows.Forms.TextBox
End Class
