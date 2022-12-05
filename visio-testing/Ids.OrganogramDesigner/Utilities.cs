// Utilities.cs
// compile with: /doc:Utilities.xml
// <copyright>Copyright (c) Microsoft Corporation. All rights reserved.
// </copyright>
// <summary>This file contains the implementation of Utilities class.</summary>

using System;
using System.Diagnostics;
using System.Reflection;
using System.Resources;
using System.Runtime.InteropServices;
using Microsoft.Office.Interop.Visio;
using Microsoft.Win32;

namespace Ids.OrganogramDesigner
{
		  
	/// <summary>This class provides all the constants and methods that are
	/// shared among the classes in the project.</summary>
	[ComVisible(false)]
	public sealed class Utilities {

		/// <summary>Comma character is employed as the separator because
		/// Universal functions (i.e. FormulaU) are being used.</summary>
        public const string Separator = ",";

		/// <summary>Minimum version of Visio supported -Office 2003
		/// </summary>
		public const short MinVisioVersion = 11;

		/// <summary>Column in Excel worksheets containing the step ID
		/// </summary>
		public const short ExcelColumnStepId = 1;

		/// <summary>Column in Excel worksheets containing the task name
		/// </summary>
		public const short ExcelColumnTask = 2;
		
		/// <summary>Column in Excel worksheets containing the next steps
		/// </summary>
		public const short ExcelColumnNextSteps = 3;

		/// <summary>Column in Excel worksheets containing the owner name
		/// </summary>
		public const short ExcelColumnOwner = 4;

		/// <summary>Column in Excel worksheets containing the step type
		/// </summary>
		public const short ExcelColumnStepType = 5;

		/// <summary>Column in Excel worksheets containing the duration
		/// </summary>
		public const short ExcelColumnDuration = 6;

		/// <summary>Column in Excel worksheets containing the comments
		/// </summary>
		public const short ExcelColumnComments = 7;

		/// <summary>Column in Excel worksheets containing the hyperlink
		/// address</summary>
		public const short ExcelColumnHyperlink = 8;

		/// <summary>Column in Excel worksheets containing the hyperlink
		/// description</summary>
		public const short ExcelColumnHyperlinkDescription = 9;

		/// <summary>The first row in the Sample Excel Spreadsheet that has 
		/// data</summary>
        public const short ExcelRowStart = 2;

		/// <summary>Name of the flowchart stencil this addin uses</summary>
		public const string FlowchartStencil = 
			"Basic Flowchart Shapes (US units).vss";

		/// <summary>Name of the Backgrounds stencil</summary>
		public const string BackgroundsStencil = 
			"Backgrounds (US units).vss";

		/// <summary>Name of the Borders and Titles stencil</summary>
		public const string BordersAndTitlesStencil = 
			"Borders and Titles (US units).vss";

		/// <summary>Name of the HTML file that is generated</summary>
		public const string HtmlFileName = "SampleFlowchart.html";

		/// <summary>Name of the Excel file that is used</summary>
		public const string ExcelFileName = "Flowchart.xls";

		/// <summary>Background master that is used</summary>
		public const string BackgroundMaster = "Background cosmic";

		/// <summary>Title master that is used</summary>
		public const string TitleMaster = "Title Block Elegant";

		/// <summary>Command ID representing a document created event. Used
		/// by marker event context strings.</summary>
        public const short DocumentCreateCommandId = 1;

		/// <summary>Command ID representing a document opened event. Used
		/// by marker event context strings.</summary>
		public const short DocumentOpenCommandId = 2;

		/// <summary>Command ID representing a shape RMA event. Used
		/// by marker event context strings.</summary>
		public const short ShapeRmaConnectsCommandId = 100;

		/// <summary>SDK Flowchart Application Format used in the Marker 
		/// event context string.</summary>
        public const string ContextSdkFlowchart = "SDKFLW_C#NET";

		/// <summary>Begin marker format used in the marker event context 
		/// string.</summary>
        public const string ContextBeginMarker = "/";

		/// <summary>Document format used in the marker event Context 
		/// string</summary>
		public const string ContextDocument = "DOC=";

		/// <summary>Event format used in the marker event context string
		/// </summary>
		public const string ContextEvent = "EVENT=";

		/// <summary>Page format used in the marker event Context string
		/// </summary>
		public const string ContextPage = "PAGE=";

		/// <summary>Shape format used in the marker event Context string
		/// </summary>
		public const string ContextShape = "SHAPE=";

		/// <summary>Solution format used in the marker event context string
		/// </summary>
		public const string ContextSolution = "SOLUTION=";

		/// <summary>Formula of the right menu action item</summary>
        public const string RmaMenuFormula =
			"RUNADDONWARGS(\"QueueMarkerEvent\"" + Separator + "\"" + 
			ContextSolution + ContextSdkFlowchart + " " 
            + ContextBeginMarker + ContextEvent + "100\")";

		/// <summary>Extension for binary Visio template files
		/// </summary>
        public const string TemplateExtensionVst = "VST";

		/// <summary>Extension for XML-based Visio template files
		/// </summary>
		public const string TemplateExtensionVtx = "VTX";

