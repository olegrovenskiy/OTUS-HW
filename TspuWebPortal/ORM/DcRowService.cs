namespace TspuWebPortal.ORM;
using System.Linq;
using TspuWebPortal.Model;


public class DcRowService
{
    //~~~~~~~~~~~~~~~~~~~~~~~~~~    Базовые настройки   ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
    private readonly TspuDbContext _db;

    public DcRowService(TspuDbContext db)
    {
        _db = db;
    }

    //~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~    Ряды    ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~

    public List<RowData> ListAllDcRows()
    {
        List<RowData>? RowList = _db.Rows?.ToList();
        return RowList;
    }

    public void CreateRow(RowData objRow)
    {
        _db.Rows?.Add(objRow);
        _db.SaveChanges();
        return;
    }

    public RowData GetRowInfoById(int ID)
    {

        RowData? RowInfo = _db.Rows?.FirstOrDefault(s => s.RowId == ID);

        if (RowInfo == null)
        {
            RowData RowDefaultInfo = new RowData();
            RowDefaultInfo.RowId = ID;
            RowDefaultInfo.RowNameDataCenter = "Не создан";
            RowDefaultInfo.RowNameAsbi = "Не создан";
            RowDefaultInfo.RoomId = 0;
            return RowDefaultInfo;
        }

        else return RowInfo;

    }

    public List<RowData> ListRowsOnSpecificRoom(int ID)
    {
        //List<RoomData>? RoomList = _db.Rooms?.ToList();
        List<RowData>? SelectedRowList = _db.Rows.Where(s => s.RoomId == ID).ToList();
        return SelectedRowList;
    }

    public void UpdateRowInfo(RowData objDcRow)
    {
        _db.Rows?.Update(objDcRow);
        _db.SaveChanges();
        return;
    }
}

