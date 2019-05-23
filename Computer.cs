using System;
using System.Collections.Generic;
using System.Text;

namespace RPSLS_Game
{
    public class Computer : Player
    {

        // member variables (HAS A...)

        //Player Child Object


        // Constructor(spawner)
        public Computer(string name):base(name)
        {
            this.name = name;

        }

        // Member Methods (CAN DO...)
        //CAN DO RANDOM NUMBER GENERATOR FOR GESTURE CHOICE();

        public override void ChooseGesture()
        {
            Console.WriteLine("Choose Gesture");
            gesture = Console.ReadLine();

        }

        //public override void DisplayGestureChoiceP2()
        //{
        //    base.DisplayGestureChoiceP2();
        //    Console.ReadLine();

     
            

        //}
    }
}
