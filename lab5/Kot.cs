namespace lab5
{
    internal class Kot : Zwierz
    {

        public void SetWiek(int wiekKota)
        {
            if(wiekKota > 0 && wiekKota < 100)
            {
                wiek = wiekKota;
            }
        }
        public int PodajWiek()
        {
            return wiek;
        }

        public override void DajGlos()
        {
            Console.WriteLine("Miauuuu");
        }
    }
}
