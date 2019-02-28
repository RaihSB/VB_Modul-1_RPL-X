Public Class Form1
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        TextBox1.Text = Mid(Label1.Text, 1, 2)
        TextBox2.Text = Mid(Label1.Text, 6, 2)
        TextBox3.Text = Mid(Label1.Text, 11, 4)
    End Sub
End Class
