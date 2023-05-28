using System;
using System.Collections.Generic;
using System.Text;

namespace Mediator_Pattern
{
    public class Button : UIControl
    {
        private bool isEnabledprop;

        public Button(DialogBox owner) : base(owner)
        {
        }

        public bool isEnabled()
        {
            return isEnabledprop;
        }

        public void setEnabled(bool enabled)
        {
            isEnabledprop = enabled;
            owner.changed(this);
        }
    }
}
