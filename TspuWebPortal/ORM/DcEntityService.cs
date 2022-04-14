namespace TspuWebPortal.ORM;
using System.Linq;
using TspuWebPortal.Model;


public class DcEntityService
{
    //~~~~~~~~~~~~~~~~~~~~~~~~~~    Базовые настройки   ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
    private readonly TspuDbContext _db;

    public DcEntityService(TspuDbContext db)
    {
        _db = db;
    }

    //~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~    Сущности    ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~

    public List<EntityModelData> ListAllDcEntityModels()
    {
        List<EntityModelData>? EntityModelList = _db.EntityModel?.ToList();
        return EntityModelList;
    }

    public void CreateEntityModel(EntityModelData objEntityModel)
    {
        _db.EntityModel?.Add(objEntityModel);
        _db.SaveChanges();
        return;
    }

    public EntityModelData GetEntityModelInfoById(int ID)
    {

        EntityModelData? EntityModelInfo = _db.EntityModel?.FirstOrDefault(s => s.EntityModelId == ID);

        if (EntityModelInfo == null)
        {
            EntityModelData EntityModelDefaultInfo = new EntityModelData();
            EntityModelDefaultInfo.EntityModelId = ID;
            EntityModelDefaultInfo.Vendor = "Не создан";
            EntityModelDefaultInfo.ModelType = "Не создан";
            EntityModelDefaultInfo.ModelName = "Не создан";
            EntityModelDefaultInfo.PartNumber = "Не создан";
            EntityModelDefaultInfo.NominalPower = 0;
            EntityModelDefaultInfo.MaximalPower = 0;
            return EntityModelDefaultInfo;
        }

        else return EntityModelInfo;

    }

    public void UpdateEntityModelInfo(EntityModelData objDcEntityModel)
    {
        _db.EntityModel?.Update(objDcEntityModel);
        _db.SaveChanges();
        return;
    }


    public EntityModelData FindOrCreateEntityModelFromExcel(VedomostData ExcelObject)
    {
        EntityModelData? EntityModelInfo = _db.EntityModel?.FirstOrDefault(s => s.ModelName == ExcelObject.Description);
        if (EntityModelInfo == null)
        {
            string EntityType;
            string EntityName = ExcelObject.Description;
            string ItemNumber = ExcelObject.ItemNumber;
            if (ItemNumber.IndexOf(".") == -1) EntityType = "Шасси";
            else if ((EntityName.IndexOf("Плата") > -1) || (EntityName.IndexOf("Memory") > -1)) EntityType = "Плата";
            else if (EntityName.IndexOf("Кабель") > -1) EntityType = "Кабель";
            else EntityType = "Модуль";
            EntityModelData NewEntityModel = new EntityModelData { ModelName = EntityName, ModelType = EntityType };
            CreateEntityModel(NewEntityModel);
            return NewEntityModel;
        }
        else return EntityModelInfo;
    }

}

