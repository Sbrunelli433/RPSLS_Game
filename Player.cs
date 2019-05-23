using System;
using System.Collections.Generic;
using System.Text;

namespace RPSLS_Game
{
    public abstract class Player
    {

        // member variables (HAS A...)
        //Player Score
        public int score;
        //HAS A STRING NAME
        public string name;
        //HAS A GESTURE
        public string gesture;
        //HAS A LIST<T> STRING
        public List<string> gestures;


        // Constructor(spawner)
        //ALWAYS HAS LIST<T> STRING GESTURE OPTIONS

        public Player(string name)
        {
           

            

            this.gestures = new List<string>();
            gestures.Add("Rock");
            gestures.Add("Paper");
            gestures.Add("Scissors");
            gestures.Add("Lizard");
            gestures.Add("Spock");
        }







        // Member Methods (CAN DO...)

        //CAN DO DISPLAY P1 GESTURE CHOICE();
        public abstract void ChooseGesture();



        public void PlayerName()
        {
            Console.ReadLine();

        }


        //_______________________________-
        public void DisplayGestureChoice()
        {
            Console.ReadLine();
            Console.WriteLine($"{name}'s choice is " + gesture);
        }
        //CAN DO DISPLAY P2 GESTURE CHOICE();

        //public virtual void DisplayGestureChoiceP2()
        //    {
        //        Console.WriteLine("Player 2's choice is " + Human.P2GestureChoice());
        //    }
        //    //CAN DO DISPLAY COMPUTER GESTURE CHOICE();
        //}
    }
}
