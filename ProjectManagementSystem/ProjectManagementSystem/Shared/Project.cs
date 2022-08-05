using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectManagementSystem.Shared
{
    public class Project
    {
        [Key]
        public Guid Id { get; set; }

        [Required]
        public string Name { get; set; }
        [Required]
        public DateTime StartDate { get; set; }
        public Nullable<DateTime> EndDate { get; set; }
        public Nullable<DateTime> Deadline { get; set; }

        public ICollection<ProjectUser> ProjectUsers { get; set; }
        public ICollection<Ticket> Tickets { get; set; }

        [Required]
        [ForeignKey("Company")]
        public Guid CompanyId { get; set; }
        public Company Company { get; set; }
    }
}
