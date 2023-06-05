using System;
using System.Collections.Generic;
using System.Text;

namespace Meadiator_Using_Observer
{
    public class ArticleDialogBox
    {
        private Button button;
        private ListBox listBox;
        private TextBox textBox;


        public ArticleDialogBox()
        {
            this.button = new Button();
            this.listBox = new ListBox();
            this.textBox = new TextBox();
            
        }


        private void articleSelected()
        {
            textBox.setContent(listBox.getSelection());
            if (!string.IsNullOrEmpty(textBox.getContent()))
                button.setEnabled(true);
            else
                button.setEnabled(false);
        }
    }
}
