using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    public class Computer : Player
    {
        // member variables (HAS A...)

        Random random;


        // Constructor(spawner)
        public Computer(string name) : base(name)
        {
            this.name = name;
            random = new Random();
        }

        // Member Methods (CAN DO...)
        //CAN DO RANDOM NUMBER GENERATOR FOR GESTURE CHOICE();

        public override string ChooseGesture()
        {

            int roll = random.Next(0, 4);

            switch(roll)
            {
                case 0:
                    gesture = "rock";
                    break;
                case 1:
                    gesture = "Paper";
                    break;
                case 2:
                    gesture = "Scissors";
                    break;
                case 3:
                    gesture = "Lizard";
                    break;
                case 4:
                    gesture = "Spock";
                    break;
            }
            Console.WriteLine("Player2 chose " + gesture + ". Press enter to continue.");
            Console.ReadLine();
            return gesture;

        }




        //public override void DisplayGestureChoiceP2()
        //{
        //    base.DisplayGestureChoiceP2();
        //    Console.ReadLine();




        //}
    }
}
