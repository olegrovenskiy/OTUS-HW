using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TspuWebPortal.Data
{
    public class LicenseData
    {
        [Key]
        public int LicenseId { get; set; }
        public string SnType { get; set; } = string.Empty;
        public int DeliveryYear { get; set; }
        public string Comments { get; set; } = string.Empty;
        public string SerialNumber { get; set; } = string.Empty;
        public string Location { get; set; } = string.Empty;
        public int PrimaryRecordlId { get; set; }
        public int EntityModelId { get; set; }
        public EntityModelData? EntityModel { get; set; }
    }
}
