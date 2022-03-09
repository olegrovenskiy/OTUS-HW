using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TspuWebPortal.Data
{
    public class RoomData
    {
        [Key]
        public int RoomId { get; set; }
        public string RoomName { get; set; } = string.Empty;
        public string RoomCoordinates { get; set; } = string.Empty;
        public int DataCenterId { get; set; }  
        public DataCenterData? DataCenter { get; set; }
        public List<RowData>? Rows { get; set; }

    }
}
