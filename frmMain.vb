﻿Imports System.Net
Imports System.IO
Imports System.Text
Imports YAZDL.WAD.IO

Public Class frmMain
    Public OldListItem As String = vbNullString
    Public ZDExeFile As String = String.Empty
    Public FileArgs As List(Of String)

    Private DeathMatchControls As New List(Of Control)

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

        If My.Settings.ZDoomExecutable <> "" Then
            ZDExeFile = My.Settings.ZDoomExecutable
            txtPath.Text = Path.GetDirectoryName(ZDExeFile)
            GetWadFiles(txtPath.Text)
            SkillLvlPopulate()
        End If

        GetNetworkStuff()

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
        For Each item As String In WAD.IO.WAD.MapNames
            cboMap.Items.Add(item)
        Next item

        'TextBox1.Clear()
        'For Each lump In WAD.IO.WAD.LumpNames
        '    TextBox1.AppendText(lump & Environment.NewLine)
        'Next
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
        Dim Map As String = String.Empty
        Dim Patch2Load As String = String.Empty
        Dim SkillLevel As String = String.Empty

        If lstIWads.SelectedIndex = -1 Then
        Else
            IWADFile = (" -iwad " & lstIWads.SelectedItem.ToString)
        End If

        If cboMap.Text <> "" Then
            Map = (" +map " & cboMap.Text)
        End If
        If cboMap.Text <> "" Then
            SkillLevel = (" -skill " & cboSkillLevel.SelectedIndex + 1)
        End If
        If (lstPatch.CheckedIndices.Count > 0) Then
            CmdArgs.Append(IWADFile & BuildMPString() & Map & SkillLevel & (" -file " & BuildPatchList(lstPatch)) & _
                            BuildGamePlayString())
        Else
            CmdArgs.Append(IWADFile & BuildMPString() & Map & SkillLevel & _
                            BuildGamePlayString())
            'CmdArgs.Append(IWADFile & BuildMPString() & Map & SkillLevel & BuildGamePlayString())
        End If

        Return CmdArgs.ToString().TrimEnd()
    End Function

    Private Function BuildMPString()
        Dim MPArgs As New StringBuilder
        Dim Deathmatch As String = String.Empty
        Dim NetSettings As String = String.Empty

        If radHost.Checked = True Then
            If cboPlayers.SelectedIndex = -1 Then
                'Don't do anything
            Else
                NetSettings = (" -host " & cboPlayers.SelectedItem.ToString)
            End If

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

        MPArgs.Append(NetSettings & Deathmatch)

        Return MPArgs.ToString().TrimEnd()
    End Function

    Private Function BuildGamePlayString()
        Dim GPString As New StringBuilder
        Dim DblAmmo As String = String.Empty
        Dim InfAmmo As String = String.Empty
        Dim CheatsEn As String = String.Empty
        Dim NoMonsters As String = String.Empty
        Dim FastMonsters As String = String.Empty
        Dim Respawn As String = String.Empty
        Dim RomeroDeath As String = String.Empty

        If chkNoMonsters.Checked = True Then
            NoMonsters = " -nomonsters"
        End If
        If chkFastMonsters.Checked = True Then
            FastMonsters = " -fast"
        End If
        If chkMonsterRespawn.Checked = True Then
            Respawn = " -respawn"
        End If
        If chkCheatsEn.Checked = True Then
            CheatsEn = " +sv_cheats 1 "
        End If
        If chkDblAmmo.Checked = True Then
            DblAmmo = " +set sv_doubleammo 1"
        End If
        If chkInfAmmo.Checked = True Then
            InfAmmo = " +set sv_infiniteammo 1"
        End If
        If chkKillSpawn.Checked = True Then
            RomeroDeath = " +set sv_killbossmonst 1"
        End If

        GPString.Append(NoMonsters & FastMonsters & Respawn & CheatsEn & DblAmmo & InfAmmo & RomeroDeath)

        Return GPString.ToString().TrimEnd()
    End Function

    Private Function BuildDMString()
        Dim DeathMatchString As New StringBuilder
        Dim WeaponsStay As String = String.Empty
        Dim DisablePU As String = String.Empty
        Dim DisableHealthSpwn As String = String.Empty
        Dim DisableArmorSpwn As String = String.Empty
        Dim SpawnFarthest As String = String.Empty
        Dim SameMap As String = String.Empty
        Dim DisableExit As String = String.Empty
        Dim RSpwnProtect As String = String.Empty
        Dim LoseFrag As String = String.Empty
        Dim KeepFrags As String = String.Empty
        Dim NoTeamSwitch As String = String.Empty

        If chkWeaponsStay.Checked = True Then

        End If
        If chkAllowPwrUps.Checked = True Then

        End If
        If chkHealthSpawn.Checked = True Then

        End If
        If chkArmorSpawn.Checked = True Then

        End If
        If chkSpawnFarthest.Checked = True Then

        End If
        If chkSameMap.Checked = True Then

        End If
        If chkAllowExit.Checked = True Then

        End If
        If chkRespawnProtection.Checked = True Then

        End If
        If chkLoseFrag.Checked = True Then

        End If
        If chkKeepFragsGained.Checked = True Then

        End If
        If chkWeaponsStay.Checked = True Then

        End If

        'DeathMatchString.Append()

        Return DeathMatchString.ToString().TrimEnd()

    End Function

    Private Function BuildCoOpString()

    End Function

    Private Sub SkillLvlPopulate()
        cboSkillLevel.Items.Clear()
        If chkBrutalDoom.Checked = True Then
            cboSkillLevel.Items.Add("Power Fantasy")
            cboSkillLevel.Items.Add("Wussy")
            cboSkillLevel.Items.Add("Harsh")
            cboSkillLevel.Items.Add("Full Ultra Violence")
            cboSkillLevel.Items.Add("I Am Super Bad")
            cboSkillLevel.Items.Add("12 in a 10 Point Scale of Bad")
            cboSkillLevel.Items.Add("Black Metal")
        Else
            cboSkillLevel.Items.Add("I'm too Young to Die")
            cboSkillLevel.Items.Add("Hey, Not too Rough")
            cboSkillLevel.Items.Add("Hurt Me Plenty")
            cboSkillLevel.Items.Add("Ultra-Violence")
            cboSkillLevel.Items.Add("NIGHTMARE!")
        End If
    End Sub

    Private Sub frmMain_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        If ZDExeFile <> My.Settings.ZDoomExecutable Then
            If (MessageBox.Show("Remember ZDoom Folders?", "Save Settings?", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes) Then
                My.Settings.ZDoomExecutable = ZDExeFile
            Else
                End
            End If
        End If
    End Sub

    Private Sub chkBrutalDoom_CheckedChanged(sender As Object, e As EventArgs) Handles chkBrutalDoom.CheckedChanged
        SkillLvlPopulate()
    End Sub

    Private Sub tmrBuildCmd_Tick(sender As Object, e As EventArgs) Handles tmrBuildCmd.Tick
        txtZDArgs.Text = BuildCmd().ToString
    End Sub
End Class
