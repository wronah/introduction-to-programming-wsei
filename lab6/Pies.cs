namespace lab6
{
    class Pies : Zwierzak, ILatanie, IPlywanie
    {
        public string rasa = string.Empty;
        public Pies()
        {
            
        }
        public Pies(string imiePsa)
        {
            imie = imiePsa;
        }
        public Pies(string imiePsa, string rasaPsa)
        {
            imie = imiePsa;
            rasa = rasaPsa;
        }
        public Pies(string imie, string rasa, int wiek, int waga)
        {
            this.imie = imie;
            this.rasa = rasa;
            this.wiek = wiek;
            this.waga = waga;
        }

        ~Pies()
        {

        }

        public override void DajGlos()
        {
            Console.WriteLine("Hauuuu");
        }

        public void Lataj()
        {
            Console.WriteLine("Latam");
        }

        public void Plywam()
        {
            Console.WriteLine("Plywam");
        }
    }
}
