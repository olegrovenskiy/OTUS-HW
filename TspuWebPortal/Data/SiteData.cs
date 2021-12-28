using System.ComponentModel.DataAnnotations.Schema;

namespace TspuWebPortal.Data
{
    public class SiteData
    {
        public int ID { get; set; }
        public string Oper { get; set; }
        public string FederalDistrict { get; set; }
        public int RegionNumber { get; set; }
        public string City { get; set; }
        public string Address { get; set; }
        public string SiteType { get; set; }
        public string Links { get; set; }
        public string IsInProject { get; set; }
        public string MaintainanceStatus { get; set; }
        public string PipelineStage { get; set; }

        public SiteData() 
        { 
            ID = 0; Oper = "не определено"; City = "не определено"; FederalDistrict = "не определено";
            RegionNumber = 0; Address = "не определено"; SiteType = "не определено"; Links = "не определено";
            IsInProject = "нет"; MaintainanceStatus = "в работе без инцидентов"; PipelineStage = "в работе без замечаний";
        }


    }
}