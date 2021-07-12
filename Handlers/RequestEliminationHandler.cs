using System;
using System.Collections.Generic;
using System.Text;

namespace ChainResponsibilityDemo.Handlers
{
    /// <summary>
    /// The 'ConcreteHandler' class
    /// </summary>
    public class RequestEliminationHandler : InscriptionHandler
    {
        public override void ProcessRequest(Request request)
        {
            if (request.Action == "E")
            {
                Console.WriteLine("El estudiante #{0} se ha eliminado de la actividad #{1}",
                    request.StudentID, request.ActivityID);
            }
            else if (successor != null)
            {
                successor.ProcessRequest(request);
            }
        }
    }
}
