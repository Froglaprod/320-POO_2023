namespace ParaClub
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Plane plane = new Plane(0, 0);

            Console.CursorVisible = false;
            Console.SetWindowSize(Config.SCREEN_WIDTh, Config.SCREEN_HEIGHT);
            plane.Show();

            while (true)
            {
                Console.Clear();
                plane.mooveRight();

                plane.Show();
                Thread.Sleep(100);
            }
        }
    }
}