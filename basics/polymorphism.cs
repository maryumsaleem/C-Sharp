using System;
namespace Base
{
	class Animal //base class
	{
		public virtual void animalSound()
		{
			Console.WriteLine("The animal makes a sound");
		}
	}
}
namespace child1
{
	class Cat: Base.Animal
	{
		public override void animalSound()
		{
			Console.WriteLine("MEOW,MEOW");
		}
	}
}

namespace child2
{
	class Dog: Base.Animal
	{
		public override void animalSound()
		{
				Console.WriteLine("BOW,WOW");
		}
	}
}
namespace MyApp
{
class program
{
	static void Main(string[] args)
	{
		Base.Animal myAnimal=new Base.Animal();
		Base.Animal myCat=new child1.Cat();
		Base.Animal myDog=new child2.Dog();
		
		myAnimal.animalSound();
		myCat.animalSound();
		myDog.animalSound();
	}
}
}