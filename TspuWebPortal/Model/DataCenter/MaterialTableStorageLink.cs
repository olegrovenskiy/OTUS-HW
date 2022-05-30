

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TspuWebPortal.Model
{
    public class MaterialTableStorageLink
    {
        //[Key] 
        public int MaterialStorageItemId { get; set; }
        public MaterialStorageData MaterialStorageData { get; set; }
        
        //[Key] 
        public int InitialMaterialTableId { get; set; }
        public InitialMaterialTableData InitialMaterialTableData { get; set; }
    }
}
