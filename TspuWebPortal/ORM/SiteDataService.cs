

namespace TspuWebPortal.ORM;
using TspuWebPortal.Model;

    public class SiteDataService
    {
        private readonly TspuDbContext _db;

        public SiteDataService(TspuDbContext db)
        {
            _db = db;
        }

        public void CreateSite (SiteData objSite)
        {
            _db.Sites?.Add(objSite);
            _db.SaveChanges();
            return;
        }
        
        public List<SiteData> GetAllSitesInfo()
        {
            var SiteList = _db.Sites?.ToList();
            return SiteList;
        }

        public SiteData GetSiteInfoById(int ID)
        {

            SiteData SiteInfo = _db.Sites.FirstOrDefault(s => s.ID == ID);

            if (SiteInfo == null)
            {
                SiteData DefaultInfo = new SiteData();
                DefaultInfo.ID = ID;
                DefaultInfo.Oper = "Не создан";
                DefaultInfo.SiteType = "Не создан";
                DefaultInfo.City = "Не создан";
                DefaultInfo.SiteType = "Не создан";
                DefaultInfo.Address = "Не создан";
                DefaultInfo.Links = "Не создан";
                return DefaultInfo;
            }

            else return SiteInfo;

        }

        public void UpdateSiteInfo(SiteData objSite)
        {
            _db.Sites?.Update(objSite);
            _db.SaveChanges();
            return;
        }

    //~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~

        public List<DcData> ListAllDcSites()
        {
            List <DcData>? SiteList = _db.DataCenters?.ToList();
            return SiteList;
        }


        public void CreateDc(DcData objDc)
        {
            _db.DataCenters?.Add(objDc);
            _db.SaveChanges();
            return;
        }


        public DcData GetDcInfoById(int ID)
        {

            DcData? DcInfo = _db.DataCenters?.FirstOrDefault(s => s.DataCenterId == ID);

            if (DcInfo == null)
            {
                DcData DcDefaultInfo = new DcData();
                DcDefaultInfo.DataCenterId = ID;
                DcDefaultInfo.DataCenterName = "Не создан";
                DcDefaultInfo.DataCenterAddress = "Не создан";
                return DcDefaultInfo;
            }

            else return DcInfo;

        }

        public void UpdateDcInfo(DcData objDcSite)
        {
            _db.DataCenters?.Update(objDcSite);
            _db.SaveChanges();
            return;
        }


    //~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~

    public List<RoomData> ListAllDcRooms()
        {
            List<RoomData>? RoomList = _db.Rooms?.ToList();
            return RoomList;
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
    //~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~

    public List<RowData> ListAllDcRows()
    {
        List<RowData>? RowList = _db.Rows?.ToList();
        return RowList;
    }

    public void CreateRow(RowData objRow)
    {
        _db.Rows?.Add(objRow);
        _db.SaveChanges();
        return;
    }

    public RowData GetRowInfoById(int ID)
    {

        RowData? RowInfo = _db.Rows?.FirstOrDefault(s => s.RowId == ID);

        if (RowInfo == null)
        {
            RowData RowDefaultInfo = new RowData();
            RowDefaultInfo.RowId = ID;
            RowDefaultInfo.RowNameDataCenter = "Не создан";
            RowDefaultInfo.RowNameAsbi = "Не создан";
            RowDefaultInfo.RoomId = 0;
            return RowDefaultInfo;
        }

        else return RowInfo;

    }

    public void UpdateRowInfo(RowData objDcRow)
    {
        _db.Rows?.Update(objDcRow);
        _db.SaveChanges();
        return;
    }

}

