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
                ListBoxNumbers.Items.Cast(Of Object)().Select(Function(x) x.ToString()).ToList().ForEach(Sub(num) writer.Write(num & " "))
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
            Dim line As String
            Using reader As New StreamReader(filePath)
                line = reader.ReadLine()
            End Using

            If Not String.IsNullOrEmpty(line) Then
                Dim parts() As String = line.Split(" "c)
                Dim numberList = parts.Where(Function(p) p.Trim() <> "").Select(Function(p) Integer.Parse(p)).OrderBy(Function(x) x).ToList()
                numberList.ToList().ForEach(Sub(num) ListBoxNumbers.Items.Add(num))

                Using writer As New StreamWriter(filePath, False)
                    numberList = numberList.ToList() : numberList.ForEach(Sub(num) writer.Write(num & " "))
                End Using
            End If

            MessageBox.Show("Numbers loaded successfully!")
        Else
            MessageBox.Show("File not found! Please save numbers first.")
        End If
    End Sub

    Private Sub ButtonClear_Click(sender As Object, e As EventArgs) Handles ButtonClear.Click
        ListBoxNumbers.Items.Clear()
    End Sub
End Class
