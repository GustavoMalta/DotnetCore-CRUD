using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace DotnetCRUD.Models
{
    public class Employee
    {
        [Key]
        public int EmployeeId { get; set; }

        [Column(TypeName ="varchar(250)")]
        [Required]
        public string FullName { get; set; }

        [Column(TypeName = "varchar(20)")]
        public string Phone { get; set; }

        [Column(TypeName = "varchar(10)")]
        public string  EmpCode { get; set; }

        [Column(TypeName = "varchar(100)")]
        public string position { get; set; }

        [Column(TypeName = "varchar(100)")]
        public string OfficeLocation { get; set; }

        


    }
}
