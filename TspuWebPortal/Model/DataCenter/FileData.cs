using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TspuWebPortal.Model
{
    public class FileData
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int FileId { get; set; }
        public string? FileName { get; set; }        //enum
        public DateOnly? UploadDate { get; set; }
        public DateOnly? LastChangeDate { get; set; }
        public string? FilePath { get; set; }        //enum
        public string? FileCategory { get; set; }
        public bool? IsAppliedToTable { get; set; }
        public List<DetailTableData>? InitialDetailTables { get; set; }
        public List<MaterialTableData>? InitialMaterialTables { get; set; }
    }
}
