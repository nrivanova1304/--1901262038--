using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns
{
    public delegate void EventHandler(object sender, StateChangeEventArgs e);
    class Athlete
    {
        public event EventHandler StateChange;
        protected virtual void OnChange(StateChangeEventArgs e)
        {
            if (StateChange != null)
            {
                StateChange(this, e);
            }
        }
        public void Up() 
        {
            StateChangeEventArgs eventArg = new StateChangeEventArgs();
            eventArg.StateText = "I'm an athlete. Getting Up";
            
            OnChage(eventArg);
            Console.WriteLine("Getting up");
        }

        public void Down()
        {
            StateChangeEventArgs eventArg = new StateChangeEventArgs();
            eventArg.StateText = "I'm an athlete. Going down !";

            OnChange(eventArg);
            Console.WriteLine("Going down");
        }
    }
}
