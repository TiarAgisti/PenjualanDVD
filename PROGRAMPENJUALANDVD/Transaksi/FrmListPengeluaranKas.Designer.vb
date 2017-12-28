<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmListPengeluaranKas
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
        Me.Button1 = New System.Windows.Forms.Button
        Me.btnKeluar = New System.Windows.Forms.Button
        Me.btnBatal = New System.Windows.Forms.Button
        Me.btnSimpan = New System.Windows.Forms.Button
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
        Me.Label1.Size = New System.Drawing.Size(681, 38)
        Me.Label1.TabIndex = 176
        Me.Label1.Text = "LIST PENGELUARAN KAS" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
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
        Me.GroupBox1.Size = New System.Drawing.Size(681, 71)
        Me.GroupBox1.TabIndex = 177
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
        Me.Panel5.Controls.Add(Me.Button1)
        Me.Panel5.Controls.Add(Me.btnKeluar)
        Me.Panel5.Controls.Add(Me.btnBatal)
        Me.Panel5.Controls.Add(Me.btnSimpan)
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel5.Location = New System.Drawing.Point(0, 109)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(681, 40)
        Me.Panel5.TabIndex = 182
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Cyan
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.Black
        Me.Button1.Location = New System.Drawing.Point(165, 6)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(100, 23)
        Me.Button1.TabIndex = 32
        Me.Button1.Text = "SEGARKAN"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'btnKeluar
        '
        Me.btnKeluar.BackColor = System.Drawing.Color.Cyan
        Me.btnKeluar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnKeluar.ForeColor = System.Drawing.Color.Black
        Me.btnKeluar.Location = New System.Drawing.Point(271, 5)
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
        Me.btnBatal.Text = "UBAH"
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
        Me.btnSimpan.Text = "TAMBAH"
        Me.btnSimpan.UseVisualStyleBackColor = False
        '
        'dgv
        '
        Me.dgv.BackgroundColor = System.Drawing.Color.Cyan
        Me.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgv.GridColor = System.Drawing.Color.Red
        Me.dgv.Location = New System.Drawing.Point(0, 149)
        Me.dgv.Name = "dgv"
        Me.dgv.Size = New System.Drawing.Size(681, 333)
        Me.dgv.TabIndex = 183
        '
        'FrmListPengeluaranKas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(681, 482)
        Me.Controls.Add(Me.dgv)
        Me.Controls.Add(Me.Panel5)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label1)
        Me.Name = "FrmListPengeluaranKas"
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
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents btnKeluar As System.Windows.Forms.Button
    Friend WithEvents btnBatal As System.Windows.Forms.Button
    Friend WithEvents btnSimpan As System.Windows.Forms.Button
    Friend WithEvents dgv As System.Windows.Forms.DataGridView
End Class
