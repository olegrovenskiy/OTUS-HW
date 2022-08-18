using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TspuWebPortal.Model
{
    public class MaterialModelData
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int MaterialEntityModelId { get; set; }

        public string MaterialModelName { get; set; } = string.Empty;

        public string MaterialModelType { get; set; } = string.Empty;

        public string Comments { get; set; } = string.Empty;

        public ICollection<MaterialStorageData>? MaterialStorageItems { get; set; }

    }
}
