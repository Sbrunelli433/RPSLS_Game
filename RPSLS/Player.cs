using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    public abstract class Player
    {
        public int score;
        public string name;
        public string gesture;
        public List<string> gestures;

        public Player(string name)
        {
            this.gestures = new List<string>();
            gestures.Add("Rock");
            gestures.Add("Paper");
            gestures.Add("Scissors");
            gestures.Add("Lizard");
            gestures.Add("Spock");
        }

        public void PlayerName()
        {
            Console.WriteLine("Enter your name");
            Console.ReadLine();
        }

        public abstract string ChooseGesture();

        public void DisplayGestureChoice()
        {
            Console.WriteLine($"{name}'s choice is " + gesture);
            Console.ReadLine();
        }
    }
}
