using System;


namespace LABVAR5
{
    internal class Classic
    {
		protected int[] mv = new int [5];
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
		public int sum;
		public int sred;
		public int sumread
        {
			get { return sum; }
        }
		
		public int sredread
        {
            get { return sredread; }
        }

        static void Main(string[] args)
        {
			Classic obj = new Classic();
			for (int i = 0; i < 5; i++)
            {
				obj.mv[i] = i;

            }
        }
    }
}
