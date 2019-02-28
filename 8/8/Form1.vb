Public Class Form1
    Private ReadOnly GroupBox1 As Object

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        GroupBox1.Text = "Bujur Sangkar"
        Label1.Text = "Sisi"
        'TextBox2.Visible = False
        TextBox2.Text = ""
        Label2.Visible = False
        TextBox3.Text = Val(TextBox1.Text) * Val(TextBox1.Text)
        TextBox2.Enabled = False
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        GroupBox1.Text = "Balok"
        Label1.Text = "Panjang"
        Label2.Text = "Lebar"
        TextBox3.Text = Val(TextBox1.Text) * Val(TextBox2.Text)
        TextBox2.Enabled = True
        Label2.Visible = True
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        GroupBox1.Text = "Segitiga Siku-Siku"
        Label1.Text = "Alas"
        Label2.Text = "Tinggi"
        TextBox3.Text = Val(TextBox1.Text) * Val(TextBox2.Text) / 2
        TextBox2.Enabled = True
        Label2.Visible = True
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        GroupBox1.Text = "Jajar Genjang"
        Label1.Text = "Alas"
        Label2.Text = "Tinggi"
        TextBox3.Text = Val(TextBox1.Text) * Val(TextBox2.Text)
        TextBox2.Enabled = True
        Label2.Visible = True
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        GroupBox1.Text = "Lingkaran"
        Label1.Text = "Jari-Jari"
        Label2.Text = "phi"
        TextBox2.Text = "3.14"
        TextBox2.Enabled = False
        TextBox3.Text = Val(TextBox1.Text) * (Val(TextBox2.Text) * Val(TextBox2.Text))
        Label2.Visible = True
    End Sub

End Class
