Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ' Création du menu 
        Dim menu As New MenuStrip
        ' On ajoute le Menu Strip à la fenêtre
        Me.Controls.Add(menu)

        ' Menu Fichier 
        Dim itemFichier As New ToolStripMenuItem
        itemFichier.Text = "Fichier"
        'On ajoute le menu Fichier au MenuStrip
        menu.Items.Add(itemFichier)

        ' Sous menu Ouvrir
        Dim itemOuvrir As New ToolStripMenuItem
        itemOuvrir.Text = "Ouvrir"

        AddHandler itemOuvrir.Click, AddressOf item_Click
        itemFichier.DropDownItems.Add(itemOuvrir)

        'Sous menu Quitter
        Dim itemQuitter As New ToolStripMenuItem
        itemQuitter.Text = "Quitter"

        AddHandler itemQuitter.Click, AddressOf item_Click
        itemFichier.DropDownItems.Add(itemQuitter)

    End Sub
    ' Gestion du clic
    Private Sub item_Click(ByVal sender As Object, ByVal e As EventArgs)
        Dim item As ToolStripItem = DirectCast(sender, ToolStripItem)
        ' MessageBox.Show(item.Text)
        ' Au clic sur Quitter
        If item.Text = "Quitter" Then
            Application.Exit()
        ElseIf item.Text = "Ouvrir" Then
            MessageBox.Show("Ouvrir un document")
        End If
    End Sub
End Class
