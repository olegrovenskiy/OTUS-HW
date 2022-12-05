using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Ids.OrganogramDesigner;

namespace OrganogramTest
{
    class Program
    {
        public static void Main(string[] args)
        {
            List<Box> boxes = new List<Box>();

            boxes.Add(new Box("1", "General Manager"));

            boxes[0].Type = BoxTypes.Executive;

            boxes.Add(new Box("2", "Research & Development", "1", 1));
            boxes.Add(new Box("3", "Customer Support", "1", 1));
            boxes.Add(new Box("4", "Sales", "1", 1));
            boxes.Add(new Box("5", "Marketing", "1", 1));
            boxes.Add(new Box("6", "Accounting", "1", 1));

            boxes[1].Type = BoxTypes.Manager;
            boxes[1].ForeColor = Colors.Red;

            boxes[2].BackColor = System.Drawing.Color.LightGreen;

            boxes.Add(new Box("9", "Project Management", "2", 2));
            boxes.Add(new Box("10", "Quality Assurance", "2", 2));
            boxes.Add(new Box("11", "System Analyst", "2", 2));
            boxes.Add(new Box("12", "Development", "2", 2));

            Ids.OrganogramDesigner.Designer designer = new Designer();
            designer.Boxes = boxes;

            designer.GenerateDiagram();
        }
    }
}
