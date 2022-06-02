namespace TspuWebPortal.ORM;
using System.Linq;
using TspuWebPortal.Model;

public class DcInitialDetailRecordService
{
    //~~~~~~~~~~~~~~~~~~~~~~~~~~    Базовые настройки   ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
    private readonly TspuDbContext _db;

    public DcInitialDetailRecordService(TspuDbContext db)
    {
        _db = db;
    }

    //~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~    Таблицы деталей    ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~

    public List<InitialDetailRecordData> ListAllDetailRecordData()
    {
        List<InitialDetailRecordData>? DetailRecordDataList = _db.DetailRecord?.ToList();
        return DetailRecordDataList;
    }

    public void CreateDetailRecordModel(InitialDetailRecordData objDetailRecordModel)
    {
        _db.DetailRecord?.Add(objDetailRecordModel);
        _db.SaveChanges();
        return;
    }

    public InitialDetailRecordData GetDetailRecordDataInfoById(int ID)
    {

        InitialDetailRecordData? DetailRecordDataInfo = _db.DetailRecord?.FirstOrDefault(s => s.InitialDetailRecordId == ID);

        if (DetailRecordDataInfo == null)
        {
            InitialDetailRecordData DetailRecordDataDefaultInfo = new InitialDetailRecordData();
            DetailRecordDataInfo.InitialDetailRecordId = ID;
            return DetailRecordDataDefaultInfo;
        }

        else return DetailRecordDataInfo;

    }




    public void UpdateDetailRecordInfo(InitialDetailRecordData objDetailRecordModel)
    {

        _db.DetailRecord?.Update(objDetailRecordModel);
        _db.SaveChanges();
        return;
    }

}
