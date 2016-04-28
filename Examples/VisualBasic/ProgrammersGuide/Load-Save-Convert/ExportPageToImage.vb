'////////////////////////////////////////////////////////////////////////
' Copyright 2001-2015 Aspose Pty Ltd. All Rights Reserved.
'
' This file is part of Aspose.Diagram. The source code in this file
' is only intended as a supplement to the documentation, and is provided
' "as is", without warranty of any kind, either expressed or implied.
'////////////////////////////////////////////////////////////////////////

Imports Microsoft.VisualBasic
Imports System.IO

Imports Aspose.Diagram
Imports Aspose.Diagram.Saving

Namespace VisualBasic.Diagrams
    Public Class ExportPageToImage
        Public Shared Sub Run()
            'ExStart:ExportPageToImage
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_Diagrams()
            ' load diagram
            Dim diagram As New Diagram(dataDir & "ExportPageToImage.vsd")

            'Save diagram as PNG
            Dim options As New ImageSaveOptions(SaveFileFormat.PNG)

            ' Save one page only, by page index
            options.PageIndex = 0

            'Save resultant Image file
            diagram.Save(dataDir & "ExportPageToImage_Out.png", options)
            'ExEnd:ExportPageToImage
        End Sub
    End Class
End Namespace