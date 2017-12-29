Imports System.Data
Imports System.Data.SqlClient

Public Class FrmListRekapPenjualan
    Sub TampilData()
        Dim query As String
        query = "SELECT * FROM tbpenjualanheader"
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
        dgv.Columns(0).HeaderText = "No Penjualan"
        dgv.Columns(0).Width = 120
        dgv.Columns(1).HeaderText = "Tanggal"
        dgv.Columns(2).HeaderText = "Status"
        dgv.Columns(2).Width = 150
        dgv.Columns(3).HeaderText = "Kode Pegawai"
        dgv.Columns(3).Width = 120
    End Sub

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click

    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub FrmListRekapPenjualan_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call TampilData()
    End Sub
End Class