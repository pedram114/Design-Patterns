using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Nehavioral.State
{
    public abstract class State
    {
        protected Context context;
        public void SetContext(Context context) {
            this.context = context;
        }
        /// <summary>
        /// This function use for doing your business in the state which has implemented State Class
        /// </summary>
        public abstract void DoYourBusiness();
    }
}
