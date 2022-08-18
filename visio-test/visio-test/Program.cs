using System;
using Visio = Microsoft.Office.Interop.Visio;
using Excel = Microsoft.Office.Interop.Excel;

//generate the VISIO file

List<Box> boxes = new List<Box>();

//adding a new box to the list of boxes
boxes.Add(new Box("1", "General Manager"));

boxes[0].Type = BoxTypes.Executive;
boxes.Add(new Box("2", "Research & Development", "1", 1));
boxes.Add(new Box("3", "Customer Support", "1", 1));
boxes.Add(new Box("4", "Sales", "1", 1));
boxes.Add(new Box("5", "Marketing", "1", 1));
boxes.Add(new Box("6", "Accounting", "1", 1));

//setting some properties such as fore color, back color
boxes[1].Type = BoxTypes.Manager;
boxes[1].ForeColor = Colors.Red;

boxes[2].BackColor = System.Drawing.Color.LightGreen;

boxes.Add(new Box("9", "Project Management", "2", 2));
boxes.Add(new Box("10", "Quality Assurance", "2", 2));
boxes.Add(new Box("11", "System Analyst", "2", 2));
boxes.Add(new Box("12", "Development", "2", 2));

Ids.OrganogramDesigner.Designer designer = new Designer();
designer.Boxes = boxes;
designer.SaveFolder = @"d:\Projects\DrawVisio\";
designer.VisioTemplatePath = @"C:\Program Files 
	(x86)\Microsoft Office\Office12\1033\ORGCH_M.VST";
designer.GenerateDiagram();