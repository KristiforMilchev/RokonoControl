﻿using System;
using System.Collections.Generic;

namespace TransportLayer.Models
{
    public partial class AssocatedUserChatRights
    {
        public int Id { get; set; }
        public int? UserId { get; set; }
        public int? RightId { get; set; }
        public int? ProjectId { get; set; }

        public virtual Projects Project { get; set; }
        public virtual ChatRoomRights Right { get; set; }
        public virtual UserAccounts User { get; set; }
    }
}
