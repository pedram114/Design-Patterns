using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Nehavioral.State
{
    public abstract class Context
    {
        public State _state = null;
        public Context(State state)
        {
            _state = state;
        }
        /// <summary>
        /// it uses To transition between states
        /// </summary>
        /// <param name="state"></param>
        public void TransitionTo(State state) {
            this._state = state;
            _state.SetContext(this);
        }

        public void DefaultAction() {
            this._state.DoYourBusiness();

        }

        /// <summary>
        /// You can costomize yuur action
        /// </summary>
        public abstract void YourFirstAction();
        
   
    }
}
