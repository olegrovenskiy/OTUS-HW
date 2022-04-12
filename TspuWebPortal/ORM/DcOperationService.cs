namespace TspuWebPortal.ORM;
using System.Linq;
using TspuWebPortal.Model;


public class DcOperationService
{
    //~~~~~~~~~~~~~~~~~~~~~~~~~~    Базовые настройки   ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
    private readonly TspuDbContext _db;

    public DcOperationService(TspuDbContext db)
    {
        _db = db;
    }

    //~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~    Помещения    ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~

    public List<OperationData> ListAllDcOperations()
    {
        List<OperationData>? OperationList = _db.Operations?.ToList();
        return OperationList;
    }

    public List<OperationData> ListAllOperations(int ID)
    {
        //List<OperationData>? OperationList = _db.Operations?.ToList();
        List<OperationData>? SelectedOperationList = _db.Operations.Where(s => s.OperationId == ID).ToList();
        return SelectedOperationList;
    }


    public void CreateOperationModel(OperationData objOperation)
    {
        _db.Operations?.Add(objOperation);
        _db.SaveChanges();
        return;
    }

    public OperationData GetOperationInfoById(int ID)
    {

        OperationData? OperationInfo = _db.Operations?.FirstOrDefault(s => s.OperationId == ID);
        /*
        if (OperationInfo == null)
        {
            OperationData OperationDefaultInfo = new OperationData();
            OperationDefaultInfo.DataCenterId = ID;
            OperationDefaultInfo.OperationName = "Не создан";
            OperationDefaultInfo.OperationCoordinates = "Не создан";
            return OperationDefaultInfo;
        }

        else return OperationInfo;
        */
        return OperationInfo;
    }

    public void UpdateOperationInfo(OperationData objDcOperation)
    {
        _db.Operations?.Update(objDcOperation);
        _db.SaveChanges();
        return;
    }
}