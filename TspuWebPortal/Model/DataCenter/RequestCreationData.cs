using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TspuWebPortal.Model
{
    public class RequestCreationData
    {
        [Key]
        public int RequestCreationId { get; set; }
        public OperationData? Operation { get; set; }
        public int OperationId { get; set; }
        public ChangeApplicationData? ChangeApplication { get; set; }

    }
}
