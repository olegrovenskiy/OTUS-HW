using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TspuWebPortal.Model
{
    public class RowData
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int RowId { get; set; }
        public string? RowNameAsbi { get; set; } = string.Empty;
        public string? RowNameDataCenter { get; set; } = string.Empty;
        public int? RoomId { get; set; }
        public virtual RoomData? Room { get; set; }
        public List<RackData>? Racks { get; set; }
    }
}
