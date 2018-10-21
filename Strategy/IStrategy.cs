using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Nehavioral.Strategy
{
    /// <summary>
    /// Define your Strategies by impelementing this Interface
    /// </summary>
    public interface IStrategy
    {
        object DoAlgorithm(object data);
    }
}
