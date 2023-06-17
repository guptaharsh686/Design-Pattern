﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Flyweight_Pattern_Exercise
{
    public class Spreadsheet
    {
        private int MAX_ROWS = 3;
        private int MAX_COLS = 3;
        private FormattingAttributes attribute;

        // In a real app, these values should not be hardcoded here.
        // They should be read from a configuration file.
 
        private Cell[,] cells = new Cell[3,3];

        public Spreadsheet(FormattingAttributes attributes)
        {
            this.attribute = attributes;
            generateCells();
        }

        public void setContent(int row, int col, String content)
        {
            ensureCellExists(row, col);

            cells[row,col].setContent(content);
        }

        public void setFontFamily(int row, int col, FormattingAttributes fontFamily)
        {
            ensureCellExists(row, col);

            var cell = cells[row,col];
            cells[row,col].setFontFamily(fontFamily.getFontFamily());
        }

        private void ensureCellExists(int row, int col)
        {
            if (row < 0 || row >= MAX_ROWS)
                throw new ArgumentOutOfRangeException();

            if (col < 0 || col >= MAX_COLS)
                throw new ArgumentOutOfRangeException();
        }

        private void generateCells()
        {
            for (var row = 0; row < MAX_ROWS; row++)
                for (var col = 0; col < MAX_COLS; col++)
                {
                    var cell = new Cell(row, col,attribute);
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
