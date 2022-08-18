
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TspuWebPortal.Model
{
    public class MaterialStorageData
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int StorageItemId { get; set; }
        
        //[Key]
        public int DeliveryYear { get; set; }

        public string MaterialSpecificationName { get; set; } = string.Empty;
        public int TakenQuantity { get; set; }
        public int CurrentQuantity { get; set; }
        public int InstalledQuantity { get; set; }

        public int MaterialEntityModelId { get; set; }
        [ForeignKey("MaterialEntityModelId")]
        public MaterialModelData? MaterialModel { get; set; }

        public int DataCenterId { get; set; }
        [ForeignKey("DataCenterId")]
        public DcData? DataCenter { get; set; }

        public ICollection<MaterialOperationData>? MaterialOperations { get; set; }

        public ICollection<MaterialTableStorageLink>? TableStorageLinks { get; set; }
        //public MaterialTableStorageLink? TableStorageLink { get; set; }                   //Зачем коллекция если один к одному? Прочитать инструкцию.



    }
}
