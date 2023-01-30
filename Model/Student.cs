using Student_WEB_API.Data;
using System.ComponentModel.DataAnnotations;

namespace Student_WEB_API.Model
{
    public class Student
    {
        public string Name { get; set; }
        [Key]
        public int Roll_No { get; set; }
        public string Father_Name { get; set; }
        public string Mother_Name { get; set; }
        //public Address Address { get; set; }
        public int House_No { get; set; }
        public string City { get; set; }
        public string Region { get; set; }
        public int PostalCode { get; set; }
        public string Country { get; set; }

        public int Contact { get; set; }
         

    }
}