		/// <summary>Create a global resource manager for the application
		/// to retrieve localized strings.</summary>
		private static ResourceManager theResourceManager = 
			new ResourceManager("Strings",
			System.Reflection.Assembly.GetExecutingAssembly());

		/// <summary>Array of step types found in the sample Excel 
		/// spreadsheet and their corresponding Visio masters</summary>
		private static readonly string[,] stepShapes = {
			 { "PROCESS", "Process" },
			 { "DECISION", "Decision" },
			 { "END", "Terminator" }
		};

		/// <summary>Array of owners found in the sample Excel spreadsheet
		/// and their corresponding colors</summary>
		private static readonly string[,] ownerColor = {
			{ LoadString("OwnerAmyLead"), "RGB(204, 255, 153)" },
			{ LoadString("OwnerJohnMarketer"), "RGB(149, 203, 221)" },
			{ LoadString("OwnerSarahPlanner"), "RGB(171, 170, 225)" }
		};

		/// <summary>Lists the fields in the ownerColor lookup table.
		/// </summary>
		public enum OwnerColorField {

			/// <summary>Index for the Owner field</summary>
			OwnerColorOwner = 0,

			/// <summary>Index for the Color field</summary>
			OwnerColorColor = 1
		}

		/// <summary>This constructor intentionally left blank.</summary>
		private Utilities() {

			// No initialization
		}

		/// <summary>This method displays a message box containing an error
		/// if the alertResponse value is zero.</summary>
		/// <param name="alertResponse">AlertResponse value of the running
		/// Visio instance</param>
		/// <param name="exceptionMessage">Error message to be displayed
		/// </param>
		public static void DisplayException(
			int alertResponse, 
			string exceptionMessage) {

			string title;

			title = LoadString("AddInName");

            // Check AlertResponse to see whether we should display
            // modal UI. 
 			
            Debug.WriteLine(exceptionMessage);
		}

		/// <summary>This method gets the Flowchart Sample's path from the 
		/// fully qualified add-in name.</summary>
		/// <returns>Flowchart Sample path with an ending backslash (\)
		/// </returns>
		public static string FlowchartSamplePathFromAddin {

			get {
				string path = "";
				System.Reflection.Module sampleAddIn;

				sampleAddIn = Assembly.GetExecutingAssembly().GetModules()[0];
				path = sampleAddIn.FullyQualifiedName;
				path = path.Substring(0, path.LastIndexOf("\\")+1);

				return path;
			}
		}

		/// <summary>This method gets the Flowchart Sample's path from the 
		/// registry.</summary>
		/// <returns>Flowchart Sample path with an ending backslash (\)
		/// </returns>
        public static string FlowchartSamplePathFromRegistry
        {

            get
            {
                string path = "";

                RegistryKey regKey = Registry.LocalMachine.OpenSubKey(
                    "SOFTWARE\\Microsoft\\Office\\12.0\\Visio");
                path = (string)regKey.GetValue("SDKPath");

                path = path + "Samples\\Flowchart\\CSharp\\";
                return path;
            }
        }

		/// <summary>This method gets the document from the documents 
		/// collection.</summary>
		/// <param name="theDocuments">Document collection from which
		/// the document is to be found</param>
		/// <param name="documentName">Name of the document to be found
		/// </param>
		/// <returns>Document object if found; otherwise null</returns>
		[CLSCompliant(false)]
		public static Document GetDocumentItem(
			Documents theDocuments,
			string documentName) {

			Document currentDocument;

			if (documentName == null || theDocuments == null) {
				return null;
			}
			try {
				currentDocument = theDocuments[documentName];
			}
			catch (COMException) {
				// Document was not found. Ignore the error.
				currentDocument = null;
			}

			return currentDocument;
		}

		/// <summary>This method finds the master specified by masterNameU.
		/// </summary>
		/// <param name="currentDocument">Document object from which the
		/// master is to be found</param>
		/// <param name="masterNameU">Name of the master to be found</param>
		/// <returns>Master object if found; otherwise null</returns>
		[CLSCompliant(false)]
		public static Master GetMasterItem(
			Document currentDocument,
			string masterNameU) {

			if (currentDocument == null || masterNameU == null) {
				return null;
			}

			Master currentMaster;

			// Get a master on the stencil by its universal name.
			try {
				if (currentDocument.Masters == null)
				{
					throw new COMException("NoMasters");
				}
				currentMaster = currentDocument.Masters.get_ItemU(masterNameU);
			}
			catch (COMException) {
				// Master was not found. Ignore the error.
				currentMaster = null;
			}

			return currentMaster;
		}

		/// <summary>Accessor for the ownerColor field.</summary>
		/// <param name="index">Index to find the corresponding 
		/// value for</param>
		/// <param name="field">What to return: Owner or Color</param>
		/// <returns>Owner or Color, depending on field param</returns>
		public static string GetOwnerColor(
			int index, 
			OwnerColorField field) {

			return ownerColor[index, (int)field];
		}

