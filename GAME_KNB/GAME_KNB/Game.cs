using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GAME_KNB;


namespace GAME_KNB
{



    class Game
    {
        int countWins = 0;
        int countLoses = 0;
        int countDraws = 0;

        static int youChoose;

      public  static int computerChoose;
      


    
        
        public static int Choose(int i)
        {
            switch (i)
            {
                case 3:
                    computerChoose = Random();
                    youChoose = (int)Enum.Variant.Paper;
                    break;
                case 1:
                    computerChoose = Random();
                    youChoose = (int)Enum.Variant.Rock;
                    break;
                case 2:
                    computerChoose = Random();
                    youChoose = (int)Enum.Variant.Scissors;
                    break;
            }
            return youChoose;
        }

        public void Play()
        {
        
            if (youChoose == 1 & computerChoose == 2)
                countWins++;
            else if (youChoose == 1 & computerChoose == 3)
                countLoses++;
            else if (youChoose == 1 & computerChoose == 1)
            {
                countDraws++;
            }

            if (youChoose == 2 & computerChoose == 3)
                countWins++;
            else if (youChoose == 2 & computerChoose == 1)
                countLoses++;
            else if (youChoose == 2 & computerChoose == 2)
            {
                countDraws++;
            }
            if (youChoose == 3 & computerChoose == 1)
            {
                countWins ++;
            }
            else if (youChoose == 3 & computerChoose == 2)
            { 
            countLoses++;
        }
            else if (youChoose == 3 & computerChoose == 3)
            {
                countDraws++;
            }

           // Console.WriteLine($"Wins= {countWins}\nLoses = {countLoses}\nDraws= {countDraws}");
       }
        public void CountRounds()
        {
            Console.WriteLine($"Wins= {countWins}\nLoses = {countLoses}\nDraws= {countDraws}");
        }



        public static int Random()
        {
            Random random = new Random();
            int r = random.Next(1,4);
            return r;
        }
    }
}
