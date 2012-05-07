using System;
using System.Linq;

class Problem1
{
	static void Main(string[] args)
	{
		Console.WriteLine(Enumerable.Range(1, 999).Where(x => x % 3 == 0 || x % 5 == 0).Sum());
	}
}
