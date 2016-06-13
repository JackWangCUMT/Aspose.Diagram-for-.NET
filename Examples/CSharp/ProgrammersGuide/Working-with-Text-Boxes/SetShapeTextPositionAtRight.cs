﻿using Aspose.Diagram;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CSharp.ProgrammersGuide.Working_with_Text_Boxes
{
    public class SetShapeTextPositionAtRight
    {
        public static void Run() 
        {
            // ExStart:SetShapeTextPositionAtRight
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_ShapeTextBoxData();

            // load source Visio diagram
            Diagram diagram = new Diagram(dataDir + "Drawing1.vsdx");
            // get shape
            long shapeid = 1;
            Shape shape = diagram.Pages.GetPage("Page-1").Shapes.GetShape(shapeid);

            // set text position at the right,
            // TxtLocPinX = "TxtWidth*0" and TxtPinX = "Width*1"
            shape.TextXForm.TxtLocPinX.Value = 0;
            shape.TextXForm.TxtPinX.Value = shape.XForm.Width.Value;
            // set orientation angle
            double angleDeg = 0;
            double angleRad = (Math.PI / 180) * angleDeg;
            shape.TextXForm.TxtAngle.Value = angleRad;

            // save Visio diagram in the local storage
            diagram.Save(dataDir + "SetShapeTextPositionAtRight_Out.vsdx", SaveFileFormat.VSDX);
            // ExEnd:SetShapeTextPositionAtRight
        }
    }
}
