Imports System.Net


Public Class frmMain
    Public RunString As String = (txtPath.Text & "\zxoom.exe")


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnZDoomDir.Click
        Dim ZDoomFolder As String

        fbdZDoom.ShowDialog()
        ZDoomFolder = fbdZDoom.SelectedPath

        If ZDoomFolder <> "" Then
            GetWadFiles(ZDoomFolder)
            txtPath.Text = ZDoomFolder
            My.Settings.ZDoomDirectory = ZDoomFolder
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
        Dim di As New IO.DirectoryInfo(Folder)
        Dim diar1 As IO.FileInfo() = di.GetFiles("*.WAD")
        Dim dra As IO.FileInfo

        'list the names of all files in the specified directory
        For Each dra In diar1
            lstWads.Items.Add(dra)
        Next

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


        Process.Start(txtPath.Text & "\zdoom.exe")
    End Sub
End Class
