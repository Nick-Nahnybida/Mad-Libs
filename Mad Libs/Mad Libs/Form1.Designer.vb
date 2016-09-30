<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Color = New System.Windows.Forms.ListBox()
        Me.WordEndingInEst = New System.Windows.Forms.ListBox()
        Me.BodyPartPlural = New System.Windows.Forms.ListBox()
        Me.Animal = New System.Windows.Forms.ListBox()
        Me.Noun = New System.Windows.Forms.ListBox()
        Me.PluralNoun = New System.Windows.Forms.ListBox()
        Me.Size = New System.Windows.Forms.ListBox()
        Me.btnCreate = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Color
        '
        Me.Color.FormattingEnabled = True
        Me.Color.Items.AddRange(New Object() {"red", "orange", "yellow", "green", "blue", "indigo", "violet"})
        Me.Color.Location = New System.Drawing.Point(138, 12)
        Me.Color.Name = "Color"
        Me.Color.Size = New System.Drawing.Size(120, 95)
        Me.Color.TabIndex = 0
        '
        'WordEndingInEst
        '
        Me.WordEndingInEst.FormattingEnabled = True
        Me.WordEndingInEst.Items.AddRange(New Object() {"coolest", "fastest", "slowest", "luckiest", "happiest", "loudest", "quietest"})
        Me.WordEndingInEst.Location = New System.Drawing.Point(264, 12)
        Me.WordEndingInEst.Name = "WordEndingInEst"
        Me.WordEndingInEst.Size = New System.Drawing.Size(120, 95)
        Me.WordEndingInEst.TabIndex = 1
        '
        'BodyPartPlural
        '
        Me.BodyPartPlural.FormattingEnabled = True
        Me.BodyPartPlural.Items.AddRange(New Object() {"legs", "teeth", "eyes", "arms", "hands", "feet", "ears"})
        Me.BodyPartPlural.Location = New System.Drawing.Point(390, 11)
        Me.BodyPartPlural.Name = "BodyPartPlural"
        Me.BodyPartPlural.Size = New System.Drawing.Size(120, 95)
        Me.BodyPartPlural.TabIndex = 2
        '
        'Animal
        '
        Me.Animal.FormattingEnabled = True
        Me.Animal.Items.AddRange(New Object() {"dog", "cat", "fish", "bear", "lion", "jaguar", "cow"})
        Me.Animal.Location = New System.Drawing.Point(12, 113)
        Me.Animal.Name = "Animal"
        Me.Animal.Size = New System.Drawing.Size(120, 95)
        Me.Animal.TabIndex = 3
        '
        'Noun
        '
        Me.Noun.FormattingEnabled = True
        Me.Noun.Items.AddRange(New Object() {"tree", "boat", "house", "raft", "bush", "plant", "dock"})
        Me.Noun.Location = New System.Drawing.Point(138, 113)
        Me.Noun.Name = "Noun"
        Me.Noun.Size = New System.Drawing.Size(120, 95)
        Me.Noun.TabIndex = 4
        '
        'PluralNoun
        '
        Me.PluralNoun.FormattingEnabled = True
        Me.PluralNoun.Items.AddRange(New Object() {"deserts", "people", "fish", "animals", "forests", "chairs", "desks"})
        Me.PluralNoun.Location = New System.Drawing.Point(264, 113)
        Me.PluralNoun.Name = "PluralNoun"
        Me.PluralNoun.Size = New System.Drawing.Size(120, 95)
        Me.PluralNoun.TabIndex = 5
        '
        'Size
        '
        Me.Size.FormattingEnabled = True
        Me.Size.Items.AddRange(New Object() {"big", "large", "huge", "small", "extra Large", "extra Small", "tiny"})
        Me.Size.Location = New System.Drawing.Point(12, 12)
        Me.Size.Name = "Size"
        Me.Size.Size = New System.Drawing.Size(120, 95)
        Me.Size.TabIndex = 6
        '
        'btnCreate
        '
        Me.btnCreate.Location = New System.Drawing.Point(413, 122)
        Me.btnCreate.Name = "btnCreate"
        Me.btnCreate.Size = New System.Drawing.Size(75, 23)
        Me.btnCreate.TabIndex = 7
        Me.btnCreate.Text = "Create Story"
        Me.btnCreate.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(413, 167)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(75, 23)
        Me.btnClear.TabIndex = 8
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(853, 215)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnCreate)
        Me.Controls.Add(Me.Size)
        Me.Controls.Add(Me.PluralNoun)
        Me.Controls.Add(Me.Noun)
        Me.Controls.Add(Me.Animal)
        Me.Controls.Add(Me.BodyPartPlural)
        Me.Controls.Add(Me.WordEndingInEst)
        Me.Controls.Add(Me.Color)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Color As System.Windows.Forms.ListBox
    Friend WithEvents WordEndingInEst As System.Windows.Forms.ListBox
    Friend WithEvents BodyPartPlural As System.Windows.Forms.ListBox
    Friend WithEvents Animal As System.Windows.Forms.ListBox
    Friend WithEvents Noun As System.Windows.Forms.ListBox
    Friend WithEvents PluralNoun As System.Windows.Forms.ListBox
    Friend WithEvents Size As System.Windows.Forms.ListBox
    Friend WithEvents btnCreate As System.Windows.Forms.Button
    Friend WithEvents btnClear As System.Windows.Forms.Button

End Class
