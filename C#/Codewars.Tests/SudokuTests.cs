using NUnit.Framework;

namespace CodeWars.Tests;

public sealed class SudokuTests
{
	[Test]
	public void Correct9By9Sudoku()
	{
		var solvedSudoku = new Sudoku(new[]
		{
			new[] { 5, 3, 4, 6, 7, 8, 9, 1, 2 }, new[] { 6, 7, 2, 1, 9, 5, 3, 4, 8 },
			new[] { 1, 9, 8, 3, 4, 2, 5, 6, 7 }, new[] { 8, 5, 9, 7, 6, 1, 4, 2, 3 },
			new[] { 4, 2, 6, 8, 5, 3, 7, 9, 1 }, new[] { 7, 1, 3, 9, 2, 4, 8, 5, 6 },
			new[] { 9, 6, 1, 5, 3, 7, 2, 8, 4 }, new[] { 2, 8, 7, 4, 1, 9, 6, 3, 5 },
			new[] { 3, 4, 5, 2, 8, 6, 1, 7, 9 }
		});
		Assert.That(solvedSudoku.IsValid(), Is.True);
	}

	[Test]
	public void Wrong2By2Sudoku()
	{
		var solvedSudoku = new Sudoku(new[] { new[] { 1, 2 }, new[] { 1, 2 } });
		Assert.That(solvedSudoku.IsValid(), Is.False);
	}

	[Test]
	public void Correct4By4Sudoku()
	{
		var solvedSudoku = new Sudoku(new[]
		{
			new[] { 1, 4, 2, 3 }, new[] { 3, 2, 4, 1 }, new[] { 4, 1, 3, 2 }, new[] { 2, 3, 1, 4 }
		});
		Assert.That(solvedSudoku.IsValid(), Is.False);
	}

	[Test]
	public void Wrong4By4Sudoku()
	{
		var invalidSudoku = new Sudoku(new[]
		{
			new[] { 1, 4, 2, 3 }, new[] { 3, 2, 4, 1 }, new[] { 4, 2, 3, 2 }, new[] { 2, 3, 1, 4 }
		});
		Assert.That(invalidSudoku.IsValid(), Is.False);
	}

	[Test]
	public void Wrong9By9Sudoku()
	{
		var invalidSudoku = new Sudoku(new[]
		{
			new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 },
			new[] { 2, 3, 1, 5, 6, 4, 8, 9, 7 },
			new[] { 3, 1, 2, 6, 4, 5, 9, 7, 8 },
			new[] { 4, 5, 6, 7, 8, 9, 1, 2, 3 },
			new[] { 5, 6, 4, 8, 9, 7, 2, 3, 1 },
			new[] { 6, 4, 5, 9, 7, 8, 3, 1, 2 },
			new[] { 7, 8, 9, 1, 2, 3, 4, 5, 6 },
			new[] { 8, 9, 7, 2, 3, 1, 5, 6, 4 },
			new[] { 9, 7, 8, 3, 1, 2, 6, 4, 5 }
		});
		Assert.That(invalidSudoku.IsValid(), Is.False);
	}

	[Test]
	public void NotComplicated()
	{
		var invalidSudoku = new Sudoku(new[]
		{
			new[] { 1, 2, 3, 4, 5 }, new[] { 1, 2, 3, 4 }, new[] { 1, 2, 3, 4 }, new[] { 1 }
		});
		Assert.That(invalidSudoku.IsValid(), Is.False);
	}
}