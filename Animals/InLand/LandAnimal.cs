using System;
using System.Collections.Generic;
using System.Text;

namespace Animals.InLand
{
	class LandAnimal:Animal
	{
		public const AnimalBirth birth = AnimalBirth.Cups;

		public LandAnimal(int typeCount) : base(typeCount) { }

		public override AnimalFood Eat(AnimalFood food)
		{
			return base.Eat(food);
		}



	}
}
