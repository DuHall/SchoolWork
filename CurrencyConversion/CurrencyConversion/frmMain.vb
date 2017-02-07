Public Class frmMain

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load


    End Sub

    Dim mouse_move As System.Drawing.Point
#Region "Window setup controls"

    Private Sub pnlTopControl_MouseDown(sender As Object, e As MouseEventArgs) Handles pnlTopControl.MouseDown
        mouse_move = New Point(-e.X, -e.Y)
    End Sub

    Private Sub pnlTopControl_MouseMove(sender As Object, e As MouseEventArgs) Handles pnlTopControl.MouseMove
        If (e.Button = Windows.Forms.MouseButtons.Left) Then
            Dim mposition As Point
            mposition = Control.MousePosition
            mposition.Offset(mouse_move.X, mouse_move.Y)
            Me.Location = mposition
        End If
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Application.Exit()
    End Sub

#End Region

    Private Sub btnConvert_Click(sender As Object, e As EventArgs) Handles btnConvert.Click

    End Sub

End Class
