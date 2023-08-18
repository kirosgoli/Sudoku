using Sudoku.Application.Exceptions;
using Sudoku.Application.Translations;
using Sudoku.Infrastructure.Sources;
using Sudoku.Infrastructure_Tests.Tools;
using System.IO;

namespace Sudoku.Infrastructure_Tests
{
	public class TextFileSource_Tests
	{
		[Theory]
		[InlineData(null)]
		[InlineData("")]
		public void Convert_Should_Throw_Exception_When_No_Path(string path)
		{
			var source = new TextFileSource();

			var exception = Assert.Throws<SourceException>(() => source.Convert(path));

			Assert.IsType<SourceException>(exception);
			Assert.Equal(Messages.PATH_IS_EMPTY_OR_NULL, exception.Message);


		}

		[Fact]
		public void Convert_Should_Throw_Exception_When_File_Do_Not_Exist()
		{
			var source = new TextFileSource();
			var path = @"y://sudoku.txt";

			var exception = Assert.Throws<SourceException>(() => source.Convert(path));

			Assert.IsType<SourceException>(exception);
			Assert.Equal(Messages.FILE_DO_NOT_EXISTS, exception.Message);
		}

		[Fact]
		public void Convert_Should_Throw_Exception_When_rows_do_not_match()
		{
			var source = new TextFileSource();
			var path = TestFiles.GetFullPathToFile(Path.Combine("Files", "Sudoko_Wrong_Rows.txt"));

			var exception = Assert.Throws<SourceException>(() => source.Convert(path));

			Assert.IsType<SourceException>(exception);
			Assert.Equal(Messages.IMPORTED_SUDOKU_WRONG_ROWS, exception.Message);
		}

		[Fact]
		public void Convert_Should_Throw_Exception_When_columns_do_not_match()
		{
			var source = new TextFileSource();
			var path = TestFiles.GetFullPathToFile(Path.Combine("Files", "Sudoko_Wrong_Columns.txt"));

			var exception = Assert.Throws<SourceException>(() => source.Convert(path));

			Assert.IsType<SourceException>(exception);
			Assert.Equal(Messages.IMPORTED_SUDOKU_WRONG_COLUMNS, exception.Message);
		}
	}
}