using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LABVAR9
{
    public class Sassic
    {
        protected int[] mv = new int[4];
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
        private float sum;
        public float Sum
        { 
            get 
            { 
                return sum; 
            } 
        }
        private float sred;
        public float Sred
        {
            get
            {
                return sred;
            }
        }
        private float temp = 0;
        public float Temp
        {
            get 
            { 
                return temp;
            }
        }
        public float temp1;
        public float temp2;
        float score;
        int ind;
        public void Write()
        {
            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine("Введите элемент массива под индексом {0}", i);
                mv[i] = int.Parse(Console.ReadLine());
            }
        }
        public void Count()
        {
            float[] arr = new float[4];
            for (int i = 0; i < 3; i++)
            {
                sum += mv[i];

            }
            sred = sum / 4;       // 1 4 7 2    14 / 4 = 3,5 --- mv[0] = 2,5  \   - mv[1] = [0,5]  \   - mv[2] = [3,5] \ - mv[3] = 1,5
            
            for (int i = 0; i < 4; i++)
            {
                for (int j=1; j<2; j++)
                {
                    temp1 = sred - mv[i];
                    temp2 = sred - mv[j];
                    if (temp1 > temp2)
                    {

                    }
                }
            }
            
            
            Console.WriteLine("Сумма = {0}", Sum);
            Console.WriteLine("Среднее = {0}", Sred);
            Console.WriteLine("Самое близкое = {0}, с индексом {1}", score, ind);
            Console.ReadKey();
        }
    }

    public class Sas
    {
        
        static void Main(string[] args)
        {
            Sassic sassic= new Sassic();
            sassic.Write();
            sassic.Count();
        }
    }
}
