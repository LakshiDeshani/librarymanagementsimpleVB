Public Class frmstudenr

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub frmstudenr_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'call all initial methods
        'design datagridview
        xGridview(dgv1)
        xLoadDataToGridview(" studenr", "select * from studenr ", dgv1)

    End Sub

    Private Sub butsave_Click(sender As Object, e As EventArgs) Handles butsave.Click
        xSaveDATA("studenr", "studenr", New String() {txtstudent.Text})

        MsgBox("Successfully Saved", MsgBoxStyle.Information, "Confirm")
        'load data to gridview
        Loadstudenr()
        'clear all
        txtstudent.Clear()
        txtstudent.Focus()

    End Sub
    Sub clearAll()
        'clear all
        txtstudent.Clear()
        txtstudent.Focus()
    End Sub


    Private Sub Loadstudenr()

    End Sub

    Private Sub txtstudent_TextChanged(sender As Object, e As EventArgs) Handles txtstudent.TextChanged, txtstudent.TextChanged

    End Sub

    Private Sub txtsearch_TextChanged(sender As Object, e As EventArgs) Handles txtsearch.TextChanged
        Dim sql As String = ""
        sql = "select*from studenr where student_ID like '%" & txtsearch.Text & "%'"
        xLoadDataToGridview("student", sql, dgv1)

    End Sub

    Private Sub butExit_Click(sender As Object, e As EventArgs) Handles butExit.Click
        Me.Close()
        frmMain.Show()

    End Sub
End Class