using System;

namespace MementoPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            var doc = new Document();
            var his = new History();

            doc.setContent("Harsh");
            doc.setFontName("BOLD");
            doc.setFontSize(10);

            his.push(doc.createState());

            Console.WriteLine($"Current State \n");
            Console.WriteLine($"content = {doc.getcontent()} fontName = {doc.getFontName()} fontSize = {doc.getFontSize()} \n");

            doc.setContent("Varad");
            doc.setFontName("Italics");
            doc.setFontSize(11);

            his.push(doc.createState());

            Console.WriteLine($"Current State \n");
            Console.WriteLine($"content = {doc.getcontent()} fontName = {doc.getFontName()} fontSize = {doc.getFontSize()} \n");

            doc.setContent("Ankit");
            his.push(doc.createState());

            Console.WriteLine($"Current State \n");
            Console.WriteLine($"content = {doc.getcontent()} fontName = {doc.getFontName()} fontSize = {doc.getFontSize()} \n");

            doc.restore(his.pop());

            Console.WriteLine($"Current State \n");
            Console.WriteLine($"content = {doc.getcontent()} fontName = {doc.getFontName()} fontSize = {doc.getFontSize()} \n");

            doc.restore(his.pop());

            Console.WriteLine($"Current State \n");
            Console.WriteLine($"content = {doc.getcontent()} fontName = {doc.getFontName()} fontSize = {doc.getFontSize()} \n");



        }
    }
}
