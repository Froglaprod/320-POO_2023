namespace Exo_snail
{
    internal class Program
    {
       
            
   
        static void Main(string[] args)
        {
            int hp = 50;
            int hpdeplacement = 1;
            int i = 0;
            int positionx  = 10;
            string snail0 = "_@_ö";
            string snail1 = "____";

            Console.ForegroundColor = ConsoleColor.DarkBlue;
            do
            {
                for (i = 0; i < hp; i++)
                {
                    Console.CursorVisible = false; 
                    Console.Clear();
                    Console.SetCursorPosition(i, positionx);
                    Console.WriteLine(snail0);
                    hp -=hpdeplacement;
                    Thread.Sleep(200);
                }

                
            } while (hp < 0);
            Console.Clear();
            Console.SetCursorPosition(i, positionx);
            Console.WriteLine(snail1);
        }
        
    }
}