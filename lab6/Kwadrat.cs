namespace lab6
{
    internal class Kwadrat : IFigura
    {
        int a;
        public string PodajNazwe()
        {
            return "Kwadrat";
        }
        public void PodajDane()
        {
            Console.WriteLine("Podaj dlugosc boku");
            a = int.Parse(Console.ReadLine());
        }
        public void Pole()
        {
            Console.WriteLine(a * a);
        }
        public void Obwod()
        {
            Console.WriteLine(4 * a);
        }
    }
}
