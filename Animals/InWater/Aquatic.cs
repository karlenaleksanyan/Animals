namespace Animals.InWater
{
	class Aquatic:Animal
	{
		public const AnimalBirth birth = AnimalBirth.Tadpole;

		public Aquatic(int typeCount):base(typeCount)
		{
		}

		public override AnimalFood Eat(AnimalFood food)
		{
			return food;
		}
	}
}
