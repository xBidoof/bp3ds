Imports System.IO

Public Class nouveau
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If TextBox1.Text = "" Then
            If parametres.CheckBox1.Checked = True Then
                MessageBox.Show("You have to enter the name of the project!", "Warning !", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Else
                MessageBox.Show("Vous devez rentrez le nom du projet !", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If
        Else
            If TextBox2.Text = "" Then
                If parametres.CheckBox1.Checked = True Then
                    MessageBox.Show("You have to enter the name of your plugin !", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Else
                    MessageBox.Show("Vous devez rentrez le nom de votre plugin !", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                End If
            Else

                    My.Computer.FileSystem.CreateDirectory("project\" & TextBox1.Text)
                My.Computer.FileSystem.CreateDirectory("project\" & TextBox1.Text & "\" & TextBox2.Text)
                My.Computer.FileSystem.CopyDirectory("sys\blankCheatMenu-ctrpf", "project\" & TextBox1.Text & "\" & TextBox2.Text)
                File.WriteAllText("project\" & TextBox1.Text & "\" & "cheatshlist.lc", "cheats")
                File.WriteAllText("project\" & TextBox1.Text & "\" & "cheatsclist.lc", "void     cheats(MenuEntry *entry)")
                File.WriteAllText("project\" & TextBox1.Text & "\" & "mainclist.lc", "cheats")
                File.WriteAllText("project\" & TextBox1.Text & "\" & "rp2.xcc", TextBox2.Text)
                File.WriteAllText("project\" & TextBox1.Text & "\" & TextBox1.Text & ".bp3ds", "project\" & TextBox1.Text)
                File.WriteAllText(Application.StartupPath & "\project\" & TextBox1.Text & "\" & "rp.xcc", "project\" & TextBox1.Text & "\" & TextBox2.Text)
                File.WriteAllText(Application.StartupPath & "\project\" & TextBox1.Text & "\" & "plg_request", "project\" & TextBox1.Text & "\" & TextBox2.Text)

                File.WriteAllText(Application.StartupPath & "\project\" & TextBox1.Text & "\" & "cheats" & ".fold", "---<folder>main menu<ed_folder>" & Chr(13) & "---<text>Joueur 1 invisible<end_text>---<in_folder>invisible<end_in>" & Chr(13) & "---<end_folder>")

                'RichTextBox_lirefolder_main_c.Text = Replace(RichTextBox1.Text, "---<folder>", "")
                'RichTextBox_lirefolder_main_c.Text = Replace(RichTextBox1.Text, "<ed_folder>", "")
                'RichTextBox_lirefolder_main_c.Text = Replace(RichTextBox1.Text, "---<in_folder>", "")
                'RichTextBox_lirefolder_main_c.Text = Replace(RichTextBox1.Text, "<end_in>", "")
                'RichTextBox_lirefolder_main_c.Text = Replace(RichTextBox1.Text, "---<text>", "")
                'RichTextBox_lirefolder_main_c.Text = Replace(RichTextBox1.Text, "<end_text>", "")
                'RichTextBox_lirefolder_main_c.Text = Replace(RichTextBox1.Text, "---<end_folder>", "")
                If parametres.CheckBox1.Checked = True Then
                    MessageBox.Show("The project was created !", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else
                    MessageBox.Show("Le projet a bien été créé !", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If

            End If
            End If
    End Sub

    Private Sub nouveau_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If parametres.RichTextBox1.Text.Contains("lg_en") Then
            parametres.LgEn()
        End If
        If parametres.RichTextBox1.Text.Contains("lg_fr") Then
            parametres.LgFr()
        End If
    End Sub

    Private Sub nouveau_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing

    End Sub

    Private Sub nouveau_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed

    End Sub
End Class