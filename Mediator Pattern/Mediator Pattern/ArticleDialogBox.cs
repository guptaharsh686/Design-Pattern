using System;
using System.Collections.Generic;
using System.Text;

namespace Mediator_Pattern
{
    public class ArticleDialogBox : DialogBox
    {
        private ListBox articleListDialogBox;
        private Button button;
        private TextBox textBox; 

        public ArticleDialogBox()
        {
            this.articleListDialogBox = new ListBox(this);
            this.button = new Button(this);
            this.textBox = new TextBox(this);
        }

        public void simulateUIChanges()
        {
            articleListDialogBox.setSelection("Item 1");
            Console.WriteLine($"ListBox : {articleListDialogBox.getSelection()}");
            Console.WriteLine($"Button : {button.isEnabled()}");

            articleListDialogBox.setSelection("");
            Console.WriteLine($"ListBox : {articleListDialogBox.getSelection()}");
            Console.WriteLine($"Button : {button.isEnabled()}");
        }

        public override void changed(UIControl control)
        {
            if(control == articleListDialogBox)
            {
                articleSelected();
            }
            else if(control == textBox)
            {
                var content = textBox.getContent();
                var isEmpty = (content == null || content == "");
                button.setEnabled(!isEmpty);
            }
        }

        private void articleSelected()
        {
            textBox.setContent(articleListDialogBox.getSelection());
            if (!string.IsNullOrEmpty(textBox.getContent()))
                button.setEnabled(true);
            else
                button.setEnabled(false);
        }
    }
}
