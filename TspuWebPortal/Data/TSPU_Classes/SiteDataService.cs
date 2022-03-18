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
            _db.Sites.Add(objSite);
            _db.SaveChanges();
            return;
        }
        
        public List<SiteData> GetAllSitesInfo()
        {
            var SiteList = _db.Sites.ToList();
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
            _db.Sites.Update(objSite);
            _db.SaveChanges();
            return;
        }


        public List<DcData> ListAllDcSites()
        {
            List <DcData> SitesList = _db.DataCenters.ToList();
            return SitesList;
        }



    }
}
