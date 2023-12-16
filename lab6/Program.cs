namespace lab6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IFigura[] figury = { new Kwadrat(), new Prostokat(), new Trojkat() };

            Console.WriteLine("Ktora figura");
            
            for(int i = 0; i < figury.Length; i++) 
            {
                Console.WriteLine(i+1 + " - " + figury[i].PodajNazwe());
            }

            int decyzja = int.Parse(Console.ReadLine());    
            IFigura figura = figury[decyzja-1];
            

            figura.PodajDane();
            Console.WriteLine("Co chcesz zrobic");
            Console.WriteLine("1 - pole");
            Console.WriteLine("2 - obwod");
            string obliczenia = Console.ReadLine();
            if(obliczenia =="1") 
            {
                figura.Pole();
            }
            if(obliczenia =="2") 
            {
                figura.Obwod();
            }
        }
    }
}
