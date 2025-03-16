Public Class Form1

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub butExit_Click(sender As Object, e As EventArgs) Handles butExit.Click
        Me.Close()
    End Sub

    Private Sub butlogin_Click(sender As Object, e As EventArgs) Handles butlogin.Click
        If (txtusername.Text = "") Then
            MsgBox("Please enter user name", MsgBoxStyle.Exclamation, "Warning")
        ElseIf (txtpwd.Text = "") Then
            MsgBox("Please enter password", MsgBoxStyle.Exclamation, "Warning")
        Else
        End If

        If xCheckPassword("Admin", "username='" & txtusername.Text & "'   and Password='" & txtpwd.Text & " '") = True Then

            frmMain.Show()

            Me.Hide()

        Else
            MsgBox("Invalid user name or password", MsgBoxStyle.Exclamation, "Warning")
        End If


    End Sub


End Class
