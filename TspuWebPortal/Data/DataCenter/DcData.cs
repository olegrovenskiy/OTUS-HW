using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace TspuWebPortal.Data
{
    public class DcData
    {
        [Key]
        public int DataCenterId { get; set; }
        public string DataCenterName { get; set; } = string.Empty;
        public string DataCenterAddress { get; set;} = string.Empty;
        public List<RoomData>? Rooms { get; set; }
    }
}
