﻿using System;
using System.Collections.Generic;

namespace  TransportLayer.Models
{
    public partial class AssociatedProjectBuilds
    {
        public int Id { get; set; }
        public int? RepositoryId { get; set; }
        public int? BuildId { get; set; }
        public int? ProjectId { get; set; }

        public virtual Builds Build { get; set; }
        public virtual Projects Project { get; set; }
        public virtual Repository Repository { get; set; }
    }
}
