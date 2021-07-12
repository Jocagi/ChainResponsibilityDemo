using System;
using System.Collections.Generic;
using System.Text;

namespace ChainResponsibilityDemo.Handlers
{
    /// <summary>
    /// The 'Handler' abstract class
    /// </summary>
    public abstract class InscriptionHandler
    {
        protected InscriptionHandler successor;
        public void SetSuccessor(InscriptionHandler successor)
        {
            this.successor = successor;
        }
        public abstract void ProcessRequest(Request request);
    }
}
