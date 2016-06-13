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
Imports System

Namespace VisualBasic.Shapes
    Public Class SetLineData
        Public Shared Sub Run()
            ' ExStart:SetLineData
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_Shapes()

            ' load a Visio diagram
            Dim diagram As New Diagram(dataDir & Convert.ToString("SetLineData.vsd"))
            ' get the page by its name
            Dim page1 As Aspose.Diagram.Page = diagram.Pages.GetPage("Page-1")
            ' get shape by its ID
            Dim shape As Aspose.Diagram.Shape = page1.Shapes.GetShape(1)
            ' set line dash type by index
            shape.Line.LinePattern.Value = 4
            ' set line weight, defualt in PT
            shape.Line.LineWeight.Value = 2
            ' set color of the shape' S line
            shape.Line.LineColor.Ufe.F = "RGB(95,108,53)"
            ' set line rounding, default in inch
            shape.Line.Rounding.Value = 0.3125
            ' set line caps
            shape.Line.LineCap.Value = BOOL.True
            ' set line color transparency in percent
            shape.Line.LineColorTrans.Value = 50

            ' add arrows to the connector or curve shapes 

            ' select arrow type by index
            shape.Line.BeginArrow.Value = 4
            shape.Line.EndArrow.Value = 4
            ' set arrow size 
            shape.Line.BeginArrowSize.Value = ArrowSizeValue.Large
            shape.Line.BeginArrowSize.Value = ArrowSizeValue.Large

            ' save the Visio
            diagram.Save(dataDir & Convert.ToString("SetLineData_Out.vsdx"), SaveFileFormat.VSDX)
            ' ExEnd:SetLineData
        End Sub
    End Class
End Namespace