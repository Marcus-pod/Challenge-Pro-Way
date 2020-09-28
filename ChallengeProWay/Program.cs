using System;

namespace ChallengeProWay
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Informe o placar do jogo:");
            int scoreboard = int.Parse(Console.ReadLine());

            string newGame = "";
            int jogo = 1;
            int minSeason = scoreboard;
            int maxSeason = scoreboard;
            int minRecord = 0;
            int maxRecord = 0;

            while (newGame != "Nao")
            {
                Console.WriteLine("-----------------------------------------------------------------------------------------------------------------------------------");
                Console.WriteLine("|   Jogo    |   Placar    |   Mínimo da Temporada   |   Máximo da Temporada   |   Quebra recorde min.   |   Quebra recorde máx.   |");
                Console.WriteLine("-----------------------------------------------------------------------------------------------------------------------------------");
                Console.WriteLine("|     " + jogo + "     |     " + scoreboard + "      |           " + minSeason + "            |           "
                    + maxSeason + "            |             " + minRecord + "           |             " + maxRecord + "           |");
                Console.WriteLine("-----------------------------------------------------------------------------------------------------------------------------------");

                // cadastrando um novo jogo
                Console.WriteLine();
                Console.WriteLine("Deseja adicionar um novo jogo? (Sim/Nao)");
                newGame = Console.ReadLine();
                Console.WriteLine();

                if (newGame == "Sim")
                {
                    Console.WriteLine("Informe o placar do jogo:");
                    scoreboard = int.Parse(Console.ReadLine());

                }
                jogo++;

                // condição do Mínimo e Máximo da Temporada e Quebra Recorde
                if (scoreboard < minSeason)
                {
                    minSeason = scoreboard;
                    minRecord++;
                }
                else if (scoreboard > maxSeason)
                {
                    maxSeason = scoreboard;
                    maxRecord++;
                }
            }


            Console.ReadLine();
        }
    }
}