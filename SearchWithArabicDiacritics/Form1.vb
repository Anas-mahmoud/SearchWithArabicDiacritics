Imports System.Text.RegularExpressions

Public Class Form1

    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        Reset()

        Dim word As String = txtSearch.Text.Trim
        Dim textToSearch As String = rtbSource.Text
        Dim matches As IEnumerable(Of Match)

        If String.IsNullOrWhiteSpace(word) Then Return

        matches = SearchArabic(textToSearch, word)

        If matches.Count = 0 Then Return

        PopulateResults(matches)
        FillListBox(matches, lstResults)

        If chkAutoColor.Checked Then ColorResults(rtbSource, matches, prgColor.ProgressBar)
    End Sub
    Function SearchArabic(Text As String, Word As String) As IEnumerable(Of Match)
        Dim expression As String = "[\u0600-\u06FF]*(?<input>"
        For Each l In Word
            expression &= l & "[\u064B-\u0652]*"
        Next

        expression &= ")[\u0600-\u06FF]*"
        Return Regex.Matches(Text, expression).Cast(Of Match)
    End Function
    Sub FillListBox(matches As IEnumerable(Of Match), ListBox As ListBox)
        ListBox.DataSource = matches.ToList
    End Sub
    Sub PopulateResults(matches As IEnumerable(Of Match))
        lblResults.Text = String.Format("{0} نتيجة بحث", matches.Count)
        prgColor.Maximum = matches.Count
    End Sub
    Sub ColorResults(richTextBox As RichTextBox, matches As IEnumerable(Of Match), Optional ProgressBar As ProgressBar = Nothing)
        For Each m As Match In matches
            Dim input As Group = m.Groups("input")
            richTextBox.Select(input.Index, input.Length)
            richTextBox.SelectionBackColor = Color.Yellow
            If ProgressBar IsNot Nothing Then ProgressBar.PerformStep()
        Next
    End Sub
    Sub Reset()
        lblResults.Text = "- نتيجة بحث"
        prgColor.Value = 0
        lstResults.DataSource = Nothing
        rtbSource.SelectAll()
        rtbSource.SelectionBackColor = Color.White
    End Sub
    Private Sub btnColor_Click(sender As Object, e As EventArgs) Handles btnColor.Click
        Dim matches As IEnumerable(Of Match) = lstResults.DataSource
        If matches Is Nothing OrElse matches.Count = 0 Then Return
        ColorResults(rtbSource, matches, prgColor.ProgressBar)
    End Sub
    Dim textboxFocusd As Boolean
    Private Sub txtSearch_GotFocus(sender As Object, e As EventArgs) Handles txtSearch.GotFocus
        textboxFocusd = True
    End Sub
    Private Sub txtSearch_LostFocus(sender As Object, e As EventArgs) Handles txtSearch.LostFocus
        textboxFocusd = False
    End Sub
    Private Sub lstResults_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstResults.SelectedIndexChanged
        If textboxFocusd Then Return
        Dim lst As ListBox = sender
        Dim m As Match = lst.SelectedItem
        If m Is Nothing Then Return
        rtbSource.SelectionStart = m.Index
        rtbSource.SelectionLength = m.Length
        rtbSource.Focus()
    End Sub


End Class

