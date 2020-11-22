using Abp.Domain.Entities.Auditing;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using EmployeeManagement.Authorization.Users;

namespace EmployeeManagement.DomainModel
{
    public class Employee
    {
        [Key]
        [ForeignKey("Id")]
        public User User { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string Qualification { get; set; }
        public long ContactNumber { get; set; }
        [ForeignKey("Did")]
        public Department Department { get; set; }
    }
}
