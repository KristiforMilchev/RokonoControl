﻿using System;
using System.Collections.Generic;

namespace TransportLayer.Models
{
    public partial class WorkItemMessage
    {
        public WorkItemMessage()
        {
            AssociatedWorkItemMessages = new HashSet<AssociatedWorkItemMessages>();
        }

        public int Id { get; set; }
        public int SenderId { get; set; }
        public string Content { get; set; }
        public DateTime? DateOfMessage { get; set; }

        public virtual UserAccounts Sender { get; set; }
        public virtual ICollection<AssociatedWorkItemMessages> AssociatedWorkItemMessages { get; set; }
    }
}
