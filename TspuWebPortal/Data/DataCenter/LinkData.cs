using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TspuWebPortal.Data
{
    public class LinkData
    {
        [Key]
        public int LinkId { get; set; }

        public ModuleAData? ModuleA { get; set; }
        public ModuleBData? ModuleB { get; set; }
        public int ModuleAId { get; set; }
        public int ModuleBId { get; set; }

        public string VirtualPortA { get; set; } = string.Empty;
        public string VirtualPortB { get; set; } = string.Empty;
        public int CableId { get; set; }
        public CableData? Cable { get; set; }
        public string RdLinkId { get; set; } = string.Empty;
        public DateOnly CreationDate { get; set; }
        public bool IsNew { get; set; }
        public int DeliveryYear { get; set; }
        public int OperationId { get; set; }


    }
}
