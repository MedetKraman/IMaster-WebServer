using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMaster.DAL.Enitities
{
    public class CustomerProfile
    {
        [Key]
        [ForeignKey("ApplicationUser")]
        public string Id { get; set; }
        public virtual ApplicationUser ApplicationUser { get; set; }
        
        public string FirstName { get; set; }
        
        public int CityId { get; set; }
        public virtual City City { get; set; }

        public string PhoneNumber { get; set; }
        public string AvatarUrl { get; set; }
    }
}
