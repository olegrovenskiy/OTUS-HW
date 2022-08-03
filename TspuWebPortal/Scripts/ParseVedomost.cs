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

    //Добавил флаг новой таблицы деталей
    public static List<FullVedomostData> GetAllVedomostRecords(string VedomostPath, bool IsNewTable)
    {
        string _ExcelFile;
        _ExcelFile = VedomostPath;

        // Открываем файл со считанным именем.
        Excel.Application xlApp = new Excel.Application();
        Excel.Workbook xlWorkbook = xlApp.Workbooks.Open(VedomostPath);
        Excel.Worksheet xlWorksheet = (Excel.Worksheet)xlWorkbook.Worksheets.get_Item(1);
        Excel.Range xlRange = xlWorksheet.UsedRange;
        List<FullVedomostData> ListAllRecords = new List<FullVedomostData>();
        //Console.WriteLine($"Строк: {xlRange.Rows.Count}");

        for (int intCurrentRow = 2; intCurrentRow <= xlRange.Rows.Count; intCurrentRow++)
        {
           
            ListAllRecords.Add(new FullVedomostData { 
                SerialNumber = ((Excel.Range)xlWorksheet.Cells[intCurrentRow, 1]).Value,
                ItemNumber = IsNewTable ? "нет" : Convert.ToString(((Excel.Range)xlWorksheet.Cells[intCurrentRow, 2]).Value),
                FullDetailName = IsNewTable ? Convert.ToString(((Excel.Range)xlWorksheet.Cells[intCurrentRow, 2]).Value) : Convert.ToString(((Excel.Range)xlWorksheet.Cells[intCurrentRow, 3]).Value),
                FactoryNumber = IsNewTable ? "нет" : Convert.ToString(((Excel.Range)xlWorksheet.Cells[intCurrentRow, 4]).Value),
                AsbiHostname = IsNewTable ? "не назначено" : Convert.ToString(((Excel.Range)xlWorksheet.Cells[intCurrentRow, 5]).Value),
                InventoryNumber = IsNewTable ? "не назначено" : Convert.ToString(((Excel.Range)xlWorksheet.Cells[intCurrentRow, 6]).Value),
                Comments = IsNewTable ? "не назначено" : Convert.ToString(((Excel.Range)xlWorksheet.Cells[intCurrentRow, 7]).Value),
                Rack = IsNewTable ? "не назначено" : Convert.ToString(((Excel.Range)xlWorksheet.Cells[intCurrentRow, 8]).Value),
                Place = IsNewTable ? "не назначено" : Convert.ToString(((Excel.Range)xlWorksheet.Cells[intCurrentRow, 9]).Value),
                Quantity = IsNewTable ? 1 : Convert.ToInt32(((Excel.Range)xlWorksheet.Cells[intCurrentRow, 10]).Value),
                DefinitionType = IsNewTable ? "не назначено" : Convert.ToString(((Excel.Range)xlWorksheet.Cells[intCurrentRow, 11]).Value),
                Year = IsNewTable ? 0 : Convert.ToInt32(((Excel.Range)xlWorksheet.Cells[intCurrentRow, 12]).Value),
                DataCenter = IsNewTable ? Convert.ToString(((Excel.Range)xlWorksheet.Cells[intCurrentRow, 3]).Value) : Convert.ToString(((Excel.Range)xlWorksheet.Cells[intCurrentRow, 13]).Value),
                RoomName = IsNewTable ? "не назначено" : Convert.ToString(((Excel.Range) xlWorksheet.Cells[intCurrentRow, 14]).Value),
                RowName = IsNewTable ? "не назначено" : Convert.ToString(((Excel.Range)xlWorksheet.Cells[intCurrentRow, 15]).Value),
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

        xlWorksheet.get_Range("a1", "s1").Interior.Color = System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.LightYellow);
        xlWorksheet.get_Range("a1", "q3000").NumberFormat = "@";
        string RackNumber = "";

        xlWorksheet.Cells[1, 1] = "Серийный номер";
        xlWorksheet.Cells[1, 2] = "№ п/п";
        xlWorksheet.Cells[1, 3] = "Категория детали";
        xlWorksheet.Cells[1, 4] = "Описание";
        xlWorksheet.Cells[1, 5] = "Маркировка производителя";
        xlWorksheet.Cells[1, 6] = "Маркировка АСБИ";
        xlWorksheet.Cells[1, 7] = "Инвентарный номер";
        xlWorksheet.Cells[1, 8] = "Метод определения SN";
        xlWorksheet.Cells[1, 9] = "Расположение вложенной детали";
        xlWorksheet.Cells[1, 10] = "Нижний юнит";
        xlWorksheet.Cells[1, 11] = "Высота шасси";
        xlWorksheet.Cells[1, 12] = "Стойка";
        xlWorksheet.Cells[1, 13] = "Ряд";
        xlWorksheet.Cells[1, 14] = "Помещение";
        xlWorksheet.Cells[1, 15] = "ЦОД";
        xlWorksheet.Cells[1, 16] = "Год поставки";
        xlWorksheet.Cells[1, 17] = "Коментарии";
        xlWorksheet.Cells[1, 18] = "Учёт количества";
        xlWorksheet.Cells[1, 19] = "Исключить из РД";

        int intCurrentRow = 1;
        int CurrentChassisItem = 0;
        int CurrentDetailItem = 0;

        foreach (OuterChassisData CurrentChassis in OutputList)
        {
            intCurrentRow++;

            if (CurrentChassis.Rack != RackNumber)
            {
                RackNumber = CurrentChassis.Rack;
                xlWorksheet.Range[xlWorksheet.Cells[intCurrentRow, 1], xlWorksheet.Cells[intCurrentRow, 19]].Interior.Color = System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.Cyan);
                xlWorksheet.Cells[intCurrentRow, 1] = $"Стойка № {RackNumber}";
                intCurrentRow++;
                CurrentDetailItem = 0;
                //CurrentChassisItem = 0;
            }


            CurrentChassisItem++;

            xlWorksheet.Cells[intCurrentRow, 1] = CurrentChassis.SerialNumber;
            xlWorksheet.Cells[intCurrentRow, 2] = CurrentChassisItem;
            xlWorksheet.Cells[intCurrentRow, 3] = CurrentChassis.Type;
            xlWorksheet.Cells[intCurrentRow, 4] = CurrentChassis.Description;
            xlWorksheet.Cells[intCurrentRow, 5] = CurrentChassis.FactoryNumber;
            xlWorksheet.Cells[intCurrentRow, 6] = CurrentChassis.Hostname;
            xlWorksheet.Cells[intCurrentRow, 7] = CurrentChassis.InventoryNumber;
            xlWorksheet.Cells[intCurrentRow, 8] = CurrentChassis.DefinitionType;

            xlWorksheet.Cells[intCurrentRow, 10] = CurrentChassis.IsOnFront ? CurrentChassis.LowerUnit : $"{CurrentChassis.LowerUnit} (тыл)";
            xlWorksheet.Cells[intCurrentRow, 11] = CurrentChassis.ChassisHeight;
            xlWorksheet.Cells[intCurrentRow, 12] = CurrentChassis.Rack;
            xlWorksheet.Cells[intCurrentRow, 13] = CurrentChassis.RowName;
            xlWorksheet.Cells[intCurrentRow, 14] = CurrentChassis.RoomName;
            xlWorksheet.Cells[intCurrentRow, 15] = CurrentChassis.DataCenter;
            xlWorksheet.Cells[intCurrentRow, 16] = CurrentChassis.Year;
            xlWorksheet.Cells[intCurrentRow, 17] = CurrentChassis.Comments;
            xlWorksheet.Cells[intCurrentRow, 18] = 1;
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
                    xlWorksheet.Cells[intCurrentRow, 9] = CurrentDetailInChassis.PositionInUpperEntity;
                    xlWorksheet.Cells[intCurrentRow, 16] = CurrentDetailInChassis.Year;
                    xlWorksheet.Cells[intCurrentRow, 17] = CurrentDetailInChassis.Comments;
                    xlWorksheet.Cells[intCurrentRow, 18] = CurrentDetailInChassis.QuantityCount;
                    xlWorksheet.Cells[intCurrentRow, 19] = CurrentDetailInChassis.IsExcludedFromPrint ? "да" : "";

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

    //List<AllDevicesInDatacenter>


    //~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~

    public static void GenerateVedomost(List<AllDevicesInDatacenter> InputList, string FilePath)
    {
        Excel.Application xlApp = new Excel.Application();
        Excel.Workbook xlWorkbook = xlApp.Workbooks.Add(Type.Missing);
        Excel.Worksheet xlWorksheet;


        int intCurrentRow = 1;
        int CurrentChassisItem = 0;
        int CurrentDetailItem = 0;

        int CurrentSheet = 0;

        List<OuterChassisData> outerChassisInRack = new List<OuterChassisData>();
        //string DataCenterName;
        string RackNumber = "";




        foreach (AllDevicesInDatacenter CurrentDataDenterDevices in InputList)
        {
            RackNumber = "";
            CurrentChassisItem = 0;
            //DataCenterName = CurrentDataDenterDevices.DataCenterName;
            CurrentSheet++;

            if (CurrentSheet == 1)
            {
                xlWorksheet = (Excel.Worksheet)xlWorkbook.Worksheets.get_Item(1);
            }
            else
            {
                xlWorksheet = (Excel.Worksheet)xlWorkbook.Worksheets.Add();     //new Excel.Worksheet() { }
            }
            xlWorksheet.Name = CurrentDataDenterDevices.DataCenterName;


            xlWorksheet.get_Range("a1", "s1").Interior.Color = System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.LightYellow);
            xlWorksheet.get_Range("a1", "q3000").NumberFormat = "@";


            xlWorksheet.Cells[1, 1] = "Серийный номер";
            xlWorksheet.Cells[1, 2] = "№ п/п";
            xlWorksheet.Cells[1, 3] = "Категория детали";
            xlWorksheet.Cells[1, 4] = "Описание";
            xlWorksheet.Cells[1, 5] = "Маркировка производителя";
            xlWorksheet.Cells[1, 6] = "Маркировка АСБИ";
            xlWorksheet.Cells[1, 7] = "Инвентарный номер";
            xlWorksheet.Cells[1, 8] = "Метод определения SN";
            xlWorksheet.Cells[1, 9] = "Расположение вложенной детали";
            xlWorksheet.Cells[1, 10] = "Нижний юнит";
            xlWorksheet.Cells[1, 11] = "Высота шасси";
            xlWorksheet.Cells[1, 12] = "Стойка";
            xlWorksheet.Cells[1, 13] = "Ряд";
            xlWorksheet.Cells[1, 14] = "Помещение";
            xlWorksheet.Cells[1, 15] = "ЦОД";
            xlWorksheet.Cells[1, 16] = "Год поставки";
            xlWorksheet.Cells[1, 17] = "Коментарии";
            xlWorksheet.Cells[1, 18] = "Учёт количества";
            xlWorksheet.Cells[1, 19] = "Исключить из РД";

            intCurrentRow = 1;
            foreach (OuterChassisData CurrentChassis in CurrentDataDenterDevices.FullSingleRackData)
            {
                intCurrentRow++;

                if (CurrentChassis.Rack != RackNumber)
                {
                    RackNumber = CurrentChassis.Rack;
                    xlWorksheet.Range[xlWorksheet.Cells[intCurrentRow, 1], xlWorksheet.Cells[intCurrentRow, 19]].Interior.Color = System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.Cyan);
                    xlWorksheet.Cells[intCurrentRow, 1] = $"Стойка № {RackNumber}";
                    intCurrentRow++;
                    CurrentDetailItem = 0;
                    //CurrentChassisItem = 0;
                }


                CurrentChassisItem++;

                xlWorksheet.Cells[intCurrentRow, 1] = CurrentChassis.SerialNumber;
                xlWorksheet.Cells[intCurrentRow, 2] = CurrentChassisItem;
                xlWorksheet.Cells[intCurrentRow, 3] = CurrentChassis.Type;
                xlWorksheet.Cells[intCurrentRow, 4] = CurrentChassis.Description;
                xlWorksheet.Cells[intCurrentRow, 5] = CurrentChassis.FactoryNumber;
                xlWorksheet.Cells[intCurrentRow, 6] = CurrentChassis.Hostname;
                xlWorksheet.Cells[intCurrentRow, 7] = CurrentChassis.InventoryNumber;
                xlWorksheet.Cells[intCurrentRow, 8] = CurrentChassis.DefinitionType;

                xlWorksheet.Cells[intCurrentRow, 10] = CurrentChassis.IsOnFront ? CurrentChassis.LowerUnit : $"{CurrentChassis.LowerUnit} (тыл)";
                xlWorksheet.Cells[intCurrentRow, 11] = CurrentChassis.ChassisHeight;
                xlWorksheet.Cells[intCurrentRow, 12] = CurrentChassis.Rack;
                xlWorksheet.Cells[intCurrentRow, 13] = CurrentChassis.RowName;
                xlWorksheet.Cells[intCurrentRow, 14] = CurrentChassis.RoomName;
                xlWorksheet.Cells[intCurrentRow, 15] = CurrentChassis.DataCenter;
                xlWorksheet.Cells[intCurrentRow, 16] = CurrentChassis.Year;
                xlWorksheet.Cells[intCurrentRow, 17] = CurrentChassis.Comments;
                xlWorksheet.Cells[intCurrentRow, 18] = 1;
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
                        xlWorksheet.Cells[intCurrentRow, 9] = CurrentDetailInChassis.PositionInUpperEntity;
                        xlWorksheet.Cells[intCurrentRow, 16] = CurrentDetailInChassis.Year;
                        xlWorksheet.Cells[intCurrentRow, 17] = CurrentDetailInChassis.Comments;
                        xlWorksheet.Cells[intCurrentRow, 18] = CurrentDetailInChassis.QuantityCount;
                        xlWorksheet.Cells[intCurrentRow, 19] = CurrentDetailInChassis.IsExcludedFromPrint ? "да" : "";

                    }
                }
            }


            xlWorksheet.UsedRange.Borders.LineStyle = Excel.XlLineStyle.xlContinuous;
            xlWorksheet.UsedRange.Borders.Weight = 2;
            xlWorksheet.UsedRange.Columns.AutoFit();
        }


       

        xlWorkbook.SaveAs(FilePath);
        xlWorkbook.Close();
        xlApp.Quit();
        return;
    }


    //ParseVedomost.GenerateFullVedomost(AllRacksForVedomost, FilePath);



}



