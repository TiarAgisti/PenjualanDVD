Imports System.Data.SqlClient
Public Class FrmBarangMasuk
    Dim intBaris As Integer
    Dim intPost As Integer
    Public Shared noBM As String
    Public Shared kondisi As String
    Dim statusno As Integer
    Sub GenerateNoBarangMasuk()
        Dim urutan As String
        Dim hitung As Long
        Dim cari As Long

        OpenConnection()
        Dim query As String = " Select nobarangmasuk from tbbarangmasukheader where nobarangmasuk in " & _
                              " ( Select max (nobarangmasuk) as nobarangmasuk from tbbarangmasukheader)"
        cmd = New SqlCommand(query, conn)
        dr = cmd.ExecuteReader
        dr.Read()

        If Not dr.HasRows Then
            urutan = "NO/" & DateTime.Now.Year & "/" & "000001"
        Else
            cari = Microsoft.VisualBasic.Right(dr.GetString(0), 6)
            If Microsoft.VisualBasic.Left(dr.GetString(0), 8) <> "NO/" & DateTime.Now.Year & "/" Then
                urutan = "NO/" & DateTime.Now.Year & "/" & 1
            Else
                hitung = Microsoft.VisualBasic.Right(dr.GetString(0), 6) + 1
                urutan = "NO/" & DateTime.Now.Year & "/" & Microsoft.VisualBasic.Right("000000" & hitung, 6)
            End If
        End If
        dr.Close()
        txtnomorbarangmasuk.Text = urutan
    End Sub
    Sub HapusTextItem()
        txtkodeitem.Clear()
        txtnamaitem.Clear()
        txtjenisitem.Clear()
        txtqty.Clear()
        'txtGrandTotal.Clear()
    End Sub
    Sub TampilGridDetail()
        dgv.Columns.Add(0, "KODE ITEM")
        dgv.Columns.Add(1, "NAMA ITEM")
        dgv.Columns.Add(2, "JENIS ITEM")
        dgv.Columns.Add(3, "QTY")
        dgv.ReadOnly = True
    End Sub
    Sub TampilanAwal()
        GenerateNoBarangMasuk()
        HapusTextItem()
        txtkodeitem.Focus()
        dgv.Columns.Clear()
        TampilGridDetail()
        btnSimpan.Enabled = True
        btnBatal.Enabled = True
        btnsetujui.Enabled = False
        btntolak.Enabled = False
    End Sub
    Sub AddGrid()
        dgv.Rows.Add()
        dgv.Item(0, intBaris).Value = txtkodeitem.Text
        dgv.Item(1, intBaris).Value = txtnamaitem.Text
        dgv.Item(2, intBaris).Value = txtjenisitem.Text
        dgv.Item(3, intBaris).Value = txtqty.Text
        intBaris = intBaris + 1
    End Sub
    Sub DeleteGrid()
        If dgv.Rows.Count > 1 Then
            dgv.Rows.RemoveAt(dgv.CurrentCell.RowIndex)
            intBaris = intBaris - 1
        End If
    End Sub
    Sub GrandTotalGrid()
        Dim hitungHarga As Integer = 0
        If dgv.Rows.Count > 1 Then
            For i As Integer = 0 To dgv.Rows.Count - 1
                hitungHarga = hitungHarga + Val(dgv.Rows(i).Cells(3).Value)
            Next
        Else
            hitungHarga = 0
        End If
        txtGrandTotal.Text = hitungHarga
    End Sub
    Sub RetrieveMasterItem()
        OpenConnection()
        Dim query As String = "Select * From tbMasterItem Where kodeitem = '" & txtkodeitem.Text & "' AND isactive = 1"
        cmd = New SqlCommand(query, conn)
        dr = cmd.ExecuteReader
        dr.Read()
        If dr.HasRows Then
            txtnamaitem.Text = dr.Item("NamaItem")
            txtjenisitem.Text = dr.Item("JenisItem")
            txtqty.Focus()
        Else
            MsgBox("Data Item tidak ditemukan")
            txtkodeitem.Focus()
        End If
        conn.Close()
        dr.Close()
    End Sub
    Sub RetrieveNoBarangMasukHeader()
        Dim query As String = "Select BM.nobarangmasuk,BM.tanggalbarangmasuk,BM.Status"
        query += " From tbbarangmasukheader as BM"
        query += " Where BM.nobarangmasuk = '" & noBM & "'"
        Try
            OpenConnection()
            cmd = New SqlCommand(query, conn)
            dr = cmd.ExecuteReader
            dr.Read()
            If dr.HasRows Then
                txtnomorbarangmasuk.Text = dr.Item("nobarangmasuk")
                noBM = dr.Item("nobarangmasuk")
                tglpembelian.Value = dr.Item("tanggalbarangmasuk")
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
    Sub RetrieveNoBarangMasukDetail()
        Dim query As String = "Select bmdet.*"
        query += ", item.namaitem, item.jenisitem"
        query += " From tbbarangmasukdetail as bmdet"
        query += " inner join tbmasteritem as item on item.kodeitem = bmdet.kodeitem"
        query += " Where bmdet.nobarangmasuk = '" & noBM & "'"
        Try
            OpenConnection()
            cmd = New SqlCommand(query, conn)
            dr = cmd.ExecuteReader
            TampilGridDetail()
            While dr.Read
                If Not IsDBNull(dr.Item("nobarangmasuk")) Then
                    dgv.Rows.Add()
                    dgv.Item(0, intBaris).Value = dr.Item("kodeitem")
                    dgv.Item(1, intBaris).Value = dr.Item("namaitem")
                    dgv.Item(2, intBaris).Value = dr.Item("jenisitem")
                    dgv.Item(3, intBaris).Value = dr.Item("qty")
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

            SQLHeader = "Insert into tbbarangmasukheader(nobarangmasuk,tanggalbarangmasuk,status,kodepegawai)values" & _
                        "('" & txtnomorbarangmasuk.Text & "'" & _
                        ",'" & Format(Me.tglpembelian.Value, "yyyy-MM-dd") & "'" & _
                        ",1,'" & MenuUtama.stKodePegawai.Text & "')"
            cmd = New SqlCommand(SQLHeader, conn, Trans)
            cmd.ExecuteNonQuery()

            For detail = 0 To Me.dgv.Rows.Count - 2
                SQLDetail = "Insert into tbbarangmasukdetail(nobarangmasuk,kodeitem,qty)values" & _
                            "('" & txtnomorbarangmasuk.Text & "'" & _
                            ",'" & Me.dgv.Rows(detail).Cells(0).Value & "'" & _
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
            SQLHeader = "Update tbbarangmasukheader Set kodeitem='" & txtkodeitem.Text & "' Where nobarangmasuk='" & txtnomorbarangmasuk.Text & "'"

            cmd = New SqlCommand(SQLHeader, conn, Trans)
            cmd.ExecuteNonQuery()

            Dim deleteSql As String = "Delete From tbbarangmasudetail Where nobarangmasuk='" & txtnomorbarangmasuk.Text & "'"
            cmd = New SqlCommand(deleteSql, conn, Trans)
            cmd.ExecuteNonQuery()

            For detail = 0 To Me.dgv.Rows.Count - 2
                SQLDetail = "Insert into tbbarangmasudetail(nobarangmasuk,kodeitem,qty)values" & _
                            "('" & txtnomorbarangmasuk.Text & "'" & _
                            ",'" & Me.dgv.Rows(detail).Cells(0).Value & "'" & _
                            ",'" & Me.dgv.Rows(detail).Cells(3).Value & "')"
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
    Sub TampilanUpdate()
        Try
            RetrieveNoBarangMasukHeader()
            RetrieveNoBarangMasukDetail()
            If statusno = 1 Then
                btnsetujui.Enabled = True
                btntolak.Enabled = True
            ElseIf statusno = 3 Then
                btnsetujui.Enabled = False
                btntolak.Enabled = True
                btnsimpan.Enabled = False
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub
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
    Sub SetujuiData()
        Dim sql As String
        sql = "Update tbbarangmasukheader set status = 3 where nobarangmasuk = '" & txtnomorbarangmasuk.Text & "'"
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
        sql = "Update tbbarangmasukheader set status = 0 where nobarangmasuk = '" & txtnomorbarangmasuk.Text & "'"
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
    Private Sub txtkodeitem_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtkodeitem.KeyPress
        If e.KeyChar = Chr(13) Then
            RetrieveMasterItem()
        End If
    End Sub

    Private Sub btntambah_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btntambah.Click
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

    Private Sub btnhapus_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnhapus.Click
        DeleteGrid()
        GrandTotalGrid()
    End Sub

    Private Sub btnbatal_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnbatal.Click
        TampilanAwal()
    End Sub

    Private Sub btnkeluar_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnkeluar.Click
        Close()
    End Sub

    Private Sub btnsimpan_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnsimpan.Click
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
                            btnsimpan.Enabled = False
                            btnbatal.Enabled = False
                        End If
                End Select
            End If
        Catch ex As Exception
            msgError(ex.Message)
        End Try
    End Sub

    Private Sub btnsetujui_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnsetujui.Click
        SetujuiData()
    End Sub

    Private Sub btntolak_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btntolak.Click
        TolakData()
    End Sub

    Private Sub FrmBarangMasuk_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
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

    Private Sub txtkodeitem_Validated(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtkodeitem.Validated
        If txtkodeitem.Text = "" Then
            txtkodeitem.Text = ""
        Else
            RetrieveMasterItem()
        End If
    End Sub

    Private Sub txtqty_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtqty.TextChanged
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

    Private Sub txtNota_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If e.KeyChar = Chr(13) Then
            txtkodeitem.Focus()
        End If
    End Sub
End Class