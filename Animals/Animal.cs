using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace Animals
{
	public enum Gender
	{
		Male,
		Female,
	}
	public enum AnimalBirth
	{
		Eggs,
		Cups,
		Tadpole //sherepuk
	}
	public	 enum AnimalFood
	{
		Meat,
		Cereals,//dzavarexen
		Worm,
		Bone,
		Grass,
		SeaFood,
	}
	public class Animal
	{
		public int TypeCount { get; private set; }
		protected Animal[] Type;

		public Animal(int _counter)
		{
			TypeCount = _counter;
			Type = new Animal[TypeCount];
		}


		public Animal this[int name]
		{
			get
			{
				return Type[name];
			}
			set
			{
				if (name < TypeCount && name >= 0)
				{
					Type[name] = value;
				}
				throw new IndexOutOfRangeException();
			}
		}




		public static int operator +(Animal animal, Animal animal1)
		{
			return animal.TypeCount + animal1.TypeCount;
		}
		public static int operator -(Animal animal, Animal animal1)
		{
			return animal.TypeCount - animal.TypeCount;
		}

		public static double operator *(Animal animal, Animal animal1)
		{
			return animal.TypeCount * animal.TypeCount;
		}

		public static double operator /(Animal animal, Animal animal1)
		{
			return animal.TypeCount / animal1.TypeCount;
		}

		public static bool operator >(Animal animal, Animal animal1)
		{
			return animal.TypeCount > animal1.TypeCount;
		}

		public static bool operator <(Animal animal, Animal animal1)
		{
			return animal.TypeCount < animal1.TypeCount;
		}

		public static bool operator >=(Animal animal, Animal animal1)
		{
			return animal.TypeCount >= animal1.TypeCount;
		}

		public static bool operator <=(Animal animal, Animal animal1)
		{
			return animal.TypeCount <= animal1.TypeCount;
		}

		public static bool operator ==(Animal animal, Animal animal1)
		{
			return animal.TypeCount == animal1.TypeCount;
		}

		public static bool operator !=(Animal animal, Animal animal1)
		{
			return animal.TypeCount != animal1.TypeCount;
		}



		public override string ToString()
		{
			return $"Animal are {TypeCount} types";
		}

		public override bool Equals(object obj)
		{
			return obj is Animal animal &&
				   TypeCount == animal.TypeCount &&
				   EqualityComparer<Animal[]>.Default.Equals(Type, animal.Type);
		}

		public override int GetHashCode()
		{
			return HashCode.Combine(TypeCount, Type);
		}

		public virtual AnimalFood Eat(AnimalFood food) 
		{
			return food;
		} 
	}
}
