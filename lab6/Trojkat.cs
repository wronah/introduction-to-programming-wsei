namespace lab6
{
    internal class Trojkat : IFigura
    {
        int a, h;
        public string PodajNazwe()
        {
            return "Trojkat";
        }
        public void PodajDane()
        {
            Console.WriteLine("Podaj dlugosc boku");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("Podaj dlugosc wysokosci");
            h = int.Parse(Console.ReadLine());
        }
        public void Pole()
        {
            Console.WriteLine(a * h / 2);
        }
        public void Obwod()
        {
            Console.WriteLine(3 * h);
        }
    }
}
