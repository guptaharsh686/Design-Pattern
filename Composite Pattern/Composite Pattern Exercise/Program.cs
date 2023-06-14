using System;

namespace Composite_Pattern_Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            var st1 = new Team();
            st1.add(new Truck());
            st1.add(new HumanResource());
            st1.add(new HumanResource());

            var st2 = new Team();
            st2.add(new Truck());
            st2.add(new HumanResource());
            st2.add(new HumanResource());

            var team = new Team();
            team.add(st1);
            team.add(st2);

            team.deploy();

        }
    }
}
