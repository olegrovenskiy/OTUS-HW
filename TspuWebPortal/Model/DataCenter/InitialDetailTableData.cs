using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TspuWebPortal.Model
{
    public class InitialDetailTableData
    {
        [Key]
        public int InitialDetailTableId { get; set; }
        public FileData? TableFile { get; set; }
        public int FileId { get; set; }
        public List<InitialDetailRecordData>? InitialDetailRecords { get; set; }
    }
}
