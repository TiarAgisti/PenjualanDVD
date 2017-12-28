Imports System.Data
Imports System.Data.SqlClient
Public Class FrmListBarangMasuk

    Function DeleteData() As Boolean
    End Function
    Sub TampilData()
        Dim query As String
        query = "Select BM.nobarangmasuk,BM.tanggalbarangmasuk,BM.nonotapembelian,pgw.namapegawai" & _
        " , CASE WHEN bm.status = 1 THEN 'Baru' WHEN bm.status = 3 Then 'Disetujui' ELSE 'Ditolak' End StatusDesc " & _
        " From tbbarangmasukheader as BM INNER JOIN tbpegawai as pgw" & _
        " ON pgw.kodepegawai = BM.kodepegawai Where BM.status <> 0"
        Try
            OpenConnection()
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
            da.Dispose()
            cmd.Dispose()
            'ds.Dispose()
            'dt.Dispose()
        Catch ex As Exception
            Throw ex
        End Try
    End Sub
    Sub HeaderGrid()
        dgv.Columns(0).HeaderText = "No Barang Masuk"
        dgv.Columns(0).Width = 120
        dgv.Columns(1).HeaderText = "Tanggal"
        dgv.Columns(2).HeaderText = "No Nota Pembelian"
        dgv.Columns(2).Width = 150
        dgv.Columns(3).HeaderText = "Nama Pegawai"
        dgv.Columns(3).Width = 120
        dgv.Columns(4).HeaderText = "Status"
        dgv.Columns(4).Width = 100
    End Sub
    Private Sub btnSimpan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btntambah.Click
        Dim frm As FrmBarangMasuk = New FrmBarangMasuk
        FrmBarangMasuk.kondisi = "Create"
        frm.ShowDialog()
    End Sub

    Private Sub FrmListBarangMasuk_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Try
            TampilData()
        Catch ex As Exception
            msgError(ex.Message)
        End Try
    End Sub

    Private Sub btnsegarkan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsegarkan.Click
        Try
            TampilData()
        Catch ex As Exception
            msgError(ex.Message)
        End Try
    End Sub

    Private Sub btnKeluar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnKeluar.Click
        Close()
    End Sub

    Private Sub btnubah_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnubah.Click
        Dim row As Integer = dgv.CurrentRow.Index
        Dim frm As FrmBarangMasuk = New FrmBarangMasuk
        FrmBarangMasuk.noBM = dgv.Item(0, row).Value
        FrmBarangMasuk.kondisi = "Update"
        frm.ShowDialog()
    End Sub
End Class