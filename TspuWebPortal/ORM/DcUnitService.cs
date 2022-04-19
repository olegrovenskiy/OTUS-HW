namespace TspuWebPortal.ORM;
using System.Linq;
using TspuWebPortal.Model;

public class DcUnitService
{
    //~~~~~~~~~~~~~~~~~~~~~~~~~~    Базовые настройки   ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
    private readonly TspuDbContext _db;

    public DcUnitService(TspuDbContext db)
    {
        _db = db;
    }

    //~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~    Юниты в стойке   ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~

    public List<UnitData> ListAllUnitData()
    {
        List<UnitData>? UnitDataList = _db.Units?.ToList();
        return UnitDataList;
    }

    public List<UnitData> ListAllUnitsInRack(int RackId)
    {
        List<UnitData>? UnitDataList = _db.Units?.Where(s => s.RackId == RackId).ToList();
        return UnitDataList;
    }

    public void CreateUnitModel(UnitData objUnitModel)
    {
        _db.Units?.Add(objUnitModel);
        _db.SaveChanges();
        return;
    }

    public UnitData GetUnitDataInfoById(int ID)
    {

        UnitData? UnitDataInfo = _db.Units?.FirstOrDefault(s => s.UnitId == ID);

        if (UnitDataInfo == null)
        {
            UnitData UnitDataDefaultInfo = new UnitData();
            UnitDataInfo.UnitId = ID;
            return UnitDataDefaultInfo;
        }

        else return UnitDataInfo;

    }

    public void UpdateUnitInfo(UnitData objUnitModel)
    {

        _db.Units?.Update(objUnitModel);
        _db.SaveChanges();
        return;
    }

}
