using System;
using System.Collections.Generic;
using System.Text;

namespace Mediator_Exercise
{
    public class Button : UIControl
    {
        private bool isEnabled;

        public bool isEnabled_()
        {
            return isEnabled;
        }

        public void setEnabled(bool enabled)
        {
            isEnabled = enabled;
        }
    }
}
