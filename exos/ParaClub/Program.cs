namespace ParaClub
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Plane plane = new Plane(0, 0);
            List<Para> planes = new List<Para>();
            Para Bob = new Para();
            Para Bob1 = new Para();
            Para Bob2 = new Para();

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