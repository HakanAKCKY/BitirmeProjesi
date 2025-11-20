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
        /// <summary>
        ///     Sorunun başlığı
        /// </summary>
        public string Description { get; set; }
        /// <summary>
        ///     sorunun detaylı açıklaması
        /// </summary>
        public IssueStatus Status { get; set; }
        /// <summary>
        ///     sorunun mevcut durumu, IssueStatus enumundan gelir.
        /// </summary>

        public int? EmployeeId { get; set; }
        /// <summary>
        ///     Bu sorunla ilgilenen çalışan (Employee) id’sini tutar. Int? nullable olduğu için bu sorunun henüz atanmış bir çalışanı olmayabilir.
        /// </summary>
        public Employee Employee { get; set; }
        /// <summary>
        ///     Bu sorunla ilgilenen çalışan (Employee) nesnesini tutar.
        /// </summary>
    }

}
