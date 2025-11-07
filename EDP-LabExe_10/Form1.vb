Imports System.IO

Public Class Form1
    Private Sub ButtonInput_Click(sender As Object, e As EventArgs) Handles ButtonInput.Click

        If Not TextBoxNumberInput.Text.Trim() = "" Then
            Dim num As Integer
            If Integer.TryParse(TextBoxNumberInput.Text.Trim(), num) Then
                ListBoxNumbers.Items.Add(num)
                TextBoxNumberInput.Clear()
            Else
                MessageBox.Show("Please enter a valid number.")
            End If
        Else
            MessageBox.Show("Please enter a number first.")
        End If
    End Sub
    '======================================================================================================
    Private Sub ButtonSave_Click(sender As Object, e As EventArgs) Handles ButtonSave.Click
        Dim filePath As String = "numbers.txt"

        If ListBoxNumbers.Items.Count > 0 Then
            Using writer As New StreamWriter(filePath)
                ListBoxNumbers.Items.Cast(Of Integer)().ToList().ForEach(Sub(num) writer.Write(num & " "))
            End Using
            ListBoxNumbers.Items.Clear()
            MessageBox.Show("Numbers saved to " & filePath)
        Else
            MessageBox.Show("No numbers to save.")
        End If
    End Sub
    '======================================================================================================
    Private Sub ButtonRead_Click(sender As Object, e As EventArgs) Handles ButtonRead.Click
        Dim filePath As String = "numbers.txt"

        If File.Exists(filePath) Then
            ListBoxNumbers.Items.Clear()
            Using reader As New StreamReader(filePath)
                Dim line As String = reader.ReadLine()
                If Not String.IsNullOrEmpty(line) Then
                    Dim parts() As String = line.Split(" "c)
                    Dim numberList = parts.Where(Function(p) p.Trim() <> "").Select(Function(p) Integer.Parse(p)).OrderBy(Function(x) x)
                    numberList.ToList().ForEach(Sub(num) ListBoxNumbers.Items.Add(num))
                End If
            End Using

            MessageBox.Show("Numbers loaded successfully!")
        Else
            MessageBox.Show("File not found! Please save numbers first.")
        End If
    End Sub
End Class
