
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TspuWebPortal.Model
{
    public class MaterialStorageData
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int MaterialStorageItemId { get; set; }
        public string? ItemName { get; set; }
        public int? TakenQuantity { get; set; }
        public int? CurrentQuantity { get; set; }
        public List<InitialMaterialRecordData>? InitialMaterialRecords { get; set; }


        public ICollection<MaterialTableStorageLink>? TableStorageLinks { get; set; }



    }
}
