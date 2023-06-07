using System;
using System.Collections.Generic;
using System.Text;

namespace Mediator_Exercise
{
    public class UIControl
    {
        private List<IObserver> observers = new List<IObserver>();

        public void addObserver(IObserver obs)
        {
            observers.Add(obs);
        }

        public void removeObserver(IObserver obs)
        {
            observers.Remove(obs);
        }

        public void notify()
        {
            foreach (var obs in observers)
            {
                obs.update();
            }
        }
    }
}
