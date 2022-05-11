using TspuWebPortal.Model;
using Excel = Microsoft.Office.Interop.Excel;
namespace TspuWebPortal.Scripts;

public class ParseVedomost
{
    /*
    public VedomostData GetFirstRecord(string ExcelVedomost)
    {
        string _ExcelFile;
        _ExcelFile = ExcelVedomost;

    }
    */


    public static List<VedomostData> GetAllRecords(string VedomostPath)
    {
        string _ExcelFile;
        _ExcelFile = VedomostPath;

        // Открываем файл со считанным именем.
        Excel.Application xlApp = new Excel.Application();
        Excel.Workbook xlWorkbook = xlApp.Workbooks.Open(VedomostPath);
        Excel.Worksheet xlWorksheet = (Excel.Worksheet)xlWorkbook.Worksheets.get_Item(1);
        Excel.Range xlRange = xlWorksheet.UsedRange;
        List<VedomostData> ListAllRecords = new List<VedomostData>();
        //Console.WriteLine($"Строк: {xlRange.Rows.Count}");
        for (int intCurrentRow = 2; intCurrentRow <= xlRange.Rows.Count; intCurrentRow++)
        {
            ListAllRecords.Add(new VedomostData { 
                SerialNumber = ((Excel.Range)xlWorksheet.Cells[intCurrentRow, 1]).Value,
                ItemNumber = Convert.ToString(((Excel.Range)xlWorksheet.Cells[intCurrentRow, 2]).Value),
                Description = Convert.ToString(((Excel.Range)xlWorksheet.Cells[intCurrentRow, 3]).Value),
                Type = Convert.ToString(((Excel.Range)xlWorksheet.Cells[intCurrentRow, 4]).Value),
                FactoryNumber = Convert.ToString(((Excel.Range)xlWorksheet.Cells[intCurrentRow, 5]).Value),
                InventoryNumber = Convert.ToString(((Excel.Range)xlWorksheet.Cells[intCurrentRow, 6]).Value),
                Comments = Convert.ToString(((Excel.Range)xlWorksheet.Cells[intCurrentRow, 7]).Value),
                Rack = Convert.ToString(((Excel.Range)xlWorksheet.Cells[intCurrentRow, 8]).Value),
                Place = Convert.ToString(((Excel.Range)xlWorksheet.Cells[intCurrentRow, 9]).Value),
                Quantity = Convert.ToInt32(((Excel.Range)xlWorksheet.Cells[intCurrentRow, 10]).Value),
                DefinitionType = Convert.ToString(((Excel.Range)xlWorksheet.Cells[intCurrentRow, 11]).Value),
                Year = Convert.ToInt32(((Excel.Range)xlWorksheet.Cells[intCurrentRow, 12]).Value),
                DataCenter = Convert.ToString(((Excel.Range)xlWorksheet.Cells[intCurrentRow, 13]).Value),
                RoomName = Convert.ToString(((Excel.Range) xlWorksheet.Cells[intCurrentRow, 14]).Value),
                RowName = Convert.ToString(((Excel.Range)xlWorksheet.Cells[intCurrentRow, 15]).Value),
            });
        }

        // Закрываем эксель с шаблоном
        xlWorkbook.Close();
        xlApp.Quit();
        return ListAllRecords;
    }
}



