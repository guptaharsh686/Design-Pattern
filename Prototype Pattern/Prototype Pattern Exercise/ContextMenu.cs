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
            if (component is Text) {
                Text source = (Text)component;
                Text target = new Text(source.getContent());
                timeline.add(target);
            }
        else if (component is Audio) {
                // Logic for duplicating an Audio object
            }
        else if (component is Clip) {
                // Logic for duplicating a Clip object
            }
        }
    }
}
