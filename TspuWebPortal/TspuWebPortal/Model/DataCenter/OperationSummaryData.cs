using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TspuWebPortal.Model
{
    public class OperationSummaryData
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int GlobalOperationId { get; set; }
        public DateOnly? OperationDate { get; set; }
        public string? OperationType { get; set; } = string.Empty;
        public int? AccountId { get; set; }
        public UserListData? UserList { get; set; }
        public RequestCreationData? RequestCreation { get; set; }
        public RequestCompletionData? RequestCompletion { get; set; }
        public MaterialOperationData? MaterialOperation { get; set; }
        public DetailOperationData? DetailOperation { get; set; }

        //public List<DetailRecordData>? InitialDetailRecord { get; set; }
        //public List<InitialMaterialRecordData>? InitialMaterialRecord { get; set; }
        //public MaterialStorageData? MaterialItem { get; set; }
    }
}
