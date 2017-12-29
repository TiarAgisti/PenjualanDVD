Imports System.Data.SqlClient

Public Class FrmRekapPenjualan
    Dim intBaris As Integer
    Dim intPost As Integer
    Public Shared noPJ As String
    Public Shared kondisi As String
    Dim statusno As Integer
    Sub GenerateNoPenjualan()
        Dim urutan As String
        Dim hitung As Long
        Dim cari As Long

        OpenConnection()
        Dim query As String = " Select nopenjualan from tbpenjualanheader where nopenjualan in " &
                              " ( Select max (nopenjualan) as nopenjualan from tbpenjualanheader)"
        cmd = New SqlCommand(query, conn)
        dr = cmd.ExecuteReader
        dr.Read()

        If Not dr.HasRows Then
            urutan = "PJ/" & DateTime.Now.Year & "/" & "000001"
        Else
            cari = Microsoft.VisualBasic.Right(dr.GetString(0), 6)
            If Microsoft.VisualBasic.Left(dr.GetString(0), 8) <> "NO/" & DateTime.Now.Year & "/" Then
                urutan = "PJ/" & DateTime.Now.Year & "/" & 1
            Else
                hitung = Microsoft.VisualBasic.Right(dr.GetString(0), 6) + 1
                urutan = "PJ/" & DateTime.Now.Year & "/" & Microsoft.VisualBasic.Right("000000" & hitung, 6)
            End If
        End If
        dr.Close()
        txtkodepenjualan.Text = urutan
    End Sub
    Sub HapusTextItem()
        txtkodeitem.Clear()
        txtnamaitem.Clear()
        txtJenisItem.Clear()
        txtharga.Clear()
        txtqty.Clear()
        'txtGrandTotal.Clear()
    End Sub
    Sub TampilGridDetail()
        dgv.Columns.Add(0, "KODE ITEM")
        dgv.Columns.Add(1, "NAMA ITEM")
        dgv.Columns.Add(2, "JENIS ITEM")
        dgv.Columns.Add(3, "HARGA ITEM")
        dgv.Columns.Add(4, "QTY")
        dgv.ReadOnly = True
    End Sub
    Sub TampilanAwal()
        GenerateNoPenjualan()
        HapusTextItem()
        txtkodeitem.Focus()
        dgv.Columns.Clear()
        TampilGridDetail()
        btnSimpan.Enabled = True
        btnBatal.Enabled = True
        btnAprove.Enabled = False
        btnVoid.Enabled = False
    End Sub
    Sub AddGrid()
        dgv.Rows.Add()
        dgv.Item(0, intBaris).Value = txtkodeitem.Text
        dgv.Item(1, intBaris).Value = txtnamaitem.Text
        dgv.Item(2, intBaris).Value = txtJenisItem.Text
        dgv.Item(3, intBaris).Value = txtharga.Text
        dgv.Item(4, intBaris).Value = txtqty.Text
        intBaris = intBaris + 1
    End Sub
    Sub DeleteGrid()
        If dgv.Rows.Count > 1 Then
            dgv.Rows.RemoveAt(dgv.CurrentCell.RowIndex)
            intBaris = intBaris - 1
        End If
    End Sub
    Sub GrandTotalGrid()
        Dim grandtotal As Integer = 0
        If dgv.Rows.Count > 1 Then
            For i As Integer = 0 To dgv.Rows.Count - 1
                grandtotal = Val(dgv.Rows(i).Cells(3).Value) * Val(dgv.Rows(i).Cells(4).Value)
            Next
        Else
            grandtotal = 0
        End If
        txtGrandTotal.Text = grandtotal
    End Sub
    Sub RetrieveMasterItem()
        OpenConnection()
        Dim query As String = "Select * From tbMasterItem Where kodeitem = '" & txtkodeitem.Text & "' AND isactive = 1"
        cmd = New SqlCommand(query, conn)
        dr = cmd.ExecuteReader
        dr.Read()
        If dr.HasRows Then
            txtnamaitem.Text = dr.Item("NamaItem")
            txtJenisItem.Text = dr.Item("jenisitem")
            txtharga.Text = dr.Item("HargaJual")
            txtqty.Focus()
        Else
            MsgBox("Data Item tidak ditemukan")
            txtkodeitem.Focus()
        End If
        conn.Close()
        dr.Close()
    End Sub
    Sub RetrieveNoPenjualanHeader()
        Dim query As String = "Select PJ.nopenjualan,PJ.tanggalpenjualan,PJ.Status"
        query += " From tbpenjualanheader as PJ"
        query += " Where PJ.nopenjualan = '" & noPJ & "'"
        Try
            OpenConnection()
            cmd = New SqlCommand(query, conn)
            dr = cmd.ExecuteReader
            dr.Read()
            If dr.HasRows Then
                txtkodepenjualan.Text = dr.Item("nopenjualan")
                noPJ = dr.Item("nopenjualan")
                tglpenjualan.Value = dr.Item("tanggalpenjualan")
                statusno = dr.Item("status")
            Else
                MsgBox("Data NO tidak ditemukan")
                txtkodeitem.Focus()
            End If
            conn.Close()
            dr.Close()
        Catch ex As Exception
            Throw ex
        End Try
    End Sub
    Sub RetrieveNoPenjualanDetail()
        Dim query As String = "Select pjdet.*"
        query += ", item.namaitem, item.jenisitem"
        query += " From tbpenjualandetail as pjdet"
        query += " inner join tbmasteritem as item on item.kodeitem = pjdet.kodeitem"
        query += " Where pjdet.nopenjualan = '" & noPJ & "'"
        Try
            OpenConnection()
            cmd = New SqlCommand(query, conn)
            dr = cmd.ExecuteReader
            TampilGridDetail()
            While dr.Read
                If Not IsDBNull(dr.Item("nopenjualan")) Then
                    dgv.Rows.Add()
                    dgv.Item(0, intBaris).Value = dr.Item("kodeitem")
                    dgv.Item(1, intBaris).Value = dr.Item("namaitem")
                    dgv.Item(2, intBaris).Value = dr.Item("jenisitem")
                    dgv.Item(3, intBaris).Value = dr.Item("hargajual")
                    dgv.Item(4, intBaris).Value = dr.Item("qty")
                    intBaris = intBaris + 1
                End If
            End While
            GrandTotalGrid()
        Catch ex As Exception
            Throw ex
        End Try
    End Sub
    Private Function CreateData() As Boolean
        Dim Result As Boolean = False
        Dim SQLHeader As String
        Dim SQLDetail As String
        Dim Trans As SqlTransaction
        Dim detail As Integer
        OpenConnection()
        Trans = conn.BeginTransaction
        Try

            SQLHeader = "Insert into tbpenjualanheader(nopenjualan,tanggalpenjualan,status,kodepegawai)values" &
                        "('" & txtkodepenjualan.Text & "'" &
                        ",'" & Format(Me.tglpenjualan.Value, "yyyy-MM-dd") & "'" &
                        ",1,'" & MenuUtama.stKodePegawai.Text & "')"
            cmd = New SqlCommand(SQLHeader, conn, Trans)
            cmd.ExecuteNonQuery()

            For detail = 0 To Me.dgv.Rows.Count - 2
                SQLDetail = "Insert into tbpenjualandetail(nopenjualan,kodeitem,qty,harga)values" &
                            "('" & txtkodepenjualan.Text & "'" &
                            ",'" & Me.dgv.Rows(detail).Cells(0).Value & "'" &
                            ",'" & Me.dgv.Rows(detail).Cells(4).Value & "'" &
                            ",'" & Me.dgv.Rows(detail).Cells(3).Value & "')"
                cmd = New SqlCommand(SQLDetail, conn, Trans)
                cmd.ExecuteNonQuery()
            Next
            Trans.Commit()
            Result = True
            conn.Close()
            cmd.Dispose()
        Catch ex As SqlException
            Trans.Rollback()
            MsgBox(ex.Message)
            Result = False
        End Try
        Return Result
    End Function
    Private Function UpdateData() As Boolean
        Dim Result As Boolean = False
        Dim SQLHeader As String
        Dim SQLDetail As String
        Dim Trans As SqlTransaction
        Dim detail As Integer
        OpenConnection()
        Trans = conn.BeginTransaction
        Try
            SQLHeader = "Update tbpenjualanheader Set kodeitem='" & txtkodeitem.Text & "' Where nopenjualan='" & txtkodepenjualan.Text & "'"

            cmd = New SqlCommand(SQLHeader, conn, Trans)
            cmd.ExecuteNonQuery()

            Dim deleteSql As String = "Delete From tbpenjualandetail Where nopenjualan='" & txtkodepenjualan.Text & "'"
            cmd = New SqlCommand(deleteSql, conn, Trans)
            cmd.ExecuteNonQuery()

            For detail = 0 To Me.dgv.Rows.Count - 2
                SQLDetail = "Insert into tbpenjualandetail(nopenjualan,kodeitem,qty)values" &
                            "('" & txtkodepenjualan.Text & "'" &
                            ",'" & Me.dgv.Rows(detail).Cells(0).Value & "'" &
                            ",'" & Me.dgv.Rows(detail).Cells(3).Value & "'" &
                            ",'" & Me.dgv.Rows(detail).Cells(4).Value & "')"
                cmd = New SqlCommand(SQLDetail, conn, Trans)
                cmd.ExecuteNonQuery()
            Next
            Trans.Commit()
            Result = True
            conn.Close()
            cmd.Dispose()
        Catch ex As Exception
            Trans.Rollback()
            MsgBox(ex.Message)
            Result = False
        End Try
        Return Result
    End Function
    Function CheckIsEmpty()
        Dim status As Boolean = True

        If txtGrandTotal.Text = "" Then
            msgError("Kode item belum dimasukan")
            txtkodeitem.Focus()
        Else
            status = False
        End If
        Return status
    End Function
    Sub TampilanUpdate()
        Try
            RetrieveNoPenjualanHeader()
            RetrieveNoPenjualanDetail()
            If statusno = 1 Then
                btnAprove.Enabled = True
                btnVoid.Enabled = True
            ElseIf statusno = 3 Then
                btnAprove.Enabled = False
                btnVoid.Enabled = True
                btnSimpan.Enabled = False
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub
    Sub SetujuiData()
        Dim sql As String
        sql = "Update tbpenjualanheader set status = 3 where nopenjualan = '" & txtkodepenjualan.Text & "'"
        Try
            OpenConnection()
            cmd = New SqlCommand(sql, conn)
            cmd.ExecuteNonQuery()
            MsgBox("Data Berhasil Di Setujui")
            TampilanAwal()
        Catch ex As Exception
            msgError(ex.Message)
        End Try
    End Sub
    Sub TolakData()
        Dim sql As String
        sql = "Update tbpenjualanheader set status = 0 where nopenjualan = '" & txtkodepenjualan.Text & "'"
        Try
            OpenConnection()
            cmd = New SqlCommand(sql, conn)
            cmd.ExecuteNonQuery()
            MsgBox("Data Berhasil Di Tolak")
            TampilanAwal()
        Catch ex As Exception
            msgError(ex.Message)
        End Try
    End Sub
    Private Sub btnotomatis_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnotomatis.Click
        FrmMasterItem.ShowDialog()
    End Sub

    Private Sub txtkodeitem_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtkodeitem.KeyPress
        If e.KeyChar = Chr(13) Then
            RetrieveMasterItem()
        End If
    End Sub

    Private Sub btnTambah_Click(sender As Object, e As EventArgs) Handles btnTambah.Click
        If txtkodeitem.Text = "" Then
            msgError("Kode Item belum diisi")
            txtkodeitem.Focus()
        ElseIf txtqty.Text = "" Then
            msgError("Qty tidak boleh kosong")
        Else
            AddGrid()
            HapusTextItem()
            GrandTotalGrid()
            txtkodeitem.Focus()
        End If
    End Sub

    Private Sub btnhapus_Click(sender As Object, e As EventArgs) Handles btnhapus.Click
        DeleteGrid()
        GrandTotalGrid()
    End Sub

    Private Sub btnBatal_Click(sender As Object, e As EventArgs) Handles btnBatal.Click
        TampilanAwal()
    End Sub

    Private Sub btnKeluar_Click(sender As Object, e As EventArgs) Handles btnKeluar.Click
        Close()
    End Sub

    Private Sub btnSimpan_Click(sender As Object, e As EventArgs) Handles btnSimpan.Click
        Try
            If CheckIsEmpty() = False Then
                Select Case kondisi
                    Case "Create"
                        If CreateData() = True Then
                            MsgBox("Data Berhasil disimpan")
                            TampilanAwal()
                        End If
                    Case "Update"
                        If UpdateData() = True Then
                            MsgBox("Data Berhasil diupdate")
                            'TampilanAwal()
                            btnSimpan.Enabled = False
                            btnBatal.Enabled = False
                        End If
                End Select
            End If
        Catch ex As Exception
            msgError(ex.Message)
        End Try
    End Sub

    Private Sub btnAprove_Click(sender As Object, e As EventArgs) Handles btnAprove.Click
        SetujuiData()
    End Sub

    Private Sub btnVoid_Click(sender As Object, e As EventArgs) Handles btnVoid.Click
        TolakData()
    End Sub

    Private Sub FrmRekapPenjualan_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Select Case kondisi
                Case "Create"
                    TampilanAwal()
                Case "Update"
                    TampilanUpdate()
            End Select
        Catch ex As Exception
            msgError(ex.Message)
        End Try
    End Sub

    Private Sub txtkodeitem_Validated(sender As Object, e As EventArgs) Handles txtkodeitem.Validated
        If txtkodeitem.Text = "" Then
            txtkodeitem.Text = ""
        Else
            RetrieveMasterItem()
        End If
    End Sub

    Private Sub txtqty_TextChanged(sender As Object, e As EventArgs) Handles txtqty.TextChanged
        If txtqty.Text = "" Then
            txtqty.Text = ""
        Else
            If Not IsNumeric(txtqty.Text) Then
                txtqty.Text = ""
            Else
                txtqty.Focus()
            End If
        End If
    End Sub
End Class