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
                FullDetailName = Convert.ToString(((Excel.Range)xlWorksheet.Cells[intCurrentRow, 3]).Value),
                FactoryNumber = Convert.ToString(((Excel.Range)xlWorksheet.Cells[intCurrentRow, 4]).Value),
                AsbiHostname = Convert.ToString(((Excel.Range)xlWorksheet.Cells[intCurrentRow, 5]).Value),
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

        xlWorksheet.get_Range("a1", "p1").Interior.Color = System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.LightYellow);
        xlWorksheet.get_Range("a1", "p1000").NumberFormat = "@";

        xlWorksheet.Cells[1, 1] = "Серийный номер";
        xlWorksheet.Cells[1, 2] = "№ п/п";
        xlWorksheet.Cells[1, 3] = "Категория детали";
        xlWorksheet.Cells[1, 4] = "Описание";
        xlWorksheet.Cells[1, 5] = "Маркировка производителя";
        xlWorksheet.Cells[1, 6] = "Маркировка АСБИ";
        xlWorksheet.Cells[1, 7] = "Инвентарный номер";
        xlWorksheet.Cells[1, 8] = "Метод определения SN";
        xlWorksheet.Cells[1, 9] = "Нижний юнит";
        xlWorksheet.Cells[1, 10] = "Высота шасси";
        xlWorksheet.Cells[1, 11] = "Стойка";
        xlWorksheet.Cells[1, 12] = "Ряд";
        xlWorksheet.Cells[1, 13] = "Помещение";
        xlWorksheet.Cells[1, 14] = "ЦОД";
        xlWorksheet.Cells[1, 15] = "Год поставки";
        xlWorksheet.Cells[1, 16] = "Коментарии";

        int intCurrentRow = 1;
        int CurrentChassisItem = 0;
        int CurrentDetailItem = 0;

        foreach (OuterChassisData CurrentChassis in OutputList)
        {
            intCurrentRow++;
            CurrentChassisItem++;
            xlWorksheet.Cells[intCurrentRow, 1] = CurrentChassis.SerialNumber;
            xlWorksheet.Cells[intCurrentRow, 2] = CurrentChassisItem;
            xlWorksheet.Cells[intCurrentRow, 3] = CurrentChassis.Type;
            xlWorksheet.Cells[intCurrentRow, 4] = CurrentChassis.Description;
            xlWorksheet.Cells[intCurrentRow, 5] = CurrentChassis.FactoryNumber;
            xlWorksheet.Cells[intCurrentRow, 6] = CurrentChassis.Hostname;
            xlWorksheet.Cells[intCurrentRow, 7] = CurrentChassis.InventoryNumber;
            xlWorksheet.Cells[intCurrentRow, 8] = CurrentChassis.DefinitionType;
            xlWorksheet.Cells[intCurrentRow, 9] = CurrentChassis.LowerUnit;
            xlWorksheet.Cells[intCurrentRow, 10] = CurrentChassis.ChassisHeight;
            xlWorksheet.Cells[intCurrentRow, 11] = CurrentChassis.Rack;
            xlWorksheet.Cells[intCurrentRow, 12] = CurrentChassis.RowName;
            xlWorksheet.Cells[intCurrentRow, 13] = CurrentChassis.RoomName;
            xlWorksheet.Cells[intCurrentRow, 14] = CurrentChassis.DataCenter;
            xlWorksheet.Cells[intCurrentRow, 15] = CurrentChassis.Year;
            xlWorksheet.Cells[intCurrentRow, 16] = CurrentChassis.Comments;
            if (CurrentChassis?.InnerChassisDataList?.Count > 0)
            {
                CurrentDetailItem = 0;
                foreach (InnerChassisData CurrentDetailInChassis in CurrentChassis.InnerChassisDataList)
                {
                    intCurrentRow++; 
                    CurrentDetailItem++;
                    xlWorksheet.Cells[intCurrentRow, 1] = CurrentDetailInChassis.SerialNumber;
                    xlWorksheet.Cells[intCurrentRow, 2] = $"{CurrentChassisItem}.{CurrentDetailItem}";
                    xlWorksheet.Cells[intCurrentRow, 3] = CurrentDetailInChassis.Type;
                    xlWorksheet.Cells[intCurrentRow, 4] = CurrentDetailInChassis.Description;
                    xlWorksheet.Cells[intCurrentRow, 5] = CurrentDetailInChassis.FactoryNumber;
                    //xlWorksheet.Cells[intCurrentRow, 7] = CurrentDetailInChassis.InventoryNumber;
                    //xlWorksheet.Cells[intCurrentRow, 8] = CurrentDetailInChassis.DefinitionType;
                    xlWorksheet.Cells[intCurrentRow, 15] = CurrentDetailInChassis.Year;
                    xlWorksheet.Cells[intCurrentRow, 16] = CurrentDetailInChassis.Comments;

                }
            }
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



