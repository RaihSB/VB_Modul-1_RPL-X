Public Class Form1
    Private Sub Button1_Click(ByVal sender As Object, e As EventArgs) Handles Button1.Click
        TextBox4.Text = TextBox1.Text + "" + TextBox2.Text + TextBox3.Text
        TextBox4.TextAlign = HorizontalAlignment.Center
    End Sub
End Class
