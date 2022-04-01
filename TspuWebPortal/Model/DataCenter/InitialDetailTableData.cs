﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TspuWebPortal.Model
{
    public class InitialDetailTableData
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int InitialDetailTableId { get; set; }
        public int? FileId { get; set; }

        [ForeignKey("FileId")]
        public FileData? TableFile { get; set; }
        public DateOnly? RegisterDate { get; set; }
        public List<InitialDetailRecordData>? InitialDetailRecords { get; set; }
    }
}
