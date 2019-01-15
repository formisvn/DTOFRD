'Imports Npgsql
'Public Class Ketnoi
'    Public Sub ketnoi(ByVal sqlcon As String, ByVal tab As DataTable, ByRef thanhcong As Boolean)
'        Dim CN As New NpgsqlConnection(mketnoi)
'        Try
'            CN.Open()
'            Dim sqltab As New NpgsqlDataAdapter(sqlcon, CN)
'            sqltab.Fill(tab)
'        Catch ex As Exception
'            MsgBox(ex.Message, MsgBoxStyle.Exclamation, "Thông báo")
'            thanhcong = False
'        Finally
'            CN.Close()
'            CN.Dispose()
'        End Try
'    End Sub
'    Public Sub ketnoi2(ByVal sqlcon As String, ByVal tab As DataTable, ByRef thanhcong As Boolean)
'        Dim CN As New NpgsqlConnection(mketnoi2)
'        Try
'            CN.Open()
'            Dim sqltab As New NpgsqlDataAdapter(sqlcon, CN)
'            sqltab.Fill(tab)
'        Catch ex As Exception
'            MsgBox(ex.Message, MsgBoxStyle.Exclamation, "Thông báo")
'            thanhcong = False
'        Finally
'            CN.Close()
'            CN.Dispose()
'        End Try
'    End Sub
'    Public Sub ketnoi_cham(ByVal sqlcon As String, ByVal tab As DataTable, ByRef thanhcong As Boolean) ';Connect Timeout=100000
'        Dim CN As New NpgsqlConnection(mketnoi)
'        Try
'            Dim sqltab As New NpgsqlDataAdapter(sqlcon, CN)

'            CN.Open()
'            sqltab.SelectCommand.CommandTimeout = 3600
'            sqltab.Fill(tab)
'        Catch ex As Exception
'            MsgBox(ex.Message, MsgBoxStyle.Exclamation, "Thông báo")
'            thanhcong = False
'            ' Return
'        Finally
'            CN.Close()
'            CN.Dispose()
'        End Try
'    End Sub
'    Public Sub ketnoi_nhanh(ByVal sqlcon As String, ByVal tab As DataTable, ByRef thanhcong As Boolean) ';Connect Timeout=100000
'        Dim CN As New NpgsqlConnection(mketnoi)
'        Try
'            Dim sqltab As New NpgsqlDataAdapter(sqlcon, CN)

'            CN.Open()
'            sqltab.SelectCommand.CommandTimeout = 10
'            sqltab.Fill(tab)
'        Catch ex As Exception
'            MsgBox(ex.Message, MsgBoxStyle.Exclamation, "Thông báo")
'            thanhcong = False
'            ' Return
'        Finally
'            CN.Close()
'            CN.Dispose()
'        End Try
'    End Sub
'    Public Sub thucthi(ByVal SQL As String)
'        Dim con As NpgsqlConnection
'        con = New NpgsqlConnection(mketnoi)
'        con.Open()
'        Try
'            Dim comm As NpgsqlCommand
'            comm = New NpgsqlCommand(SQL, con)
'            comm.ExecuteNonQuery()
'        Catch ex As Exception
'            MsgBox(ex.Message, MsgBoxStyle.Exclamation, "Thông báo")
'        Finally
'            con.Close()
'            con.Dispose()
'        End Try

'    End Sub
'    Public Sub thucthi3(ByVal SQL As String)
'        Dim con As NpgsqlConnection
'        con = New NpgsqlConnection(mketnoi2)
'        con.Open()
'        Try
'            Dim comm As NpgsqlCommand
'            comm = New NpgsqlCommand(SQL, con)
'            comm.ExecuteNonQuery()
'        Catch ex As Exception
'            MsgBox(ex.Message, MsgBoxStyle.Exclamation, "Thông báo")
'        Finally
'            con.Close()
'            con.Dispose()
'        End Try

'    End Sub
'    Public Sub thucthi2(ByVal SQL As String)
'        Dim con As NpgsqlConnection
'        con = New NpgsqlConnection(mketnoi + ";Connect Timeout=5000")
'        con.Open()
'        Try
'            Dim comm As NpgsqlCommand
'            comm = New NpgsqlCommand(SQL, con)
'            comm.ExecuteNonQuery()
'        Catch ex As Exception
'            MsgBox(ex.Message, MsgBoxStyle.Exclamation, "Thông báo")
'        Finally
'            con.Close()
'            con.Dispose()
'        End Try

'    End Sub
'    Public Sub thucthi_loi(ByVal SQL As String)
'        Dim con As NpgsqlConnection
'        con = New NpgsqlConnection(mketnoi + ";Connect Timeout=5")
'        con.Open()
'        '
'        Dim comm As NpgsqlCommand
'        comm = New NpgsqlCommand(SQL, con)
'        comm.ExecuteNonQuery()
'        '
'        '
'        con.Close()
'        con.Dispose()
'        '

'    End Sub
'End Class
