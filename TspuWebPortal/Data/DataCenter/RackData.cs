using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace TspuWebPortal.Data
{
    public class RackData
    {
        [Key]
        public int RackId { get; set; }
        public string RackNameAsbi { get; set; } = string.Empty;
        public string RackNameDataCenter { get; set; } = string.Empty;
        public int RackHeight { get; set; }
        public int FreeServerSlotsQuantity { get; set; }
        public bool IsInstalled { get; set; }
        public int InstallationYear { get; set; }
        public string RackType { get; set; } = string.Empty;            //Изменить тип на enum (ИБ/серверная/другая)
        public int RowId { get; set; }
        public RowData? Room { get; set; }
        public List<UnitData>? Rows { get; set; }
    }
}
