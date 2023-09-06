namespace ParaClub
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Plane plane = new Plane(0, 0);

            Console.CursorVisible = false;
            plane.Show();


            Console.ReadLine();
        }
    }
}