namespace TspuWebPortal.Model
{
    public class OuterChassisData
    {
        public string SerialNumber { get; set; }
        //public int ItemNumber { get; set; }
        public string Description { get; set; }
        public string Type { get; set; }
        public string FactoryNumber { get; set; }
        public string Hostname { get; set; }
        public string InventoryNumber { get; set; }
        public string Comments { get; set; }
        public string Rack { get; set; }
        public int LowerUnit { get; set; }
        public int ChassisHeight { get; set; }
        public int Quantity { get; set; }
        public string DefinitionType { get; set; }
        public int Year { get; set; }
        public string DataCenter { get; set; }
        public string RoomName { get; set; }
        public string RowName { get; set; }
        public bool IsOnFront { get; set; }
        public List<InnerChassisData>? InnerChassisDataList { get; set; }
    }
}
