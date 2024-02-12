<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        ToolStrip1 = New ToolStrip()
        NouvelleToolStripButton = New ToolStripButton()
        OuvrirToolStripButton = New ToolStripButton()
        EnregistrerToolStripButton = New ToolStripButton()
        ImprimerToolStripButton = New ToolStripButton()
        toolStripSeparator = New ToolStripSeparator()
        CouperToolStripButton = New ToolStripButton()
        CopierToolStripButton = New ToolStripButton()
        CollerToolStripButton = New ToolStripButton()
        toolStripSeparator1 = New ToolStripSeparator()
        Bold = New ToolStripButton()
        Italic = New ToolStripButton()
        Underline = New ToolStripButton()
        Left = New ToolStripButton()
        Center = New ToolStripButton()
        Right = New ToolStripButton()
        ToolStripSeparator2 = New ToolStripSeparator()
        AideToolStripButton = New ToolStripButton()
        RichTextBox1 = New RichTextBox()
        ToolStrip1.SuspendLayout()
        SuspendLayout()
        ' 
        ' ToolStrip1
        ' 
        ToolStrip1.Items.AddRange(New ToolStripItem() {NouvelleToolStripButton, OuvrirToolStripButton, EnregistrerToolStripButton, ImprimerToolStripButton, toolStripSeparator, CouperToolStripButton, CopierToolStripButton, CollerToolStripButton, toolStripSeparator1, Bold, Italic, Underline, Left, Center, Right, ToolStripSeparator2, AideToolStripButton})
        ToolStrip1.Location = New Point(0, 0)
        ToolStrip1.Name = "ToolStrip1"
        ToolStrip1.Size = New Size(985, 25)
        ToolStrip1.TabIndex = 0
        ToolStrip1.Text = "ToolStrip1"
        ' 
        ' NouvelleToolStripButton
        ' 
        NouvelleToolStripButton.DisplayStyle = ToolStripItemDisplayStyle.Image
        NouvelleToolStripButton.Image = CType(resources.GetObject("NouvelleToolStripButton.Image"), Image)
        NouvelleToolStripButton.ImageTransparentColor = Color.Magenta
        NouvelleToolStripButton.Name = "NouvelleToolStripButton"
        NouvelleToolStripButton.Size = New Size(23, 22)
        NouvelleToolStripButton.Text = "&Nouvelle"
        ' 
        ' OuvrirToolStripButton
        ' 
        OuvrirToolStripButton.DisplayStyle = ToolStripItemDisplayStyle.Image
        OuvrirToolStripButton.Image = CType(resources.GetObject("OuvrirToolStripButton.Image"), Image)
        OuvrirToolStripButton.ImageTransparentColor = Color.Magenta
        OuvrirToolStripButton.Name = "OuvrirToolStripButton"
        OuvrirToolStripButton.Size = New Size(23, 22)
        OuvrirToolStripButton.Text = "&Ouvrir"
        ' 
        ' EnregistrerToolStripButton
        ' 
        EnregistrerToolStripButton.DisplayStyle = ToolStripItemDisplayStyle.Image
        EnregistrerToolStripButton.Image = CType(resources.GetObject("EnregistrerToolStripButton.Image"), Image)
        EnregistrerToolStripButton.ImageTransparentColor = Color.Magenta
        EnregistrerToolStripButton.Name = "EnregistrerToolStripButton"
        EnregistrerToolStripButton.Size = New Size(23, 22)
        EnregistrerToolStripButton.Text = "Enre&gistrer"
        ' 
        ' ImprimerToolStripButton
        ' 
        ImprimerToolStripButton.DisplayStyle = ToolStripItemDisplayStyle.Image
        ImprimerToolStripButton.Image = CType(resources.GetObject("ImprimerToolStripButton.Image"), Image)
        ImprimerToolStripButton.ImageTransparentColor = Color.Magenta
        ImprimerToolStripButton.Name = "ImprimerToolStripButton"
        ImprimerToolStripButton.Size = New Size(23, 22)
        ImprimerToolStripButton.Text = "&Imprimer"
        ' 
        ' toolStripSeparator
        ' 
        toolStripSeparator.Name = "toolStripSeparator"
        toolStripSeparator.Size = New Size(6, 25)
        ' 
        ' CouperToolStripButton
        ' 
        CouperToolStripButton.DisplayStyle = ToolStripItemDisplayStyle.Image
        CouperToolStripButton.Image = CType(resources.GetObject("CouperToolStripButton.Image"), Image)
        CouperToolStripButton.ImageTransparentColor = Color.Magenta
        CouperToolStripButton.Name = "CouperToolStripButton"
        CouperToolStripButton.Size = New Size(23, 22)
        CouperToolStripButton.Text = "Co&uper"
        ' 
        ' CopierToolStripButton
        ' 
        CopierToolStripButton.DisplayStyle = ToolStripItemDisplayStyle.Image
        CopierToolStripButton.Image = CType(resources.GetObject("CopierToolStripButton.Image"), Image)
        CopierToolStripButton.ImageTransparentColor = Color.Magenta
        CopierToolStripButton.Name = "CopierToolStripButton"
        CopierToolStripButton.Size = New Size(23, 22)
        CopierToolStripButton.Text = "&Copier"
        ' 
        ' CollerToolStripButton
        ' 
        CollerToolStripButton.DisplayStyle = ToolStripItemDisplayStyle.Image
        CollerToolStripButton.Image = CType(resources.GetObject("CollerToolStripButton.Image"), Image)
        CollerToolStripButton.ImageTransparentColor = Color.Magenta
        CollerToolStripButton.Name = "CollerToolStripButton"
        CollerToolStripButton.Size = New Size(23, 22)
        CollerToolStripButton.Text = "&Coller"
        ' 
        ' toolStripSeparator1
        ' 
        toolStripSeparator1.Name = "toolStripSeparator1"
        toolStripSeparator1.Size = New Size(6, 25)
        ' 
        ' Bold
        ' 
        Bold.DisplayStyle = ToolStripItemDisplayStyle.Image
        Bold.Image = CType(resources.GetObject("Bold.Image"), Image)
        Bold.ImageTransparentColor = Color.Magenta
        Bold.Name = "Bold"
        Bold.Size = New Size(23, 22)
        Bold.Text = "Gras"
        ' 
        ' Italic
        ' 
        Italic.DisplayStyle = ToolStripItemDisplayStyle.Image
        Italic.Image = CType(resources.GetObject("Italic.Image"), Image)
        Italic.ImageTransparentColor = Color.Magenta
        Italic.Name = "Italic"
        Italic.Size = New Size(23, 22)
        Italic.Text = "Italique"
        ' 
        ' Underline
        ' 
        Underline.DisplayStyle = ToolStripItemDisplayStyle.Image
        Underline.Image = CType(resources.GetObject("Underline.Image"), Image)
        Underline.ImageTransparentColor = Color.Magenta
        Underline.Name = "Underline"
        Underline.Size = New Size(23, 22)
        Underline.Text = "Souligné"
        ' 
        ' Left
        ' 
        Left.DisplayStyle = ToolStripItemDisplayStyle.Image
        Left.Image = CType(resources.GetObject("Left.Image"), Image)
        Left.ImageTransparentColor = Color.Magenta
        Left.Name = "Left"
        Left.Size = New Size(23, 22)
        Left.Text = "Texte à gauche"
        ' 
        ' Center
        ' 
        Center.DisplayStyle = ToolStripItemDisplayStyle.Image
        Center.Image = CType(resources.GetObject("Center.Image"), Image)
        Center.ImageTransparentColor = Color.Magenta
        Center.Name = "Center"
        Center.Size = New Size(23, 22)
        Center.Text = "Texte centré"
        ' 
        ' Right
        ' 
        Right.DisplayStyle = ToolStripItemDisplayStyle.Image
        Right.Image = CType(resources.GetObject("Right.Image"), Image)
        Right.ImageTransparentColor = Color.Magenta
        Right.Name = "Right"
        Right.Size = New Size(23, 22)
        Right.Text = "Texte à droite"
        ' 
        ' ToolStripSeparator2
        ' 
        ToolStripSeparator2.Name = "ToolStripSeparator2"
        ToolStripSeparator2.Size = New Size(6, 25)
        ' 
        ' AideToolStripButton
        ' 
        AideToolStripButton.DisplayStyle = ToolStripItemDisplayStyle.Image
        AideToolStripButton.Image = CType(resources.GetObject("AideToolStripButton.Image"), Image)
        AideToolStripButton.ImageTransparentColor = Color.Magenta
        AideToolStripButton.Name = "AideToolStripButton"
        AideToolStripButton.Size = New Size(23, 22)
        AideToolStripButton.Text = "Ai&de"
        ' 
        ' RichTextBox1
        ' 
        RichTextBox1.Dock = DockStyle.Fill
        RichTextBox1.Location = New Point(0, 25)
        RichTextBox1.Name = "RichTextBox1"
        RichTextBox1.Size = New Size(985, 610)
        RichTextBox1.TabIndex = 1
        RichTextBox1.Text = ""
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(985, 635)
        Controls.Add(RichTextBox1)
        Controls.Add(ToolStrip1)
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Name = "Form1"
        Text = "Word Clone VB"
        ToolStrip1.ResumeLayout(False)
        ToolStrip1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents NouvelleToolStripButton As ToolStripButton
    Friend WithEvents OuvrirToolStripButton As ToolStripButton
    Friend WithEvents EnregistrerToolStripButton As ToolStripButton
    Friend WithEvents ImprimerToolStripButton As ToolStripButton
    Friend WithEvents toolStripSeparator As ToolStripSeparator
    Friend WithEvents CouperToolStripButton As ToolStripButton
    Friend WithEvents CopierToolStripButton As ToolStripButton
    Friend WithEvents CollerToolStripButton As ToolStripButton
    Friend WithEvents toolStripSeparator1 As ToolStripSeparator
    Friend WithEvents AideToolStripButton As ToolStripButton
    Friend WithEvents Bold As ToolStripButton
    Friend WithEvents Italic As ToolStripButton
    Friend WithEvents Underline As ToolStripButton
    Friend WithEvents Left As ToolStripButton
    Friend WithEvents Center As ToolStripButton
    Friend WithEvents Right As ToolStripButton
    Friend WithEvents ToolStripSeparator2 As ToolStripSeparator
    Friend WithEvents RichTextBox1 As RichTextBox

End Class
