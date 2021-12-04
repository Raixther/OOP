using System;
using System.Collections.Generic;

namespace Lesson4
{
	class Program
	{
		static void Main(string[] args)
		{
			Building A = Creator.Create_Build(12, 220, 6, 50);

			Console.WriteLine(A.GetID());

			Console.WriteLine(A.GetRooms());

			Console.WriteLine(A.GetRoomsAtEntrance());

			Console.WriteLine(A.GetRoomsAtFloor());

			Console.WriteLine(A.GetFloors());

			Console.WriteLine(A.GetHeight());

			A.SetEntrances(13);

			A.SetFloors(16);

			A.SetRooms(340);

			Console.WriteLine(A.GetRoomsAtEntrance());

			Console.WriteLine(A.GetRoomsAtFloor());


			Building B = new();

			Console.WriteLine(B.GetID());


			Console.ReadKey();
		}
	}
	public class Building
	{
		static private int _lastId;

		private int _id;

		private int _height;

		private int _floors;

		private int _rooms;

		private int _entrances;

		public Building()
		{
			GenerateNewId();
		}
		public Building(int floors, int rooms, int entrances, int height):this()
		{
			_floors = floors;
			_rooms = rooms;
			_entrances = entrances;
			_height = height;		
		}

		private void GenerateNewId()
		{
			_id = _lastId;

			_lastId++;
		}

		public int GetID()
		{
			return _id;
		}

		public int GetHeight()
		{
			return _height;
		}

		public int GetFloors()
		{
			return _floors;
		}
		public int GetRooms()
		{
			return _rooms;
		}
		public int GetEntrances()
		{
			return _entrances;
		}

		public void SetHeight(int height)
		{
			_height = height;
		}

		public void SetFloors(int floors)
		{
			_floors = floors;
		}
		public void SetRooms(int rooms)
		{
			_rooms = rooms;
		}
		public void SetEntrances(int entrances)
		{
			_entrances = entrances;
		}

		public int GetRoomsAtEntrance()
		{
			return _rooms/_entrances;
		}

		public int GetRoomsAtFloor()
		{
			return _rooms/_floors;
		}
		public int GetFloorHeight()
		{
			return _height/_floors;
		}
	}









	public class Creator
	{
		
		private Creator()
		{

		}

		static public Building Create_Build()
		{
			Building building = new Building();		
			return building;
		}
		static public Building Create_Build(int floors, int rooms, int entrances, int height)
		{
			Building building = new Building(floors, rooms, entrances, height);
			return building;
		}
	}
}
