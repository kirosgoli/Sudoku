using Sudoku.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace Sudoku.Infrastructure.Sources
{
    internal abstract class FileSource : ISource<string>
    {

        protected bool ValidatePath(string path)
        {
            return false;
        }

        public abstract Core.Models.Sudoku Convert(string path);
    }
}
