Imports Connection
Imports System.Data
Imports System.Data.SqlClient
Partial Class Popularity
    Inherits System.Web.UI.Page

    Protected Sub btnBack_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnBack.Click
        Response.Redirect("index.aspx")
    End Sub


    Private Sub BindYear()
        ddlYear.Items.Clear()
        ddlYear.Items.Add("-Please Select-")
        For i As Integer = 1944 To 2013
            ddlYear.Items.Add(i.ToString())
        Next
    End Sub


    Private Sub BindGender()
        ddlGender.Items.Clear()
        ddlGender.Items.Add("-Please Select-")
        ddlGender.Items.Add("Male")
        ddlGender.Items.Add("Female")

    End Sub

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Not Page.IsPostBack Then
            BindYear()

            BindGender()

        End If
    End Sub


  

    Protected Sub Button1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button1.Click

        If txtName.Text <> "" Then


            Dim FilterClause As String = ""
            Dim topclause As String = "select  Year, Name, SUM(Amount) as Amount from ("

            Dim str As String = " SELECT Master.Name, Master.Amount, Master.Position, Gender.Gender, Master.Year "
            str += " FROM Gender LEFT OUTER JOIN Master ON Gender.GenderId = Master.GenderID " + FilterClause + ") as T1 "

            Dim endclause As String = " group by year,name order by YEAR "




            If txtName.Text <> "" Then

                FilterClause += " where Name like '" + txtName.Text + "'"
            Else
                FilterClause += ""
            End If


            If ddlYear.SelectedIndex > 0 Then


                FilterClause += " and Year between '" + ddlYear.SelectedItem.ToString() + "' and '2013'"
            Else
                FilterClause += " "

            End If


            If ddlGender.SelectedIndex > 0 Then
                If ddlGender.SelectedIndex = 3 Then
                    FilterClause += ""
                Else
                    FilterClause += " and Gender='" + ddlGender.SelectedItem.ToString() + "'"
                End If
            End If

            Dim dt As DataTable = Connection.BindDt(topclause + str + FilterClause + endclause)
            GridView1.DataSource = dt
            GridView1.DataBind()

        End If

    
    End Sub
End Class
