using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TspuWebPortal.Model
{
    public class ModuleBData
    {
        [Key]
        public int ModuleBId { get; set; }
        public int ModuleId { get; set; }

        public ModuleData? Module { get; set; }
        public LinkData? Link { get; set; }

    }
}
