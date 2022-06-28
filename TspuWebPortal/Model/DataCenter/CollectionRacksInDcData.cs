namespace TspuWebPortal.Model
{
    public class AllRacksInDcData
    {
        public List<OuterChassisData>? FullSingleRackData { get; set; }
        public string RackAsbiName { get; set; } = string.Empty;
        public string RackDcName { get; set; } = string.Empty;
    }
}
