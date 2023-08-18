using Sudoku.Core.Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sudoku.Core.Models
{
    public struct Cell
    {
        public readonly int Row;
        public readonly int Column;

        private CellValue _value;

        public CellValue Value
        {
            get { return _value; }
            set { _value = value; }
        }
        public Cell(int row, int column, CellValue value = CellValue.Empty)
        {
            Row = row;
            Column = column;
            Value = value;
        }

    }
}
