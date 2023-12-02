namespace lab5
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Liczba l1 = new Liczba();
            l1.wartosc = 10;
            Liczba l2 = l1;
            l1.wartosc = 10;

            Console.WriteLine(l1.wartosc);
            Console.WriteLine(l2.wartosc);

            Console.WriteLine("Hello, World!");

            int a = 5;
            int b = a;

            a = 10;

            Kot koteczek = new Kot();
            koteczek.DajGlos();

            Kot koteczek1 = new Kot();
            Console.WriteLine(koteczek1.waga);
            koteczek1.waga = -20;
            koteczek1.SetWiek(10);
            Console.WriteLine(koteczek1.waga);
            Zwierz koteczek11 = new Kot();
            koteczek11.DajGlos();
        }
    }
}