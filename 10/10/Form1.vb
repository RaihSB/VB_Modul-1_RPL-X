Public Class Form1
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If Not IsNumeric(TextBox1.Text) Or TextBox1.Text = "" Then
            MsgBox("Maaf, Nomor Telepon Harus Diisi Dengan Angka")
            TextBox1.Text = ""
        Else
            TextBox6.Text = Val(TextBox6.Text) + Val(TextBox7.Text)
            TextBox7.Text = Val(TextBox5.Text) - Val(TextBox7.Text)
            TextBox1.Text = ""
            TextBox2.Text = ""
            MsgBox("Terkirim")
        End If
    End Sub

    Private Sub Button2_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.TextChanged
        Label7.Text = "Karakter : " & Len(TextBox2.Text)
        TextBox7.Text = Val(TextBox4.Text) * Len(TextBox2.Text)
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        TextBox1.Enabled = True
        TextBox2.Enabled = True
        TextBox5.Text = TextBox3.Text
        Button1.Enabled = True
        TextBox6.Text = Val(TextBox6.Text) + Val(TextBox7.Text)
        TextBox7.Text = Val(TextBox5.Text) - Val(TextBox6.Text)
    End Sub

    Private Sub Form10_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        TextBox5.Enabled = False
        TextBox6.Enabled = False
        TextBox7.Enabled = False
        TextBox1.Enabled = False
        TextBox2.Enabled = False
        Button1.Enabled = False
    End Sub
End Class