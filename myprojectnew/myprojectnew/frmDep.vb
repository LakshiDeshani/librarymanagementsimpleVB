Public Class frmDep

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub frmDep_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'call all initial methods
        'design datagridview
        xGridview(dgv1)
        xLoadDataToGridview(" DEpartment", "select * from DEpartment ", dgv1)

    End Sub

    Private Sub butsave_Click(sender As Object, e As EventArgs) Handles butsave.Click
        xSaveDATA("DEpartment", "DEpartment name", New String() {txtDep.Text})

        MsgBox("Successfully Saved", MsgBoxStyle.Information, "Confirm")
        'load data to gridview
        LoadDEpartment()
        'clear all
        txtDep.Clear()
        txtDep.Focus()

    End Sub
    Sub clearAll()
        'clear all
        txtDep.Clear()
        txtDep.Focus()
    End Sub


    Private Sub LoadDEpartment()

    End Sub

    Private Sub txtDep_TextChanged(sender As Object, e As EventArgs) Handles txtDep.TextChanged

    End Sub

    Private Sub txtsearch_TextChanged(sender As Object, e As EventArgs) Handles txtsearch.TextChanged
        Dim sql As String = ""
        sql = "select*from DEpartment where Department_name like '%" & txtsearch.Text & "%'"
        xLoadDataToGridview("DEpartment", sql, dgv1)

    End Sub

    Private Sub butExit_Click(sender As Object, e As EventArgs) Handles butExit.Click
        Me.Close()
        frmMain.Show()

    End Sub
End Class