using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TspuWebPortal.Model
{
    public class DetailModelData
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int EntityModelId { get; set; }
        public string ModelName { get; set; } = string.Empty;


        public string PartNumber { get; set; } = string.Empty;
        public string ModelType { get; set; } = string.Empty;          //Изменить на enum
        public string Manufacturer { get; set; } = string.Empty;
        public string SnDefinitionType { get; set; } = string.Empty;
        public int? NominalPower { get; set; }
        public int? MaximalPower { get; set; }
        public int? ChassisHeightInUnits { get; set; }
        //public List<ChassisData>? Chassis { get; set; }
        //public List<CardData>? Cards { get; set; }
        //public List<ModuleData>? Modules { get; set; }
        //public List<CableData>? Cables { get; set; }
        //public List<LicenseData>? Licenses { get; set; }

        public List<SpecDetailData>? SpecificationRecords { get; set; }

        //public List<InitialDetailRecordData>? InitialDetailRecords { get; set; }
    }
}
