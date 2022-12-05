using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Office.Interop.Visio;

namespace Ids.OrganogramDesigner
{
    public class Designer
    {
        private string templatePath = @"C:\Program Files (x86)\Microsoft Office\Office12\1033\ORGCH_M.VST";
        public string VisioTemplatePath
        {
            get
            {
                return templatePath;
            }
            set
            {
                templatePath = value;
            }
        }

        private string saveFolder = @"d:\Projects\DrawVisio\";
        public string SaveFolder
        {
            get
            {
                return saveFolder;
            }
            set
            {
                saveFolder = value;
            }
        }

        private IList<Box> boxes;
        public IList<Box> Boxes
        {
            get
            {
                return boxes;
            }
            set
            {
                boxes = value;
            }
        }

        public string GenerateDiagram()
        {
            Microsoft.Office.Interop.Visio.Application application = new Microsoft.Office.Interop.Visio.Application();
            application.Visible = false;

            Microsoft.Office.Interop.Visio.Document doc = application.Documents.Add(templatePath);
            Microsoft.Office.Interop.Visio.Page page = application.Documents[1].Pages.Add();

            List<Box> rootBoxes = boxes.Where(x => x.Parent == null).OrderBy(x => x.DisplayOrder).ToList<Box>();

            double xPosition = page.PageSheet.get_CellsU("PageWidth").ResultIU / rootBoxes.Count + 1;

            foreach (Box box in rootBoxes)
            {
                double yPosition = page.PageSheet.get_CellsU("PageHeight").ResultIU - 1;

                Microsoft.Office.Interop.Visio.Master position = doc.Masters.get_ItemU(box.Type.ToString());
                Microsoft.Office.Interop.Visio.Shape shape = page.Drop(position, xPosition, yPosition - box.LevelNumber);

                SetShapeProperties(shape, box);

                drawBox(doc, page, box, xPosition, shape);
                xPosition += 1.5;
            }

            page.Layout();

            string fileName = saveFolder + Guid.NewGuid() + ".vsd";
            doc.SaveAs(fileName);

            doc.Close();
            application.Quit();

            return fileName;
        }

        private void drawBox(Document doc, Page page, Box parentBox, double xPosition, Shape shape)
        {
            double yPosition = page.PageSheet.get_CellsU("PageHeight").ResultIU - 1;

            List<Box> children = boxes.Where(x => x.Parent != null && x.Parent.Id == parentBox.Id).OrderBy(x => x.DisplayOrder).ToList<Box>();

            foreach (Box child in children)
            {
                xPosition += 1.5;

                Microsoft.Office.Interop.Visio.Master childPosition = doc.Masters.get_ItemU(child.Type.ToString());
                Microsoft.Office.Interop.Visio.Shape childShape = page.Drop(childPosition, xPosition, yPosition - child.LevelNumber);

                SetShapeProperties(childShape, child);
                
                connectWithDynamicGlueAndConnector(shape, childShape);

                drawBox(doc, page, child, xPosition, childShape);
            }
        }

        private void SetShapeProperties(Shape shape, Box box)
        {
            //set the text
            shape.Text = box.Name;

            //set hyperlink
            if (!String.IsNullOrEmpty(box.HyperLink.Trim()))
            {
                Hyperlink link = shape.Hyperlinks.Add();
                link.Address = box.HyperLink;
            }

            //set the shape width
            shape.get_CellsSRC(
                (short)Microsoft.Office.Interop.Visio.VisSectionIndices.
                visSectionObject,
                (short)Microsoft.Office.Interop.Visio.VisRowIndices.
                visRowXFormIn,
                (short)Microsoft.Office.Interop.Visio.VisCellIndices.
                visXFormWidth).ResultIU = box.Width;

            //set the shape height
            shape.get_CellsSRC(
               (short)Microsoft.Office.Interop.Visio.VisSectionIndices.
               visSectionObject,
               (short)Microsoft.Office.Interop.Visio.VisRowIndices.
               visRowXFormIn,
               (short)Microsoft.Office.Interop.Visio.VisCellIndices.
               visXFormHeight).ResultIU = box.Height;

            //set the shape fore color
            shape.Characters.set_CharProps(
                (short)Microsoft.Office.Interop.Visio.
                    VisCellIndices.visCharacterColor,
                (short)Utilities.GetVisioColor(box.ForeColor));

            //set the shape back color
            shape.get_CellsSRC((short)VisSectionIndices.visSectionObject,
                   (short)VisRowIndices.visRowFill, (short)VisCellIndices.visFillForegnd).FormulaU = "RGB(" + box.BackColor.R.ToString() + "," + box.BackColor.G.ToString() + "," + box.BackColor.B.ToString() + ")";
        }

        private void connectWithDynamicGlueAndConnector(
           Shape shapeFrom,
           Shape shapeTo)
        {

            Microsoft.Office.Interop.Visio.Cell beginXCell;
            Microsoft.Office.Interop.Visio.Cell endXCell;
            Microsoft.Office.Interop.Visio.Shape connector;

            // Add a Dynamic connector to the page.
            connector = dropMasterOnPage(
                (Page)shapeFrom.ContainingPage,
                "Dynamic Connector",
                Utilities.FlowchartStencil,
                0.0,
                0.0);

            // Connect the begin point.
            beginXCell = connector.get_CellsSRC(
                (short)VisSectionIndices.visSectionObject,
                (short)VisRowIndices.visRowXForm1D,
                (short)VisCellIndices.vis1DBeginX);

            beginXCell.GlueTo(shapeFrom.get_CellsSRC(
                (short)VisSectionIndices.visSectionObject,
                (short)VisRowIndices.visRowXFormOut,
                (short)VisCellIndices.visXFormPinX));

            // Connect the end point.
            endXCell = connector.get_CellsSRC(
                (short)VisSectionIndices.visSectionObject,
                (short)VisRowIndices.visRowXForm1D,
                (short)VisCellIndices.vis1DEndX);

            endXCell.GlueTo(shapeTo.get_CellsSRC(
                (short)VisSectionIndices.visSectionObject,
                (short)VisRowIndices.visRowXFormOut,
                (short)VisCellIndices.visXFormPinX));
        }

        private Shape dropMasterOnPage(
            Page dropOnPage,
            string masterNameU,
            string stencilName,
            double pinX,
            double pinY)
        {

            Documents applicationDocuments;
            Document stencil;
            Master masterToDrop;
            Shape returnShape = null;

            // Find the stencil in the Documents collection by name.
            applicationDocuments = dropOnPage.Application.Documents;
            stencil = Utilities.GetStencil(applicationDocuments,
                stencilName);

            // Get a master on the stencil by its universal name.
            masterToDrop = Utilities.GetMasterItem(stencil, masterNameU);

            // Drop the master on the page that is passed in. Set the
            // PinX and PinY using the data passed in parameters pinX
            // and pinY, respectively.
            returnShape = dropOnPage.Drop(masterToDrop, pinX, pinY);

            return returnShape;
        }
    }
}