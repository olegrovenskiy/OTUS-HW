using Aspose.Diagram;


string dirPath = @"C:\Users\o.rovenskiy\Downloads\aspose\";

Aspose.Diagram.Diagram dg = new Diagram();

Page newPage = new Page();

Page newPage1 = new Page();


newPage.Name = "new page";

newPage1.Name = "new page1";

newPage.ID = 2;
newPage1.ID = 3;

dg.Pages.Add(newPage);
dg.Pages.Add(newPage1);



string datadir = @"C:\Users\o.rovenskiy\Desktop\обучение c#\aspose\Aspose.Diagram-for-.NET-master\Examples\Data\Working-Shapes\";

string masterName = "Rectangle";

dg.AddMaster(datadir + "Basic Shapes.vss", masterName);


double width = 2, height = 2, pinX = 4.25, pinY = 4.5;

long rectangleId = dg.AddShape(pinX, pinY, width, height, masterName, 2);





Shape rectangle = newPage1.Shapes.GetShape(rectangleId);



rectangle.XForm.PinX.Value = 5;
rectangle.XForm.PinY.Value = 5;
rectangle.Type = TypeValue.Shape;
rectangle.Text.Value.Add(new Txt("Aspose Diagram"));
rectangle.TextStyle = dg.StyleSheets[3];
rectangle.Line.LineColor.Value = "#ff0000";
rectangle.Line.LineWeight.Value = 0.03;
rectangle.Line.Rounding.Value = 0.1;
rectangle.Fill.FillBkgnd.Value = "#ff00ff";
rectangle.Fill.FillForegnd.Value = "#ebf8df";




dg.Save(dirPath + "OutputByAsposeDiagram.vsdx", SaveFileFormat.Vsdx);

