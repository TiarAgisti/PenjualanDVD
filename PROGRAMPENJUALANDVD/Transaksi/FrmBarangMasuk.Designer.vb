<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmBarangMasuk
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
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.tglpembelian = New System.Windows.Forms.DateTimePicker
        Me.Label7 = New System.Windows.Forms.Label
        Me.txtnomorbarangmasuk = New System.Windows.Forms.TextBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.Panel4 = New System.Windows.Forms.Panel
        Me.Label2 = New System.Windows.Forms.Label
        Me.txtqty = New System.Windows.Forms.TextBox
        Me.btnhapus = New System.Windows.Forms.Button
        Me.btntambah = New System.Windows.Forms.Button
        Me.btnotomatis = New System.Windows.Forms.Button
        Me.Label10 = New System.Windows.Forms.Label
        Me.txtjenisitem = New System.Windows.Forms.TextBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.txtnamaitem = New System.Windows.Forms.TextBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.txtkodeitem = New System.Windows.Forms.TextBox
        Me.dgv = New System.Windows.Forms.DataGridView
        Me.Panel5 = New System.Windows.Forms.Panel
        Me.btntolak = New System.Windows.Forms.Button
        Me.btnsetujui = New System.Windows.Forms.Button
        Me.txtGrandTotal = New System.Windows.Forms.TextBox
        Me.Label13 = New System.Windows.Forms.Label
        Me.btnkeluar = New System.Windows.Forms.Button
        Me.btnbatal = New System.Windows.Forms.Button
        Me.btnsimpan = New System.Windows.Forms.Button
        Me.Panel2.SuspendLayout()
        Me.Panel4.SuspendLayout()
        CType(Me.dgv, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel5.SuspendLayout()
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
        Me.Label1.Size = New System.Drawing.Size(873, 38)
        Me.Label1.TabIndex = 172
        Me.Label1.Text = "BARANG MASUK"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Cyan
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.tglpembelian)
        Me.Panel2.Controls.Add(Me.Label7)
        Me.Panel2.Controls.Add(Me.txtnomorbarangmasuk)
        Me.Panel2.Controls.Add(Me.Label6)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 38)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(873, 50)
        Me.Panel2.TabIndex = 174
        '
        'tglpembelian
        '
        Me.tglpembelian.CalendarForeColor = System.Drawing.Color.Violet
        Me.tglpembelian.CalendarMonthBackground = System.Drawing.Color.Cyan
        Me.tglpembelian.CalendarTitleBackColor = System.Drawing.Color.Black
        Me.tglpembelian.CalendarTitleForeColor = System.Drawing.Color.Red
        Me.tglpembelian.CalendarTrailingForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.tglpembelian.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tglpembelian.Location = New System.Drawing.Point(568, 8)
        Me.tglpembelian.Name = "tglpembelian"
        Me.tglpembelian.Size = New System.Drawing.Size(215, 26)
        Me.tglpembelian.TabIndex = 177
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(381, 14)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(167, 13)
        Me.Label7.TabIndex = 176
        Me.Label7.Text = "TANGGAL BARANG MASUK"
        '
        'txtnomorbarangmasuk
        '
        Me.txtnomorbarangmasuk.BackColor = System.Drawing.Color.White
        Me.txtnomorbarangmasuk.Enabled = False
        Me.txtnomorbarangmasuk.Location = New System.Drawing.Point(157, 11)
        Me.txtnomorbarangmasuk.Name = "txtnomorbarangmasuk"
        Me.txtnomorbarangmasuk.Size = New System.Drawing.Size(217, 20)
        Me.txtnomorbarangmasuk.TabIndex = 175
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(14, 14)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(127, 13)
        Me.Label6.TabIndex = 174
        Me.Label6.Text = "NO BARANG MASUK"
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.Cyan
        Me.Panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel4.Controls.Add(Me.Label2)
        Me.Panel4.Controls.Add(Me.txtqty)
        Me.Panel4.Controls.Add(Me.btnhapus)
        Me.Panel4.Controls.Add(Me.btntambah)
        Me.Panel4.Controls.Add(Me.btnotomatis)
        Me.Panel4.Controls.Add(Me.Label10)
        Me.Panel4.Controls.Add(Me.txtjenisitem)
        Me.Panel4.Controls.Add(Me.Label9)
        Me.Panel4.Controls.Add(Me.txtnamaitem)
        Me.Panel4.Controls.Add(Me.Label8)
        Me.Panel4.Controls.Add(Me.txtkodeitem)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel4.Location = New System.Drawing.Point(0, 88)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(873, 87)
        Me.Panel4.TabIndex = 176
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(480, 34)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(32, 13)
        Me.Label2.TabIndex = 175
        Me.Label2.Text = "QTY"
        '
        'txtqty
        '
        Me.txtqty.BackColor = System.Drawing.Color.White
        Me.txtqty.Location = New System.Drawing.Point(569, 31)
        Me.txtqty.Name = "txtqty"
        Me.txtqty.Size = New System.Drawing.Size(215, 20)
        Me.txtqty.TabIndex = 176
        '
        'btnhapus
        '
        Me.btnhapus.BackColor = System.Drawing.Color.Cyan
        Me.btnhapus.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnhapus.ForeColor = System.Drawing.Color.Black
        Me.btnhapus.Location = New System.Drawing.Point(231, 59)
        Me.btnhapus.Name = "btnhapus"
        Me.btnhapus.Size = New System.Drawing.Size(75, 23)
        Me.btnhapus.TabIndex = 174
        Me.btnhapus.Text = "HAPUS"
        Me.btnhapus.UseVisualStyleBackColor = False
        '
        'btntambah
        '
        Me.btntambah.BackColor = System.Drawing.Color.Cyan
        Me.btntambah.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btntambah.ForeColor = System.Drawing.Color.Black
        Me.btntambah.Location = New System.Drawing.Point(150, 59)
        Me.btntambah.Name = "btntambah"
        Me.btntambah.Size = New System.Drawing.Size(75, 23)
        Me.btntambah.TabIndex = 173
        Me.btntambah.Text = "TAMBAH"
        Me.btntambah.UseVisualStyleBackColor = False
        '
        'btnotomatis
        '
        Me.btnotomatis.BackColor = System.Drawing.Color.Cyan
        Me.btnotomatis.Font = New System.Drawing.Font("Showcard Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnotomatis.ForeColor = System.Drawing.Color.Black
        Me.btnotomatis.Location = New System.Drawing.Point(384, -1)
        Me.btnotomatis.Name = "btnotomatis"
        Me.btnotomatis.Size = New System.Drawing.Size(47, 26)
        Me.btnotomatis.TabIndex = 171
        Me.btnotomatis.Text = "..."
        Me.btnotomatis.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnotomatis.UseVisualStyleBackColor = False
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Black
        Me.Label10.Location = New System.Drawing.Point(480, 8)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(76, 13)
        Me.Label10.TabIndex = 171
        Me.Label10.Text = "JENIS ITEM"
        '
        'txtjenisitem
        '
        Me.txtjenisitem.BackColor = System.Drawing.Color.White
        Me.txtjenisitem.Enabled = False
        Me.txtjenisitem.Location = New System.Drawing.Point(569, 5)
        Me.txtjenisitem.Name = "txtjenisitem"
        Me.txtjenisitem.Size = New System.Drawing.Size(215, 20)
        Me.txtjenisitem.TabIndex = 172
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Black
        Me.Label9.Location = New System.Drawing.Point(16, 36)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(76, 13)
        Me.Label9.TabIndex = 169
        Me.Label9.Text = "NAMA ITEM"
        '
        'txtnamaitem
        '
        Me.txtnamaitem.Enabled = False
        Me.txtnamaitem.Location = New System.Drawing.Point(152, 31)
        Me.txtnamaitem.Name = "txtnamaitem"
        Me.txtnamaitem.Size = New System.Drawing.Size(217, 20)
        Me.txtnamaitem.TabIndex = 170
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Black
        Me.Label8.Location = New System.Drawing.Point(14, 8)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(75, 13)
        Me.Label8.TabIndex = 167
        Me.Label8.Text = "KODE ITEM"
        '
        'txtkodeitem
        '
        Me.txtkodeitem.Location = New System.Drawing.Point(152, 3)
        Me.txtkodeitem.Name = "txtkodeitem"
        Me.txtkodeitem.Size = New System.Drawing.Size(217, 20)
        Me.txtkodeitem.TabIndex = 168
        '
        'dgv
        '
        Me.dgv.BackgroundColor = System.Drawing.Color.Cyan
        Me.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv.Dock = System.Windows.Forms.DockStyle.Top
        Me.dgv.GridColor = System.Drawing.Color.Red
        Me.dgv.Location = New System.Drawing.Point(0, 175)
        Me.dgv.Name = "dgv"
        Me.dgv.Size = New System.Drawing.Size(873, 222)
        Me.dgv.TabIndex = 177
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.Cyan
        Me.Panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel5.Controls.Add(Me.btntolak)
        Me.Panel5.Controls.Add(Me.btnsetujui)
        Me.Panel5.Controls.Add(Me.txtGrandTotal)
        Me.Panel5.Controls.Add(Me.Label13)
        Me.Panel5.Controls.Add(Me.btnkeluar)
        Me.Panel5.Controls.Add(Me.btnbatal)
        Me.Panel5.Controls.Add(Me.btnsimpan)
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel5.Location = New System.Drawing.Point(0, 397)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(873, 59)
        Me.Panel5.TabIndex = 178
        '
        'btntolak
        '
        Me.btntolak.BackColor = System.Drawing.Color.Cyan
        Me.btntolak.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btntolak.ForeColor = System.Drawing.Color.Black
        Me.btntolak.Location = New System.Drawing.Point(324, 6)
        Me.btntolak.Name = "btntolak"
        Me.btntolak.Size = New System.Drawing.Size(75, 23)
        Me.btntolak.TabIndex = 31
        Me.btntolak.Text = "TOLAK"
        Me.btntolak.UseVisualStyleBackColor = False
        '
        'btnsetujui
        '
        Me.btnsetujui.BackColor = System.Drawing.Color.Cyan
        Me.btnsetujui.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnsetujui.ForeColor = System.Drawing.Color.Black
        Me.btnsetujui.Location = New System.Drawing.Point(243, 6)
        Me.btnsetujui.Name = "btnsetujui"
        Me.btnsetujui.Size = New System.Drawing.Size(75, 23)
        Me.btnsetujui.TabIndex = 30
        Me.btnsetujui.Text = "SETUJUI" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.btnsetujui.UseVisualStyleBackColor = False
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
        Me.Label13.Size = New System.Drawing.Size(114, 13)
        Me.Label13.TabIndex = 27
        Me.Label13.Text = "TOTAL QUANTITY"
        '
        'btnkeluar
        '
        Me.btnkeluar.BackColor = System.Drawing.Color.Cyan
        Me.btnkeluar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnkeluar.ForeColor = System.Drawing.Color.Black
        Me.btnkeluar.Location = New System.Drawing.Point(165, 6)
        Me.btnkeluar.Name = "btnkeluar"
        Me.btnkeluar.Size = New System.Drawing.Size(75, 23)
        Me.btnkeluar.TabIndex = 26
        Me.btnkeluar.Text = "KELUAR"
        Me.btnkeluar.UseVisualStyleBackColor = False
        '
        'btnbatal
        '
        Me.btnbatal.BackColor = System.Drawing.Color.Cyan
        Me.btnbatal.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnbatal.ForeColor = System.Drawing.Color.Black
        Me.btnbatal.Location = New System.Drawing.Point(84, 6)
        Me.btnbatal.Name = "btnbatal"
        Me.btnbatal.Size = New System.Drawing.Size(75, 23)
        Me.btnbatal.TabIndex = 25
        Me.btnbatal.Text = "BATAL"
        Me.btnbatal.UseVisualStyleBackColor = False
        '
        'btnsimpan
        '
        Me.btnsimpan.BackColor = System.Drawing.Color.Cyan
        Me.btnsimpan.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnsimpan.ForeColor = System.Drawing.Color.Black
        Me.btnsimpan.Location = New System.Drawing.Point(3, 6)
        Me.btnsimpan.Name = "btnsimpan"
        Me.btnsimpan.Size = New System.Drawing.Size(75, 23)
        Me.btnsimpan.TabIndex = 24
        Me.btnsimpan.Text = "SIMPAN"
        Me.btnsimpan.UseVisualStyleBackColor = False
        '
        'FrmBarangMasuk
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(873, 456)
        Me.Controls.Add(Me.Panel5)
        Me.Controls.Add(Me.dgv)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "FrmBarangMasuk"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "TOKO DVD"
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
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents tglpembelian As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtnomorbarangmasuk As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents btnhapus As System.Windows.Forms.Button
    Friend WithEvents btntambah As System.Windows.Forms.Button
    Friend WithEvents btnotomatis As System.Windows.Forms.Button
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txtjenisitem As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtnamaitem As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtkodeitem As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtqty As System.Windows.Forms.TextBox
    Friend WithEvents dgv As System.Windows.Forms.DataGridView
    Friend WithEvents Panel5 As System.Windows.Forms.Panel
    Friend WithEvents btntolak As System.Windows.Forms.Button
    Friend WithEvents btnsetujui As System.Windows.Forms.Button
    Friend WithEvents txtGrandTotal As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents btnkeluar As System.Windows.Forms.Button
    Friend WithEvents btnbatal As System.Windows.Forms.Button
    Friend WithEvents btnsimpan As System.Windows.Forms.Button
End Class
