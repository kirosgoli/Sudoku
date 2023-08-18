using Sudoku.Application.Exceptions;
using Sudoku.Application.Translations;
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

		/// <summary>
		/// TODO inject splitter or create mechanic for finding splitter
		/// </summary>
		private const string SEPARATOR = ",";

		public TextFileSource() { }

		public override Core.Models.Sudoku Convert(string path)
		{
			#region Init
			ValidatePath(path);
			#endregion

			Core.Models.Sudoku result = new Core.Models.Sudoku();
			var rows = File.ReadAllLines(path);
			ValidateInputData(rows);
			return result;
		}

		private static void ValidateInputData(string[] rows)
		{
			if (rows.Count() != 9) throw new SourceException(Messages.IMPORTED_SUDOKU_WRONG_ROWS);
			foreach (var row in rows)
			{
				string[] cells = row.Split(SEPARATOR);
				if (cells.Length != 9) throw new SourceException(Messages.IMPORTED_SUDOKU_WRONG_COLUMNS);

			}
		}
	}
}
