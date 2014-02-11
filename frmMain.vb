Imports System.Net
Imports System.IO
Imports ZDoom_Launcher.WAD.IO




Public Class frmMain
    'Public RunString As String = (txtPath.Text & "\zxoom.exe")
    Public OldListItem As String = vbNullString

    Private Sub btnZDoomDir_Click(sender As Object, e As EventArgs) Handles btnZDoomDir.Click
        Dim ZDoomFolder As String

        If ofdZDoomExe.ShowDialog = Windows.Forms.DialogResult.OK AndAlso ofdZDoomExe.FileName <> "" Then
            ZDoomFolder = Path.GetDirectoryName(ofdZDoomExe.FileName)
            txtZDoomCommand.Text = ofdZDoomExe.FileName
            GetWadFiles(ZDoomFolder)
            txtPath.Text = ZDoomFolder
        End If


    End Sub

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If My.Settings.ZDoomDirectory <> "" Then
            txtPath.Text = My.Settings.ZDoomDirectory
            GetWadFiles(txtPath.Text)
        End If
    End Sub

    Private Sub GetWadFiles(ByVal Folder As String)
        ' make a reference to a directory
        Dim dir As New IO.DirectoryInfo(Folder)
        'Dim WADList As IO.FileInfo() = dir.GetFiles("*.wad")
        Dim WADList As IO.FileInfo() = dir.GetFiles.Where(Function(fi) fi.Extension.ToLower = ".wad" OrElse fi.Extension.ToLower = ".pk3").ToArray
        Dim WADFile As IO.FileInfo
        Dim IsIWAD As Boolean

        'list the names of all files in the specified directory
        For Each WADFile In WADList
            If Path.GetExtension(WADFile.ToString).ToLower = ".wad" Then

                Dim TestWADFile As New WAD.IO.WAD(Folder & "\" & WADFile.ToString)
                IsIWAD = (TestWADFile.TestWADType = WAD.IO.WAD.IWAD)
                If (IsIWAD = True) Then
                    lstIWads.Items.Add(WADFile)
                Else
                    lstPatch.Items.Add(WADFile)
                End If
            ElseIf Path.GetExtension(WADFile.ToString).ToLower <> ".wad" Then
                lstPatch.Items.Add(WADFile)
            End If
        Next

        lstIWads.Focus()

    End Sub

    Private Sub txtIPAddress_LostFocus(sender As Object, e As EventArgs) Handles txtIPAddress.LostFocus

        If IPAddress.TryParse(txtIPAddress.Text, Nothing) = True Then
            lblIPValidity.ForeColor = Color.Green
            lblIPValidity.Text = "IP Valid"
            lblIPValidity.Visible = True
        Else
            lblIPValidity.ForeColor = Color.Red
            lblIPValidity.Text = "IP Invalid"
            lblIPValidity.Visible = True
        End If

    End Sub

    Private Sub txtIPAddress_GotFocus(sender As Object, e As EventArgs) Handles txtIPAddress.GotFocus
        lblIPValidity.Visible = False
    End Sub

    Private Sub radJoin_CheckedChanged(sender As Object, e As EventArgs) Handles radJoin.CheckedChanged
        lblPlayers.Enabled = False
        cboPlayers.Enabled = False
        txtIPAddress.Enabled = True
        lblRemoteHost.Enabled = True
    End Sub

    Private Sub radHost_CheckedChanged(sender As Object, e As EventArgs) Handles radHost.CheckedChanged
        txtIPAddress.Enabled = False
        lblRemoteHost.Enabled = False
        lblPlayers.Enabled = True
        cboPlayers.Enabled = True
    End Sub

    Private Sub btnRunZDoom_Click(sender As Object, e As EventArgs) Handles btnRunZDoom.Click


        Process.Start(txtZDoomCommand.Text)
    End Sub

    Private Sub ChangePatchActivation(src As ListBox, dst As ListBox)
        Dim sItems As ListBox.SelectedObjectCollection = src.SelectedItems

        For Each item As FileInfo In sItems
            dst.Items.Add(item)
        Next

        While src.SelectedItems.Count > 0
            src.Items.Remove(src.SelectedItems(0))
        End While

    End Sub

    

    Private Sub lstIWads_SelectedValueChanged(sender As Object, e As EventArgs) Handles lstIWads.SelectedValueChanged
        Dim WADFile As New WAD.IO.WAD(txtPath.Text & "\" & lstIWads.SelectedItem.ToString)
        Dim count As Integer
        Dim ListItem As String = lstIWads.SelectedItem.ToString

        count = WAD.IO.WAD.LumpNames.Count
        If ListItem <> OldListItem Then
            'Clear the map combobox here
            ComboBox1.Items.Clear()
            For Each item As String In WAD.IO.WAD.LumpNames
                ComboBox1.Items.Add(item)
            Next item
            'Select the first map available for the user.
            ComboBox1.SelectedIndex = 0
            OldListItem = lstIWads.SelectedItem.ToString
        End If
    End Sub

    Private Sub lstPatch_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstPatch.SelectedIndexChanged

    End Sub
End Class
