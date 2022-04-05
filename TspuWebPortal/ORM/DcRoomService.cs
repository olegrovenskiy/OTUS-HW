namespace TspuWebPortal.ORM;
using System.Linq;
using TspuWebPortal.Model;


public class DcRoomService
{
    //~~~~~~~~~~~~~~~~~~~~~~~~~~    Базовые настройки   ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
    private readonly TspuDbContext _db;

    public DcRoomService(TspuDbContext db)
    {
        _db = db;
    }

    //~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~    Помещения    ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~

    public List<RoomData> ListAllDcRooms()
    {
        List<RoomData>? RoomList = _db.Rooms?.ToList();
        return RoomList;
    }

    public List<RoomData> ListRoomsOnSpecificDataCenter(int ID)
    {
        //List<RoomData>? RoomList = _db.Rooms?.ToList();
        List<RoomData>? SelectedRoomList = _db.Rooms.Where(s => s.DataCenterId == ID).ToList();
        return SelectedRoomList;
    }


    public void CreateRoom(RoomData objRoom)
    {
        _db.Rooms?.Add(objRoom);
        _db.SaveChanges();
        return;
    }

    public RoomData GetRoomInfoById(int ID)
    {

        RoomData? RoomInfo = _db.Rooms?.FirstOrDefault(s => s.RoomId == ID);

        if (RoomInfo == null)
        {
            RoomData RoomDefaultInfo = new RoomData();
            RoomDefaultInfo.DataCenterId = ID;
            RoomDefaultInfo.RoomName = "Не создан";
            RoomDefaultInfo.RoomCoordinates = "Не создан";
            return RoomDefaultInfo;
        }

        else return RoomInfo;

    }

    public void UpdateRoomInfo(RoomData objDcRoom)
    {
        _db.Rooms?.Update(objDcRoom);
        _db.SaveChanges();
        return;
    }
}

