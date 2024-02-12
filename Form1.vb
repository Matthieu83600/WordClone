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
    ' Gestion du clic menu
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

    ' Gestion du clic options
    Private Sub ToolStrip1_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles ToolStrip1.ItemClicked
        ' MessageBox.Show(e.ClickedItem.Text)
        If e.ClickedItem.Text = "Gras" Then
            RichTextBox1.SelectionFont = New Font(RichTextBox1.Font, FontStyle.Bold)
        ElseIf e.ClickedItem.Text = "Italique" Then
            RichTextBox1.SelectionFont = New Font(RichTextBox1.Font, FontStyle.Italic)
        ElseIf e.ClickedItem.Text = "Souligné" Then
            RichTextBox1.SelectionFont = New Font(RichTextBox1.Font, FontStyle.Underline)
        ElseIf e.ClickedItem.Text = "Texte à gauche" Then
            RichTextBox1.SelectionAlignment = HorizontalAlignment.Left
        ElseIf e.ClickedItem.Text = "Texte centré" Then
            RichTextBox1.SelectionAlignment = HorizontalAlignment.Center
        ElseIf e.ClickedItem.Text = "Texte à droite" Then
            RichTextBox1.SelectionAlignment = HorizontalAlignment.Right
        ElseIf e.ClickedItem.Text = "Big" Then
            RichTextBox1.SelectionFont = New Font(RichTextBox1.Font.FontFamily, RichTextBox1.SelectionFont.Size + 2)
        ElseIf e.ClickedItem.Text = "Small" Then
            RichTextBox1.SelectionFont = New Font(RichTextBox1.Font.FontFamily, RichTextBox1.SelectionFont.Size - 2)
        End If
    End Sub
End Class
