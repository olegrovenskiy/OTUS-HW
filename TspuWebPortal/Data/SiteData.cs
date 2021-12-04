using System.ComponentModel.DataAnnotations.Schema;

namespace TspuWebPortal.Data
{
    public class SiteData
    {
        public int ID { get; set; }
        public string Oper { get; set; } = null!;
        public string City { get; set; } = null!;
        public string Address { get; set; } = null!;
        public string SiteType { get; set; } = null!;
        public string Links { get; set; } = null!;

        //public SiteData(int ID, string Oper, string City, string Address, string SiteType, string Links) 
        //{ this.ID = ID; this.Oper = Oper; this.City = City; this.Address = Address; this.SiteType = SiteType; this.Links = Links; }


    }
}
