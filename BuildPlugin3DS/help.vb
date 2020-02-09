Public Class help
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs) Handles TextBox3.TextChanged

    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        If parametres.CheckBox1.Checked = True Then
            MessageBox.Show("Send me a message that I can correct the link!", "Invalid link", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            MessageBox.Show("Envoyez-moi un message que je puis corrigez le lien !", "Lien invalide", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub help_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If parametres.RichTextBox1.Text.Contains("lg_en") Then
            parametres.CheckBox1.Checked = True
            parametres.CheckBox2.Checked = False
        End If
        If parametres.RichTextBox1.Text.Contains("lg_fr") Then
            parametres.CheckBox2.Checked = True
            parametres.CheckBox1.Checked = False
        End If
    End Sub
End Class