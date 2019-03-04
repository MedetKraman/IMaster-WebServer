﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMaster.DAL.Enitities
{
    public class City
    {
        public City()
        {
            CityLangs = new HashSet<CityLang>();
            UserProfiles = new HashSet<ExecutorProfile>();
        }

        public int Id { get; set; }

        public ICollection<CityLang> CityLangs { get; set; }
        public ICollection<ExecutorProfile> UserProfiles { get; set; }
    }
}
