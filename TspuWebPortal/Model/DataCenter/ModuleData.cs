﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TspuWebPortal.Model
{
    public class ModuleData
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ModuleId { get; set; }
        public string? SnType { get; set; }
        public int? DeliveryYear { get; set; }
        public string? Comments { get; set; }
        public string? ModuleStatus { get; set; }
        public string? SerialNumber { get; set; }
        public string? CardSlotInChassisOrCard { get; set; }
        public string? CurrentLocation { get; set; }
        public int? InitialDetailRecordId { get; set; }
        public int? DetailChangeId { get; set; }
        public string? InventoryNumber { get; set; }
        public bool? IsInstalled { get; set; }
        public int? ServeroMesto { get; set; }
        public int? EntityModelId { get; set; }
        public EntityModelData? EntityModel { get; set; }
        public int? ChassisId { get; set; }
        public ChassisData? Chassis { get; set; }
        public int? CardId { get; set; }
        public CardData? Card { get; set; }
        public ChangeApplicationData? DetailChange { get; set; }
        public InitialDetailRecordData? InitialDetailRecord { get; set; }

        public string? PositionInUpperEntity { get; set; }

        public ModuleAData? ModuleA { get; set; }
        public ModuleBData? ModuleB { get; set; }

    }
}
