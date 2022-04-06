namespace TspuWebPortal.ORM;
using System.Linq;
using TspuWebPortal.Model;

public class DcRackService
    {
        //~~~~~~~~~~~~~~~~~~~~~~~~~~    Базовые настройки   ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        private readonly TspuDbContext _db;

        public DcRackService(TspuDbContext db)
        {
            _db = db;
        }

    //~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~    Стойки    ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~

    public List<RackData> ListAllDcRacks()
    {
        List<RackData>? RackList = _db.Racks?.ToList();
        return RackList;
    }

    public void CreateRack(RackData objRack)
    {
        _db.Racks?.Add(objRack);
        _db.SaveChanges();
        return;
    }

    public RackData GetRackInfoById(int ID)
    {

        RackData? RackInfo = _db.Racks?.FirstOrDefault(s => s.RackId == ID);

        if (RackInfo == null)
        {
            RackData RackDefaultInfo = new RackData();

            RackDefaultInfo.RackId = ID;
            RackDefaultInfo.RackNameAsbi = "Не создан";
            RackDefaultInfo.RackNameDataCenter = "Не создан";
            RackDefaultInfo.RackHeight = 42;
            RackDefaultInfo.FreeServerSlotsQuantity = 42;
            RackDefaultInfo.IsInstalled = false;
            RackDefaultInfo.InstallationYear = 2022;
            RackDefaultInfo.RackType = "Не создан";
            RackDefaultInfo.RowId = 0;

            return RackDefaultInfo;
        }

        else return RackInfo;

    }

    public void UpdateRackInfo(RackData objDcRack)
    {
        _db.Racks?.Update(objDcRack);
        _db.SaveChanges();
        return;
    }

}

