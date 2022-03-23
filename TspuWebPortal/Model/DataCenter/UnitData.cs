using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TspuWebPortal.Model
{
    public class UnitData
    {
        [Key]
        public int UnitId { get; set; }
        public int UnitInRack { get; set; }
        public bool IsFront { get; set; }
        public string RowNameAsbi { get; set; } = string.Empty;
        public string RowNameDataCenter { get; set; } = string.Empty;
        public int ChassisId { get; set; }
        public ChassisData? Chassis { get; set; }
        public int ServerSlotId { get; set; }
        public ServerSlotData? ServerSlot { get; set; }
        public int RackId { get; set; }
        public RackData? Rack { get; set; }

    }
}