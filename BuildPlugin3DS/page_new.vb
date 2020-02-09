Imports System.IO


Public Class page_new
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        nouveau.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim sw As New OpenFileDialog()

        sw.Filter = "|*.bp3ds"
        If sw.ShowDialog() = Windows.Forms.DialogResult.OK Then
            RichTextBox1.LoadFile(sw.FileName, RichTextBoxStreamType.PlainText)
            RichTextBox2.Text = My.Computer.FileSystem.ReadAllText(Application.StartupPath & "\" & RichTextBox1.Text & "\rp.xcc")

            If File.Exists(Application.StartupPath & "\" & RichTextBox1.Text & "\cheatshlist.lc") Then
                Dim sr As New StreamReader(Application.StartupPath & "\" & RichTextBox1.Text & "\cheatshlist.lc")
                While (sr.Peek >= 0)
                    Form1.ListBox1.Items.Add(sr.ReadLine)
                End While
                sr.Close()
            Else
                If parametres.CheckBox1.Checked = True Then
                    MessageBox.Show("Can't load the cheats.hpp", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Else
                    MessageBox.Show("Impossible de charger le cheats.hpp", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            End If

                If File.Exists(Application.StartupPath & "\" & RichTextBox1.Text & "\cheatsclist.lc") Then
                Form1.RichTextBox1.Text = My.Computer.FileSystem.ReadAllText(Application.StartupPath & "\" & RichTextBox1.Text & "\cheatsclist.lc")
            Else
                If parametres.CheckBox1.Checked = True Then
                    MessageBox.Show("Can't load the cheats.cpp", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Else
                    MessageBox.Show("Impossible de charger le cheats.hpp", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            End If

            If File.Exists(Application.StartupPath & "\" & RichTextBox1.Text & "\mainclist.lc") Then
                Dim sr As New StreamReader(Application.StartupPath & "\" & RichTextBox1.Text & "\" & "mainclist.lc")
                While (sr.Peek >= 0)
                    Form1.ListBox2.Items.Add(sr.ReadLine)
                End While
                sr.Close()
            Else
                If parametres.CheckBox1.Checked = True Then
                    MessageBox.Show("Can't load the main.cpp", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Else
                    MessageBox.Show("Impossible de charger le cheats.hpp", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            End If
            Form1.Button4.Enabled = True
            Form1.Button3.Enabled = True
            Form1.Button2.Enabled = True
            Form1.Button1.Enabled = True
            Form1.Button5.Enabled = True
        Else
            MsgBox("ShowDialog.back();")
        End If
        Me.Hide()
    End Sub

    Private Sub page_new_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing

    End Sub

    Private Sub page_new_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed

    End Sub

    Private Sub page_new_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If parametres.RichTextBox1.Text.Contains("lg_en") Then
            parametres.LgEn()
        End If
        If parametres.RichTextBox1.Text.Contains("lg_fr") Then
            parametres.LgFr()
        End If
    End Sub
End Class