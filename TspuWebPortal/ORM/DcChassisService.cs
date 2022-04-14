namespace TspuWebPortal.ORM;
using System.Linq;
using TspuWebPortal.Model;

public class DcChassisService
{
    //~~~~~~~~~~~~~~~~~~~~~~~~~~    Базовые настройки   ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
    private readonly TspuDbContext _db;

    public DcChassisService(TspuDbContext db)
    {
        _db = db;
    }

    //~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~    Таблицы деталей    ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~

    public List<ChassisData> ListAllChassisData()
    {
        List<ChassisData>? ChassisDataList = _db.Chassis?.ToList();
        return ChassisDataList;
    }

    public void CreateChassisModel(ChassisData objChassisModel)
    {
        _db.Chassis?.Add(objChassisModel);
        _db.SaveChanges();
        return;
    }

    public ChassisData GetChassisDataInfoById(int ID)
    {

        ChassisData? ChassisDataInfo = _db.Chassis?.FirstOrDefault(s => s.ChassisId == ID);

        if (ChassisDataInfo == null)
        {
            ChassisData ChassisDataDefaultInfo = new ChassisData();
            ChassisDataInfo.ChassisId = ID;
            return ChassisDataDefaultInfo;
        }

        else return ChassisDataInfo;

    }

    public void UpdateChassisInfo(ChassisData objChassisModel)
    {

        _db.Chassis?.Update(objChassisModel);
        _db.SaveChanges();
        return;
    }

}
