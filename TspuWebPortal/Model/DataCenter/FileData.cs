﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TspuWebPortal.Model
{
    public class FileData
    {
        [Key]
        public int FileId { get; set; }
        public string? FileName { get; set; } = string.Empty;        //enum
        public DateOnly? UploadDate { get; set; }
        public DateTimeOffset? LastChangeDate { get; set; }
        public string? FilePath { get; set; } = string.Empty;        //enum
        public List<InitialDetailTableData>? InitialDetailTables { get; set; }
        public List<InitialMaterialTableData>? InitialMaterialTables { get; set; }
    }
}
