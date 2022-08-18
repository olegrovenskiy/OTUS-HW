using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using static TspuWebPortal.Model.ComponentEnums;

namespace TspuWebPortal.Model
{
    public class DetailRecordData
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int DetailRecordId { get; set; }
        public Submitter DetailOrigin { get; set; }        //enum
        public string? ContractNumber { get; set; } = "неизвестно";
        public string? ResponsiblePerson { get; set; }
        public string Comments { get; set; } = string.Empty;

        public int InitialDetailTableId { get; set; }
        [ForeignKey("InitialDetailTableId")]
        public DetailTableData? InitialDetailTable { get; set; }

        public string SerialNumber { get; set; } = string.Empty;
        public string DetailOfficialName { get; set; } = string.Empty;
        public string InventoryNumber { get; set; } = string.Empty;
        public string Location { get; set; } = string.Empty;
        public bool IsSplittable { get; set; } = false;


        public ICollection<DetailOperationData>? DetailOperations { get; set; }


        public bool IsSuccessfullyUploaded { get; set; } = false;

        public List<ChassisData>? Chassis { get; set; }
        public List<CardData>? Card { get; set; }
        public List<ModuleData>? Module { get; set; }
        public List<CableData>? Cables { get; set; }
        public List<LicenseData>? Licenses { get; set; }


        public int SpecDetailId { get; set; }
        [ForeignKey("SpecDetailId")]
        public SpecDetailData? SpecDetail { get; set; }                 //Нужно прогрузить в БД



        public bool IsVisibleInExcel { get; set; } = true;

        public int DeliveryYear { get; set; } = 2020;

        public bool IsExcludedFromPrint { get; set; }

    }
}
