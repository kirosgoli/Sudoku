using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sudoku.Application.Exceptions
{
	public class SourceException : Exception
	{
		public SourceException(string message) : base(message)
		{
			
		}
	}
}
