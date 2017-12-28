<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmRekapPenjualan
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
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.tglpembelian = New System.Windows.Forms.DateTimePicker
        Me.Label7 = New System.Windows.Forms.Label
        Me.txtkodepembelian = New System.Windows.Forms.TextBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.Panel4 = New System.Windows.Forms.Panel
        Me.Label3 = New System.Windows.Forms.Label
        Me.TextBox2 = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.TextBox1 = New System.Windows.Forms.TextBox
        Me.Button3 = New System.Windows.Forms.Button
        Me.btnTambah = New System.Windows.Forms.Button
        Me.Button2 = New System.Windows.Forms.Button
        Me.Label10 = New System.Windows.Forms.Label
        Me.TextBox5 = New System.Windows.Forms.TextBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.TextBox4 = New System.Windows.Forms.TextBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.txtkodeitem = New System.Windows.Forms.TextBox
        Me.dgv = New System.Windows.Forms.DataGridView
        Me.Panel5 = New System.Windows.Forms.Panel
        Me.btnVoid = New System.Windows.Forms.Button
        Me.btnAprove = New System.Windows.Forms.Button
        Me.txtGrandTotal = New System.Windows.Forms.TextBox
        Me.Label13 = New System.Windows.Forms.Label
        Me.btnKeluar = New System.Windows.Forms.Button
        Me.btnBatal = New System.Windows.Forms.Button
        Me.btnSimpan = New System.Windows.Forms.Button
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel4.SuspendLayout()
        CType(Me.dgv, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel5.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Cyan
        Me.Label1.Font = New System.Drawing.Font("Algerian", 25.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte), True)
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(188, 7)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(391, 38)
        Me.Label1.TabIndex = 171
        Me.Label1.Text = "Rekapan Penjualan"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Cyan
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(780, 52)
        Me.Panel1.TabIndex = 172
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Cyan
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.tglpembelian)
        Me.Panel2.Controls.Add(Me.Label7)
        Me.Panel2.Controls.Add(Me.txtkodepembelian)
        Me.Panel2.Controls.Add(Me.Label6)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 52)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(780, 45)
        Me.Panel2.TabIndex = 173
        '
        'tglpembelian
        '
        Me.tglpembelian.CalendarForeColor = System.Drawing.Color.Violet
        Me.tglpembelian.CalendarMonthBackground = System.Drawing.Color.Cyan
        Me.tglpembelian.CalendarTitleBackColor = System.Drawing.Color.Black
        Me.tglpembelian.CalendarTitleForeColor = System.Drawing.Color.Red
        Me.tglpembelian.CalendarTrailingForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.tglpembelian.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tglpembelian.Location = New System.Drawing.Point(556, 8)
        Me.tglpembelian.Name = "tglpembelian"
        Me.tglpembelian.Size = New System.Drawing.Size(215, 26)
        Me.tglpembelian.TabIndex = 177
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(403, 13)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(141, 13)
        Me.Label7.TabIndex = 176
        Me.Label7.Text = "TANGGAL PENJUALAN"
        '
        'txtkodepembelian
        '
        Me.txtkodepembelian.BackColor = System.Drawing.Color.White
        Me.txtkodepembelian.Location = New System.Drawing.Point(137, 11)
        Me.txtkodepembelian.Name = "txtkodepembelian"
        Me.txtkodepembelian.Size = New System.Drawing.Size(203, 20)
        Me.txtkodepembelian.TabIndex = 175
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(14, 14)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(101, 13)
        Me.Label6.TabIndex = 174
        Me.Label6.Text = "NO PENJUALAN"
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.Cyan
        Me.Panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel4.Controls.Add(Me.Label3)
        Me.Panel4.Controls.Add(Me.TextBox2)
        Me.Panel4.Controls.Add(Me.Label2)
        Me.Panel4.Controls.Add(Me.TextBox1)
        Me.Panel4.Controls.Add(Me.Button3)
        Me.Panel4.Controls.Add(Me.btnTambah)
        Me.Panel4.Controls.Add(Me.Button2)
        Me.Panel4.Controls.Add(Me.Label10)
        Me.Panel4.Controls.Add(Me.TextBox5)
        Me.Panel4.Controls.Add(Me.Label9)
        Me.Panel4.Controls.Add(Me.TextBox4)
        Me.Panel4.Controls.Add(Me.Label8)
        Me.Panel4.Controls.Add(Me.txtkodeitem)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel4.Location = New System.Drawing.Point(0, 97)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(780, 87)
        Me.Panel4.TabIndex = 175
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(453, 60)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(32, 13)
        Me.Label3.TabIndex = 177
        Me.Label3.Text = "QTY"
        '
        'TextBox2
        '
        Me.TextBox2.Enabled = False
        Me.TextBox2.Location = New System.Drawing.Point(556, 57)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(215, 20)
        Me.TextBox2.TabIndex = 178
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(453, 34)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(50, 13)
        Me.Label2.TabIndex = 175
        Me.Label2.Text = "HARGA"
        '
        'TextBox1
        '
        Me.TextBox1.Enabled = False
        Me.TextBox1.Location = New System.Drawing.Point(556, 31)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(215, 20)
        Me.TextBox1.TabIndex = 176
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.Cyan
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.ForeColor = System.Drawing.Color.Black
        Me.Button3.Location = New System.Drawing.Point(214, 59)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 23)
        Me.Button3.TabIndex = 174
        Me.Button3.Text = "HAPUS"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'btnTambah
        '
        Me.btnTambah.BackColor = System.Drawing.Color.Cyan
        Me.btnTambah.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTambah.ForeColor = System.Drawing.Color.Black
        Me.btnTambah.Location = New System.Drawing.Point(133, 59)
        Me.btnTambah.Name = "btnTambah"
        Me.btnTambah.Size = New System.Drawing.Size(75, 23)
        Me.btnTambah.TabIndex = 173
        Me.btnTambah.Text = "TAMBAH"
        Me.btnTambah.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.Cyan
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.Color.Black
        Me.Button2.Location = New System.Drawing.Point(361, 3)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(46, 29)
        Me.Button2.TabIndex = 171
        Me.Button2.Text = "..."
        Me.Button2.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Black
        Me.Label10.Location = New System.Drawing.Point(453, 8)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(42, 13)
        Me.Label10.TabIndex = 171
        Me.Label10.Text = "JENIS"
        '
        'TextBox5
        '
        Me.TextBox5.Enabled = False
        Me.TextBox5.Location = New System.Drawing.Point(556, 5)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(215, 20)
        Me.TextBox5.TabIndex = 172
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Black
        Me.Label9.Location = New System.Drawing.Point(11, 36)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(42, 13)
        Me.Label9.TabIndex = 169
        Me.Label9.Text = "NAMA"
        '
        'TextBox4
        '
        Me.TextBox4.Location = New System.Drawing.Point(135, 33)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(203, 20)
        Me.TextBox4.TabIndex = 170
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Black
        Me.Label8.Location = New System.Drawing.Point(11, 8)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(75, 13)
        Me.Label8.TabIndex = 167
        Me.Label8.Text = "KODE ITEM"
        '
        'txtkodeitem
        '
        Me.txtkodeitem.Location = New System.Drawing.Point(136, 5)
        Me.txtkodeitem.Name = "txtkodeitem"
        Me.txtkodeitem.Size = New System.Drawing.Size(203, 20)
        Me.txtkodeitem.TabIndex = 168
        '
        'dgv
        '
        Me.dgv.BackgroundColor = System.Drawing.Color.Cyan
        Me.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv.Dock = System.Windows.Forms.DockStyle.Top
        Me.dgv.GridColor = System.Drawing.Color.Red
        Me.dgv.Location = New System.Drawing.Point(0, 184)
        Me.dgv.Name = "dgv"
        Me.dgv.Size = New System.Drawing.Size(780, 226)
        Me.dgv.TabIndex = 176
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.Cyan
        Me.Panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel5.Controls.Add(Me.btnVoid)
        Me.Panel5.Controls.Add(Me.btnAprove)
        Me.Panel5.Controls.Add(Me.txtGrandTotal)
        Me.Panel5.Controls.Add(Me.Label13)
        Me.Panel5.Controls.Add(Me.btnKeluar)
        Me.Panel5.Controls.Add(Me.btnBatal)
        Me.Panel5.Controls.Add(Me.btnSimpan)
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel5.Location = New System.Drawing.Point(0, 410)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(780, 43)
        Me.Panel5.TabIndex = 177
        '
        'btnVoid
        '
        Me.btnVoid.BackColor = System.Drawing.Color.Cyan
        Me.btnVoid.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnVoid.ForeColor = System.Drawing.Color.Black
        Me.btnVoid.Location = New System.Drawing.Point(324, 6)
        Me.btnVoid.Name = "btnVoid"
        Me.btnVoid.Size = New System.Drawing.Size(75, 23)
        Me.btnVoid.TabIndex = 31
        Me.btnVoid.Text = "TOLAK"
        Me.btnVoid.UseVisualStyleBackColor = False
        '
        'btnAprove
        '
        Me.btnAprove.BackColor = System.Drawing.Color.Cyan
        Me.btnAprove.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAprove.ForeColor = System.Drawing.Color.Black
        Me.btnAprove.Location = New System.Drawing.Point(243, 6)
        Me.btnAprove.Name = "btnAprove"
        Me.btnAprove.Size = New System.Drawing.Size(75, 23)
        Me.btnAprove.TabIndex = 30
        Me.btnAprove.Text = "SETUJUI" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.btnAprove.UseVisualStyleBackColor = False
        '
        'txtGrandTotal
        '
        Me.txtGrandTotal.BackColor = System.Drawing.Color.White
        Me.txtGrandTotal.Enabled = False
        Me.txtGrandTotal.Location = New System.Drawing.Point(572, 8)
        Me.txtGrandTotal.Name = "txtGrandTotal"
        Me.txtGrandTotal.Size = New System.Drawing.Size(200, 20)
        Me.txtGrandTotal.TabIndex = 28
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.Black
        Me.Label13.Location = New System.Drawing.Point(456, 11)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(95, 13)
        Me.Label13.TabIndex = 27
        Me.Label13.Text = "GRAND TOTAL"
        '
        'btnKeluar
        '
        Me.btnKeluar.BackColor = System.Drawing.Color.Cyan
        Me.btnKeluar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnKeluar.ForeColor = System.Drawing.Color.Black
        Me.btnKeluar.Location = New System.Drawing.Point(165, 6)
        Me.btnKeluar.Name = "btnKeluar"
        Me.btnKeluar.Size = New System.Drawing.Size(75, 23)
        Me.btnKeluar.TabIndex = 26
        Me.btnKeluar.Text = "KELUAR"
        Me.btnKeluar.UseVisualStyleBackColor = False
        '
        'btnBatal
        '
        Me.btnBatal.BackColor = System.Drawing.Color.Cyan
        Me.btnBatal.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBatal.ForeColor = System.Drawing.Color.Black
        Me.btnBatal.Location = New System.Drawing.Point(84, 6)
        Me.btnBatal.Name = "btnBatal"
        Me.btnBatal.Size = New System.Drawing.Size(75, 23)
        Me.btnBatal.TabIndex = 25
        Me.btnBatal.Text = "BATAL"
        Me.btnBatal.UseVisualStyleBackColor = False
        '
        'btnSimpan
        '
        Me.btnSimpan.BackColor = System.Drawing.Color.Cyan
        Me.btnSimpan.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSimpan.ForeColor = System.Drawing.Color.Black
        Me.btnSimpan.Location = New System.Drawing.Point(3, 6)
        Me.btnSimpan.Name = "btnSimpan"
        Me.btnSimpan.Size = New System.Drawing.Size(75, 23)
        Me.btnSimpan.TabIndex = 24
        Me.btnSimpan.Text = "SIMPAN"
        Me.btnSimpan.UseVisualStyleBackColor = False
        '
        'FrmRekapPenjualan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(780, 453)
        Me.Controls.Add(Me.Panel5)
        Me.Controls.Add(Me.dgv)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmRekapPenjualan"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "TOKO DVD"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        CType(Me.dgv, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents tglpembelian As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtkodepembelian As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents TextBox5 As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents TextBox4 As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtkodeitem As System.Windows.Forms.TextBox
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents btnTambah As System.Windows.Forms.Button
    Friend WithEvents dgv As System.Windows.Forms.DataGridView
    Friend WithEvents Panel5 As System.Windows.Forms.Panel
    Friend WithEvents btnVoid As System.Windows.Forms.Button
    Friend WithEvents btnAprove As System.Windows.Forms.Button
    Friend WithEvents txtGrandTotal As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents btnKeluar As System.Windows.Forms.Button
    Friend WithEvents btnBatal As System.Windows.Forms.Button
    Friend WithEvents btnSimpan As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
End Class
