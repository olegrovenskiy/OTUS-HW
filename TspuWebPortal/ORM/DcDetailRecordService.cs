namespace TspuWebPortal.ORM;
using System.Linq;
using TspuWebPortal.Model;
using Microsoft.EntityFrameworkCore;

public class DcDetailRecordService
{
    //~~~~~~~~~~~~~~~~~~~~~~~~~~    Базовые настройки   ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
    private readonly TspuDbContext _db;

    public DcDetailRecordService(TspuDbContext db)
    {
        _db = db;
    }

    //~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~    Записи деталей    ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~

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
        //var AllDetailRecords = _db.DetailRecords.


        DetailRecordData? DetailRecordDataInfo = _db.DetailRecords?.Include(record => record.SpecDetail)
            .ThenInclude(spec => spec.EntityModel).
            FirstOrDefault(s => s.DetailRecordId == ID);

        if (DetailRecordDataInfo == null)
        {
            DetailRecordData DetailRecordDataDefaultInfo = new DetailRecordData();
            DetailRecordDataInfo.DetailRecordId = ID;
            return DetailRecordDataDefaultInfo;
        }

        else return DetailRecordDataInfo;

    }

    //ListAllAnattendedDetails
    public List<DetailRecordData> ListAllAnattendedDetails()
    {
        List<DetailRecordData>? DetailRecordDataList = _db.DetailRecords?
            .Where(record => record.IsSuccessfullyUploaded == false)
            .Include(record => record.SpecDetail)
            .ToList();
        return DetailRecordDataList;
    }



    public void UpdateDetailRecordInfo(DetailRecordData objDetailRecordModel)
    {

        _db.DetailRecords?.Update(objDetailRecordModel);
        _db.SaveChanges();
        return;
    }

    //~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~    Записи спецификации    ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~

    public SpecDetailData GetSpecaDataInfoById(int ID)
    {


        SpecDetailData? DetailSpecaInfo = _db.SpecificationRecords?.FirstOrDefault(s => s.SpecDetailId == ID);

        if (DetailSpecaInfo == null)
        {
            SpecDetailData DefaultDetailSpecaInfo = new SpecDetailData();
            DefaultDetailSpecaInfo.SpecDetailId = ID;
            return DefaultDetailSpecaInfo;
        }

        else return DetailSpecaInfo;

    }

}
