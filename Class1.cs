using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fact
{
	class class1
	{
		static void Main(string[] args)
		{
			Console.Write("Enter range:");
			int num = int.Parse(Console.ReadLine());
			for (int i = num; i >= 1; i--)
			{
				Console.WriteLine(i);
			}
			Console.ReadLine();
		}

	}
}
