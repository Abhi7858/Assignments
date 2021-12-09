using System.Collections.Generic;

namespace OfficeApplication
{
    public class Office
    {
        public int OfficeId { get; set; }
        public string OfficeName { get; set; }
        public string OfficeAddress { get; set; }
        List<Department> Departments { get; set; }
        public Office()
        {
          departments=  new List<Department>();
        }
    }
}
