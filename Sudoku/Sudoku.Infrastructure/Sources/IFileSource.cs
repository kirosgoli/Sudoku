using Sudoku.Application.Exceptions;
using Sudoku.Application.Translations;
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

        protected void ValidatePath(string path)
        {
            if (string.IsNullOrEmpty(path)) throw new SourceException(Messages.PATH_IS_EMPTY_OR_NULL);
            if (!System.IO.File.Exists(path)) throw new SourceException(Messages.FILE_DO_NOT_EXISTS);
        }

        public abstract Core.Models.Sudoku Convert(string path);
    }
}
