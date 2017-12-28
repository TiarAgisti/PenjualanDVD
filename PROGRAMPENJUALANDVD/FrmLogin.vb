Imports System.Data
Imports System.Data.SqlClient
Public Class FrmLogin
    Function ValidasiLogin() As Boolean
        Try
            Dim query As String
            query = "Select * From tbpegawai Where KodePegawai = '" & txtKodePegawai.Text & "' AND" & _
                    " Password = '" & txtPassword.Text & "'"

            OpenConnection()
            cmd = New SqlCommand(query, conn)
            dr = cmd.ExecuteReader
            dr.Read()
            If dr.HasRows Then
                MenuUtama.stKodePegawai.Text = dr.Item("kodepegawai")
                MenuUtama.stNamaPegawai.Text = dr.Item("namapegawai")
                MenuUtama.stHakAkses.Text = dr.Item("hakakses")
                MenuUtama.stTanggal.Text = Format(Now, "dd-MMM-yyyy")
                Return True
            Else
                Return False
            End If
            dr.Close()
            cmd.Dispose()
            conn.Close()
        Catch ex As Exception
            dr.Close()
            cmd.Dispose()
            conn.Close()
            Throw ex
        End Try
    End Function

    Private Sub FrmLogin_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Panel1_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub btnLogin_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLogin.Click
        Try
            If ValidasiLogin() Then
                MsgBox("Login Sukses", MsgBoxStyle.Information, "Informasi")
                Hide()
                MenuUtama.Show()
            Else
                MsgBox("Login gagal", MsgBoxStyle.Critical, "Peringatan")
            End If
        Catch ex As Exception
            MsgBox("Error of :" & ex.Message & ",please contact IT", MsgBoxStyle.Critical, "Peringatan")
        End Try
    End Sub

    Private Sub btnKeluar_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnKeluar.Click
        Me.Close()
    End Sub
End Class