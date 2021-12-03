using System.ComponentModel.DataAnnotations.Schema;

namespace TspuWebPortal.Data
{
    public class SiteData
    {
        public int ID { get; set; }
        public string Oper { get; set; }
        public string City { get; set; }
        public string Address { get; set; }
        public string SiteType { get; set; }
        public string Links { get; set; }

        public SiteData(int ID, string Oper, string City, string Address, string SiteType, string Links) 
        { this.ID = ID; this.Oper = Oper; this.City = City; this.Address = Address; this.SiteType = SiteType; this.Links = Links; }
    }
}
