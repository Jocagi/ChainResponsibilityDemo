using System;
using ChainResponsibilityDemo.Handlers;

namespace ChainResponsibilityDemo
{

    /// <summary>
    /// Chain of Responsibility Design Pattern
    /// </summary>
    public class Program
    {
        public static void Main(string[] args)
        {
            // Configurar Chain of Responsibility
            RequestInscriptionHandler requestInscriptionHandler = new RequestInscriptionHandler();
            RequestEliminationHandler requestEliminationHandler = new RequestEliminationHandler();
            RequestConfirmationHandler requestConfirmationHandler = new RequestConfirmationHandler();
            requestInscriptionHandler.SetSuccessor(requestEliminationHandler);
            requestEliminationHandler.SetSuccessor(requestConfirmationHandler);

            // Generar y procesar solicitud #1
            Request r1 = new Request(1064718, 6156568489948, "I");
            requestInscriptionHandler.ProcessRequest(r1);

            // Generar y procesar solicitud #2
            Request r2 = new Request(1215718, 5566623484872, "I");
            requestInscriptionHandler.ProcessRequest(r2);

            // Generar y procesar solicitud #3
            Request r3 = new Request(1215718, 5566623484872, "C");
            requestInscriptionHandler.ProcessRequest(r3);

            // Generar y procesar solicitud #4
            Request r4 = new Request(1094818, 1656849988451, "I");
            requestInscriptionHandler.ProcessRequest(r4);

            // Generar y procesar solicitud #5
            Request r5 = new Request(1094818, 1656849988451, "E");
            requestInscriptionHandler.ProcessRequest(r5);

            // Esperar por el usuario
            Console.ReadKey();
        }
    }
}
