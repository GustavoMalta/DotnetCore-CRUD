using System;
using System.Collections.Generic;
using System.ComponentModel;
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
        [DisplayName("Nome Completo")]
        public string FullName { get; set; }

        [Column(TypeName = "varchar(20)",Order = 3)]
        [DisplayName("Telefone")]
        public string Phone { get; set; }

        [Column(TypeName = "varchar(10)")]
        [DisplayName("Cod. Emrpesa")]
        public string  EmpCode { get; set; }

        [Column(TypeName = "varchar(100)")]
        [DisplayName("Cargo")]
        public string position { get; set; }

        [Column(TypeName = "varchar(100)")]
        [DisplayName("Local Empresa")]
        public string OfficeLocation { get; set; }

        [DefaultValue("t")]
        [DisplayName("Ativo")]
        public bool Active { get; set; }

    }
}
