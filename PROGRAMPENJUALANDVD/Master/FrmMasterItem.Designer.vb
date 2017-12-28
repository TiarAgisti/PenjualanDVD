<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmMasterItem
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
        Me.dgv = New System.Windows.Forms.DataGridView
        Me.Label1 = New System.Windows.Forms.Label
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.txtCari = New System.Windows.Forms.TextBox
        Me.cmbCari = New System.Windows.Forms.ComboBox
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.txthargajual = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.txtjenisitem = New System.Windows.Forms.TextBox
        Me.btnkeluar = New System.Windows.Forms.Button
        Me.btnhapus = New System.Windows.Forms.Button
        Me.btnubah = New System.Windows.Forms.Button
        Me.btntambah = New System.Windows.Forms.Button
        Me.txtkodeitem = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.txtnamaitem = New System.Windows.Forms.TextBox
        CType(Me.dgv, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'dgv
        '
        Me.dgv.BackgroundColor = System.Drawing.Color.Cyan
        Me.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv.Location = New System.Drawing.Point(0, 277)
        Me.dgv.Name = "dgv"
        Me.dgv.Size = New System.Drawing.Size(877, 184)
        Me.dgv.TabIndex = 31
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Cyan
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label1.Font = New System.Drawing.Font("Algerian", 25.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte), True)
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(971, 39)
        Me.Label1.TabIndex = 176
        Me.Label1.Text = "MASTER ITEM"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Cyan
        Me.GroupBox1.Controls.Add(Me.txtCari)
        Me.GroupBox1.Controls.Add(Me.cmbCari)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(0, 212)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(971, 65)
        Me.GroupBox1.TabIndex = 178
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "PENCARIAN DATA"
        Me.GroupBox1.UseCompatibleTextRendering = True
        '
        'txtCari
        '
        Me.txtCari.Location = New System.Drawing.Point(227, 24)
        Me.txtCari.Name = "txtCari"
        Me.txtCari.Size = New System.Drawing.Size(362, 20)
        Me.txtCari.TabIndex = 32
        '
        'cmbCari
        '
        Me.cmbCari.FormattingEnabled = True
        Me.cmbCari.Items.AddRange(New Object() {"Kode Item", "Nama Item"})
        Me.cmbCari.Location = New System.Drawing.Point(16, 23)
        Me.cmbCari.Name = "cmbCari"
        Me.cmbCari.Size = New System.Drawing.Size(205, 21)
        Me.cmbCari.TabIndex = 31
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Cyan
        Me.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.txthargajual)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.txtjenisitem)
        Me.Panel1.Controls.Add(Me.btnkeluar)
        Me.Panel1.Controls.Add(Me.btnhapus)
        Me.Panel1.Controls.Add(Me.btnubah)
        Me.Panel1.Controls.Add(Me.btntambah)
        Me.Panel1.Controls.Add(Me.txtkodeitem)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.txtnamaitem)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 39)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(971, 173)
        Me.Panel1.TabIndex = 177
        Me.Panel1.TabStop = True
        '
        'txthargajual
        '
        Me.txthargajual.BackColor = System.Drawing.Color.White
        Me.txthargajual.Location = New System.Drawing.Point(129, 101)
        Me.txthargajual.Name = "txthargajual"
        Me.txthargajual.Size = New System.Drawing.Size(203, 20)
        Me.txthargajual.TabIndex = 193
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(28, 104)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(84, 13)
        Me.Label5.TabIndex = 192
        Me.Label5.Text = "HARGA JUAL"
        '
        'txtjenisitem
        '
        Me.txtjenisitem.BackColor = System.Drawing.Color.White
        Me.txtjenisitem.Location = New System.Drawing.Point(128, 73)
        Me.txtjenisitem.Name = "txtjenisitem"
        Me.txtjenisitem.Size = New System.Drawing.Size(203, 20)
        Me.txtjenisitem.TabIndex = 191
        '
        'btnkeluar
        '
        Me.btnkeluar.BackColor = System.Drawing.Color.Cyan
        Me.btnkeluar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnkeluar.ForeColor = System.Drawing.Color.Black
        Me.btnkeluar.Location = New System.Drawing.Point(271, 142)
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
        Me.btnhapus.Location = New System.Drawing.Point(188, 142)
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
        Me.btnubah.Location = New System.Drawing.Point(105, 142)
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
        Me.btntambah.Location = New System.Drawing.Point(23, 142)
        Me.btntambah.Name = "btntambah"
        Me.btntambah.Size = New System.Drawing.Size(75, 23)
        Me.btntambah.TabIndex = 187
        Me.btntambah.Text = "TAMBAH"
        Me.btntambah.UseVisualStyleBackColor = False
        '
        'txtkodeitem
        '
        Me.txtkodeitem.BackColor = System.Drawing.Color.White
        Me.txtkodeitem.Enabled = False
        Me.txtkodeitem.ForeColor = System.Drawing.Color.Black
        Me.txtkodeitem.Location = New System.Drawing.Point(128, 14)
        Me.txtkodeitem.Name = "txtkodeitem"
        Me.txtkodeitem.Size = New System.Drawing.Size(203, 20)
        Me.txtkodeitem.TabIndex = 179
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(27, 76)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(76, 13)
        Me.Label4.TabIndex = 186
        Me.Label4.Text = "JENIS ITEM"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(27, 17)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(75, 13)
        Me.Label2.TabIndex = 178
        Me.Label2.Text = "KODE ITEM"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(27, 43)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(76, 13)
        Me.Label3.TabIndex = 180
        Me.Label3.Text = "NAMA ITEM"
        '
        'txtnamaitem
        '
        Me.txtnamaitem.BackColor = System.Drawing.Color.White
        Me.txtnamaitem.Location = New System.Drawing.Point(129, 41)
        Me.txtnamaitem.Name = "txtnamaitem"
        Me.txtnamaitem.Size = New System.Drawing.Size(203, 20)
        Me.txtnamaitem.TabIndex = 181
        '
        'FrmMasterItem
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(971, 451)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.dgv)
        Me.Name = "FrmMasterItem"
        Me.Text = "FrmMaster"
        CType(Me.dgv, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents dgv As System.Windows.Forms.DataGridView
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txtCari As System.Windows.Forms.TextBox
    Friend WithEvents cmbCari As System.Windows.Forms.ComboBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents txtjenisitem As System.Windows.Forms.TextBox
    Friend WithEvents btnkeluar As System.Windows.Forms.Button
    Friend WithEvents btnhapus As System.Windows.Forms.Button
    Friend WithEvents btnubah As System.Windows.Forms.Button
    Friend WithEvents btntambah As System.Windows.Forms.Button
    Friend WithEvents txtkodeitem As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtnamaitem As System.Windows.Forms.TextBox
    Friend WithEvents txthargajual As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
End Class
