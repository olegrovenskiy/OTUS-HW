using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TspuWebPortal.Model
{
    public class ServerLinkData
    {
        [Key]
        public int ServerLinkId { get; set; }
        public int ServerTypeId { get; set; }           // enum
        public int ServerSlotId { get; set; }
        public ServerSlotData? ServerSlots { get; set; }
    }
}
