using System;
using System.Collections.Generic;
using System.Text;

namespace Prototype_Pattern_Exercise
{
    public class ContextMenu
    {
        private Timeline timeline;

        public ContextMenu(Timeline timeline)
        {
            this.timeline = timeline;
        }

        public void duplicate(IComponent component)
        {
            Console.WriteLine("Duplicated");
            timeline.add(component.clone());

        }
    }
}
