using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TspuWebPortal.Model
{
    public class ModuleAData
    {
        [Key]
        public int ModuleAId { get; set; }
        public int ModuleId { get; set; }
        public ModuleData? Module { get; set; }
        public LinkData? Link { get; set; }

    }
}
