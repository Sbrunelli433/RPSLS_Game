using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    public class Game
    {
        // member variables (HAS A...)

        Player Player1;
        Player Player2;

        public void RunGame()
        {
            int numberOfPlayers = GetNumberOfHumanPlayers();
            SetPlayers(numberOfPlayers);
            Loop();
        }


        public int GetNumberOfHumanPlayers()
        {
            Console.WriteLine("How many human players are there? 1 or 2?");
            int numberOfPlayers = int.Parse(Console.ReadLine());

            if (numberOfPlayers != 1 && numberOfPlayers != 2)
            {
                Console.WriteLine("please enter 1 or 2....NOTHING ELSE OR YOU'LL ALMOST KINDA BREAK THE GAME");
                GetNumberOfHumanPlayers();
            }
            return numberOfPlayers;
            
        }

        public void SetPlayers(int numberOfPlayers)
        {
            if (numberOfPlayers == 1)
            {
                Player1 = new Human("Player1");
                Player2 = new Computer("Player2");
                Console.WriteLine("This is a single player game");
                Console.ReadLine();
            }
            else if (numberOfPlayers == 2)
            {
                Player1 = new Human("Player1");
                Player2 = new Human("Player2");
                Console.WriteLine("This is a multi player game");
                Console.ReadLine();
            }

        }


        public void Loop()
        {
            MakeGestures();
            CompareGestures();
            DetermineGameWinner();


        }
        public void MakeGestures()
        {
            Player1.ChooseGesture();
            Player2.ChooseGesture();

        }

        public void CompareGestures()
        {
            if(Player1.gesture == "rock" && Player2.gesture == "Scissors")
            {
                Console.WriteLine("Player 1 wins!");
                Console.ReadLine();
                Player1.score++;
            }
            else if (Player1.gesture == "rock" && Player2.gesture == "Lizard") 
            {
                Console.WriteLine("Player 1 wins!");
                Console.ReadLine();

                Player1.score++;
            }
            else if (Player1.gesture == "Scissors" && Player2.gesture == "Paper") 
            {
                Console.WriteLine("Player 1 wins!");
                Console.ReadLine();

                Player1.score++;
            }
            else if (Player1.gesture == "Scissors" && Player2.gesture == "Lizard") 
            {
                Console.WriteLine("Player 1 wins!");
                Console.ReadLine();

                Player1.score++;
            }
            else if (Player1.gesture == "Paper" && Player2.gesture == "Rock") 
            {
                Console.WriteLine("Paper covers Rock! Player 1 wins!");
                Console.ReadLine();

                Player1.score++;
            }
            else if (Player1.gesture == "Paper" && Player2.gesture == "Spock") 
            {
                Console.WriteLine("Player 1 wins!");
                Console.ReadLine();

                Player1.score++;
            }
            else if (Player1.gesture == "Lizard" && Player2.gesture == "Spock") 
            {
                Console.WriteLine("Player 1 wins!");
                Console.ReadLine();

                Player1.score++;
            }
            else if (Player1.gesture == "Lizard" && Player2.gesture == "Paper") 
            {
                Console.WriteLine("Player 1 wins!");
                Console.ReadLine();

                Player1.score++;
            }
            else if (Player1.gesture == "Spock" && Player2.gesture == "Scissors") 
            {
                Console.WriteLine("Player 1 wins!");
                Console.ReadLine();

                Player1.score++;
            }
            else if (Player1.gesture == "Spock" && Player2.gesture == "Rock") 
            {
                Console.WriteLine("Player 1 wins!");
                Console.ReadLine();

                Player1.score++;
            }
            else if (Player1.gesture == Player2.gesture)
            {
                Console.WriteLine("both players have the same gesture, it is a tie!");
                Console.ReadLine();
            }
            else
            {
                Player2.score++;
            }
        }


        public void DetermineGameWinner()
        {
            if (Player1.score > 1)
            {
                Console.WriteLine("Player1 has won the match!");
                Console.ReadLine();
            }
            else if (Player2.score > 1)
            {
                Console.WriteLine("Player2 has won the match!");
                Console.ReadLine();
            }
            else if(Player1.score <= 1 && Player2.score <= 1)
            {
                Console.WriteLine("Player1's score is" + Player1.score + "and Player2's score is " + Player2.score);
                Loop();
            }
        }
    }
}

