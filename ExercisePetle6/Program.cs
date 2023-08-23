namespace ExercisePetle6
{
    class Program
    {
        private static void Main(string[] args)
        {
            double a = 0;

            //Calculation         
            for (double i = 1; i <= 20; i++)
            {
                a = a + 1/i;
            }
            Console.WriteLine(a);
        }
    }
}
