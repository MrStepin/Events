using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Events
{
    public class Page
    {
        public delegate string PageStatus();
        public event PageStatus Notify;

        public void Event()
        {
            Notify?.Invoke();
        }
    }
}
