using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TspuWebPortal.Model
{
    public class InitialMaterialRecordData
    {
        [Key]
        public int InitialMaterialId { get; set; }
        public int InitialMaterialTableId { get; set; }
        public InitialMaterialTableData? InitialMaterialTable { get; set; }
        public string DocumentNumber { get; set; } = string.Empty;
        public string MaterialOfficialName { get; set; } = string.Empty;
        public int Quantity { get; set; }
        public string Location { get; set; } = string.Empty;
        public DateOnly DeliveryDate { get; set; }
        public int OperationId { get; set; }
        public OperationData? Operation { get; set; }

    }
}
