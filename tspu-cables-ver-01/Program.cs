


using DocumentFormat.OpenXml;
using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Spreadsheet;
using System.Text.RegularExpressions;


string filepath = @"C:\Users\o.rovenskiy\source\repos\tspu-cables-ver-01\tspu-cablesl.xlsx";

string[,] SegmentLan = new string[,] { { "1L", "ODF --- IS40 (1)\r\n10GBASE-LR", "ТШ ряд2, место 9 ODF №1", "№10 (duplex) 2xLC", "IS40 (1)", "Net 1/1/0", "", "", "", "", "PE1 Huawei S6330\r\nXG0/0/8" },
{"1L", "ODF --- IS40 (1)\r\n10GBASE-LR", "ТШ ряд2, место 9 ODF №1", "№10 (duplex) 2xLC", "IS40 (1)", "Net 1/1/0", "", "", "", "", "PE1 Huawei S6330\r\nXG0/0/8"}, 
{"1L", "ODF --- IS40 (1)\r\n10GBASE-LR", "ТШ ряд2, место 9 ODF №1", "№10 (duplex) 2xLC", "IS40 (1)", "Net 1/1/0", "", "", "", "", "PE1 Huawei S6330\r\nXG0/0/8"}};

CablesGournaleCreation(filepath, SegmentLan);



static void CablesGournaleCreation (string filepath, string[,] _segmentlan)


