using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Nehavioral.Strategy
{
    public abstract class Context
    {
        private IStrategy _strategy;
        /// <summary>
        /// Default Data which is used by DoDefultAction Method
        /// </summary>
        public object Data { set; get; }
        public Context()
        {

        }
        public Context(IStrategy strategy)
        {
            _strategy = strategy;

        }
        public void SetStrategy(IStrategy strategy) {
            this._strategy = strategy;
        }
        /// <summary>
        /// Use DoDefaultAction or you can impelement the DoYourBusinessLogic method
        /// </summary>
        public void DoDefaultAction() {
            _strategy.DoAlgorithm(Data);
        }
        /// <summary>
        /// Override your business logic action 
        /// You can just call your action in Istrategy
        /// </summary>
        public abstract void DoYourBusinessLogic();
    }
}
