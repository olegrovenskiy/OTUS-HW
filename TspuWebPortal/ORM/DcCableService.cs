namespace TspuWebPortal.ORM;
using System.Linq;
using TspuWebPortal.Model;

public class DcCableService
{
    //~~~~~~~~~~~~~~~~~~~~~~~~~~    Базовые настройки   ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
    private readonly TspuDbContext _db;

    public DcCableService(TspuDbContext db)
    {
        _db = db;
    }

    //~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~    Таблицы деталей    ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~

    public List<CableData> ListAllCableData()
    {
        List<CableData>? CableDataList = _db.Cables?.ToList();
        return CableDataList;
    }

    public void CreateCableModel(CableData objCableModel)
    {
        _db.Cables?.Add(objCableModel);
        _db.SaveChanges();
        return;
    }

    public CableData GetCableDataInfoById(int ID)
    {

        CableData? CableDataInfo = _db.Cables?.FirstOrDefault(s => s.CableId == ID);

        if (CableDataInfo == null)
        {
            CableData CableDataDefaultInfo = new CableData();
            CableDataInfo.CableId = ID;
            return CableDataDefaultInfo;
        }

        else return CableDataInfo;

    }

    public void UpdateCableInfo(CableData objCableModel)
    {

        _db.Cables?.Update(objCableModel);
        _db.SaveChanges();
        return;
    }

}
