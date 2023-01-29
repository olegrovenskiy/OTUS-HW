
using ClosedXML.Excel;


string filepath = @"C:\Users\o.rovenskiy\source\repos\closedxml-test\tspu-cablesl.xlsx";
string address = "г. Рязань, ул. Горького, д. 94";

string[,] SegmentLan = new string[,] { { "1L", "ODF --- IS40 (1)\r\n10GBASE-LR", "ТШ ряд2, место 9 ODF №1", "№10 (duplex) 2xLC", "IS40 (1)", "Net 1/1/0", "", "", "", "", "PE1 Huawei S6330\r\nXG0/0/8" },
{"1L", "ODF --- IS40 (1)\r\n10GBASE-LR", "ТШ ряд2, место 9 ODF №1", "№10 (duplex) 2xLC", "IS40 (1)", "Net 1/1/0", "", "", "", "", "PE1 Huawei S6330\r\nXG0/0/8"},
{"1L", "ODF --- IS40 (1)\r\n10GBASE-LR", "ТШ ряд2, место 9 ODF №1", "№10 (duplex) 2xLC", "IS40 (1)", "Net 1/1/0", "", "", "", "", "PE1 Huawei S6330\r\nXG0/0/8"}};


string[,] SegmentWan = new string[,] { { "1L", "ODF --- IS40 (1)\r\n10GBASE-LR", "ТШ ряд2, место 9 ODF №1", "№10 (duplex) 2xLC", "IS40 (1)", "Net 1/1/0", "", "", "", "", "PE1 Huawei S6330\r\nXG0/0/8" },
{"1L", "ODF --- IS40 (1)\r\n10GBASE-LR", "ТШ ряд2, место 9 ODF №1", "№10 (duplex) 2xLC", "IS40 (1)", "Net 1/1/0", "", "", "", "", "PE1 Huawei S6330\r\nXG0/0/8"},
{"1L", "ODF --- IS40 (1)\r\n10GBASE-LR", "ТШ ряд2, место 9 ODF №1", "№10 (duplex) 2xLC", "IS40 (1)", "Net 1/1/0", "", "", "", "", "PE1 Huawei S6330\r\nXG0/0/8"}};

CablesGournaleCreation(filepath, address, SegmentLan, SegmentWan);


static void CablesGournaleCreation(string _filepath, string _address, string[,] _segmentlan, string[,] _segmentwan)

