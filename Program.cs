namespace Class_260221
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Cat cat_1 = new Cat(2, "FatF...", 6, "OrangeCat", "Orange", 60, 6, true, "Male");
            cat_1.Eating(80);
            cat_1.Sleeping();
            cat_1.WakeUp();
            cat_1.Eating(70);
            cat_1.Play();
            Console.WriteLine(cat_1);

            Console.WriteLine("\n------------------------------------------------------------\n");

            Cat cat_2 = new Cat(2, "Husi", 3, "Uhm...", "Gray", 70, 2, true, "Female");
            cat_2.Eating(50);
            cat_2.Sleeping();
            cat_2.WakeUp();
            cat_2.Eating(45);
            cat_2.Play();
            Console.WriteLine(cat_2);

            Console.WriteLine("\n------------------------------------------------------------\n");

            Cat cat_3 = new Cat(15, "Creative_catName_Cirmi", 5, "Uhm...", "Brown", 100, 4, true, "Male");
            cat_3.Eating(50);
            cat_3.Sleeping();
            cat_3.WakeUp();
            cat_3.Eating(45);
            cat_3.Play();
            Console.WriteLine(cat_3);
        }
    }
}
