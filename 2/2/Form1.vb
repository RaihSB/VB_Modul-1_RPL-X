Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim tampung As String
        tampung = TextBox3.Text
        TextBox3.Text = TextBox2.Text
        TextBox2.Text = TextBox1.Text
        TextBox1.Text = tampung
    End Sub
End Class
