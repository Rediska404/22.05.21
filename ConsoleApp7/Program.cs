using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
	class Program
	{
		static void Main(string[] args)
		{
			Transport newTransport = new Transport("", "", "");
			newTransport.Color = "";
	
			
			
			
			
			
			
			
			
			Car NewCar = new Car("BMW", "Black", "М5");
			NewCar.StartCar(true);
			NewCar.SignalingCar(false);
			Bus NewBus = new Bus("ПАЗ", "White", "21-36");
			NewBus.DoorBus(false);
			NewBus.BusStart(true);
			Plane NewPlane = new Plane("AirBus", "White", "A-310");
			NewPlane.Start(false);
			NewPlane.Chassis(true);
			NewPlane.Color = "";
			Helicopter NewHelecopter = new Helicopter("Bell","Blue","407");
			NewHelecopter.Start(false);
			NewHelecopter.Door(true);
			Train NewTrain = new Train("JR-Maglev", "White", "NotNull");
			NewTrain.Start(true);
			NewTrain.Door(false);
			Console.ReadKey();
		
			
		}
	}
}
