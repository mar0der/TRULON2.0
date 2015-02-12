namespace GameEngine
{
    public class Engine
    {
        private int i = 0;
        public Engine()
        {
            
        }

        public void Init()
        {

        }

        public void Update()
        {
            System.Console.WriteLine(this.i++);
        }
    }
}
