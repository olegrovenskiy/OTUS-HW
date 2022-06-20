namespace TspuWebPortal.ORM;
using System.Linq;
using TspuWebPortal.Model;

public class DcModuleService
{
    //~~~~~~~~~~~~~~~~~~~~~~~~~~    Базовые настройки   ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
    private readonly TspuDbContext _db;

    public DcModuleService(TspuDbContext db)
    {
        _db = db;
    }

    //~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~    Таблицы деталей    ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~

    public List<ModuleData> ListAllModuleData()
    {
        List<ModuleData>? ModuleDataList = _db.Modules?.ToList();
        return ModuleDataList;
    }

    public void CreateModuleModel(ModuleData objModuleModel)
    {
        _db.Modules?.Add(objModuleModel);
        _db.SaveChanges();
        return;
    }

    public ModuleData GetModuleDataInfoById(int ID)
    {

        ModuleData? ModuleDataInfo = _db.Modules?.FirstOrDefault(s => s.ModuleId == ID);

        if (ModuleDataInfo == null)
        {
            ModuleData ModuleDataDefaultInfo = new ModuleData();
            ModuleDataInfo.ModuleId = ID;
            return ModuleDataDefaultInfo;
        }

        else return ModuleDataInfo;

    }

    public void UpdateModuleInfo(ModuleData objModuleModel)
    {

        _db.Modules?.Update(objModuleModel);
        _db.SaveChanges();
        return;
    }


    public List<ModuleData> ListAllModulesOnChassis(int InputChassisId)
    {
        List<ModuleData> AllModules = _db.Modules?.Where(s => s.ChassisId == InputChassisId).ToList();

        return AllModules;
    }


}
