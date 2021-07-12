using System;
using System.Collections.Generic;
using System.Text;

namespace ChainResponsibilityDemo.Handlers
{
    /// <summary>
    /// The 'ConcreteHandler' class
    /// </summary>
    public class RequestConfirmationHandler : InscriptionHandler
    {
        public override void ProcessRequest(Request request)
        {
            if (request.Action == "C")
            {
                Console.WriteLine("Se le han acreditado las horas de la actividad #{0} al estudiante #{1}",
                    request.ActivityID, request.StudentID);
            }
            else
            {
                Console.WriteLine("400 Bad request");
            }
        }
    }
}
