Imports System.Data
Imports System.Data.SqlClient
Public Class FrmMasterItem
    Sub EnableText()
        txtnamaitem.Enabled = True
        txtjenisitem.Enabled = True
        txthargajual.Enabled = True
    End Sub
    Sub DisableText()
        txtkodeitem.Enabled = False
        txtnamaitem.Enabled = False
        txtjenisitem.Enabled = False
        txthargajual.Enabled = False
    End Sub
    Sub ClearText()
        txtkodeitem.Clear()
        txtnamaitem.Clear()
        txtjenisitem.Clear()
        txthargajual.Clear()
    End Sub
    Private Sub prepareButtonCreat()
        btnTambah.Enabled = True
        btntambah.Text = "TAMBAH"
        btnubah.Enabled = False
        btnubah.Text = "EDIT"
        btnHapus.Enabled = False
        btnkeluar.Enabled = True
        btnkeluar.Text = "KELUAR"
    End Sub
    Public Sub prepareButtonSave()
        btntambah.Text = "SIMPAN"
        btnubah.Enabled = False
        btnHapus.Enabled = False
        btnkeluar.Enabled = True
        btnkeluar.Text = "BATAL"
    End Sub
    Public Sub prepareButtonEdit()
        btnTambah.Enabled = False
        btntambah.Text = "TAMBAH"
        btnubah.Enabled = True
        btnHapus.Enabled = True
        btnkeluar.Text = "BATAL"
    End Sub
    Sub GeneratedCodeMasterItem()
        Dim query As String
        Dim hitung As Integer
        Dim urutan As String
        OpenConnection()
        query = "Select Max(kodeitem) as kodeitem From tbmasteritem"
        cmd = New SqlCommand(query, conn)
        dr = cmd.ExecuteReader
        While dr.Read
            If IsDBNull(dr.Item("kodeitem")) Then
                urutan = "ITEM" + "001"
            Else
                hitung = Microsoft.VisualBasic.Right(dr.Item("kodeitem"), 3) + 1
                urutan = "ITEM" & Microsoft.VisualBasic.Right("000" & hitung, 3)
            End If
            txtkodeitem.Text = urutan
        End While
        conn.Close()
    End Sub
    Sub HeaderGrid()
        dgv.Columns(0).HeaderText = "Kode Item"
        dgv.Columns(1).HeaderText = "Nama Item"
        dgv.Columns(2).HeaderText = "Jenis Item"
        dgv.Columns(3).HeaderText = "Harga Jual"
        dgv.Columns(4).Visible = False
        dgv.Columns(5).Visible = False

    End Sub

    Sub ListMasterItem()
        Try
            OpenConnection()
            Dim query As String
            query = "Select * from tbmasteritem" & _
                    "  Where IsActive = 1"
            cmd = New SqlCommand(query, conn)
            da = New SqlDataAdapter
            da.SelectCommand = cmd
            ds = New DataSet
            da.Fill(ds)
            dt = ds.Tables(0)
            dgv.DataSource = dt
            dgv.ReadOnly = True
            HeaderGrid()
            conn.Close()
        Catch ex As Exception
            MsgBox(ex.Message.ToString)
        End Try
    End Sub
    Sub UpdateData()
        Try
            OpenConnection()
            Dim query As String = "Update tbmasteritem set namaitem = '" & txtnamaitem.Text & "' ,jenisitem='" & txtjenisitem.Text & "'" & _
                                    " where kodeitem = '" & txtkodeitem.Text & "'"
            cmd = New SqlCommand(query, conn)
            cmd.ExecuteNonQuery()
            MsgBox("Data berhasil diupdate")
            conn.Close()
            cmd.Dispose()
            TampilanAwal()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Sub DeleteData()
        Try
            OpenConnection()
            Dim query As String = "Update tbmasteritem set IsActive = 0 Where kodeitem='" & txtkodeitem.Text & "'"
            cmd = New SqlCommand(query, conn)
            cmd.ExecuteNonQuery()
            MsgBox("Data berhasil dihapus")
            conn.Close()
            cmd.Dispose()
            TampilanAwal()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Sub SimpanData()
        Try
            OpenConnection()
            Dim query As String
            query = "Insert into tbmasteritem(kodeitem,namaitem,jenisitem,hargajual,kodepegawai,IsActive)Values" & _
                    "('" & txtkodeitem.Text & "','" & txtnamaitem.Text & "','" & txtjenisitem.Text & "','" & txthargajual.Text & "'" & _
                    ",'" & MenuUtama.stKodePegawai.Text & "',1)"
            cmd = New SqlCommand(query, conn)
            cmd.ExecuteNonQuery()
            MsgBox("Data berhasil disimpan")
            conn.Close()
            cmd.Dispose()
            TampilanAwal()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Sub TampilanAwal()
        ListMasterItem()
        prepareButtonCreat()
        DisableText()
        ClearText()
    End Sub

    Private Sub FrmMaster_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        TampilanAwal()
    End Sub
    Private Sub dgv_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgv.Click
        Try
            Dim row As Integer = dgv.CurrentRow.Index
            txtkodeitem.Text = dgv.Item(0, row).Value
            txtnamaitem.Text = dgv.Item(1, row).Value
            txtjenisitem.Text = dgv.Item(2, row).Value
            txthargajual.Text = dgv.Item(3, row).Value
            prepareButtonEdit()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btntambah_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btntambah.Click
        Select Case btntambah.Text
            Case "TAMBAH"
                GeneratedCodeMasterItem()
                prepareButtonSave()
                EnableText()
            Case "SIMPAN"
                If txtnamaitem.Text = "" Then
                    msgError("Nama item tidak boleh kosong")
                    txtnamaitem.Focus()
                ElseIf txtjenisitem.Text = "" Then
                    msgError("Jenis item tidak boleh kosong")
                    txtjenisitem.Focus()
                ElseIf txthargajual.Text = "" Then
                    msgError("Harga tidak boleh kosong")
                    txthargajual.Focus()
                Else
                    SimpanData()
                    TampilanAwal()
                End If
        End Select
    End Sub

    Private Sub btnkeluar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnkeluar.Click
        Select Case btnkeluar.Text
            Case "BATAL"
                TampilanAwal()
            Case "KELUAR"
                Me.Close()
        End Select
    End Sub

    Private Sub btnhapus_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnhapus.Click
        DeleteData()
    End Sub

    Private Sub btnubah_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnubah.Click
        Select Case btnubah.Text
            Case "EDIT"
                EnableText()
                prepareButtonEdit()
                Me.txtkodeitem.Enabled = False
                Me.txtnamaitem.Focus()
                btnubah.Text = "UPDATE"
            Case "UPDATE"
                UpdateData()
                ClearText()
                DisableText()
        End Select
    End Sub

    Private Sub txthargajual_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txthargajual.TextChanged
        If txthargajual.Text = "" Then
            txthargajual.Text = ""
        Else
            If Not IsNumeric(txthargajual.Text) Then
                txthargajual.Clear()
            End If
        End If
    End Sub

    Private Sub txtCari_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCari.TextChanged
        If cmbCari.Text = "Kode Item" Then
            Try
                OpenConnection()
                Dim query As String = "Select * from tbmasteritem" & _
                                        " Where kodeitem Like '%" & txtCari.Text & "%' AND IsActive = 1"
                cmd = New SqlCommand(query, conn)
                da = New SqlDataAdapter
                da.SelectCommand = cmd
                ds = New DataSet
                da.Fill(ds)
                dt = ds.Tables(0)
                dgv.DataSource = dt
                dgv.ReadOnly = True
                HeaderGrid()
                conn.Close()
            Catch ex As Exception
                MsgBox(ex.Message.ToString)
            End Try
        ElseIf cmbCari.Text = "Nama Item" Then
            Try
                OpenConnection()
                Dim query As String = "Select * from tbmasteritem" & _
                                        " Where namaitem Like '%" & txtCari.Text & "%' AND IsActive = 1"
                cmd = New SqlCommand(query, conn)
                da = New SqlDataAdapter
                da.SelectCommand = cmd
                ds = New DataSet
                da.Fill(ds)
                dt = ds.Tables(0)
                dgv.DataSource = dt
                dgv.ReadOnly = True
                HeaderGrid()
                conn.Close()
            Catch ex As Exception
                MsgBox(ex.Message.ToString)
            End Try
        End If
    End Sub
End Class