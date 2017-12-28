Imports System.Data
Imports System.Data.SqlClient
Module ModulPenjualanDvd
    Public cmd As SqlCommand
    Public conn As SqlConnection
    Public dt As DataTable
    Public ds As DataSet
    Public dr As SqlDataReader
    Public da As SqlDataAdapter
    Public Sub OpenConnection()
        Dim myConnectionString As String
        myConnectionString = "Server=INTEL_AMD-NB-PC\;database=dbpenjualandvd;trusted_Connection=True"
        Try
            conn = New SqlConnection(myConnectionString)
            conn.Open()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Sub msgError(ByVal msg As String)
        MsgBox("Error of :" & msg & ",please contact IT", MsgBoxStyle.Critical, "Peringatan")
    End Sub

  
End Module
