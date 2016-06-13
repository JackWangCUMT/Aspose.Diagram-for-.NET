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
Imports Aspose.Diagram.AutoLayout

Namespace VisualBasic.Diagrams
    Public Class LayOutShapesInCompactTreeStyle
        Public Shared Sub Run()
            ' ExStart:LayOutShapesInCompactTreeStyle
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_Diagrams()

            Dim fileName As String = "LayOutShapesInCompactTreeStyle.vdx"
            Dim diagram As New Diagram(dataDir & fileName)

            Dim compactTreeOptions As New LayoutOptions()
            compactTreeOptions.LayoutStyle = LayoutStyle.CompactTree
            compactTreeOptions.EnlargePage = True

            compactTreeOptions.Direction = LayoutDirection.DownThenRight
            diagram.Layout(compactTreeOptions)
            diagram.Save(dataDir & "sample_down_right.vdx", SaveFileFormat.VDX)

            diagram = New Diagram(dataDir & fileName)
            compactTreeOptions.Direction = LayoutDirection.DownThenLeft
            diagram.Layout(compactTreeOptions)
            diagram.Save(dataDir & "sample_down_left.vdx", SaveFileFormat.VDX)

            diagram = New Diagram(dataDir & fileName)
            compactTreeOptions.Direction = LayoutDirection.RightThenDown
            diagram.Layout(compactTreeOptions)
            diagram.Save(dataDir & "sample_right_down.vdx", SaveFileFormat.VDX)

            diagram = New Diagram(dataDir & fileName)
            compactTreeOptions.Direction = LayoutDirection.LeftThenDown
            diagram.Layout(compactTreeOptions)
            diagram.Save(dataDir & "sample_left_down.vdx", SaveFileFormat.VDX)
            ' ExEnd:LayOutShapesInCompactTreeStyle
        End Sub
    End Class
End Namespace