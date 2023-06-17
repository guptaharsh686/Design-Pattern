using System;
using System.Collections.Generic;
using System.Text;

namespace Flyweight_Pattern_Exercise
{
    public class Demo
    {
        public static void show()
        {
            var attributes = new FormattingAttributesFactory();
            var sheet = new Spreadsheet(attributes.GetFormattingAttributes(FontFamily.TIMES_NEW_ROMAN.ToString()));
            sheet.setContent(0, 0, "Hello");
            sheet.setContent(1, 0, "World");
            sheet.setFontFamily(0, 0, attributes.GetFormattingAttributes(FontFamily.ARIAL.ToString()));
            sheet.render();
        }
    }
}
