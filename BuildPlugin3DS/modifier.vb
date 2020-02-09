Public Class modifier
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If Form1.RichTextBox_listbox_cheatsh.Text.Contains(TextBox1.Text) Then
            If parametres.CheckBox1.Checked = True Then
                MessageBox.Show("The code exists !", "Error")
            Else
                MessageBox.Show("Le code est déja existant !", "Erreur")
            End If
        Else
                Dim remplecr As Integer = Form1.ListBox1.SelectedIndex
            Form1.ListBox1.Items.RemoveAt(remplecr)

            Form1.ListBox1.Items.Insert(remplecr, TextBox1.Text)
            If parametres.CheckBox1.Checked = True Then
                MessageBox.Show("The code has been changed!", "Changez")
            Else

            End If
        End If

            Close()
    End Sub

    Private Sub modifier_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing

    End Sub

    Private Sub modifier_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed

    End Sub

    Private Sub modifier_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If parametres.RichTextBox1.Text.Contains("lg_en") Then
            parametres.LgEn()
        End If
        If parametres.RichTextBox1.Text.Contains("lg_fr") Then
            parametres.LgFr()
        End If
    End Sub
End Class