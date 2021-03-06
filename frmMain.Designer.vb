﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
        Me.lstIWads = New System.Windows.Forms.ListBox()
        Me.btnZDoomDir = New System.Windows.Forms.Button()
        Me.txtPath = New System.Windows.Forms.TextBox()
        Me.lblPlayers = New System.Windows.Forms.Label()
        Me.cboPlayers = New System.Windows.Forms.ComboBox()
        Me.lblRemoteHost = New System.Windows.Forms.Label()
        Me.lblIPValidity = New System.Windows.Forms.Label()
        Me.txtIPAddress = New System.Windows.Forms.TextBox()
        Me.radHost = New System.Windows.Forms.RadioButton()
        Me.radJoin = New System.Windows.Forms.RadioButton()
        Me.btnRunZDoom = New System.Windows.Forms.Button()
        Me.txtZDArgs = New System.Windows.Forms.TextBox()
        Me.ofdZDoomExe = New System.Windows.Forms.OpenFileDialog()
        Me.tbcGameSettings = New System.Windows.Forms.TabControl()
        Me.tbpMultiplayer = New System.Windows.Forms.TabPage()
        Me.lstIpAddresses = New System.Windows.Forms.ListBox()
        Me.chkDeathMatch = New System.Windows.Forms.CheckBox()
        Me.radSinglePlayer = New System.Windows.Forms.RadioButton()
        Me.tbpGameType = New System.Windows.Forms.TabPage()
        Me.lblSkill = New System.Windows.Forms.Label()
        Me.lblMap = New System.Windows.Forms.Label()
        Me.chkBrutalDoom = New System.Windows.Forms.CheckBox()
        Me.cboMap = New System.Windows.Forms.ComboBox()
        Me.cboSkillLevel = New System.Windows.Forms.ComboBox()
        Me.tbpPatchMod = New System.Windows.Forms.TabPage()
        Me.lstPatch = New System.Windows.Forms.CheckedListBox()
        Me.tbpGamePlay = New System.Windows.Forms.TabPage()
        Me.chkForceRespawn = New System.Windows.Forms.CheckBox()
        Me.chkKillSpawn = New System.Windows.Forms.CheckBox()
        Me.chkInfAmmo = New System.Windows.Forms.CheckBox()
        Me.chkDblAmmo = New System.Windows.Forms.CheckBox()
        Me.chkMonsterRespawn = New System.Windows.Forms.CheckBox()
        Me.chkFastMonsters = New System.Windows.Forms.CheckBox()
        Me.chkNoMonsters = New System.Windows.Forms.CheckBox()
        Me.chkCheatsEn = New System.Windows.Forms.CheckBox()
        Me.tpgDeathmatch = New System.Windows.Forms.TabPage()
        Me.chkTeamSwitching = New System.Windows.Forms.CheckBox()
        Me.chkKeepFragsGained = New System.Windows.Forms.CheckBox()
        Me.chkRespawnProtection = New System.Windows.Forms.CheckBox()
        Me.chkLoseFrag = New System.Windows.Forms.CheckBox()
        Me.chkAllowExit = New System.Windows.Forms.CheckBox()
        Me.chkSameMap = New System.Windows.Forms.CheckBox()
        Me.chkSpawnFarthest = New System.Windows.Forms.CheckBox()
        Me.chkArmorSpawn = New System.Windows.Forms.CheckBox()
        Me.chkHealthSpawn = New System.Windows.Forms.CheckBox()
        Me.chkAllowPwrUps = New System.Windows.Forms.CheckBox()
        Me.chkWeaponsStay = New System.Windows.Forms.CheckBox()
        Me.tpgCoOp = New System.Windows.Forms.TabPage()
        Me.chkSpawnDeathspot = New System.Windows.Forms.CheckBox()
        Me.chkLoseHalfAmmo = New System.Windows.Forms.CheckBox()
        Me.chkLoseWeapons = New System.Windows.Forms.CheckBox()
        Me.chkLoseAmmo = New System.Windows.Forms.CheckBox()
        Me.chkLosePowerUps = New System.Windows.Forms.CheckBox()
        Me.chkLoseArmor = New System.Windows.Forms.CheckBox()
        Me.chkLoseKeys = New System.Windows.Forms.CheckBox()
        Me.chkLoseInventory = New System.Windows.Forms.CheckBox()
        Me.chkNoMPWeapons = New System.Windows.Forms.CheckBox()
        Me.btnBuildCmd = New System.Windows.Forms.Button()
        Me.tmrBuildCmd = New System.Windows.Forms.Timer(Me.components)
        Me.ttpBrutalDoom = New System.Windows.Forms.ToolTip(Me.components)
        Me.ssYAZDL = New System.Windows.Forms.StatusStrip()
        Me.sslZDFolderSelected = New System.Windows.Forms.ToolStripStatusLabel()
        Me.tbcGameSettings.SuspendLayout()
        Me.tbpMultiplayer.SuspendLayout()
        Me.tbpGameType.SuspendLayout()
        Me.tbpPatchMod.SuspendLayout()
        Me.tbpGamePlay.SuspendLayout()
        Me.tpgDeathmatch.SuspendLayout()
        Me.tpgCoOp.SuspendLayout()
        Me.ssYAZDL.SuspendLayout()
        Me.SuspendLayout()
        '
        'lstIWads
        '
        Me.lstIWads.FormattingEnabled = True
        Me.lstIWads.Location = New System.Drawing.Point(12, 12)
        Me.lstIWads.Name = "lstIWads"
        Me.lstIWads.Size = New System.Drawing.Size(205, 290)
        Me.lstIWads.TabIndex = 0
        Me.lstIWads.TabStop = False
        '
        'btnZDoomDir
        '
        Me.btnZDoomDir.Location = New System.Drawing.Point(28, 317)
        Me.btnZDoomDir.Name = "btnZDoomDir"
        Me.btnZDoomDir.Size = New System.Drawing.Size(83, 29)
        Me.btnZDoomDir.TabIndex = 1
        Me.btnZDoomDir.Text = "Open File"
        Me.btnZDoomDir.UseVisualStyleBackColor = True
        '
        'txtPath
        '
        Me.txtPath.Location = New System.Drawing.Point(117, 322)
        Me.txtPath.Name = "txtPath"
        Me.txtPath.ReadOnly = True
        Me.txtPath.Size = New System.Drawing.Size(445, 20)
        Me.txtPath.TabIndex = 2
        '
        'lblPlayers
        '
        Me.lblPlayers.AutoSize = True
        Me.lblPlayers.Enabled = False
        Me.lblPlayers.Location = New System.Drawing.Point(124, 34)
        Me.lblPlayers.Name = "lblPlayers"
        Me.lblPlayers.Size = New System.Drawing.Size(51, 13)
        Me.lblPlayers.TabIndex = 6
        Me.lblPlayers.Text = "# Players"
        '
        'cboPlayers
        '
        Me.cboPlayers.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboPlayers.Enabled = False
        Me.cboPlayers.FormattingEnabled = True
        Me.cboPlayers.Items.AddRange(New Object() {"2", "3", "4", "5", "6", "7", "8"})
        Me.cboPlayers.Location = New System.Drawing.Point(124, 50)
        Me.cboPlayers.Name = "cboPlayers"
        Me.cboPlayers.Size = New System.Drawing.Size(62, 21)
        Me.cboPlayers.TabIndex = 5
        '
        'lblRemoteHost
        '
        Me.lblRemoteHost.AutoSize = True
        Me.lblRemoteHost.Enabled = False
        Me.lblRemoteHost.Location = New System.Drawing.Point(8, 35)
        Me.lblRemoteHost.Name = "lblRemoteHost"
        Me.lblRemoteHost.Size = New System.Drawing.Size(42, 13)
        Me.lblRemoteHost.TabIndex = 4
        Me.lblRemoteHost.Text = "Host IP"
        '
        'lblIPValidity
        '
        Me.lblIPValidity.AutoSize = True
        Me.lblIPValidity.Location = New System.Drawing.Point(8, 74)
        Me.lblIPValidity.Name = "lblIPValidity"
        Me.lblIPValidity.Size = New System.Drawing.Size(50, 13)
        Me.lblIPValidity.TabIndex = 3
        Me.lblIPValidity.Text = "IP Status"
        Me.lblIPValidity.Visible = False
        '
        'txtIPAddress
        '
        Me.txtIPAddress.Enabled = False
        Me.txtIPAddress.Location = New System.Drawing.Point(9, 51)
        Me.txtIPAddress.MaxLength = 16
        Me.txtIPAddress.Name = "txtIPAddress"
        Me.txtIPAddress.Size = New System.Drawing.Size(94, 20)
        Me.txtIPAddress.TabIndex = 2
        '
        'radHost
        '
        Me.radHost.AutoSize = True
        Me.radHost.Location = New System.Drawing.Point(56, 6)
        Me.radHost.Name = "radHost"
        Me.radHost.Size = New System.Drawing.Size(47, 17)
        Me.radHost.TabIndex = 1
        Me.radHost.Text = "Host"
        Me.radHost.UseVisualStyleBackColor = True
        '
        'radJoin
        '
        Me.radJoin.AutoSize = True
        Me.radJoin.Location = New System.Drawing.Point(6, 6)
        Me.radJoin.Name = "radJoin"
        Me.radJoin.Size = New System.Drawing.Size(44, 17)
        Me.radJoin.TabIndex = 0
        Me.radJoin.Text = "Join"
        Me.radJoin.UseVisualStyleBackColor = True
        '
        'btnRunZDoom
        '
        Me.btnRunZDoom.Location = New System.Drawing.Point(441, 428)
        Me.btnRunZDoom.Name = "btnRunZDoom"
        Me.btnRunZDoom.Size = New System.Drawing.Size(75, 23)
        Me.btnRunZDoom.TabIndex = 4
        Me.btnRunZDoom.Text = "Play"
        Me.btnRunZDoom.UseVisualStyleBackColor = True
        '
        'txtZDArgs
        '
        Me.txtZDArgs.Location = New System.Drawing.Point(39, 357)
        Me.txtZDArgs.Multiline = True
        Me.txtZDArgs.Name = "txtZDArgs"
        Me.txtZDArgs.ReadOnly = True
        Me.txtZDArgs.Size = New System.Drawing.Size(477, 65)
        Me.txtZDArgs.TabIndex = 5
        '
        'ofdZDoomExe
        '
        Me.ofdZDoomExe.DefaultExt = "exe"
        Me.ofdZDoomExe.Filter = "Application (*.exe)|*.exe"
        '
        'tbcGameSettings
        '
        Me.tbcGameSettings.Controls.Add(Me.tbpMultiplayer)
        Me.tbcGameSettings.Controls.Add(Me.tbpGameType)
        Me.tbcGameSettings.Controls.Add(Me.tbpPatchMod)
        Me.tbcGameSettings.Controls.Add(Me.tbpGamePlay)
        Me.tbcGameSettings.Controls.Add(Me.tpgDeathmatch)
        Me.tbcGameSettings.Controls.Add(Me.tpgCoOp)
        Me.tbcGameSettings.HotTrack = True
        Me.tbcGameSettings.Location = New System.Drawing.Point(232, 12)
        Me.tbcGameSettings.Name = "tbcGameSettings"
        Me.tbcGameSettings.SelectedIndex = 0
        Me.tbcGameSettings.Size = New System.Drawing.Size(357, 290)
        Me.tbcGameSettings.TabIndex = 7
        '
        'tbpMultiplayer
        '
        Me.tbpMultiplayer.Controls.Add(Me.lstIpAddresses)
        Me.tbpMultiplayer.Controls.Add(Me.chkDeathMatch)
        Me.tbpMultiplayer.Controls.Add(Me.radSinglePlayer)
        Me.tbpMultiplayer.Controls.Add(Me.lblPlayers)
        Me.tbpMultiplayer.Controls.Add(Me.radJoin)
        Me.tbpMultiplayer.Controls.Add(Me.cboPlayers)
        Me.tbpMultiplayer.Controls.Add(Me.radHost)
        Me.tbpMultiplayer.Controls.Add(Me.lblRemoteHost)
        Me.tbpMultiplayer.Controls.Add(Me.lblIPValidity)
        Me.tbpMultiplayer.Controls.Add(Me.txtIPAddress)
        Me.tbpMultiplayer.Location = New System.Drawing.Point(4, 22)
        Me.tbpMultiplayer.Name = "tbpMultiplayer"
        Me.tbpMultiplayer.Padding = New System.Windows.Forms.Padding(3)
        Me.tbpMultiplayer.Size = New System.Drawing.Size(349, 264)
        Me.tbpMultiplayer.TabIndex = 0
        Me.tbpMultiplayer.Text = "Multiplayer"
        Me.tbpMultiplayer.UseVisualStyleBackColor = True
        '
        'lstIpAddresses
        '
        Me.lstIpAddresses.FormattingEnabled = True
        Me.lstIpAddresses.Location = New System.Drawing.Point(4, 163)
        Me.lstIpAddresses.Name = "lstIpAddresses"
        Me.lstIpAddresses.SelectionMode = System.Windows.Forms.SelectionMode.None
        Me.lstIpAddresses.Size = New System.Drawing.Size(322, 69)
        Me.lstIpAddresses.TabIndex = 9
        '
        'chkDeathMatch
        '
        Me.chkDeathMatch.AutoSize = True
        Me.chkDeathMatch.Enabled = False
        Me.chkDeathMatch.Location = New System.Drawing.Point(7, 102)
        Me.chkDeathMatch.Name = "chkDeathMatch"
        Me.chkDeathMatch.Size = New System.Drawing.Size(84, 17)
        Me.chkDeathMatch.TabIndex = 8
        Me.chkDeathMatch.Text = "Deathmatch"
        Me.chkDeathMatch.UseVisualStyleBackColor = True
        '
        'radSinglePlayer
        '
        Me.radSinglePlayer.AutoSize = True
        Me.radSinglePlayer.Checked = True
        Me.radSinglePlayer.Location = New System.Drawing.Point(109, 6)
        Me.radSinglePlayer.Name = "radSinglePlayer"
        Me.radSinglePlayer.Size = New System.Drawing.Size(54, 17)
        Me.radSinglePlayer.TabIndex = 7
        Me.radSinglePlayer.TabStop = True
        Me.radSinglePlayer.Text = "Single"
        Me.radSinglePlayer.UseVisualStyleBackColor = True
        '
        'tbpGameType
        '
        Me.tbpGameType.Controls.Add(Me.lblSkill)
        Me.tbpGameType.Controls.Add(Me.lblMap)
        Me.tbpGameType.Controls.Add(Me.chkBrutalDoom)
        Me.tbpGameType.Controls.Add(Me.cboMap)
        Me.tbpGameType.Controls.Add(Me.cboSkillLevel)
        Me.tbpGameType.Location = New System.Drawing.Point(4, 22)
        Me.tbpGameType.Name = "tbpGameType"
        Me.tbpGameType.Padding = New System.Windows.Forms.Padding(3)
        Me.tbpGameType.Size = New System.Drawing.Size(349, 264)
        Me.tbpGameType.TabIndex = 1
        Me.tbpGameType.Text = "Game"
        Me.tbpGameType.UseVisualStyleBackColor = True
        '
        'lblSkill
        '
        Me.lblSkill.AutoSize = True
        Me.lblSkill.Location = New System.Drawing.Point(6, 90)
        Me.lblSkill.Name = "lblSkill"
        Me.lblSkill.Size = New System.Drawing.Size(47, 13)
        Me.lblSkill.TabIndex = 5
        Me.lblSkill.Text = "Difficulty"
        '
        'lblMap
        '
        Me.lblMap.AutoSize = True
        Me.lblMap.Location = New System.Drawing.Point(3, 25)
        Me.lblMap.Name = "lblMap"
        Me.lblMap.Size = New System.Drawing.Size(28, 13)
        Me.lblMap.TabIndex = 4
        Me.lblMap.Text = "Map"
        '
        'chkBrutalDoom
        '
        Me.chkBrutalDoom.AutoSize = True
        Me.chkBrutalDoom.Location = New System.Drawing.Point(196, 65)
        Me.chkBrutalDoom.Name = "chkBrutalDoom"
        Me.chkBrutalDoom.Size = New System.Drawing.Size(84, 17)
        Me.chkBrutalDoom.TabIndex = 3
        Me.chkBrutalDoom.Text = "Brutal Doom"
        Me.ttpBrutalDoom.SetToolTip(Me.chkBrutalDoom, "Check to use Brutal Doom" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "difficulty levels")
        Me.chkBrutalDoom.UseVisualStyleBackColor = True
        '
        'cboMap
        '
        Me.cboMap.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboMap.FormattingEnabled = True
        Me.cboMap.Location = New System.Drawing.Point(6, 41)
        Me.cboMap.Name = "cboMap"
        Me.cboMap.Size = New System.Drawing.Size(121, 21)
        Me.cboMap.TabIndex = 2
        '
        'cboSkillLevel
        '
        Me.cboSkillLevel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboSkillLevel.FormattingEnabled = True
        Me.cboSkillLevel.Location = New System.Drawing.Point(6, 106)
        Me.cboSkillLevel.Name = "cboSkillLevel"
        Me.cboSkillLevel.Size = New System.Drawing.Size(198, 21)
        Me.cboSkillLevel.TabIndex = 1
        '
        'tbpPatchMod
        '
        Me.tbpPatchMod.Controls.Add(Me.lstPatch)
        Me.tbpPatchMod.Location = New System.Drawing.Point(4, 22)
        Me.tbpPatchMod.Name = "tbpPatchMod"
        Me.tbpPatchMod.Padding = New System.Windows.Forms.Padding(3)
        Me.tbpPatchMod.Size = New System.Drawing.Size(349, 264)
        Me.tbpPatchMod.TabIndex = 2
        Me.tbpPatchMod.Text = "Patch/Mod"
        Me.tbpPatchMod.UseVisualStyleBackColor = True
        '
        'lstPatch
        '
        Me.lstPatch.CheckOnClick = True
        Me.lstPatch.Cursor = System.Windows.Forms.Cursors.Default
        Me.lstPatch.FormattingEnabled = True
        Me.lstPatch.Location = New System.Drawing.Point(99, 25)
        Me.lstPatch.Name = "lstPatch"
        Me.lstPatch.Size = New System.Drawing.Size(181, 214)
        Me.lstPatch.TabIndex = 0
        '
        'tbpGamePlay
        '
        Me.tbpGamePlay.Controls.Add(Me.chkForceRespawn)
        Me.tbpGamePlay.Controls.Add(Me.chkKillSpawn)
        Me.tbpGamePlay.Controls.Add(Me.chkInfAmmo)
        Me.tbpGamePlay.Controls.Add(Me.chkDblAmmo)
        Me.tbpGamePlay.Controls.Add(Me.chkMonsterRespawn)
        Me.tbpGamePlay.Controls.Add(Me.chkFastMonsters)
        Me.tbpGamePlay.Controls.Add(Me.chkNoMonsters)
        Me.tbpGamePlay.Controls.Add(Me.chkCheatsEn)
        Me.tbpGamePlay.Location = New System.Drawing.Point(4, 22)
        Me.tbpGamePlay.Name = "tbpGamePlay"
        Me.tbpGamePlay.Padding = New System.Windows.Forms.Padding(3)
        Me.tbpGamePlay.Size = New System.Drawing.Size(349, 264)
        Me.tbpGamePlay.TabIndex = 3
        Me.tbpGamePlay.Text = "Gameplay"
        Me.tbpGamePlay.UseVisualStyleBackColor = True
        '
        'chkForceRespawn
        '
        Me.chkForceRespawn.AutoSize = True
        Me.chkForceRespawn.Location = New System.Drawing.Point(3, 168)
        Me.chkForceRespawn.Name = "chkForceRespawn"
        Me.chkForceRespawn.Size = New System.Drawing.Size(101, 17)
        Me.chkForceRespawn.TabIndex = 17
        Me.chkForceRespawn.Text = "Force Respawn"
        Me.chkForceRespawn.UseVisualStyleBackColor = True
        '
        'chkKillSpawn
        '
        Me.chkKillSpawn.AutoSize = True
        Me.chkKillSpawn.Location = New System.Drawing.Point(3, 145)
        Me.chkKillSpawn.Name = "chkKillSpawn"
        Me.chkKillSpawn.Size = New System.Drawing.Size(120, 17)
        Me.chkKillSpawn.TabIndex = 14
        Me.chkKillSpawn.Text = "Romero Kill Children"
        Me.chkKillSpawn.UseVisualStyleBackColor = True
        '
        'chkInfAmmo
        '
        Me.chkInfAmmo.AutoSize = True
        Me.chkInfAmmo.Location = New System.Drawing.Point(3, 121)
        Me.chkInfAmmo.Name = "chkInfAmmo"
        Me.chkInfAmmo.Size = New System.Drawing.Size(89, 17)
        Me.chkInfAmmo.TabIndex = 13
        Me.chkInfAmmo.Text = "Infinite Ammo"
        Me.chkInfAmmo.UseVisualStyleBackColor = True
        '
        'chkDblAmmo
        '
        Me.chkDblAmmo.AutoSize = True
        Me.chkDblAmmo.Location = New System.Drawing.Point(3, 98)
        Me.chkDblAmmo.Name = "chkDblAmmo"
        Me.chkDblAmmo.Size = New System.Drawing.Size(92, 17)
        Me.chkDblAmmo.TabIndex = 12
        Me.chkDblAmmo.Text = "Double Ammo"
        Me.chkDblAmmo.UseVisualStyleBackColor = True
        '
        'chkMonsterRespawn
        '
        Me.chkMonsterRespawn.AutoSize = True
        Me.chkMonsterRespawn.Location = New System.Drawing.Point(3, 75)
        Me.chkMonsterRespawn.Name = "chkMonsterRespawn"
        Me.chkMonsterRespawn.Size = New System.Drawing.Size(117, 17)
        Me.chkMonsterRespawn.TabIndex = 11
        Me.chkMonsterRespawn.Text = "Respawn Monsters"
        Me.chkMonsterRespawn.UseVisualStyleBackColor = True
        '
        'chkFastMonsters
        '
        Me.chkFastMonsters.AutoSize = True
        Me.chkFastMonsters.Location = New System.Drawing.Point(3, 52)
        Me.chkFastMonsters.Name = "chkFastMonsters"
        Me.chkFastMonsters.Size = New System.Drawing.Size(92, 17)
        Me.chkFastMonsters.TabIndex = 10
        Me.chkFastMonsters.Text = "Fast Monsters"
        Me.chkFastMonsters.UseVisualStyleBackColor = True
        '
        'chkNoMonsters
        '
        Me.chkNoMonsters.AutoSize = True
        Me.chkNoMonsters.Location = New System.Drawing.Point(3, 29)
        Me.chkNoMonsters.Name = "chkNoMonsters"
        Me.chkNoMonsters.Size = New System.Drawing.Size(86, 17)
        Me.chkNoMonsters.TabIndex = 10
        Me.chkNoMonsters.Text = "No Monsters"
        Me.chkNoMonsters.UseVisualStyleBackColor = True
        '
        'chkCheatsEn
        '
        Me.chkCheatsEn.AutoSize = True
        Me.chkCheatsEn.Location = New System.Drawing.Point(3, 6)
        Me.chkCheatsEn.Name = "chkCheatsEn"
        Me.chkCheatsEn.Size = New System.Drawing.Size(95, 17)
        Me.chkCheatsEn.TabIndex = 9
        Me.chkCheatsEn.Text = "Enable Cheats"
        Me.chkCheatsEn.UseVisualStyleBackColor = True
        '
        'tpgDeathmatch
        '
        Me.tpgDeathmatch.Controls.Add(Me.chkTeamSwitching)
        Me.tpgDeathmatch.Controls.Add(Me.chkKeepFragsGained)
        Me.tpgDeathmatch.Controls.Add(Me.chkRespawnProtection)
        Me.tpgDeathmatch.Controls.Add(Me.chkLoseFrag)
        Me.tpgDeathmatch.Controls.Add(Me.chkAllowExit)
        Me.tpgDeathmatch.Controls.Add(Me.chkSameMap)
        Me.tpgDeathmatch.Controls.Add(Me.chkSpawnFarthest)
        Me.tpgDeathmatch.Controls.Add(Me.chkArmorSpawn)
        Me.tpgDeathmatch.Controls.Add(Me.chkHealthSpawn)
        Me.tpgDeathmatch.Controls.Add(Me.chkAllowPwrUps)
        Me.tpgDeathmatch.Controls.Add(Me.chkWeaponsStay)
        Me.tpgDeathmatch.Location = New System.Drawing.Point(4, 22)
        Me.tpgDeathmatch.Name = "tpgDeathmatch"
        Me.tpgDeathmatch.Padding = New System.Windows.Forms.Padding(3)
        Me.tpgDeathmatch.Size = New System.Drawing.Size(349, 264)
        Me.tpgDeathmatch.TabIndex = 4
        Me.tpgDeathmatch.Text = "Deathmatch"
        Me.tpgDeathmatch.UseVisualStyleBackColor = True
        '
        'chkTeamSwitching
        '
        Me.chkTeamSwitching.AutoSize = True
        Me.chkTeamSwitching.Location = New System.Drawing.Point(6, 236)
        Me.chkTeamSwitching.Name = "chkTeamSwitching"
        Me.chkTeamSwitching.Size = New System.Drawing.Size(119, 17)
        Me.chkTeamSwitching.TabIndex = 20
        Me.chkTeamSwitching.Text = "No Team Switching"
        Me.chkTeamSwitching.UseVisualStyleBackColor = True
        '
        'chkKeepFragsGained
        '
        Me.chkKeepFragsGained.AutoSize = True
        Me.chkKeepFragsGained.Location = New System.Drawing.Point(6, 213)
        Me.chkKeepFragsGained.Name = "chkKeepFragsGained"
        Me.chkKeepFragsGained.Size = New System.Drawing.Size(117, 17)
        Me.chkKeepFragsGained.TabIndex = 19
        Me.chkKeepFragsGained.Text = "Keep Frags Gained"
        Me.chkKeepFragsGained.UseVisualStyleBackColor = True
        '
        'chkRespawnProtection
        '
        Me.chkRespawnProtection.AutoSize = True
        Me.chkRespawnProtection.Location = New System.Drawing.Point(6, 167)
        Me.chkRespawnProtection.Name = "chkRespawnProtection"
        Me.chkRespawnProtection.Size = New System.Drawing.Size(122, 17)
        Me.chkRespawnProtection.TabIndex = 18
        Me.chkRespawnProtection.Text = "Respawn Protection"
        Me.chkRespawnProtection.UseVisualStyleBackColor = True
        '
        'chkLoseFrag
        '
        Me.chkLoseFrag.AutoSize = True
        Me.chkLoseFrag.Location = New System.Drawing.Point(6, 190)
        Me.chkLoseFrag.Name = "chkLoseFrag"
        Me.chkLoseFrag.Size = New System.Drawing.Size(123, 17)
        Me.chkLoseFrag.TabIndex = 10
        Me.chkLoseFrag.Text = "Lose Frag if Fragged"
        Me.chkLoseFrag.UseVisualStyleBackColor = True
        '
        'chkAllowExit
        '
        Me.chkAllowExit.AutoSize = True
        Me.chkAllowExit.Location = New System.Drawing.Point(6, 144)
        Me.chkAllowExit.Name = "chkAllowExit"
        Me.chkAllowExit.Size = New System.Drawing.Size(81, 17)
        Me.chkAllowExit.TabIndex = 17
        Me.chkAllowExit.Text = "Disable Exit"
        Me.chkAllowExit.UseVisualStyleBackColor = True
        '
        'chkSameMap
        '
        Me.chkSameMap.AutoSize = True
        Me.chkSameMap.Location = New System.Drawing.Point(6, 121)
        Me.chkSameMap.Name = "chkSameMap"
        Me.chkSameMap.Size = New System.Drawing.Size(77, 17)
        Me.chkSameMap.TabIndex = 15
        Me.chkSameMap.Text = "Same Map"
        Me.chkSameMap.UseVisualStyleBackColor = True
        '
        'chkSpawnFarthest
        '
        Me.chkSpawnFarthest.AutoSize = True
        Me.chkSpawnFarthest.Location = New System.Drawing.Point(6, 98)
        Me.chkSpawnFarthest.Name = "chkSpawnFarthest"
        Me.chkSpawnFarthest.Size = New System.Drawing.Size(100, 17)
        Me.chkSpawnFarthest.TabIndex = 14
        Me.chkSpawnFarthest.Text = "Spawn Farthest"
        Me.chkSpawnFarthest.UseVisualStyleBackColor = True
        '
        'chkArmorSpawn
        '
        Me.chkArmorSpawn.AutoSize = True
        Me.chkArmorSpawn.Location = New System.Drawing.Point(6, 75)
        Me.chkArmorSpawn.Name = "chkArmorSpawn"
        Me.chkArmorSpawn.Size = New System.Drawing.Size(127, 17)
        Me.chkArmorSpawn.TabIndex = 13
        Me.chkArmorSpawn.Text = "Disable Armor Spawn"
        Me.chkArmorSpawn.UseVisualStyleBackColor = True
        '
        'chkHealthSpawn
        '
        Me.chkHealthSpawn.AutoSize = True
        Me.chkHealthSpawn.Location = New System.Drawing.Point(6, 52)
        Me.chkHealthSpawn.Name = "chkHealthSpawn"
        Me.chkHealthSpawn.Size = New System.Drawing.Size(131, 17)
        Me.chkHealthSpawn.TabIndex = 12
        Me.chkHealthSpawn.Text = "Disable Health Spawn"
        Me.chkHealthSpawn.UseVisualStyleBackColor = True
        '
        'chkAllowPwrUps
        '
        Me.chkAllowPwrUps.AutoSize = True
        Me.chkAllowPwrUps.Location = New System.Drawing.Point(6, 29)
        Me.chkAllowPwrUps.Name = "chkAllowPwrUps"
        Me.chkAllowPwrUps.Size = New System.Drawing.Size(111, 17)
        Me.chkAllowPwrUps.TabIndex = 11
        Me.chkAllowPwrUps.Text = "Disable Powerups"
        Me.chkAllowPwrUps.UseVisualStyleBackColor = True
        '
        'chkWeaponsStay
        '
        Me.chkWeaponsStay.AutoSize = True
        Me.chkWeaponsStay.Location = New System.Drawing.Point(6, 6)
        Me.chkWeaponsStay.Name = "chkWeaponsStay"
        Me.chkWeaponsStay.Size = New System.Drawing.Size(96, 17)
        Me.chkWeaponsStay.TabIndex = 10
        Me.chkWeaponsStay.Text = "Weapons Stay"
        Me.chkWeaponsStay.UseVisualStyleBackColor = True
        '
        'tpgCoOp
        '
        Me.tpgCoOp.Controls.Add(Me.chkSpawnDeathspot)
        Me.tpgCoOp.Controls.Add(Me.chkLoseHalfAmmo)
        Me.tpgCoOp.Controls.Add(Me.chkLoseWeapons)
        Me.tpgCoOp.Controls.Add(Me.chkLoseAmmo)
        Me.tpgCoOp.Controls.Add(Me.chkLosePowerUps)
        Me.tpgCoOp.Controls.Add(Me.chkLoseArmor)
        Me.tpgCoOp.Controls.Add(Me.chkLoseKeys)
        Me.tpgCoOp.Controls.Add(Me.chkLoseInventory)
        Me.tpgCoOp.Controls.Add(Me.chkNoMPWeapons)
        Me.tpgCoOp.Location = New System.Drawing.Point(4, 22)
        Me.tpgCoOp.Name = "tpgCoOp"
        Me.tpgCoOp.Padding = New System.Windows.Forms.Padding(3)
        Me.tpgCoOp.Size = New System.Drawing.Size(349, 264)
        Me.tpgCoOp.TabIndex = 5
        Me.tpgCoOp.Text = "Co-Op"
        Me.tpgCoOp.UseVisualStyleBackColor = True
        '
        'chkSpawnDeathspot
        '
        Me.chkSpawnDeathspot.AutoSize = True
        Me.chkSpawnDeathspot.Location = New System.Drawing.Point(6, 190)
        Me.chkSpawnDeathspot.Name = "chkSpawnDeathspot"
        Me.chkSpawnDeathspot.Size = New System.Drawing.Size(134, 17)
        Me.chkSpawnDeathspot.TabIndex = 8
        Me.chkSpawnDeathspot.Text = "Respawn Where Killed"
        Me.chkSpawnDeathspot.UseVisualStyleBackColor = True
        '
        'chkLoseHalfAmmo
        '
        Me.chkLoseHalfAmmo.AutoSize = True
        Me.chkLoseHalfAmmo.Location = New System.Drawing.Point(6, 167)
        Me.chkLoseHalfAmmo.Name = "chkLoseHalfAmmo"
        Me.chkLoseHalfAmmo.Size = New System.Drawing.Size(150, 17)
        Me.chkLoseHalfAmmo.TabIndex = 7
        Me.chkLoseHalfAmmo.Text = "Lose Half Ammo on Death"
        Me.chkLoseHalfAmmo.UseVisualStyleBackColor = True
        '
        'chkLoseWeapons
        '
        Me.chkLoseWeapons.AutoSize = True
        Me.chkLoseWeapons.Location = New System.Drawing.Point(6, 75)
        Me.chkLoseWeapons.Name = "chkLoseWeapons"
        Me.chkLoseWeapons.Size = New System.Drawing.Size(145, 17)
        Me.chkLoseWeapons.TabIndex = 6
        Me.chkLoseWeapons.Text = "Lose Weapons on Death"
        Me.chkLoseWeapons.UseVisualStyleBackColor = True
        '
        'chkLoseAmmo
        '
        Me.chkLoseAmmo.AutoSize = True
        Me.chkLoseAmmo.Location = New System.Drawing.Point(6, 144)
        Me.chkLoseAmmo.Name = "chkLoseAmmo"
        Me.chkLoseAmmo.Size = New System.Drawing.Size(128, 17)
        Me.chkLoseAmmo.TabIndex = 5
        Me.chkLoseAmmo.Text = "Lose Ammo on Death"
        Me.chkLoseAmmo.UseVisualStyleBackColor = True
        '
        'chkLosePowerUps
        '
        Me.chkLosePowerUps.AutoSize = True
        Me.chkLosePowerUps.Location = New System.Drawing.Point(6, 121)
        Me.chkLosePowerUps.Name = "chkLosePowerUps"
        Me.chkLosePowerUps.Size = New System.Drawing.Size(146, 17)
        Me.chkLosePowerUps.TabIndex = 4
        Me.chkLosePowerUps.Text = "Lose Powerups on Death"
        Me.chkLosePowerUps.UseVisualStyleBackColor = True
        '
        'chkLoseArmor
        '
        Me.chkLoseArmor.AutoSize = True
        Me.chkLoseArmor.Location = New System.Drawing.Point(6, 98)
        Me.chkLoseArmor.Name = "chkLoseArmor"
        Me.chkLoseArmor.Size = New System.Drawing.Size(126, 17)
        Me.chkLoseArmor.TabIndex = 3
        Me.chkLoseArmor.Text = "Lose Armor on Death"
        Me.chkLoseArmor.UseVisualStyleBackColor = True
        '
        'chkLoseKeys
        '
        Me.chkLoseKeys.AutoSize = True
        Me.chkLoseKeys.Location = New System.Drawing.Point(6, 52)
        Me.chkLoseKeys.Name = "chkLoseKeys"
        Me.chkLoseKeys.Size = New System.Drawing.Size(122, 17)
        Me.chkLoseKeys.TabIndex = 2
        Me.chkLoseKeys.Text = "Lose Keys on Death"
        Me.chkLoseKeys.UseVisualStyleBackColor = True
        '
        'chkLoseInventory
        '
        Me.chkLoseInventory.AutoSize = True
        Me.chkLoseInventory.Location = New System.Drawing.Point(6, 29)
        Me.chkLoseInventory.Name = "chkLoseInventory"
        Me.chkLoseInventory.Size = New System.Drawing.Size(126, 17)
        Me.chkLoseInventory.TabIndex = 1
        Me.chkLoseInventory.Text = "Lose Entire Inventory"
        Me.chkLoseInventory.UseVisualStyleBackColor = True
        '
        'chkNoMPWeapons
        '
        Me.chkNoMPWeapons.AutoSize = True
        Me.chkNoMPWeapons.Location = New System.Drawing.Point(6, 6)
        Me.chkNoMPWeapons.Name = "chkNoMPWeapons"
        Me.chkNoMPWeapons.Size = New System.Drawing.Size(165, 17)
        Me.chkNoMPWeapons.TabIndex = 0
        Me.chkNoMPWeapons.Text = "Disable MP Weapons Spawn"
        Me.chkNoMPWeapons.UseVisualStyleBackColor = True
        '
        'btnBuildCmd
        '
        Me.btnBuildCmd.Location = New System.Drawing.Point(39, 428)
        Me.btnBuildCmd.Name = "btnBuildCmd"
        Me.btnBuildCmd.Size = New System.Drawing.Size(95, 23)
        Me.btnBuildCmd.TabIndex = 8
        Me.btnBuildCmd.Text = "Build Run Args"
        Me.btnBuildCmd.UseVisualStyleBackColor = True
        '
        'tmrBuildCmd
        '
        '
        'ttpBrutalDoom
        '
        Me.ttpBrutalDoom.IsBalloon = True
        '
        'ssYAZDL
        '
        Me.ssYAZDL.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.sslZDFolderSelected})
        Me.ssYAZDL.Location = New System.Drawing.Point(0, 626)
        Me.ssYAZDL.Name = "ssYAZDL"
        Me.ssYAZDL.Size = New System.Drawing.Size(598, 22)
        Me.ssYAZDL.TabIndex = 9
        Me.ssYAZDL.Text = "StatusStrip1"
        '
        'sslZDFolderSelected
        '
        Me.sslZDFolderSelected.Name = "sslZDFolderSelected"
        Me.sslZDFolderSelected.Size = New System.Drawing.Size(0, 17)
        '
        'frmMain
        '
        Me.AcceptButton = Me.btnRunZDoom
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(598, 648)
        Me.Controls.Add(Me.ssYAZDL)
        Me.Controls.Add(Me.btnBuildCmd)
        Me.Controls.Add(Me.tbcGameSettings)
        Me.Controls.Add(Me.txtZDArgs)
        Me.Controls.Add(Me.btnRunZDoom)
        Me.Controls.Add(Me.txtPath)
        Me.Controls.Add(Me.btnZDoomDir)
        Me.Controls.Add(Me.lstIWads)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "YAZDL:  Yet Another ZDoom Launcher"
        Me.tbcGameSettings.ResumeLayout(False)
        Me.tbpMultiplayer.ResumeLayout(False)
        Me.tbpMultiplayer.PerformLayout()
        Me.tbpGameType.ResumeLayout(False)
        Me.tbpGameType.PerformLayout()
        Me.tbpPatchMod.ResumeLayout(False)
        Me.tbpGamePlay.ResumeLayout(False)
        Me.tbpGamePlay.PerformLayout()
        Me.tpgDeathmatch.ResumeLayout(False)
        Me.tpgDeathmatch.PerformLayout()
        Me.tpgCoOp.ResumeLayout(False)
        Me.tpgCoOp.PerformLayout()
        Me.ssYAZDL.ResumeLayout(False)
        Me.ssYAZDL.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lstIWads As System.Windows.Forms.ListBox
    Friend WithEvents btnZDoomDir As System.Windows.Forms.Button
    Friend WithEvents txtPath As System.Windows.Forms.TextBox
    Friend WithEvents txtIPAddress As System.Windows.Forms.TextBox
    Friend WithEvents radHost As System.Windows.Forms.RadioButton
    Friend WithEvents radJoin As System.Windows.Forms.RadioButton
    Friend WithEvents lblIPValidity As System.Windows.Forms.Label
    Friend WithEvents lblRemoteHost As System.Windows.Forms.Label
    Friend WithEvents cboPlayers As System.Windows.Forms.ComboBox
    Friend WithEvents lblPlayers As System.Windows.Forms.Label
    Friend WithEvents btnRunZDoom As System.Windows.Forms.Button
    Friend WithEvents txtZDArgs As System.Windows.Forms.TextBox
    Friend WithEvents ofdZDoomExe As System.Windows.Forms.OpenFileDialog
    Friend WithEvents tbcGameSettings As System.Windows.Forms.TabControl
    Friend WithEvents tbpMultiplayer As System.Windows.Forms.TabPage
    Friend WithEvents tbpGameType As System.Windows.Forms.TabPage
    Friend WithEvents tbpPatchMod As System.Windows.Forms.TabPage
    Friend WithEvents cboSkillLevel As System.Windows.Forms.ComboBox
    Friend WithEvents lstPatch As System.Windows.Forms.CheckedListBox
    Friend WithEvents cboMap As System.Windows.Forms.ComboBox
    Friend WithEvents chkBrutalDoom As System.Windows.Forms.CheckBox
    Friend WithEvents btnBuildCmd As System.Windows.Forms.Button
    Friend WithEvents chkCheatsEn As System.Windows.Forms.CheckBox
    Friend WithEvents radSinglePlayer As System.Windows.Forms.RadioButton
    Friend WithEvents chkDeathMatch As System.Windows.Forms.CheckBox
    Friend WithEvents tbpGamePlay As System.Windows.Forms.TabPage
    Friend WithEvents chkInfAmmo As System.Windows.Forms.CheckBox
    Friend WithEvents chkDblAmmo As System.Windows.Forms.CheckBox
    Friend WithEvents chkMonsterRespawn As System.Windows.Forms.CheckBox
    Friend WithEvents chkFastMonsters As System.Windows.Forms.CheckBox
    Friend WithEvents chkNoMonsters As System.Windows.Forms.CheckBox
    Friend WithEvents chkKillSpawn As System.Windows.Forms.CheckBox
    Friend WithEvents tpgDeathmatch As System.Windows.Forms.TabPage
    Friend WithEvents tpgCoOp As System.Windows.Forms.TabPage
    Friend WithEvents chkForceRespawn As System.Windows.Forms.CheckBox
    Friend WithEvents chkTeamSwitching As System.Windows.Forms.CheckBox
    Friend WithEvents chkKeepFragsGained As System.Windows.Forms.CheckBox
    Friend WithEvents chkRespawnProtection As System.Windows.Forms.CheckBox
    Friend WithEvents chkLoseFrag As System.Windows.Forms.CheckBox
    Friend WithEvents chkAllowExit As System.Windows.Forms.CheckBox
    Friend WithEvents chkSameMap As System.Windows.Forms.CheckBox
    Friend WithEvents chkSpawnFarthest As System.Windows.Forms.CheckBox
    Friend WithEvents chkArmorSpawn As System.Windows.Forms.CheckBox
    Friend WithEvents chkHealthSpawn As System.Windows.Forms.CheckBox
    Friend WithEvents chkAllowPwrUps As System.Windows.Forms.CheckBox
    Friend WithEvents chkWeaponsStay As System.Windows.Forms.CheckBox
    Friend WithEvents tmrBuildCmd As System.Windows.Forms.Timer
    Friend WithEvents chkSpawnDeathspot As System.Windows.Forms.CheckBox
    Friend WithEvents chkLoseHalfAmmo As System.Windows.Forms.CheckBox
    Friend WithEvents chkLoseWeapons As System.Windows.Forms.CheckBox
    Friend WithEvents chkLoseAmmo As System.Windows.Forms.CheckBox
    Friend WithEvents chkLosePowerUps As System.Windows.Forms.CheckBox
    Friend WithEvents chkLoseArmor As System.Windows.Forms.CheckBox
    Friend WithEvents chkLoseKeys As System.Windows.Forms.CheckBox
    Friend WithEvents chkLoseInventory As System.Windows.Forms.CheckBox
    Friend WithEvents chkNoMPWeapons As System.Windows.Forms.CheckBox
    Friend WithEvents lstIpAddresses As System.Windows.Forms.ListBox
    Friend WithEvents lblSkill As System.Windows.Forms.Label
    Friend WithEvents lblMap As System.Windows.Forms.Label
    Friend WithEvents ttpBrutalDoom As System.Windows.Forms.ToolTip
    Friend WithEvents ssYAZDL As System.Windows.Forms.StatusStrip
    Friend WithEvents sslZDFolderSelected As System.Windows.Forms.ToolStripStatusLabel

End Class
