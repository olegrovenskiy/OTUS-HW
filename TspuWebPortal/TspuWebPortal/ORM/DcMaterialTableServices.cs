namespace TspuWebPortal.ORM;
using System.Linq;
using TspuWebPortal.Model;

public class DcMaterialTableService
{
    //~~~~~~~~~~~~~~~~~~~~~~~~~~    Базовые настройки   ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
    private readonly TspuDbContext _db;

    public DcMaterialTableService(TspuDbContext db)
    {
        _db = db;
    }

    //~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~    Таблицы материалов    ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~

    public List<MaterialTableData> ListAllMaterialTableData()
    {
        List<MaterialTableData>? MaterialTableDataList = _db.MaterialTable?.ToList();
        return MaterialTableDataList;
    }

    public void CreateMaterialTableModel(MaterialTableData objMaterialTableModel)
    {
        _db.MaterialTable?.Add(objMaterialTableModel);
        _db.SaveChanges();
        return;
    }

    public MaterialTableData GetMaterialTableDataInfoById(int ID)
    {

        MaterialTableData? MaterialTableDataInfo = _db.MaterialTable?.FirstOrDefault(s => s.InitialMaterialTableId == ID);

        if (MaterialTableDataInfo == null)
        {
            MaterialTableData MaterialTableDataDefaultInfo = new MaterialTableData();
            MaterialTableDataInfo.InitialMaterialTableId = ID;
            return MaterialTableDataDefaultInfo;
        }

        else return MaterialTableDataInfo;

    }

    public void UpdateMaterialTableInfo(MaterialTableData objMaterialTableModel)
    {

        _db.MaterialTable?.Update(objMaterialTableModel);
        _db.SaveChanges();
        return;
    }

}