﻿using System;
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
                Console.WriteLine("please enter 1 or 2....This is Nevin-Proofed");
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
                Console.WriteLine("This is a single player game, press Enter to continue.");
                Console.ReadLine();
            }
            else if (numberOfPlayers == 2)
            {
                Player1 = new Human("Player1");
                Player2 = new Human("Player2");
                Console.WriteLine("This is a multi player game, press Enter to continue.");
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
            if(Player1.gesture == "rock" && Player2.gesture == "scissors")
            {
                Console.WriteLine("Player 1 wins!");
                Console.ReadLine();
                Player1.score++;
            }
            else if (Player1.gesture == "rock" && Player2.gesture == "lizard") 
            {
                Console.WriteLine("Player 1 wins!");
                Console.ReadLine();
                Player1.score++;
            }
            else if (Player1.gesture == "scissrs" && Player2.gesture == "paper") 
            {
                Console.WriteLine("Player 1 wins!");
                Console.ReadLine();
                Player1.score++;
            }
            else if (Player1.gesture == "scissors" && Player2.gesture == "lizard") 
            {
                Console.WriteLine("Player 1 wins!");
                Console.ReadLine();
                Player1.score++;
            }
            else if (Player1.gesture == "paper" && Player2.gesture == "rock") 
            {
                Console.WriteLine("Player 1 wins!");
                Console.ReadLine();
                Player1.score++;
            }
            else if (Player1.gesture == "paper" && Player2.gesture == "spock") 
            {
                Console.WriteLine("Player 1 wins!");
                Console.ReadLine();
                Player1.score++;
            }
            else if (Player1.gesture == "lizard" && Player2.gesture == "spock") 
            {
                Console.WriteLine("Player 1 wins!");
                Console.ReadLine();
                Player1.score++;
            }
            else if (Player1.gesture == "lizard" && Player2.gesture == "paper") 
            {
                Console.WriteLine("Player 1 wins!");
                Console.ReadLine();
                Player1.score++;
            }
            else if (Player1.gesture == "spock" && Player2.gesture == "scissors") 
            {
                Console.WriteLine("Player 1 wins!");
                Console.ReadLine();
                Player1.score++;
            }
            else if (Player1.gesture == "spock" && Player2.gesture == "rock") 
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
                Console.WriteLine("Player 2 wins!");
                Console.ReadLine();
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
                Console.WriteLine("Player1's score is" + " " + Player1.score + " " + "and Player2's score is " + " " + Player2.score + " " + "Please push enter to continue.");
                Console.ReadLine();
                Loop();
            }
        }
    }
}

