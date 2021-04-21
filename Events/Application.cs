using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Events
{
    public class Application
    {
        //public Application(string appstatus)
        //{
        //    string message = appstatus;
        //}

        public delegate string AppStatus(string message);
        public event AppStatus Notify;

        public void HUI(string message, int a, int b)
        {
            //Program.Method(message);
            Notify?.Invoke(message); // = Method(message);
        }
    }
}
