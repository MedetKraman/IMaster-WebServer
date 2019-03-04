using IMaster.DAL.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMaster.DAL.Enitities
{
    public class ExecutorProfile
    {
        [Key]
        [ForeignKey("ApplicationUser")]
        public string Id { get; set; }
        public virtual ApplicationUser ApplicationUser { get; set; }

        public string LastName { get; set; }
        public string FirstName { get; set; }
        public DateTime BirthDay { get; set; }
        public Gender Gender { get; set; }

        public int CityId { get; set; }
        public virtual City City { get; set; }

        public ExecutorType ExecutorType { get; set; }
    }
}
