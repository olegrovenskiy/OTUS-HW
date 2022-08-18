using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TspuWebPortal.Model
{
    public class RequestCompletionData
    {
        [Key]
        public int RequestCompletionId { get; set; }
        public OperationSummaryData? Operation { get; set; }
        public int OperationId { get; set; }
        public ChangeApplicationData? ChangeApplication { get; set; }
    }
}
