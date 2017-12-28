<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmPegawai
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
        Me.Label1 = New System.Windows.Forms.Label
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.combohakakses = New System.Windows.Forms.ComboBox
        Me.txtpassword = New System.Windows.Forms.TextBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.btnkeluar = New System.Windows.Forms.Button
        Me.btnhapus = New System.Windows.Forms.Button
        Me.btnubah = New System.Windows.Forms.Button
        Me.btntambah = New System.Windows.Forms.Button
        Me.txtkodepegawai = New System.Windows.Forms.TextBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.txtnamapegawai = New System.Windows.Forms.TextBox
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.txtCari = New System.Windows.Forms.TextBox
        Me.cmbCari = New System.Windows.Forms.ComboBox
        Me.dgv = New System.Windows.Forms.DataGridView
        Me.Panel1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgv, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Cyan
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label1.Font = New System.Drawing.Font("Algerian", 25.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte), True)
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(623, 54)
        Me.Label1.TabIndex = 177
        Me.Label1.Text = "PEGAWAI"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Cyan
        Me.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.combohakakses)
        Me.Panel1.Controls.Add(Me.txtpassword)
        Me.Panel1.Controls.Add(Me.Label9)
        Me.Panel1.Controls.Add(Me.btnkeluar)
        Me.Panel1.Controls.Add(Me.btnhapus)
        Me.Panel1.Controls.Add(Me.btnubah)
        Me.Panel1.Controls.Add(Me.btntambah)
        Me.Panel1.Controls.Add(Me.txtkodepegawai)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Controls.Add(Me.txtnamapegawai)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 54)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(623, 151)
        Me.Panel1.TabIndex = 178
        Me.Panel1.TabStop = True
        '
        'combohakakses
        '
        Me.combohakakses.BackColor = System.Drawing.Color.White
        Me.combohakakses.FormattingEnabled = True
        Me.combohakakses.Items.AddRange(New Object() {"ADMIN", "USER"})
        Me.combohakakses.Location = New System.Drawing.Point(137, 93)
        Me.combohakakses.Name = "combohakakses"
        Me.combohakakses.Size = New System.Drawing.Size(203, 21)
        Me.combohakakses.TabIndex = 194
        '
        'txtpassword
        '
        Me.txtpassword.BackColor = System.Drawing.Color.White
        Me.txtpassword.Location = New System.Drawing.Point(137, 65)
        Me.txtpassword.Name = "txtpassword"
        Me.txtpassword.Size = New System.Drawing.Size(203, 20)
        Me.txtpassword.TabIndex = 193
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(22, 69)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(78, 13)
        Me.Label9.TabIndex = 192
        Me.Label9.Text = "PASSWORD"
        '
        'btnkeluar
        '
        Me.btnkeluar.BackColor = System.Drawing.Color.Cyan
        Me.btnkeluar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnkeluar.ForeColor = System.Drawing.Color.Black
        Me.btnkeluar.Location = New System.Drawing.Point(270, 120)
        Me.btnkeluar.Name = "btnkeluar"
        Me.btnkeluar.Size = New System.Drawing.Size(75, 23)
        Me.btnkeluar.TabIndex = 190
        Me.btnkeluar.Text = "KELUAR"
        Me.btnkeluar.UseVisualStyleBackColor = False
        '
        'btnhapus
        '
        Me.btnhapus.BackColor = System.Drawing.Color.Cyan
        Me.btnhapus.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnhapus.ForeColor = System.Drawing.Color.Black
        Me.btnhapus.Location = New System.Drawing.Point(187, 120)
        Me.btnhapus.Name = "btnhapus"
        Me.btnhapus.Size = New System.Drawing.Size(75, 23)
        Me.btnhapus.TabIndex = 189
        Me.btnhapus.Text = "HAPUS"
        Me.btnhapus.UseVisualStyleBackColor = False
        '
        'btnubah
        '
        Me.btnubah.BackColor = System.Drawing.Color.Cyan
        Me.btnubah.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnubah.ForeColor = System.Drawing.Color.Black
        Me.btnubah.Location = New System.Drawing.Point(104, 120)
        Me.btnubah.Name = "btnubah"
        Me.btnubah.Size = New System.Drawing.Size(75, 23)
        Me.btnubah.TabIndex = 188
        Me.btnubah.Text = "UBAH"
        Me.btnubah.UseVisualStyleBackColor = False
        '
        'btntambah
        '
        Me.btntambah.BackColor = System.Drawing.Color.Cyan
        Me.btntambah.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btntambah.ForeColor = System.Drawing.Color.Black
        Me.btntambah.Location = New System.Drawing.Point(22, 120)
        Me.btntambah.Name = "btntambah"
        Me.btntambah.Size = New System.Drawing.Size(75, 23)
        Me.btntambah.TabIndex = 187
        Me.btntambah.Text = "TAMBAH"
        Me.btntambah.UseVisualStyleBackColor = False
        '
        'txtkodepegawai
        '
        Me.txtkodepegawai.BackColor = System.Drawing.Color.White
        Me.txtkodepegawai.Enabled = False
        Me.txtkodepegawai.ForeColor = System.Drawing.Color.Black
        Me.txtkodepegawai.Location = New System.Drawing.Point(137, 12)
        Me.txtkodepegawai.Name = "txtkodepegawai"
        Me.txtkodepegawai.Size = New System.Drawing.Size(203, 20)
        Me.txtkodepegawai.TabIndex = 179
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(22, 99)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(76, 13)
        Me.Label6.TabIndex = 186
        Me.Label6.Text = "HAK AKSES"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(22, 15)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(102, 13)
        Me.Label7.TabIndex = 178
        Me.Label7.Text = "KODE PEGAWAI"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(22, 42)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(103, 13)
        Me.Label8.TabIndex = 180
        Me.Label8.Text = "NAMA PEGAWAI"
        '
        'txtnamapegawai
        '
        Me.txtnamapegawai.BackColor = System.Drawing.Color.White
        Me.txtnamapegawai.Location = New System.Drawing.Point(138, 39)
        Me.txtnamapegawai.Name = "txtnamapegawai"
        Me.txtnamapegawai.Size = New System.Drawing.Size(203, 20)
        Me.txtnamapegawai.TabIndex = 181
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Cyan
        Me.GroupBox1.Controls.Add(Me.txtCari)
        Me.GroupBox1.Controls.Add(Me.cmbCari)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(-2, 205)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(604, 54)
        Me.GroupBox1.TabIndex = 194
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "PENCARIAN DATA"
        Me.GroupBox1.UseCompatibleTextRendering = True
        '
        'txtCari
        '
        Me.txtCari.Location = New System.Drawing.Point(231, 24)
        Me.txtCari.Name = "txtCari"
        Me.txtCari.Size = New System.Drawing.Size(328, 20)
        Me.txtCari.TabIndex = 32
        '
        'cmbCari
        '
        Me.cmbCari.FormattingEnabled = True
        Me.cmbCari.Items.AddRange(New Object() {"KODE PEGAWAI", "NAMA PEGAWAI"})
        Me.cmbCari.Location = New System.Drawing.Point(16, 23)
        Me.cmbCari.Name = "cmbCari"
        Me.cmbCari.Size = New System.Drawing.Size(205, 21)
        Me.cmbCari.TabIndex = 31
        '
        'dgv
        '
        Me.dgv.BackgroundColor = System.Drawing.Color.Cyan
        Me.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv.Location = New System.Drawing.Point(-1, 259)
        Me.dgv.Name = "dgv"
        Me.dgv.Size = New System.Drawing.Size(603, 180)
        Me.dgv.TabIndex = 33
        '
        'FrmPegawai
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(623, 436)
        Me.Controls.Add(Me.dgv)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label1)
        Me.Name = "FrmPegawai"
        Me.Text = "FrmPegawai"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.dgv, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents txtpassword As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents btnkeluar As System.Windows.Forms.Button
    Friend WithEvents btnhapus As System.Windows.Forms.Button
    Friend WithEvents btnubah As System.Windows.Forms.Button
    Friend WithEvents btntambah As System.Windows.Forms.Button
    Friend WithEvents txtkodepegawai As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtnamapegawai As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txtCari As System.Windows.Forms.TextBox
    Friend WithEvents cmbCari As System.Windows.Forms.ComboBox
    Friend WithEvents dgv As System.Windows.Forms.DataGridView
    Friend WithEvents combohakakses As System.Windows.Forms.ComboBox

End Class
