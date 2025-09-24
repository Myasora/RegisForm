Public Class Form1
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles lblLastNametext.Click

    End Sub

    Private Sub TableLayoutPanel3_Paint(sender As Object, e As PaintEventArgs) Handles TableLayoutPanel3.Paint

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub TableLayoutPanel6_Paint(sender As Object, e As PaintEventArgs) Handles TableLayoutPanel6.Paint

    End Sub

    Private Sub btnChooseFile_Click(sender As Object, e As EventArgs) Handles btnChooseFile.Click
        ' Create OpenFileDialog
        Dim ofd As New OpenFileDialog()

        ' Allow only image file types
        ofd.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp;*.gif"
        ofd.Title = "Select an Image"

        ' If user selected a file
        If ofd.ShowDialog() = DialogResult.OK Then
            ' Load selected image into PictureBox
            PictureBox1.Image = Image.FromFile(ofd.FileName)

            ' Adjust image display
            PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
        End If
    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label3_Click_1(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub TextBox9_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub lblMotherText_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub lblEmailText_Click(sender As Object, e As EventArgs) Handles lblEmailText.Click

    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked Then
            ' Copy Address 1 to Address 2
            Address2TextBox.Text = AddressTextBox.Text
            ' Lock Address 2 so it can’t be edited
            Address2TextBox.ReadOnly = True
        Else
            ' Allow manual input again
            Address2TextBox.Clear()
            Address2TextBox.ReadOnly = False
        End If
    End Sub

    Private Sub AddressTextBox_TextChanged(sender As Object, e As EventArgs) Handles AddressTextBox.TextChanged
        ' Keep Address 2 updated if checkbox is checked
        If CheckBox1.Checked Then
            Address2TextBox.Text = AddressTextBox.Text
        End If
    End Sub

End Class
