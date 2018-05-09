namespace Lab5
{
    class MainClass
    {
        static void Main(string[] args)
        {
            Board b = new Board();
            b.Draw();
            while (true)
            {
                b.Move();
                System.Console.Clear();
                b.Draw();
            }
        }
    }
}