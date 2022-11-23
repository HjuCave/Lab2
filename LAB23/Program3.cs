using System;

namespace ConsoleApplication13
{
	class Rmas
	{
		protected float[] msf = new float[10];
		public float this [int j]
		{
			get
			{
				return msf[j];
			}
			set
			{
				msf[j] = value;
			}
		}
	}
	class Class1
	{
		static void Main()
		{
			Rmas obj = new Rmas();
			for (int i = 0; i < 10; i++)
			{
				obj[i] = 1.5f * i;   // это СЭТ и он устнавливает значение МСФу, индекс же одинаков для i и j
			}
			for (int i = 0; i < 10; i++)
			{
				Console.WriteLine( obj[i] );
			}
			Console.ReadKey();
		}
	}
}

