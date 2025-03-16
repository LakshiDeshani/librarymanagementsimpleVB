Public Class frmBooks

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub frmBooks_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'call all initial methods
        'design datagridview
        xGridview(dgv1)
        xLoadDataToGridview(" Books", "select * from Books ", dgv1)

    End Sub

    Private Sub butsave_Click(sender As Object, e As EventArgs) Handles butsave.Click
        xSaveDATA("Books", "Books", New String() {txtBooks.Text})

        MsgBox("Successfully Saved", MsgBoxStyle.Information, "Confirm")
        'load data to gridview
        LoadBooks()
        'clear all
        txtBooks.Clear()
        txtBooks.Focus()

    End Sub
    Sub clearAll()
        'clear all
        txtBooks.Clear()
        txtBooks.Focus()
    End Sub


    Private Sub LoadBooks()

    End Sub

    Private Sub txtBooks_TextChanged(sender As Object, e As EventArgs) Handles txtBooks.TextChanged

    End Sub

    Private Sub txtsearch_TextChanged(sender As Object, e As EventArgs) Handles txtsearch.TextChanged
        Dim sql As String = ""
        sql = "select*from Books where book_ID like '%" & txtsearch.Text & "%'"
        xLoadDataToGridview("Books", sql, dgv1)

    End Sub

    Private Sub butExit_Click(sender As Object, e As EventArgs) Handles butExit.Click
        Me.Close()
        frmMain.Show()

    End Sub

    Private Sub PanelLeft_Paint(sender As Object, e As PaintEventArgs) Handles PanelLeft.Paint

    End Sub
End Class