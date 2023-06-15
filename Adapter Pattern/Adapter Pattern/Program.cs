using System;
using Ava_Filters;

namespace Adapter_Pattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            var imageview = new ImageView(new Image());
            imageview.apply(new VividFilter());

            //imageview.apply(new CaramelFilter());
            //this will not work as of now because the CaramelFilter class dosenot implement IFilter interface and it is a third party 
            // library it dosenot know anything about IFilter we need to solve this using Adapter pattern

            imageview.apply(new CaramelFilterAdapter(new CaramelFilter()));
        }
    }
}
