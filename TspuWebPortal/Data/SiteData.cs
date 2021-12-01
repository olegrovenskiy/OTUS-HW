using System.ComponentModel.DataAnnotations.Schema;

namespace TspuWebPortal.Data
{
    public class SiteData
    {
        public int ID { get; set; }
        public string Oper { get; set; }
        public string City { get; set; }
        public string Address { get; set; }

        public SiteData(int ID, string Oper, string City, string Address) { this.ID = ID; this.Oper = Oper; this.City = City; this.Address = Address; }
    }
}
