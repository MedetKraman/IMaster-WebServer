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
        public ExecutorProfile()
        {
            ExecutorServices = new HashSet<ExecutorService>();
        }

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
        public string AvatarUrl { get; set; }
        public double Rating { get; set; }
        public int ClosedOrderCount { get; set; }
        public DateTime RegistrationDateTime { get; set; }
        public string Status { get; set; }
        public bool DocumentsVerified { get; set; }
        public string CategoriesAndSpecializations { get; set; }
        public int Age { get; set; }
        public string PhoneNumber { get; set; }
        public string Reviews { get; set; }
        public string ServicesPrices { get; set; }
        public string YouTubeVideoUrl { get; set; }

        public ICollection<ExecutorService> ExecutorServices { get; set; }
    }
}
