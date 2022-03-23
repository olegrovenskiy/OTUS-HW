using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TspuWebPortal.Model
{
    public class ServerSlotData
    {
        [Key]
        public int ServerSlotId { get; set; }
        public int UnitId { get; set; }
        public string SlotIndex { get; set; } = string.Empty;
        public List<UnitData>? Units { get; set; }
        public List<ServerLinkData>? ServerLinks { get; set; }

    }
}
