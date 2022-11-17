using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EfCoreGroupByOwnedTest6
{
    public class Item
    {
        public int ItemId { get; set; }

        public string Name { get; set; }

        public string Group { get; set; }

        public DataValue Set1 { get; set; } = new ();
        public DataValue Set2 { get; set; } = new();
        public DataValue Set3 { get; set; } = new();

        public int CategoryId { get; set; }

        public Category Category { get; set; }

    }
}
