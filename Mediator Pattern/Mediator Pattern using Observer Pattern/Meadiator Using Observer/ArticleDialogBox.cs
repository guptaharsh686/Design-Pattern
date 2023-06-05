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

            this.listBox.addObserver(new ConcreteListObserver(this));
            this.textBox.addObserver(new ConcreteTextBoxObserver(this));
            
        }
        
        public void simulateInteraction()
        {
            listBox.setSelection("Article 1");
            Console.WriteLine($"TextBox : " + textBox.getContent());
            Console.WriteLine($"Button : " + button.getEnabled());
            textBox.setContent("");
            Console.WriteLine($"Button : " + button.getEnabled());
            textBox.setContent("Article 2");
            Console.WriteLine($"TextBox : "+ textBox.getContent());
            Console.WriteLine($"Button : " + button.getEnabled());
        }

        private void articleSelected()
        {
            textBox.setContent(listBox.getSelection());
            if (!string.IsNullOrEmpty(textBox.getContent()))
                button.setEnabled(true);
            else
                button.setEnabled(false);
        }

        private void titleChanged()
        {
            var content = textBox.getContent();
            var isEmpty = string.IsNullOrEmpty(content);
            button.setEnabled(!isEmpty);
        }

        public class ConcreteListObserver : IObserver
        {
            private ArticleDialogBox dialogBox;

            public ConcreteListObserver(ArticleDialogBox dialogBox)
            {
                this.dialogBox = dialogBox;
            }
            public override void update()
            {
                dialogBox.articleSelected();
            }
        }

        public class ConcreteTextBoxObserver : IObserver
        {
            private ArticleDialogBox dialogBox;

            public ConcreteTextBoxObserver(ArticleDialogBox dialogBox)
            {
                this.dialogBox = dialogBox;
            }
            public override void update()
            {
                dialogBox.titleChanged();
            }
        }


        public class ConcreteButtonObserver : IObserver
        {
            private ArticleDialogBox dialogBox;

            public ConcreteButtonObserver(ArticleDialogBox dialogBox)
            {
                this.dialogBox = dialogBox;
            }
            public override void update()
            {
                throw new NotImplementedException();
            }
        }
    }

    
}
