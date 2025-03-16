Public Class frmreturn


    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub frmreturn_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'call all initial methods
        'design datagridview
        xGridview(dgv1)
        xLoadDataToGridview(" return", "select * from return ", dgv1)

    End Sub

    Private Sub butsave_Click(sender As Object, e As EventArgs) Handles butsave.Click
        xSaveDATA("return", "return", New String() {txtreturn.Text})

        MsgBox("Successfully Saved", MsgBoxStyle.Information, "Confirm")
        'load data to gridview
        Loadreturn()
        'clear all
        txtreturn.Clear()
        txtreturn.Focus()

    End Sub
    Sub clearAll()
        'clear all
        txtreturn.Clear()
        txtreturn.Focus()
    End Sub


    Private Sub Loadreturn()

    End Sub

    Private Sub txtDep_TextChanged(sender As Object, e As EventArgs) Handles txtreturn.TextChanged

    End Sub

    Private Sub txtsearch_TextChanged(sender As Object, e As EventArgs) Handles txtsearch.TextChanged
        Dim sql As String = ""
        sql = "select*from return where Book_ID like '%" & txtsearch.Text & "%'"
        xLoadDataToGridview("returnt", sql, dgv1)

    End Sub

    Private Sub butExit_Click(sender As Object, e As EventArgs) Handles butExit.Click
        Me.Close()
        frmMain.Show()

    End Sub
End Class