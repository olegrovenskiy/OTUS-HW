
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TspuWebPortal.Model
{
    public class DetailOperationData
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int DetailOperationId { get; set; }

        public string OperationSubtype { get; set; } = string.Empty;

        public int DetailRecordId { get; set; }
        [ForeignKey("DetailRecordId")]
        public DetailRecordData? DetailRecord { get; set; }

        public int GlobalOperationId { get; set; }
        [ForeignKey("GlobalOperationId")]
        public OperationSummaryData? GlobalOperation { get; set; }

    }
}
