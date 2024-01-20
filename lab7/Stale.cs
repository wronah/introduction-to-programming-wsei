namespace lab7
{
    internal class Stale
    {
        public static double Pi = 3.14159267;
        public static double G = 9.81;

        public void PokazSingleton()
        {
            Console.WriteLine(Singleton.GetSingleton().a);
        }
    }
}
