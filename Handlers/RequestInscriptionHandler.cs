using System;
using System.Collections.Generic;
using System.Text;

namespace ChainResponsibilityDemo.Handlers
{
    /// <summary>
    /// The 'ConcreteHandler' class
    /// </summary>
    public class RequestInscriptionHandler : InscriptionHandler
    {
        public override void ProcessRequest(Request request)
        {
            if (request.Action == "I")
            {
                Console.WriteLine("El estudiante #{0} se ha inscrito satisfactoriamente a la actividad #{1}",
                    request.StudentID, request.ActivityID);
            }
            else if (successor != null)
            {
                successor.ProcessRequest(request);
            }
        }
    }
}
