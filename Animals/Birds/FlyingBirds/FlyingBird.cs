using System;
using System.Collections.Generic;
using System.Text;

namespace Animals.Birds.FlyingBirds
{
	class FlyingBird
	{
		public int FlightSpeed { get; set; }


		public string Name { get; set; }
		public int Age { get; set; }
		public int Mass { get; set; }
		public int LifeCycle { get; set; }
		public ConsoleColor Color { get; set; }
		public Gender AnimalGender { get; set; }

		public FlyingBird()
		{

		}
		public FlyingBird(
					 string name,
					 int age,
					 int mass,
					 int lifeCycle,
					 ConsoleColor color,
					 Gender animalGender
					)
		{
			Name = name;
			Age = age;
			Mass = mass;
			LifeCycle = lifeCycle;
			Color = color;
			AnimalGender = animalGender;
		}

		public override string ToString()
		{
			return $"Name ={Name}\n" +
				   $"Age = {Age}\n" +
				   $"Mass = {Mass}\n" +
				   $"LifeCycle = {LifeCycle}\n" +
				   $"Color = {Color}\n" +
				   $"AnimalGender = {AnimalGender}\n ";
		}
	}
}
