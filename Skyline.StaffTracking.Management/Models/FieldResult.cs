using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Skyline.StaffTracking.Management
{
    public class FieldResult
    {
        [Description("Id")]
        public int RestaurantFieldId { get; set; }
        [Description("Mã nhân viên")]
        public string EmployeeId { get; set; }
        [Description("Tên nhân viên")]
        public string EmployeeName { get; set; }
        [Description("Số điện thoại")]
        public string PhoneNumber { get; set; }
        [Description("Ghi chú")]
        public string Comment { get; set; }
        [Description("Thời gian bắt đầu")]
        public DateTime StartTime { get; set; }
        [Description("Thời gian kết thúc")]
        public DateTime EndTime { get; set; }
        [Description("Hoàn thành")]
        public bool IsComplete { get; set; }
        [Description("Quãng đường đi")]
        public double Distance { get; set; }
        [Description("Tỉnh thành")]
        public string LocationName { get; set; }
        [Description("Ca làm việc")]
        public string ShiftWork { get; set; }

    }
}
