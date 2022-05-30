﻿namespace TspuWebPortal.ORM;

using Microsoft.EntityFrameworkCore;
using System.Linq;
using TspuWebPortal.Model;

public class DcUnitService
{
    //~~~~~~~~~~~~~~~~~~~~~~~~~~    Базовые настройки   ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
    private readonly TspuDbContext _db;

    public DcUnitService(TspuDbContext db)
    {
        _db = db;
    }

    //~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~    Юниты в стойке   ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~

    public List<UnitData> ListAllUnitData()
    {
        List<UnitData>? UnitDataList = _db.Units?.ToList();
        return UnitDataList;
    }

    public List<UnitData> ListAllUnitsInRack(int RackId)
    {
        List<UnitData>? UnitDataList = _db.Units?.Where(s => s.RackId == RackId).ToList();
        return UnitDataList;
    }

    public void CreateUnitModel(UnitData objUnitModel)
    {
        _db.Units?.Add(objUnitModel);
        _db.SaveChanges();
        return;
    }

    public UnitData GetUnitDataInfoById(int ID)
    {

        UnitData? UnitDataInfo = _db.Units?.FirstOrDefault(s => s.UnitId == ID);

        if (UnitDataInfo == null)
        {
            UnitData UnitDataDefaultInfo = new UnitData();
            UnitDataInfo.UnitId = ID;
            return UnitDataDefaultInfo;
        }

        else return UnitDataInfo;

    }

    public void UpdateUnitInfo(UnitData objUnitModel)
    {

        _db.Units?.Update(objUnitModel);
        _db.SaveChanges();
        return;
    }



    public UnitData GetUnitByVedomostData(string DcName, string RoomName, string RowName, string RackId, int UnitInRackId, bool IsChassisOnFront)
    {



        var SelectedDataCenters = _db.DataCenters
                    .Include(dc => dc.Rooms)
                    .ThenInclude(room => room.Rows)
                    .ThenInclude(row => row.Racks)
                    .ThenInclude(rack => rack.Units)
                    .ToList();


        DcData SelectedDc = SelectedDataCenters.Single(p => p.DataCenterName == DcName);
        RoomData SelectedRoom = SelectedDc.Rooms.Single(p => p.RoomName == RoomName);
        RowData SelectedRow = SelectedRoom.Rows.Single(p => p.RowNameDataCenter == RowName);
         RackData SelectrdRack = SelectedRow.Racks.Single(p => p.RackNameAsbi == RackId);
        UnitData SelectedUnit = SelectrdRack.Units.Single(p => (p.UnitInRack == UnitInRackId) && (p.IsFront == IsChassisOnFront));
        //UnitData SelectedUnit = SelectrdRack.Units.Single(p => (p.UnitInRack == UnitInRackId) && (p.IsFront == true));
        //UnitData SelectedUnit = SelectrdRack.Units.Single(p => (p.UnitInRack == UnitInRackId));
        if (SelectedUnit == null) throw new Exception("Данные не найдены");
        return SelectedUnit;
    }

}

/*
 * 
         public DcData GetDcInfoByName(string DcName)
        {
            DcData? DcObject = _db.DataCenters?.FirstOrDefault(s => s.DataCenterName == DcName);
            return DcObject;
        }
 
 */