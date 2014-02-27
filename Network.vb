#Region "LICENSE_NOTICE"
'This Source Code Form is subject to the terms of the Mozilla Public
'License, v. 2.0. If a copy of the MPL was not distributed with this
'file, You can obtain one at http://mozilla.org/MPL/2.0/.
#End Region

Imports System.Net
Imports System.Net.NetworkInformation
Module NetworkFunc
    Public Sub GetNetworkStuff()

        Dim NetworkInterfaces As NetworkInterface() = NetworkInterface.GetAllNetworkInterfaces()
        Dim adapter As NetworkInterface

        Dim AdapterInfo As IPInterfaceProperties = Nothing
        Dim GatewayAddrs As GatewayIPAddressInformationCollection = Nothing
        Dim IPAddresses As New List(Of String)
        Dim SubnetMasks As New List(Of String)
        Dim Gateways As New List(Of String)

        For Each adapter In NetworkInterfaces
            If adapter.NetworkInterfaceType = NetworkInterfaceType.Loopback Then
                Continue For
            End If

            AdapterInfo = adapter.GetIPProperties
            GatewayAddrs = AdapterInfo.GatewayAddresses

            Dim IPInfo As UnicastIPAddressInformationCollection = adapter.GetIPProperties().UnicastAddresses
            Dim properties As IPInterfaceProperties = adapter.GetIPProperties()

            For Each IPAddressInfo As UnicastIPAddressInformation In IPInfo
                If adapter.Name.StartsWith("isatap") Then
                Else
                    frmMain.lstIpAddresses.Items.Add(adapter.Name & " (" & IPAddressInfo.Address.ToString & ")")
                    IPAddresses.Add(IPAddressInfo.Address.ToString)
                    SubnetMasks.Add(IPAddressInfo.IPv4Mask.ToString)
                End If
            Next

            For Each Gateway As GatewayIPAddressInformation In GatewayAddrs
                Gateways.Add(Gateway.Address.ToString)
            Next
        Next

    End Sub

End Module
