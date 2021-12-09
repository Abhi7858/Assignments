using System;

namespace OfficeApplication
{
    public partial class TblEmployee
    {
        public int EmployeeId { get; set; }
        public string EmployeeName { get; set; }
        public string EmployeeAddress { get; set; }
        public string DepartmentName { get; set; }
        public int DepartmentId { get; set; }
        public <decimal> Salary { get; set; }
    }
}
