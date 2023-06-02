using System;
namespace CSharpSandbox
{
	public class Person
	{
		public int ID;
		public int time;
		public bool crossed;

		public Person()
		{
			ID = 0;
			time = 0;
			crossed = false;
		}

		public Person(int number, int speedGiven)
		{
			ID = number;
			time = speedGiven;
			crossed = false;
		}
	}
}