{


    string firstLine = "Кабельный Журнал   " + _address + "  (Сводный)";


    using (var workbook = new XLWorkbook())
    {
        var worksheet = workbook.Worksheets.Add("Сводный КЖ");  // создание страницы

        // задание ширины колонок

        var col1 = worksheet.Column("A"); col1.Width = 12;
        var col2 = worksheet.Column("B"); col2.Width = 20;
        var col3 = worksheet.Column("C"); col3.Width = 20;
        var col4 = worksheet.Column("D"); col4.Width = 20;
        var col5 = worksheet.Column("E"); col5.Width = 20;
        var col6 = worksheet.Column("F"); col6.Width = 20;
        var col7 = worksheet.Column("G"); col7.Width = 40;
        var col8 = worksheet.Column("H"); col8.Width = 15;
        var col9 = worksheet.Column("I"); col9.Width = 20;
        var col10 = worksheet.Column("J"); col10.Width = 20;
        var col11 = worksheet.Column("K"); col11.Width = 40;

        var col12 = worksheet.Row(2); col12.Height = 60;
        var col13 = worksheet.Row(3); col13.Height = 60;

       
        worksheet.Cell("A1").Style.Fill.BackgroundColor = XLColor.LightSeaGreen; // заливка ячейки цветом
        worksheet.Cell("A1").Style.Fill.BackgroundColor = XLColor.LightSeaGreen;
        worksheet.Range("A2:K3").Style.Fill.BackgroundColor = XLColor.BurlyWood;


        Cell_Fill_Left(worksheet, "A1:K1", firstLine);
        Cell_Fill_Center(worksheet, "A2:A3", "Номер кабельного соединения");
        Cell_Fill_Center(worksheet, "B2:B3", "Наименование участка");
        Cell_Fill_Center(worksheet, "C2:D2", "Откуда");
        Cell_Fill_Center(worksheet, "E2:F2", "Куда");
        Cell_Fill_Left(worksheet, "C3:C3", "№№ стойки, шкафа;\r\nнаименование оборудования");
        Cell_Fill_Left(worksheet, "D3:D3", "Плата (слот) / гнездо (порт)");
        Cell_Fill_Left(worksheet, "E3:E3", "№№ стойки, шкафа;\r\nнаименование оборудования");
        Cell_Fill_Left(worksheet, "F3:F3", "Плата (слот) / гнездо (порт)");
        Cell_Fill_Center(worksheet, "G2:G3", "Марка, ёмкость кабеля");
        Cell_Fill_Center(worksheet, "H2:H3", "Количество кусков (шт)");
        Cell_Fill_Center(worksheet, "I2:I3", "Длина куска (м)");
        Cell_Fill_Center(worksheet, "J2:J3", "Общая длина (м)");
        Cell_Fill_Center(worksheet, "K2:K3", "Примечания");

        // формирование части ЛАН

        worksheet.Range("A4:K4").Style.Fill.BackgroundColor = XLColor.Bisque;
        Cell_Fill_Center(worksheet, "A4:K4", "Сегмент LAN");

        for (int j = 0; j < _segmentlan.GetLength(0); j++)  // GetLength(0) длина массива по элементу 0, по вертикали
        {
                        for (int i = 0; i < 11; i++)
            {
                worksheet.Cell(j+5, i + 1).Value = _segmentlan[j, i];
                worksheet.Cell(j+5, i + 1).Style.Border.RightBorder = XLBorderStyleValues.Thin;
                worksheet.Cell(j+5, i + 1).Style.Border.BottomBorder = XLBorderStyleValues.Thin;
            }
        }
        // формирование части WAN

        string wan_title = "A" + (_segmentlan.GetLength(0) + 5).ToString() + ":K" + (_segmentlan.GetLength(0) + 5).ToString();

        Cell_Fill_Center(worksheet, wan_title, "Сегмент LAN");
        worksheet.Range(wan_title).Style.Fill.BackgroundColor = XLColor.Bisque;

        for (int j = 0; j < _segmentwan.GetLength(0); j++)
        {
            for (int i = 0; i < 11; i++)
            {
                worksheet.Cell(j + 6 + _segmentwan.GetLength(0), i + 1).Value = _segmentlan[j, i];
                worksheet.Cell(j + 6 + _segmentwan.GetLength(0), i + 1).Style.Border.RightBorder = XLBorderStyleValues.Thin;
                worksheet.Cell(j + 6 + _segmentwan.GetLength(0), i + 1).Style.Border.BottomBorder = XLBorderStyleValues.Thin;
            }
        }


        // формирование раздкла Байпасы - далее


        //
        //
        //
        //
        //
        //





        // сохраненеие файла

        workbook.SaveAs(_filepath);
    }


    // вспомогательные методы

    // запись в центре ячейки

    void Cell_Fill_Center(IXLWorksheet ws, string cells, string text)
    {
        ws.Range(cells).Merge();
        ws.Range(cells).Value = text;
        ws.Range(cells).Style.Alignment.SetHorizontal(XLAlignmentHorizontalValues.Center);
        ws.Range(cells).Style.Alignment.WrapText = true;
        ws.Range(cells).Style.Border.RightBorder = XLBorderStyleValues.Thin;
        ws.Range(cells).Style.Border.BottomBorder = XLBorderStyleValues.Thin;
     }

    // запись слева ячейки

    void Cell_Fill_Left(IXLWorksheet ws, string cells, string text)
    {
        ws.Range(cells).Merge();
        ws.Range(cells).Value = text;
        ws.Range(cells).Style.Alignment.SetHorizontal(XLAlignmentHorizontalValues.Left);
        ws.Range(cells).Style.Alignment.WrapText = true;
        ws.Range(cells).Style.Border.RightBorder = XLBorderStyleValues.Thin;
        ws.Range(cells).Style.Border.BottomBorder = XLBorderStyleValues.Thin;
     }


}