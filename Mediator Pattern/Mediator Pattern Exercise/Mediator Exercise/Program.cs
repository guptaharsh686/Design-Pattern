﻿using System;

namespace Mediator_Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            var dialog = new DialogBox();
            dialog.simulateBehavior();
        }
    }
}
