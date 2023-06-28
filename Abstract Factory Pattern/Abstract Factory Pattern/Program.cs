using System;

namespace Abstract_Factory_Pattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            new App.ContactForm().render(new MaterialWidgetFactory());
            new App.ContactForm().render(new AntWidgetFactory());

        }
    }
}
