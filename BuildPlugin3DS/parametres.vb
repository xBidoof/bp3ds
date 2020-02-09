Imports System.IO
Public Class parametres
    Private Sub parametres_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If RichTextBox1.Text.Contains("lg_en") Then
            LgEn()
        End If
        If RichTextBox1.Text.Contains("lg_fr") Then
            LgFr()
        End If
    End Sub
    Sub LgEn()
        Form1.ProjetToolStripMenuItem.Text = "Project"
        Form1.ProjetToolStripMenuItem1.Text = "Project..."
        Form1.CrééUnProjetToolStripMenuItem.Text = "Create project..."
        Form1.SauvegarderToolStripMenuItem.Text = "Save"
        Form1.ParamètresToolStripMenuItem.Text = "Settings"
        Form1.Button4.Text = "Add"
        Form1.Button2.Text = "Generate file"
        Form1.Button3.Text = "Launch compilation"
        Form1.Button1.Text = "Add"
        modifier.Button1.Text = "Change"
        nouveau.Label1.Text = "Name project:"
        nouveau.Label2.Text = "Name plugin:"
        nouveau.Button1.Text = "Create Project"
        page_new.Button2.Text = "Load..."
        page_new.Button1.Text = "New..."
        page_new.Label1.Text = "Start a new project"
        page_new.Label2.Text = "Load a project"
        modifier.Text = "Modifie"
        nouveau.Text = "New project"
        page_new.Text = "Project"
        Form1.SupprimerCetteLigneToolStripMenuItem.Text = "Delete this line"
        Form1.ModifierCetteLigneToolStripMenuItem.Text = "Modifier this line"
        Form1.ToolStripMenuItem1.Text = "Delete this line"
        Form1.AideToolStripMenuItem.Text = "Help"
        help.Text = "Help"
        Form1.Button5.Text = "Copy .plg file to your desktop"
    End Sub

    Sub LgFr()
        Form1.ProjetToolStripMenuItem.Text = "Projet"
        Form1.ProjetToolStripMenuItem1.Text = "Projet..."
        Form1.CrééUnProjetToolStripMenuItem.Text = "Créé un projet"
        Form1.SauvegarderToolStripMenuItem.Text = "Sauvegarder"
        Form1.ParamètresToolStripMenuItem.Text = "Paramètres"
        Form1.Button4.Text = "Ajouter"
        Form1.Button2.Text = "Généré les fichiers"
        Form1.Button3.Text = "Lancez la compilation"
        Form1.Button1.Text = "Ajouter"
        modifier.Button1.Text = "Changez"
        nouveau.Label1.Text = "Non du projet:"
        nouveau.Label2.Text = "Nom du plugin:"
        nouveau.Button1.Text = "Créé"
        page_new.Button2.Text = "Charger.."
        page_new.Button1.Text = "Nouveau..."
        page_new.Label1.Text = "Demarrer un nouveau projet..."
        page_new.Label2.Text = "Chargez un projet"
        modifier.Text = "Modifier"
        nouveau.Text = "Nouveau projet"
        page_new.Text = "Projet"
        Form1.SupprimerCetteLigneToolStripMenuItem.Text = "Supprimer cette ligne"
        Form1.ModifierCetteLigneToolStripMenuItem.Text = "Modifier cette ligne"
        Form1.ToolStripMenuItem1.Text = "Supprimer cette ligne"
        Form1.AideToolStripMenuItem.Text = "Aide"
        help.Text = "Aide"
        Form1.Button5.Text = "Copier le .plg sur le bureau"
    End Sub
    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        CheckBox2.Checked = False
        Form1.ProjetToolStripMenuItem.Text = "Project"
        Form1.ProjetToolStripMenuItem1.Text = "Project..."
        Form1.CrééUnProjetToolStripMenuItem.Text = "Create project..."
        Form1.SauvegarderToolStripMenuItem.Text = "Save"
        Form1.ParamètresToolStripMenuItem.Text = "Settings"
        Form1.Button4.Text = "Add"
        Form1.Button2.Text = "Generate file"
        Form1.Button3.Text = "Launch compilation"
        Form1.Button1.Text = "Add"
        modifier.Button1.Text = "Change"
        nouveau.Label1.Text = "Name project:"
        nouveau.Label2.Text = "Name plugin:"
        nouveau.Button1.Text = "Create Project"
        page_new.Button2.Text = "Load..."
        page_new.Button1.Text = "New..."
        page_new.Label1.Text = "Start a new project"
        page_new.Label2.Text = "Load a project"
        modifier.Text = "Modifie"
        nouveau.Text = "New project"
        page_new.Text = "Project"
        Form1.SupprimerCetteLigneToolStripMenuItem.Text = "Delete this line"
        Form1.ModifierCetteLigneToolStripMenuItem.Text = "Modifier this line"
        Form1.ToolStripMenuItem1.Text = "Delete this line"
        Form1.AideToolStripMenuItem.Text = "Help"
        help.Text = "Help"
        Form1.Button5.Text = "Copy .plg file to your desktop"
        If RichTextBox1.Text.Contains("lg_fr") Then
            RichTextBox1.Text = Replace(RichTextBox1.Text, "lg_fr", "lg_en")
        Else
            If RichTextBox1.Text.Contains("lg_en") Then
            Else
                RichTextBox1.Text = Replace(RichTextBox1.Text, "lg_en", "")
            End If
        End If
        If File.Exists(Application.StartupPath & "\stg.vgf") Then
            My.Computer.FileSystem.DeleteFile(Application.StartupPath & "\stg.vgf")
            File.WriteAllText(Application.StartupPath & "\stg.vgf", RichTextBox1.Text)
        Else

        End If


    End Sub

    Private Sub CheckBox2_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox2.CheckedChanged
        CheckBox1.Checked = False
        Form1.ProjetToolStripMenuItem.Text = "Projet"
        Form1.ProjetToolStripMenuItem1.Text = "Projet..."
        Form1.CrééUnProjetToolStripMenuItem.Text = "Créé un projet"
        Form1.SauvegarderToolStripMenuItem.Text = "Sauvegarder"
        Form1.ParamètresToolStripMenuItem.Text = "Paramètres"
        Form1.Button4.Text = "Ajouter"
        Form1.Button2.Text = "Généré les fichiers"
        Form1.Button3.Text = "Lancez la compilation"
        Form1.Button1.Text = "Ajouter"
        modifier.Button1.Text = "Changez"
        nouveau.Label1.Text = "Non du projet:"
        nouveau.Label2.Text = "Nom du plugin:"
        nouveau.Button1.Text = "Créé"
        page_new.Button2.Text = "Charger.."
        page_new.Button1.Text = "Nouveau..."
        page_new.Label1.Text = "Demarrer un nouveau projet..."
        page_new.Label2.Text = "Chargez un projet"
        modifier.Text = "Modifier"
        nouveau.Text = "Nouveau projet"
        page_new.Text = "Projet"
        Form1.SupprimerCetteLigneToolStripMenuItem.Text = "Supprimer cette ligne"
        Form1.ModifierCetteLigneToolStripMenuItem.Text = "Modifier cette ligne"
        Form1.ToolStripMenuItem1.Text = "Supprimer cette ligne"
        Form1.AideToolStripMenuItem.Text = "Aide"
        help.Text = "Aide"
        Form1.Button5.Text = "Copier le .plg sur le bureau"
        If RichTextBox1.Text.Contains("lg_en") Then
            RichTextBox1.Text = Replace(RichTextBox1.Text, "lg_en", "lg_fr")
        Else
            If RichTextBox1.Text.Contains("lg_fr") Then
            Else
                RichTextBox1.Text = Replace(RichTextBox1.Text, "lg_fr", "")
            End If
        End If
        If File.Exists(Application.StartupPath & "\stg.vgf") Then
            My.Computer.FileSystem.DeleteFile(Application.StartupPath & "\stg.vgf")
            File.WriteAllText(Application.StartupPath & "\stg.vgf", RichTextBox1.Text)
        Else

        End If


    End Sub

    Private Sub parametres_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing

    End Sub

    Private Sub parametres_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed

    End Sub
End Class