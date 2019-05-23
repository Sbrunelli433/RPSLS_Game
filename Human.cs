using System;
using System.Collections.Generic;
using System.Text;

namespace RPSLS_Game
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
            Console.WriteLine("Choose Gesture");
            gesture = Console.ReadLine();

          
        }

        public void P1GestureChoice()
        {
            Console.WriteLine("Choose Gesture");
            Console.ReadLine();

            

        }
        //public override void P2GestureChoice()
        //{
        //    base.DisplayGestureChoiceP2();

        //    Console.ReadLine();
        //}

    }
}
