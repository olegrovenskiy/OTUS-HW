using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace TspuWebPortal.Model
{
    public class RackData
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int RackId { get; set; }
        public string? RackNameAsbi { get; set; }
        public string? RackNameDataCenter { get; set; }
        public int? RackHeight { get; set; }
        public int? FreeServerSlotsQuantity { get; set; }
        public bool IsInstalled { get; set; }
        public int? InstallationYear { get; set; }
        public string? RackType { get; set; }           //Изменить тип на enum (ИБ/серверная/другая)
        public int? RowId { get; set; }

        [ForeignKey("RowId")]
        public RowData? Row { get; set; }
        public List<UnitData>? Units { get; set; }
    }
}