{

    string address = "г. Рязань, ул. Горького, д. 94";

    SpreadsheetDocument document = SpreadsheetDocument.Create(filepath, SpreadsheetDocumentType.Workbook);

    WorkbookPart workbookPart = document.AddWorkbookPart();
    workbookPart.Workbook = new Workbook();
    WorksheetPart worksheetPart = workbookPart.AddNewPart<WorksheetPart>();

    worksheetPart.Worksheet = new Worksheet(new SheetData());


    //create a MergeCells class to hold each MergeCell
    MergeCells mergeCells = new MergeCells();
    //append a MergeCell to the mergeCells for each set of merged cells

    mergeCells.Append(new MergeCell() { Reference = new StringValue("A1:K1") });

    mergeCells.Append(new MergeCell() { Reference = new StringValue("A2:A3") });

    mergeCells.Append(new MergeCell() { Reference = new StringValue("B2:B3") });

    mergeCells.Append(new MergeCell() { Reference = new StringValue("C2:D2") });

    mergeCells.Append(new MergeCell() { Reference = new StringValue("E2:F2") });

    mergeCells.Append(new MergeCell() { Reference = new StringValue("G2:G3") });

    mergeCells.Append(new MergeCell() { Reference = new StringValue("H2:H3") });

    mergeCells.Append(new MergeCell() { Reference = new StringValue("I2:I3") });

    mergeCells.Append(new MergeCell() { Reference = new StringValue("J2:J3") });

    mergeCells.Append(new MergeCell() { Reference = new StringValue("K2:K3") });

    mergeCells.Append(new MergeCell() { Reference = new StringValue("A4:K4") });



    Columns lstColumns = worksheetPart.Worksheet.GetFirstChild<Columns>();
    Boolean needToInsertColumns = false;
    if (lstColumns == null)
    {
        lstColumns = new Columns();
        needToInsertColumns = true;
    }
    lstColumns.Append(new Column() { Min = 1, Max = 1, Width = 12, CustomWidth = true });
    lstColumns.Append(new Column() { Min = 2, Max = 2, Width = 20, CustomWidth = true });
    lstColumns.Append(new Column() { Min = 3, Max = 3, Width = 30, CustomWidth = true });
    lstColumns.Append(new Column() { Min = 4, Max = 4, Width = 30, CustomWidth = true });
    lstColumns.Append(new Column() { Min = 5, Max = 5, Width = 10, CustomWidth = true });
    lstColumns.Append(new Column() { Min = 6, Max = 6, Width = 20, CustomWidth = true });
    lstColumns.Append(new Column() { Min = 7, Max = 7, Width = 40, CustomWidth = true });
    lstColumns.Append(new Column() { Min = 8, Max = 8, Width = 15, CustomWidth = true });
    lstColumns.Append(new Column() { Min = 9, Max = 9, Width = 20, CustomWidth = true });
    lstColumns.Append(new Column() { Min = 10, Max = 10, Width = 20, CustomWidth = true });
    lstColumns.Append(new Column() { Min = 11, Max = 11, Width = 40, CustomWidth = true });



    if (needToInsertColumns)
        worksheetPart.Worksheet.InsertAt(lstColumns, 0);


    WorkbookStylesPart wbsp = workbookPart.AddNewPart<WorkbookStylesPart>();
    // Добавляем в документ набор стилей
    wbsp.Stylesheet = GenerateStyleSheet();
    wbsp.Stylesheet.Save();



    worksheetPart.Worksheet.InsertAfter(mergeCells, worksheetPart.Worksheet.Elements<SheetData>().First());






    Sheets sheets = workbookPart.Workbook.AppendChild(new Sheets());
    Sheet sheet = new Sheet() { Id = workbookPart.GetIdOfPart(worksheetPart), SheetId = 1, Name = "Сводный КЖ" };
    sheets.Append(sheet);



    SheetData sheetData = worksheetPart.Worksheet.GetFirstChild<SheetData>();
    Row row = new Row() { RowIndex = 1 };
    sheetData.Append(row);




    string firstLine = "Кабельный Журнал   " + address + "  (Сводный)";


    InsertCell(row, 1, firstLine, CellValues.String, 8);
    InsertCell(row, 2, null, CellValues.String, 1);
    InsertCell(row, 3, null, CellValues.String, 1);
    InsertCell(row, 4, null, CellValues.String, 1);
    InsertCell(row, 5, null, CellValues.String, 1);
    InsertCell(row, 6, null, CellValues.String, 1);
    InsertCell(row, 7, null, CellValues.String, 1);
    InsertCell(row, 8, null, CellValues.String, 1);
    InsertCell(row, 9, null, CellValues.String, 1);
    InsertCell(row, 10, null, CellValues.String, 1);
    InsertCell(row, 11, null, CellValues.String, 1);





    row = new Row() { RowIndex = 2 };
    sheetData.Append(row);


    InsertCell(row, 1, "Номер кабельного соединения", CellValues.String, 9);
    InsertCell(row, 2, "Наименование участка", CellValues.String, 9);
    InsertCell(row, 3, "Откуда", CellValues.String, 9);
    InsertCell(row, 4, null, CellValues.String, 9);
    InsertCell(row, 5, "Куда", CellValues.String, 9);
    InsertCell(row, 6, null, CellValues.String, 9);
    InsertCell(row, 7, "Марка, ёмкость кабеля", CellValues.String, 9);
    InsertCell(row, 8, "Количество кусков (шт)", CellValues.String, 9);
    InsertCell(row, 9, "Длина куска (м)", CellValues.String, 9);
    InsertCell(row, 10, "Общая длина (м)", CellValues.String, 9);
    InsertCell(row, 11, "Примечания", CellValues.String, 9);



    row = new Row() { RowIndex = 3 };
    sheetData.Append(row);

    InsertCell(row, 1, null, CellValues.String, 9);
    InsertCell(row, 2, null, CellValues.String, 9);
    InsertCell(row, 3, "№№ стойки, шкафа;\r\nнаименование оборудования", CellValues.String, 9);
    InsertCell(row, 4, "Плата (слот) / гнездо (порт)", CellValues.String, 9);
    InsertCell(row, 5, "№№ стойки, шкафа;\r\nнаименование оборудования", CellValues.String, 9);
    InsertCell(row, 6, "Плата (слот) / гнездо (порт)", CellValues.String, 9);
    InsertCell(row, 7, null, CellValues.String, 9);
    InsertCell(row, 8, null, CellValues.String, 9);
    InsertCell(row, 9, null, CellValues.String, 9);
    InsertCell(row, 10, null, CellValues.String, 9);
    InsertCell(row, 11, null, CellValues.String, 9);




    row = new Row() { RowIndex = 4 };
    sheetData.Append(row);

    InsertCell(row, 1, "Сегмент LAN", CellValues.String, 10);
    InsertCell(row, 2, null, CellValues.String, 10);
    InsertCell(row, 3, null, CellValues.String, 10);
    InsertCell(row, 4, null, CellValues.String, 10);
    InsertCell(row, 5, null, CellValues.String, 10);
    InsertCell(row, 6, null, CellValues.String, 10);
    InsertCell(row, 7, null, CellValues.String, 10);
    InsertCell(row, 8, null, CellValues.String, 10);
    InsertCell(row, 9, null, CellValues.String, 10);
    InsertCell(row, 10, null, CellValues.String, 10);
    InsertCell(row, 11, null, CellValues.String, 10);

    // заполнение сегмента ЛАН в КЖ


     DocumentFormat.OpenXml.UInt32Value index;

    for (DocumentFormat.OpenXml.UInt32Value j = 0; j < _segmentlan.GetLength(0); j++)
    {

        index = 5+j;
    
        
        row = new Row() { RowIndex = index };
        sheetData.Append(row);


        for (int i = 0; i < 11; i++)
        {
            InsertCell(row, i + 1, _segmentlan[j, i], CellValues.String, 2);
        }
    }


    string mer = (_segmentlan.GetLength(0)+5).ToString();


    string merge = "A" + mer + ":K" + mer;
    
    mergeCells.Append(new MergeCell() { Reference = new StringValue(merge) }  );

    DocumentFormat.OpenXml.UInt32Value index1;

    index1 = (UInt32)_segmentlan.GetLength(0)+5;

    row = new Row() { RowIndex = index1 };
    sheetData.Append(row);

    InsertCell(row, 1, "Сегмент WAN", CellValues.String, 10);
    InsertCell(row, 2, null, CellValues.String, 10);
    InsertCell(row, 3, null, CellValues.String, 10);
    InsertCell(row, 4, null, CellValues.String, 10);
    InsertCell(row, 5, null, CellValues.String, 10);
    InsertCell(row, 6, null, CellValues.String, 10);
    InsertCell(row, 7, null, CellValues.String, 10);
    InsertCell(row, 8, null, CellValues.String, 10);
    InsertCell(row, 9, null, CellValues.String, 10);
    InsertCell(row, 10, null, CellValues.String, 10);
    InsertCell(row, 11, null, CellValues.String, 10);



    workbookPart.Workbook.Save();
    document.Close();











    // МЕТОДЫ для Построения Текста в Ячейках


    //Добавление Ячейки в строку (На вход подаем: строку, номер колонки, тип значения, стиль)
    static void InsertCell(Row row, int cell_num, string val, CellValues type, uint styleIndex)
    {
        Cell refCell = null;
        Cell newCell = new Cell() { CellReference = cell_num.ToString() + ":" + row.RowIndex.ToString(), StyleIndex = styleIndex };
        row.InsertBefore(newCell, refCell);

        // Устанавливает тип значения.
        newCell.CellValue = new CellValue(val);
        newCell.DataType = new EnumValue<CellValues>(type);

    }






    // стили, требуют корректировки


    //Метод генерирует стили для ячеек (за основу взят код, найденный где-то в интернете)
    static Stylesheet GenerateStyleSheet()
    {
        return new Stylesheet(

            new Fonts(
                new Font(                                                               // Стиль под номером 0 - Шрифт по умолчанию.
                    new FontSize() { Val = 11 },
                    new Color() { Rgb = new HexBinaryValue() { Value = "000000" } },
                    new FontName() { Val = "Calibri" }),
                new Font(                                                               // Стиль под номером 1 - Жирный шрифт Times New Roman.
                    new Bold(),
                    new FontSize() { Val = 11 },
                    new Color() { Rgb = new HexBinaryValue() { Value = "000000" } },
                    new FontName() { Val = "Times New Roman" }),
                new Font(                                                               // Стиль под номером 2 - Обычный шрифт Times New Roman.
                    new FontSize() { Val = 11 },
                    new Color() { Rgb = new HexBinaryValue() { Value = "000000" } },
                    new FontName() { Val = "Times New Roman" }),
                new Font(                                                               // Стиль под номером 3 - Шрифт Times New Roman размером 14.
                    new FontSize() { Val = 14 },
                    new Color() { Rgb = new HexBinaryValue() { Value = "000000" } },
                    new FontName() { Val = "Times New Roman" })
            ),



            new Fills(
                new Fill(                                                           // Стиль под номером 0 - Заполнение ячейки по умолчанию.
                    new PatternFill() { PatternType = PatternValues.None }),
                new Fill(                                                           // Стиль под номером 1 - Заполнение ячейки серым цветом
                    new PatternFill(
                        new ForegroundColor() { Rgb = new HexBinaryValue() { Value = "FFAAAAAA" } }
                        )
                    { PatternType = PatternValues.Solid }),
                new Fill(                                                           // Стиль под номером 2 - Заполнение ячейки цвета морской волны
                    new PatternFill(
                        new ForegroundColor() { Rgb = new HexBinaryValue() { Value = "3CB371" } }
                    )
                    { PatternType = PatternValues.Solid }),


                new Fill(                                                           // Стиль под номером 3 - Запоолнение ячейки коричневым.
                    new PatternFill(
                        new ForegroundColor() { Rgb = new HexBinaryValue() { Value = "DEB887" } }
                    )
                    { PatternType = PatternValues.Solid }),

                new Fill(                                                           // Стиль под номером 4 - Запоолнение светло корич.
                    new PatternFill(
                        new ForegroundColor() { Rgb = new HexBinaryValue() { Value = "F5DEB3" } }
                    )
                    { PatternType = PatternValues.Solid })


                )
            ,



            new Borders(
                new Border(                                                         // Стиль под номером 0 - Грани.
                    new LeftBorder(),
                    new RightBorder(),
                    new TopBorder(),
                    new BottomBorder(),
                    new DiagonalBorder()),
                new Border(                                                         // Стиль под номером 1 - Грани
                    new LeftBorder(
                        new Color() { Auto = true }
                    )
                    { Style = BorderStyleValues.Medium },
                    new RightBorder(
                        new Color() { Indexed = (UInt32Value)64U }
                    )
                    { Style = BorderStyleValues.Medium },
                    new TopBorder(
                        new Color() { Auto = true }
                    )
                    { Style = BorderStyleValues.Medium },
                    new BottomBorder(
                        new Color() { Indexed = (UInt32Value)64U }
                    )
                    { Style = BorderStyleValues.Medium },
                    new DiagonalBorder()),
                new Border(                                                         // Стиль под номером 2 - Грани.
                    new LeftBorder(
                        new Color() { Auto = true }
                    )
                    { Style = BorderStyleValues.Thin },
                    new RightBorder(
                        new Color() { Indexed = (UInt32Value)64U }
                    )
                    { Style = BorderStyleValues.Thin },
                    new TopBorder(
                        new Color() { Auto = true }
                    )
                    { Style = BorderStyleValues.Thin },
                    new BottomBorder(
                        new Color() { Indexed = (UInt32Value)64U }
                    )
                    { Style = BorderStyleValues.Thin },
                    new DiagonalBorder())
            ),



            new CellFormats(
                new CellFormat() { FontId = 0, FillId = 0, BorderId = 0 },                          // Стиль под номером 0 - The default cell style.  (по умолчанию)

                new CellFormat(new Alignment() { Horizontal = HorizontalAlignmentValues.Center, Vertical = VerticalAlignmentValues.Center, WrapText = true }) { FontId = 1, FillId = 2, BorderId = 1, ApplyFont = true },       // Стиль под номером 1 - Bold 

                new CellFormat(new Alignment() { Horizontal = HorizontalAlignmentValues.Center, Vertical = VerticalAlignmentValues.Center, WrapText = true }) { FontId = 2, FillId = 0, BorderId = 2, ApplyFont = true },       // Стиль под номером 2 - REgular

                new CellFormat() { FontId = 3, FillId = 0, BorderId = 2, ApplyFont = true, NumberFormatId = 4 },       // Стиль под номером 3 - Times Roman

                new CellFormat() { FontId = 0, FillId = 2, BorderId = 0, ApplyFill = true },       // Стиль под номером 4 - Yellow Fill

                new CellFormat(                                                                   // Стиль под номером 5 - Alignment
                    new Alignment() { Horizontal = HorizontalAlignmentValues.Center, Vertical = VerticalAlignmentValues.Center }
                )
                { FontId = 0, FillId = 0, BorderId = 0, ApplyAlignment = true },
                new CellFormat() { FontId = 0, FillId = 0, BorderId = 1, ApplyBorder = true },      // Стиль под номером 6 - Border
                new CellFormat(new Alignment() { Horizontal = HorizontalAlignmentValues.Right, Vertical = VerticalAlignmentValues.Center, WrapText = true }) { FontId = 2, FillId = 0, BorderId = 2, ApplyFont = true, NumberFormatId = 4 },       // Стиль под номером 7 - Задает числовой формат полю.

                new CellFormat(new Alignment() { Horizontal = HorizontalAlignmentValues.Center, Vertical = VerticalAlignmentValues.Center, WrapText = true }) { FontId = 2, FillId = 2, BorderId = 2, ApplyFont = true },  // стиль 8 морская волна, первая строка

                new CellFormat(new Alignment() { Horizontal = HorizontalAlignmentValues.Center, Vertical = VerticalAlignmentValues.Center, WrapText = true }) { FontId = 2, FillId = 3, BorderId = 2, ApplyFont = true },  // стиль 9 темн кор вторая строка
                new CellFormat(new Alignment() { Horizontal = HorizontalAlignmentValues.Center, Vertical = VerticalAlignmentValues.Center, WrapText = true }) { FontId = 2, FillId = 4, BorderId = 2, ApplyFont = true }  // стиль 10 темн кор вторая строка

            )
        ); // Выход

    }

}