using Sudoku.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sudoku.Infrastructure.Sources
{
    internal class TextFileSource : FileSource
    {

        public TextFileSource() { }

        public override Core.Models.Sudoku Convert(string path)
        {
            #region Init
            ValidatePath(path);
            #endregion

            Core.Models.Sudoku result = new Core.Models.Sudoku();
            return result;
        }
    }
}
