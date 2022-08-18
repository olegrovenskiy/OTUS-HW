using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace TspuWebPortal.Model
{
    public class DcData
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int DataCenterId { get; set; }
        public string? DataCenterName { get; set; } = string.Empty;
        public string? DataCenterAddress { get; set;} = string.Empty;
        public List<RoomData>? Rooms { get; set; }
        public ICollection<MaterialStorageData>? MaterialStorageItems { get; set; }
    }
}
