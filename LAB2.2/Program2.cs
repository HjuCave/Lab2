using System;


namespace ConsoleApplication11
{
	class CStatic
	{
		private int m = 35;
		public int Y
		{
			get
			{
				return m;  // когда обращаюсь к ИГРИКУ, то он возвращает значение поля ЭМ
				            
			}			    
			set			   
			{			   
				m = value; // когда устанавливаю значение ИГРИКУ извне, то устанавливаю значение полю ЭМ
			}
		}
	}
	class Class1
	{
		[STAThread]
		static void Main(string[] args)
		{
			CStatic p = new CStatic();//создается экземпляр класса
			Console.WriteLine("{0}", p.y);
			p.Y = 75;
			int z = p.Y;
			Console.WriteLine("{0}", z);
			Console.ReadKey();
		}
	}
}


