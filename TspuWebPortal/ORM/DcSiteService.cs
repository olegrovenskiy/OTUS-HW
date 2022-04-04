namespace TspuWebPortal.ORM;
using System.Linq;
using TspuWebPortal.Model;


    public class DcSiteService
    {
        //~~~~~~~~~~~~~~~~~~~~~~~~~~    Базовые настройки   ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        private readonly TspuDbContext _db;

        public DcSiteService(TspuDbContext db)
        {
            _db = db;
        }

        //~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~    ЦОДы    ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~

        public List<DcData> ListAllDcSites()
        {
            List<DcData>? SiteList = _db.DataCenters?.ToList();
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
}

