using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace EMS.Models
{
    public class Employee
    {
        [Key]
        public int EmployeeID { get; set; }
        [Required]
        [Column(TypeName = "nvarchar(250)")]
        public string FullName { get; set; }
        [Column(TypeName = "varchar(100)")]
        public string EmpCode { get; set; }
        [Column(TypeName = "varchar(10)")]
        public string Postion { get; set; }
        [Column(TypeName = "varchar(100)")]
        public string OfficeLocation { get; set; }
    }
}
