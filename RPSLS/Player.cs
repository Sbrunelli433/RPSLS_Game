using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
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

        public void PlayerName()
        {
            Console.WriteLine("Enter your name");
            Console.ReadLine();
        }

        public abstract string ChooseGesture();


        //_______________________________-
        public void DisplayGestureChoice(string ChooseGesture)
        {
            
            Console.WriteLine($"{name}'s choice is " + gesture);
            Console.ReadLine();
            
        }
        public void DisplayComputerGestureChoice()
        {
            Console.WriteLine(Computer.ChooseGesture());
            Computer.ChooseGesture();

        }
        //CAN DO DISPLAY P2 GESTURE CHOICE();

        //public virtual void DisplayGestureChoiceP2()
        //    {
        //        Console.WriteLine("Player 2's choice is " + Human.P2GestureChoice());
        //    }
        //    //CAN DO DISPLAY COMPUTER GESTURE CHOICE();
        //}
        public void Player1Score()
        {
            int[] Player1Score = new int[2];
        }
        public void Player2Score()
        {
            int[] Player2Score = new int[2];
        }
    }

}
