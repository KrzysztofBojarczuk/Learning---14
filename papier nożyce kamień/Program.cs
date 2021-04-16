using System;

namespace papier_nożyce_kamień
{
    class Program
    {
        static void Main(string[] args)
        {
            string CPU;

            bool playAgain = true;

            while (playAgain)
            {

                int scorePlayer = 0;
                int scoreCPU = 0;

                while (scorePlayer < 3 && scoreCPU < 3)
                {


                    Console.WriteLine("Wybierz papier, nożyce, kamień");
                    string inputUser = Console.ReadLine();

                    Random rand = new Random();
                    int i = rand.Next(1, 3);

                    switch (i)
                    {
                        case 1:
                            CPU = "kamień";
                            Console.WriteLine("A.I. wybrało kamień");
                            if (inputUser == "kamień")
                            {
                                Console.WriteLine("Remis!\n\n");
                            }
                            else if (inputUser == "papier")
                            {
                                Console.WriteLine("Wygrał gracz!\n\n");
                                scorePlayer++;
                            }
                            else if (inputUser == "nożyce")
                            {
                                Console.WriteLine("A.I. wygrało!\n\n");
                                scoreCPU++;
                            }
                            break;
                        case 2:
                            CPU = "papier";
                            Console.WriteLine("A.I. wybrało papier");
                            if (inputUser == "papier")
                            {
                                Console.WriteLine("Remis!\n\n");
                            }
                            else if (inputUser == "kamień")
                            {
                                Console.WriteLine("A.I. Wygrało!\n\n");
                                scorePlayer++;
                            }
                            else if (inputUser == "nożyce")
                            {
                                Console.WriteLine("Wygrał gracz!\n\n");
                                scoreCPU++;
                            }
                            break;
                        case 3:
                            CPU = "nożyce";
                            Console.WriteLine("A.I. wybrało nożyce");
                            if (inputUser == "nożyce")
                            {
                                Console.WriteLine("Remis!\n\n");
                            }
                            else if (inputUser == "kamień")
                            {
                                Console.WriteLine("Wygrał gracz!\n\n");
                                scorePlayer++;
                            }
                            else if (inputUser == "papier")
                            {
                                Console.WriteLine("A.I. wygrało!\n\n");
                                scoreCPU++;
                            }
                            break;
                        default:
                            Console.WriteLine("Złe dane wejściowe.");
                            break;
                    }
                    Console.WriteLine("\n\nSCORES:\tA.I.:\t{0}\tGracz:\t{1}", scorePlayer, scoreCPU);
                }
                if (scorePlayer == 3)
                {
                    Console.WriteLine("Wygrał gracz");
                }
                else if (scoreCPU == 3)
                {
                    Console.WriteLine("Wygrało A.I.");
                }
                Console.WriteLine("Czy chesz zagrać ponownie?(y/n)");
                string loop = Console.ReadLine();
                if (loop == "y")
                {
                    playAgain = true;
                    Console.Clear();
                }
                else if (loop == "n")
                {
                    playAgain = false;
                }
            }
        }
    }
}
