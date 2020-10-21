namespace Animals.Birds
{
	enum WingsType
	{
		Feathery,
     	NonFeathery,
	}
	 class Bird:Animal
	{
		
		public WingsType Wings { get; set; }

		public const AnimalBirth birth = AnimalBirth.Eggs;
		public Bird(int type,  WingsType wings):base(type)
		{
			Wings = wings;
		}

		public override AnimalFood Eat(AnimalFood food)
		{
			return food;
		}




	}
}
