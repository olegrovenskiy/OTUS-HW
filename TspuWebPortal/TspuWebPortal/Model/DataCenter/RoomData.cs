using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TspuWebPortal.Model
{
    public class RoomData
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int RoomId { get; set; }
        public string? RoomName { get; set; } = string.Empty;
        public string? RoomCoordinates { get; set; } = string.Empty;
        public int? DataCenterId { get; set; }  
        public virtual DcData? DataCenter { get; set; }
        public List<RowData>? Rows { get; set; }

    }
}
