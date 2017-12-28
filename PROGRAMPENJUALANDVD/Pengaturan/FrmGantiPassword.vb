Imports System
Imports System.Data.SqlClient
Public Class FrmGantiPassword
    Sub RetrievePasswordLama()
        Dim sql As String
        OpenConnection()
        sql = "Select password from tbpegawai where kodepegawai ='" & MenuUtama.stKodePegawai.Text & "'" & _
        " And password = '" & txtpasswordlama.Text & "'"
        cmd = New SqlCommand(sql, conn)
        dr = cmd.ExecuteReader
        dr.Read()
        If dr.HasRows Then
            txtpasswordbaru.Focus()
        Else
            msgError("Password Lama Yang Anda Masukkan Salah")
            txtpasswordlama.Clear()
            txtpasswordlama.Focus()
        End If
        dr.Close()
    End Sub
    Sub ClearText()
        txtpasswordlama.Clear()
        txtpasswordbaru.Clear()
        txtkonfirmasipassword.Clear()
    End Sub
    Sub CheckNewPassword()
        If txtpasswordbaru.Text <> txtkonfirmasipassword.Text Then
            msgError("Konfirmasi Yang Anda Masukan Salah")
            txtkonfirmasipassword.Clear()
            txtkonfirmasipassword.Focus()
        Else
            btnSimpan.Focus()
        End If
    End Sub
    Sub UpdatePassword()
        Dim sql As String
        Try
            OpenConnection()
            sql = "Update tbpegawai set password = '" & txtkonfirmasipassword.Text & "' Where kodepegawai = '" & MenuUtama.stKodePegawai.Text & "'"
            cmd = New SqlCommand(sql, conn)
            cmd.ExecuteNonQuery()
            MsgBox("Data Berhasil Disimpan")
        Catch ex As Exception
            msgError(ex.Message)
        End Try
        conn.Close()
    End Sub
    
    Private Sub txtpasswordlama_Validated(ByVal sender As Object, ByVal e As System.EventArgs)
        If txtpasswordlama.Text = "" Then
            txtpasswordlama.Text = ""
        Else
            RetrievePasswordLama()
        End If
    End Sub


    Private Sub txtpasswordbaru_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If e.KeyChar = Chr(13) Then
            txtkonfirmasipassword.Focus()
        End If
    End Sub
    Private Sub txtpasswordlama_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtpasswordlama.KeyPress
        If e.KeyChar = Chr(13) Then
            RetrievePasswordLama()
        End If
    End Sub

    Private Sub btnkeluar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnkeluar.Click
        Me.Close()
    End Sub

    Private Sub btnsimpan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsimpan.Click
        If txtpasswordlama.Text = "" Then
            msgError("Isi Dulu Password Lama")
            txtpasswordlama.Focus()
        ElseIf txtpasswordbaru.Text = "" Then
            msgError("Isi Dulu Password Baru")
            txtpasswordbaru.Focus()
        ElseIf txtkonfirmasipassword.Text = "" Then
            msgError("Isi Dulu Konfirmasi Password")
        Else
            UpdatePassword()
            ClearText()
        End If
    End Sub

    Private Sub txtkonfirmasipassword_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtkonfirmasipassword.KeyPress
        If e.KeyChar = Chr(13) Then
            CheckNewPassword()
        End If
    End Sub

    Private Sub txtkonfirmasipassword_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtkonfirmasipassword.Validated
        If txtkonfirmasipassword.Text = "" Then
            txtkonfirmasipassword.Text = ""
        Else
            CheckNewPassword()
        End If
    End Sub
End Class