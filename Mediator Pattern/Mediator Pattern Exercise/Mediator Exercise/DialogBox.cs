using System;
using System.Collections.Generic;
using System.Text;

namespace Mediator_Exercise
{
    public class DialogBox
    {
        private TextBox username;
        private TextBox password;
        private CheckBox checkBox1;
        private Button signupButton;


        public DialogBox()
        {
            this.username = new TextBox();
            this.password = new TextBox();
            this.checkBox1 = new CheckBox();
            this.signupButton = new Button();

            username.addObserver(new textBoxObserver(this));
            password.addObserver(new textBoxObserver(this));
            checkBox1.addObserver(new checkBoxObserver(this));

        }

        public void simulateBehavior()
        {
            username.setContent("");
            password.setContent("wwd");
            checkBox1.setChecked(true);
            Console.WriteLine($"username : {username.getContent()}");
            Console.WriteLine($"password : {password.getContent()}");
            Console.WriteLine($"checkBox : {checkBox1.isChecked_()}");
            Console.WriteLine($"signup : {signupButton.isEnabled_()}");

            username.setContent("wdwd");
            password.setContent("wwd");
            checkBox1.setChecked(false);
            Console.WriteLine($"username : {username.getContent()}");
            Console.WriteLine($"password : {password.getContent()}");
            Console.WriteLine($"checkBox : {checkBox1.isChecked_()}");
            Console.WriteLine($"signup : {signupButton.isEnabled_()}");


            username.setContent("wdwqdqwd");
            password.setContent("wwd");
            checkBox1.setChecked(true);
            Console.WriteLine($"username : {username.getContent()}");
            Console.WriteLine($"password : {password.getContent()}");
            Console.WriteLine($"checkBox : {checkBox1.isChecked_()}");
            Console.WriteLine($"signup : {signupButton.isEnabled_()}");




        }

        public void enableButton()
        {
            if(!string.IsNullOrEmpty(username.getContent()) && !string.IsNullOrEmpty(password.getContent()) && checkBox1.isChecked_())
            {
                signupButton.setEnabled(true);
            }
            else
            {
                signupButton.setEnabled(false);
            }
        }



        private class textBoxObserver : IObserver
        {
            private DialogBox dialogBox1;

            public textBoxObserver(DialogBox dialogBox)
            {
                this.dialogBox1 = dialogBox;
            }

            public override void update()
            {
                dialogBox1.enableButton();
            }
        }


        private class checkBoxObserver : IObserver
        {
            private DialogBox dialogBox2;

            public checkBoxObserver(DialogBox dialogBox)
            {
                this.dialogBox2 = dialogBox;
            }

            public override void update()
            {
                dialogBox2.enableButton();
            }
        }
    }
}
