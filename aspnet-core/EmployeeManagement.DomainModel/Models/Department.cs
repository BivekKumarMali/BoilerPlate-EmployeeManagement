using System;
using System.Collections.Generic;
using System.Text;
using Abp.Domain.Entities.Auditing;

namespace EmployeeManagement.DomainModel
{
    public class Department : AuditedEntity<Guid>
    {
        public string Name { get; set; }
    }
}
