Imports System.Net
Imports System.IO
Imports System.Text
Imports YAZDL.WAD.IO




Public Class frmMain
    'Public RunString As String = (txtPath.Text & "\zxoom.exe")
    Public OldListItem As String = vbNullString
    Public PopulatedFlag As Boolean
    Public ZDExecute As String = vbNullString
    Public ZDExeFile As String = String.Empty
    Public FileArgs As List(Of String)


    Private Sub btnZDoomDir_Click(sender As Object, e As EventArgs) Handles btnZDoomDir.Click
        Dim ZDoomFolder As String

        If ofdZDoomExe.ShowDialog = Windows.Forms.DialogResult.OK AndAlso ofdZDoomExe.FileName <> "" Then
            ZDoomFolder = Path.GetDirectoryName(ofdZDoomExe.FileName)
            ZDExeFile = ofdZDoomExe.FileName
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
        Dim WADList As IO.FileInfo() = dir.GetFiles.Where(Function(fi) fi.Extension.ToLower = ".wad" Or fi.Extension.ToLower = ".pk3").ToArray
        Dim WADFile As IO.FileInfo
        Dim IsIWAD As Boolean

        lstIWads.Items.Clear()
        lstPatch.Items.Clear()

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
            ElseIf Path.GetExtension(WADFile.ToString).ToLower = ".pk3" Then
                If (WADFile.ToString = "zdoom.pk3" Or WADFile.ToString = "gzdoom.pk3") Then

                Else
                    lstPatch.Items.Add(WADFile)
                End If

            End If
        Next

    End Sub

    Private Sub txtIPAddress_TextChanged(sender As Object, e As EventArgs) Handles txtIPAddress.TextChanged

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
        If txtIPAddress.Text = "" Then
            lblIPValidity.Visible = False
        End If

    End Sub

    Private Sub radJoin_CheckedChanged(sender As Object, e As EventArgs) Handles radJoin.CheckedChanged
        chkDeathMatch.Enabled = False
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
        chkDeathMatch.Enabled = True
    End Sub
    Private Sub radSinglePlayer_CheckedChanged(sender As Object, e As EventArgs) Handles radSinglePlayer.CheckedChanged
        txtIPAddress.Enabled = False
        lblRemoteHost.Enabled = False
        lblPlayers.Enabled = False
        cboPlayers.Enabled = False
        chkDeathMatch.Enabled = False
    End Sub

    Private Sub btnRunZDoom_Click(sender As Object, e As EventArgs) Handles btnRunZDoom.Click
        Dim ZDoom As New ProcessStartInfo

        ZDoom.FileName = ZDExeFile
        ZDoom.Arguments = BuildCmd()
        Process.Start(ZDoom)
    End Sub

    Private Sub lstIWads_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstIWads.SelectedIndexChanged
        'Turn off the interrupt...like working with hardware.  
        RemoveHandler lstIWads.SelectedIndexChanged, AddressOf lstIWads_SelectedIndexChanged
        Dim ListItem As String = lstIWads.SelectedItem.ToString

        If ListItem <> OldListItem Then

            GetGameInfo(txtPath.Text & "\" & lstIWads.SelectedItem.ToString)
            OldListItem = lstIWads.SelectedItem.ToString
        Else
            lstIWads.SelectedIndex = -1
            cboMap.Items.Clear()
            OldListItem = vbNullString
        End If
        'Turn interrupt back on
        AddHandler lstIWads.SelectedIndexChanged, AddressOf lstIWads_SelectedIndexChanged
    End Sub

    Private Sub GetGameInfo(WADString As String)
        Dim WADFile As New WAD.IO.WAD(WADString)

        'Clear the map combobox here
        cboMap.Items.Clear()
        For Each item As String In WAD.IO.WAD.LumpNames
            cboMap.Items.Add(item)
        Next item

    End Sub
    Private Function BuildPatchList(PatchList As CheckedListBox) As String
        Dim sb As New StringBuilder

        For pIndex As Integer = 0 To PatchList.CheckedItems.Count - 1
            sb.Append(PatchList.CheckedItems(pIndex).ToString & " ")
        Next

        Return sb.ToString().TrimEnd()
    End Function

    Private Sub btnBuildCmd_Click(sender As Object, e As EventArgs) Handles btnBuildCmd.Click
        txtZDArgs.Text = BuildCmd()
    End Sub

    Private Function BuildCmd()
        Dim CmdArgs As New StringBuilder
        Dim IWADFile As String = String.Empty
        Dim CheatsEn As String = String.Empty
        Dim NoMonsters As String = String.Empty
        Dim FastMonsters As String = String.Empty
        Dim Deathmatch As String = String.Empty
        Dim Respawn As String = String.Empty
        Dim Map As String = String.Empty
        Dim NetSettings As String = String.Empty
        Dim Patch2Load As String = String.Empty
        Dim DblAmmo As String = String.Empty
        Dim InfAmmo As String = String.Empty

        If lstIWads.SelectedIndex = -1 Then
        Else
            IWADFile = (" -iwad " & lstIWads.SelectedItem.ToString)
        End If

        If radHost.Checked = True Then
            NetSettings = (" -host " & cboPlayers.SelectedItem.ToString)
        ElseIf radJoin.Checked = True Then
            'Check to see if IP Address was forgotten to be entered
            If txtIPAddress.Text = "" Then
                MessageBox.Show("IP Address not entered.  Enter IP Address and try again", "You've fucked up", MessageBoxButtons.OK, MessageBoxIcon.Error)
                '
                Return vbNullString
            End If
            NetSettings = (" -join " & txtIPAddress.Text)
        End If
        If chkDeathMatch.Checked = True Then
            Deathmatch = " -deathmatch"
        End If
        If chkCheatsEn.Checked = True Then
            CheatsEn = " +sv_cheats 1 "
        End If
        If chkNoMonsters.Checked = True Then
            NoMonsters = " -nomonsters"
        End If
        If chkFastMonsters.Checked = True Then
            FastMonsters = " -fast"
        End If
        If chkMonsterRespawn.Checked = True Then
            Respawn = " -respawn"
        End If
        If chkDblAmmo.Checked = True Then
            DblAmmo = " +set sv_doubleammo 1"
        End If
        If chkInfAmmo.Checked = True Then
            InfAmmo = " +set sv_infiniteammo 1"
        End If
        If (lstPatch.CheckedIndices.Count > 0) Then
            CmdArgs.Append(IWADFile & NetSettings & Deathmatch & NoMonsters & Respawn & _
                           FastMonsters & (" -file " & BuildPatchList(lstPatch)) & CheatsEn & DblAmmo & InfAmmo)
        Else
            CmdArgs.Append(IWADFile & NetSettings & Deathmatch & NoMonsters & Respawn & FastMonsters & CheatsEn & DblAmmo & InfAmmo)
        End If



        Return CmdArgs.ToString().TrimEnd()
    End Function


End Class
