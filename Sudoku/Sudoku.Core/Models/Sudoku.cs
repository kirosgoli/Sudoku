using Sudoku.Core.Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sudoku.Core.Models
{
    public class Sudoku
    {
        private const int ROW_LENGTH = 9;
        private const int COLUMN_LENGTH = 9;
        private Cell[,] _cells;

        public Sudoku()
        {
            _cells = new Cell[ROW_LENGTH,COLUMN_LENGTH];
            FillWithEmptyValues();
        }

        private void FillWithEmptyValues()
        {
            for (int row = 0; row < ROW_LENGTH; row++)
            {
                for (int column = 0; column < COLUMN_LENGTH; column++)
                {
                    _cells[row, column] = new Cell(row,column);
                }
            }
        }

        public void SetValue(int row, int column, CellValue value)
        {
            _cells[row,column].Value = value;
        }
    }
}
