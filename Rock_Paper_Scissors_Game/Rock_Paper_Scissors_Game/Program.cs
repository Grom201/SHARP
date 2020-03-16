using System;

namespace Rock_Paper_Scissors_Game
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How round`s you want play?");
            
            int countRoounds =0;
           int  rounds =Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Choose you turn \nRock=1 \nScissors = 2 \nPaper = 3");

           
            Game player1 = new Game();
            do
            {
                
                int Turn = Convert.ToInt32(Console.ReadLine());
                player1.ChooseTurn(Turn);
                Console.WriteLine($"you turn ={(Enum.Variant)Turn}");
                player1.Play();
                Console.WriteLine($"Computer turn ={(Enum.Variant)player1.computerChoose}\n");
             
                countRoounds++;
            }
            while (countRoounds < rounds);
            player1.CountRounds();
        }
    }
}
