using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TspuWebPortal.Data
{
    public class RowData
    {
        [Key]
        public int RowId { get; set; }
        public string RowNameAsbi { get; set; } = string.Empty;
        public string RowNameDataCenter { get; set; } = string.Empty;
        public int RoomId { get; set; }
        public RoomData? Room { get; set; }
        public List<RackData>? Rows { get; set; }
    }
}
