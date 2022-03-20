namespace TspuWebPortal.Data
{
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


        public List<DcData> ListAllDcSites()
        {
            List <DcData>? SiteList = _db.DataCenters?.ToList();
            return SiteList;
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


        public List<RoomData> ListAllDcRooms()
        {
            List<RoomData>? RoomList = _db.Rooms?.ToList();
            return RoomList;
        }

    }
}
