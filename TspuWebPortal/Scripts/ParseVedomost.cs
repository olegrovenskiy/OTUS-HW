using TspuWebPortal.Model;
using Excel = Microsoft.Office.Interop.Excel;
using System.Collections;
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
            Console.WriteLine($"Строка: {intCurrentRow}");
        }

        // Закрываем эксель с шаблоном
        xlWorkbook.Close();
        xlApp.Quit();
        return ListAllRecords;
    }


    public static void GenerateVedomost(List<OuterChassisData> OutputList, string FilePath)
    {
        Excel.Application xlApp = new Excel.Application();
        Excel.Workbook xlWorkbook = xlApp.Workbooks.Add(Type.Missing);
        Excel.Worksheet xlWorksheet = (Excel.Worksheet)xlWorkbook.Worksheets.get_Item(1);

        xlWorksheet.get_Range("a1", "h1").Interior.Color = System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.LightSeaGreen);

        xlWorksheet.Cells[1, 1] = "Серийный номер";
        xlWorksheet.Cells[1, 2] = "Описание";
        xlWorksheet.Cells[1, 3] = "Нижний юнит";
        xlWorksheet.Cells[1, 4] = "Высота шасси";
        xlWorksheet.Cells[1, 5] = "Стойка";
        xlWorksheet.Cells[1, 6] = "Ряд";
        xlWorksheet.Cells[1, 7] = "Помещение";
        xlWorksheet.Cells[1, 8] = "ЦОД";

        int intCurrentRow = 1;
        foreach (OuterChassisData CurrentChassis in OutputList)
        {
            intCurrentRow++;
            xlWorksheet.Cells[intCurrentRow, 1] = CurrentChassis.SerialNumber;
            xlWorksheet.Cells[intCurrentRow, 2] = CurrentChassis.Description;
            xlWorksheet.Cells[intCurrentRow, 3] = CurrentChassis.LowerUnit;
            xlWorksheet.Cells[intCurrentRow, 4] = CurrentChassis.ChassisHeight;
            xlWorksheet.Cells[intCurrentRow, 5] = CurrentChassis.Rack;
            xlWorksheet.Cells[intCurrentRow, 6] = CurrentChassis.RowName;
            xlWorksheet.Cells[intCurrentRow, 7] = CurrentChassis.RoomName;
            xlWorksheet.Cells[intCurrentRow, 8] = CurrentChassis.DataCenter;
        }

        
        xlWorksheet.UsedRange.Borders.LineStyle = Excel.XlLineStyle.xlContinuous;
        xlWorksheet.UsedRange.Borders.Weight = 2;
        xlWorksheet.UsedRange.Columns.AutoFit();

        xlWorkbook.SaveAs(FilePath);
        xlWorkbook.Close();
        xlApp.Quit();
        return;
    }



}



