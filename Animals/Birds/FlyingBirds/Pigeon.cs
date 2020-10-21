using System;
using System.Collections.Generic;
using System.Text;

namespace Animals.Birds.FlyingBirds
{
	class Pigeon:FlyingBird
	{
		public Pigeon(
						  string name,
						  int age,
						  int mass,
						  int lifeCycle,
						  ConsoleColor color,
						  Gender animalGender
						) : base(name, age, mass, lifeCycle, color, animalGender) { }
	}
}
