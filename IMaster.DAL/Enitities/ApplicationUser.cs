using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMaster.DAL.Enitities
{
    public class ApplicationUser : IdentityUser
    {
        public virtual ExecutorProfile ExecutorProfile { get; set; }
        public virtual CustomerProfile CustomerProfile { get; set; }
    }
}
