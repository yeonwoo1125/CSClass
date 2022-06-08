namespace CSClass
{
    class SingleTon
    {
        static private SingleTon instance = null;
        private SingleTon()
        {
        }

        public static SingleTon getInstance() 
        {
            if (SingleTon.instance == null)
            {
                instance = new SingleTon(); 
            }
            return instance;
        }
    }
}