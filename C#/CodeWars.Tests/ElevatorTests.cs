using System;
using NUnit.Framework;

namespace CodeWars.Tests;

public sealed class ElevatorTests
{
	[Test]
	public void NoWaitingQueue() =>
		Assert.That(new Elevator(new int[][] { }, 1).GetVisitedFloors(), Is.EqualTo(new int[1]));

	[Test]
	public void EmptyBuilding() =>
		VisitsExpectedFloors(new Elevator(
			// @formatter:off
	new[]
	{
			Array.Empty<int>(),
			Array.Empty<int>(),
			Array.Empty<int>(),
			Array.Empty<int>(),
			Array.Empty<int>(),
			Array.Empty<int>(),
			Array.Empty<int>()
		}
			// @formatter:on
			, 5).GetVisitedFloors(), new int[1]);

	private static void VisitsExpectedFloors(int[] result, int[] expected) =>
		Assert.That(result, Is.EqualTo(expected),
			"Expected: " + string.Join(",", expected) + "\n" + "  Actual:   " + string.Join(",", result));

	[Test]
	public void EnterAllFromGroundFloor()
	{
		// @formatter:off
		int[][] floorsQueues =
		{
			new[] { 1, 2, 3, 4 },
			Array.Empty<int>(),
			Array.Empty<int>(),
			Array.Empty<int>(),
			Array.Empty<int>(),
			Array.Empty<int>(),
			Array.Empty<int>()
		};
		// @formatter:on
		VisitsExpectedFloors(new Elevator(floorsQueues, 4).GetVisitedFloors(),
			new[] { 0, 1, 2, 3, 4, 0 });
	}

	[Test]
	public void MoveUp()
	{
		// @formatter:off
		int[][] floorsQueues =
		{
			Array.Empty<int>(),
			Array.Empty<int>(),
			new[] { 5, 5, 5 },
			Array.Empty<int>(),
			Array.Empty<int>(),
			Array.Empty<int>(),
			Array.Empty<int>()
		};
		// @formatter:on
		VisitsExpectedFloors(new Elevator(floorsQueues, 5).GetVisitedFloors(), new[] { 0, 2, 5, 0 });
	}

	[Test]
	public void MoveFromGroundAndPickupOneThenGoToRequiredLevel()
	{
		// @formatter:off
		int[][] floorsQueues =
		{
			Array.Empty<int>(),
			new[] { 2 },
			Array.Empty<int>()
		};
		// @formatter:on
		VisitsExpectedFloors(new Elevator(floorsQueues, 1).GetVisitedFloors(), new[] { 0, 1, 2, 0 });
	}

	[Test]
	public void MoveUpWithLimitedCapacity()
	{
		// @formatter:off
		int[][] floorsQueues =
		{
			Array.Empty<int>(),
			new[] { 3, 4, 5 },
			Array.Empty<int>(),
			Array.Empty<int>(),
			Array.Empty<int>(),
			Array.Empty<int>()
		};
		// @formatter:on
		VisitsExpectedFloors(new Elevator(floorsQueues, 3).GetVisitedFloors(),
			new[] { 0, 1, 3, 4, 5, 0 });
	}

	[Test]
	public void MoveDown()
	{
		// @formatter:off
		int[][] floorsQueues =
		{
			Array.Empty<int>(),
			Array.Empty<int>(),
			new[] { 1, 1 },
			Array.Empty<int>(),
			Array.Empty<int>(),
			Array.Empty<int>(),
			Array.Empty<int>()
		};
		// @formatter:on
		VisitsExpectedFloors(new Elevator(floorsQueues, 5).GetVisitedFloors(), new[] { 0, 2, 1, 0 });
	}

	[Test]
	public void MoveUpAndUp()
	{
		// @formatter:off
		int[][] floorsQueues =
		{
			Array.Empty<int>(),
			new[] { 3 },
			new[] { 4 },
			Array.Empty<int>(),
			new[] { 5 },
			Array.Empty<int>(),
			Array.Empty<int>()
		};
		// @formatter:one
		VisitsExpectedFloors(new Elevator(floorsQueues, 5).GetVisitedFloors(), new[] { 0, 1, 2, 3, 4, 5, 0 });
	}

	[Test]
	public void MoveUpAndMoveDown()
	{
		// @formatter:off
		int[][] floorsQueues =
		{
			Array.Empty<int>(),
			new int[1],
			Array.Empty<int>(),
			Array.Empty<int>(),
			new[] { 2 },
			new[] { 3 },
			Array.Empty<int>()
		};
		// @formatter:one
		VisitsExpectedFloors(new Elevator(floorsQueues, 5).GetVisitedFloors(), new[] { 0, 5, 4, 3, 2, 1, 0 });
	}

