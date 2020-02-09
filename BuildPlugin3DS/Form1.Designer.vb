<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ProjetToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProjetToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.CrééUnProjetToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SauvegarderToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ParamètresToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AideToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.ContextMenuStrip_listbox_cheatsh = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.SupprimerCetteLigneToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ModifierCetteLigneToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.RichTextBox_listbox_cheatsh = New System.Windows.Forms.RichTextBox()
        Me.RichTextBox1 = New System.Windows.Forms.RichTextBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.ListBox2 = New System.Windows.Forms.ListBox()
        Me.ContextMenuStrip_listbox_maincpp = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.RichTextBox2 = New System.Windows.Forms.RichTextBox()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.RichTextBox3 = New System.Windows.Forms.RichTextBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Button5 = New System.Windows.Forms.Button()
        Me.TextBox_readforcopyplg = New System.Windows.Forms.TextBox()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.TextBox6 = New System.Windows.Forms.TextBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer3 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer4 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer5 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer6 = New System.Windows.Forms.Timer(Me.components)
        Me.MenuStrip1.SuspendLayout()
        Me.ContextMenuStrip_listbox_cheatsh.SuspendLayout()
        Me.ContextMenuStrip_listbox_maincpp.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ProjetToolStripMenuItem, Me.SauvegarderToolStripMenuItem, Me.ParamètresToolStripMenuItem, Me.AideToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1129, 24)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ProjetToolStripMenuItem
        '
        Me.ProjetToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ProjetToolStripMenuItem1, Me.CrééUnProjetToolStripMenuItem})
        Me.ProjetToolStripMenuItem.Name = "ProjetToolStripMenuItem"
        Me.ProjetToolStripMenuItem.Size = New System.Drawing.Size(50, 20)
        Me.ProjetToolStripMenuItem.Text = "Projet"
        '
        'ProjetToolStripMenuItem1
        '
        Me.ProjetToolStripMenuItem1.Name = "ProjetToolStripMenuItem1"
        Me.ProjetToolStripMenuItem1.Size = New System.Drawing.Size(180, 22)
        Me.ProjetToolStripMenuItem1.Text = "Projet..."
        '
        'CrééUnProjetToolStripMenuItem
        '
        Me.CrééUnProjetToolStripMenuItem.Name = "CrééUnProjetToolStripMenuItem"
        Me.CrééUnProjetToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.CrééUnProjetToolStripMenuItem.Text = "Créé un projet"
        '
        'SauvegarderToolStripMenuItem
        '
        Me.SauvegarderToolStripMenuItem.Name = "SauvegarderToolStripMenuItem"
        Me.SauvegarderToolStripMenuItem.Size = New System.Drawing.Size(84, 20)
        Me.SauvegarderToolStripMenuItem.Text = "Sauvegarder"
        '
        'ParamètresToolStripMenuItem
        '
        Me.ParamètresToolStripMenuItem.Name = "ParamètresToolStripMenuItem"
        Me.ParamètresToolStripMenuItem.Size = New System.Drawing.Size(78, 20)
        Me.ParamètresToolStripMenuItem.Text = "Paramètres"
        '
        'AideToolStripMenuItem
        '
        Me.AideToolStripMenuItem.Name = "AideToolStripMenuItem"
        Me.AideToolStripMenuItem.Size = New System.Drawing.Size(43, 20)
        Me.AideToolStripMenuItem.Text = "Aide"
        '
        'ListBox1
        '
        Me.ListBox1.ContextMenuStrip = Me.ContextMenuStrip_listbox_cheatsh
        Me.ListBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.ItemHeight = 16
        Me.ListBox1.Location = New System.Drawing.Point(917, 53)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(200, 388)
        Me.ListBox1.TabIndex = 2
        '
        'ContextMenuStrip_listbox_cheatsh
        '
        Me.ContextMenuStrip_listbox_cheatsh.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SupprimerCetteLigneToolStripMenuItem, Me.ModifierCetteLigneToolStripMenuItem})
        Me.ContextMenuStrip_listbox_cheatsh.Name = "ContextMenuStrip_listbox_cheatsh"
        Me.ContextMenuStrip_listbox_cheatsh.Size = New System.Drawing.Size(188, 48)
        '
        'SupprimerCetteLigneToolStripMenuItem
        '
        Me.SupprimerCetteLigneToolStripMenuItem.Name = "SupprimerCetteLigneToolStripMenuItem"
        Me.SupprimerCetteLigneToolStripMenuItem.Size = New System.Drawing.Size(187, 22)
        Me.SupprimerCetteLigneToolStripMenuItem.Text = "Supprimer cette ligne"
        '
        'ModifierCetteLigneToolStripMenuItem
        '
        Me.ModifierCetteLigneToolStripMenuItem.Name = "ModifierCetteLigneToolStripMenuItem"
        Me.ModifierCetteLigneToolStripMenuItem.Size = New System.Drawing.Size(187, 22)
        Me.ModifierCetteLigneToolStripMenuItem.Text = "Modifier cette ligne"
        '
        'TextBox1
        '
        Me.TextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(917, 457)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(200, 22)
        Me.TextBox1.TabIndex = 3
        '
        'Button1
        '
        Me.Button1.Enabled = False
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(917, 485)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(200, 44)
        Me.Button1.TabIndex = 4
        Me.Button1.Text = "Ajouter"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'RichTextBox_listbox_cheatsh
        '
        Me.RichTextBox_listbox_cheatsh.Location = New System.Drawing.Point(639, 116)
        Me.RichTextBox_listbox_cheatsh.Name = "RichTextBox_listbox_cheatsh"
        Me.RichTextBox_listbox_cheatsh.Size = New System.Drawing.Size(115, 149)
        Me.RichTextBox_listbox_cheatsh.TabIndex = 5
        Me.RichTextBox_listbox_cheatsh.Text = ""
        '
        'RichTextBox1
        '
        Me.RichTextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RichTextBox1.Location = New System.Drawing.Point(366, 53)
        Me.RichTextBox1.Name = "RichTextBox1"
        Me.RichTextBox1.Size = New System.Drawing.Size(545, 426)
        Me.RichTextBox1.TabIndex = 6
        Me.RichTextBox1.Text = ""
        '
        'Button2
        '
        Me.Button2.Enabled = False
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(365, 485)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(146, 44)
        Me.Button2.TabIndex = 7
        Me.Button2.Text = "Généré les fichiers"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Enabled = False
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Location = New System.Drawing.Point(517, 485)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(146, 44)
        Me.Button3.TabIndex = 8
        Me.Button3.Text = "Lancez la compilation"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'ListBox2
        '
        Me.ListBox2.ContextMenuStrip = Me.ContextMenuStrip_listbox_maincpp
        Me.ListBox2.FormattingEnabled = True
        Me.ListBox2.Location = New System.Drawing.Point(12, 53)
        Me.ListBox2.Name = "ListBox2"
        Me.ListBox2.Size = New System.Drawing.Size(348, 108)
        Me.ListBox2.TabIndex = 9
        '
        'ContextMenuStrip_listbox_maincpp
        '
        Me.ContextMenuStrip_listbox_maincpp.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem1})
        Me.ContextMenuStrip_listbox_maincpp.Name = "ContextMenuStrip_listbox_cheatsh"
        Me.ContextMenuStrip_listbox_maincpp.Size = New System.Drawing.Size(188, 26)
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(187, 22)
        Me.ToolStripMenuItem1.Text = "Supprimer cette ligne"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(155, 34)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(66, 16)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "main.cpp:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(591, 34)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(77, 16)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "cheats.cpp:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(968, 34)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(77, 16)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "cheats.hpp:"
        '
        'RichTextBox2
        '
        Me.RichTextBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RichTextBox2.Location = New System.Drawing.Point(12, 271)
        Me.RichTextBox2.Name = "RichTextBox2"
        Me.RichTextBox2.Size = New System.Drawing.Size(348, 208)
        Me.RichTextBox2.TabIndex = 13
        Me.RichTextBox2.Text = ""
        '
        'Button4
        '
        Me.Button4.Enabled = False
        Me.Button4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.Location = New System.Drawing.Point(12, 221)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(348, 44)
        Me.Button4.TabIndex = 15
        Me.Button4.Text = "Ajouter"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'TextBox2
        '
        Me.TextBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox2.Location = New System.Drawing.Point(12, 193)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(348, 22)
        Me.TextBox2.TabIndex = 14
        '
        'RichTextBox3
        '
        Me.RichTextBox3.Location = New System.Drawing.Point(380, 140)
        Me.RichTextBox3.Name = "RichTextBox3"
        Me.RichTextBox3.Size = New System.Drawing.Size(45, 30)
        Me.RichTextBox3.TabIndex = 16
        Me.RichTextBox3.Text = ""
        '
        'TextBox3
        '
        Me.TextBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox3.Location = New System.Drawing.Point(12, 167)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.ReadOnly = True
        Me.TextBox3.Size = New System.Drawing.Size(348, 22)
        Me.TextBox3.TabIndex = 17
        '
        'Timer1
        '
        Me.Timer1.Interval = 400
        '
        'Button5
        '
        Me.Button5.Enabled = False
        Me.Button5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button5.Location = New System.Drawing.Point(669, 485)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(242, 44)
        Me.Button5.TabIndex = 18
        Me.Button5.Text = "Copier le .plg sur le bureau"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'TextBox_readforcopyplg
        '
        Me.TextBox_readforcopyplg.Location = New System.Drawing.Point(507, 302)
        Me.TextBox_readforcopyplg.Name = "TextBox_readforcopyplg"
        Me.TextBox_readforcopyplg.Size = New System.Drawing.Size(74, 20)
        Me.TextBox_readforcopyplg.TabIndex = 19
        '
        'TextBox4
        '
        Me.TextBox4.Location = New System.Drawing.Point(468, 230)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(88, 20)
        Me.TextBox4.TabIndex = 20
        '
        'TextBox5
        '
        Me.TextBox5.Location = New System.Drawing.Point(520, 277)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(88, 20)
        Me.TextBox5.TabIndex = 21
        '
        'TextBox6
        '
        Me.TextBox6.Location = New System.Drawing.Point(517, 337)
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.Size = New System.Drawing.Size(88, 20)
        Me.TextBox6.TabIndex = 22
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.BuildPlugin3DS.My.Resources.Resources.warning_
        Me.PictureBox1.Location = New System.Drawing.Point(569, 535)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(48, 41)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 23
        Me.PictureBox1.TabStop = False
        '
        'Timer2
        '
        Me.Timer2.Interval = 1600
        '
        'Timer3
        '
        Me.Timer3.Interval = 400
        '
        'Timer4
        '
        Me.Timer4.Interval = 400
        '
        'Timer5
        '
        Me.Timer5.Interval = 400
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1129, 582)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.RichTextBox2)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ListBox2)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.RichTextBox1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.ListBox1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.RichTextBox_listbox_cheatsh)
        Me.Controls.Add(Me.RichTextBox3)
        Me.Controls.Add(Me.TextBox_readforcopyplg)
        Me.Controls.Add(Me.TextBox4)
        Me.Controls.Add(Me.TextBox5)
        Me.Controls.Add(Me.TextBox6)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MainMenuStrip = Me.MenuStrip1
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Build Plugin 3DS  ||  By xBidoof  ||  Version: BETA"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ContextMenuStrip_listbox_cheatsh.ResumeLayout(False)
        Me.ContextMenuStrip_listbox_maincpp.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents ProjetToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ProjetToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents CrééUnProjetToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents ContextMenuStrip_listbox_cheatsh As ContextMenuStrip
    Friend WithEvents SupprimerCetteLigneToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ModifierCetteLigneToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RichTextBox_listbox_cheatsh As RichTextBox
    Friend WithEvents RichTextBox1 As RichTextBox
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents ListBox2 As ListBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents RichTextBox2 As RichTextBox
    Friend WithEvents Button4 As Button
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents RichTextBox3 As RichTextBox
    Friend WithEvents ContextMenuStrip_listbox_maincpp As ContextMenuStrip
    Friend WithEvents ToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents SauvegarderToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SaveFileDialog1 As SaveFileDialog
    Friend WithEvents Timer1 As Timer
    Friend WithEvents ParamètresToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AideToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Button5 As Button
    Friend WithEvents TextBox_readforcopyplg As TextBox
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents TextBox6 As TextBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Timer2 As Timer
    Friend WithEvents Timer3 As Timer
    Friend WithEvents Timer4 As Timer
    Friend WithEvents Timer5 As Timer
    Friend WithEvents Timer6 As Timer
End Class
