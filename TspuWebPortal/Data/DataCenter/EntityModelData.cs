using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TspuWebPortal.Data
{
    public class EntityModelData
    {
        [Key]
        public int EntityModelId { get; set; }
        public string ModelName { get; set; } = string.Empty;
        public string PartNumber { get; set; } = string.Empty;
        public string ModelType { get; set; } = string.Empty;           //Изменить на enum
        public string Vendor { get; set; } = string.Empty;
        public int NominalPower { get; set; }
        public int MaximalPower { get; set; }
        public List<ChassisData>? Chassis { get; set; }
        public List<CardData>? Cards { get; set; }
        public List<ModuleData>? Modules { get; set; }
        public List<CableData>? Cables { get; set; }
        public List<LicenseData>? Licenses { get; set; }
    }
}
