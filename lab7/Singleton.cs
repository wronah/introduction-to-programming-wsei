namespace lab7
{
    internal class Singleton
    {
        static Singleton instance;
        public int a;
        public static Singleton GetSingleton()
        {
            if(instance == null)
            {
                instance = new Singleton();
            }
            return instance;
        }
        private Singleton()
        {
            
        }
    }
}
