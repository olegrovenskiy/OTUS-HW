using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TspuWebPortal.Model
{
    public class LicenseData
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int LicenseId { get; set; }
        public string SnType { get; set; } = string.Empty;
        public int DeliveryYear { get; set; }
        public string Comments { get; set; } = string.Empty;
        public string SerialNumber { get; set; } = string.Empty;
        public string Location { get; set; } = string.Empty;

        //public int EntityModelId { get; set; }
        //public EntityModelData? EntityModel { get; set; }
        
        public int InitialDetailRecordId { get; set; }
        public DetailRecordData? InitialDetailRecord { get; set; }
    }
}
