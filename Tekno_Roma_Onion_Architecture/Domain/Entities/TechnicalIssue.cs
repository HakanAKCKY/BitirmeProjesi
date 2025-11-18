using Domain.Entities.Teknoroma.Domain.Common;
using Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class TechnicalIssue : BaseEntity
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public IssueStatus Status { get; set; }

        public int? EmployeeId { get; set; }
        public Employee Employee { get; set; }
    }

}
