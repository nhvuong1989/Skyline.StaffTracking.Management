namespace Skyline.StaffTracking.Management
{
    public class RestaurantModel
    {
        public int Id { get; set; }
        public string RestaurantId { get; set; }
        public string RestaurantName { get; set; }
        public int RestaurantType { get; set; }
        public string RestaurantAddress { get; set; }
        public bool IsActive { get; set; }
        public string ProviceId { get; set; }
        public string ShiftWork { get; set; }
    }
}
