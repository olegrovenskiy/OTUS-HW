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

    public List<DetailRecordData> ListAllDetailRecordData()
    {
        List<DetailRecordData>? DetailRecordDataList = _db.DetailRecords?.ToList();
        return DetailRecordDataList;
    }

    public void CreateDetailRecordModel(DetailRecordData objDetailRecordModel)
    {
        _db.DetailRecords?.Add(objDetailRecordModel);
        _db.SaveChanges();
        return;
    }

    public DetailRecordData GetDetailRecordDataInfoById(int ID)
    {

        DetailRecordData? DetailRecordDataInfo = _db.DetailRecords?.FirstOrDefault(s => s.DetailRecordId == ID);

        if (DetailRecordDataInfo == null)
        {
            DetailRecordData DetailRecordDataDefaultInfo = new DetailRecordData();
            DetailRecordDataInfo.DetailRecordId = ID;
            return DetailRecordDataDefaultInfo;
        }

        else return DetailRecordDataInfo;

    }




    public void UpdateDetailRecordInfo(DetailRecordData objDetailRecordModel)
    {

        _db.DetailRecords?.Update(objDetailRecordModel);
        _db.SaveChanges();
        return;
    }

}
