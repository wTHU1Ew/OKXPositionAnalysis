using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OKX_PA
{
    abstract class Coin
    {
        abstract protected string Name
        {
            set;get;
        }
        abstract protected double value
        {
            set;get;
        }
        abstract protected DateTime time
        {
            set;get;
        }
    }
}
