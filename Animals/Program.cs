using Animals.Birds;
using System;

	namespace Animals
	{
		class Program
		{
			static void Main(string[] args)
			{
			Bird bird = new Bird(15, WingsType.Feathery);
			Console.WriteLine(bird.Eat(AnimalFood.Cereals));
			}
		}
	}

