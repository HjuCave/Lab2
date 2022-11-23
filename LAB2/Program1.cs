using System;


namespace ConsoleApplication12
{
	class Cmin
	{
		public static int Min(int x, int y)
		{
			int z = (x < y) ? x : y;
			return z;
		}
		public static int Minabs(ref int x, ref int y)
		{
			x = (x < 0) ? -x : x;
			y = (y < 0) ? -y : y;
			int z = (x < y) ? x : y;
			return z;
		}
	}
	class Class1
	{
		[STAThread]
		static void Main(string[] args)
		{
			int a = -4;
			int b = 2;
			Console.WriteLine("a={0}  b={1}", a, b);
			int k = Cmin.Min(a, b);
			Console.WriteLine("a={0}  b={1}", a, b);
			Console.WriteLine("k=" + k);
			k = Cmin.Minabs(ref a, ref b); 
			Console.WriteLine("a={0}  b={1}", a, b);
			Console.WriteLine("k=" + k);
			Console.ReadKey();
		}
		
	}
}

