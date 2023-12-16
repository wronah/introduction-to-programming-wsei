namespace lab6
{
    internal class Prostokat : IFigura
    {
        int a;
        int b;
        public string PodajNazwe()
        {
            return "Prostokat";
        }
        public void PodajDane()
        {
            Console.WriteLine("Podaj dlugosc boku a");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("Podaj dlugosc boku b");
            b = int.Parse(Console.ReadLine());
        }
        public void Pole()
        {
            Console.WriteLine(a*b);
        }
        public void Obwod()
        {
            Console.WriteLine(2*a + 2*b);
        }
    }
}
