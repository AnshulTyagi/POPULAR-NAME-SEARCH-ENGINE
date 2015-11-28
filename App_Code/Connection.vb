Imports Microsoft.VisualBasic
Imports System.Data.SqlClient
Imports System.Data
Public Class Connection
    Public Shared ConStr As String = "Data Source=DESKTOP-VQ0SO5A;User Id=sa;password=welcome;initial catalog=Proj"
    Shared con As SqlConnection
    ''Shared Con As New SqlClient.SqlConnection(GlobalSettings.ConStr)
    Shared cmd As SqlCommand
    Public Shared Sub OpenCon()
        con = New SqlConnection(ConStr)
        ' In case of connection is open then this not work
        If con.State = ConnectionState.Closed Then
            Try
                con.Open()
            Catch ex As Exception
                MsgBox(ex.ToString(), MsgBoxStyle.AbortRetryIgnore)
            End Try
        End If
    End Sub

    Public Shared Function GetUniqueID(ByVal Table As String) As String
        ' Method use to generate your table unique ID
        Dim Id As String = Table + "ID"
        Dim UID As String = ""
        Dim sql As String = "select ISNULL(" + Id.ToString() + ",0)+1 as " + Id.ToString() + " from (select max(" + Id.ToString() + ") as " + Id.ToString() + "  from " + Table + " ) as T1"
        OpenCon()
        cmd = New SqlCommand(sql, con)
        UID = cmd.ExecuteScalar()
        Return UID
    End Function


    Public Shared Function GetUniqueNo(ByVal Table As String, ByVal SDate As String, ByVal EDate As String) As String
        ' Method use to generate your table unique ID
        Dim Id As String = Table + "ID"
        Dim UNo As String = ""
        Dim sql As String = "select RIGHT('00000' + CONVERT(varchar(5),ISNULL(" + Id.ToString() + ",0)+1),5) as " + Id.ToString() + " from (select max(" + Id.ToString() + ") as " + Id.ToString() + "   from " + Table + " where dated between '" + SDate + "' and '" + EDate + "') as T1"
        OpenCon()
        cmd = New SqlCommand(sql, con)
        UNo = cmd.ExecuteScalar()
        Return UNo
    End Function

   



    Public Shared Function BindDt(ByVal Str As String) As DataTable
        Dim dt As DataTable = New DataTable()
        OpenCon()
        cmd = New SqlCommand(Str, con)
        Dim da As SqlDataAdapter = New SqlDataAdapter(cmd)
        da.Fill(dt)
        Return dt
    End Function

End Class
