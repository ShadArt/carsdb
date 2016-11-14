using Cars.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cars.UI
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var c = new Context())
            {
                var temp = c.Manufacturers.ToList();
            }
        }
    }
}
