namespace Skyline.StaffTracking.Management
{
    public class MasterModel
    {
        public int Id { get; set; }
        public string DictionaryType { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public string GroupId { get; set; }
        public bool IsActive { get; set; }
    }
}
