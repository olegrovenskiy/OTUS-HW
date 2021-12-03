namespace TspuWebPortal.Data
{
    public class SiteDataService
    {
        private readonly SiteDBContext _db;

        public SiteDataService(SiteDBContext db)
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
    }
}
