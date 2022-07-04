using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TspuWebPortal.Model
{
    public class ChangeApplicationData
    {
        [Key]
        public int DetailChangeId { get; set; }
        public int JiraApplicationId { get; set; }
        public string ResponsiblePerson { get; set; } = string.Empty;
        public string ChangeReason { get; set; } = string.Empty;
        public string SnOldDetail { get; set; } = string.Empty;
        public string SnNewDetail { get; set; } = string.Empty;
        public string ApplicationStatus { get; set; } = string.Empty;
        public DateOnly CompleteChangeDate { get; set; }
        public bool IsInstalled { get; set; }
        //public List<CableData>? Cables { get; set; }
        //public List<CardData>? Cards { get; set; }
        //public List<ChassisData>? Chassis { get; set; }
        //public List<ModuleData>? Modules { get; set; }
        public RequestCreationData? RequestCreation { get; set; }
        public RequestCompletionData? RequestCompletion { get; set; }
        public int RequestCreationId { get; set; }
        public int RequestCompletionId { get; set; }
        
    }
}
