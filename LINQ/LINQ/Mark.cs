using System.Collections;
using System.Collections.Generic;

namespace LINQ
{
    public class Mark : Entity
    {
        public string Name { get; set; }
        public ICollection<Car> Cars { get; set; }
    }
}