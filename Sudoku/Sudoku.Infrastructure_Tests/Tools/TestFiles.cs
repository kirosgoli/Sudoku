using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Sudoku.Infrastructure_Tests.Tools
{
	static class TestFiles
	{
		internal static string GetFullPathToFile(string file)
		{
			var codeBaseUrl = new Uri(Assembly.GetExecutingAssembly().CodeBase);
			var codeBasePath = Uri.UnescapeDataString(codeBaseUrl.AbsolutePath);
			var dirPath = Path.GetDirectoryName(codeBasePath);
			return Path.Combine(dirPath,file);
		}
	}
}
