namespace lab6
{
    internal class Kot : Zwierzak, IPlywanie
    {
        int iloscPazurow;

        public Kot()
        {
            Console.WriteLine("Rodzi sie nowy kot");
        }

        public override void DajGlos()
        {
            Console.WriteLine("Miauuuu");
        }

        public void Plywam()
        {
            Console.WriteLine("Plywam");
        }
    }
}
