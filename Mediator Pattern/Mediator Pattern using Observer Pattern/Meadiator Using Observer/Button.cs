using System;
using System.Collections.Generic;
using System.Text;

namespace Meadiator_Using_Observer
{
    public class Button : UIControl
    {
        private bool isEnabledprop;

        public bool getEnabled()
        {
            return isEnabledprop;
        }

        public void setEnabled(bool enabled)
        {
            isEnabledprop = enabled;
            notify();
        }
    }
}
