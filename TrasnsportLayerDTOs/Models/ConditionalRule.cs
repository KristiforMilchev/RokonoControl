using System.Collections.Generic;

namespace  TransportLayer.Models
{
    public class ConditionalRule
    {
        public string condition { get; set; }
        public List<ObjectRule> Rules { get; set; }
    }
}