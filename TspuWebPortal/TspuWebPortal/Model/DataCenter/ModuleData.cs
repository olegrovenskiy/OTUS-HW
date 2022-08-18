using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TspuWebPortal.Model
{
    public class ModuleData
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ModuleId { get; set; }

        public string Comments { get; set; } = string.Empty;


        public bool IsInstalled { get; set; } = true;

        public int? ChassisId { get; set; }
        public ChassisData? Chassis { get; set; }

        public int? CardId { get; set; }
        public CardData? Card { get; set; }

        public int InitialDetailRecordId { get; set; }
        public DetailRecordData? InitialDetailRecord { get; set; }

        public int HydraEndNumber { get; set; }

        public string PositionInUpperEntity { get; set; } = string.Empty ;

        public ModuleAData? ModuleA { get; set; }
        public ModuleBData? ModuleB { get; set; }

    }
}
