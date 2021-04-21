using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Events
{
    class Program
    {
        static void Main(string[] args)
        {
            Button button = new Button();

            void DisplayMessage(string result)
            {
                Console.WriteLine(result);
            }

            button.Notify += DisplayMessage;

            int number = Convert.ToInt32(Console.ReadLine());
            if (number == 1)
            {
                button.Notification();
            }

            Page page = new Page();

            page.Notify += Loaded;
            if (number == 2)
            {
                page.Event();
            }
            if (number == 3)
            {
                page.Notify += Updated;
                page.Event();
            }
            if (number == 4)
            {
                page.Notify += Closed;
                page.Event();
            }

            string Loaded()
            {
                return "Loaded";
            }

            string Updated()
            {
                return "Updated";
            }

            string Closed()
            {
                return "Closed";
            }

            if (number == 5)
            {
                string message = "application opened";
                Application app = new Application();

                app.Notify += Method;
                app.HUI(message, 1, 2);

            }

            Console.ReadKey();
        }
        public static string Method(string mes)
        {
            Console.WriteLine(mes);
            return "test";
        }
    }
}
