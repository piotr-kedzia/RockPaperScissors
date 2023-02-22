using System.Runtime.Intrinsics.Arm;
using System.Runtime.Versioning;

namespace RockPaperScissorsApp
{
    internal class Program
    {
        static void Main()
        {
            RockPaperScissors Game = new RockPaperScissors();

            Console.WriteLine("Doszedłeś do końca programu, dziękuje za odpalenie gry");
        }
    }


    class RockPaperScissors
    {
        private string PlayerOne = " ";
        public string GetPlayerOne() { return PlayerOne; }
        public void SetPlayerOne()
        {
            Console.WriteLine("Kamień/Papier/Nożyce\n--------------------------\n");
            Console.WriteLine("Gracz 1:\nPodaj symbol który wybierasz:\np - Papier\nk - Kamień\nn - Nożyce");
            PlayerOne = Console.ReadLine().ToLower(); Console.Clear();
        }
        Random rnd = new Random();
        public int random;
        private string PlayerTwo = " ";
        public string GetPlayerTwo()
        {
            return PlayerTwo;
        }
        public void SetPlayerTwo()
        {
            Console.WriteLine("Kamień/Papier/Nożyce\n--------------------------\nGra 2-osobowa");
            Console.WriteLine("Gracz 2:\nPodaj symbol który wybierasz:\np - Papier\nk - Kamień\nn - Nożyce");
            PlayerTwo = Console.ReadLine().ToLower(); Console.Clear();
        }

        public void SetPlayerThree()
        {
            random = rnd.Next(1, 4);
            if (random == 1) { PlayerTwo = "k"; }
            else if (random == 2) { PlayerTwo = "p"; }
            else if (random == 3) { PlayerTwo = "n"; }
        }

