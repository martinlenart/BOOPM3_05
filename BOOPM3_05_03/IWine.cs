using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BOOPM3_05_03
{
    interface IWine
    {
        string Name { get; set; }
        int Year { get; set; }
        decimal Price { get; set; }
        string ToString();
    }
}
