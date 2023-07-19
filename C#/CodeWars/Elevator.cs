using System.Collections.Generic;
using System.Linq;

namespace CodeWars;

public sealed class Elevator
{
	public Elevator(IEnumerable<int[]> floors, int capacity)
	{
		this.floors = floors.Select(queue => queue.ToList()).ToList();
		this.capacity = capacity;
	}

	private readonly List<List<int>> floors;
	private readonly int capacity;

	public int[] GetVisitedFloors()
	{
		var visitedFloor = new List<int> { 0 };
		while (!IsBuildingEmpty())
			Move(visitedFloor);
		AddVisitedFloor(visitedFloor, 0);
		return visitedFloor.ToArray();
	}

	private bool IsBuildingEmpty() => floors.All(floor => floor.Count == 0);

	private void Move(List<int> visitedFloor)
	{
		currentDirection = Direction.Up;
		for (var floor = 0; floor <= floors.Count && floor >= 0; floor += (int)currentDirection)
			if (floor < floors.Count)
			{
				if (IsAnyoneLeavingLift(floor))
					Leave(visitedFloor, floor);
				var filtersPeople = GetPassengersWantEnter(floor);
				if (filtersPeople.Any())
					Enter(visitedFloor, filtersPeople, floor);
			}
			else
				currentDirection = Direction.Down;
	}

	private Direction currentDirection;

	private enum Direction
	{
		Up = 1,
		Down = -1
	}

	private List<int> GetPassengersWantEnter(int floor) =>
		floors[floor].Where(person => currentDirection == Direction.Up
			? person > floor
			: person < floor).ToList();

	private void Leave(List<int> visitedFloor, int floor)
	{
		targetFloors.RemoveAll(targetFloor => targetFloor == floor);
		AddVisitedFloor(visitedFloor, floor);
	}

	private readonly List<int> targetFloors = new();

	private void Enter(List<int> visitedFloor, IEnumerable<int> filtersPeople, int floor)
	{
		foreach (var targetFloor in filtersPeople.Where(_ => targetFloors.Count < capacity))
		{
			targetFloors.Add(targetFloor);
			floors[floor].Remove(targetFloor);
		}
		AddVisitedFloor(visitedFloor, floor);
	}

	private static void AddVisitedFloor(List<int> visitedFloor, int floor)
	{
		if (visitedFloor[^1] != floor)
			visitedFloor.Add(floor);
	}

	private bool IsAnyoneLeavingLift(int floor) => targetFloors.Contains(floor);
}