        public void LogicRPSConsole()
        {
            if (PlayerOne == "p" && PlayerTwo == "k")
            { //----------------------------------------------------    PAPIER  V  KAMIEŃ    ---------------------------------------------------------
                Console.WriteLine("     ________     \t        _______      \n" +
                              "____/    ____)_____   \t     __/____    =_____\n" +
                              "            ________) \t   (_____| ) \n" +
                              "            _________)\t  (_______| )     ==\n" +
                              "           ________)  \t   (_____| )   /______\n" +
                              "---.____________)     \t      (___|)_/\n");
                Console.WriteLine("Gracz 1 Wygrał!");
            }
            else if (PlayerOne == "p" && PlayerTwo == "n")
            { //----------------------------------------------------    PAPIER  V  NOŻYCE    ---------------------------------------------------------
                Console.WriteLine("     ________     \t          ______\n" +
                              "____/    ____)_____   \t   _____(___     \\_____\n" +
                              "            ________) \t (______    \\_\n" +
                              "            _________)\t(___________\n" +
                              "           ________)  \t       (____)     _____\n" +
                              "---.____________)     \t         (___)__.-\n");
                Console.WriteLine("Gracz 2 Wygrał!");
            }
            else if (PlayerOne == "p" && PlayerTwo == "p")
            { //----------------------------------------------------    PAPIER  V  PAPIER    ---------------------------------------------------------
                Console.WriteLine("     ________     \t           ________\n" +
                              "____/    ____)_____   \t     _____(____    \\____\n" +
                              "            ________) \t   (________\n" +
                              "            _________)\t  (_________\n" +
                              "           ________)  \t   (________\n" +
                              "---.____________)     \t       (____________.---\n");
                Console.WriteLine("Remis!");
            }
            else if (PlayerOne == "k" && PlayerTwo == "k")
            { //----------------------------------------------------    KAMIEŃ  V  KAMIEŃ    ---------------------------------------------------------
                Console.WriteLine("" +
                    "      _______        \t        _______      \n" +
                    "_____/   ____\\__    \t     __/____    =_____\n" +
                    "        /( |_____)   \t   (_____| ) \n" +
                    "  ==     ( |______)  \t   (______| )     ==\n" +
                    "       \\ ( |_____)  \t    (_____| )   /______\n" +
                    " ----.__( |___)      \t      (___|)_/\\n");
                Console.WriteLine("Remis!");
            }
            else if (PlayerOne == "k" && PlayerTwo == "n")
            { //----------------------------------------------------    KAMIEŃ  V  NOŻYCE    ---------------------------------------------------------
                Console.WriteLine("" +
                    "      _______        \t           ______\n" +
                    "_____/   ____\\__    \t   _____(___     \\_____\n" +
                    "        /( |_____)   \t (______    \\_\n" +
                    "  ==     ( |______)  \t(___________\n" +
                    "       \\ ( |_____)  \t       (____)     _____\n" +
                    " ----.__( |___)      \t         (___)__.-\n");
                Console.WriteLine("Gracz 1 Wygrał!");
            }
            else if (PlayerOne == "k" && PlayerTwo == "p")
            { //----------------------------------------------------    KAMIEŃ  V  PAPIER    ---------------------------------------------------------
                Console.WriteLine("" +
                    "      _______        \t           ________\n" +
                    "_____/   ____\\__    \t    ______(____    \\____\n" +
                    "        /( |_____)   \t  (_________\n" +
                    "  ==     ( |______)  \t (__________\n" +
                    "       \\ ( |_____)  \t   (_________\n" +
                    " ----.__( |___)      \t      (_____________.---\n");
                Console.WriteLine("Gracz 2 Wygrał!");
            }
            else if (PlayerOne == "n" && PlayerTwo == "k")
            { //----------------------------------------------------    NOŻYCE  V  KAMIEŃ    ---------------------------------------------------------
                Console.WriteLine("" +
                    "       _______         \t         _______      \n" +
                    " _____/   ____)_____   \t     __/____    =_____\n" +
                    "        _/     ______) \t   (_____| ) \n" +
                    "  ==      ____________)\t  (_______| )     ==\n" +
                    " ____   (_]___)        \t   (_____| )   /______\n" +
                    "     -._(_]__)         \t      (___|)_/\n");

                Console.WriteLine("Gracz 2 Wygrał!");
            }
            else if (PlayerOne == "n" && PlayerTwo == "n")
            { //----------------------------------------------------    NOŻYCE  V  NOŻYCE    ---------------------------------------------------------
                Console.WriteLine("" +
                    "       _______          \t          _______\n" +
                    " _____/   ____)______   \t   ______(___     \\_____\n" +
                    "        _/    ._______) \t (_______.    \\_\n" +
                    "  ==      ____.________)\t(________.____\n" +
                    " ____   (_]___)         \t       (___[_)     _____\n" +
                    "     -._(_]__)          \t        (__[_)__.-\n");

                Console.WriteLine("Remis!");
            }
            else if (PlayerOne == "n" && PlayerTwo == "p")
            { //----------------------------------------------------    NOŻYCE  V  PAPIER    ---------------------------------------------------------
                Console.WriteLine("" +
                    "       _______         \t           ________\n" +
                    " _____/   ____)_____   \t    ______(____    \\____\n" +
                    "        _/     ______) \t  (_________\n" +
                    "  ==      ____________)\t (__________\n" +
                    " ____   (_]___)        \t   (_________\n" +
                    "     -._(_]__)         \t      (_____________.---\n");

                Console.WriteLine("Gracz 1 Wygrał!");

            }
        }
        public RockPaperScissors()
        {
            for (; ; )
            {
                Console.Clear();
                Console.WriteLine("Witaj w grze Kamień/Papier/Nożyce!\n--------------------------\nGra 2 osoba? czy z komputerem?\n1. Dwu osobowa\n2. Z komputerem ");
                int sign = int.Parse(Console.ReadLine());
                {
                    switch (sign)
                    {
                        case 1:
                            {
                                for (; ; )
                                {
                                    SetPlayerOne();
                                    SetPlayerTwo();
                                    LogicRPSConsole();

                                    Console.WriteLine("Chcesz zagrać w dwie osoby jeszcze raz?: y/n");
                                    string odp = Console.ReadLine().ToLower();
                                    if (odp == "n") break;
                                }
                            }
                            break;
                        case 2:
                            {
                                for (; ; )
                                {
                                    SetPlayerOne();
                                    SetPlayerThree();
                                    LogicRPSConsole();

                                    Console.WriteLine("Chcesz zagrać z komputerem jeszcze raz?: y/n");
                                    string odp = Console.ReadLine().ToLower();
                                    if (odp == "n") break;
                                }
                                break;
                            }

                    }
                    

                }
                Console.WriteLine("Chcesz zostać?: y/n");
                string odp1 = Console.ReadLine().ToLower();
                if (odp1 == "n") break;
            }

        }

    }

}