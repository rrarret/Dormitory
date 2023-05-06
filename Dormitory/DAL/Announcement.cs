﻿using System;
using System.Collections.Generic;

namespace Dormitory.DAL
{
    public partial class Announcement
    {
        public Announcement()
        {
            Applications = new HashSet<Application>();
        }

        public int Id { get; set; }
        public string Title { get; set; } = null!;
        public string Description { get; set; } = null!;
        public DateTime PublishedDate { get; set; }
        public bool? IsActive { get; set; }

        public virtual ICollection<Application> Applications { get; set; }
    }
}
