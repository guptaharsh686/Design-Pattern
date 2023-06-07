using System;
using System.Collections.Generic;
using System.Text;

namespace Mediator_Exercise
{
    public class CheckBox : UIControl
    {
        private bool isChecked;

        public bool isChecked_()
        {
            return isChecked;
        }

        public void setChecked(bool check)
        {
            isChecked = check;
            notify();
        }
    }
}
