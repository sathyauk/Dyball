using System;
using System.Collections.Generic;
using System.Text;

namespace Dyball.Domain
{
    public class BaseAnimal
    {
        public double FeedValue { get; set; }
        public bool IsLive { get; set; }
        public bool CanWalk { get; set; }
    }
}
