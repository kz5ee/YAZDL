<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
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
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.ofdZDoomExe = New System.Windows.Forms.OpenFileDialog()
        Me.txtZDoomCommand = New System.Windows.Forms.TextBox()
        Me.tbcGameSettings = New System.Windows.Forms.TabControl()
        Me.tbpMultiplayer = New System.Windows.Forms.TabPage()
        Me.tbpGameType = New System.Windows.Forms.TabPage()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.cboSkillLevel = New System.Windows.Forms.ComboBox()
        Me.tbpPatchMod = New System.Windows.Forms.TabPage()
        Me.lstPatch = New System.Windows.Forms.CheckedListBox()
        Me.tbcGameSettings.SuspendLayout()
        Me.tbpMultiplayer.SuspendLayout()
        Me.tbpGameType.SuspendLayout()
        Me.tbpPatchMod.SuspendLayout()
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
        Me.btnZDoomDir.Location = New System.Drawing.Point(39, 319)
        Me.btnZDoomDir.Name = "btnZDoomDir"
        Me.btnZDoomDir.Size = New System.Drawing.Size(99, 23)
        Me.btnZDoomDir.TabIndex = 1
        Me.btnZDoomDir.Text = "ZDoom Folder"
        Me.btnZDoomDir.UseVisualStyleBackColor = True
        '
        'txtPath
        '
        Me.txtPath.Location = New System.Drawing.Point(158, 322)
        Me.txtPath.Name = "txtPath"
        Me.txtPath.ReadOnly = True
        Me.txtPath.Size = New System.Drawing.Size(349, 20)
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
        Me.btnRunZDoom.Location = New System.Drawing.Point(505, 397)
        Me.btnRunZDoom.Name = "btnRunZDoom"
        Me.btnRunZDoom.Size = New System.Drawing.Size(75, 23)
        Me.btnRunZDoom.TabIndex = 4
        Me.btnRunZDoom.Text = "Play"
        Me.btnRunZDoom.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(38, 400)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.ReadOnly = True
        Me.TextBox1.Size = New System.Drawing.Size(433, 20)
        Me.TextBox1.TabIndex = 5
        '
        'ofdZDoomExe
        '
        Me.ofdZDoomExe.DefaultExt = "exe"
        Me.ofdZDoomExe.Filter = "Application (*.exe)|*.exe"
        '
        'txtZDoomCommand
        '
        Me.txtZDoomCommand.Location = New System.Drawing.Point(38, 450)
        Me.txtZDoomCommand.Multiline = True
        Me.txtZDoomCommand.Name = "txtZDoomCommand"
        Me.txtZDoomCommand.Size = New System.Drawing.Size(356, 108)
        Me.txtZDoomCommand.TabIndex = 6
        '
        'tbcGameSettings
        '
        Me.tbcGameSettings.Controls.Add(Me.tbpMultiplayer)
        Me.tbcGameSettings.Controls.Add(Me.tbpGameType)
        Me.tbcGameSettings.Controls.Add(Me.tbpPatchMod)
        Me.tbcGameSettings.Location = New System.Drawing.Point(232, 12)
        Me.tbcGameSettings.Name = "tbcGameSettings"
        Me.tbcGameSettings.SelectedIndex = 0
        Me.tbcGameSettings.Size = New System.Drawing.Size(375, 290)
        Me.tbcGameSettings.TabIndex = 7
        '
        'tbpMultiplayer
        '
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
        Me.tbpMultiplayer.Size = New System.Drawing.Size(367, 264)
        Me.tbpMultiplayer.TabIndex = 0
        Me.tbpMultiplayer.Text = "Multiplayer"
        Me.tbpMultiplayer.UseVisualStyleBackColor = True
        '
        'tbpGameType
        '
        Me.tbpGameType.Controls.Add(Me.ComboBox1)
        Me.tbpGameType.Controls.Add(Me.cboSkillLevel)
        Me.tbpGameType.Location = New System.Drawing.Point(4, 22)
        Me.tbpGameType.Name = "tbpGameType"
        Me.tbpGameType.Padding = New System.Windows.Forms.Padding(3)
        Me.tbpGameType.Size = New System.Drawing.Size(367, 264)
        Me.tbpGameType.TabIndex = 1
        Me.tbpGameType.Text = "Game"
        Me.tbpGameType.UseVisualStyleBackColor = True
        '
        'ComboBox1
        '
        Me.ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(6, 39)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(121, 21)
        Me.ComboBox1.TabIndex = 2
        '
        'cboSkillLevel
        '
        Me.cboSkillLevel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboSkillLevel.FormattingEnabled = True
        Me.cboSkillLevel.Items.AddRange(New Object() {"I'm too young to die", "Hey, not too rough", "Hurt me plenty", "Ultra-violence", "NIGHTMARE!"})
        Me.cboSkillLevel.Location = New System.Drawing.Point(6, 95)
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
        Me.tbpPatchMod.Size = New System.Drawing.Size(367, 264)
        Me.tbpPatchMod.TabIndex = 2
        Me.tbpPatchMod.Text = "Patch/Mod"
        Me.tbpPatchMod.UseVisualStyleBackColor = True
        '
        'lstPatch
        '
        Me.lstPatch.CheckOnClick = True
        Me.lstPatch.Cursor = System.Windows.Forms.Cursors.Default
        Me.lstPatch.FormattingEnabled = True
        Me.lstPatch.Location = New System.Drawing.Point(90, 24)
        Me.lstPatch.Name = "lstPatch"
        Me.lstPatch.Size = New System.Drawing.Size(181, 214)
        Me.lstPatch.TabIndex = 0
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(621, 648)
        Me.Controls.Add(Me.tbcGameSettings)
        Me.Controls.Add(Me.txtZDoomCommand)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.btnRunZDoom)
        Me.Controls.Add(Me.txtPath)
        Me.Controls.Add(Me.btnZDoomDir)
        Me.Controls.Add(Me.lstIWads)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ZDoom Launcher"
        Me.tbcGameSettings.ResumeLayout(False)
        Me.tbpMultiplayer.ResumeLayout(False)
        Me.tbpMultiplayer.PerformLayout()
        Me.tbpGameType.ResumeLayout(False)
        Me.tbpPatchMod.ResumeLayout(False)
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
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents ofdZDoomExe As System.Windows.Forms.OpenFileDialog
    Friend WithEvents txtZDoomCommand As System.Windows.Forms.TextBox
    Friend WithEvents tbcGameSettings As System.Windows.Forms.TabControl
    Friend WithEvents tbpMultiplayer As System.Windows.Forms.TabPage
    Friend WithEvents tbpGameType As System.Windows.Forms.TabPage
    Friend WithEvents tbpPatchMod As System.Windows.Forms.TabPage
    Friend WithEvents cboSkillLevel As System.Windows.Forms.ComboBox
    Friend WithEvents lstPatch As System.Windows.Forms.CheckedListBox
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox

End Class
