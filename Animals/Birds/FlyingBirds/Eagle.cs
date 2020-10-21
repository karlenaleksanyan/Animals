using System;
using System.Collections.Generic;
using System.Text;

namespace Animals.Birds.FlyingBirds
{
	
	class Eagle:FlyingBird
	{
		public Eagle(
					  string name,
					  int age,
					  int mass,
					  int lifeCycle,
					  ConsoleColor color,
					  Gender animalGender
					):base(name, age, mass, lifeCycle, color, animalGender) { }
		


		}
}
