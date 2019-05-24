using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    public class Human : Player
    {
        // member variables (HAS A...)


        //PLAYER CHILD OBJECT

        // Constructor(spawner)

        // Member Methods (CAN DO...)

        //CAN DO INPUT GESTURE CHOICE();
        public Human(string name) : base(name)
        {
            this.name = name;
        }

        public override void ChooseGesture()
        {
            Console.WriteLine("Choose Gesture: Rock, Paper, Scissors, Lizard, or Spock");
            gesture = Console.ReadLine();
        }

    }


}
