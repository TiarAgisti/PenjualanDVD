Public Class MenuUtama

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        stJam.Text = TimeOfDay
    End Sub
    Sub menuKeluar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles menuKeluar.Click
        Timer1.Stop()
        Application.Exit()
    End Sub
    Private Sub FrmMenuUtama_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Application.Exit()
    End Sub
    Private Sub menuBarang_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles menuBarang.Click
        FrmMasterItem.ShowDialog()
    End Sub

    Private Sub menuLapPembelian_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles menuLapPembelian.Click

    End Sub

    Private Sub menuLapBrgMsk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles menuLapBrgMsk.Click

    End Sub

    Private Sub menuGantiPassword_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles menuGantiPassword.Click
        Dim frm As FrmGantiPassword = New FrmGantiPassword
        frm.ShowDialog()
    End Sub
    Private Sub menuUser_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles menuUser.Click
        FrmPegawai.ShowDialog()
    End Sub

    Private Sub menuPenjualanHeader_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles menuPenjualanHeader.Click
        FrmListBarangMasuk.ShowDialog()
    End Sub

    Private Sub menuPenjualanDetail_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles menuPenjualanDetail.Click
        FrmListRekapPenjualan.ShowDialog()
    End Sub

    Private Sub menuBarangMasukHeader_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles menuBarangMasukHeader.Click
        FrmPengeluaranKas.ShowDialog()
    End Sub

    Private Sub BaeangMasukDetailToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BaeangMasukDetailToolStripMenuItem.Click
        FrmReturPembelian.ShowDialog()
    End Sub
End Class