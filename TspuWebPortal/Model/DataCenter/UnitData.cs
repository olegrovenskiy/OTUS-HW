using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TspuWebPortal.Model
{
    public class UnitData
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int UnitId { get; set; }
        public int? UnitInRack { get; set; }
        public bool? IsFront { get; set; }

        public int? ChassisId { get; set; }
        [ForeignKey("ChassisId")]
        public ChassisData? Chassis { get; set; }

        
        public int? ServerSlotId { get; set; }
        [ForeignKey("ServerSlotId")]
        public ServerSlotData? ServerSlot { get; set; }

        public int? RackId { get; set; }
        [ForeignKey("RackId")]
        public RackData? Rack { get; set; }

    }
}