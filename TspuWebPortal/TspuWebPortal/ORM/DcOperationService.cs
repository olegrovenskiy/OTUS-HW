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

    public List<OperationSummaryData> ListAllDcOperations()
    {
        List<OperationSummaryData>? OperationList = _db.OperationSummary?.ToList();
        return OperationList;
    }

    public List<OperationSummaryData> ListAllOperations(int ID)
    {
        //List<OperationData>? OperationList = _db.Operations?.ToList();
        List<OperationSummaryData>? SelectedOperationList = _db.OperationSummary.Where(s => s.GlobalOperationId == ID).ToList();
        return SelectedOperationList;
    }


    public void CreateSummaryOperation(OperationSummaryData objOperation)
    {
        _db.OperationSummary?.Add(objOperation);
        _db.SaveChanges();
        return;
    }

    public void CreateDetailOperation(DetailOperationData objOperation)
    {
        _db.DetailOperations?.Add(objOperation);
        _db.SaveChanges();
        return;
    }

    //objOperationService.CreateDetailOperation(UsedDetailOperation);

    public OperationSummaryData GetOperationInfoById(int ID)
    {

        OperationSummaryData? OperationInfo = _db.OperationSummary?.FirstOrDefault(s => s.GlobalOperationId == ID);
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

    public void UpdateOperationInfo(OperationSummaryData objDcOperation)
    {
        _db.OperationSummary?.Update(objDcOperation);
        _db.SaveChanges();
        return;
    }
}