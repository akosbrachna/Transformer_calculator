using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Transformer_calculator
{
    interface ICalculate
    {
        Result do_calculation(Input input);
    }
}
