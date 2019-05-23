using System;
using System.Collections.Generic;
using System.Text;

namespace RPSLS_Game
{
    class Game
    {
        // member variables (HAS A...)
        //has a PVP
        //public string playerVersusPlayer;
        //HAS A P1 SCORE
        //public int player1Score;
        Player Player1;
        Player Player2;

        //HAS A P2 SCORE
        //public int player2Score;
        //Computer computer = new Computer();


        // Constructor(spawner)
        //ALWAYS HAS PVP;
        //public Game(string playerVersusPlayer, int player1Score, int player2Score)
        //{
        //this.playerVersusPlayer = playerVersusPlayer;
        //this.player1Score = player1Score;
        //this.player2Score = player2Score;




        //}

        // Member Methods (CAN DO...)
        //CAN DO  MASTER RUN FUNCTION();
        //PICK PLAYER();

        //public abstract void RunGame()
        //{

        //}

        public int GetNumberOfHumanPlayers()
        {
            Console.WriteLine("how many human players are there?");
            int numberOfPlayers = int.Parse(Console.ReadLine());
            return numberOfPlayers;
        }
        public void SetPlayers(int numberOfPlayers)
        {
            if(numberOfPlayers == 1)
            {
                Player1 = new Human("Player1");
                Player2 = new Computer("Player2");
            }
            else if(numberOfPlayers == 2)
            {
                //Player_1 = new Human("Player1");
                //Player_2 = new Human("Player2");
            }
           
        }

        //public void DisplayStuff()
        //{
        //    Player1.DisplayGestureChoice();
        //    Player2.DisplayGestureChoice();
        //}
        //public void MakeGestures()
        //{
            //player1.ChooseGesture();
            //player2.ChooseGesture();
        //}
       
            //for loop the following
                //Player choose gestures();
                //Compare Gestures ();
                    //P1 GESTURE CHOICE(); FROM PLAYER OBJECT
              
                        //Player.DisplayGestureChoiceP1();


                    //P2 GESTURE CHOICE(); FROM PLAYER OBJECT
                        //player2.DisplayGestureChoiceP2();

        //Determine Victory();
        //SWITCH CASE THROUGH LIST<T> OPTIONS FOR WIN(); FROM PLAYER OBJECT
        //IF P1 WINS
        //{
        //STORE P1 SCORE ++
        //}
        //BREAK;
        //IF P2 WINS
        //{
        //STORE P2 SCORE ++
        //}
        //BREAK;
        //Check Victory();
        //IF INT P1SCORE = 2
        //{
        //P1 WINS
        //}
        //BREAK;
        //IF P1 WINS
        //{
        //PROMPT TO RESTART GAME
        //}
        //BREAK;
        //IF INT P2SCORE = 2
        //{
        //P2 WINS
        //}
        //BREAK;
        //IF P2 WINS
        //{
        //PROMPT TO RESTART GAME
        //}
        //BREAK;
        //DEFAULT....RESTART LOOP;

        //
        //
    }
}
