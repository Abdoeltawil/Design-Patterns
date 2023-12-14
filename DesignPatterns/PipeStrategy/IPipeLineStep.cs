using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.PipeStrategy
{
    internal interface IPipeLineStep
    {
        Burger Execute(IPipeLineContext context);
    }
}
