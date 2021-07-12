using System;
using System.Collections.Generic;
using System.Text;

namespace ChainResponsibilityDemo
{
    /// <summary>
    /// Clase que represante los detalles de la solicitud
    /// </summary>
    public class Request
    {
        // Constructor
        public Request(int studentID, double activityID, string action)
        {
            this.StudentID = studentID;
            this.ActivityID = activityID;
            this.Action = action;
        }

        public int StudentID { get; set; }

        public double ActivityID { get; set; }

        public string Action { get; set; }
    }
}
