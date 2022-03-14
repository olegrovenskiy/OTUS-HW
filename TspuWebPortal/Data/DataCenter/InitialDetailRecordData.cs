using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TspuWebPortal.Data
{
    public class InitialDetailRecordData
    {
        [Key]
        public int InitialDetailRecordId { get; set; }
        public string DetailOrigin { get; set; } = string.Empty;        //enum
        public int InitialDetailTableId { get; set; }
        public InitialDetailTableData? InitialDetailTable { get; set; }
        public string DocumentNumber { get; set; } = string.Empty;
        public string ResponsiblePerson { get; set; } = string.Empty;
        public string SerialNumber { get; set; } = string.Empty;
        public string DetailOfficialName { get; set; } = string.Empty;
        public int Quantity { get; set; }
        public string Location { get; set; } = string.Empty;
        public DateOnly DeliveryDate { get; set; }
        public string Category { get; set; } = string.Empty; //string
        public bool IsSplittable { get; set; }
        public int OperationId { get; set; }
        public OperationData? Operation { get; set; }
        public bool IsSuccessfullyUploaded { get; set; }
        public List<ChassisData>? Chassis { get; set; }
        public List<CardData>? Card { get; set; }
        public List<ModuleData>? Module { get; set; }
        public List<CableData>? Cables { get; set; }
        public List<LicenseData>? Licenses { get; set; }

        

    }
}
