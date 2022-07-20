
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TspuWebPortal.Model
{
    public class MaterialOperationData
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int MaterialOperationId { get; set; }

        public string OperationSubtype { get; set; } = string.Empty;

        public int StorageItemId { get; set; }
        [ForeignKey("StorageItemId")]
        public MaterialStorageData? MaterialModel { get; set; }

        public int GlobalOperationId { get; set; }
        [ForeignKey("GlobalOperationId")]
        public OperationSummaryData? GlobalOperation { get; set; }

        public ICollection<MaterialTableStorageLink>? TableStorageLinks { get; set; }
        //public MaterialTableStorageLink? TableStorageLink { get; set; }                   //Зачем коллекция если один к одному? Прочитать инструкцию.



    }
}
