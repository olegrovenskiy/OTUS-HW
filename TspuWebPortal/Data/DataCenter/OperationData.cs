﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TspuWebPortal.Data
{
    public class OperationData
    {
        [Key]
        public int OperationId { get; set; }
        public DateOnly OperationDate { get; set; }
        public string OperationType { get; set; } = string.Empty;
        public int AccountId { get; set; }
        public UserListData? UserList { get; set; }
        public RequestCreationData? RequestCreation { get; set; }
        public RequestCompletionData? RequestCompletion { get; set; }
        public List<InitialDetailRecordData>? InitialDetailRecord { get; set; }
        public List<InitialMaterialRecordData>? InitialMaterialRecord { get; set; }


    }
}
