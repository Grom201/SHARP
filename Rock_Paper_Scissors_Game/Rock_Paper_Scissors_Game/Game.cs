using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Rock_Paper_Scissors_Game;


namespace Rock_Paper_Scissors_Game
{



    class Game
    {
       private int countWins = 0;
        private int countLoses = 0;
        private int countDraws = 0;
        public int youChoose;
      public int computerChoose;
       
        public  int ChooseTurn(int i)
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
        
            if ((youChoose == 1 & computerChoose == 2)|(youChoose == 2 & computerChoose == 3) |(youChoose == 3 & computerChoose == 1))
                countWins++;
            else if ((youChoose == 1 & computerChoose == 3)|(youChoose == 2 & computerChoose == 1)| (youChoose == 3 & computerChoose == 2))
                countLoses++;
            else if (youChoose == computerChoose )
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
