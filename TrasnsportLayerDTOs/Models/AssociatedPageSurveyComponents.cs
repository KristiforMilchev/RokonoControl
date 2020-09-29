﻿using System;
using System.Collections.Generic;

namespace  TransportLayer.Models
{
    public partial class AssociatedPageSurveyComponents
    {
        public int Id { get; set; }
        public int? ComponentId { get; set; }
        public int? PageId { get; set; }
        public string DataSource { get; set; }
        public string Question { get; set; }

        public virtual SurveyComponent Component { get; set; }
        public virtual SurveyPage Page { get; set; }
    }
}
