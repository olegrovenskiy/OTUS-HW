namespace TspuWebPortal.ORM;
using System.Linq;
using TspuWebPortal.Model;
using Microsoft.EntityFrameworkCore;

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
            EntityModelDefaultInfo.Manufacturer = "Не создан";
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



    public SpecDetailData GetSpecaModelInfoById(int ID)
    {

        SpecDetailData? SpecaModelInfo = _db.SpecificationRecords?.FirstOrDefault(s => s.SpecDetailId == ID);

        if (SpecaModelInfo == null)
        {
            SpecDetailData SpecModelDefaultInfo = new SpecDetailData();
            SpecModelDefaultInfo.EntityModelId = ID;
            SpecModelDefaultInfo.SpecItemType = "Не создан";
            SpecModelDefaultInfo.SpecItemFullName = "Не создан";
            SpecModelDefaultInfo.SpecItemShortName = "Не создан";
            return SpecModelDefaultInfo;
        }

        else return SpecaModelInfo;

    }

    public void CreateSpecaRecord(SpecDetailData objSpecaRecord)
    {
        _db.SpecificationRecords?.Add(objSpecaRecord);
        _db.SaveChanges();
        return;
    }

    public SpecDetailData FindOrCreateSpecaRecordFromExcel(VedomostData ExcelObject)
    {
        SpecDetailData? SpecaInfo = _db.SpecificationRecords?.FirstOrDefault(s => s.SpecItemFullName == ExcelObject.FullDetailName);
        if (SpecaInfo == null)
        {
            string FullName = ExcelObject.FullDetailName;
            string ShortName = "не назначено";
            string Type = "не назначено";
            int Year = ExcelObject.Year;
            string FactoryNumber = ExcelObject.FactoryNumber;
            EntityModelData EntityModel = FindOrCreateEntityModelFromExcel(ExcelObject);
            //int EntityModelId = EntityModel.EntityModelId;
            SpecDetailData NewSpecaInfo = new SpecDetailData
            {
                SpecItemFullName = FullName,
                SpecItemShortName = ShortName,
                SpecItemType = Type,
                DeliveryYear = Year,
                EntityModel = EntityModel,
                EntityModelId = EntityModel.EntityModelId
            };
            CreateSpecaRecord(NewSpecaInfo);                                                    //Возможно, подгрузить модель
            return NewSpecaInfo;
        }
        else
        {
            EntityModelData? EntityModelInfo = GetEntityModelInfoById(SpecaInfo.EntityModelId);
            return SpecaInfo;
        }    
    }





    public EntityModelData FindOrCreateEntityModelFromExcel(VedomostData ExcelObject)
    {
        EntityModelData? EntityModelInfo = _db.EntityModel?.FirstOrDefault(s => s.PartNumber == ExcelObject.FactoryNumber);
        if (EntityModelInfo == null)
        {
            string EntityType;
            string EntityName = ExcelObject.FullDetailName;
            string ItemNumber = ExcelObject.ItemNumber;
            string FactoryNumber = ExcelObject.FactoryNumber;
            if (FactoryNumber == "" || FactoryNumber == null) FactoryNumber = "не назначено";
            string DefinitionType = ExcelObject.DefinitionType;
            if (DefinitionType == "" || DefinitionType == null) DefinitionType = "не определено";
            if (ItemNumber.IndexOf(".") == -1) EntityType = "Шасси";
            else if ((EntityName.IndexOf("Плата") > -1) ||                                                                      //перетащить в enum
                (EntityName.IndexOf("Memory") > -1) || (EntityName.IndexOf("питания") > -1) ||
                (EntityName.IndexOf("карта") > -1) || (EntityName.IndexOf("управляющий") > -1) ||
                (EntityName.IndexOf("ПАК") > -1) || (EntityName.IndexOf("SSD") > -1) ||
                (EntityName.IndexOf("linecard") > -1) || (EntityName.IndexOf("Card") > -1))
                EntityType = "Плата";
            else if (EntityName.IndexOf("Кабель") > -1) EntityType = "Кабель";
            else EntityType = "Модуль";
            EntityModelData NewEntityModel = new EntityModelData { ModelName = EntityName, ModelType = EntityType, PartNumber = FactoryNumber, SnDefinitionType = DefinitionType };
            CreateEntityModel(NewEntityModel);
            return NewEntityModel;
        }
        else return EntityModelInfo;
    }

}

