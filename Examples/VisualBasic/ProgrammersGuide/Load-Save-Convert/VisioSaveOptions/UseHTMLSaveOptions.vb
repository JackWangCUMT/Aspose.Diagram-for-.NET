﻿Imports Aspose.Diagram.Saving

Imports Aspose.Diagram
Imports System
Imports System.IO

Public Class UseHTMLSaveOptions
    Public Shared Sub Run()
        ' ExStart:UseHTMLSaveOptions
        ' The path to the documents directory.
        Dim dataDir As String = RunExamples.GetDataDir_LoadSaveConvert()

        ' call the diagram constructor to a VSDX diagram
        Dim diagram As New Diagram(dataDir & Convert.ToString("Drawing1.vsdx"))

        ' Options when saving a diagram into the HTML format
        Dim options As New HTMLSaveOptions()

        ' Summary:
        '     value or the font is not installed locally, they may appear as a block,
        '     set the DefaultFont such as MingLiu or MS Gothic to show these
        '     characters.
        options.DefaultFont = "MS Gothic"
        ' sets the number of pages to render in HTML.
        options.PageCount = 2
        ' sets the 0-based index of the first page to render. Default is 0.
        options.PageIndex = 0

        ' set page size
        Dim pgSize As New PageSize(PaperSizeFormat.A1)
        options.PageSize = pgSize
        ' discard saving background pages of the Visio diagram
        options.SaveForegroundPagesOnly = True

        ' specify whether to include the toolbar or not. Default value is true.
        options.SaveToolBar = False
        ' set title of the HTML document
        options.Title = "Title goes here"

        ' save in any supported file format
        diagram.Save(dataDir & Convert.ToString("UseHTMLSaveOptions_Out.html"), options)

        ' save resultant HTML directly to a stream
        Dim stream As New MemoryStream()
        diagram.Save(stream, SaveFileFormat.HTML)
        ' ExEnd:UseHTMLSaveOptions
    End Sub
End Class
