<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmListBarangMasuk
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.txtCari = New System.Windows.Forms.TextBox
        Me.cmbCari = New System.Windows.Forms.ComboBox
        Me.Panel5 = New System.Windows.Forms.Panel
        Me.btnsegarkan = New System.Windows.Forms.Button
        Me.btnKeluar = New System.Windows.Forms.Button
        Me.btnubah = New System.Windows.Forms.Button
        Me.btntambah = New System.Windows.Forms.Button
        Me.dgv = New System.Windows.Forms.DataGridView
        Me.GroupBox1.SuspendLayout()
        Me.Panel5.SuspendLayout()
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
        Me.Label1.Size = New System.Drawing.Size(672, 38)
        Me.Label1.TabIndex = 174
        Me.Label1.Text = "LIST BARANG MASUK" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Cyan
        Me.GroupBox1.Controls.Add(Me.txtCari)
        Me.GroupBox1.Controls.Add(Me.cmbCari)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox1.Location = New System.Drawing.Point(0, 38)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(672, 71)
        Me.GroupBox1.TabIndex = 175
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Pencarian Data"
        '
        'txtCari
        '
        Me.txtCari.Location = New System.Drawing.Point(189, 30)
        Me.txtCari.Name = "txtCari"
        Me.txtCari.Size = New System.Drawing.Size(479, 20)
        Me.txtCari.TabIndex = 3
        '
        'cmbCari
        '
        Me.cmbCari.FormattingEnabled = True
        Me.cmbCari.Items.AddRange(New Object() {"No PO", "Nama Supplier"})
        Me.cmbCari.Location = New System.Drawing.Point(12, 30)
        Me.cmbCari.Name = "cmbCari"
        Me.cmbCari.Size = New System.Drawing.Size(171, 21)
        Me.cmbCari.TabIndex = 2
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.Cyan
        Me.Panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel5.Controls.Add(Me.btnsegarkan)
        Me.Panel5.Controls.Add(Me.btnKeluar)
        Me.Panel5.Controls.Add(Me.btnubah)
        Me.Panel5.Controls.Add(Me.btntambah)
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel5.Location = New System.Drawing.Point(0, 109)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(672, 40)
        Me.Panel5.TabIndex = 180
        '
        'btnsegarkan
        '
        Me.btnsegarkan.BackColor = System.Drawing.Color.Cyan
        Me.btnsegarkan.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnsegarkan.ForeColor = System.Drawing.Color.Black
        Me.btnsegarkan.Location = New System.Drawing.Point(165, 6)
        Me.btnsegarkan.Name = "btnsegarkan"
        Me.btnsegarkan.Size = New System.Drawing.Size(100, 23)
        Me.btnsegarkan.TabIndex = 32
        Me.btnsegarkan.Text = "SEGARKAN"
        Me.btnsegarkan.UseVisualStyleBackColor = False
        '
        'btnKeluar
        '
        Me.btnKeluar.BackColor = System.Drawing.Color.Cyan
        Me.btnKeluar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnKeluar.ForeColor = System.Drawing.Color.Black
        Me.btnKeluar.Location = New System.Drawing.Point(271, 6)
        Me.btnKeluar.Name = "btnKeluar"
        Me.btnKeluar.Size = New System.Drawing.Size(75, 23)
        Me.btnKeluar.TabIndex = 26
        Me.btnKeluar.Text = "KELUAR"
        Me.btnKeluar.UseVisualStyleBackColor = False
        '
        'btnubah
        '
        Me.btnubah.BackColor = System.Drawing.Color.Cyan
        Me.btnubah.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnubah.ForeColor = System.Drawing.Color.Black
        Me.btnubah.Location = New System.Drawing.Point(84, 6)
        Me.btnubah.Name = "btnubah"
        Me.btnubah.Size = New System.Drawing.Size(75, 23)
        Me.btnubah.TabIndex = 25
        Me.btnubah.Text = "UBAH"
        Me.btnubah.UseVisualStyleBackColor = False
        '
        'btntambah
        '
        Me.btntambah.BackColor = System.Drawing.Color.Cyan
        Me.btntambah.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btntambah.ForeColor = System.Drawing.Color.Black
        Me.btntambah.Location = New System.Drawing.Point(3, 6)
        Me.btntambah.Name = "btntambah"
        Me.btntambah.Size = New System.Drawing.Size(75, 23)
        Me.btntambah.TabIndex = 24
        Me.btntambah.Text = "TAMBAH"
        Me.btntambah.UseVisualStyleBackColor = False
        '
        'dgv
        '
        Me.dgv.BackgroundColor = System.Drawing.Color.Cyan
        Me.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgv.GridColor = System.Drawing.Color.Red
        Me.dgv.Location = New System.Drawing.Point(0, 149)
        Me.dgv.Name = "dgv"
        Me.dgv.Size = New System.Drawing.Size(672, 318)
        Me.dgv.TabIndex = 181
        '
        'FrmListBarangMasuk
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(672, 467)
        Me.Controls.Add(Me.dgv)
        Me.Controls.Add(Me.Panel5)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label1)
        Me.Name = "FrmListBarangMasuk"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "TOKO DVD"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.Panel5.ResumeLayout(False)
        CType(Me.dgv, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txtCari As System.Windows.Forms.TextBox
    Friend WithEvents cmbCari As System.Windows.Forms.ComboBox
    Friend WithEvents Panel5 As System.Windows.Forms.Panel
    Friend WithEvents btnsegarkan As System.Windows.Forms.Button
    Friend WithEvents btnKeluar As System.Windows.Forms.Button
    Friend WithEvents btnubah As System.Windows.Forms.Button
    Friend WithEvents btntambah As System.Windows.Forms.Button
    Friend WithEvents dgv As System.Windows.Forms.DataGridView
End Class
