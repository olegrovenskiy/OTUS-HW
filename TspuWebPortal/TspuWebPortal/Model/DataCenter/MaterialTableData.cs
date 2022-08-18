using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TspuWebPortal.Model
{
    public class MaterialTableData
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int InitialMaterialTableId { get; set; }
        public int? FileId { get; set; }

        [ForeignKey("FileId")]
        public FileData? TableFile { get; set; }

        public DateOnly? RegisterDate { get; set; }

        public ICollection<MaterialTableStorageLink>? TableStorageLinks { get; set; }
    }
}
