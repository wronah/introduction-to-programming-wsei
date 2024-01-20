namespace lab7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Element e1 = new Element();
            Element e2 = new Element();
            Element e3 = new Element();
            e1.value = 1;
            e2.value = 2;
            e3.value = 3;

            e1.SetNext(e2);
            e2.SetNext(e3);
            e2.SetPrevious(e1);
            e3.SetPrevious(e2);

            Console.WriteLine(e1.next.value);

            e1.DeleteNext();

            Console.WriteLine(e1.next.value);

            Node ciuchy = new Node();
            Node meskie = new Node();
            Node damskie = new Node();
            Node buty = new Node();
            Node spodnie = new Node();

            meskie.AddChild(buty);
            meskie.AddChild(spodnie);
            ciuchy.AddChild(meskie);
            ciuchy.AddChild(damskie);

            Node doBiegania = new Node();
            Node doChodzenia = new Node();

            buty.AddChild(doBiegania);
            buty.AddChild(doChodzenia);

            Console.WriteLine(ciuchy.CountAncestors());

            Singleton s1 = Singleton.GetSingleton();
            s1.a = 123;

            Singleton s2 = Singleton.GetSingleton();

            Console.WriteLine(s1.a);
            Console.WriteLine(s2.a);

            Cyferka c1 = new Cyferka();
            Cyferka.a = 10;

            Cyferka c2 = new Cyferka();
            Cyferka.a = (int)(20 * Stale.Pi);

            Console.WriteLine(Cyferka.a);
            Console.WriteLine(Cyferka.a);

            double z = Utils.Abs(-10.0);

            Stale s11 = new Stale();
            s11.PokazSingleton();
        }
    }
}