using System;


namespace LABVAR5
{
	internal class Classic
	{
		protected int[] mv = new int[5];
		public int this[int j]
		{
			get
			{
				return mv[j];
			}
			set
			{
				mv[j] = value;
			}
		}
		public float sum;
		public float sred;
		public float sumread
		{
			get { return sum; }
		}

		public float sredread
		{
			get { return sred; }
		}
	}
	public class Counting
    {
		public void Count()
        {
			Classic obj = new Classic();
			for (int i = 0; i < 5; i++)
			{
				Console.WriteLine("Введите элемент массива под индексом {0}", i);
				obj[i] = int.Parse(Console.ReadLine());
			}
			for (int i = 0; i < 5; i++)
			{
				obj.sum = obj.sumread + obj[i];
			}
			obj.sred = obj.sum / 5;
			Console.WriteLine("Сумма = {0}", obj.sumread);
			Console.WriteLine("Среднее арифметическое = {0}", obj.sredread);
			Console.ReadKey();
		}
    }
	class Class
	{ 
        static void Main(string[] args)
        {
			Counting count = new Counting();
			count.Count();
        }
    }
}
