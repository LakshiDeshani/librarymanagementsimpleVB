Public Class frmissues

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub frmissues_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'call all initial methods
        'design datagridview
        xGridview(dgv1)
        xLoadDataToGridview(" issues", "select * from issues ", dgv1)

    End Sub

    Private Sub butsave_Click(sender As Object, e As EventArgs) Handles butsave.Click
        xSaveDATA("issues", "issues", New String() {txtissues.Text})

        MsgBox("Successfully Saved", MsgBoxStyle.Information, "Confirm")
        'load data to gridview
        Loadissues()
        'clear all
        txtissues.Clear()
        txtissues.Focus()

    End Sub
    Sub clearAll()
        'clear all
        txtissues.Clear()
        txtissues.Focus()
    End Sub


    Private Sub Loadissues()

    End Sub

    Private Sub txtissue_TextChanged(sender As Object, e As EventArgs) Handles txtissues.TextChanged

    End Sub

    Private Sub txtsearch_TextChanged(sender As Object, e As EventArgs) Handles txtsearch.TextChanged
        Dim sql As String = ""
        sql = "select*from issues where book_ID like '%" & txtsearch.Text & "%'"
        xLoadDataToGridview("issues", sql, dgv1)

    End Sub

    Private Sub butExit_Click(sender As Object, e As EventArgs) Handles butExit.Click
        Me.Close()
        frmMain.Show()

    End Sub

    Private Sub dgv1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv1.CellContentClick

    End Sub

    Private Sub PanelLeft_Paint(sender As Object, e As PaintEventArgs) Handles PanelLeft.Paint

    End Sub
End Class