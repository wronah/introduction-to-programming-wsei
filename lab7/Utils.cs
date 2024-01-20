namespace lab7
{
    internal class Utils
    {
        public static double Abs(double number)
        {
            if(number < 0)
            {
                return number * -1;
            }
            return number;
        }
    }
}
