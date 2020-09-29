﻿using System;
using System.Collections.Generic;

namespace  TransportLayer.Models
{
    public partial class WorkItemAreas
    {
        public WorkItemAreas()
        {
            WorkItem = new HashSet<WorkItem>();
        }

        public int Id { get; set; }
        public string AreaName { get; set; }

        public virtual ICollection<WorkItem> WorkItem { get; set; }
    }
}
