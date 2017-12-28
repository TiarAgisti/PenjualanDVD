Imports System.Data
Imports System.Data.SqlClient
Public Class FrmPegawai
    Sub EnableText()
        txtnamapegawai.Enabled = True
        txtpassword.Enabled = True
        combohakakses.Enabled = True
    End Sub
    Sub DisableText()
        txtkodepegawai.Enabled = False
        txtnamapegawai.Enabled = False
        txtpassword.Enabled = False
        combohakakses.Enabled = False
    End Sub
    Sub ClearText()
        txtkodepegawai.Clear()
        txtnamapegawai.Clear()
        txtpassword.Clear()
        combohakakses.Text = ""
    End Sub
    Private Sub prepareButtonCreat()
        btnTambah.Enabled = True
        btntambah.Text = "TAMBAH"
        btnubah.Enabled = False
        btnubah.Text = "EDIT"
        btnHapus.Enabled = False
        btnKeluar.Enabled = True
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
    Sub GeneratedCodePegawai()
        Dim query As String
        Dim hitung As Integer
        Dim urutan As String
        OpenConnection()
        query = "Select Max(kodepegawai) as kodepegawai From tbpegawai"
        cmd = New SqlCommand(query, conn)
        dr = cmd.ExecuteReader
        While dr.Read
            If IsDBNull(dr.Item("kodepegawai")) Then
                urutan = "PEGAWAI" + "001"
            Else
                hitung = Microsoft.VisualBasic.Right(dr.Item("kodepegawai"), 3) + 1
                urutan = "PEGAWAI" & Microsoft.VisualBasic.Right("000" & hitung, 3)
            End If
            txtkodepegawai.Text = urutan
        End While
    End Sub
    Sub HeaderGrid()
        dgv.Columns(0).HeaderText = "Kode Pegawai"
        dgv.Columns(1).HeaderText = "Nama Pegawai"
        dgv.Columns(2).HeaderText = "Password"
        dgv.Columns(3).HeaderText = "Hak Akses"
        dgv.Columns(4).Visible = False
    End Sub
    Sub ListPegawai()
        Try
            OpenConnection()
            Dim query As String
            query = "Select * from tbpegawai" & _
                    " Where IsActive = 1"
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
            Dim query As String = "Update tbpegawai set namapegawai = '" & txtnamapegawai.Text & "' ,hakakses='" & combohakakses.Text & "'" & _
                                    " where kodepegawai = '" & txtkodepegawai.Text & "'"
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
            Dim query As String = "Update tbpegawai set IsActive = 0 Where kodepegawai='" & txtkodepegawai.Text & "'"
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
            query = "Insert into tbpegawai(Kodepegawai,Namapegawai,Password,Hakakses,IsActive)Values" & _
                    "('" & txtkodepegawai.Text & "','" & txtnamapegawai.Text & "','" & txtpassword.Text & "','" & combohakakses.Text & "' , 1)"

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
        GeneratedCodePegawai()
        ListPegawai()
        prepareButtonCreat()
        DisableText()
    End Sub

    Private Sub FrmPegawai_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        TampilanAwal()
    End Sub
    Private Sub combohakakses_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles combohakakses.SelectedIndexChanged

    End Sub

    Private Sub btntambah_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btntambah.Click
        Select Case btntambah.Text
            Case "TAMBAH"
                GeneratedCodePegawai()
                prepareButtonSave()
                EnableText()
            Case "SIMPAN"
                If txtkodepegawai.Text = "" Then
                    msgError("Nama item tidak boleh kosong")
                    txtkodepegawai.Focus()
                ElseIf txtnamapegawai.Text = "" Then
                    msgError("Jenis item tidak boleh kosong")
                    txtnamapegawai.Focus()
                    txtkodepegawai.Focus()
                ElseIf txtpassword.Text = "" Then
                    msgError("Jenis item tidak boleh kosong")
                    txtpassword.Focus()
                ElseIf combohakakses.Text = "" Then
                    msgError("Harga tidak boleh kosong")
                    combohakakses.Focus()
                Else
                    SimpanData()
                    TampilanAwal()
                End If
        End Select
    End Sub

    Private Sub txtCari_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCari.TextChanged
        If cmbCari.Text = "KODE PEGAWAI" Then
            Try
                OpenConnection()
                Dim query As String = "Select * from tbpegawai" & _
                                        " Where kodepegawai Like '%" & txtCari.Text & "%' AND IsActive = 1"
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
        ElseIf cmbCari.Text = "NAMA PEGAWAI" Then
            Try
                OpenConnection()
                Dim query As String = "Select * from tbpegawai" & _
                                        " Where namapegawai Like '%" & txtCari.Text & "%' AND IsActive = 1"
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
   

    Private Sub btnubah_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnubah.Click
        Select Case btnubah.Text
            Case "EDIT"
                EnableText()
                prepareButtonEdit()
                Me.txtkodepegawai.Enabled = False
                Me.txtnamapegawai.Focus()
                btnubah.Text = "UPDATE"
            Case "UPDATE"
                UpdateData()
                ClearText()
                DisableText()
        End Select
    End Sub

    Private Sub btnhapus_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnhapus.Click
        DeleteData()
    End Sub

    Private Sub btnkeluar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnkeluar.Click
        Select Case btnkeluar.Text
            Case "BATAL"
                TampilanAwal()
            Case "KELUAR"
                Me.Close()
        End Select
    End Sub

    Private Sub dgv_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgv.Click
        Try
            Dim row As Integer = dgv.CurrentRow.Index
            txtkodepegawai.Text = dgv.Item(0, row).Value
            txtnamapegawai.Text = dgv.Item(1, row).Value
            txtpassword.Text = dgv.Item(2, row).Value
            combohakakses.SelectedValue = dgv.Item(3, row).Value
            prepareButtonEdit()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class
