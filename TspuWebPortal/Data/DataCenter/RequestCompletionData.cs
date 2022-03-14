using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TspuWebPortal.Data
{
    public class RequestCompletionData
    {
        [Key]
        public int RequestCompletionId { get; set; }
        public OperationData? Operation { get; set; }
        public int OperationId { get; set; }
        public ChangeApplicationData? ChangeApplication { get; set; }
    }
}
