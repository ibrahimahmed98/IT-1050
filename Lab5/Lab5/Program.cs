namespace Lab5
{
    class MainClass
    {
        static void Main(string[] args)
        {
            Board a = new Board();
            a.Draw();
            while (true)
            {
                a.Move();
                System.Console.Clear();
                a.Draw();
            }
        }
    }
}