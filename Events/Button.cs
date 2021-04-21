using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Events
{
    public class Button
    {
        public delegate void ClickButton(string message);

        public event ClickButton Notify;

        public void Notification()
        {
            Notify?.Invoke("Button was pressed.");
        }
    }
}
