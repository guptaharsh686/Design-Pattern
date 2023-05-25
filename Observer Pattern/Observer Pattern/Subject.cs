using System;
using System.Collections.Generic;
using System.Text;

namespace Observer_Pattern
{
    //Observable
    public abstract class Subject
    {
        private List<IObserver> observers = new List<IObserver>();

        public void addObserver(IObserver ob)
        {
            observers.Add(ob);
        }


        public void removeObserver(IObserver ob)
        {
            observers.Remove(ob);
        }


        public void notifyObserver(int value)
        {
            foreach (var ob in observers)
            {
                ob.update(value);
            }
        }
    }
}
