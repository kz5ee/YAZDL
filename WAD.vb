Imports System.Collections.Generic
Imports System.Text
Imports System.IO


Namespace WAD.IO
    Friend Class WAD

        'Got these constants and encoder from GZDB
        'Types of WAD
        Public Const IWAD As String = "IWAD"
        Public Const PWAD As String = "PWAD"

        Public Shared LumpNames As List(Of String)

        'Encoder
        Public Shared ReadOnly WADEncoding As Encoding = Encoding.ASCII

        'File manipulation stuff
        Private WADFileStream As FileStream
        Private reader As BinaryReader

        'Header stuff
        '0x00 is the type of WAD
        '0x04 is the number of lumps (We don't care about these, just part of the anatomy of the WAD)
        '0x08 is the directory location pointer (Again, we don't care about this, part of the anatomy)

        Private WADType As String
        Private NumLumps As Integer
        Private Offset As Integer

        Public ReadOnly Property TestWADType() As String
            Get
                Return WADType
            End Get
        End Property
        Public ReadOnly Property HEncoding() As Encoding
            Get
                Return WADEncoding
            End Get
        End Property

        ' Constructor for opening WAD files
        Public Sub New(WADFile As String)
            Me.WADOpen(WADFile)
        End Sub


        'Open the WAD file
        Private Sub WADOpen(WADFile As String)

            'Open the filestream
            WADFileStream = File.Open(WADFile, FileMode.Open, FileAccess.Read, FileShare.None)

            reader = New BinaryReader(WADFileStream, WADEncoding)

            'Read header info
            ReadHeader()

            GetLumpNames()
        End Sub

        'This reads the WAD header
        Private Sub ReadHeader()

            'Go to beginning
            WADFileStream.Seek(0, SeekOrigin.Begin)

            'Read WAD type
            WADType = WADEncoding.GetString(reader.ReadBytes(4))

        End Sub

        Private Sub GetLumpNames()
            Dim Counter As Integer = 0
            Dim Lumps As Integer = 0
            Dim Offset As Integer = 0
            'Lump variables.
            Dim LumpAddr As Integer = 0
            Dim LumpSize As Integer = 0
            Dim LumpName As String = vbNullString

            Lumps = reader.ReadInt32
            Offset = reader.ReadInt32

            LumpNames = New List(Of String)

            reader.BaseStream.Seek(Offset, SeekOrigin.Begin)

            While (Counter < Lumps)
                'Read lump offset and lump size.
                LumpAddr = reader.ReadInt32
                LumpSize = reader.ReadInt32
                'Get lump name.
                LumpName = Encoding.ASCII.GetString(reader.ReadBytes(8)).Replace(Chr(0), "")
                'Add lump name to list if it's a map name
                If LumpName.Length > 3 Then
                    If LumpName.StartsWith("E") And Char.IsDigit(LumpName(1)) Then
                        LumpNames.Add(LumpName)
                    ElseIf LumpName.StartsWith("MAP") And Char.IsDigit(LumpName(3)) Then
                        LumpNames.Add(LumpName)
                    End If
                End If

                'INC Counter
                Counter += 1
            End While
            'Close file.
            reader.Close()

        End Sub

    End Class
End Namespace

