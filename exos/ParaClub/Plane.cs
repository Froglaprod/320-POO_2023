namespace ParaClub
{
    internal class Plane
    {
        private int x;
        private int y;
        private string[] PLANE =
        {
            @" _                         ",
            @"| \                        ",
            @"|  \       ______          ",
            @"--- \_____/  |_|_\____  |  ",
            @"  \_______ --------- __>-} ",
            @"        \_____|_____/   |  "
        };


        public Plane(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public void Show()
        {
           for(int i = 0; i < PLANE.Length; i++)
            {
                Console.SetCursorPosition(x, y + i);
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine(PLANE[i]);
            }
               
            
        }

        public void mooveRight()
        {
            Console.SetCursorPosition(x + 1, y);
            x++;
            
            if( x == Console.WindowWidth - 2)
            {
                x = 0;
            }
        }
    }
}
