using System;
namespace Base
{
	abstract class Animal
	{
		public abstract void animalSound();//abstract method does not have a body
		public void sleep()//regular method
		{
			Console.WriteLine("Zzz");
		}
	}
}
namespace child
{
	class Cat: Base.Animal
	{
		public override void animalSound()
		{
			Console.WriteLine("meow meow");
		}
	}
}
namespace myApp
{
	class main{
	static void Main(string[] args)
	{
		 child.Cat myCat=new child.Cat();
		 myCat.animalSound();
		 myCat.sleep();
	}
}
}