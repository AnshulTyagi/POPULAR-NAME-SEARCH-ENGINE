Imports Connection
Imports System.Data
Imports System.Data.SqlClient
Partial Class index
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        If Not Page.IsPostBack Then
            BindYear()
            BindGap()
            BindGender()
        End If
    End Sub

    Private Sub BindYear()
        ddlYear.Items.Clear()
        ddlYear.Items.Add("-Please Select-")
        For i As Integer = 1944 To 2013
            ddlYear.Items.Add(i.ToString())
        Next
    End Sub


    Private Sub BindGap()
        ddlTop.Items.Clear()
        ddlTop.Items.Add("-Please Select-")
        For i As Integer = 10 To 1000
            ddlTop.Items.Add(i.ToString())
            i = 9 + i
        Next
    End Sub


    Private Sub BindGender()
        ddlGender.Items.Clear()
        ddlGender.Items.Add("-Please Select-")
        ddlGender.Items.Add("Male")
        ddlGender.Items.Add("Female")

    End Sub


    Private Sub Binddata()

        Dim str As String = " SELECT     TOP (10) Master.Name, Master.Amount, Master.Position, Master.Year, Gender.Gender FROM   Master INNER JOIN  Gender ON Master.GenderID = Gender.GenderId"

        Dim dt As DataTable = Connection.BindDt(str)
        GridView1.DataSource = dt
        GridView1.DataBind()

    End Sub

    Protected Sub Button1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button1.Click

        Dim str As String = "SELECT Master.Name, Master.Amount, Master.Position, Gender.Gender, Master.Year FROM Gender LEFT OUTER JOIN Master ON Gender.GenderId = Master.GenderID "
        Dim FilterClause As String = ""
        Dim topclause As String = " select * from ( "
        Dim endclause As String = " ) as T1"

        If ddlYear.SelectedIndex > 0 Then

            FilterClause += " where Master.Year=" + ddlYear.SelectedItem.ToString()

        End If

        If ddlGender.SelectedIndex > 0 Then
            If ddlGender.SelectedIndex = 3 Then
                FilterClause = ""
            Else
                FilterClause += " and Gender.Gender='" + ddlGender.SelectedItem.ToString() + "'"
            End If
        End If

            If ddlTop.SelectedIndex > 0 Then
                topclause = " select top " + ddlTop.SelectedItem.ToString() + " Name, SUM(Amount) as Amount, Gender, YEAR from ("
                endclause = " ) as t1 group by Name, Gender, year order by Amount Desc "
            End If

            Dim dt As DataTable = Connection.BindDt(topclause + str + FilterClause + endclause)
            GridView1.DataSource = dt
            GridView1.DataBind()


    End Sub

    Protected Sub btnPopularity_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnPopularity.Click
        Response.Redirect("Popularity.aspx")
    End Sub
End Class