	[TestCase(4,
		new[] { 0, 6, 5, 4, 3, 2, 1, 0, 5, 4, 3, 2, 1, 0, 4, 3, 2, 1, 0, 3, 2, 1, 0, 2, 1, 0, 1, 0 })]
	[TestCase(5, new[] { 0, 6, 5, 4, 3, 2, 1, 0, 5, 4, 3, 2, 1, 0, 4, 3, 2, 1, 0, 3, 2, 1, 0, 1, 0 })]
	public void FireDrill(int capacity, int[] expected)
	{
		// @formatter:off
		int[][] floorsQueues =
		{
			Array.Empty<int>(),
			new int[4],
			new int[4],
			new int[4],
			new int[4],
			new int[4],
			new int[4]
		};
		// @formatter:on
		VisitsExpectedFloors(new Elevator(floorsQueues, capacity).GetVisitedFloors(), expected);
	}

	[Test]
	public void AnotherRandomBuilding()
	{
		// @formatter:off
		int[][] floorsQueues =
		{
			new[] { 1 },
			new[] { 2, 2, 0 },
			Array.Empty<int>()
		};
		// @formatter:on
		VisitsExpectedFloors(new Elevator(floorsQueues, 3).GetVisitedFloors(), new[] { 0, 1, 2, 1, 0 });
	}

	[TestCase(1, new[] { 0, 1, 2, 3, 1, 2, 3, 2, 3, 0 })]
	[TestCase(5, new[] { 0, 1, 2, 3, 1, 0 })]
	public void Highlander(int capacity, int[] expected)
	{
		// @formatter:off
		int[][] floorsQueues =
		{
			Array.Empty<int>(),
			new[] { 2 },
			new[] { 3, 3, 3 },
			new[] { 1 },
			Array.Empty<int>(),
			Array.Empty<int>(),
			Array.Empty<int>()
		};
		// @formatter:on
		VisitsExpectedFloors(new Elevator(floorsQueues, capacity).GetVisitedFloors(), expected);
	}

	[Test]
	public void SkyScarper()
	{
		// @formatter:off
		int[][] floorsQueues =
		{
			new[] { 1 },
			new[] { 9, 8, 9, 5 },
			new[] { 9, 7, 0, 6 },
			Array.Empty<int>(),
			new[] { 1, 0, 5, 0 },
			new[] { 9, 3 },
			new[] { 0, 5, 2 },
			new[] { 4, 1, 5 },
			new[] { 4, 6, 4 },
			new[] { 6, 4 }
		};
		// @formatter:on
		VisitsExpectedFloors(new Elevator(floorsQueues, 3).GetVisitedFloors(),
			new[]
			{
				0, 1, 2, 4, 5, 8, 9, 8, 7, 6, 5, 4, 2, 1, 0, 1, 2, 4, 5, 7, 9, 8, 7, 6, 5, 4, 3, 2, 0, 2,
				4, 5, 6, 7, 6, 5, 2, 1, 0
			});
	}

	[Test]
	public void TrickyBuilding()
	{
		// @formatter:off
		int[][] floorsQueues =
		{
			Array.Empty<int>(),
			new[] { 0, 0, 0, 6 },
			Array.Empty<int>(),
			Array.Empty<int>(),
			Array.Empty<int>(),
			new[] { 6, 6, 0, 0, 0, 6 },
			Array.Empty<int>()
		};
		// @formatter:on
		VisitsExpectedFloors(new Elevator(floorsQueues, 4).GetVisitedFloors(),
			new[] { 0, 1, 5, 6, 5, 1, 0, 1, 0 });
	}

	[Test]
	public void SecondSkyScarper()
	{
		// @formatter:off
		int[][] floorsQueues =
		{
			new[] { 12, 16, 16, 17 },
			new[] { 8, 10 },
			new[] { 12, 4 },
			Array.Empty<int>(),
			Array.Empty<int>(),
			new[] { 13, 2, 8 },
			new[] { 18 },
			new[] { 2, 2, 16 },
			Array.Empty<int>(),
			new[] { 4 },
			new[] { 9, 14 },
			new[] { 6 },
			new[] { 15, 1, 4 },
			new[] { 1, 4, 3 },
			new[] { 13 },
			new[] { 13 },
			new[] { 9, 7, 8 },
			Array.Empty<int>(),
			new[] { 5, 16 }
		};
		// @formatter:on
		VisitsExpectedFloors(new Elevator(floorsQueues, 5).GetVisitedFloors(),
			new[]
			{
				0, 1, 2, 5, 6, 7, 8, 10, 12, 14, 15, 16, 17, 18, 16, 15, 14, 13, 12, 11, 10, 9, 8, 7, 5,
				4, 2, 1, 2, 4, 5, 6, 7, 8, 10, 12, 13, 18, 14, 13, 12, 11, 10, 6, 4, 3, 1, 7, 16, 10, 9, 0
			});
	}
}