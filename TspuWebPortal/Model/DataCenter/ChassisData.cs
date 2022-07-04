using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TspuWebPortal.Model
{
    public class ChassisData
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ChassisId { get; set; }
        //public string? SnType { get; set; } = string.Empty;                         //Тут не нужно, только в первичных записях
        public string ChassisStatus { get; set; } = string.Empty;                   //Немзвестно для чего
        //public string? SerialNumber { get; set; } = string.Empty;                   //Тут не нужно, только в первичных записях

        public string Hostname { get; set; } = string.Empty;
        //public string? CurrentLocation { get; set; } = string.Empty;                //Тут не нужно, только в первичных записях
        //public bool IsInstalled { get; set; }                                          //Убрать

        
        //public string? InventoryNumber { get; set; } = string.Empty;                //Тут не нужно, только в первичных записях
        //public int? DeliveryYear { get; set; }                                      //Тут не нужно, только в первичных записях
        
        public string Comments { get; set; } = string.Empty;


        //public string? PositionInUpperEntity { get; set; }                          //Тут не нужно, только для вставных позиций

        //public int? EntityModelId { get; set; }                                     //Тут не нужно, только в первичных записях
        //[ForeignKey("EntityModelId")]
        //public EntityModelData? EntityModel { get; set; }

        public List<UnitData>? Units { get; set; }
        public List<CardData>? Cards { get; set; }
        public List<ModuleData>? Modules { get; set; }

       // public int? DetailChangeId { get; set; }                                    //Связку в обратном направлении
       // [ForeignKey("DetailChangeId")]
       // public ChangeApplicationData? DetailChange { get; set; }

        public int InitialDetailRecordId { get; set; }
        [ForeignKey("InitialDetailRecordId")]
        public InitialDetailRecordData? InitialDetailRecord { get; set; }
    }
}
