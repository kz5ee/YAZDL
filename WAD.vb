Imports System.Collections.Generic
Imports System.Text
Imports System.IO


Namespace WAD.IO
    Friend Class WAD

        'Got these constants and encoder from GZDB
        'Types of WAD
        Public Const IWAD As String = "IWAD"
        Public Const PWAD As String = "PWAD"

        'Encoder
        Public Shared ReadOnly WADTypeEncoding As Encoding = Encoding.ASCII

        'File manipulation stuff
        Private WADFileStream As FileStream
        Private reader As BinaryReader

        'Header stuff
        '0x00 is the type of WAD
        '0x04 is the number of lumps (We don't care about these, just part of the anatomy of the WAD)
        '0x08 is the directory location pointer (Again, we don't care about this, part of the anatomy)

        Private WADType As String

        Public ReadOnly Property TestWADType() As String
            Get
                Return WADType
            End Get
        End Property
        Public ReadOnly Property HEncoding() As Encoding
            Get
                Return WADTypeEncoding
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

            reader = New BinaryReader(WADFileStream, WADTypeEncoding)

            'Read header info
            ReadHeader()

        End Sub

        'This reads the WAD header
        Private Sub ReadHeader()
            'Go to beginning
            WADFileStream.Seek(0, SeekOrigin.Begin)

            'Read WAD type
            WADType = WADTypeEncoding.GetString(reader.ReadBytes(4))

            'Close the file when we're done
            reader.Close()

        End Sub


    End Class
End Namespace