		/// <summary>This method finds the requested shape in the shapes 
		/// collection passed in.</summary>
		/// <param name="shapesInPage">Shapes collection</param>
		/// <param name="id">ID of the shape to be found</param>
		/// <returns>Shape object if found; otherwise null</returns>
		[CLSCompliant(false)]
		public static Shape GetShapeItem(
			Shapes shapesInPage, 
			object id) {

			Shape currentShape;

			if ( shapesInPage == null ) {
				return null;
			}

			try {
				currentShape = shapesInPage[id];
			}
			catch (COMException) {
				// Shape was not found. Ignore the error.
				currentShape = null;
			}

			return currentShape;
		}

		/// <summary>This method finds the stencil in the Documents 
		/// collection. If the stencil is not found, this method loads it 
		/// by calling the OpenEx method of the Documents collection.
		/// </summary>
		/// <param name="applicationDocuments">Documents collection</param>
		/// <param name="stencilName">Name of the stencil</param>
		/// <returns>Document object that corresponds to the stencil name
		/// or nothing if the stencil cannot be found</returns>
		[CLSCompliant(false)]
		public static Document GetStencil(
			Documents applicationDocuments,
			string stencilName) {

			Document stencil = null;

			if (applicationDocuments == null || applicationDocuments.Application == null) {
				return null;
			}

			try {

				stencil = GetDocumentItem(applicationDocuments, stencilName);

				// The stencil is not loaded, so load it.
				if (stencil == null) {
					stencil = applicationDocuments.OpenEx(stencilName,
						(short)(short)VisOpenSaveArgs.visOpenRO
						+ (short)VisOpenSaveArgs.visOpenDocked);
				}
			}
			catch (COMException) {
				string error = "Stencil not found: \r\n" + stencilName;
				DisplayException(
					applicationDocuments.Application.AlertResponse,
					error);
			}

			return stencil;
		}

		/// <summary>Accessor for the stepShapes field.</summary>
		/// <param name="index">Step type index to find the corresponding 
		/// shape for</param>
		/// <returns>Shape type</returns>
		public static string GetStepShapes(int index) {
			
			return stepShapes[index, 1];
		}

		/// <summary>Accessor for the types in the stepShapes field.</summary>
		/// <param name="index">Step type index to find the corresponding 
		/// type for</param>
		/// <returns>Step type</returns>
		public static string GetStepTypes(int index) {
			
			return stepShapes[index, 0];
		}

		/// <summary>This method loads a string from the embedded resource.
		/// </summary>
		/// <param name="resourceName">Name of the resource to be loaded
		/// </param>
		/// <returns>Loaded resource string if successful, otherwise empty
		/// string</returns>
		public static string LoadString(string resourceName) {

			return "Test";
		}

		/// <summary>Returns the size of the ownerColor lookup table.
		/// </summary>
		public static int OwnerColorCount {
			get {
				return ownerColor.GetLength(0);
			}
		}

		/// <summary>Returns the size of the stepShapes lookup table.
		/// </summary>
		public static int StepShapeCount {
			get {
				return stepShapes.GetLength(0);
			}
		}

        public static Microsoft.Office.Interop.Visio.VisDefaultColors GetVisioColor(Colors color)
        {
            switch (color)
            {
                case Colors.Black: return VisDefaultColors.visBlack;
                case Colors.Blue: return VisDefaultColors.visBlue;
                case Colors.DarkBlue: return VisDefaultColors.visDarkBlue;
                case Colors.DarkCyan: return VisDefaultColors.visDarkCyan;
                case Colors.DarkGray: return VisDefaultColors.visDarkGray;
                case Colors.DarkGreen: return VisDefaultColors.visDarkGreen;
                case Colors.DarkRed: return VisDefaultColors.visDarkRed;
                case Colors.DarkYellow: return VisDefaultColors.visYellow;
                case Colors.Gray: return VisDefaultColors.visGray;
                case Colors.Green: return VisDefaultColors.visGreen;
                case Colors.Magenta: return VisDefaultColors.visMagenta;
                case Colors.Purple: return VisDefaultColors.visPurple;
                case Colors.Red: return VisDefaultColors.visRed;
                case Colors.Transparent: return VisDefaultColors.visTransparent;
                case Colors.White: return VisDefaultColors.visWhite;
                case Colors.Yellow: return VisDefaultColors.visYellow;
            }

            return VisDefaultColors.visTransparent;
        }

		/// <summary>This method converts the input string to a Formula for a
		/// string by replacing each double quotation mark (") with a pair of
		/// double quotation marks ("") and adding double quotation marks 
		/// ("") around the entire string. When this formula is assigned to 
		/// the formula property of a Visio cell it will produce a result 
		/// value equal to the string, input.</summary>
		/// <param name="input">Input string that will be processed
		/// </param>
		/// <returns>Formula for input string</returns>
		public static string StringToFormulaForString(string input) {

			const string quote = "\"";
			string  result = "";

			if (input == null) {
				return null;
			}

			// Replace all (") with ("").
			result = input.Replace(quote,
				(quote + quote));

			// Add ("") around the entire string.
			result = quote + result + quote;

			return result;
		}
	}
}
