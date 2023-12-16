namespace lab6
{
    abstract class Zwierzak
    {
        public int waga;
        public int wiek;

        public string imie = string.Empty;

        public void PrzedstawSie()
        {
            Console.WriteLine(imie);
        }

        public abstract void DajGlos();
    }
}
