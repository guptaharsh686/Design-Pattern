using System;
using System.Collections.Generic;
using System.Text;

namespace Flyweight_Pattern_Exercise
{
    public class Demo
    {
        public static void show()
        {
            var factory = new AttributesFactory();
            var sheet = new Spreadsheet(factory);
            sheet.setContent(0, 0, "Hello");
            sheet.setContent(1, 0, "World");
            sheet.setFontFamily(0, 0, FontFamily.ARIAL.ToString());
            sheet.render();
        }
    }
}
