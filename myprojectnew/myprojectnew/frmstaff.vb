Public Class frmstaff

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub frmstaff_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'call all initial methods
        'design datagridview
        xGridview(dgv1)
        xLoadDataToGridview(" staff", "select * from staff ", dgv1)

    End Sub

    Private Sub butsave_Click(sender As Object, e As EventArgs) Handles butsave.Click
        xSaveDATA("staff", "staff name", New String() {txtstaff.Text})

        MsgBox("Successfully Saved", MsgBoxStyle.Information, "Confirm")
        'load data to gridview
        Loadstaff()
        'clear all
        txtstaff.Clear()
        txtstaff.Focus()

    End Sub
    Sub clearAll()
        'clear all
        txtstaff.Clear()
        txtstaff.Focus()
    End Sub



    Private Sub txtstaff_TextChanged(sender As Object, e As EventArgs) Handles txtstaff.TextChanged

    End Sub

    Private Sub txtsearch_TextChanged(sender As Object, e As EventArgs) Handles txtsearch.TextChanged
        Dim sql As String = ""
        sql = "select*from staff where staff_name like '%" & txtsearch.Text & "%'"
        xLoadDataToGridview("staff", sql, dgv1)

    End Sub

    Private Sub butExit_Click(sender As Object, e As EventArgs) Handles butExit.Click
        Me.Close()
        frmMain.Show()

    End Sub

    Private Sub Loadstaff()
        Throw New NotImplementedException
    End Sub

End Class