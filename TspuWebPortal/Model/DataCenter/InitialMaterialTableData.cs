using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TspuWebPortal.Model
{
    public class InitialMaterialTableData
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int InitialMaterialTableId { get; set; }
        public FileData? TableFile { get; set; }
        public int FileId { get; set; }
        public List<InitialMaterialRecordData>? InitialMaterialRecords { get; set; }
    }
}
