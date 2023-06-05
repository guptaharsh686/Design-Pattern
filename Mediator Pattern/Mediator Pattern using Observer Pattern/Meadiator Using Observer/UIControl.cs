using System;
using System.Collections.Generic;
using System.Text;

namespace Meadiator_Using_Observer
{
    public abstract class UIControl
    {
        private List<IObserver> observers = new List<IObserver>();

        public void addObserver(IObserver obs)
        {
            observers.Add(obs);
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
