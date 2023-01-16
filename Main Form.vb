Public Class frmMain
    Private strCountriesAndStates(6) As String
    Private intLastSub As Integer = strCountriesAndStates.GetUpperBound(0)

    Private Sub ListBox()
        For intSub As Integer = 0 To intLastSub
            lstStates.Items.Add(strCountriesAndStates(intSub))
        Next intSub
        lstStates.SelectedIndex = 0
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub SortAcToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SortAcToolStripMenuItem.Click
        Array.Sort(strCountriesAndStates)
        ListBox()

    End Sub
    Private Sub SortDecendingToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SortDecendingToolStripMenuItem.Click
        Array.Sort(strCountriesAndStates)
        Array.Reverse(strCountriesAndStates)
        ListBox()

    End Sub

    Private Sub btnReadFile_Click(sender As Object, e As EventArgs) Handles btnReadFile.Click

        Dim inFile As IO.StreamReader

        lstStates.Items.Clear()

        If IO.File.Exists("states.txt") Then
            inFile = IO.File.OpenText("states.txt")

            Do Until inFile.Peek = -1
                lstStates.Items.Add(inFile.ReadLine)
            Loop
            inFile.Close()

        End If

    End Sub

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim inFile As IO.StreamReader

        If IO.File.Exists("states.txt") Then
            inFile = IO.File.OpenText("states.txt")
            For intSub As Integer = 0 To intLastSub
                strCountriesAndStates(intSub) = inFile.ReadLine

            Next intSub
            inFile.Close()
            ListBox()

        End If
    End Sub

    Private Sub btnAddStates_Click(sender As Object, e As EventArgs) Handles btnAddState.Click
        Dim outFile As IO.StreamWriter

        outFile = IO.File.AppendText("states.txt")

        outFile.WriteLine(lblUserAdd.Text.Trim)

        outFile.Close()
    End Sub


End Class
