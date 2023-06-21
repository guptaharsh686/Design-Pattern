using System;
using System.Collections.Generic;
using System.Text;

namespace Flyweight_Pattern_Exercise
{
    public class Spreadsheet
    {
        private int MAX_ROWS = 3;
        private int MAX_COLS = 3;

        // In a real app, these values should not be hardcoded here.
        // They should be read from a configuration file.

        private Cell[,] cells = new Cell[3, 3];
        private AttributesFactory attributesFactory;

        public Spreadsheet(AttributesFactory attributesFactory)
        {
            this.attributesFactory = attributesFactory;
            generateCells();
        }

        public void setContent(int row, int col, String content)
        {
            ensureCellExists(row, col);

            cells[row,col].setContent(content);
        }

        public void setFontFamily(int row, int col, String fontFamily)
        {
            ensureCellExists(row, col);

            var cell = cells[row,col];
            var context = cell.GetAttributeContext();
            var newContext = attributesFactory.GetAttributes(fontFamily, context.getFontSize(), context.get_isBold());
            cells[row,col].setAttributeContext(newContext);
        }

        private void ensureCellExists(int row, int col)
        {
            if (row < 0 || row >= MAX_ROWS)
                throw new ArgumentException();

            if (col < 0 || col >= MAX_COLS)
                throw new ArgumentException();
        }

        private void generateCells()
        {
            for (var row = 0; row < MAX_ROWS; row++)
                for (var col = 0; col < MAX_COLS; col++)
                {
                    var cell = new Cell(row, col);
                    var context = attributesFactory.GetAttributes(FontFamily.TIMES_NEW_ROMAN.ToString());
                    cell.setAttributeContext(context);
                    cells[row,col] = cell;
                }
        }

        public void render()
        {
            for (var row = 0; row < MAX_ROWS; row++)
                for (var col = 0; col < MAX_COLS; col++)
                    cells[row,col].render();
        }
    }
}
