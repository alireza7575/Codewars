using System.Collections.Generic;
using System.Linq;

namespace CodeWars;

public sealed class Sudoku
{
	private readonly int[][] board;
	public Sudoku(int[][] board) => this.board = board;

	public bool IsValid()
	{
		try
		{
			return CheckRow() && CheckColumn() && CheckSubGrids();
		}
		catch
		{
			return false;
		}
	}

	private bool CheckColumn()
	{
		for (var columnIndex = 0; columnIndex < board.Length; columnIndex++)
		{
			var seenNumbers = new List<int>();
			foreach (var row in board)
				if (!seenNumbers.Contains(row[columnIndex]) && row[columnIndex] != 0)
					seenNumbers.Add(row[columnIndex]);
				else
					return false;
		}
		return true;
	}

	private bool CheckRow()
	{
		foreach (var row in board)
		{
			var seenNumbers = new List<int>();
			for (var columnIndex = 0; columnIndex < board.Length; columnIndex++)
				if (!seenNumbers.Contains(row[columnIndex]) && row[columnIndex] != 0)
					seenNumbers.Add(row[columnIndex]);
				else
					return false;
		}
		return true;
	}

	private bool CheckSubGrids()
	{
		for (var rowIndex = 0; rowIndex < board.Length; rowIndex += 3)
		for (var columnIndex = 0; columnIndex < board.Length; columnIndex += 3)
			if (!LookForRepeatedNumber(rowIndex, columnIndex))
				return false;
		return true;
	}

	private bool LookForRepeatedNumber(int rowIndex, int columnIndex)
	{
		var seenNumbers = new List<int>();
		return board.Skip(rowIndex).Take(3).Select(row => row.Skip(columnIndex).Take(3)).
			SelectMany(subRow => subRow).All(value => CheckHistory(seenNumbers, value));
	}

	private static bool CheckHistory(ICollection<int> seenNumbers, int value)
	{
		if (!seenNumbers.Contains(value))
			seenNumbers.Add(value);
		else
			return false;
		return true;
	}
}