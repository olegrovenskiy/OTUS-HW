using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TspuWebPortal.Data
{
    public class InitialMaterialTableData
    {
        [Key]
        public int InitialMaterialTableId { get; set; }
        public FileData? TableFile { get; set; }
        public int FileId { get; set; }
        public List<InitialMaterialRecordData>? InitialMaterialRecords { get; set; }
    }
}
