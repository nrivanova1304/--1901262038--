using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns
{
    class Observer
    {
        public void Update(object sender, StateChangeEventArgs e)
        {
            Console.WriteLine("Notification has been sent to the observer");
            Console.WriteLine(e.StateText);
        }
    }
}
