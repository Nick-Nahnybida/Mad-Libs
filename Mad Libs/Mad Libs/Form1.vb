Public Class Form1

    Private Sub btnCreate_Click(sender As Object, e As EventArgs) Handles btnCreate.Click

        MessageBox.Show("The " + Me.Color.SelectedItem & " Dragon is the " + Me.WordEndingInEst.SelectedItem & " Dragon of all. It has " + Me.Size.SelectedItem & " " + Me.BodyPartPlural.SelectedItem & " and a " + Me.Animal.SelectedItem & " shaped like a " + Me.Noun.SelectedItem & ". It loves to eat " + Me.PluralNoun.SelectedItem & ", although it will feast on nearly anything.")

    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        ' Reset the list boxes
        Size.SelectedIndex = -1
        Color.SelectedIndex = -1
        WordEndingInEst.SelectedIndex = -1
        BodyPartPlural.SelectedIndex = -1
        Animal.SelectedIndex = -1
        Noun.SelectedIndex = -1
        PluralNoun.SelectedIndex = -1
    End Sub
End Class
