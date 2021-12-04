﻿namespace TspuWebPortal.Data
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

        public SiteData GetSiteInfoById(int ID)
        {
            SiteData SiteInfo = _db.Sites.FirstOrDefault(s => s.ID == ID);
            if (SiteInfo == null)
            {
                SiteData DefaultInfo = new SiteData();
                DefaultInfo.ID = ID;
                DefaultInfo.Oper = "Не найдено";
                DefaultInfo.SiteType = "Не найдено";
                DefaultInfo.City = "Не найдено";
                DefaultInfo.SiteType = "Не найдено";
                DefaultInfo.Address = "Не найдено";
                DefaultInfo.Links = "Не найдено";
                return DefaultInfo;
            }
            else return SiteInfo;
        }

    }
}
