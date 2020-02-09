Imports System.IO
Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MessageBox.Show("FR: Ce logiciel est en BETA, il se peut que vous rencontrerai des bugs !" & Chr(13) & "EN: This software is in BETA, you may encounter bugs!" & Chr(13) & Chr(13) & "Created by xBidoof" & Chr(13) & Chr(13) & "Discord: xBidoof#4923" & Chr(13) & Chr(13) & Chr(13) & "Copyright @2019 || all right reserved", "Please, read", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Timer1.Start()
        Timer2.Start()
        If File.Exists(Application.StartupPath & "\stg.vgf") = True Then
        Else
            File.WriteAllText(Application.StartupPath & "\stg.vgf", "lg_fr")
        End If

        parametres.RichTextBox1.Text = My.Computer.FileSystem.ReadAllText(Application.StartupPath & "\stg.vgf")
        System.Threading.Thread.Sleep(500)
        If parametres.RichTextBox1.Text.Contains("lg_en") Then
            parametres.CheckBox1.Checked = True
            parametres.CheckBox2.Checked = False
        End If
        If parametres.RichTextBox1.Text.Contains("lg_fr") Then
            parametres.CheckBox2.Checked = True
            parametres.CheckBox1.Checked = False
        End If
    End Sub

    Private Sub MenuStrip1_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles MenuStrip1.ItemClicked

    End Sub

    Private Sub ProjetToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ProjetToolStripMenuItem1.Click
        page_new.Show()
    End Sub

    Private Sub CrééUnProjetToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CrééUnProjetToolStripMenuItem.Click
        nouveau.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If ListBox1.Items.Contains(TextBox1.Text) Then
            If parametres.CheckBox1.Checked = True Then
                MessageBox.Show("This code exists !", "Error")
            Else
                MessageBox.Show("Ce code existe déja !", "Erreur")
            End If
            TextBox1.Clear()
            Else
                ListBox1.Items.Add(TextBox1.Text)
        End If
        TextBox1.Clear()
    End Sub

    Private Sub SupprimerCetteLigneToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SupprimerCetteLigneToolStripMenuItem.Click
        ListBox1.Items.Remove(ListBox1.SelectedItem)
    End Sub

    Private Sub ModifierCetteLigneToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ModifierCetteLigneToolStripMenuItem.Click
        modifier.Show()
        modifier.TextBox1.Text = ListBox1.SelectedItem
    End Sub

    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox1.SelectedIndexChanged

    End Sub


    Private Sub ListBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox2.SelectedIndexChanged
        TextBox3.Text = ListBox2.SelectedItem
    End Sub

    Private Sub ListBox2_DoubleClick(sender As Object, e As EventArgs) Handles ListBox2.DoubleClick
        If File.Exists(Application.StartupPath & "\" & page_new.RichTextBox1.Text & "\" & ListBox2.SelectedItem & ".fold") Then
            RichTextBox2.Text = My.Computer.FileSystem.ReadAllText(Application.StartupPath & "\" & page_new.RichTextBox1.Text & "\" & TextBox3.Text & ".fold")
        Else
            If parametres.CheckBox1.Checked = True Then
                MessageBox.Show("Can't find the file" & TextBox3.Text & ".fold, please delete the item and recreateit it, if you don't do that, there will be problems when compiling", "Warning !", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Else
                MessageBox.Show("Impossible de trouver le fichier " & TextBox3.Text & ".fold, veuillez a supprimer l'item et a le recréé, si vous ne faittes pas cela, il y aura des problèmes lors de la compilation", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If

        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        File.WriteAllText(Application.StartupPath & "\" & page_new.RichTextBox1.Text & "\" & TextBox2.Text & ".fold", "---<folder>main menu<ed_folder>" & Chr(13) & "---<text>Joueur 1 invisible<end_text>---<in_folder>invisible<end_in>" & Chr(13) & "---<end_folder>")
        RichTextBox3.Text = My.Computer.FileSystem.ReadAllText(Application.StartupPath & "\" & page_new.RichTextBox1.Text & "\mainclist.lc") ' main.cpp
        RichTextBox3.AppendText(vbNewLine)
        RichTextBox3.AppendText(TextBox2.Text)
        System.Threading.Thread.Sleep(500)
        File.WriteAllText(Application.StartupPath & "\" & page_new.RichTextBox1.Text & "\mainclist.lc", RichTextBox3.Text)
        ListBox2.Items.Add(TextBox2.Text)
        TextBox2.Clear()



    End Sub

    Private Sub ToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem1.Click
        If File.Exists(Application.StartupPath & "\" & page_new.RichTextBox1.Text & "\" & TextBox2.Text & ".fold") Then
            My.Computer.FileSystem.DeleteFile(page_new.RichTextBox1.Text & "\" & TextBox2.Text & ".fold")
            ListBox1.Items.Remove(ListBox1.SelectedItem)
            If parametres.CheckBox1.Checked = True Then
                MessageBox.Show("File delete !", "Delete", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MessageBox.Show("Fichier supprimer !", "Effacer", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Else
            If parametres.CheckBox1.Checked = True Then
                MessageBox.Show("Can't find the file " & ListBox1.SelectedItem & ".fold" & Chr(13) & "maybe the file has already been deleted or moved", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Else
                MessageBox.Show("Impossible de trouver le fichier " & ListBox1.SelectedItem & ".fold" & Chr(13) & "peut être que la fichier a déja été supprimer ou déplacer", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If
            ListBox1.Items.Remove(ListBox1.SelectedItem)
            End If
    End Sub

    Private Sub SauvegarderToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SauvegarderToolStripMenuItem.Click
        'My.Computer.FileSystem.DeleteFile(page_new.RichTextBox1.Text & "\" & "cheatshlist.lc")
        Dim sw1 As New StreamWriter(Application.StartupPath & "\" & page_new.RichTextBox1.Text & "\" & "cheatshlist.lc")
        For Each item In ListBox1.Items
            sw1.WriteLine(item)
        Next
        sw1.Close()
        RichTextBox_listbox_cheatsh.Text = ""

        System.Threading.Thread.Sleep(500)

        RichTextBox_listbox_cheatsh.Text = ""
        ' My.Computer.FileSystem.DeleteFile(page_new.RichTextBox1.Text & "\" & "cheatsclist.lc")
        File.WriteAllText(page_new.RichTextBox1.Text & "\" & "cheatsclist.lc", RichTextBox1.Text)
        RichTextBox_listbox_cheatsh.Text = ""

        System.Threading.Thread.Sleep(500)

        RichTextBox_listbox_cheatsh.Text = ""
        ' My.Computer.FileSystem.DeleteFile(page_new.RichTextBox1.Text & "\" & "mainclist.lc")
        Dim sw As New StreamWriter(Application.StartupPath & "\" & page_new.RichTextBox1.Text & "\" & "mainclist.lc")
        For Each item In ListBox2.Items
            sw.WriteLine(item)
        Next
        sw.Close()

        If File.Exists(Application.StartupPath & "\" & page_new.RichTextBox1.Text & "\" & TextBox3.Text & ".fold") Then
            ' My.Computer.FileSystem.DeleteFile(Application.StartupPath & "\" & page_new.RichTextBox1.Text & "\" & TextBox3.Text & ".fold")
            File.WriteAllText(Application.StartupPath & "\" & page_new.RichTextBox1.Text & "\" & TextBox3.Text & ".fold", RichTextBox2.Text)
        End If
    End Sub

    Private Sub ToolStripMenuItem2_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        page_new.Show()
        Timer1.Stop()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If File.Exists("gen_bp3ds.exe") Then
            File.WriteAllText(Application.StartupPath & "\" & "start_debug.xxl", page_new.RichTextBox1.Text)
            Process.Start("gen_bp3ds.exe")
        Else
            If parametres.CheckBox1.Checked = True Then
                MessageBox.Show("We can't find the app gen-bp3ds.exe, check who exists and who is in the same directory as the BuildPlugin3DS.exe", "Error !", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                MessageBox.Show("Nous ne pouvons pas trouver l'application gen-bp3ds.exe, vérifier qui existe et qui est dans le même répertoire que le BuildPlugin3DS.exe", "Erreur !", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        End If
            File.WriteAllText(Application.StartupPath & "\" & "start_debug_1.xxl", page_new.RichTextBox2.Text)
    End Sub

    Private Sub ProjetToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ProjetToolStripMenuItem.Click

    End Sub

    Private Sub ParamètresToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ParamètresToolStripMenuItem.Click
        parametres.Show()
    End Sub

    Private Sub RichTextBox1_TextChanged(sender As Object, e As EventArgs) Handles RichTextBox1.TextChanged

    End Sub

    Private Sub AideToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AideToolStripMenuItem.Click
        help.Show()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        If File.Exists(Application.StartupPath & "\" & page_new.RichTextBox1.Text & "\" & "rp.xcc") Then
            TextBox6.Text = My.Computer.FileSystem.ReadAllText(Application.StartupPath & "\" & page_new.RichTextBox1.Text & "\" & "rp2.xcc")
            TextBox_readforcopyplg.Text = My.Computer.FileSystem.ReadAllText(Application.StartupPath & "\" & page_new.RichTextBox1.Text & "\" & "rp.xcc")
            My.Computer.FileSystem.CopyFile(Application.StartupPath & "\" & TextBox_readforcopyplg.Text & "\" & TextBox6.Text & ".plg", "C:\Users\" & Environment.UserName & "\Desktop\" & TextBox6.Text & ".plg")

        Else
            If parametres.CheckBox1.Checked = True Then
                MessageBox.Show("Can't copy the plugin on your desktop! The software fails to find the file rp2.xcc", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                MessageBox.Show("Impossible de copier le plugin sur votre bureau ! Le logiciel ne parvient pas a trouver le fichier rp2.xcc", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        'TextBox_readforcopyplg.Text = My.Computer.FileSystem.ReadAllText(Application.StartupPath & "\" & page_new.RichTextBox1.Text & "\" & "rp.xcc")
        'If File.Exists(Application.StartupPath & "\" & TextBox_readforcopyplg.Text & "\WindowsApp1.exe") Then
        'Process.Start(Application.StartupPath & "\" & TextBox_readforcopyplg.Text & "\WindowsApp1.exe")
        ' Else
        'If parametres.CheckBox1.Checked = True Then
        'MessageBox.Show("The compilation failed !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        'Else
        'MessageBox.Show("La compilation a échoué !", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error)
        'End If
        If parametres.CheckBox1.Checked = True Then
            MessageBox.Show("There is a problem with the launch of the compilation, I'm working on a corectif to patch this!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            MessageBox.Show("Il y a un problème au niveau du lancement de la compilation, je travaille sur un corectif pour patcher ceci !", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
        ' End If
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        PictureBox1.Visible = False
        Button3.BackColor = Color.Empty
        Timer2.Stop()
        Timer3.Start()
    End Sub

    Private Sub Timer3_Tick(sender As Object, e As EventArgs) Handles Timer3.Tick
        PictureBox1.Visible = True
        Button3.BackColor = Color.Yellow
        Timer3.Stop()
        Timer4.Start()
    End Sub

    Private Sub Timer4_Tick(sender As Object, e As EventArgs) Handles Timer4.Tick
        PictureBox1.Visible = False
        Button3.BackColor = Color.Empty
        Timer4.Stop()
        Timer5.Start()
    End Sub

    Private Sub Timer5_Tick(sender As Object, e As EventArgs) Handles Timer5.Tick
        PictureBox1.Visible = True
        Button3.BackColor = Color.Yellow
        Timer5.Stop()
        Timer2.Start()
    End Sub
End Class
