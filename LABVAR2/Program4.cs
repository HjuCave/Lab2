using System;


namespace LABVAR2
{
    public class BioMaterial
    {
        public int age;
        public int mass;
        public int Age 
        { 
            get { return age; } 
            set { age = value; } 
        }
        public int Mass
        { 
            get { return mass; } 
            set { mass = value; } 
        }
        static public void Main ()
        {
            BioMaterial mat = new BioMaterial ();

            Console.WriteLine("Type an age of thou, creature. Full years.");
            mat.Age = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Thou weight in kg?");
            mat.Mass = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Let us see... Is that correct? \n Age = {0}\n Mass = {1}", mat.Age, mat.Mass);
            (mat.Mass, mat.Age) = (mat.Age, mat.Mass);
            Console.WriteLine("Or should i swap it? \n Age = {0}\n Mass = {1}", mat.Age, mat.Mass);

            Console.ReadKey();

        }
    }
}
